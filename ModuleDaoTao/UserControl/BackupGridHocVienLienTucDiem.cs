using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NETLINK.UI;
using NETLINK.LIB;
using ModuleDaoTao.UI;
using ModuleDaoTao.LIB;
using Authoration.LIB;
using DanhMuc.LIB;
using ExportLib;

namespace ModuleDaoTao.UserControls
{
    public partial class BackupGridHocVienLienTucDiem : UsDictionary
    {
        #region variables
        
        private FormMode formMode = new FormMode();
        private int selectedID = -1;

        private int Mode; // da dong hoc phi hay chua

        #endregion

        public BackupGridHocVienLienTucDiem(int mode)
        {
            this.Mode = mode;
           
            InitializeComponent();
            RadGrid = radGridView1;
            STT();
            SaveToNew();
            //PrintToShow();

            if (this.Mode == DT_Common.DIEM_THEOLOP)
            {
                radLabelChonLop.Visible = true;
                dropDownLopHocLienTuc1.Visible = true;
            }
            else
            {
                radLabelChonLop.Visible = false;
                dropDownLopHocLienTuc1.Visible = false;
            }
        }
        #region Override

        public override object GetIdValue()
        {
            if (Mode == DT_Common.DIEM_THEOLOP)
                return TextMessages.ControlID.DT_HocVienLienTuc_DiemTheoLop;
            else
                return TextMessages.ControlID.DT_HocVienLienTuc_DiemKemCap;
        }

        public override string ToString()
        {
            if (Mode == DT_Common.DIEM_KEMCAP)
                return TextMessages.FormTitle.DT_HocVienLienTuc_DiemKemCap;
            else
                return TextMessages.FormTitle.DT_HocVienLienTuc_DiemTheoLop;
        }

        protected override void ApplyAuthorizationRules()
        {
            // nếu có được quyền tối thiểu thì cho phép vào form
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_QuanLyDiem_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_QuanLyDiem_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_QuanLyDiem_Delete);
        }

        protected override void Save()
        {
            formMode.IsInsert = true;
            Form_LT_HocVienLienTuc fr = new Form_LT_HocVienLienTuc(formMode);
            fr.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            dropDownLopHocLienTuc1.FillData();
            try
            {
                bl_btnDelete = false;
                bl_btnPrint = false;
                bl_btnSave = false;
                if (!GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_QuanLyDiem_View))
                {
                    bl_btnDelete = false;
                    bl_btnPrint = false;
                    bl_btnSave = false;
                    throw new Exception(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
                }
                else
                {
                    BusinessFunction function = null;
                    if (Mode == DT_Common.DIEM_THEOLOP)
                    {
                        function = new BusinessFunction(BusinessFunctionMode.GetDataForGridViewTheoLop);
                        function.Item = null;
                    }
                    else
                    {
                        function = new BusinessFunction(BusinessFunctionMode.GetDataForGridViewKemCap);
                    }
                    //Nếu là user sysman thì có quyền xem toàn bộ
                    if (GlobalCommon.IsHavePermission(string.Empty))
                        function.ItemID = -1;
                    else
                        function.ItemID = (int)PTIdentity.IDNguoiDung;

                    bindingSourceHocVien.DataSource = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
                }

                if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_QuanLyDiem_Print))
                    bl_btnPrint = true;

                if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_QuanLyDiem_Insert))
                    bl_btnDelete = true;
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Print()
        {
            try
            {
                PrintToHTML();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        protected override void Delete()
        {
            try
            {
                if (int.TryParse(radGridView1.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    DT_LienTuc_HocVien.DeleteDT_LienTuc_HocVien(selectedID);
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void MyClose()
        {
            this.Close();
        }

        #endregion

        private void radGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(radGridView1.CurrentRow.Cells["Id"].Value.ToString(), out selectedID)
                    && GlobalCommon.IsHavePermission(new string[]{TextMessages.RolePermission.DT_LT_QuanLyDiem_View,TextMessages.RolePermission.DT_LT_QuanLyDiem_Edit}))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    Form_LT_HocVienLienTuc fr = new Form_LT_HocVienLienTuc(formMode);
                    fr.ShowDialog();
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void dropDownLopHocLienTuc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DT_LienTuc_LopHoc_Info lophoc = (DT_LienTuc_LopHoc_Info)dropDownLopHocLienTuc1.Selected_Item;
            if (lophoc != null) {
                BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForGridViewTheoLop);
                function.ItemID = (int)PTIdentity.IDNguoiDung;
                function.Item = lophoc.MaLop;
                bindingSourceHocVien.DataSource = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
            }
        }

        private void radGridView1_CellEndEdit_1(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                // just save when HoaDonHocPhi
                if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_QuanLyDiem_Edit))
                {
                    DT_LienTuc_HocVien_Info item = (DT_LienTuc_HocVien_Info)e.Row.DataBoundItem;
                    XepLoai(item);
                    DT_LienTuc_HocVien_Coll hocVienColl = (DT_LienTuc_HocVien_Coll)bindingSourceHocVien.DataSource;
                    hocVienColl.Save();
                }
            }
            catch (Exception ex)
            {
                radGridView1.CancelEdit();
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void XepLoai(DT_LienTuc_HocVien_Info item) {
            double tong = 0;
            int   count = 0;

            if (item.DiemThi.HasValue && item.DiemThi > 0) {
                tong += (double)item.DiemThi;
                count++;
            }

            if (item.Lan1.HasValue && item.Lan1 > 0)
            {
                tong += (double)item.Lan1;
                count++;
            }
            
            if (item.Lan2.HasValue && item.Lan2 > 0)
            {
                tong += (double)item.Lan2;
                count++;
            }

            if (item.Lan3.HasValue && item.Lan3 > 0)
            {
                tong += (double)item.Lan3;
                count++;
            }

            if (item.DiemThi.HasValue && item.Lan4 > 0)
            {
                tong += (double)item.Lan4;
                count++;
            }

            if (item.DiemThi.HasValue && item.Lan5 > 0)
            {
                tong += (double)item.Lan5;
                count++;
            }
            if (tong > 0 && count > 0)
            {
                double average = tong / count;
                average = Math.Round(average, 1);

                if (average >= TextMessages.HocVienXepLoaiValue.XepLoai_Gioi)
                    item.XepLoai = TextMessages.HocVienXepLoai.XepLoai_Gioi;
                else if (average >= TextMessages.HocVienXepLoaiValue.XepLoai_Kha)
                    item.XepLoai = TextMessages.HocVienXepLoai.XepLoai_Kha;
                else if (average >= TextMessages.HocVienXepLoaiValue.XepLoai_TrungBinhKha)
                    item.XepLoai = TextMessages.HocVienXepLoai.XepLoai_TrungBinhKha;
                else if (average >= TextMessages.HocVienXepLoaiValue.XepLoai_TrungBinh)
                    item.XepLoai = TextMessages.HocVienXepLoai.XepLoai_TrungBinh;
                else
                    item.XepLoai = TextMessages.HocVienXepLoai.XepLoai_Yeu;
            }
        }
        private void PrintToHTML()
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Họ tên", "Ngày sinh", "Trình độ", "Nội đào tạo", "LT1","LT2","TH1","TH2","TH3","TH4" };
            cv.E_FilterExpression = this.FilterExpression;
            string PhongBan = string.Empty;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    DT_LienTuc_HocVien_Info itemInfo = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { itemInfo.HoTen, itemInfo.NgaySinh, itemInfo.TenTrinhDo, itemInfo.Lan1.ToString(), itemInfo.Lan3.ToString(), itemInfo.DiemThi.ToString(), itemInfo.Lan2.ToString(), itemInfo.Lan4.ToString(), itemInfo.Lan5.ToString() };
                    cv.E_Content.Add(cvItem);
                    PhongBan = itemInfo.TenPhongQuanLy;
                }
            }
            cv.E_TieuDeBaoCao = "Danh sách điểm học viên";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TenTrungTam = PhongBan;
            cv.ProcessTuNgayDenNgay(6); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }
    }
}
