using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NETLINK.UI;
using ModuleDaoTao.LIB;
using ModuleDaoTao.UI;
using NETLINK.LIB;
using ExportLib;
using ExportLib.Entities;
using Authoration.LIB;

namespace ModuleDaoTao.UserControls
{
    public partial class GridChinhQuyNhapDiemHocVien : UsDictionary
    {
         #region variables

        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        #endregion

        public GridChinhQuyNhapDiemHocVien()
        {
            InitializeComponent();
            RadGrid = radGridView1;
            RadGrid.CellDoubleClick += radGridView_CellDoubleClick;
            RadGrid.CellFormatting += radGridView_CellFormatting;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            HideSave();
            HideNew();
            HideDelete();
            PrintToShow();
            ShowPrint2 = true;
            ShowPrint3 = true;
            ShowPrint4 = true;
            TextPrint2 = "In CKI";
            TextPrint3 = "In CKII";
            TextPrint4 = "In BSNT";
        }
        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.DT_ChinhQuy_DiemThiHocVien;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.DT_ChinhQuy_DiemThiHocVien;
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_CQ_QuanLyDiem_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_CQ_QuanLyDiem_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_CQ_QuanLyDiem_Del);
        }

        protected override void Save()
        {
            formMode.IsInsert = true;
            Form_CQ_DiemThi fr = new Form_CQ_DiemThi(formMode);
            fr.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            try
            {
                radBindingSource.DataSource = DT_ChinhQuy_HocVien_Coll.GetDT_ChinhQuy_HocVien_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));

            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Print()
        {
            try
            {
                LoadUS();
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
                //if (int.TryParse(RadGrid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                //{
                //    DT_ChinhQuy_LopHoc.DeleteDT_ChinhQuy_LopHoc(selectedID);
                //    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, FormAction.Delete, "Chính Quy - Nhập điểm |" + this.ToString());
                //    LoadUS();
                //}
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }
        protected override void Print2()
        {
            try
            {
                PrintToHTML(DT_Common.CQ_LoaiDT_CKI);
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
                PrintToHTML(DT_Common.CQ_LoaiDT_CKII);
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
                PrintToHTML(DT_Common.CQ_LoaiDT_BSNT);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        protected override void MyClose()
        {
            this.Close();
        }

        #endregion

        private void radGridView_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }

        private void radGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (int.TryParse(RadGrid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    Form_CQ_DiemThi fr = new Form_CQ_DiemThi(formMode);
                    fr.ShowDialog();
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        #region HTML generator

        private void PrintToHTML(string CK)
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Họ tên", "Ngày sinh","Nơi sinh", "Điểm trung bình môn học", "Điểm trung bình tốt nghiệp", "Điểm xếp loại tốt nghiệp", "Xếp loại tốt nghiệp" };
            cv.E_FilterExpression = this.FilterExpression;
            string khoa = string.Empty;
            string chuyennganh = string.Empty;
            double tongTN = 0;
            double tongxeploai = 0;
            string xeploai = string.Empty;
            DT_Common dtcommon = new DT_Common();
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    DT_ChinhQuy_HocVien_Info itemInfo = (DT_ChinhQuy_HocVien_Info)rowInfo.DataBoundItem;
                    if (itemInfo.CapDoDuTuyen == CK)
                    {
                        tongTN = DT_Common.CQ_CaculateTongDiemTotNghiep(itemInfo.TotNghiepLT, itemInfo.TotNghiepTH, itemInfo.BaoVeLuanVan);
                        tongxeploai = DT_Common.CQ_CaculateDiemXepLoai(itemInfo.Backup03, tongTN);
                        xeploai = DT_Common.CQ_XepLoai(tongxeploai);
                        ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                        cvItem.E_Value = new List<string>() { itemInfo.HoTen, itemInfo.NgaySinh,string.Empty, itemInfo.Backup03, tongTN.ToString(), tongxeploai.ToString(), xeploai };
                        cv.E_Content.Add(cvItem);
                        khoa = itemInfo.KhoaDuTuyen;
                        chuyennganh = itemInfo.TenChuyenNganhLop;
                    }

                }
            }
            if (CK == DT_Common.CQ_LoaiDT_CKI)
                cv.E_TieuDeBaoCao = string.Format("Kết quả học tập, thi tốt nghiệp lớp Chuyên khoa cấp I khóa {0}", khoa);
            else if (CK == DT_Common.CQ_LoaiDT_CKII)
                cv.E_TieuDeBaoCao = string.Format("Kết quả học tập, thi tốt nghiệp lớp Chuyên khoa cấp II khóa {0}", khoa);
            else
                cv.E_TieuDeBaoCao = string.Format("Kết quả học tập, thi tốt nghiệp lớp bác sĩ nội trú khóa {0}", khoa);
            cv.E_NguoiKi = string.Empty;
            cv.E_CongHoaXaHoi = string.Empty;
            cv.E_DocLapTuDo = string.Empty;
            cv.E_TenBenhVien = "bộ y tế";
            cv.E_TenTrungTam = "bệnh viện bạch mai";
            cv.E_NoiLapBC = string.Empty;
            cv.IsNamDoc = false;
            cv.E_TuNgayDenNgay = string.Format("Chuyên ngành: {0}", chuyennganh);
            cv.E_NoiLapBC = string.Empty;
            cv.E_TenTrungTamLapBC = string.Empty;
            cv.E_NguoiKi = PTIdentity.FullName;
            // cv.ProcessTuNgayDenNgay(6); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }

        private void PrintToHTML()
        {
            //TT_AnPham_Coll listItem = (TT_AnPham_Coll)bindAnPham.DataSource;
            //ExportHanhChinh ex = new ExportHanhChinh();
            //ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            //cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            //cv.E_TieuDe = new List<string>() { "Ấn Phẩm", "Đơn Vị Đặt", "Loại", "Nội dung", "Số lượng", "Từ ngày", "Đến ngày" };
            //foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            //{
            //    if (rowInfo.IsVisible)
            //    {
            //        TT_AnPham_Info itemInfo = (TT_AnPham_Info)rowInfo.DataBoundItem;
            //        ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
            //        cvItem.E_Value = new List<string>() { itemInfo.Ten, itemInfo.DonViDat, itemInfo.Loai, itemInfo.NoiDung, itemInfo.SoLuong.ToString(), itemInfo.TuNgay, itemInfo.DenNgay };
            //        cv.E_Content.Add(cvItem);
            //    }
            //}
            //cv.E_TieuDeBaoCao = "báo cáo ấn phẩm";
            //cv.E_NguoiKi = PTIdentity.FullName;
            //cv.ProcessTuNgayDenNgay(5); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            //ex.B100_GenReport(cv);
        }


        #endregion
    }
}
