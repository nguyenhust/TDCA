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
    public partial class Form_VanPhongPham : NETLINK.UI.Dictionary
    {
        
        private HC_DuTruVanPhongPham item;
        public Form_VanPhongPham(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
        }
        protected override void ApplyAuthorizationRules()
        {
            try
            {
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.DM_VanPhongPham_Insert, TextMessages.RolePermission.DM_VanPhongPham_Edit });
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
                if (ValidateDataBeforeSave())
                {
                    BindData(false);
                    item.ApplyEdit();
                    item.Save();
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Văn phòng phẩm :" + item.TenThietBi);
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
                //dropDownBoPhan1.FillData();
               
                if (formMode.IsEdit && formMode.Id > 0)
                {
                    item = HC_DuTruVanPhongPham.GetHC_DuTruVanPhongPham(formMode.Id);
                }
                else
                {
                    item = HC_DuTruVanPhongPham.NewHC_DuTruVanPhongPham();
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
            if (isLoad)
            {
                richTextBoxWithBigEditor1.Text = item.GhiChu;
            }
            else
            {
                item.GhiChu = richTextBoxWithBigEditor1.Text;
            }
        }
        private bool ValidateDataBeforeSave()
        {
            if (GlobalCommon.CheckArrayTextIsNull(new object[] {radTen.Text,radDonVi.Text }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            return true;
        }

        private void Form_VanPhongPham_Load(object sender, EventArgs e)
        {

        }

        private void Form_VanPhongPham_Load_1(object sender, EventArgs e)
        {

        }

        private void radTextBox3_TextChanged(object sender, EventArgs e)
        {

        }




    }
}
