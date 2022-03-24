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
    public partial class Form_CQ_TamTru : NETLINK.UI.Dictionary
    {
        #region variables

        
        private DT_ChinhQuy_TamTru item;
        private int selectedID = -1;

        #endregion

        public Form_CQ_TamTru(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            if (_formMode.IsInsert == true)
            {
                selectedID = 0;
                item = DT_ChinhQuy_TamTru.NewDT_ChinhQuy_TamTru();
            }
            else
            {
                selectedID = _formMode.Id;
                item = DT_ChinhQuy_TamTru.GetDT_ChinhQuy_TamTru(_formMode.Id);
            }
            bindingSourceMain.DataSource = item;
        }

        #region form's events

        private void Form_CQ_TamTru_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

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
                if (selectedID > 0)
                {
                    radDateTimePicker1.Value = Convert.ToDateTime(item.NgayDangKi.ToString());
                    radTextBox2.Text = item.TenChuNhaTro;
                    radTextBox3.Text = item.DiaChi;
                    radTextBox1.Text = item.DienThoai;
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Save()
        {
            try
            {
                if(item.IdHocVien != 0)
                {
                //item.NgayDangKi = Convert.ToDateTime(radDateTimePicker1.Text);
                item.TenChuNhaTro = radTextBox2.Text;
                item.DiaChi = radTextBox3.Text;
                item.DienThoai = radTextBox1.Text;
                item.ApplyEdit();
                item.Save();
                this.Close();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        #endregion
    }
}
