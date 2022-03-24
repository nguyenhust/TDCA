using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using NETLINK.UI;
using DanhMuc.LIB;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using TruyenThong.LIB;
using NETLINK.LIB;
using Authoration.LIB;

namespace TruyenThong.UI
{
    public partial class DKThietKe : Dictionary
    {
        
        private TT_PhieuDangKyThietKe item;
        private string fileUploaded;
        public DKThietKe(FormMode _formMode)
        {
            InitializeComponent();
           
            this.formMode = _formMode;
            tungay.MyName = "Từ ngày";
            denngay.MyName = "Đến ngày"; ApplyAuthorizationRules();
        }
        protected override void ApplyAuthorizationRules()
        {
            if (formMode.IsInsert)
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.TT_PhieuDangKyThietKe_Insert,TextMessages.RolePermission.TT_DuyetPhieuDangKyThietKe_Insert });
            else
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.TT_PhieuDangKyThietKe_Edit,TextMessages.RolePermission.TT_DuyetPhieuDangKyThietKe_Edit });
        
           // btnSave.Enabled = GlobalCommon.IsHavePermission(new[] {, });
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
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Form Đăng Kí Thiết Kế - Truyền Thông |" +item.IDNguoiDK);
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
                dropCBDuyet.FillData(1);
                dropCBThucHien.FillData(2);
                dropCBYeucau.FillData(3);
                dropDownTinhTrang1.FillData();
                if (formMode.IsEdit && formMode.Id64 > 0)
                {
                    item = TT_PhieuDangKyThietKe.GetTT_PhieuDangKyThietKe(formMode.Id64);
                }
                else
                {
                    item = TT_PhieuDangKyThietKe.NewTT_PhieuDangKyThietKe();
                }
                BindData(true);
                ProcessBussiness();
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
                    dropCBDuyet.Selected_ID = item.IDNguoiDuyet;
                    dropCBThucHien.Selected_ID = item.IDCanBo;
                    dropCBYeucau.Selected_ID = item.IDNguoiDK;
                    tungay.Value_String = item.TuNgay;
                    denngay.Value_String = item.DenNgay;
                    txtslduyet.Text = item.SLDuyet.ToString();
                    txtslyeucau.Text = item.SLYeuCau.ToString();
                    dropDownTinhTrang1.Text = item.TinhTrang;
                    txtnoidung.Text = item.NoiDung;
                    txtghichu.Text = item.GhiChu;
                    radBrowseEditor1.Text = item.LinkFile;
                    if (formMode.IsEdit && !string.IsNullOrEmpty(item.LinkFile))
                        radButton1.Enabled = true;
                    else
                        radButton1.Enabled = false;
                }
                else
                {
                    if (dropDownLoai1.Selected_ID != null)
                        item.IDLoai = Convert.ToInt32(dropDownLoai1.Selected_ID);
                    item.TuNgay = tungay.Value_String;
                    item.DenNgay = denngay.Value_String;
                    if (dropCBYeucau.Selected_ID != null)
                        item.IDNguoiDK = Convert.ToInt64(dropCBYeucau.Selected_ID);
                    if (dropCBThucHien.Selected_ID != null)
                        item.IDCanBo = Convert.ToInt64(dropCBThucHien.Selected_ID);
                    if (dropCBDuyet.Selected_ID != null)
                        item.IDNguoiDuyet = Convert.ToInt64(dropCBDuyet.Selected_ID);
                    item.NoiDung = txtnoidung.Text;
                    item.GhiChu = txtghichu.Text;
                    if (formMode.IsEdit)
                    {
                        item.TinhTrang = dropDownTinhTrang1.Text;
                    }
                    else
                    {
                        item.TinhTrang = "Chờ duyệt";
                        item.Backup01 = PTIdentity.IDNguoiDung.ToString();
                    }
                    if (string.IsNullOrEmpty(txtslduyet.Text))
                        item.SLDuyet = 0;
                    else
                        item.SLDuyet = Convert.ToInt32(txtslduyet.Text);
                    item.SLYeuCau = Convert.ToInt32(txtslyeucau.Text);
                    if (!string.IsNullOrEmpty(fileUploaded))
                    item.LinkFile = fileUploaded;
                    item.LastEdited_UserID = PTIdentity.IDNguoiDung;
                    item.LastEdited_Date = DateTime.Now;
                    
                }
            }
        }
        private void ProcessBussiness()
        {
            if (formMode.IsInsert)
            {
                dropCBDuyet.Enabled = false;
                dropDownTinhTrang1.Enabled = false;
                dropDownTinhTrang1.Text = "Chờ duyệt";
                txtslduyet.Enabled = false;
            }
            else
            {
                txtnoidung.Enable = false;
                txtslduyet.Enabled = false;
                txtslyeucau.Enabled = false;
                dropDownTinhTrang1.Enabled = false;
                dropDownLoai1.Enabled = false;
                dropCBDuyet.Enabled = false;
                dropCBThucHien.Enabled = false;
                dropCBYeucau.Enabled = false;
                tungay.Enabled = false;
                denngay.Enabled = false;
                radBrowseEditor1.Enabled = false;
                txtnoidung.Enable = false;
                if(GlobalCommon.IsHavePermission(new []{TextMessages.RolePermission.TT_DuyetPhieuDangKyThietKe_Insert,TextMessages.RolePermission.TT_DuyetPhieuDangKyThietKe_Edit}))
                {
                    dropCBDuyet.Enabled = true;
                    dropCBThucHien.Enabled = true;
                    txtslduyet.Enabled = true;
                    dropDownTinhTrang1.Enabled = true;

                }
                if (item.Backup01 == PTIdentity.IDNguoiDung.ToString() && item.TinhTrang !="Đã Duyệt" && GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.TT_PhieuDangKyThietKe_Edit, TextMessages.RolePermission.TT_PhieuDangKyThietKe_Insert }))
                {
                    txtnoidung.Enable = true;
                   // txtslduyet.Enabled = false;
                    txtslyeucau.Enabled = true;
                   // dropDownTinhTrang1.Enabled = false;
                    dropDownLoai1.Enabled = true;
                    //dropCBDuyet.Enabled = false;
                    dropCBThucHien.Enabled = true;
                    dropCBYeucau.Enabled = true;
                    tungay.Enabled = true;
                    denngay.Enabled = true;
                    radBrowseEditor1.Enabled = true;
                    txtnoidung.Enable = true;
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
            if (GlobalCommon.CheckArrayTextIsNull(new object[] {dropDownLoai1.Selected_TextValue, tungay.Value_String, denngay.Value_String }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            if (!GlobalCommon.CheckDateMustBeEarilierOrEqualOther(denngay.Value_String, tungay.Value_String))
            {
                GlobalCommon.ShowErrorMessager(string.Format(TextMessages.ErrorMessage.PhaiCungNgayHoacMuonHon, denngay.MyName, tungay.MyName));
                return false;
            }
            if (!GlobalCommon.CheckIsNumber(txtslyeucau.Text))
            {
                GlobalCommon.ShowErrorMessager("Số lượng yêu cầu phải là một số");
                return false;
            }
            if(!GlobalCommon.CheckIsNumber(txtslduyet.Text))
            {
                GlobalCommon.ShowErrorMessager("Số lượng duyệt phải là một số");
                return false;
            }
            if (!string.IsNullOrEmpty(txtslduyet.Text) && !string.IsNullOrEmpty(txtslyeucau.Text) && Convert.ToInt32(txtslduyet.Text) > Convert.ToInt32(txtslyeucau.Text))
            {
                GlobalCommon.ShowErrorMessager("Số lượng duyệt không thể lớn hơn số lượng yêu cầu");
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
