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
    public partial class Form_PhieuGiaoViec : NETLINK.UI.Dictionary
    {
        
        private HC_PhieuGiaoViec item;
        private bool cvcuatoi;

        public Form_PhieuGiaoViec(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            radNgayBatDau.MyName = "Bắt đầu từ ngày";
            radNgayHoanThanh.MyName = "Thời hạn hoàn thành";

        }
        protected override void ApplyAuthorizationRules()
        {
            try
            {
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.HC_PhieuGiaoViec_Insert, TextMessages.RolePermission.HC_PhieuGiaoViec_Edit });
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
                if (ValidateData() && UploadFile())
                {

                    BindData(false);
                    item.ApplyEdit();
                    item.Save();
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Hành Chính | Phiếu Giao Việc | Việc ngày " + item.BatDauTuNgay);
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
                dropDownTrangThaiCongViec.FillData();
                if (formMode.IsEdit && formMode.Id > 0)
                {
                    item = HC_PhieuGiaoViec.GetHC_PhieuGiaoViec(formMode.Id);
                }
                else
                { 
                    groupBox1.Visible = false;
                    this.Width = 658;
                    item = HC_PhieuGiaoViec.NewHC_PhieuGiaoViec();
                }
                radBindingSource.DataSource = item;
                gridViewCanBoTDC1.FillData(BusinessFunctionMode.GetDataForGridViewWithCondition2);
                BindData(true);
                ProcessBussiness();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void ProcessBussiness()
        {
            radNgayBatDau.Enabled = false;
            radNgayHoanThanh.Enabled = false;
            radNoidungCongViec.Enable = false;
            radGhiChu.Enable = false;
            gridViewCanBoTDC1.Enable = false;
            radChiTietTienDo.Enabled = true;
            dropDownTrangThaiCongViec.Enabled = false;
            if (formMode.IsEdit)
            {
                if ((item.TrangThai == "Xong" || item.TrangThai == "Hủy") && item.IdNguoiGiaoViec == PTIdentity.IDNguoiDung)
                {
                    dropDownTrangThaiCongViec.Enabled = true;
                    radChiTietTienDo.Enable = false;
                }
                else
                {
                    if (cvcuatoi)
                    {
                        dropDownTrangThaiCongViec.Enabled = true;
                        radChiTietTienDo.Enable = true;
                        
                    }
                    if (item.IdNguoiGiaoViec == PTIdentity.IDNguoiDung)
                    {
                        radChiTietTienDo.Enable = false;
                        radNgayBatDau.Enabled = true;
                        radNgayHoanThanh.Enabled = true;
                        radNoidungCongViec.Enable = true;
                        radGhiChu.Enable = true;
                        gridViewCanBoTDC1.Enable = true;
                    }
                }
            }
            else
            {
                radNgayBatDau.Enabled = true;
                radNgayHoanThanh.Enabled = true;
                radNoidungCongViec.Enable = true;
                radGhiChu.Enable = true;
                gridViewCanBoTDC1.Enable = true;
            }
        }
        private void BindData(bool isLoad)
        {
            if (item != null)
            {
                if (isLoad)
                {

                    if (formMode.IsInsert)
                    {
                        txtNguoiGui.Text = PTIdentity.FullName;
                    }
                    else
                    {
                        if (formMode.Item != null)
                            cvcuatoi = (bool)formMode.Item;
                        txtNguoiGui.Text = item.TenNguoiGiaoViec;
                        radNoidungCongViec.Text = item.NoiDungCongViec;
                        radGhiChu.Text = item.GhiChu;
                        radBrowseEditor1.Value = item.Link;
                        radNgayBatDau.Value_String = item.BatDauTuNgay;
                        radNgayHoanThanh.Value_String = item.PhaiXongNgay;
                        radChiTietTienDo.Text = item.LyDo;
                        dropDownTrangThaiCongViec.Text = item.TrangThai;
                        gridViewCanBoTDC1.Selected_ListItem_ID = item.ListIDCanBoDuocGiao;
                    }
                }
                else
                {
                    if (formMode.IsInsert)
                    {

                        item.IdNguoiGiaoViec = PTIdentity.IDNguoiDung;
                        item.NgayGiao = DateTime.Now.ToShortDateString();
                        item.TrangThai = "Chưa bắt đầu";
                    }
                    else
                    {
                        item.TrangThai = dropDownTrangThaiCongViec.Text;
                    }
                    if (!string.IsNullOrEmpty(fileUploaded))
                        item.Link = fileUploaded;
                    item.LyDo = radChiTietTienDo.Text;
                    item.GhiChu = radGhiChu.Text;
                    item.BatDauTuNgay = radNgayBatDau.Value_String;
                    item.PhaiXongNgay = radNgayHoanThanh.Value_String;
                    item.NoiDungCongViec = radNoidungCongViec.Text;
                    item.ListHoTenCanBoDuocGiao = gridViewCanBoTDC1.Selected_ListItem_Name;
                    item.ListIDCanBoDuocGiao = gridViewCanBoTDC1.Selected_ListItem_ID;
                    item.ListIDUserDuocGiao = gridViewCanBoTDC1.Selected_ListItem_IDUser;
                    if (gridViewCanBoTDC1.Selected_ListItem[0] != null)
                        item.Backup01 = gridViewCanBoTDC1.Selected_ListItem[0].IDBoPhan.ToString();
                }
            }
        }
        private bool ValidateData()
        {
            if (!radNgayBatDau.isDateTime && !radNgayBatDau.isNull)
            {
                GlobalCommon.ShowErrorMessager(radNgayBatDau.Value_Error);
                return false;
            }
            if (!radNgayHoanThanh.isDateTime && !radNgayBatDau.isNull)
            {
                GlobalCommon.ShowErrorMessager(radNgayHoanThanh.Value_Error);
                return false;
            }
            if (GlobalCommon.CheckArrayTextIsNull(new string[] { radNgayBatDau.Value_String, radNgayHoanThanh.Value_String, radNoidungCongViec.Text, gridViewCanBoTDC1.IsNull_String }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            if (!formMode.IsInsert && cvcuatoi && string.IsNullOrEmpty(dropDownTrangThaiCongViec.Text))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            /*if (!GlobalCommon.CheckDateMustBeEarilierOrEqualOther(radNgayHoanThanh.Value_String, radNgayBatDau.Value_String))
            {
                GlobalCommon.ShowErrorMessager(string.Format(TextMessages.ErrorMessage.PhaiCungNgayHoacMuonHon,radNgayHoanThanh.MyName, radNgayBatDau.MyName));
                return false;
            }*/

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            HC_PhieuGiaoViec itemInfo = item.Clone();
            formMode.IsInsert = true;
            groupBox1.Visible = false;
            this.Width = 658;
            item = HC_PhieuGiaoViec.NewHC_PhieuGiaoViec();
            BindData(true);
            ProcessBussiness();
            radNoidungCongViec.Text = itemInfo.NoiDungCongViec;
            radNgayBatDau.Value_String = itemInfo.BatDauTuNgay;
            radNgayHoanThanh.Value_String = itemInfo.PhaiXongNgay;
            radGhiChu.Text = itemInfo.GhiChu;
            gridViewCanBoTDC1.Selected_ListItem_ID = string.Empty;
            radButton1.Enabled = false;
        }
        private string fileUploaded;
        
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
        private void radButton2_Click(object sender, EventArgs e)
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
