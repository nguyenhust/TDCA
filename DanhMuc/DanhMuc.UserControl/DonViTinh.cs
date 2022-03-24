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
using DanhMuc.LIB;
using Telerik.WinControls.UI;

namespace DanhMuc.UserControl
{
    public partial class DonViTinh : NETLINK.UI.UsDictionary
    {
        DIC_DonViTinh_Coll donvitinhcoll;
        public DonViTinh()
        {
            InitializeComponent();
            RadGrid = radgDonViTinh;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
        }

        #region Overide

        public override object GetIdValue()
        {
            return "mnuDonViTinh";
        }

        public override string ToString()
        {
            return "Quản lý danh mục đơn vị tính";
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = (Csla.ApplicationContext.User.IsInRole("DonViTinh:I") ||
                Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            bl_btnPrint = (Csla.ApplicationContext.User.IsInRole("DonViTinh:I") ||
                Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            bl_btnMyClose = true;
        }

        protected override void Save()
        {
            try
            {
                donvitinhcoll = (DIC_DonViTinh_Coll)radgDonViTinh.DataSource;
                if (donvitinhcoll.IsDirty == true)
                {
                    donvitinhcoll.Save();
                    StateSave();
                    radgDonViTinh.DataSource = DIC_DonViTinh_Coll.GetDIC_DonViTinh_Coll();
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
                radgDonViTinh.DataSource = DanhMuc.LIB.DIC_DonViTinh_Coll.GetDIC_DonViTinh_Coll();
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
                donvitinhcoll = (DIC_DonViTinh_Coll)radgDonViTinh.DataSource;
                if (donvitinhcoll.IsDirty == true)
                    StateDirty();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void CursorChanged(object sender, EventArgs e)
        {
            try
            {
                donvitinhcoll = (DIC_DonViTinh_Coll)radgDonViTinh.DataSource;
                if (donvitinhcoll.IsDirty == true)
                    StateDirty();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
    }
}
