using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using NETLINK.UI;
using NETLINK.LIB;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using DanhMuc.LIB;
using System.IO;
using System.Diagnostics;
using Authoration.LIB;
using ModuleChiDaoTuyen.LIB;

namespace ModuleChiDaoTuyen.UI
{
    public partial class Form_TaiChinh : Dictionary
    {
        
        private CDT_KinhPhiCGKT item;
        private string fileUploaded;
        private CDT_HopDongCGKT itemCGKT;
        public Form_TaiChinh(FormMode _formMode)
        {
            InitializeComponent();
            
            this.formMode = _formMode;
            ngayhoadon.MyName = "Ngày xuất hóa đơn";
            ApplyAuthorizationRules();
           
        }
        protected override void ApplyAuthorizationRules()
        {
            if (formMode.IsInsert)
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.CDT_HopDongKyThuat_Insert });
            else
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.CDT_HopDongKyThuat_Edit });
        
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
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Hop dong CGKT - Tai Chinh" + this.Text);
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
                dropDownNguonKinhPhi1.FillData(1);
                if (formMode.IsEdit && formMode.Id > 0)
                {
                    item = CDT_KinhPhiCGKT.GetCDT_KinhPhiCGKT(formMode.Id);
                }
                else
                {
                    item = CDT_KinhPhiCGKT.NewCDT_KinhPhiCGKT();
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
                    if (formMode.Item != null)
                    {
                        itemCGKT = (CDT_HopDongCGKT)formMode.Item;
                        txtMaHopDong.Text = itemCGKT.MaHopDong;
                    }
                    txtDVXuat.Text = item.TenDonViXuat;
                    txtghichu.Text = item.GhiChu;
                    txtMaHoaDon.Text = item.MaHoaDon;
                    txtNguoiThanhToan.Text = item.TenNguoiLay;
                    txtnoidung.Text = item.Noidung;
                    txtThanhTien.Text = item.ThanhTien.ToString();
                    dropDownNguonKinhPhi1.Selected_ID = item.IdNguonKinhPhi;
                    radBrowseEditor1.Value = item.LinkFile;
                    if (formMode.IsEdit && !string.IsNullOrEmpty(item.LinkFile))
                        Open.Enabled = true;
                    else
                        Open.Enabled = false;
                    ngayhoadon.Value_String = item.NgayHoaDon;
                }
                else
                {
                    if (dropDownNguonKinhPhi1.Selected_ID != null)
                        item.IdNguonKinhPhi = Convert.ToInt32(dropDownNguonKinhPhi1.Selected_ID);
                    if (!string.IsNullOrEmpty(txtThanhTien.Text))
                        item.ThanhTien = Convert.ToInt64(txtThanhTien.Text);
                    item.TenDonViXuat = txtDVXuat.Text;
                    item.GhiChu = txtghichu.Text;
                    if (itemCGKT != null && itemCGKT.ID != null)
                        item.IdHopDong = itemCGKT.ID;
                    
                    item.MaHoaDon = txtMaHoaDon.Text;
                    item.TenNguoiLay = txtNguoiThanhToan.Text;
                    item.Noidung = txtnoidung.Text;
                    if (!string.IsNullOrEmpty(fileUploaded))
                        item.LinkFile = fileUploaded;
                    item.NgayHoaDon = ngayhoadon.Value_String;
                    item.LastEdited_Date = DateTime.Now;
                    item.LastEdited_UserID = PTIdentity.IDNguoiDung;
                }
            }
        }
        private bool ValidateDataBeforeSave()
        {
            if (!ngayhoadon.isDateTime && !ngayhoadon.isNull)
            {
                GlobalCommon.ShowErrorMessager(ngayhoadon.Value_Error);
                return false;
            }
            if (GlobalCommon.CheckArrayTextIsNull(new object[] { txtnoidung.Text,txtThanhTien.Text }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            if (!GlobalCommon.CheckIsNumberLong(txtThanhTien.Text))
            {
                GlobalCommon.ShowErrorMessager("Thành tiền phải là một số");
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


        private void Open_Click(object sender, EventArgs e)
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
