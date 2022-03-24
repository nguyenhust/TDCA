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
    public partial class Form_GiangVien : Dictionary
    {
        
        private CDT_HopDong_GoiKT_CanBoTrienKhai item;
        private CDT_HopDongCGKT itemCGKT;
        public Form_GiangVien(FormMode _formMode)
        {
            InitializeComponent();
            batdauA.MyName = "Ngày bắt đầu";
            batdauB.MyName = "Ngày bắt đầu";
            kethucB.MyName = "Ngày kết thúc";
            ketthucA.MyName = "Ngày kết thúc";
            this.formMode = _formMode;
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
                if (ValidateDataBeforeSave())
                {
                    BindData(false);
                    item.ApplyEdit();
                    item.Save();
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "CDT - Hop Dong CGKT - Giang Vien" + this.Text);
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
                dropDownChucVu1.FillData(1);
                dropDownChuyenKhoa1.FillData(1);
                dropDownChuyenNganh1.FillData(1);

                dropDownTrinhDo1.FillData(1);
                if (formMode.IsEdit && formMode.Id > 0)
                {
                    item = CDT_HopDong_GoiKT_CanBoTrienKhai.GetCDT_HopDong_GoiKT_CanBoTrienKhai(formMode.Id);
                }
                else
                {
                    item = CDT_HopDong_GoiKT_CanBoTrienKhai.NewCDT_HopDong_GoiKT_CanBoTrienKhai();
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
                        dropDownGoiKyThuat1.FillData(itemCGKT.ID);
                        BenhVienA.Text = string.Format("Chuyển giao tại {0}", itemCGKT.TenBenhVienA);
                        BenhVienB.Text = string.Format("Chuyển giao tại {0}", itemCGKT.TenBenhVienB);
                    }
                    else
                    {
                        BenhVienA.Text = "Chuyển giao tại bệnh viện A";
                        BenhVienB.Text = "Chuyển giao tại bệnh viện B";
                    }
                    dropDownChucVu1.Selected_ID = item.IdChucVu;
                    dropDownTrinhDo1.Selected_ID = item.IdTrinhDo;
                    dropDownGoiKyThuat1.Selected_IDGoiKT = item.IdGoiKT;
                    txtghichu.Text = item.Backup01;
                    txtHoTen.Text = item.GiangVien;
                    txtEmail.Text = item.Email;
                    txtDienthoai.Text = item.DienThoai;
                    txtnoidung.Text = item.NoiDungDaoTao;
                    dropDownChuyenNganh1.Selected_ID = item.IdChuyenNganh;
                    dropDownChuyenKhoa1.Selected_ID = item.IdChuyenKhoa;
                    batdauA.Value_String = item.A_NgayBatDau;
                    batdauB.Value_String = item.B_NgayBatDau;
                    kethucB.Value_String = item.B_NgayKetThuc;
                    ketthucA.Value_String = item.A_NgayKetThuc;
                }
                else
                {
                    if (dropDownChucVu1.Selected_ID != null)
                        item.IdChucVu = Convert.ToInt32(dropDownChucVu1.Selected_ID);
                    if (dropDownTrinhDo1.Selected_ID != null)
                        item.IdTrinhDo = Convert.ToInt32(dropDownTrinhDo1.Selected_ID);
                    if (dropDownGoiKyThuat1.Selected_IDGoiKT != null)
                        item.IdGoiKT = Convert.ToInt32(dropDownGoiKyThuat1.Selected_IDGoiKT);
                    item.GiangVien = txtHoTen.Text;
                    item.NoiDungDaoTao = txtnoidung.Text;
                    item.A_NgayBatDau = batdauA.Value_String;
                    item.A_NgayKetThuc = ketthucA.Value_String;
                    item.B_NgayBatDau = batdauB.Value_String;
                    item.B_NgayKetThuc = kethucB.Value_String;
                    item.Email = txtEmail.Text;
                    item.DienThoai = txtDienthoai.Text;
                    if (dropDownChuyenKhoa1.Selected_ID != null)
                        item.IdChuyenKhoa = Convert.ToInt32(dropDownChuyenKhoa1.Selected_ID);
                    if (dropDownChuyenNganh1.Selected_ID != null)
                        item.IdChuyenNganh = Convert.ToInt32(dropDownChuyenNganh1.Selected_ID);
                    item.Backup01 = txtghichu.Text;
                    if (itemCGKT != null && itemCGKT.ID != null)
                        item.IdHopDong = itemCGKT.ID;
                    item.LastEdited_Date = DateTime.Now;
                    item.LastEdited_UserID = PTIdentity.IDNguoiDung;
                }
            }
        }
        private bool ValidateDataBeforeSave()
        {
            if (!batdauA.isDateTime && !batdauA.isNull)
            {
                GlobalCommon.ShowErrorMessager(batdauA.Value_Error);
                return false;
            }
            if (!batdauB.isDateTime && !batdauB.isNull)
            {
                GlobalCommon.ShowErrorMessager(batdauB.Value_Error);
                return false;
            }
            if (!kethucB.isDateTime && !kethucB.isNull)
            {
                GlobalCommon.ShowErrorMessager(kethucB.Value_Error);
                return false;
            }
            if (!ketthucA.isDateTime && !ketthucA.isNull)
            {
                GlobalCommon.ShowErrorMessager(ketthucA.Value_Error);
                return false;
            }
            if (GlobalCommon.CheckArrayTextIsNull(new object[] { txtHoTen.Text,dropDownChucVu1.Selected_TextValue,dropDownTrinhDo1.Selected_TextValue}))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            if (!string.IsNullOrEmpty(txtDienthoai.Text) && !GlobalCommon.Check_MustHasANumber(txtDienthoai.Text))
            {
                GlobalCommon.ShowErrorMessager("Định dạng điện thoại sai");
                return false;
            }
            if (!string.IsNullOrEmpty(txtEmail.Text) && !GlobalCommon.CheckEmail(txtEmail.Text))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DinhDangEmailSai);
                return false;
            }
            if (!GlobalCommon.CheckDateMustBeEarilierOrEqualOther(ketthucA.Value_String, batdauA.Value_String))
            {
                GlobalCommon.ShowErrorMessager(string.Format(TextMessages.ErrorMessage.PhaiCungNgayHoacMuonHon, ketthucA.MyName, batdauA.MyName));
                return false;
            }
            if (!GlobalCommon.CheckDateMustBeEarilierOrEqualOther(kethucB.Value_String, batdauB.Value_String))
            {
                GlobalCommon.ShowErrorMessager(string.Format(TextMessages.ErrorMessage.PhaiCungNgayHoacMuonHon, kethucB.MyName, batdauB.MyName));
                return false;
            }
            return true;
        }


    }
}
