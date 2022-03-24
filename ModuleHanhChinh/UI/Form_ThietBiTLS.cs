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
using System.Data.SqlClient;
namespace ModuleHanhChinh.UI
{
    public partial class Form_ThietBiTLS : NETLINK.UI.Dictionary
    {
        
        private HC_ThietBiTienLamSang item;
        public Form_ThietBiTLS(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
        }
        protected override void ApplyAuthorizationRules()
        {
            btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.HC_ThietBiTienLamSang_Edit, TextMessages.RolePermission.HC_ThietBiTienLamSang_Insert });
        }
        protected override void Save()
        {
            try
            {
                if (kiemtratontai())
                {
                    GlobalCommon.ShowError("Tên thiết bị lâm sàng đã tồn tại", "Thông báo");
                }
                else
                {
                    if (ValidateDataBeforeSave())
                    {
                        BindData(false);
                        item.ApplyEdit();
                        item.Save();
                        GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Thiết bị TLS:" + item.TenThietBi);
                        GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
                        this.Close();
                    }
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
                    item = HC_ThietBiTienLamSang.GetHC_ThietBiTienLamSang(formMode.Id);
                }
                else
                {
                    item = HC_ThietBiTienLamSang.NewHC_ThietBiTienLamSang();
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
                    if (formMode.IsEdit)
                    {
                        richTextBoxWithBigEditor1.Text = item.GhiChu;
                        dropDownNguonKinhPhi1.Selected_ID = item.IdNguonKinhPhi;
                    }
                }
                else
                {
                    item.GhiChu = richTextBoxWithBigEditor1.Text;
                    if (dropDownNguonKinhPhi1.Selected_ID != null)
                        item.IdNguonKinhPhi = Convert.ToInt32(dropDownNguonKinhPhi1.Selected_ID);


                }
            }
        }
        private bool ValidateDataBeforeSave()
        {
            if (GlobalCommon.CheckArrayTextIsNull(new object[] { dropDownNguonKinhPhi1.Selected_TextValue, radTen.Text, radSerial.Text }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            return true;
        }
        private bool kiemtratontai()
        {
            bool tatkt = false;
            string maso = radTen.Text;
            SqlConnection con = new SqlConnection(DBConnection.Connection);
            SqlCommand cmd = new SqlCommand("Select TenThietBi from HC_ThietBiTienLamSang", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (maso == dr.GetString(0))
                {
                    tatkt = true;
                    break;
                }
            }
            con.Close();
            return tatkt;
        }  
    }
}
