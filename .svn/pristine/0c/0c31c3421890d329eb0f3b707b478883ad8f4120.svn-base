using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using NETLINK.LIB;
using NETLINK.UI;
using TruyenThong.LIB;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using DanhMuc.LIB;
using Csla.Windows;
using Authoration.LIB;

namespace TruyenThong.UI
{
    public partial class SuKien : Dictionary
    {
        
        private TT_SuKien item;
        private string fileUploaded;
        public SuKien(FormMode _formMode)
        {
            InitializeComponent();
            
            this.formMode = _formMode;
            ApplyAuthorizationRules();
            netLink_DatePicker1.MyName = "Ngày";
           
        }
        protected override void ApplyAuthorizationRules()
        {
            if (formMode.IsInsert)
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.TT_SuKien_Insert });
            else
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.TT_SuKien_Edit });
        
          //  btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.TT_SuKien_Insert, TextMessages.RolePermission.TT_SuKien_Edit });
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
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Form Sự Kiện - Truyền Thông |" + item.Ten);
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
                dropDownLoai1.FillData(1);
                dropDownChuyenKhoa1.FillData(1);
               
                if (formMode.IsEdit && formMode.Id64 > 0)
                {
                    item = TT_SuKien.GetTT_SuKien(formMode.Id64);
                }
                else
                {
                    item = TT_SuKien.NewTT_SuKien();
                }
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
                    dropDownLoai1.Selected_ID = item.IDLoai;
                    richTextBoxWithBigEditor1.Text = item.GhiChu;
                    txtTen.Text = item.Ten;
                    txtDiaDiem.Text = item.DiaDiem;
                    txtChuTri.Text = item.ChuTri;
                    dropDownChuyenKhoa1.Selected_ID = item.IDChuyenNganh;
                    netLink_DatePicker1.Value_String = item.ThoiGian;
                    radBrowseEditor1.Value = item.LinkFile;
                    if (formMode.IsEdit && !string.IsNullOrEmpty(item.LinkFile))
                        radButton1.Enabled = true;
                    else
                        radButton1.Enabled = false;
                }
                else
                {
                    if (dropDownLoai1.Selected_ID != null)
                        item.IDLoai = Convert.ToInt32(dropDownLoai1.Selected_ID);
                    if (dropDownChuyenKhoa1.Selected_ID != null)
                        item.IDChuyenNganh = Convert.ToInt32(dropDownChuyenKhoa1.Selected_ID);
                    item.Ten = txtTen.Text;
                    item.DiaDiem = txtDiaDiem.Text;
                    item.ChuTri = txtChuTri.Text;
                    item.ThoiGian = netLink_DatePicker1.Value_String;
                    item.GhiChu = richTextBoxWithBigEditor1.Text;
                    if (!string.IsNullOrEmpty(fileUploaded))
                    item.LinkFile = fileUploaded;
                    item.LastEdited_UserID = PTIdentity.IDNguoiDung;
                    item.LastEdited_Date = DateTime.Now;
                }
            }
        }
        private bool ValidateDataBeforeSave()
        {
            if (!netLink_DatePicker1.isDateTime && !netLink_DatePicker1.isNull)
            {
                GlobalCommon.ShowErrorMessager(netLink_DatePicker1.Value_Error);
                return false;
            }
            if (GlobalCommon.CheckArrayTextIsNull(new object[] { txtTen.Text, dropDownLoai1.Selected_TextValue, dropDownChuyenKhoa1.Text,netLink_DatePicker1.Value_String}))
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

        private void radButton1_Click_1(object sender, EventArgs e)
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
    }
}
