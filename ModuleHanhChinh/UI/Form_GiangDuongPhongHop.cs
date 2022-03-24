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
    public partial class Form_GiangDuongPhongHop : NETLINK.UI.Dictionary
    {
        
        private HC_GiangDuong_Phong item;
        public Form_GiangDuongPhongHop(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
        }
        protected override void ApplyAuthorizationRules()
        {
            btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.HC_GiangDuong_Phong_Edit, TextMessages.RolePermission.HC_GiangDuong_Phong_Insert });
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
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Giảng đường phòng họp :" + item.TenPhong);
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
                dropDownTrangThaiPhong1.FillData();
                if (formMode.IsEdit && formMode.Id > 0)
                {
                    item = HC_GiangDuong_Phong.GetHC_GiangDuong_Phong(formMode.Id);
                }
                else
                {
                    item = HC_GiangDuong_Phong.NewHC_GiangDuong_Phong();
                }
                radBindingSource.DataSource = item;
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
                    radtxtGhiChu.Text = item.GhiChu;
                    radtxtThietBiDiKem.Text = item.ThietBiDiKem;
                    dropDownCanBo1.FillData(1);
                    dropDownCanBo1.Selected_ID = item.IdNguoiQuanLy;

                }
                else
                {
                    item.GhiChu = radtxtGhiChu.Text;
                    item.ThietBiDiKem = radtxtThietBiDiKem.Text;
                    item.IdNguoiQuanLy = Convert.ToInt64(dropDownCanBo1.Selected_ID);
                    if (dropDownTrangThaiPhong1.IsAvaible)
                        item.MaPhong = "1";
                    else
                        item.MaPhong = "0";

                }
            }
        }
        private bool ValidateDataBeforeSave()
        {
            if (GlobalCommon.CheckArrayTextIsNull(new string[] {txtDiaDiem.Text,txtTenPhong.Text,dropDownCanBo1.Selected_TextValue.ToString(),dropDownTrangThaiPhong1.Text }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            return true;
        }
    }
}
