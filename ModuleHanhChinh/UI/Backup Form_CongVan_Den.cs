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
using ModuleHanhChinh.LIB;

namespace ModuleHanhChinh.UI
{
    public partial class BackupForm_CongVan_Den : NETLINK.UI.Dictionary
    {
        
        private HC_CongVanDi item;
        private HC_CongVanDi_NoiNhan_Coll listItem;
        public BackupForm_CongVan_Den(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            this.btnSave.CausesValidation = false;
            this.button1.Click += button1_Click;
            radTextBox1.Enabled = false;
            radTextBox2.Enabled = false;
            radTextBox3.Enabled = false;
            radTextBox4.Enabled = false;
            radTextBox5.Enabled = false;
            radTextBox6.Enabled = false;
            radDateTimePicker1.Enabled = false;
            btnSave.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(item.LinkFile))
                {
                    FtpUltilies ftp = new FtpUltilies();
                    ftp.SaveDownloadedFile(item.LinkFile);
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }

            
        }
        protected override void ApplyAuthorizationRules()
        {
            try
            {
                btnSave.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_CongVanDen_Edit);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
                this.Close();
            }
        }
        protected override void Save()
        {
            try
            {
                BindData(false);
                item.ApplyEdit();
                item.Save();
                this.Close();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        protected override void FormLoad()
        {
            try
            {
                dropDownCapQuanLy1.FillData();
                dropDownLoaiCongVan1.FillData();
                if (formMode.IsEdit && formMode.Id > 0)
                {
                    item = HC_CongVanDi.GetHC_CongVanDi(formMode.Id);


                }
                else
                {
                    item = HC_CongVanDi.NewHC_CongVanDi();
                }
                radBindingSource.DataSource = item;
                BindData(true);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void BindData(bool isLoad)
        {
            if (item != null)
            {
                if (isLoad)
                {
                    radtxtHuongGiaiQuyet.Text = item.HuongGiaiQuyet;
                    radtxtNoiDung.Text = item.NoiDung;
                    radtxtVeVanDe.Text = item.VeVanDe;
                    if (GlobalCommon.CheckDate(item.NgayGui))
                        radTextBox3.Text = GlobalCommon.FixDate_Return(item.NgayGui);
                    if (GlobalCommon.CheckDate(item.NgayKi))
                        radDateTimePicker1.Value = Convert.ToDateTime(item.NgayKi);

                    
                }
                else
                {
                    item.HuongGiaiQuyet = radtxtHuongGiaiQuyet.Text;
                }
            }
        }


        private void radTextBox4_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string errMessage;
                if (ValidCheck.ValidEmpty(radTextBox4.Text, out errMessage))
                {
                   // this.errorProvider_CongVanDi.SetError(radTextBox4, errMessage);
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
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
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void radLabel14_Click(object sender, EventArgs e)
        {

        }




    }
}
