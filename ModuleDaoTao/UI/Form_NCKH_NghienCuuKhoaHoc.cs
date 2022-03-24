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
    public partial class Form_NCKH_NghienCuuKhoaHoc : NETLINK.UI.Dictionary
    {
        #region variables

        
        private DT_NghienCuuKhoaHoc item;

        #endregion

        public Form_NCKH_NghienCuuKhoaHoc(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            this.btnSave.CausesValidation = false;
        }

        private void Form_NCKH_NghienCuuKhoaHoc_Load(object sender, EventArgs e)
        {
            try
            {
                dropDownCanBo1.FillData(1);
                if (formMode.IsInsert == true) // tạo mới
                {
                    item = DT_NghienCuuKhoaHoc.NewDT_NghienCuuKhoaHoc();
                    bindingSourceMain.DataSource = item;
                }
                else // cập nhật - chỉnh sửa
                {
                    item = DT_NghienCuuKhoaHoc.GetDT_NghienCuuKhoaHoc(formMode.Id);
                    bindingSourceMain.DataSource = item;
                    richTextBoxWithBigEditorGhichu.Text = item.GhiChu;
                    dropDownCanBo1.Selected_ID = item.IdNguoiThucHien;
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        #region overrides

        protected override void ApplyAuthorizationRules()
        {
            this.btnSave.Enabled = (Csla.ApplicationContext.User.IsInRole("GoiKyThuat:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == TextMessages.RolePermission.SystemAdmin
            || Csla.ApplicationContext.User.IsInRole("GoiKyThuat:U"));
        }

        protected override void Save()
        {
            try
            {
                item.IdNguoiThucHien = System.Convert.ToInt64(dropDownCanBo1.Selected_ID);
                item.GhiChu = richTextBoxWithBigEditorGhichu.Text;
                item.ApplyEdit();
                item.Save();
                this.Close();
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        #endregion

        #region validating events

        private void radTextBox1_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string errMessage;
                if (ValidCheck.ValidEmpty(radTextBox1.Text, out errMessage))
                {
                    this.errorProvider_NCKH.SetError(radTextBox1, errMessage);
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        #endregion

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
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }
    }
}
