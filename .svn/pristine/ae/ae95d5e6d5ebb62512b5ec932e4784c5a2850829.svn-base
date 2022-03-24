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
    public partial class GridQuanLyDuAn : UsDictionary
    {
        #region variables

        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        #endregion

        public GridQuanLyDuAn()
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
            return TextMessages.ControlID.DT_DuAn;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.DT_DuAn;
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_QuanLyDuAn_Insert);
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_QuanLyDuAn_View);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_QuanLyDuAn_Del);
        }

        protected override void Save()
        {
            formMode.IsInsert = true;
            Form_DA_DuAn fr = new Form_DA_DuAn(formMode);
            fr.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            try
            {
                if (!GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_QuanLyDuAn_View))
                {
                    bl_btnDelete = false;
                    bl_btnPrint = false;
                    bl_btnSave = false;
                    throw new Exception(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
                }
                else
                {
                    bindingSourceDuAn.DataSource = DT_DuAn_Coll.GetDT_DuAn_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridView));
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
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
                    DT_DuAn.DeleteDT_DuAn(selectedID);
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
                    formMode.StringId = radGridView.CurrentRow.Cells["TenDuAn"].Value.ToString();
                    Form_DA_DuAn fr = new Form_DA_DuAn(formMode);
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
