using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using NETLINK.UI;
using TruyenThong.LIB;
using NETLINK.LIB;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using DanhMuc.LIB;
using System.IO;
using Microsoft.Office;
using System.Diagnostics;
using Authoration.LIB;

namespace TruyenThong.UI
{
    public partial class BaiViet : Dictionary
    {
        
        private TT_BaiViet item;
        private string fileUploaded;
        public BaiViet(FormMode _formMode)
        {
            InitializeComponent();
            
            this.formMode = _formMode;
            ngayduyet.MyName = "Ngày duyệt";
            ngaydang.MyName = "Ngày đăng"; ApplyAuthorizationRules();
        }
        protected override void ApplyAuthorizationRules()
        {
            if (formMode.IsInsert)
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.TT_BaiViet_Insert });
            else
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.TT_BaiViet_Edit });
        
           // btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.TT_BaiViet_Insert, TextMessages.RolePermission.TT_BaiViet_Edit });
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
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Form Bài Viết - Truyền Thông :"+item.TieuDe);
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
                if (formMode.IsEdit && formMode.Id64 > 0)
                {
                    item = TT_BaiViet.GetTT_BaiViet(formMode.Id64);
                }
                else
                {
                    item = TT_BaiViet.NewTT_BaiViet();
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
                    txtnoidung.Text = item.NoiDung;
                    txtghichu.Text = item.GhiChu;
                    ngayduyet.Value_String = item.ThoiGianDuyet;
                    ngaydang.Value_String = item.ThoiGianDang;
                    txtLink.Text = item.DuongDan;
                    txtnguoiduyet.Text = item.NguoiDuyet;
                    txttacgia.Text = item.TacGia;
                    txtTieuDe.Text = item.TieuDe;
                    radBrowseEditor1.Value = item.Link;
                    if (formMode.IsEdit && !string.IsNullOrEmpty(item.Link))
                        Open.Enabled = true;
                    else
                        Open.Enabled = false;
                    if (!string.IsNullOrEmpty(txtLink.Text))
                    {
                        radButton1.Enabled = true;
                    }
                    else
                    {
                        radButton1.Enabled = false;
                    }
                }
                else
                {
                    if (dropDownLoai1.Selected_ID != null)
                        item.IDLoai = Convert.ToInt32(dropDownLoai1.Selected_ID);
                    item.NoiDung = txtnoidung.Text;
                    item.GhiChu = txtghichu.Text;
                    if (!string.IsNullOrEmpty(ngayduyet.Value_String))
                        item.ThoiGianDuyet = ngayduyet.Value_String;
                    if (!string.IsNullOrEmpty(ngaydang.Value_String))
                        item.ThoiGianDang = ngaydang.Value_String;
                    item.TacGia = txttacgia.Text;
                    item.TieuDe = txtTieuDe.Text;
                    item.DuongDan = txtLink.Text;
                    item.NguoiDuyet = txtnguoiduyet.Text;
                    if (!string.IsNullOrEmpty(fileUploaded))
                    item.Link = fileUploaded;
                    //item.LastEdited_UserID = PTIdentity.IDNguoiDung;
                    //item.LastEdited_Date = DateTime.Now;
                }
            }
        }
        private bool ValidateDataBeforeSave()
        {
            if (!ngayduyet.isDateTime && !ngayduyet.isNull)
            {
                GlobalCommon.ShowErrorMessager(ngayduyet.Value_Error);
                return false;
            }
            if (!ngaydang.isDateTime && !ngaydang.isNull)
            {
                GlobalCommon.ShowErrorMessager(ngaydang.Value_Error);
                return false;
            }
            if (GlobalCommon.CheckArrayTextIsNull(new object[] { txtnoidung.Text,txttacgia.Text,dropDownLoai1.Text,txtnoidung.Text  }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            if (!GlobalCommon.CheckDateMustBeEarilierOrEqualOther(ngaydang.Value_String, ngayduyet.Value_String))
            {
                GlobalCommon.ShowErrorMessager(string.Format(TextMessages.ErrorMessage.PhaiCungNgayHoacMuonHon, ngaydang.MyName, ngayduyet.MyName));
                return false;
            }
            return true;
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
        private void Link_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo sInfo = new ProcessStartInfo("IExplore.exe", txtLink.Text);
                Process _oProcess = Process.Start(sInfo);
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void Open_Click(object sender, EventArgs e)
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

        private void txtLink_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtLink.Text))
                {
                    radButton1.Enabled = true;
                }
                else
                {
                    radButton1.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
    }
}
