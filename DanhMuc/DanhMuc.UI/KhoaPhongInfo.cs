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
using Telerik.WinControls.UI;
using System.Data.SqlClient;
namespace DanhMuc.UI
{
    public partial class KhoaPhongInfo : NETLINK.UI.Dictionary
    {
        #region variables

        private DIC_VienKhoaPhong item;
        private int itemID = -1;
        

        #endregion

        public KhoaPhongInfo(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            if (_formMode.IsInsert)
            {
                itemID = 0;
                item = DIC_VienKhoaPhong.NewDIC_VienKhoaPhong();
            }
            else
            {
                itemID = _formMode.Id;
                item = DIC_VienKhoaPhong.GetDIC_VienKhoaPhong(_formMode.Id);
            }
            bindingSourceKhoaPhong.DataSource = item;
        }

        #region overrides

        protected override void ApplyAuthorizationRules()
        {
            if (!GlobalCommon.IsHavePermission(new string[] { TextMessages.RolePermission.DM_KhoaPhong_Insert, TextMessages.RolePermission.DM_KhoaPhong_Edit }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
                this.Close();
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        protected override void FormLoad()
        {
            try
            {
                if (itemID > 0)
                {
                    if (item.SuDung == true)
                        radCheckBoxIsUse.Checked = true;
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Save()
        {
            try
            {               
                item.MaKhoa = Convert.ToInt16(radTextBoxMa.Text);
                item.TenKhoa = radTextBoxTen.Text;
                item.TenTat = radTextBoxTenTat.Text;
                item.MaNhanDang = string.Empty;
                item.TruongKhoa = radTextBoxTruongKhoa.Text;
                item.YTaTruong = radTextBoxYTaTruong.Text;
                if (radCheckBoxIsUse.Checked)
                    item.SuDung = true;
                item.ApplyEdit();
                item.Save();
                this.Close();
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        #endregion  
    }
}
