using NETLINK.UI;
using NETLINK.LIB;
using DanhMuc.LIB;
using DanhMuc.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using ModuleDaoTao.LIB;

namespace ModuleDaoTao.UI
{
    public partial class Form_CQ_ThoiKhoaBieu : NETLINK.UI.Dictionary
    {
        #region variables

        
        private int selectedID = -1;
        

        #endregion


        public Form_CQ_ThoiKhoaBieu(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
        }

        private void FormThoiKhoaBieu_Load(object sender, EventArgs e)
        {
        }

        #region overrides

        protected override void ApplyAuthorizationRules()
        {
            this.btnSave.Enabled = (Csla.ApplicationContext.User.IsInRole("GoiKyThuat:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == TextMessages.RolePermission.SystemAdmin
            || Csla.ApplicationContext.User.IsInRole("GoiKyThuat:U"));
        }

        protected override void FormLoad()
        {
            try
            {
                LoadUs();
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }


        #endregion

        private void LoadUs()
        {
            try
            {
                radbindingSource.DataSource = DT_ChinhQuy_ThoiKhoaBieu_Coll.GetDT_ChinhQuy_ThoiKhoaBieu_Coll();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radGridView1_Click(object sender, EventArgs e)
        {

        }

       

        private void radGridView_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                if (int.TryParse(radGridView.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    formMode.StringId = radGridView.CurrentRow.Cells["Id"].Value.ToString();
                    LoadUs();
                }
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void radGridView_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }

    }
}
