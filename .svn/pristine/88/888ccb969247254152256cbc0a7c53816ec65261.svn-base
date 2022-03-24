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
    public partial class ChuyenKhoaInfo : NETLINK.UI.Dictionary
    {
        #region variables

        private DIC_ChuyenKhoa item;
        private int itemID = -1;
        
        #endregion

        public ChuyenKhoaInfo(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            if (_formMode.IsInsert)
            {
                itemID = 0;
                item = DIC_ChuyenKhoa.NewDIC_ChuyenKhoa();
            }
            else
            {
                itemID = _formMode.Id;
                item = DIC_ChuyenKhoa.GetDIC_ChuyenKhoa(_formMode.Id);
            }
            bindingSourceChuyenKhoa.DataSource = item;
        }

        #region overrides

        protected override void ApplyAuthorizationRules()
        {
            if (!GlobalCommon.IsHavePermission(new string[] { TextMessages.RolePermission.DM_ChuyenKhoa_Insert, TextMessages.RolePermission.DM_ChuyenKhoa_Edit }))
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
                    radGhiChu.Text = item.GhiChu;
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Save()
        {
            try
            {
                if (radGhiChu.Text == "")
                {
                    GlobalCommon.ShowError("Tên viết tắt không được để trống", "Thông báo");
                }
                else
                {
                    item.Ten = radTextBoxTen.Text;
                    item.GhiChu = radGhiChu.Text.Trim();
                    if (radCheckBoxIsUse.Checked)
                        item.SuDung = true;
                    item.ApplyEdit();
                    item.Save();
                    this.Close();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        #endregion

        private void ChuyenKhoaInfo_Load(object sender, EventArgs e)
        {

        }

        private bool kiemtratontai()
        {
            bool tatkt = false;
            string maso = radTextBoxTen.Text;
            string  ID = itemID.ToString();
            SqlConnection con = new SqlConnection(DBConnection.Connection);
            SqlCommand cmd = new SqlCommand("Select ID,Ten from DIC_ChuyenKhoa", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (maso == dr.GetString(1) && ID != Convert.ToString(dr.GetInt32(0)))
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
