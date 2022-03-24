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
using ModuleHanhChinh.LIB;
using DanhMuc.LIB;
using ModuleHanhChinh.UI;
using ExportLib;
using Authoration.LIB;

namespace ModuleHanhChinh.UserControl
{
    public partial class Grid_NhapXuatTienLamSang : UsDictionary
    {
        private HC_ThietBiTienLamSang_NhapXuat_Coll listItem;
        private HC_ThietBiTienLamSang_NhapXuat_Info item;
        public Grid_NhapXuatTienLamSang()
        {
            InitializeComponent();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            STT(radGridViewTonKho);
            STT(radGridViewXuat);
            STT(GridViewNhapKho);
            radGridViewTonKho.CellFormatting += radG_CellFormat;
            radGridViewXuat.CellFormatting += radG_CellFormat;
            GridViewNhapKho.CellFormatting += radG_CellFormat;
            TextPrint = "In Thống kê tồn kho";
            HideSave();
            HideDelete();
            radGridViewXuat.UserDeletingRow += radGridViewXuat_UserDeletingRow;
            GridViewNhapKho.UserDeletingRow += GridViewNhapKho_UserDeletingRow;
        }
        private int selectedID = -1;
        void GridViewNhapKho_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            try
            {

                if (int.TryParse(GridViewNhapKho.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    HC_ThietBiTienLamSang_NhapXuat.DeleteHC_ThietBiTienLamSang_NhapXuat(selectedID);
                    radBindingSource.DataSource = HC_ThietBiTienLamSang_NhapXuat_Coll.GetHC_ThietBiTienLamSang_NhapXuat_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridView));
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        void radGridViewXuat_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            try
            {
                if (int.TryParse(radGridViewXuat.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    HC_ThietBiTienLamSang_NhapXuat.DeleteHC_ThietBiTienLamSang_NhapXuat(selectedID);
                    bindingSourceXuatkho.DataSource = HC_ThietBiTienLamSang_NhapXuat_Coll.GetHC_ThietBiTienLamSang_NhapXuat_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition));
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.HC_ThietBiTienLamSang_NhapXuat;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.HC_ThietBiTienLamSang_NhapXuat;
        }

        protected override void ApplyAuthorizationRules()
        {
            // nếu có được quyền tối thiểu thì cho phép vào form
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_ThietBiTienLamSang_NhapXuat_Insert);
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_ThietBiTienLamSang_NhapXuat_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_ThietBiTienLamSang_NhapXuat_Del);
        }

        protected override void Save()
        {
            //try
            //{
                
            //    items.ApplyEdit();
            //    items.Save();
            //}
            //catch (Exception ex)
            //{
            //    GlobalCommon.ShowError(ex);
            //}
           
        }

        protected override void LoadUS()
        {
            listItem = HC_ThietBiTienLamSang_NhapXuat_Coll.GetHC_ThietBiTienLamSang_NhapXuat_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridView));
            radBindingSource.DataSource = listItem;

            bindingSourceThietbi.DataSource = HC_ThietBiTienLamSang_Coll.GetHC_ThietBiTienLamSang_Coll();
            bindingSourceKinhPhi.DataSource = DIC_NguonKinhPhi_Coll.GetDIC_NguonKinhPhi_Coll();

            bindingSourceXuatkho.DataSource = HC_ThietBiTienLamSang_NhapXuat_Coll.GetHC_ThietBiTienLamSang_NhapXuat_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition));

            bindingSourceTonKho.DataSource = HC_ThietBiTienLamSang_NhapXuat_Coll.GetListTonKho();
            radGridViewTonKho.DataSource = bindingSourceTonKho;
            if (radPageView1.SelectedPage == Xuat)
            {
                ShowPrint2 = true;
                TextPrint2 = "In Phiếu Bàn Giao";
            }
            else
            {
                ShowPrint2 = false;
            }
        }

        protected override void Print()
        {
            //LoadUS();
            try
            {
                PrintThongKeTonKho();
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
                PrintPhieuBanGiaoThietBi();
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

        private void GridViewNhapKho_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            try
            {
                HC_ThietBiTienLamSang_NhapXuat_Info newObject = (HC_ThietBiTienLamSang_NhapXuat_Info)GridViewNhapKho.Rows[0].DataBoundItem;
                newObject.XuatNgay = null;
                newObject.XuatSoLuong = 0;
                listItem = (HC_ThietBiTienLamSang_NhapXuat_Coll)radBindingSource.DataSource;
                listItem.Save();
            }
            catch (Exception ex) {
                GlobalCommon.ShowError(ex);
            }
            
        }

        private void GridViewNhapKho_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                HC_ThietBiTienLamSang_NhapXuat_Info item = (HC_ThietBiTienLamSang_NhapXuat_Info)e.Row.DataBoundItem;
                if (item == null || item.IsNew)
                    return;

                listItem = (HC_ThietBiTienLamSang_NhapXuat_Coll)radBindingSource.DataSource;
                if (listItem.IsDirty)
                {
                    listItem.Save();
                }

            }
            catch (Exception ex)
            {
                GlobalCommon.ShowError(ex);
            }
        }

        private void GridViewNhapKho_UserDeletedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {

        }

        private void radGridViewXuat_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            try
            {
                HC_ThietBiTienLamSang_NhapXuat_Info newObject = (HC_ThietBiTienLamSang_NhapXuat_Info)radGridViewXuat.Rows[0].DataBoundItem;
                newObject.NhapNgay = null;
                newObject.NhapSoLuong = 0;
                HC_ThietBiTienLamSang_NhapXuat_Coll coll = (HC_ThietBiTienLamSang_NhapXuat_Coll)bindingSourceXuatkho.DataSource;
                coll.Save();
            }
            catch (Exception ex) {
                GlobalCommon.ShowError(ex);
            }
        }

        private void radGridViewXuat_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                HC_ThietBiTienLamSang_NhapXuat_Info item = (HC_ThietBiTienLamSang_NhapXuat_Info)e.Row.DataBoundItem;
                if (item == null || item.IsNew)
                    return;

                HC_ThietBiTienLamSang_NhapXuat_Coll coll = (HC_ThietBiTienLamSang_NhapXuat_Coll)bindingSourceXuatkho.DataSource;
                if (coll.IsDirty)
                {
                    coll.Save();
                }

            }
            catch (Exception ex)
            {
                GlobalCommon.ShowError(ex);
            }
        }

        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (radPageView1.SelectedPage == Ton) {
                bindingSourceTonKho.DataSource = HC_ThietBiTienLamSang_NhapXuat_Coll.GetListTonKho();
                //radGridViewTonKho.DataSource = bindingSourceTonKho;  
                
            }
            if (radPageView1.SelectedPage == Xuat)
            {
                ShowPrint2 = true;
                TextPrint2 = "In Phiếu Bàn Giao";
            }
            else
            {
                ShowPrint2 = false;
            }
        }
        private void PrintPhieuBanGiaoThietBi()
        {
            FormMode frMode = new FormMode();
            HC_ThietBiTienLamSang_NhapXuat_Coll listThietBi = HC_ThietBiTienLamSang_NhapXuat_Coll.NewHC_ThietBiTienLamSang_NhapXuat_Coll();
            bool Err = false;
            string temp = string.Empty;
            HC_ThietBiTienLamSang_Coll cvColl = (HC_ThietBiTienLamSang_Coll)bindingSourceThietbi.DataSource;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridViewXuat.ChildRows)
            {
                if (Convert.ToBoolean(rowInfo.Cells["InPhieu"].Value))
                {
                    //foreach (HC_ThietBiTienLamSang_Info cvInfo in cvColl)
                    //{
                    //    if (rowInfo.Cells["IdThietBi"].Value.ToString() == cvInfo.ID.ToString())
                    //    {
                    //        temp = cvInfo.TenThietBi;
                    //    }
                    //}
                    listThietBi.Add((HC_ThietBiTienLamSang_NhapXuat_Info)rowInfo.DataBoundItem);
                    
                }
            }
            frMode.ItemColl = listThietBi;
            if (listThietBi.Count > 0)
            {
                Form_BanGiaoThietBi fr = new Form_BanGiaoThietBi(frMode);
                fr.ShowDialog();
            }
            else
            {
                if (!Err)
                    GlobalCommon.ShowErrorMessager("Bạn chưa chọn thiết bị nào!");
            }
        }
        private void PrintThongKeTonKho()
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Tên thiết bị mô hình", "Nhập", "Xuất", "Tồn" };
            string temp = string.Empty;
            HC_ThietBiTienLamSang_Coll cvColl = (HC_ThietBiTienLamSang_Coll)bindingSourceThietbi.DataSource;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridViewTonKho.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    foreach (HC_ThietBiTienLamSang_Info cvInfo in cvColl)
                    {
                        if (rowInfo.Cells["IdThietBi"].Value.ToString() == cvInfo.ID.ToString())
                        {
                            temp = cvInfo.TenThietBi;
                        }
                    }
                    cvItem.E_Value = new List<string>() { temp, rowInfo.Cells["TongNhap"].Value.ToString(), rowInfo.Cells["TongXuat"].Value.ToString(), rowInfo.Cells["SoLuong"].Value.ToString() };
                    cv.E_Content.Add(cvItem);
                }
            }
            cv.E_TieuDeBaoCao = "Danh sách tồn kho thiết bị tiền lâm sàng";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TuNgayDenNgay = string.Empty;
            //cv.ProcessTuNgayDenNgay(1); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }
    }
}
