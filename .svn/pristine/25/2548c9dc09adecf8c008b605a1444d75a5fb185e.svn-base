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
    public partial class ChuyenNganhInfo : NETLINK.UI.Dictionary
    {
        #region variables

        private DIC_ChuyenNganh item;
        private int itemID = -1;
        

        #endregion

        public ChuyenNganhInfo(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            if (_formMode.IsInsert)
            {
                itemID = 0;
                item = DIC_ChuyenNganh.NewDIC_ChuyenNganh();
            }
            else
            {
                itemID = _formMode.Id;
                item = DIC_ChuyenNganh.GetDIC_ChuyenNganh(_formMode.Id);
            }
            bindingSourceChuyenNganh.DataSource = item;
        }

        #region overrides

        protected override void ApplyAuthorizationRules()
        {
            if (!GlobalCommon.IsHavePermission(new string[] { TextMessages.RolePermission.DM_ChuyenNganh_Insert, TextMessages.RolePermission.DM_ChuyenNganh_Edit }))
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
                dropDownChuyenKhoa1.FillData(1);
                if (itemID > 0)
                {
                    dropDownChuyenKhoa1.Selected_ID = item.ID_ChuyenKhoa;
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
                if (radTextBoxMa.Text == "" )
                {
                    GlobalCommon.ShowError("Mã chuyên ngành không được để trống", "Thông báo");
                }
                else if (radTextBoxTenTat.Text == "")
                {
                    GlobalCommon.ShowError("Tên viết tắt không được để trống", "Thông báo");
                }
                else
                {
                    item.Ma = radTextBoxMa.Text;
                    item.TenTat = radTextBoxTenTat.Text;
                    item.Ten = radTextBoxTen.Text;
                    item.ID_ChuyenKhoa = Convert.ToInt32(dropDownChuyenKhoa1.Selected_ID);
                    if (radCheckBoxIsUse.Checked)
                        item.SuDung = true;
                    item.TruongCN = string.Empty;
                    item.GhiChu = radGhiChu.Text.Trim();
                    item.ApplyEdit();
                    item.Save();
                    this.Close();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        #endregion

        private void radRichTextBoxGhiChu_Click(object sender, EventArgs e)
        {

        }
        private bool kiemtratontai()
        {
            bool tatkt = false;
            string maso = radTextBoxTen.Text;
            SqlConnection con = new SqlConnection(DBConnection.Connection);
            SqlCommand cmd = new SqlCommand("Select Ten from DIC_ChuyenNganh", con);
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
