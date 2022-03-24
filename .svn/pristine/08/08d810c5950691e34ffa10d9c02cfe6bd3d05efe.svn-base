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
using ModuleHanhChinh.ThanhToan;

namespace ModuleHanhChinh.UI
{
    public partial class Form_LichLamViec : NETLINK.UI.Dictionary
    {
        
        private HC_LichLamViecTT item;
        private string fileUploaded;
        public Form_LichLamViec(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            radBatDau.MyName = "Ngày bắt đầu";
            radKetThuc.MyName = "Ngày kết thúc";
        }
        protected override void ApplyAuthorizationRules()
        {
            btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.HC_LichLamViec_Edit, TextMessages.RolePermission.HC_LichLamViec_Insert });
        }
        protected override void Save()
        {
            try
            {
                if (ValidateDataBeforeSave())
                {
                    BindData(false);
                    item.ApplyEdit();
                    item.Save();
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Lịch làm việc cho:" + item.TenCanBoThucHien);
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
                    item = HC_LichLamViecTT.GetHC_LichLamViecTT(formMode.Id);
                }
                else
                {
                    item = HC_LichLamViecTT.NewHC_LichLamViecTT();
                }
                dropDownBoPhan1.FillData(1);
                gridViewCanBoTDC1.FillData();
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
                    radBatDau.Value_String = item.NgayBatDau;
                    radKetThuc.Value_String = item.NgayKetThuc;
                    radNoiDung.Text = item.NoiDungThucHien;
                    radGhiChu.Text = item.GhiChu;
                    dropDownBoPhan1.Selected_ID = item.IdBoPhan;
                    gridViewCanBoTDC1.Selected_ListItem_ID = item.Backup01;
                   // radTenCanBo.Text = item.TenCanBoThucHien;
                    //if (formMode.IsEdit)
                    //    labelLastEdited.Text = GlobalCommon.GenLastEditString("", item.LastEdited_Date);
                }
                else
                {
                   // item.NgayBatDau = GlobalCommon.FixDate(radDateTimePicker1.Value);
                   // item.NgayKetThuc = GlobalCommon.FixDate(radDateTimePicker2.Value);
                    item.GhiChu = radGhiChu.Text;
                    item.NgayBatDau = radBatDau.Value_String;
                    item.NgayKetThuc = radKetThuc.Value_String;
                    item.NoiDungThucHien = radNoiDung.Text;
                    item.TenCanBoThucHien = gridViewCanBoTDC1.Selected_ListItem_Name;
                    item.Backup01 = gridViewCanBoTDC1.Selected_ListItem_ID;
                    if (dropDownBoPhan1.Selected_ID != null)
                        item.IdBoPhan = Convert.ToInt32(dropDownBoPhan1.Selected_ID);
                    item.LastEdited_UserID = PTIdentity.IDNguoiDung;
                    item.LastEdited_Date = DateTime.Now;
                }
            }
        }

        private bool ValidateDataBeforeSave()
        {
            if (!radBatDau.isDateTime && !radBatDau.isNull)
            {
                GlobalCommon.ShowErrorMessager(radBatDau.Value_Error);
                return false;
            }
            if (!radKetThuc.isDateTime && !radKetThuc.isNull)
            {
                GlobalCommon.ShowErrorMessager(radKetThuc.Value_Error);
                return false;
            }
            if (GlobalCommon.CheckArrayTextIsNull(new object[] {radNoiDung.Text,gridViewCanBoTDC1.IsNull_String,radBatDau.Value_String,radKetThuc.Value_String,dropDownBoPhan1.Selected_ID }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            if (!GlobalCommon.CheckDateMustBeEarilierOrEqualOther(radKetThuc.Value_String, radBatDau.Value_String))
            {
                GlobalCommon.ShowErrorMessager(string.Format(TextMessages.ErrorMessage.PhaiCungNgayHoacMuonHon, radKetThuc.MyName, radBatDau.MyName));
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
