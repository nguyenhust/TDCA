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
using ExportLib;
using Authoration.LIB;

namespace ModuleDaoTao.UserControls
{
    public partial class GridHocVienChinhQuy : UsDictionary
    {
        #region variables

        private FormMode formMode = new FormMode();
        private int selectedID = -1;

        #endregion

        public GridHocVienChinhQuy()
        {
            InitializeComponent();
            RadGrid = radGridView;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            PrintToShow();
            ShowPrint2 = true;
            ShowPrint3 = true;
            ShowPrint4 = true;
            TextPrint2 = "In DS CKI";
            TextPrint3 = "In DS CKII";
            TextPrint4 = "In DS BSNT";
        }

        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.DT_HocVienChinhQuy;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.DT_HocVienChinhQuy;
        }

        protected override void ApplyAuthorizationRules()
        {
            // nếu có được quyền tối thiểu thì cho phép vào form
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_CQ_HocVien_Insert);
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_CQ_HocVien_Print);
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_CQ_HocVien_Del);
            bl_btnMyClose = true;
        }

        protected override void Save()
        {
            formMode.IsInsert = true;
            Form_CQ_HocVienChinhQuy fr = new Form_CQ_HocVienChinhQuy(formMode);
            fr.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            try
            {
                if(!GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_CQ_HocVien_View))
                {
                    bl_btnDelete = false;
                    bl_btnSave = false;
                    bl_btnPrint = false;
                    throw new Exception(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
                }
                else
                {
                    radbindingSource.DataSource = DT_ChinhQuy_HocVien_Coll.GetDT_ChinhQuy_HocVien_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridView));
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Print()
        {
            LoadUS();
        }
        protected override void Print2()
        {
            try
            {
                PrintDS(DT_Common.CQ_LoaiDT_CKI);
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
                PrintDS(DT_Common.CQ_LoaiDT_CKII);
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
                PrintDS(DT_Common.CQ_LoaiDT_BSNT);
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
                if (int.TryParse(radGridView.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    DT_ChinhQuy_HocVien.DeleteDT_ChinhQuy_HocVien(selectedID);
                }
                LoadUS();
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void MyClose()
        {
            base.MyClose();
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
                if (int.TryParse(radGridView.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    formMode.StringId = radGridView.CurrentRow.Cells["MaHocVien"].Value.ToString();
                    Form_CQ_HocVienChinhQuy fr = new Form_CQ_HocVienChinhQuy(formMode);
                    fr.ShowDialog();
                    LoadUS();
                }
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
        private void PrintDS(string CK)
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Họ tên", "Giới", "Ngày sinh", "Nơi sinh", "Chuyên ngành", "Đơn vị công tác", "Điện thoại", "Ghi chú" };
            cv.E_FilterExpression = this.FilterExpression;
            string khoa = string.Empty;
            string nam = string.Empty;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    DT_ChinhQuy_HocVien_Info itemInfo = (DT_ChinhQuy_HocVien_Info)rowInfo.DataBoundItem;
                    if (itemInfo.CapDoDuTuyen == CK)
                    {
                        ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                        cvItem.E_Value = new List<string>() { itemInfo.HoTen, itemInfo.GioiTinh, itemInfo.NgaySinh, itemInfo.NoiSinh, itemInfo.TenChuyenNganh, itemInfo.NoiCongTac, itemInfo.DiDong, string.Empty };
                        cv.E_Content.Add(cvItem);
                        khoa = itemInfo.KhoaDuTuyen;
                        nam = itemInfo.NamDuTuyen.ToString();
                    }
                }
            }
            if (CK == DT_Common.CQ_LoaiDT_CKI)
                cv.E_TieuDeBaoCao = string.Format("danh sách học viên Chuyên khoa I khóa {0}", khoa);
            else if(CK == DT_Common.CQ_LoaiDT_CKII)
                cv.E_TieuDeBaoCao = string.Format("danh sách học viên Chuyên khoa II khóa {0}", khoa);
            else
                cv.E_TieuDeBaoCao = string.Format("danh sách học viên Bác sĩ nội trú khóa {0}", khoa);
            cv.E_NguoiKi = string.Empty;
            cv.E_CongHoaXaHoi = string.Empty;
            cv.E_DocLapTuDo = string.Empty;
            cv.E_TenBenhVien = "bộ y tế";
            cv.E_TenTrungTam = "bệnh viện bạch mai";
            cv.E_NoiLapBC = string.Empty;
            cv.IsNamDoc = true;
            cv.E_TuNgayDenNgay = string.Empty;
            cv.E_NoiLapBC = string.Empty;
            cv.E_TenTrungTamLapBC = string.Empty;
            cv.E_NguoiKi = PTIdentity.FullName;
            // cv.ProcessTuNgayDenNgay(6); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }
    }
}
