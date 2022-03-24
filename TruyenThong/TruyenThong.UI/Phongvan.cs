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

namespace TruyenThong.UI
{
    public partial class PhongVan : Dictionary
    {
        
        private TT_PhongVan item;
        private TT_PhongVanCT_Coll listChild;
        private string fileUploaded;
        public PhongVan(FormMode _formMode)
        {
            InitializeComponent();
            
            this.formMode = _formMode;
            ApplyAuthorizationRules();
            thoigian.MyName = "Thời gian";
        }
        protected override void ApplyAuthorizationRules()
        {
            if (formMode.IsInsert)
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.TT_PhongVan_Insert });
            else
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.TT_PhongVan_Edit });
        
           // btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.TT_PhongVan_Insert, TextMessages.RolePermission.TT_PhongVan_Edit });
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
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Form Phỏng Vấn - Truyền Thông |" + item.ID);
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
                dropDownChuyenKhoa1.FillData(1);
                dropDownCoQuan1.FillData(1);
                if (formMode.IsEdit && formMode.Id64 > 0)
                {
                    item = TT_PhongVan.GetTT_PhongVan(formMode.Id64);
                    
                }
                else
                {
                    item = TT_PhongVan.NewTT_PhongVan();
                    
                    
                }
                bindingDanhSachPV.DataSource = listChild;
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
                    
                    txtDienThoai.Text = item.SoDienThoai;
                    thoigian.Value_String = item.ThoiGian;
                    dropDownChuyenKhoa1.Selected_ID = item.KhoaLamViec;
                    dropDownCoQuan1.Selected_ID = item.IDCoQuanCT;
                    txtGiayGioiThieu.Text = item.SoGiayGioiThieu;
                    txtNoiDung.Text = item.NoiDung;
                    txtGhiChu.Text = item.Ghichu;
                    if (formMode.IsEdit && !string.IsNullOrEmpty(item.LinkFile))
                        radButton1.Enabled = true;
                    else
                        radButton1.Enabled = false;
                    txtTenPV.Text = item.TenPhongVien;
                    txtNguoiTiep.Text = item.NguoiTiep;
                    radBrowseEditor1.Value = item.LinkFile;
                }
                else
                {
                    item.SoGiayGioiThieu = txtGiayGioiThieu.Text;
                    item.NoiDung = txtNoiDung.Text;
                    item.SoDienThoai = txtDienThoai.Text;
                    item.Ghichu = txtGhiChu.Text;
                    if (!string.IsNullOrEmpty(thoigian.Value_String))
                        item.ThoiGian = thoigian.Value_String;
                    if (dropDownChuyenKhoa1.Selected_ID != null)
                        item.KhoaLamViec = Convert.ToInt64(dropDownChuyenKhoa1.Selected_ID);
                    if (dropDownCoQuan1.Selected_ID != null)
                        item.IDCoQuanCT = Convert.ToInt32(dropDownCoQuan1.Selected_ID);
                    if (!string.IsNullOrEmpty(fileUploaded))
                    item.LinkFile = fileUploaded;
                    item.LastEdited_UserID = PTIdentity.IDNguoiDung;
                    item.LastEdited_Date = DateTime.Now;
                    item.NguoiTiep = txtNguoiTiep.Text;
                    item.TenPhongVien = txtTenPV.Text;
                    //if (formMode.IsInsert)
                    //    item.PhongVanCTColl = listChild;
                }
            }
        }
        private bool ValidateDataBeforeSave()
        {
            if (!thoigian.isDateTime && !thoigian.isNull)
            {
                GlobalCommon.ShowErrorMessager(thoigian.Value_Error);
                return false;
            }
            if (GlobalCommon.CheckArrayTextIsNull(new object[] {dropDownCoQuan1.Selected_TextValue,txtNoiDung.Text,thoigian.Value_String }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            if (!string.IsNullOrEmpty(txtDienThoai.Text) && !GlobalCommon.Check_MustHasANumber(txtDienThoai.Text))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DinhDangDienThoaiSai);
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

        private void dropDownCoQuan1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dropDownCoQuan1.Selected_Item != null)
                {
                    DIC_CoQuan_Info itemInfo = (DIC_CoQuan_Info)dropDownCoQuan1.Selected_Item;
                    txtDiaChi.Text = itemInfo.DiaChi;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
    }
}
