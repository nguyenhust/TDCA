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
    public partial class LoaiInfo : NETLINK.UI.Dictionary
    {
        #region variables

        private DIC_Loai item;
        private int itemID = -1;
        

        #endregion

        public LoaiInfo(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            if (_formMode.IsInsert)
            {
                itemID = 0;
                item = DIC_Loai.NewDIC_Loai();
            }
            else
            {
                itemID = _formMode.Id;
                item = DIC_Loai.GetDIC_Loai(_formMode.Id);
            }
            bindingSourceLoai.DataSource = item;
        }

        #region overrides

        protected override void ApplyAuthorizationRules()
        {
            if (!GlobalCommon.IsHavePermission(new string[] { TextMessages.RolePermission.DM_Loai_Insert, TextMessages.RolePermission.DM_Loai_Edit }))
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
                    item.Ma = radTextBox1.Text;
                    item.Ten = radTextBox2.Text;
                    if (radCheckBoxIsUse.Checked)
                        item.SuDung = true;
                    item.GhiChu = radGhiChu.Text;
                    item.ApplyEdit();
                    item.Save();
                    this.Close();
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        #endregion 
    }
}
