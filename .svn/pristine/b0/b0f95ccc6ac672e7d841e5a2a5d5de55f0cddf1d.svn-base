using NETLINK.UI;
using NETLINK.LIB;
using DanhMuc.LIB;
using DanhMuc.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using ModuleDaoTao.LIB;
using Authoration.LIB;

namespace ModuleDaoTao.UI
{
    public partial class Form_LT_ThemLopHoc : NETLINK.UI.Dictionary
    {
        
        DT_LienTuc_KhungLopHoc item;

        public Form_LT_ThemLopHoc(FormMode _formMode)
        {
            InitializeComponent();
            this.formMode = _formMode;
            ApplyAuthorizationRules();
            
          
        }


        #region Override

        protected override void ApplyAuthorizationRules()
        {
            this.btnSave.Enabled = GlobalCommon.IsHavePermission(new string[] { TextMessages.RolePermission.DM_LopHoc_Insert, TextMessages.RolePermission.DM_LopHoc_Edit });
            /*this.btnSave.Enabled = (Csla.ApplicationContext.User.IsInRole("HopDong:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            btnContinue.Enabled = (Csla.ApplicationContext.User.IsInRole("HopDong:D")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            HopDong_Activated(this, EventArgs.Empty);*/
        }

        protected override void FormLoad()
        {
            try
            {
                // binding for trinh do
                dropDownChuyenKhoa1.FillData(1);
                if (formMode.IsInsert)
                {
                    item = DT_LienTuc_KhungLopHoc.NewDT_LienTuc_KhungLopHoc();
                }
                else
                {
                    item = DT_LienTuc_KhungLopHoc.GetDT_LienTuc_KhungLopHoc(formMode.Id);
                }
                BindData(true);
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Save()
        {
            if (ValidateDataBeforeSave())
            {
                BindData(false);
                item.ApplyEdit();
                item.Save();
                GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Chinh sua khung lớp học :" + item.TenLop);
                GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
                this.Close();
            }
        }

        #endregion


        private void BindData(bool isLoad)
        {
            if (isLoad)
            {
                dropDownChuyenKhoa1.Selected_ID = item.IdChuyenKhoa;
                radTextBoxTenLop.Text = item.TenLop;
                txtToiGianHoc.Text = item.ThoiGianHoc;
            }
            else
            {
                if (dropDownChuyenKhoa1.Selected_ID != null)
                {
                    item.IdChuyenKhoa = Convert.ToInt64(dropDownChuyenKhoa1.Selected_ID);
                }
                item.TenLop = radTextBoxTenLop.Text;
                item.HocPhi = "0";
                item.ThoiGianHoc = txtToiGianHoc.Text;
            }
        }
 

     

       

        #region Validate data
        private bool ValidateDataBeforeSave() 
        {
            if (GlobalCommon.CheckArrayTextIsNull(new string[] { radTextBoxTenLop.Text, dropDownChuyenKhoa1.Text }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }

            return true;
        }
        #endregion
    }
}
