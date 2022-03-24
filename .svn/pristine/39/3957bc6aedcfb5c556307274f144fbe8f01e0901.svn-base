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
    public partial class Form_VatTuTaiSan : NETLINK.UI.Dictionary
    {
        
      private   HC_VatTuTaiSan item;
        private string serialNo = string.Empty;
        public Form_VatTuTaiSan(FormMode _formMode)
        {
            InitializeComponent();
         //   ApplyAuthorizationRules();
            this.formMode = _formMode;
            ApplyAuthorizationRules();
        }

        protected override void ApplyAuthorizationRules()
        {
            btnSave.Enabled = GlobalCommon.IsHavePermission(new []{TextMessages.RolePermission.HC_ThietBiVatTu_Edit,TextMessages.RolePermission.HC_ThietBiVatTu_Insert});
        }
        protected override void Save()
        {
            try
            {
                if (ValidateDataBeforeSave())
                {
                    BindData(false);
                    item.ApplyEdit();
                    item.ApplyEdit();
                    item.Save();
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Vật tư tài sản :" + item.TenVatTu);
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
                dropDownTinhTrangThietBi1.FillData();
                dropDownCanBo1.FillData(1);
                dropDownNguonKinhPhi1.FillData(1);
              //  dropDownLoaiVatTu1.FillData(1);
                radDropLoaiVatTu.DataSource = DIC_LoaiTrangThietBi_Coll.GetDIC_LoaiTrangThietBi_Coll();
                dropTenThietBi.DataSource = HC_DuTruVanPhongPham_Coll.GetHC_DuTruVanPhongPham_Coll();
                //dropDownLoaiVatTu1.DataSource = DIC_LoaiTrangThietBi_Coll.GetDIC_LoaiTrangThietBi_Coll();
                if (formMode.IsEdit && formMode.Id > 0)
                {
                    item = HC_VatTuTaiSan.GetHC_VatTuTaiSan(formMode.Id);
                }
                else
                {
                    item =  HC_VatTuTaiSan.NewHC_VatTuTaiSan();
                }                
                radBindingSource.DataSource = item;
                BindData(true);
                dropTenThietBi.Focus();
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
                    dropDownCanBo1.Selected_ID = item.IdCanBoQuanLy;
                    dropDownNguonKinhPhi1.Selected_ID = item.IdNguonKinhPhi;
                    radPhuKienDiKem.Text = item.PhuKien;
                    radGhiChu.Text = item.GhiChu;
                    netLink_DatePicker1.Value_String = item.NgayNhap;
                    txtSoSerial.Text = item.SerialMay;
                    dropTenThietBi.Text = item.TenVatTu;
                    if (formMode.IsEdit)
                    {
                        serialNo = item.SerialMay;
                        //radLabel15.Text = GlobalCommon.GenLastEditString(item.LastEdited_UserName, item.LastEdited_Date.ToString(TextMessages.Config.DateAndTimeFormat));
                    }
                    else
                    {
                        radLabel15.Text = string.Empty;
                    }
                    //dropDownLoaiVatTu1.Text = item.Type;
                    radDropLoaiVatTu.Text = item.Type;
                }
                else
                {
                    if (serialNo != txtSoSerial.Text)
                        item.SerialMay = txtSoSerial.Text;
                    item.IdNguonKinhPhi = Convert.ToInt32(dropDownNguonKinhPhi1.Selected_ID);
                    item.IdCanBoQuanLy = Convert.ToInt32(dropDownCanBo1.Selected_ID);
                    item.PhuKien = radPhuKienDiKem.Text;
                    item.GhiChu = radGhiChu.Text;
                    item.NgayNhap = netLink_DatePicker1.Value_String;
                    //item.LastEdited_Date = DateTime.Now;
                    item.LastEdited_UserID = PTIdentity.IDNguoiDung;
                    //item.Type = dropDownLoaiVatTu1.Text;
                    item.Type = radDropLoaiVatTu.Text;
                    item.NamDuaVaoSuDung = netLink_DatePicker1.Value.Year;
                    item.TenVatTu = dropTenThietBi.Text;
                    //item.PhuKien = radPhuKienDiKem.Text;
                    //item.GhiChu = radGhiChu.Text;
                }
            }
        }
        private bool ValidateDataBeforeSave()
        {
            if (!netLink_DatePicker1.isDateTime && !netLink_DatePicker1.isNull)
            {
                GlobalCommon.ShowErrorMessager(netLink_DatePicker1.Value_Error);
                return false;
            }
            if (GlobalCommon.CheckArrayTextIsNull(new string[] { radDropLoaiVatTu.Text, dropDownTinhTrangThietBi1.Text, txtSoSerial.Text, dropDownCanBo1.Selected_TextValue.ToString(), dropDownNguonKinhPhi1.Selected_TextValue.ToString() }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
          
            return true;
        }

        private void radThemMoi_Click(object sender, EventArgs e)
        {
            DanhMuc.UI.LoaiTrangThietBiInfo fr = new DanhMuc.UI.LoaiTrangThietBiInfo(formMode);
            fr.ShowDialog();
            radDropLoaiVatTu.DataSource = DIC_LoaiTrangThietBi_Coll.GetDIC_LoaiTrangThietBi_Coll();
        }

    }
}
