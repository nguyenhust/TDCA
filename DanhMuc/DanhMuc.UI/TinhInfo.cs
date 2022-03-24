using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using DanhMuc.LIB;
using NETLINK.LIB;
using NETLINK.UI;
using NETLINK.UI.Form;
using Telerik.WinControls.UI;
using System.Data.SqlClient;
namespace DanhMuc

{
    public partial class TinhInfo : DictionaryEx
    {
        DIC_TinhChild_Coll tinhcon;
        DIC_Tinh tinhthanh;
        long IDTinhThanh;
        public TinhInfo()
        {
            InitializeComponent();
        }
        public TinhInfo(Int64 _ID)
        {
            InitializeComponent();
            IDTinhThanh = _ID;
        }
        #region Set Column
        private void GetColumnIDRefer()
        {
            // tạo combobox chuc vu
            GridViewComboBoxColumn comboIDRefer = new GridViewComboBoxColumn("IDRefer");
            // set datasource
            comboIDRefer.DataSource = DIC_Tinh_Coll.GetDIC_Tinh_Coll();
            comboIDRefer.DisplayMember = "Ten";
            comboIDRefer.ValueMember = "ID";
            comboIDRefer.HeaderText = "Refer Tỉnh";
            comboIDRefer.Name = "IDRefer";
            comboIDRefer.FieldName = "IDRefer";
            comboIDRefer.Width = 130;
            comboIDRefer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            radGChildTinhThanh.Columns.Add(comboIDRefer);
            //end add
            this.radGChildTinhThanh.ShowGroupPanel = true;
            this.radGChildTinhThanh.MasterTemplate.AllowAddNewRow = true;
            this.radGChildTinhThanh.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;



            this.radGChildTinhThanh.EnableFiltering = true;
            this.radGChildTinhThanh.Columns.Move(this.radGChildTinhThanh.Columns["IDRefer"].Index, 2);

        }
        

        #endregion
        #region Override
        protected override void ApplyAuthorizationRules()
        {
            this.btnSave.Enabled = (Csla.ApplicationContext.User.IsInRole("TinhInfo:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN"
            || Csla.ApplicationContext.User.IsInRole("TinhInfo:U"));
            btnDelete.Enabled = (Csla.ApplicationContext.User.IsInRole("TinhInfo:D")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
        }
        protected override void FormLoad()
        {
            //GetColumnIDRefer();
            radGChildTinhThanh.Columns["SuDung"].Width = 90;
            radGChildTinhThanh.Columns["MaDK"].Width = 100;
            btnSave.Enabled = true;
            if (IDTinhThanh == 0)
            {
                //bindReferTinh.DataSource = DIC_Tinh_Coll.GetDIC_Tinh_Coll(IDTinhThanh);
                
                btnDelete.Enabled = false;
                tinhcon = DIC_TinhChild_Coll.NewDIC_TinhChild_Coll();
                bindTinhChild.DataSource = tinhcon;
                tinhthanh = DIC_Tinh.NewDIC_Tinh();
                bindTinhThanh.DataSource = tinhthanh;
            }
            else {
                //bindReferTinh.DataSource = DIC_Tinh_Coll.GetDIC_Tinh_Coll(IDTinhThanh);
                tinhcon = DIC_TinhChild_Coll.GetDIC_TinhChild_Coll(IDTinhThanh);
                tinhthanh = DIC_Tinh.GetDIC_Tinh(IDTinhThanh);
                bindTinhChild.DataSource = tinhcon;
                bindTinhThanh.DataSource = tinhthanh;
            }
        }
        protected override void Save()
        {
            if (kiemtratontai())
            {
                GlobalCommon.ShowError("Tên tỉnh đã tồn tại", "Thông báo");
            }
            else
            {
                tinhthanh.DIC_TinhChild = tinhcon;
                tinhthanh.ApplyEdit();
                tinhthanh.Save();
                this.Close();
            }
        }
        protected override void Delete()
        {
            try
            {
                if (GlobalCommon.AcceptDelete())
                {
                    DIC_Tinh.DeleteDIC_Tinh(IDTinhThanh);
                    this.Close();
                }
                
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
        #endregion

        private void radTxtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Tên tỉnh phải là kí tự chữ ", "Thông Báo ");
            } 
        }

        private void radTxtTieuDe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Tên tỉnh phải là kí tự chữ ", "Thông Báo ");
            }
        }

        private bool kiemtratontai()
        {
            bool tatkt = false;
            string maso = radTxtTen.Text;
            SqlConnection con = new SqlConnection(DBConnection.Connection);
            SqlCommand cmd = new SqlCommand("Select Ten from DIC_Tinh", con);
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
