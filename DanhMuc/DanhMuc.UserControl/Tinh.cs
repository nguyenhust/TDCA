using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NETLINK.UI;
using NETLINK.LIB;
using Telerik.WinControls.UI;
using DanhMuc.LIB;

namespace DanhMuc.UserControl
{
    public partial class TinhThanh : NETLINK.UI.UsDictionary
    {
        DIC_Tinh_Coll tinhcoll;
        public TinhThanh()
        {
            InitializeComponent();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            PrintToShow();
        }
        #region Overide

        public override object GetIdValue()
        {
            return "mnuTinhThanh";
        }

        public override string ToString()
        {
            return "Danh Muc Tỉnh Thành";
        }
        protected override void MyClose()
        {
            this.Close();
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = (Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN" ||
                Csla.ApplicationContext.User.IsInRole("TinhThanh:I"));
            bl_btnPrint = (Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN" ||
                Csla.ApplicationContext.User.IsInRole("TinhThanh:I"));
            bl_btnDelete = (Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN" ||
                Csla.ApplicationContext.User.IsInRole("TinhThanh:I"));
            bl_btnMyClose = true;
        }
        protected override void Save()
        {
            try
            {
                TinhInfo tinh = new TinhInfo();
                tinh.ShowDialog();
                LoadUS();
            }
            catch (Exception ex)
            {
                NETLINK.LIB.GlobalCommon.ShowErrorMessager(ex);
            }
        }
        protected override void LoadUS()
        {
            radGTinhThanh.Columns["SuDung"].Width = 90;
            radGTinhThanh.Columns["MaDK"].Width = 100;
            try
            {
                radGTinhThanh.DataSource = DanhMuc.LIB.DIC_Tinh_Coll.GetDIC_Tinh_Coll();
            }

            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
        protected override void Print()
        {
            try
            {
                radGTinhThanh.DataSource = DanhMuc.LIB.DIC_Tinh_Coll.GetDIC_Tinh_Coll();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
        protected override void Delete()
        {
            try
            {
                if ((radGTinhThanh.CurrentRow.Cells["ID"].Value != null) && GlobalCommon.AcceptDelete())
                {
                    IDTinhThanh = Convert.ToInt64(radGTinhThanh.CurrentRow.Cells["ID"].Value);
                    TinhInfo tinh = new TinhInfo(IDTinhThanh);
                    DIC_Tinh.DeleteDIC_Tinh(IDTinhThanh);
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }
        #endregion
        //#region Set Column
        //private void GetColumnIDRefer()
        //{
        //    // tạo combobox chuc vu
        //    GridViewTextBoxColumn comboIDRefer = new GridViewTextBoxColumn("IDRefer");
        //    // set datasource
        //    comboIDRefer.DataSource = DIC_Tinh_Coll.GetDIC_Tinh_Coll();
        //    comboIDRefer.DisplayMember = "Ten";
        //    comboIDRefer.ValueMember = "ID";
        //    comboIDRefer.HeaderText = "Refer Tỉnh";
        //    comboIDRefer.Name = "IDRefer";
        //    comboIDRefer.FieldName = "IDRefer";
        //    comboIDRefer.Width = 130;

        //    radGTinhThanh.Columns.Add(comboIDRefer);
        //    //end add
        //    this.radGTinhThanh.ShowGroupPanel = true;
        //    this.radGTinhThanh.MasterTemplate.AllowAddNewRow = true;
        //    this.radGTinhThanh.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;



        //    this.radGTinhThanh.EnableFiltering = true;
        //    this.radGTinhThanh.Columns.Move(this.radGTinhThanh.Columns["IDRefer"].Index, 4);

        //}


        //#endregion
        Int64 IDTinhThanh = 0;
        private void radGTinhThanh_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (radGTinhThanh.CurrentRow.Cells["ID"].Value != null)
                {
                    IDTinhThanh = Convert.ToInt64(radGTinhThanh.CurrentRow.Cells["ID"].Value);
                    TinhInfo tinh = new TinhInfo(IDTinhThanh);
                    tinh.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowError(ex.Message,"Không thể xem chi tiết!");
            }
        }
    }
}
