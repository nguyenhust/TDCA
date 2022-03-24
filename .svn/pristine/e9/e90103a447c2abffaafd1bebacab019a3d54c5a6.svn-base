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
using ModuleChiDaoTuyen.LIB;
using ModuleChiDaoTuyen.UI;
using ExportLib;
using Authoration.LIB;

namespace ModuleChiDaoTuyen.UserControl
{
    public partial class GridHopDongCGKT : UsDictionary
    {
                 #region variables

        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        #endregion

        public GridHopDongCGKT()
        {
            InitializeComponent();
            RadGrid = radGridView;
            radGridView.CellDoubleClick += radGridView_CellDoubleClick;
            radGridView.CellFormatting += radGridView_CellFormatting;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
           // PrintToShow();
        }
        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.CDT_HopDongKyThuat;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.CDT_HopDongKyThuat;
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_HopDongKyThuat_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_HopDongKyThuat_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_HopDongKyThuat_Delete);
        }

        protected override void Save()
        {
            formMode.IsInsert = true;
            Form_HopDongCGKT fr = new Form_HopDongCGKT(formMode);
            fr.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            try
            {
                if (!GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_HopDongKyThuat_View))
                {
                    bl_btnDelete = false;
                    bl_btnPrint = false;
                    bl_btnSave = false;
                    throw new Exception(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
                }
                else
                {
                    radbindingSource.DataSource = CDT_HopDongCGKT_Coll.GetCDT_HopDongCGKT_Coll();
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
                    CDT_HopDongCGKT.DeleteCDT_HopDongCGKT(selectedID);
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
                    && GlobalCommon.IsHavePermission(new string[]{TextMessages.RolePermission.CDT_HopDongKyThuat_View,TextMessages.RolePermission.CDT_HopDongKyThuat_Edit}))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    Form_HopDongCGKT fr = new Form_HopDongCGKT(formMode);
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
            cv.E_TieuDe = new List<string>() { "Mã hợp đồng","Ngày kí","Bên A","Người đại diện","Bên B","Người đại diện" };
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    CDT_HopDongCGKT_Info itemInfo = (CDT_HopDongCGKT_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { itemInfo.MaHopDong, itemInfo.NgayKiKet, itemInfo.TenBenhVienA, itemInfo.A_NguoiDaiDien, itemInfo.TenBenhVienB, itemInfo.B_NguoiDaiDien };
                    cv.E_Content.Add(cvItem);
                }
            }
            cv.E_TieuDeBaoCao = "Danh sách hợp đồng chuyển giao kỹ thuật";

            cv.E_TenTrungTam = "Phòng Chỉ đạo tuyến";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TuNgayDenNgay = string.Empty;
            //cv.ProcessTuNgayDenNgay(2); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }
    }
}
