using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using NETLINK.UI;
using NETLINK.LIB;
using DanhMuc.LIB;

namespace DanhMuc.UserControl
{
    public partial class GioiTinh : NETLINK.UI.UsDictionary
    {
        DIC_GioiTinh_Coll gioitinhcoll;
        public GioiTinh()
        {
            InitializeComponent();
            RadGrid = radgGioiTinh;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
        }

        #region Overide

        public override object GetIdValue()
        {
            return "mnuGioiTinh";
        }

        public override string ToString()
        {
            return "Quản lý danh mục giới tính";
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = (Csla.ApplicationContext.User.IsInRole("GioiTinh:I") ||
             Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            bl_btnPrint = (Csla.ApplicationContext.User.IsInRole("GioiTinh:I") ||
                Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            bl_btnMyClose = true;
        }

        protected override void Save()
        {
            try
            {
                gioitinhcoll = (DIC_GioiTinh_Coll)radgGioiTinh.DataSource;
                if (gioitinhcoll.IsDirty == true)
                {
                   gioitinhcoll.Save();
                    StateSave();
                    radgGioiTinh.DataSource = DIC_GioiTinh_Coll.GetDIC_GioiTinh_Coll();
                }
            }
            catch (Exception ex)
            {
                NETLINK.LIB.GlobalCommon.ShowErrorMessager(ex);
            }
        }

        protected override void MyClose()
        {
            this.Close();
        }

        protected override void Print()
        {
            base.Print();
        }

        protected override void LoadUS()
        {
            try
            {
                radgGioiTinh.DataSource = DanhMuc.LIB.DIC_GioiTinh_Coll.GetDIC_GioiTinh_Coll();
            }

            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        #endregion

        private void CellFormatting(object sender, CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }

        private void CellValueChanged(object sender, GridViewCellEventArgs e)
        {
            try
            {
                gioitinhcoll = (DIC_GioiTinh_Coll)radgGioiTinh.DataSource;
                if (gioitinhcoll.IsDirty == true)
                    StateDirty();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void CursorChanged(object sender, EventArgs e)
        {
            try
            {
                gioitinhcoll= (DIC_GioiTinh_Coll)radgGioiTinh.DataSource;
                if (gioitinhcoll.IsDirty == true)
                    StateDirty();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
    }
}
