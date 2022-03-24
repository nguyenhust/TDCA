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
    public partial class GridHocVienLienTucHocPhi : UsDictionary
    {
        #region variables
        
        private FormMode formMode = new FormMode();
        private int selectedID = -1;

        private int Mode; // da dong hoc phi hay chua

        #endregion

        public GridHocVienLienTucHocPhi(int mode)
        {
            this.Mode = mode;
            InitializeComponent();
            RadGrid = radGridView1;
            RadGrid.CellFormatting += radGridView_CellFormatting;
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
          
            STT();
            HideSave();
            HideDelete();
            PrintToShow();
            ShowPrint2 = true;
            ShowPrint3 = true;
            ShowPrint4 = true;
            TextPrint2 = "In Danh sách";
            TextPrint3 = "In Chi Tiết";
            TextPrint4 = "In Chi Tiết 2";
            dropDownNam.FillData();
            dropDownNam.Text = GlobalCommon.GetTimeServer().Year.ToString();
        }
        #region Override
        private void radGridView_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }
        public override object GetIdValue()
        {
            switch (Mode)
            {
                case DT_Common.HOCPHI_CHUADONG:
                    return TextMessages.ControlID.DT_HocVienLienTuc_HocPhiChuaDong;
                    break;
                case DT_Common.HOCPHI_HOANTIEN:
                    return TextMessages.ControlID.DT_HocVienLienTuc_HocPhiHoanTien;
                    break;
                case DT_Common.HOCPHI_DADONG:
                    return TextMessages.ControlID.DT_HocVienLienTuc_HocPhiDaDong;
                    break;
                default:
                    return TextMessages.ControlID.DT_HocVienLienTuc_HocPhiToanBo;
                    break;
            }
        }

        public override string ToString()
        {
            switch (Mode)
            {
                case DT_Common.HOCPHI_CHUADONG:
                    return TextMessages.FormTitle.DT_HocVienLienTuc_HocPhiChuaDong;
                    break;
                case DT_Common.HOCPHI_HOANTIEN:
                    return TextMessages.FormTitle.DT_HocVienLienTuc_HocPhiHoanTien;
                    break;
                case DT_Common.HOCPHI_DADONG:
                    return TextMessages.FormTitle.DT_HocVienLienTuc_HocPhiDaDong;
                    break;
                default:
                    return TextMessages.FormTitle.DT_HocVienLienTuc_HocPhiToanBo;
                    break;
            }
        }

        protected override void ApplyAuthorizationRules()
        {
            // nếu có được quyền tối thiểu thì cho phép vào form
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_TraCuuHocPhi_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_TraCuuHocPhi_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_TraCuuHocPhi_Delete);
        }

        protected override void Save()
        {
        }
        protected override void Print2()
        {
            try
            {
                if (Mode == DT_Common.HOCPHI_HOANTIEN)
                    PrintToHTML4();
                else
                    PrintToHTML1();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        protected override void Print3()
        {
            try
            {
                PrintToHTML2();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        protected override void Print4()
        {
            try
            {
                PrintToHTML3();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        protected override void LoadUS()
        {
            try
            {
                if (dropDoBoPhan.GetListData() == null)
                {
                    dropDoBoPhan.FillData(1);
                    dropDoBoPhan.SelectedIndex = 0;
                }
                
                bl_btnDelete = false;
                bl_btnPrint = false;
                bl_btnSave = false;
                if (!GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_TraCuuHocPhi_View))
                {
                    bl_btnDelete = false;
                    bl_btnPrint = false;
                    bl_btnSave = false;
                    throw new Exception(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
                }
                else
                {
                    BusinessFunction function = null;
                    switch (Mode)
                    {
                        case DT_Common.HOCPHI_CHUADONG:
                            function = new BusinessFunction(BusinessFunctionMode.GetDataForGridViewChuaDongHP);
                            break;
                        case DT_Common.HOCPHI_HOANTIEN:
                            function = new BusinessFunction(BusinessFunctionMode.GetDataForGridViewHoanTienHP);
                            break;
                        case DT_Common.HOCPHI_DADONG:
                            function = new BusinessFunction(BusinessFunctionMode.GetDataForGridViewDaDongHP);
                            break;
                        default:
                            function = new BusinessFunction(BusinessFunctionMode.GetAllData);
                            break;
                    }
                    int nam = 0;
                    if (int.TryParse(dropDownNam.Text == "Tất cả" ? "0" : dropDownNam.Text, out nam) && dropDoBoPhan.Selected_TextValue != null)
                    {
                        function.ItemFilterCondition_Int = int.Parse(dropDownNam.Text == "Tất cả"? "0":dropDownNam.Text);
                        function.ItemFilterCondition_Int2 = (int)dropDoBoPhan.Selected_ID;
                        bindingSourceHocVien.DataSource = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
                        TotalRecordValue = bindingSourceHocVien.Count.ToString();
                    }
                }

                if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_TraCuuHocPhi_Print))
                    bl_btnPrint = true;

                if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_TraCuuHocPhi_Delete))
                    bl_btnDelete = true;
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Print()
        {
            DT_LienTuc_HocVien_Coll hocVienColl = (DT_LienTuc_HocVien_Coll)bindingSourceHocVien.DataSource;
            DIC_ChuyenNganh_Coll chuyenNganhColl = DIC_ChuyenNganh_Coll.GetDIC_ChuyenNganh_Coll();
            DIC_HocVi_Coll hocViColl = DIC_HocVi_Coll.GetDIC_HocVi_Coll();
            foreach (DT_LienTuc_HocVien_Info hocvien in hocVienColl) {
                if (hocvien.Checked) {
                    DIC_ChuyenNganh_Info chuyennganh = null;
                    foreach (DIC_ChuyenNganh_Info item in chuyenNganhColl) {
                        if (hocvien.IdChuyenNganh == item.ID)
                        {
                            chuyennganh = item;
                            break;
                        }
                    }

                    DIC_HocVi_Info trinhDo = null;
                    foreach (DIC_HocVi_Info item in hocViColl)
                    {
                        if (hocvien.IdTrinhDo == item.ID)
                        {
                            trinhDo = item;
                            break;
                        }
                    }

                    DT_Common.PrintHocPhi(hocvien, chuyennganh, trinhDo);
                }
            }
            LoadUS();
        }

        protected override void Delete()
        {
            //try
            //{
            //    if (int.TryParse(radGridView1.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
            //    {
            //        DT_LienTuc_HocVien.DeleteDT_LienTuc_HocVien(selectedID);
            //        LoadUS();
            //    }
            //}
            //catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
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
                    && GlobalCommon.IsHavePermission(new string[]{TextMessages.RolePermission.DT_LT_TraCuuHocPhi_View,TextMessages.RolePermission.DT_NghienCuuKhoaHoc_Edit}))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    formMode.Item = Mode;
                    Form_LT_NhapHocPhi fr = new Form_LT_NhapHocPhi(formMode);
                    fr.ShowDialog();
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void radGridView1_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            //try
            //{
            //    // just save when HoaDonHocPhi
            //    if (e.Column.Name == "HoaDonHocPhi")
            //    {
            //        DT_LienTuc_HocVien_Info item = (DT_LienTuc_HocVien_Info)e.Row.DataBoundItem;
            //        if (!string.IsNullOrEmpty(item.HoaDonHocPhi))
            //        {
            //            item.NgayDong = DateTime.Now.ToShortDateString();
            //        }
            //        else
            //            item.NgayDong = null;
            //        // just insert when already Lophoc is loaded
            //        DT_LienTuc_HocVien_Coll hocVienColl = (DT_LienTuc_HocVien_Coll)bindingSourceHocVien.DataSource;
            //        hocVienColl.Save();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    radGridView1.CancelEdit();
            //    GlobalCommon.ShowErrorMessager(ex);
            //}
        }
        private void PrintToHTML1()
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() {"Loại hình đào tạo", "Họ tên", "Ngày sinh", "Trình độ","Ngày đăng kí", "Nội đào tạo","Phải nộp","Đã nộp" };
            cv.E_FilterExpression = this.FilterExpression;
            string PhongBan = string.Empty;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    DT_LienTuc_HocVien_Info itemInfo = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { itemInfo.HinhThucHoc, itemInfo.HoTen, itemInfo.NgaySinh, itemInfo.TenTrinhDo, itemInfo.NgayDangKi, itemInfo.NoiDungDaoTao,GlobalCommon.ConvertMoney(itemInfo.TongHocPhi), GlobalCommon.ConvertMoney(itemInfo.TongTienHoc) };
                    cv.E_Content.Add(cvItem);
                    PhongBan = itemInfo.TenPhongQuanLy;
                }
            }
            cv.E_TieuDeBaoCao = "Tình trạng đóng học phí học viên";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TenTrungTam = PhongBan;
            cv.ProcessTuNgayDenNgay(6); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }
        private void PrintToHTML2()
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Loại hình đào tạo","Họ tên", "Ngày sinh", "Trình độ", "Nội đào tạo","Tổng Phải nộp","Mã hóa đơn","Ngày nộp","Số tiền nộp" };
            cv.E_FilterExpression = this.FilterExpression;
            string PhongBan = string.Empty;
            string spearte = ",";
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    DT_LienTuc_HocVien_Info itemInfo = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    if (!string.IsNullOrEmpty(itemInfo.HoaDonHocPhi))
                    {
                        string[] y_ma = itemInfo.HoaDonHocPhi.Split(new string[] { spearte }, StringSplitOptions.RemoveEmptyEntries);
                        string[] y_ngay = itemInfo.NgayDongDetail.Split(new string[] { spearte }, StringSplitOptions.RemoveEmptyEntries);
                        string[] y_tien = itemInfo.SoTienDongDetail.Split(new string[] { spearte }, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < y_ma.Length; i++)
                        {
                            cvItem.E_Value = new List<string>() {itemInfo.HinhThucHoc, itemInfo.HoTen, itemInfo.NgaySinh, itemInfo.TenTrinhDo, itemInfo.NoiDungDaoTao,itemInfo.TongHocPhi,y_ma[i],y_ngay[i],y_tien[i] };
                            cv.E_Content.Add(cvItem);
                        }
                    }
                    
                    PhongBan = itemInfo.TenPhongQuanLy;
                }
            }
            cv.E_TieuDeBaoCao = "Chi Tiết hóa đơn học phí";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TenTrungTam = PhongBan;
            cv.ProcessTuNgayDenNgay(7); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }
        private void PrintToHTML3()
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Ngày thu", "Số hóa đơn", "Họ và tên", "Nội dung", "Số tiền", "Số PT" };
            cv.E_FilterExpression = this.FilterExpression;
            string PhongBan = string.Empty;
            string spearte = ",";
            string spearte2 = "^";
            Int64 tongtien = 0;Int64 temp = 0;
            //string lop = string.Empty;
            ExportLib.Entities.HanhChinh.B100_Table cvItem;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    DT_LienTuc_HocVien_Info itemInfo = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                    cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    //if(
                    //string[] yAllInOne = x_allInOne.Split(new string[] { spearte2 }, StringSplitOptions.RemoveEmptyEntries);
                    //for (int i = 0; i < yAllInOne.Length; i++)
                    //{
                    //    string[] rowSplit = yAllInOne[i].Split(new string[] { spearte }, StringSplitOptions.RemoveEmptyEntries);
                    //    GridViewRowInfo itemInfo = radGridView1.Rows.AddNew();
                    //    itemInfo.Cells[ColMaHoaDon].Value = rowSplit[0];
                    //    itemInfo.Cells[ColNgayHoaDon].Value = rowSplit[1];
                    //    itemInfo.Cells[ColSoTien].Value = rowSplit[2];
                    //    itemInfo.Cells[ColSoPT].Value = rowSplit[3];
                    //}
                    if (!string.IsNullOrEmpty(itemInfo.Backup01))
                    {
                        string[] yAllInOne = itemInfo.Backup01.Split(new string[] { spearte2 }, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < yAllInOne.Length; i++)
                        {
                            string[] rowSplit = yAllInOne[i].Split(new string[] { spearte }, StringSplitOptions.RemoveEmptyEntries);
                            cvItem.E_Value = new List<string>() { rowSplit[1], rowSplit[0], itemInfo.HoTen,string.Format("{0} - {1}",itemInfo.NoiDungDaoTao,itemInfo.TenKhoaHoc), rowSplit[2], rowSplit[3]};
                            if (Int64.TryParse(rowSplit[2], out temp))
                            {
                                tongtien += temp;
                            }
                            cv.E_Content.Add(cvItem);
                        }
                      
                    }
                    //lop = itemInfo.NoiDungDaoTao;
                    PhongBan = itemInfo.TenPhongQuanLy;
                }
            }
            cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
            cvItem.E_Value = new List<string>() { string.Empty, string.Empty, string.Empty, string.Empty, tongtien.ToString(), string.Empty };
            cv.E_Content.Add(cvItem);
            cv.E_TieuDeBaoCao = "bảng kê thu tiền học phí";
            cv.E_NguoiKi = PTIdentity.FullName;
            //cv.E_ThongTinKhac = string.Format("Lớp {0}", lop);
            cv.E_TenTrungTam = PhongBan;
            cv.ProcessTuNgayDenNgay(0); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }
        private void PrintToHTML4()
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Loại hình", "Họ tên", "Ngày sinh", "Trình độ", "Nội đào tạo", "Phải nộp", "Đã nộp", "Đã hoàn","Ngày Hoàn tiền","Lý do" };
            cv.E_FilterExpression = this.FilterExpression;
            string PhongBan = string.Empty;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    DT_LienTuc_HocVien_Info itemInfo = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { itemInfo.HinhThucHoc, itemInfo.HoTen, itemInfo.NgaySinh, itemInfo.TenTrinhDo, itemInfo.NoiDungDaoTao, GlobalCommon.ConvertMoney(itemInfo.TongHocPhi), GlobalCommon.ConvertMoney(itemInfo.TongTienHoc), GlobalCommon.ConvertMoney(itemInfo.SoTienHoan),itemInfo.NgayDong,itemInfo.LyDoHoanTien };
                    cv.E_Content.Add(cvItem);
                    PhongBan = itemInfo.TenPhongQuanLy;
                }
            }
            cv.E_TieuDeBaoCao = "Danh sách học viên đã được hoàn tiền";
            cv.IsNamDoc = false;
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TenTrungTam = PhongBan;
            cv.ProcessTuNgayDenNgay(8); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }
    }
}
