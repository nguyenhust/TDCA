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

namespace ModuleDaoTao.UserControls
{
    public partial class GridMonHoc : UsDictionary
    {
        #region variables

        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        #endregion

        public GridMonHoc()
        {
            InitializeComponent();
            RadGrid = radGridView;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            PrintToShow();
        }
        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.DT_MonHoc;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.DT_MonHoc;
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_MonHocChinhQuy_Insert);
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_MonHocChinhQuy_View);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_MonHocChinhQuy_Del);
        }

        protected override void Save()
        {
            formMode.IsInsert = true;
            Form_CQ_MonHoc fr = new Form_CQ_MonHoc(formMode);
            fr.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            try
            {
                if (!GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_MonHocChinhQuy_View))
                {
                    bl_btnSave = false;
                    bl_btnDelete = false;
                }
                else
                {
                    radbindingSource.DataSource = DT_ChinhQuy_MonHoc_Coll.GetDT_ChinhQuy_MonHoc_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridView));
                }
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Print()
        {
            LoadUS();
        }

        protected override void Delete()
        {
            try
            {
                if (int.TryParse(radGridView.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                {
                    DT_ChinhQuy_MonHoc.DeleteDT_ChinhQuy_MonHoc(selectedID);
                    LoadUS();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
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
                    formMode.StringId = radGridView.CurrentRow.Cells["Ten"].Value.ToString();
                    Form_CQ_MonHoc fr = new Form_CQ_MonHoc(formMode);
                    fr.ShowDialog();
                    LoadUS();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
    }
}
