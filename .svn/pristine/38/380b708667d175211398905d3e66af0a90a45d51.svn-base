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
using ModuleDaoTao.LIB;

namespace ModuleDaoTao.UI
{
    public partial class Form_DA_DuAn : NETLINK.UI.Dictionary
    {
        #region variables

        
        private DT_DuAn item;
        private int seletedID = -1;

        #endregion

        public Form_DA_DuAn(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            if (_formMode.IsInsert)
            {
                seletedID = 0;
                item = DT_DuAn.NewDT_DuAn();
            }
            else
            {
                seletedID = _formMode.Id;
                item = DT_DuAn.GetDT_DuAn(seletedID);
            }
            bindingSourceMain.DataSource = item;
            this.btnSave.CausesValidation = false;
        }

        #region form's events

        private void Form_DA_DuAn_Load(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control control in this.Controls)
                {
                    control.Focus();
                    if (Validate())
                    {
                        DialogResult = System.Windows.Forms.DialogResult.None;
                        return;
                    }
                }
                item.IdNguoiThucHien = Convert.ToInt32(dropDownCanBo.Selected_ID);
                item.NoiDung = richTextBoxWithBigEditorNoiDung.Text;
                item.ApplyEdit();
                item.Save();
                this.Close();
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        #endregion

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
                dropDownCanBo.FillData(1);
                if (seletedID > 0)
                {

                    richTextBoxWithBigEditorNoiDung.Text = item.NoiDung;

                    dropDownCanBo.Selected_ID = item.IdNguoiThucHien;
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        /*protected override void Save()
        {
            base.Save();
        }*/


        #endregion

        #region validating events

        private void radTextBox1_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string errMessage;
                if (ValidCheck.ValidEmpty(radTextBox1.Text, out errMessage))
                {
                    this.errorProvider_Duan.SetError(radTextBox1, errMessage);
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void radTextBox2_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string errMessage;
                if (ValidCheck.ValidEmpty(radTextBox2.Text, out errMessage))
                {
                    this.errorProvider_Duan.SetError(radTextBox2, errMessage);
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void radTextBox3_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string errMessage;
                if (!ValidCheck.ValidNumber(radTextBox3.Text, out errMessage))
                {
                    this.errorProvider_Duan.SetError(radTextBox3, errMessage);
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        #endregion
    }
}
