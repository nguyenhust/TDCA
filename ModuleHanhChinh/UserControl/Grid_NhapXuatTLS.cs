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
    public partial class Grid_NhapXuatTLS : UsDictionary
    {
        private HC_ThietBiTienLamSang_NhapXuat_Coll listItem;
        private HC_ThietBiTienLamSang_NhapXuat_Info item;
        private FormMode formMode = new FormMode();
        public Grid_NhapXuatTLS()
        {
            InitializeComponent();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            STT(radGridViewTonKho);
            STT(radGridViewXuat);
            STT(GridViewNhapKho);
            RadGrid = GridViewNhapKho;
            radGridViewTonKho.CellFormatting += radG_CellFormat;
            radGridViewXuat.CellFormatting += radG_CellFormat;
            GridViewNhapKho.CellFormatting += radG_CellFormat;
            TextPrint = "In Thống kê tồn kho";
            SaveToNew();
            //HideDelete();
            radGridViewXuat.UserDeletingRow += radGridViewXuat_UserDeletingRow;
            GridViewNhapKho.UserDeletingRow += GridViewNhapKho_UserDeletingRow;
        }
        private int selectedID = -1;
        void GridViewNhapKho_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            //try
            //{

            //    if (int.TryParse(GridViewNhapKho.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
            //    {
            //        HC_DuTruVanPhongPham_NhapXuat.DeleteHC_DuTruVanPhongPham_NhapXuat(selectedID);
            //        bindingSourceNhapKho.DataSource = HC_DuTruVanPhongPham_NhapXuat_Coll.GetHC_DuTruVanPhongPham_NhapXuat_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition));
            //    }
            //}
            //catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        void radGridViewXuat_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            //try
            //{
            //    if (int.TryParse(radGridViewXuat.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
            //    {
            //        HC_DuTruVanPhongPham_NhapXuat.DeleteHC_DuTruVanPhongPham_NhapXuat(selectedID);
            //        bindingSourceNhapKho.DataSource = HC_DuTruVanPhongPham_NhapXuat_Coll.GetHC_DuTruVanPhongPham_NhapXuat_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition2));
            //    }
            //}
            //catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
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
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_ThietBiTienLamSang_NhapXuat_Insert);
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_ThietBiTienLamSang_NhapXuat_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_ThietBiTienLamSang_NhapXuat_Del);
        }

        protected override void Save()
        {
            try
            {
                
                if (radPageView1.SelectedPage == Nhap)
                {
                    formMode.IsInsert = true;
                    formMode.Item = LoaiXuatNhap.PhieuNhap;
                }
                else if (radPageView1.SelectedPage == Xuat)
                {
                    formMode.IsInsert = true;
                    formMode.Item = LoaiXuatNhap.PhieuXuat;
                    formMode.ItemColl = bindingSourceTonKho.DataSource;
                }
                Form_ThietBiTLS_NhapXuat fr = new Form_ThietBiTLS_NhapXuat(formMode);
                fr.ShowDialog();
                LoadUS();
                
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowError(ex);
            }
           
        }

        protected override void LoadUS()
        {



            //bindingSourceThietbi.DataSource = HC_DuTruVanPhongPham_Coll.GetHC_DuTruVanPhongPham_Coll();
            //bindingSourceKinhPhi.DataSource = DIC_NguonKinhPhi_Coll.GetDIC_NguonKinhPhi_Coll();
            //bindingSourcePhongBan.DataSource = DIC_BoPhan_Coll.GetDIC_BoPhan_Coll();

            //bindingSourceNhapKho.DataSource = HC_DuTruVanPhongPham_NhapXuat_Coll.GetHC_DuTruVanPhongPham_NhapXuat_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition)); 
           
            //bindingSourceXuatkho.DataSource = HC_DuTruVanPhongPham_NhapXuat_Coll.GetHC_DuTruVanPhongPham_NhapXuat_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition2));

            //bindingSourceTonKho.DataSource = HC_DuTruVanPhongPham_NhapXuat_Coll.GetHC_DuTruVanPhongPham_NhapXuat_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition3));


            bindingSourceNhapKho.DataSource = HC_ThietBiTienLamSang_NhapXuat_Coll.GetHC_ThietBiTienLamSang_NhapXuat_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition));

            bindingSourceXuatkho.DataSource = HC_ThietBiTienLamSang_NhapXuat_Coll.GetHC_ThietBiTienLamSang_NhapXuat_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition2));

            bindingSourceTonKho.DataSource = HC_ThietBiTienLamSang_NhapXuat_Coll.GetHC_ThietBiTienLamSang_NhapXuat_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition3));
            
            radGridViewTonKho.DataSource = bindingSourceTonKho;
            if (radPageView1.SelectedPage == Xuat)
            {
                //ShowPrint2 = true;
                TextPrint2 = "In Phiếu Bàn Giao";
                //ShowPrint3 = true;
                TextPrint3 = "In Phiếu dự trù văn phòng phẩm";
            }
            else
            {
                ShowPrint2 = false;
                ShowPrint3 = false;
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
        protected override void Print3()
        {
            try
            {
                PrintDuTruVanPhongPham();
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
                if (radPageView1.SelectedPage == Xuat)
                {

                    if (int.TryParse(radGridViewXuat.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                    {
                        HC_ThietBiTienLamSang_NhapXuat.DeleteHC_ThietBiTienLamSang_NhapXuat(selectedID);
                        LoadUS();
                    }
                        
                }
                else if (radPageView1.SelectedPage == Nhap)
                {
                    if (int.TryParse( GridViewNhapKho.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                    {
                        HC_ThietBiTienLamSang_NhapXuat.DeleteHC_ThietBiTienLamSang_NhapXuat(selectedID);
                        LoadUS();
                    }
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void MyClose()
        {
            this.Close();
        }

        #endregion

        private void GridViewNhapKho_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            //try
            //{
            //    HC_DuTruVanPhongPham_NhapXuat_Info newObject = (HC_DuTruVanPhongPham_NhapXuat_Info)GridViewNhapKho.Rows[0].DataBoundItem;
            //    newObject.XuatNgay = null;
            //    newObject.XuatSoLuong = 0;
            //    newObject.Type = Convert.ToInt32(LoaiXuatNhap.PhieuNhap); 
            //    listItem = (HC_DuTruVanPhongPham_NhapXuat_Coll)bindingSourceNhapKho.DataSource;
            //    listItem.Save();
            //}
            //catch (Exception ex) {
            //    GlobalCommon.ShowError(ex);
            //}
            
        }

        private void GridViewNhapKho_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            //try
            //{
            //    HC_DuTruVanPhongPham_NhapXuat_Info item = (HC_DuTruVanPhongPham_NhapXuat_Info)e.Row.DataBoundItem;
            //    if (item == null || item.IsNew)
            //        return;

            //    listItem = (HC_DuTruVanPhongPham_NhapXuat_Coll)bindingSourceNhapKho.DataSource;
            //    if (listItem.IsDirty)
            //    {
            //        listItem.Save();
            //    }

            //}
            //catch (Exception ex)
            //{
            //    GlobalCommon.ShowError(ex);
            //}
        }

        private void GridViewNhapKho_UserDeletedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {

        }

        private void radGridViewXuat_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            //try
            //{
            //    HC_DuTruVanPhongPham_NhapXuat_Info newObject = (HC_DuTruVanPhongPham_NhapXuat_Info)radGridViewXuat.Rows[0].DataBoundItem;
            //    newObject.NhapNgay = null;
            //    newObject.NhapSoLuong = 0;
            //    newObject.Type = Convert.ToInt32(LoaiXuatNhap.PhieuXuat);
            //    HC_DuTruVanPhongPham_NhapXuat_Coll coll = (HC_DuTruVanPhongPham_NhapXuat_Coll)bindingSourceXuatkho.DataSource;
            //    coll.Save();
            //}
            //catch (Exception ex) {
            //    GlobalCommon.ShowError(ex);
            //}
        }

        private void radGridViewXuat_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            //try
            //{
            //    HC_DuTruVanPhongPham_NhapXuat_Info item = (HC_DuTruVanPhongPham_NhapXuat_Info)e.Row.DataBoundItem;
            //    if (item == null || item.IsNew)
            //        return;

            //    HC_DuTruVanPhongPham_NhapXuat_Coll coll = (HC_DuTruVanPhongPham_NhapXuat_Coll)bindingSourceXuatkho.DataSource;
            //    if (coll.IsDirty)
            //    {
            //        coll.Save();
            //    }

            //}
            //catch (Exception ex)
            //{
            //    GlobalCommon.ShowError(ex);
            //}
        }

        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (radPageView1.SelectedPage == Ton) {
                bindingSourceTonKho.DataSource = HC_ThietBiTienLamSang_NhapXuat_Coll.GetHC_ThietBiTienLamSang_NhapXuat_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition3));
                RadGrid = radGridViewTonKho;
                HideNew();
                ShowPrint2 = false;
                HideDelete();
                //radGridViewTonKho.DataSource = bindingSourceTonKho;  
                
            }
            else if (radPageView1.SelectedPage == Xuat)
            {
                //ShowPrint2 = true;
                //TextPrint2 = "In Phiếu Bàn Giao";
                RadGrid = radGridViewXuat;
                ShowDelete();
                ShowNew();
            }
            else
            {
                ShowPrint2 = false;
                ShowDelete();
                ShowNew();
            }
        }
        private void PrintPhieuBanGiaoThietBi()
        {
            //FormMode frMode = new FormMode();
            //HC_DuTruVanPhongPham_NhapXuat_Coll listThietBi = HC_DuTruVanPhongPham_NhapXuat_Coll.NewHC_DuTruVanPhongPham_NhapXuat_Coll();
            //bool Err = false;
            //string temp = string.Empty;
            //HC_ThietBiTienLamSang_Coll cvColl = (HC_ThietBiTienLamSang_Coll)bindingSourceThietbi.DataSource;
            //foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridViewXuat.ChildRows)
            //{
            //    if (Convert.ToBoolean(rowInfo.Cells["InPhieu"].Value))
            //    {
            //        //foreach (HC_ThietBiTienLamSang_Info cvInfo in cvColl)
            //        //{
            //        //    if (rowInfo.Cells["IdThietBi"].Value.ToString() == cvInfo.ID.ToString())
            //        //    {
            //        //        temp = cvInfo.TenThietBi;
            //        //    }
            //        //}
            //        listThietBi.Add((HC_DuTruVanPhongPham_NhapXuat_Info)rowInfo.DataBoundItem);
                    
            //    }
            //}
            //frMode.ItemColl = listThietBi;
            //if (listThietBi.Count > 0)
            //{
            //    Form_BanGiaoThietBi fr = new Form_BanGiaoThietBi(frMode);
            //    fr.ShowDialog();
            //}
            //else
            //{
            //    if (!Err)
            //        GlobalCommon.ShowErrorMessager("Bạn chưa chọn thiết bị nào!");
            //}
        }
        private void PrintThongKeTonKho()
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Tên Thiết bị", "Nhập", "Xuất", "Tồn" };
            //string temp = string.Empty;
           // HC_DuTruVanPhongPham_Coll cvColl = (HC_DuTruVanPhongPham_Coll)bindingSourceThietbi.DataSource;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridViewTonKho.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    HC_ThietBiTienLamSang_NhapXuat_Info itemInfo = (HC_ThietBiTienLamSang_NhapXuat_Info)rowInfo.DataBoundItem;
                    //foreach (HC_DuTruVanPhongPham_Info cvInfo in cvColl)
                    //{
                    //    if (rowInfo.Cells["IdThietBi"].Value.ToString() == cvInfo.ID.ToString())
                    //    {
                    //        temp = cvInfo.TenThietBi;
                    //        break;
                    //    }
                    //}
                   // cvItem.E_Value = new List<string>() { temp, rowInfo.Cells["TongNhap"].Value.ToString(), rowInfo.Cells["TongXuat"].Value.ToString(), rowInfo.Cells["SoLuong"].Value.ToString() };
                    cvItem.E_Value = new List<string>() { itemInfo.TenThietBi, itemInfo.TongNhap.ToString(), itemInfo.TongXuat.ToString(), itemInfo.SoLuongTon.ToString() };
                    cv.E_Content.Add(cvItem);
                }
            }
            cv.E_TieuDeBaoCao = "Danh sách tồn kho Thiết bị tiền lâm sàng";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TuNgayDenNgay = string.Empty;
            //cv.ProcessTuNgayDenNgay(1); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }
        private void PrintDuTruVanPhongPham()
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Tên thiết bị", "Nhập", "Xuất", "Tồn" };
            //string temp = string.Empty;
            // HC_DuTruVanPhongPham_Coll cvColl = (HC_DuTruVanPhongPham_Coll)bindingSourceThietbi.DataSource;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridViewTonKho.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    HC_ThietBiTienLamSang_NhapXuat_Info itemInfo = (HC_ThietBiTienLamSang_NhapXuat_Info)rowInfo.DataBoundItem;
                    //foreach (HC_DuTruVanPhongPham_Info cvInfo in cvColl)
                    //{
                    //    if (rowInfo.Cells["IdThietBi"].Value.ToString() == cvInfo.ID.ToString())
                    //    {
                    //        temp = cvInfo.TenThietBi;
                    //        break;
                    //    }
                    //}
                    // cvItem.E_Value = new List<string>() { temp, rowInfo.Cells["TongNhap"].Value.ToString(), rowInfo.Cells["TongXuat"].Value.ToString(), rowInfo.Cells["SoLuong"].Value.ToString() };
                    cvItem.E_Value = new List<string>() { itemInfo.TenThietBi, itemInfo.TongNhap.ToString(), itemInfo.TongXuat.ToString(), itemInfo.SoLuongTon.ToString() };
                    cv.E_Content.Add(cvItem);
                }
            }
            cv.E_TieuDeBaoCao = "Phiếu dự trù văn phòng phẩm";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TuNgayDenNgay = string.Empty;
            //cv.ProcessTuNgayDenNgay(1); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }

        private void GridViewNhapKho_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (int.TryParse(GridViewNhapKho.CurrentRow.Cells["Id"].Value.ToString(), out selectedID)
                    && GlobalCommon.IsHavePermission(new string[]{TextMessages.RolePermission.HC_ThietBiTienLamSang_NhapXuat_Edit,TextMessages.RolePermission.HC_ThietBiTienLamSang_NhapXuat_View}))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    formMode.Item = LoaiXuatNhap.PhieuNhap;
                    Form_ThietBiTLS_NhapXuat fr = new Form_ThietBiTLS_NhapXuat(formMode);
                    fr.ShowDialog();
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }

        }

        private void radGridViewXuat_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (int.TryParse(radGridViewXuat.CurrentRow.Cells["Id"].Value.ToString(), out selectedID)
                    && GlobalCommon.IsHavePermission(new string[] { TextMessages.RolePermission.HC_ThietBiTienLamSang_NhapXuat_Edit, TextMessages.RolePermission.HC_ThietBiTienLamSang_NhapXuat_View }))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    formMode.Item = LoaiXuatNhap.PhieuXuat;
                    formMode.ItemColl = bindingSourceTonKho.DataSource;
                    Form_ThietBiTLS_NhapXuat fr = new Form_ThietBiTLS_NhapXuat(formMode);
                    fr.ShowDialog();
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }
    }
}
