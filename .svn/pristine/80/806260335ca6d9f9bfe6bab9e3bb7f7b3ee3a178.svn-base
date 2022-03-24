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
    public partial class PhongInfo : NETLINK.UI.Dictionary
    {
        #region variables

        private DIC_Phong item;
        private int itemID = -1;
        

        #endregion

        public PhongInfo(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            if (_formMode.IsInsert)
            {
                itemID = 0;
                item = DIC_Phong.NewDIC_Phong();
            }
            else
            {
                itemID = _formMode.Id;
                item = DIC_Phong.GetDIC_Phong(_formMode.Id);
            }
            bindingSourcePhong.DataSource = item;
        }

        #region overrides

        protected override void ApplyAuthorizationRules()
        {
            if (!GlobalCommon.IsHavePermission(new string[] { TextMessages.RolePermission.DM_Phong_Insert, TextMessages.RolePermission.DM_Phong_Edit }))
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
                dropDownCanBo1.FillData(1);
                if (itemID > 0)
                {
                    if (item.SuDung == true)
                        radCheckBoxIsUse.Checked = true;
                    dropDownCanBo1.Selected_ID = item.IDCanBo;
                    radDateTimePicker3.Text = item.NgayTao;
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Save()
        {
            try
            {
                if (kiemtratontai() )
                {
                    GlobalCommon.ShowError("Tên phòng đã tồn tại", "Thông báo");
                }
                else
                {
                    item.Ma = radTextBoxMa.Text;
                    item.Ten = radTextBoxTen.Text;
                    item.IDCanBo = Convert.ToInt32(dropDownCanBo1.Selected_ID);
                    item.TinhTrang = radTextBoxTinhTrang.Text;
                    item.MucDich = radTextBoxMucDich.Text;
                    item.DiaDiem = radTextBoxDiaDiem.Text;
                    item.NgayTao = radDateTimePicker3.Text;
                    item.SucChua = true;
                    item.TrangThietBi = radTextBoxTrangThietBi.Text;
                    if (radCheckBoxIsUse.Checked)
                        item.SuDung = true;
                    else
                        item.SuDung = false;
                    item.GhiChu = radGhiChu.Text;
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
            SqlCommand cmd = new SqlCommand("Select Ten from DIC_Phong", con);
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
