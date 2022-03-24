using NETLINK.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;
using DanhMuc.LIB;
using NETLINK.LIB;
using DanhMuc.UserControl;
using NETLINK.UI.Form;

namespace DanhMuc

{
    public partial class BenhVienInfo : DictionaryEx
    {
         private DIC_BenhVien item;
         public BenhVienInfo(FormMode _formMode)
        {
            InitializeComponent();
            
            this.formMode = _formMode;
            ApplyAuthorizationRules();
        }
        protected override void ApplyAuthorizationRules()
        {
            if (formMode.IsInsert)
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.DM_BenhVien_Insert });
            else
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.DM_BenhVien_Edit });
        
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
                    GlobalCommon.Log.WriteLog(0, "Không bắt được tên người dùng", formMode, "Thông tin bệnh viện" + this.Text);
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
                dropDownTinhThanh1.FillData(1);
                if (formMode.IsEdit && formMode.Id64 > 0)
                {
                    item = DIC_BenhVien.GetDIC_BenhVien(formMode.Id64);
                }
                else
                {
                    item = DIC_BenhVien.NewDIC_BenhVien();
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
                radTxtTenBV.Text = item.Ten;
                txtdiachi.Text = item.DiaChi;
                txtdienthoai.Text = item.DienThoai;
                txtemail.Text = item.Email;
                txtfax.Text = item.Fax;
                txtGDDT.Text = item.GDDT;
                txtGDEmai.Text = item.GDEmail;
                txtGDT.Text = item.GDTen;
                txtGhiChu.Text = item.GhiChu;
                txtgiuongkh.Text = item.GiuongKH;
                txtgiuongtk.Text = item.GiuongTK;
                txtHang.Text = item.Hang;
                txtkhoacls.Text = item.KhoaCLS;
                txtkhoals.Text = item.KhoaLS;
                txtkhoangcach.Text = item.KhoangCach;
                txtPGD2DT.Text = item.PGD2DT;
                txtPGD2Em.Text = item.PGD2Email;
                txtPGD2T.Text = item.PGD2Ten;
                txtPGDDT.Text = item.PGD1DT;
                txtPGDEm.Text = item.PGD1Email;
                txtPGDT.Text = item.PGD1Ten;
                txtPPCDT2DT.Text = item.PPCDT2DT;
                txtPPCDT2Email.Text = item.PPCDT2Email;
                txtPPCDT2T.Text = item.PPCDT2Ten;
                txtPPCDTDT.Text = item.PPCDT1DT;
                txtPPCDTEmail.Text = item.PPCDT1Email;
                txtPPCDTT.Text = item.PPCDT1Ten;
                txtPPTH2DT.Text = item.PPKH2DT;
                txtPPTH2Email.Text = item.PPKH2Email;
                txtPPTH2T.Text = item.PPKH2Ten;
                txtPPTHDT.Text = item.PPKH1DT;
                txtPPTHEmail.Text = item.PPKH1Email;
                txtPPTHT.Text = item.PPKH1Ten;
                txtsophong.Text = item.Phong;
                txtTPCDTDT.Text = item.TPCDTDT;
                txtTPCDTEmail.Text = item.TPCDTEmail;
                txtTPCDTT.Text = item.TPCDTTen;
                txtTPKHDT.Text = item.TPKHTHDT;
                txtTPKHEmail.Text = item.TPKHTHEmail;
                txtTPKHT.Text = item.TPKHTHTen;
                dropDownTinhThanh1.Selected_ID = item.IDTinh;
            }
            else
            {
                item.Ten = radTxtTenBV.Text;
                item.DiaChi = txtdiachi.Text;
                item.DienThoai = txtdienthoai.Text;
                item.Email = txtemail.Text;
                item.Fax = txtfax.Text;
                item.GDDT = txtGDDT.Text;
                item.GDEmail = txtGDEmai.Text;
                item.GDTen = txtGDT.Text;
                item.GhiChu = txtGhiChu.Text;
                item.GiuongKH = txtgiuongkh.Text;
                item.GiuongTK = txtgiuongtk.Text;
                item.Hang = txtHang.Text;
                item.KhoaCLS = txtkhoacls.Text;
                item.KhoaLS = txtkhoals.Text;
                item.KhoangCach = txtkhoangcach.Text;
                item.PGD2DT = txtPGD2DT.Text;
                item.PGD2Email = txtPGD2Em.Text;
                item.PGD2Ten = txtPGD2T.Text;
                item.PGD1DT = txtPGDDT.Text;
                item.PGD1Email = txtPGDEm.Text;
                item.PGD1Ten = txtPGDT.Text;
                item.PPCDT2DT = txtPPCDT2DT.Text;
                item.PPCDT2Email = txtPPCDT2Email.Text;
                item.PPCDT2Ten = txtPPCDT2T.Text;
                item.PPCDT1DT = txtPPCDTDT.Text;
                item.PPCDT1Email = txtPPCDTEmail.Text;
                item.PPCDT1Ten = txtPPCDTT.Text;
                item.PPKH2DT = txtPPTH2DT.Text;
                item.PPKH2Email = txtPPTH2Email.Text;
                item.PPKH2Ten = txtPPTH2T.Text;
                item.PPKH1DT = txtPPTHDT.Text;
                item.PPKH1Email = txtPPTHEmail.Text;
                item.PPKH1Ten = txtPPTHT.Text;
                item.Phong = txtsophong.Text;
                item.TPCDTDT = txtTPCDTDT.Text;
                item.TPCDTEmail = txtTPCDTEmail.Text;
                item.TPCDTTen = txtTPCDTT.Text;
                item.TPKHTHDT = txtTPKHDT.Text;
                item.TPKHTHEmail = txtTPKHEmail.Text;
                item.TPKHTHTen = txtTPKHT.Text;
                if (dropDownTinhThanh1.Selected_Item != null)
                    item.IDTinh = Convert.ToInt64(dropDownTinhThanh1.Selected_ID);
                item.LastEdited_Date = DateTime.Now;

            }

        }
        private bool ValidateDataBeforeSave()
        {

            if (GlobalCommon.CheckArrayTextIsNull(new object[] { radTxtTenBV.Text }) || GlobalCommon.CheckArrayTextIsNull(new object[] { dropDownTinhThanh1.Text }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
    
            return true;
        }

        private void txtPGDEm_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
