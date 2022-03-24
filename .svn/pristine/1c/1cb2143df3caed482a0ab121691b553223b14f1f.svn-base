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
using ExportLib;

namespace ModuleHanhChinh.UI
{
    public partial class Form_XinXe : NETLINK.UI.Dictionary
    {
        
        private HC_XinXe item;
        public Form_XinXe(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            radNgayDi.MyName = "Ngày đi";
            radNgayVe.MyName = "Ngày về";
        }
        protected override void ApplyAuthorizationRules()
        {
            btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.HC_XinXe_Edit, TextMessages.RolePermission.HC_XinXe_Insert });
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
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Xin xe idCanBoDangKi:" + item.IdCanBoDangKi);
                    GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
                    if (formMode.IsInsert)
                        PrintToHTML();
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
                if (formMode.IsInsert)
                {
                    btnPrint.Visible = false;
                }
                dropDownBoPhan1.FillData(1);
                dropDownCanBo1.FillData(1);
                dropDownChucVu1.FillData(1);
                dropDownBenhVien1.FillData(1);
                if (formMode.IsEdit && formMode.Id > 0)
                {
                    item = HC_XinXe.GetHC_XinXe(formMode.Id);
                }
                else
                {
                    item = HC_XinXe.NewHC_XinXe();
                }
                radBindingSource.DataSource = item;
                dropDownNguonKinhPhi1.FillData(1);
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
                    radNgayDi.Value_String = item.GioBatDau;
                    radNgayVe.Value_String = item.GioTra;
                    radtxtGhiChu.Text = item.GhiChu;
                    dropDownNguonKinhPhi1.Selected_ID = item.IdNguonKinhPhi;
                    dropDownCanBo1.Selected_ID = item.IdCanBoDangKi;
                    dropDownChucVu1.Selected_ID = item.IdChucVu;
                    dropDownBoPhan1.Selected_ID = item.IdBoPhan;
                    dropDownBenhVien1.Selected_ID = item.IdBenhVienNoiDen;
                    if (formMode.IsEdit)
                    {
                        radLabel12.Text = GlobalCommon.GenLastEditString(item.LastEdited_UserName, item.LastEdited_Date.ToString(TextMessages.Config.DateAndTimeFormat));
                    }
                    else
                    {
                        radLabel12.Text = string.Empty;
                    }
                }
                else
                {
                    
                    item.GhiChu = radtxtGhiChu.Text;
                    item.GioBatDau = radNgayDi.Value_String;
                    item.GioTra = radNgayVe.Value_String;
                    item.LastEdited_UserID = PTIdentity.IDNguoiDung;
                    item.LastEdited_Date = DateTime.Now;
                    if (dropDownBoPhan1.Selected_ID != null)
                        item.IdBoPhan = Convert.ToInt32(dropDownBoPhan1.Selected_ID);
                    if (dropDownCanBo1.Selected_ID != null)
                        item.IdCanBoDangKi = Convert.ToInt64(dropDownCanBo1.Selected_ID);
                    if (dropDownChucVu1.Selected_ID != null)
                        item.IdChucVu = Convert.ToInt32(dropDownChucVu1.Selected_ID);
                    if(dropDownNguonKinhPhi1.Selected_ID != null)
                        item.IdNguonKinhPhi = Convert.ToInt32(dropDownNguonKinhPhi1.Selected_ID);
                    if (dropDownBenhVien1.Selected_ID != null)
                        item.IdBenhVienNoiDen = Convert.ToInt64(dropDownBenhVien1.Selected_ID);
                }
            }
        }
        private bool ValidateDataBeforeSave()
        {
            if (!radNgayDi.isDateTime && !radNgayDi.isNull)
            {
                GlobalCommon.ShowErrorMessager(radNgayDi.Value_Error);
                return false;
            }
            if (!radNgayVe.isDateTime && !radNgayVe.isNull)
            {
                GlobalCommon.ShowErrorMessager(radNgayVe.Value_Error);
                return false;
            }
            if(!string.IsNullOrEmpty(radSoKM.Text) && !GlobalCommon.CheckIsNumber(radSoKM.Text))
            {
                GlobalCommon.ShowErrorMessager("Số KM phải là một số");
                return false;
            }
            if (!string.IsNullOrEmpty(radSoNguoi.Text) && !GlobalCommon.CheckIsNumber(radSoNguoi.Text))
            {
                GlobalCommon.ShowErrorMessager("Số Người phải là một số");
                return false;
            }
            if (GlobalCommon.CheckArrayTextIsNull(new object[] { radNgayDi.Value_String, radNgayVe.Value_String,dropDownBenhVien1.Selected_TextValue,radnoidung.Text,dropDownNguonKinhPhi1.Selected_TextValue,dropDownBoPhan1.Selected_TextValue }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            if (!GlobalCommon.CheckDateMustBeEarilierOrEqualOther(radNgayVe.Value_String, radNgayDi.Value_String))
            {
                GlobalCommon.ShowErrorMessager(string.Format(TextMessages.ErrorMessage.PhaiCungNgayHoacMuonHon, radNgayVe.MyName, radNgayDi.MyName));
                return false;
            }
            return true;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                PrintToHTML();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void PrintToHTML()
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.P0010_PhieuXinXe cv = new ExportLib.Entities.HanhChinh.P0010_PhieuXinXe();
            cv.NoiDung = item.NoiDung;
            if (dropDownChucVu1.Selected_TextValue != null)
                cv.ChucVu = dropDownChucVu1.Selected_TextValue.ToString();
            else
                cv.ChucVu = string.Empty;
            cv.NgayDi = item.GioBatDau;
            cv.NgayVe = item.GioTra;
            cv.NgayLapBaoCao = GlobalCommon.StringProcess.ForReport.HaNoiNgayThangNam(DateTime.Now);
            if (dropDownCanBo1.Selected_TextValue != null)
                cv.NguoiDangKy = dropDownCanBo1.Selected_TextValue.ToString();
            else
                cv.NguoiDangKy = string.Empty;
            cv.NguoiKy = PTIdentity.FullName;
            if (dropDownNguonKinhPhi1.Selected_TextValue != null)
                cv.NguonKinhPhi = dropDownNguonKinhPhi1.Selected_TextValue.ToString();
            else
                cv.NguonKinhPhi = string.Empty;
            if (dropDownBenhVien1.Selected_TextValue != null)
                cv.NoiDen = dropDownBenhVien1.Selected_TextValue.ToString();
            else
                cv.NoiDen = string.Empty;
            if (dropDownBoPhan1.Selected_TextValue != null)
                cv.Phong = dropDownBoPhan1.Selected_TextValue.ToString();
            else
                cv.Phong = string.Empty;
            cv.SoKm = item.SoKM;
            cv.SoNguoi = item.SoNguoi;
            ex.B101_PhieuXinXe(cv);
        }
        private bool Selected = false;
        private void dropDownCanBo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Selected)
                {
                    dropDownChucVu1.Selected_ID = dropDownCanBo1.Selected_Item_IDChucVu;
                    dropDownBoPhan1.Selected_ID = dropDownCanBo1.Selected_Item_IDBoPhan;
                }
                Selected = true;
            }
            catch (Exception ex)
            {
            }
        }

        private void dropDownBenhVien1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dropDownBenhVien1.Selected_Item != null)
                {
                    DIC_BenhVien_Info benhVien = (DIC_BenhVien_Info)dropDownBenhVien1.Selected_Item;
                    int kc = 0;
                    if (int.TryParse(benhVien.KhoangCach, out kc))
                    {
                        radSoKM.Text = Convert.ToString(kc * 2);
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
