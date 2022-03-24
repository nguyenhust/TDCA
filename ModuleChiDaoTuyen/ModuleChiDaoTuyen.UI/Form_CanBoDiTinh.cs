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
    public partial class Form_CanBoDiTinh : Dictionary
    {
        
        private CDT_CanBoDiTinh item;
        public Form_CanBoDiTinh(FormMode _formMode)
        {
            InitializeComponent();
            
            this.formMode = _formMode;
            ngaybatdau.MyName = "Ngày bắt đầu";
            ngayketthuc.MyName = "Kết thúc";
            ApplyAuthorizationRules();
        }
        protected override void ApplyAuthorizationRules()
        {
            if (formMode.IsInsert)
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.CDT_CanBoDiTinh_Insert });
            else
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.CDT_CanBoDiTinh_Edit });
        
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
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Cán bộ đi tỉnh" + this.Text);
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
                dropDownBenhVien1.FillData(1);
                dropDownChuyenKhoa1.FillData(1);
                dropDownNguonKinhPhi1.FillData(1);
                dropDownTrinhDo1.FillData(1);
                dropDownChucVu1.FillData(1);
                if (formMode.IsEdit && formMode.Id > 0)
                {
                    item = CDT_CanBoDiTinh.GetCDT_CanBoDiTinh(formMode.Id);
                }
                else
                {
                    item = CDT_CanBoDiTinh.NewCDT_CanBoDiTinh();
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
            if (isLoad)
            {
                txtHoTen.Text = item.HoTen;
                dropDownChuyenKhoa1.Selected_ID = item.IdChuyenKhoa;
                dropDownBenhVien1.Selected_ID = item.IdBenhVienNoiDen;
                dropDownChucVu1.Selected_ID = item.IdChucVu;
                dropDownTrinhDo1.Selected_ID = item.IdChuyenNganh;
                dropDownNguonKinhPhi1.Selected_ID = item.IdNguonKinhPhi;
                txtghichu.Text = item.GhiChu;
                txtkinhphi.Text = item.TongKinhPhi;
                txtnoidung.Text = item.NoiDungHoatDong;
                ngaybatdau.Value_String = item.NgayBatDau;
                ngayketthuc.Value_String = item.NgayKetThuc;
            }
            else
            {
                if (dropDownBenhVien1.Selected_ID != null)
                    item.IdBenhVienNoiDen = Convert.ToInt32(dropDownBenhVien1.Selected_ID);
                if (dropDownChuyenKhoa1.Selected_Item != null)
                    item.IdChuyenKhoa = Convert.ToInt32(dropDownChuyenKhoa1.Selected_ID);
                if (dropDownChucVu1.Selected_ID != null)
                    item.IdChucVu = Convert.ToInt32(dropDownChucVu1.Selected_ID);
                if (dropDownTrinhDo1.Selected_ID != null)
                    item.IdChuyenNganh = Convert.ToInt32(dropDownTrinhDo1.Selected_ID);
                if (dropDownNguonKinhPhi1.Selected_ID != null)
                    item.IdNguonKinhPhi = Convert.ToInt32(dropDownNguonKinhPhi1.Selected_ID);
                item.GhiChu = txtghichu.Text;
                item.TongKinhPhi = txtkinhphi.Text;
                item.NoiDungHoatDong = txtnoidung.Text;
                item.NgayBatDau = ngaybatdau.Value_String;
                item.NgayKetThuc = ngayketthuc.Value_String;
                item.LastEdited_Date = DateTime.Now;
                item.LastEdited_UserID = PTIdentity.IDNguoiDung;
                item.HoTen = txtHoTen.Text;
                //item.LastEdited_UserID = PTIdentity.IDNguoiDung;
                //item.LastEdited_Date = DateTime.Now;
            }

        }
        private bool ValidateDataBeforeSave()
        {
            if (!ngayketthuc.isDateTime && !ngayketthuc.isNull)
            {
                GlobalCommon.ShowErrorMessager(ngayketthuc.Value_Error);
                return false;
            }
            if (!ngaybatdau.isDateTime && !ngaybatdau.isNull)
            {
                GlobalCommon.ShowErrorMessager(ngaybatdau.Value_Error);
                return false;
            }
            if (GlobalCommon.CheckArrayTextIsNull(new object[] { dropDownChuyenKhoa1.Selected_TextValue,dropDownChucVu1.Selected_TextValue,dropDownTrinhDo1.Selected_TextValue,dropDownBenhVien1.Selected_TextValue,ngaybatdau.Value_String,ngayketthuc.Value_String ,txtHoTen.Text }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            if (!GlobalCommon.CheckDateMustBeEarilierOrEqualOther(ngayketthuc.Value_String, ngaybatdau.Value_String))
            {
                GlobalCommon.ShowErrorMessager(string.Format(TextMessages.ErrorMessage.PhaiCungNgayHoacMuonHon, ngayketthuc.MyName, ngaybatdau.MyName));
                return false;
            }
            return true;
        }

        private void dropDownCanBo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
        
            }
            catch (Exception ex)
            {
               // GlobalCommon.ShowErrorMessager(ex);
            }
        }

    }
}
