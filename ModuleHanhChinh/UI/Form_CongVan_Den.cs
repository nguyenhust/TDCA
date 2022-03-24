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
using Authoration.LIB;

namespace ModuleHanhChinh.UI
{
    public partial class Form_CongVan_Den : NETLINK.UI.Dictionary
    {
        
        private HC_CongVanDen item;
        private string fileUploaded;
        public Form_CongVan_Den(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            this.btnSave.CausesValidation = false;
            txtDateCV.MyName = "Ngày Ban Hành";
            txtDateNgayGui.MyName = "Ngày gửi";
        }
        
        protected override void ApplyAuthorizationRules()
        {
            try
            {
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.HC_CongVanDi_Insert, TextMessages.RolePermission.HC_CongVanDi_Edit });
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
                if (ValidateDataBeforeSave() && UploadFile())
                {
                    BindData(false);
                    item.ApplyEdit();
                    item = item.Save();
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Công văn đi số :" + item.SoCongVan);
                    GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
                    this.Close();
                }
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
                FillDataForDropDownBox();
                if (formMode.IsEdit && formMode.Id > 0)
                {
                    item = HC_CongVanDen.GetHC_CongVanDen(formMode.Id);
                    
                }
                else
                {
                    item = HC_CongVanDen.NewHC_CongVanDen();
                    item.LuuTruTai = "Văn Phòng Trung Tâm";
                    item.NguoiNhan = "";
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
                    txtNoiDung.Text = item.NoiDung;
                    txtVeVanDe.Text = item.VeVanDe;
                    //if (GlobalCommon.CheckDate(item.NgayGui))
                    txtDateNgayGui.Value_String = item.NgayTiepNhan;
                    // if (GlobalCommon.CheckDate(item.NgayKi))
                    txtDateCV.Value_String = item.NgayKi;
                    if (formMode.IsEdit)
                    {
                        radLabel14.Text = GlobalCommon.GenLastEditString(item.LastEdited_UserName, item.LastEdited_Date.ToString(TextMessages.Config.DateAndTimeFormat));
                        radButton1.Enabled = true;
                    }
                    else
                    {
                        radLabel14.Text = string.Empty;
                        radButton1.Enabled = false;
                    }
                    radBrowseEditor1.Value = item.LinkFile;
                    //if (formMode.IsInsert)
                    //{
                    //    radTextBox6.Text = "Văn Phòng Trung Tâm";
                    //    radTextBox2.Text = "GS. TS Phạm Minh Thông";

                    //}
                }
                else
                {
                    item.HuongGiaiQuyet = radtxtHuongGiaiQuyet.Text;
                    item.NoiDung = txtNoiDung.Text;
                    item.VeVanDe = txtVeVanDe.Text;
                    item.NgayTiepNhan = txtDateNgayGui.Value_String;
                    item.NgayKi = txtDateCV.Value_String;
                    item.LinkFile = fileUploaded;
                    item.LastEdited_UserID = PTIdentity.IDNguoiDung;
                    item.LastEdited_Date = DateTime.Now;
                }
            }
        }

        private void radTextBox4_Validating(object sender, CancelEventArgs e)
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
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void radLabel14_Click(object sender, EventArgs e)
        {

        }

   
        private void FillDataForDropDownBox()
        {
            dropDownCapQuanLy1.FillData();
            dropDownLoaiCongVan1.FillData();
        }
        private bool ValidateDataBeforeSave()
        {
            if (!txtDateNgayGui.isDateTime && !txtDateNgayGui.isNull)
            {
                GlobalCommon.ShowErrorMessager(txtDateNgayGui.Value_Error);
                return false;
            }
            if (!txtDateCV.isDateTime && !txtDateCV.isNull)
            {
                GlobalCommon.ShowErrorMessager(txtDateNgayGui.Value_Error);
                return false;
            }
            if (GlobalCommon.CheckArrayTextIsNull(new string[] {txtDateCV.Value_String, txtNoiDung.Text, txtSoCV.Text,  txtVeVanDe.Text, dropDownCapQuanLy1.Text, dropDownLoaiCongVan1.Text }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            return true;
        }
        private bool UploadFile()
        {
            if (radBrowseEditor1.Value != null && !string.IsNullOrEmpty(radBrowseEditor1.Value.ToString()) && radBrowseEditor1.Value != item.LinkFile)
            {
                FtpUltilies ftp = new FtpUltilies();
                if (!ftp.UploadLargeFile(radBrowseEditor1.Value, true, out fileUploaded))
                {
                    GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.FileUploadLoi);
                    return false;
                }
            }
            return true;
        }

        private void Form_CongVan_Di_Load(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (formMode.IsEdit && !string.IsNullOrEmpty(item.LinkFile))
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

        private void txtSoCV_TextChanged(object sender, EventArgs e)
        {
            //txtSoCV.Text += "/BM - TDC";
        }

        private void txtVeVanDe_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNoiDung.Text))
                txtNoiDung.Text = txtVeVanDe.Text;
        }

        private void txtSoCV_Leave(object sender, EventArgs e)
        {
            if (txtSoCV.Text.IndexOf("BM") == -1 && txtSoCV.Text.IndexOf("TDC") == -1 && txtSoCV.Text.IndexOf("-") == -1)
            {
                txtSoCV.Text += "/BM - TDC";
            }
        }
    }
}
