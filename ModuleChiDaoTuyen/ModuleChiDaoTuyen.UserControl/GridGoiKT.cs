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
    public partial class GridGoiKT : UsDictionary
    {
        private CDT_GoiKT goiKT;
        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        public GridGoiKT()
        {
            InitializeComponent();
            radGridView.CellDoubleClick += radGridView_CellDoubleClick;
            RadGrid = radGridView;
            STT();
            TextPrint2 = "In danh sách";
            ShowPrint2 = true;
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            PrintToShow();
        }


        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.CDT_GoiKyThuat;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.CDT_GoiKyThuat;
        }

        protected override void ApplyAuthorizationRules()
        {
            // nếu có được quyền tối thiểu thì cho phép vào form
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_GoiKyThuat_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_GoiKyThuat_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_GoiKyThuat_Delete);
        }

        protected override void Save()
        {

            formMode.IsInsert = true;
            GoiKyThuat fr = new GoiKyThuat(formMode);
            fr.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            try
            {
                radbindingSource.DataSource = CDT_GoiKT_Coll.GetCDT_GoiKT_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Print()
        {
            try
            {
                radbindingSource.DataSource = CDT_GoiKT_Coll.GetCDT_GoiKT_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
        protected override void Print2()
        {
            try
            {
                PrintToHTML();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Delete()
        {
            try
            {
                if (int.TryParse(radGridView.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    CDT_GoiKT.DeleteCDT_GoiKT(selectedID);
                    LoadUS();
                }


            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void MyClose()
        {
            
        }

        #endregion

        private void CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
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
                    GoiKyThuat fr = new GoiKyThuat(formMode);
                    fr.ShowDialog();
                    LoadUS();
                }


            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
        private void PrintToHTML()
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Tên gói KT","Nội dung", "Ghi chú" };
            cv.E_FilterExpression = this.FilterExpression;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    CDT_GoiKT_Info itemInfo = (CDT_GoiKT_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { itemInfo.TenGoiKT,itemInfo.NoiDungChuyenGiao,itemInfo.GhiChu};
                    cv.E_Content.Add(cvItem);
                }
            }
            cv.E_TieuDeBaoCao = "Danh sách gói kỹ thuật";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TuNgayDenNgay = string.Empty;
            //cv.ProcessTuNgayDenNgay(2); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }
    }
}
