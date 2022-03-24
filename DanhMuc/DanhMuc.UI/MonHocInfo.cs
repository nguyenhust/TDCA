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
    public partial class MonHocInfo : NETLINK.UI.Dictionary
    {
        #region variables

        private DIC_MonHoc item;
        private int itemID = -1;
        

        #endregion

        public MonHocInfo(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            if (_formMode.IsInsert)
            {
                itemID = 0;
                item = DIC_MonHoc.NewDIC_MonHoc();
            }
            else
            {
                itemID = _formMode.Id;
                item = DIC_MonHoc.GetDIC_MonHoc(_formMode.Id);
            }
            bindingSourceMonHoc.DataSource = item;
        }

        #region overrides

        protected override void ApplyAuthorizationRules()
        {
            if (!GlobalCommon.IsHavePermission(new string[] { TextMessages.RolePermission.DM_MonHoc_Insert, TextMessages.RolePermission.DM_MonHoc_Edit }))
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
                if (kiemtratontai())
                {
                    GlobalCommon.ShowError("Tên môn học đã tồn tại", "Thông báo");
                }
                else
                {
                    item.Ten = radTextBoxTen.Text;
                    item.IDLoai = 1;
                    item.Ma = radTextBoxMa.Text;
                    if (radCheckBoxIsUse.Checked)
                        item.SuDung = true;
                    item.GhiChu = radGhiChu.Text.Trim();
                    item.ApplyEdit();
                    item.Save();
                    this.Close();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        #endregion
        private bool kiemtratontai()
        {
            bool tatkt = false;
            string maso = radTextBoxTen.Text;
            SqlConnection con = new SqlConnection(DBConnection.Connection);
            SqlCommand cmd = new SqlCommand("Select Ten from DIC_MonHoc", con);
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
