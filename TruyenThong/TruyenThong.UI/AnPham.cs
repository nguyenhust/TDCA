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
using Telerik.WinControls.UI;
using DanhMuc.LIB;
using Telerik.WinControls.Data;
using NETLINK.LIB;
using Authoration.LIB;
using System.Linq;

namespace TruyenThong.UI
{
    public partial class AnPham : Dictionary
    {
        
        private TT_AnPham item;
        private string fileUploaded;
        public AnPham(FormMode _formMode)
        {
            InitializeComponent();
            
            this.formMode = _formMode;
            tungay.MyName = "Từ ngày";
            denngay.MyName = "Đến ngày"; ApplyAuthorizationRules();
        }
        protected override void ApplyAuthorizationRules()
        {
            if (formMode.IsInsert)
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.TT_AnPham_Insert });
            else
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.TT_AnPham_Edit });
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
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Form Ấn Phẩm - Truyền Thông :"+item.Ten);
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
                    item = TT_AnPham.GetTT_AnPham(formMode.Id64);
                }
                else
                {
                    item = TT_AnPham.NewTT_AnPham();
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
                    richTextBoxWithBigEditor1.Text = item.NoiDung;
                    richTextBoxWithBigEditor2.Text = item.GhiChu;
                    tungay.Value_String = item.TuNgay;
                    denngay.Value_String = item.DenNgay;
                    txtAnPham.Text = item.Ten;
                    txtDonViDat.Text = item.DonViDat;
                    radMaskedEditBox1.Value = item.SoLuong;
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
                    item.NoiDung = richTextBoxWithBigEditor1.Text;
                    item.GhiChu = richTextBoxWithBigEditor2.Text;
                    item.TuNgay = tungay.Value_String;
                    item.DenNgay = denngay.Value_String;
                    if (radMaskedEditBox1.Value != null)
                        item.SoLuong = Convert.ToInt32(radMaskedEditBox1.Value);
                    item.Ten = txtAnPham.Text;
                    item.DonViDat = txtDonViDat.Text;
                    if (!string.IsNullOrEmpty(fileUploaded))
                        item.LinkFile = fileUploaded;
                    item.LastEdited_UserID = PTIdentity.IDNguoiDung;
                    item.LastEdited_Date = DateTime.Now;
                }
            }
        }
        private bool ValidateDataBeforeSave()
        {
            if (!tungay.isDateTime && !tungay.isNull)
            {
                GlobalCommon.ShowErrorMessager(tungay.Value_Error);
                return false;
            }
            if (!denngay.isDateTime && !denngay.isNull)
            {
                GlobalCommon.ShowErrorMessager(denngay.Value_Error);
                return false;
            }
            if (GlobalCommon.CheckArrayTextIsNull(new object[] {txtAnPham.Text,dropDownLoai1.Selected_TextValue,radMaskedEditBox1.Text,tungay.Value_String,denngay.Value_String }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            if (!GlobalCommon.CheckDateMustBeEarilierOrEqualOther(denngay.Value_String, tungay.Value_String))
            {
                GlobalCommon.ShowErrorMessager(string.Format(TextMessages.ErrorMessage.PhaiCungNgayHoacMuonHon, denngay.MyName, tungay.MyName));
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.WindowState = FormWindowState.Maximized;
                txtAnPham.Location = new Point(txtAnPham.Location.X + 200, txtAnPham.Location.Y);
                dropDownLoai1.Location = new Point(dropDownLoai1.Location.X + 200, dropDownLoai1.Location.Y);
                radMaskedEditBox1.Location = new Point(radMaskedEditBox1.Location.X + 500, radMaskedEditBox1.Location.Y);
                txtDonViDat.Location = new Point(txtDonViDat.Location.X + 200, txtDonViDat.Location.Y);
                tungay.Location = new Point(tungay.Location.X + 200, tungay.Location.Y);
                denngay.Location = new Point(denngay.Location.X + 500, denngay.Location.Y);
                radLabel5.Location = new Point(radLabel5.Location.X + 300, radLabel5.Location.Y);
                radLabel7.Location = new Point(radLabel7.Location.X + 300, radLabel7.Location.Y);
                
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
    }
}
