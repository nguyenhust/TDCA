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
using Authoration.LIB;
using ExportLib;


namespace ModuleHanhChinh.UserControl
{
    public partial class Grid_HC_ThietBiTienLamSang : UsDictionary
    {
        #region variables

        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        #endregion

        public Grid_HC_ThietBiTienLamSang()
        {
            InitializeComponent();
            RadGrid = radGridView;
            radGridView.CellDoubleClick += radGridView_CellDoubleClick;
            radGridView.CellFormatting += radGridView_CellFormatting;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            //PrintToShow();
        }
        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.HC_ThietBiTienLamSang;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.HC_ThietBiTienLamSang;
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_ThietBiTienLamSang_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_ThietBiTienLamSang_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_ThietBiTienLamSang_Del);
        }

        protected override void Save()
        {
            formMode.IsInsert = true;
            Form_ThietBiTLS fr = new Form_ThietBiTLS(formMode);
            fr.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            try
            {
                if (!GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_ThietBiTienLamSang_View))
                {
                    bl_btnDelete = false;
                    bl_btnPrint = false;
                    bl_btnSave = false;
                    throw new Exception(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
                }
                else
                {
                    radbindingSource.DataSource = HC_ThietBiTienLamSang_Coll.GetHC_ThietBiTienLamSang_Coll();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Print()
        {
            PrintToHTML();
        }

        protected override void Delete()
        {
            try
            {
                if (int.TryParse(radGridView.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    HC_ThietBiTienLamSang.DeleteHC_ThietBiTienLamSang(selectedID);
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
                    && GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_ThietBiTienLamSang_Edit))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    Form_ThietBiTLS fr = new Form_ThietBiTLS(formMode);
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
            cv.E_TieuDe = new List<string>() { "Tên thiết bị", "Hãng sản xuất", "Serial", "Tổng tồn kho"};
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    HC_ThietBiTienLamSang_Info itemInfo = (HC_ThietBiTienLamSang_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { itemInfo.TenThietBi, itemInfo.HangSanXuat, itemInfo.SerialThietBi, itemInfo.TongTonKho};
                    cv.E_Content.Add(cvItem);
                }
            }
            cv.E_TieuDeBaoCao = "Danh sách thiết bị tiền lâm sàng";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TuNgayDenNgay = string.Empty;
            //cv.ProcessTuNgayDenNgay(1); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }
    }
}
