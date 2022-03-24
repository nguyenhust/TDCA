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
    public partial class Form_BieuMauISO : NETLINK.UI.Dictionary
    {
        
        private HC_BieuMauISO item;
        private string fileUploaded;
        public Form_BieuMauISO(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
        }
        protected override void ApplyAuthorizationRules()
        {
            btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.HC_BieuMauISO_Insert, TextMessages.RolePermission.HC_BieuMauISO_Edit });
        
       }
        protected override void Save()
        {
            try
            {
                if (ValidateDataBeforeSave() && UploadFile())
                {
                    
                    BindData(false);
                    item.ApplyEdit();
                    item.Save();
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Biểu mẫu ISO: " + item.Ten);
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
                if (formMode.IsEdit && formMode.Id > 0)
                {
                    item = HC_BieuMauISO.GetHC_BieuMauISO(formMode.Id);
                }
                else
                {
                    item = HC_BieuMauISO.NewHC_BieuMauISO();
                }
                dropDownBoPhan1.FillData(1);
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
                    radTextBox1.Text = item.Ten;
                    netLink_DatePicker1.Value_String = item.NgayBatDau;
                    radTextBox2.Text = item.Version;
                    dropDownBoPhan1.Selected_ID = item.IdBoPhan;
                    richTextBoxWithBigEditor2.Text = item.GhiChu;
                    radBrowseEditor1.Value = item.Link;
                    if (formMode.IsEdit)
                    {
                        radButton1.Enabled = true;
                        radLabel7.Text = GlobalCommon.GenLastEditString(item.LastEdited_UserName, item.LastEdited_Date.ToString(TextMessages.Config.DateAndTimeFormat));
                    }
                    else
                    {
                        radButton1.Enabled = false;
                        radLabel7.Text = string.Empty;
                    }
                    if (formMode.IsEdit && item.IdUserUp != PTIdentity.IDNguoiDung)
                    {
                        btnSave.Enabled = false;
                    }
                }
                else
                {
                    //item.NgayBatDau = GlobalCommon.FixDate(radDateTimePicker1.Value);
                    item.GhiChu = richTextBoxWithBigEditor2.Text;
                    item.IdBoPhan = Convert.ToInt32(dropDownBoPhan1.Selected_ID);
                    item.NgayBatDau = netLink_DatePicker1.Value_String;
                    item.Version = radTextBox2.Text;
                    item.Ten = radTextBox1.Text;
                    if (!string.IsNullOrEmpty(fileUploaded))
                        item.Link = fileUploaded;
                    if (formMode.IsInsert)
                        item.IdUserUp = PTIdentity.IDNguoiDung;
                    item.LastEdited_UserID = PTIdentity.IDNguoiDung;
                    item.LastEdited_Date = DateTime.Now;

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        private bool UploadFile()
        {
            if (radBrowseEditor1.Value != null && !string.IsNullOrEmpty(radBrowseEditor1.Value.ToString()) && radBrowseEditor1.Value != item.Link)
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
        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void radLabel4_Click(object sender, EventArgs e)
        {

        }
        private bool ValidateDataBeforeSave()
        {
            if (!netLink_DatePicker1.isDateTime && !netLink_DatePicker1.isNull)
            {
                GlobalCommon.ShowErrorMessager(netLink_DatePicker1.Value_Error);
                return false;
            }
            if (GlobalCommon.CheckArrayTextIsNull(new string[] { radTextBox1.Text }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            return true;
           
        }
        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (formMode.IsEdit && !string.IsNullOrEmpty(item.Link))
                {
                    FtpUltilies ftp = new FtpUltilies();
                    ftp.SaveDownloadedFile(item.Link);
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
    }
}
