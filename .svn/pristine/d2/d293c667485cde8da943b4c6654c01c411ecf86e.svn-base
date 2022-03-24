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
    public partial class Grid_HC_LichLamViec : UsDictionary
    {
        #region variables

        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        #endregion

        public Grid_HC_LichLamViec()
        {
            InitializeComponent();
            RadGrid = radGridView;
            radGridView.CellDoubleClick += radGridView_CellDoubleClick;
            radGridView.CellFormatting += radGridView_CellFormatting;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
        }
        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.HC_LichLamViec;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.HC_LichLamViec;
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_LichLamViec_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_LichLamViec_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_LichLamViec_Del);
        }

        protected override void Save()
        {
            formMode.IsInsert = true;
            Form_LichLamViec fr = new Form_LichLamViec(formMode);
            fr.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            try
            {
                radbindingSource.DataSource = HC_LichLamViecTT_Coll.GetHC_LichLamViecTT_Coll();
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
                if (int.TryParse(radGridView.CurrentRow.Cells["Id"].Value.ToString(), out selectedID)
    && GlobalCommon.AcceptDelete())
                {
                    HC_LichLamViecTT_Info itemInfo = (HC_LichLamViecTT_Info)radGridView.CurrentRow.DataBoundItem;
                    
                    HC_LichLamViecTT.DeleteHC_LichLamViecTT(selectedID);
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
                    && GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_LichLamViec_Edit))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    Form_LichLamViec fr = new Form_LichLamViec(formMode);
                    fr.ShowDialog();
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }
        private void PrintToHTML()
        {
            RadGrid.Columns["TenBoPhan"].Sort(Telerik.WinControls.UI.RadSortOrder.Ascending, false);
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Phòng","Nội dung","Người thực hiện","Từ ngày","Đến ngày" };
            cv.E_FilterExpression = this.FilterExpression;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    HC_LichLamViecTT_Info itemInfo = (HC_LichLamViecTT_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    string bp = itemInfo.TenBoPhan;
                    if (string.IsNullOrEmpty(bp))
                        bp = "(Bỏ trống)";
                    cvItem.E_Value = new List<string>() { bp, itemInfo.NoiDungThucHien, itemInfo.TenCanBoThucHien, itemInfo.NgayBatDau, itemInfo.NgayKetThuc };
                    cv.E_Content.Add(cvItem);
                }
            }
       
            cv.E_TieuDeBaoCao = "Lịch làm việc trung tâm";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_isCenter = false;
            cv.IsNamDoc = false;
            cv.ProcessTuNgayDenNgay(3); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv,2);
        }
    }
}
