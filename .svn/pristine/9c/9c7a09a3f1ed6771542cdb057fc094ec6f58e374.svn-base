using NETLINK.LIB;
using DanhMuc.LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Data.SqlClient;
namespace DanhMuc.UI
{
    public partial class HocViInfo : NETLINK.UI.Dictionary
    {
        #region variables

        private DIC_HocVi item;
        private int itemID = -1;
        

        #endregion

        public HocViInfo(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            if (_formMode.IsInsert)
            {
                itemID = 0;
                item = DIC_HocVi.NewDIC_HocVi();
            }
            else
            {
                itemID = _formMode.Id;
                item = DIC_HocVi.GetDIC_HocVi(_formMode.Id);
            }
            bindingSourceHocVi.DataSource = item;
        }

        #region overrides

        protected override void ApplyAuthorizationRules()
        {
            if (!GlobalCommon.IsHavePermission(new string[] { TextMessages.RolePermission.DM_HocVi_Insert, TextMessages.RolePermission.DM_HocVi_Edit }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
                this.Close();
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        protected override void FormLoad()
        {
            try
            {
                if (itemID > 0)
                {
                    if (item.SuDung == true)
                        radCheckBoxIsUse.Checked = true;
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Save()
        {
            try
            {
                if (radTextBox1.Text == "")
                {
                    GlobalCommon.ShowError("Tên viết tắt không được để trống", "Thông báo");
                }
                else
                {
                    item.TenHocVi = radTextBoxTen.Text;
                    if (radCheckBoxIsUse.Checked)
                        item.SuDung = true;
                    item.ApplyEdit();
                    item.Save();
                    this.Close();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        #endregion

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        } 
    }
}
