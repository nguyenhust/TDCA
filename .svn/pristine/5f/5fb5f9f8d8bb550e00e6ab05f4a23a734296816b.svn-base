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
using ModuleHanhChinh.UI;
using ModuleHanhChinh.LIB;
using ExportLib;
using Authoration.LIB;


namespace ModuleHanhChinh.UserControl
{
    public partial class Grid_HC_ThietBiVatTu : UsDictionary
    {
        #region variables

        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        #endregion

        public Grid_HC_ThietBiVatTu()
        {
            InitializeComponent();
            RadGrid = radGridView;
            radGridView.CellDoubleClick += radGridView_CellDoubleClick;
            radGridView.CellFormatting += radGridView_CellFormatting;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            //PrintToShow();
            TextPrint = "In Danh sách";
            TextPrint2 = "In Phiếu mượn";
            TextPrint3 = "In Phiếu bàn giao";
            ShowPrint2 = true;
            ShowPrint3 = true;
        }
        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.HC_ThietBiVatTu;
        }
         
        public override string ToString()
        {
            return TextMessages.FormTitle.HC_ThietBiVatTu;
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_ThietBiVatTu_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_ThietBiVatTu_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_ThietBiVatTu_Del);
        }

        protected override void Save()
        {
            formMode.IsInsert = true;
            Form_VatTuTaiSan fr = new Form_VatTuTaiSan(formMode);
            fr.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            try
            {
                this.radGridView.DataSource = HC_VatTuTaiSan_Coll.GetHC_VatTuTaiSan_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridView));

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
        protected override void Print2()
        {
            try
            {
                PrintPhieuMuonThietBi();
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
                PrintPhieuBanGiaoThietBi();
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
                    HC_VatTuTaiSan.DeleteHC_VatTuTaiSan(selectedID);
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

        private void radGridView_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }

        private void radGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (int.TryParse(radGridView.CurrentRow.Cells["Id"].Value.ToString(), out selectedID)
                    && GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_ThietBiVatTu_Edit))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    Form_VatTuTaiSan fr = new Form_VatTuTaiSan(formMode);
                    fr.ShowDialog();
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }
        private void PrintToHTML()
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Tên vật tư","Mã thiết bị", "Serial", "Tình trạng", "Ngày nhập","Nguồn kinh phí", "Cán bộ quản lý" };
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    HC_VatTuTaiSan_Info itemInfo = (HC_VatTuTaiSan_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { itemInfo.TenVatTu,itemInfo.MaVatTu, itemInfo.SerialMay, itemInfo.TinhTrang, itemInfo.NgayNhap,itemInfo.TenNguonKinhPhi, itemInfo.TenCanBoQuanLy };
                    cv.E_Content.Add(cvItem);
                }
            }
            cv.E_TieuDeBaoCao = "Danh sách vật tư thiết bị";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TuNgayDenNgay = string.Empty;
            cv.IsNamDoc = false;
            //cv.ProcessTuNgayDenNgay(1); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }
        private void PrintPhieuMuonThietBi()
        {
            FormMode frMode = new FormMode();
            frMode.Item = LoaiPhieu.PhieuMuonThietBi;
            HC_VatTuTaiSan_Coll listThietBi = HC_VatTuTaiSan_Coll.NewHC_VatTuTaiSan_Coll();
            bool Err = false;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (Convert.ToBoolean(rowInfo.Cells["ChoMuon"].Value))
                {
                    HC_VatTuTaiSan_Info itemInfo = (HC_VatTuTaiSan_Info)rowInfo.DataBoundItem;
                    if (itemInfo.TinhTrang != "Đang Cho Mượn")
                    {
                        itemInfo.TinhTrang = "Đang Cho Mượn";
                        listThietBi.Add(itemInfo);
                    }
                    else
                    {
                        Err = true;
                    }
                }
            }
            frMode.ItemColl = listThietBi;
            if (Err)
                GlobalCommon.ShowMessageInformation("Trong số các thiết bị bạn chọn có một số đã được cho mượn, số thiết bị này sẽ không được thêm vào phiếu mượn.");
            if (listThietBi.Count > 0)
            {
                Form_ChoMuonThietBi fr = new Form_ChoMuonThietBi(frMode);
                fr.ShowDialog();
            }
            else
            {
                if (!Err)
                    GlobalCommon.ShowErrorMessager("Bạn chưa chọn thiết bị nào!");
            }
        }
        private void PrintPhieuBanGiaoThietBi()
        {
            FormMode frMode = new FormMode();
            frMode.Item = LoaiPhieu.PhieuBanGiaoThietBi;
            HC_VatTuTaiSan_Coll listThietBi = HC_VatTuTaiSan_Coll.NewHC_VatTuTaiSan_Coll();
            bool Err = false;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (Convert.ToBoolean(rowInfo.Cells["ChoMuon"].Value))
                {
                    HC_VatTuTaiSan_Info itemInfo = (HC_VatTuTaiSan_Info)rowInfo.DataBoundItem;
                    if (itemInfo.TinhTrang != "Đang Cho Mượn")
                    {
                        itemInfo.TinhTrang = "Đang Cho Mượn";
                        listThietBi.Add(itemInfo);
                    }
                    else
                    {
                        Err = true;
                    }
                }
            }
            frMode.ItemColl = listThietBi;
            if (Err)
                GlobalCommon.ShowMessageInformation("Trong số các thiết bị bạn chọn có một số đã được cho mượn, số thiết bị này sẽ không được thêm vào phiếu mượn.");
            if (listThietBi.Count > 0)
            {
                Form_ChoMuonThietBi fr = new Form_ChoMuonThietBi(frMode);
                fr.ShowDialog();
            }
            else
            {
                if (!Err)
                    GlobalCommon.ShowErrorMessager("Bạn chưa chọn thiết bị nào!");
            }
        }

        private void radGridView_Click(object sender, EventArgs e)
        {

        }
    }
}
