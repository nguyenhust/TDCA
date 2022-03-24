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
using ExportLib;
using System.IO;
using ExportLib.Entities.DaoTao;

namespace ModuleDaoTao.UserControls
{
    public partial class GridHocVienLienTucChuaInThe : UsDictionary
    {
        #region variables
        
        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        private DT_LienTuc_HocVien_Coll listHV;

        #endregion

        public GridHocVienLienTucChuaInThe()
        {
            InitializeComponent();
            RadGrid = radGridView1;
            RadGrid.CellFormatting += radGridView_CellFormatting;
            STT();
            SaveToNew();
            PrintToShow();
            ShowPrint2 = true;
            TextPrint2 = "In Danh sách";
            ShowPrint3 = true;
            TextPrint3 = "In Thẻ";
            TextPrint4 = "In tất cả thẻ";
            ShowPrint4 = true;
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            HideSave();
            HideNew();
            HideDelete();
        }

        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.DT_HocVienLienTuc_ChuaInThe;
        }
        private void radGridView_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }
        public override string ToString()
        {
            return TextMessages.FormTitle.DT_HocVienLienTuc_ChuaInThe;
        }

        protected override void ApplyAuthorizationRules()
        {
            // nếu có được quyền tối thiểu thì cho phép vào form
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_HocVien_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_HocVien_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_HocVien_Delete);
        }

        protected override void Save()
        {
           
        }
        protected override void Print3()
        {
            try
            {
                PrintThe();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        protected override void Print2()
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
        protected override void Print4()
        {
            try
            {
                foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
                {
                    rowInfo.Cells["In"].Value = true;
                }
                PrintThe();
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
                BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDTLienTuc_HVChuaInThe);
                listHV = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
                bindingSourceHocVien.DataSource = listHV;
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Print()
        {
            LoadUS();
        }

        protected override void Delete()
        {
            try
            {
               
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
                    && GlobalCommon.IsHavePermission(new string[]{TextMessages.RolePermission.DT_LT_HocVien_View,TextMessages.RolePermission.DT_LT_HocVien_Edit}))
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
        private void PrintThe()
        {
            DT_TheHocVienLienTuc lstHocvienLt = new DT_TheHocVienLienTuc();
            lstHocvienLt.ListTheHocVienLienTuc = new List<TheHocVienLienTuc>();
            ExportDaoTao daotao = new ExportDaoTao();
            string temp = Path.GetTempPath();
                 FtpUltilies ftpU = new FtpUltilies();
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {

                if (rowInfo.IsVisible && Convert.ToBoolean(rowInfo.Cells["In"].Value))
                {
                    DT_LienTuc_HocVien_Info objHocvien = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                    string imgFileName = objHocvien.MaHocVien + ".jpg";
                    imgFileName = Path.Combine(temp, imgFileName);
                    TheHocVienLienTuc needPrint = new TheHocVienLienTuc();
                    needPrint.TenHocVien = GlobalCommon.StringProcess.ForReport.VietTatMotSoKiTu(objHocvien.HoTen);
                    needPrint.MaHocVien = objHocvien.MaHocVien;
                    try
                    {
                        if (!string.IsNullOrEmpty(objHocvien.Anh))
                            ftpU.DownloadFile(objHocvien.Anh, temp + "\\" + objHocvien.MaHocVien + ".jpg");
                    }
                    catch
                    {
                    }
                    needPrint.AnhHocVien = temp + "\\" + objHocvien.MaHocVien + ".jpg";
                    needPrint.TrinhDo = objHocvien.TenTrinhDo;
                    needPrint.KhoaHoc = objHocvien.NoiDungDaoTao;
                    needPrint.ThoiGian = string.Format("{0} - {1}", objHocvien.NgayBatDau, objHocvien.NgayKetThuc);
                    needPrint.SoCMT = objHocvien.SoCMT;
                    needPrint.TruongHoc = objHocvien.TruongTotNghiep;
                    lstHocvienLt.ListTheHocVienLienTuc.Add(needPrint);    
                    int tslinthe = 0;
                    if (int.TryParse(objHocvien.TongSoLanInThe.ToString(), out tslinthe))
                    {
                        objHocvien.TongSoLanInThe = tslinthe + 1;
                    }
           
                }

            }
            if (listHV != null && listHV.Count > 0 && lstHocvienLt.ListTheHocVienLienTuc.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn in " + lstHocvienLt.ListTheHocVienLienTuc.Count.ToString() + " thẻ học viên", "Xác nhận hành động", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    listHV.Save();
                    daotao.ExportTheHocVienLienTuc(lstHocvienLt, (int)0);
                    GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.ExportSuccess);
                    LoadUS();
                }
            }
        }

        private void PrintToHTML()
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Họ tên","Ngày sinh", "Trình độ", "Giới tính","Nơi công tác","Tỉnh","Ngày đăng kí","Trạng Thái","Nội đào tạo","Số lần in chứng chỉ" };
            cv.E_FilterExpression = this.FilterExpression;
            string PhongBan = string.Empty;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    DT_LienTuc_HocVien_Info itemInfo = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { itemInfo.HoTen,itemInfo.NgaySinh,itemInfo.TenTrinhDo,itemInfo.GioiTinh,itemInfo.TenBenhVien,itemInfo.TenTinhThanh,itemInfo.NgayDangKi,itemInfo.TrangThai,itemInfo.NoiDungDaoTao,itemInfo.TongSoLanInGiayChungNhan.ToString() };
                    cv.E_Content.Add(cvItem);
                    PhongBan = itemInfo.TenPhongQuanLy;
                }
            }
            cv.E_TieuDeBaoCao = "Danh sách học viên chưa in thẻ";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TenTrungTam = PhongBan;
            cv.IsNamDoc = false;
            cv.ProcessTuNgayDenNgay(6); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }



    }
}
