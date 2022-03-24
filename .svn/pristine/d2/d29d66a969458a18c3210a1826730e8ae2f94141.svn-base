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
    public partial class QuocGia : NETLINK.UI.UsDictionary
    {
        DIC_QuocGia_Coll quocgiacoll;
        public QuocGia()
        {
            InitializeComponent();
            RadGrid = radgQuocGia;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
        }

        #region Overide

        public override object GetIdValue()
        {
            return "mnuQuocGia";
        }

        public override string ToString()
        {
            return "Quản lý danh mục Quốc Gia";
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = (Csla.ApplicationContext.User.IsInRole("QuocGia:I") ||
                Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            bl_btnPrint = (Csla.ApplicationContext.User.IsInRole("QuocGia:I") ||
                Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            bl_btnMyClose = true;
        }

        protected override void Save()
        {
            try
            {
                quocgiacoll = (DIC_QuocGia_Coll)radgQuocGia.DataSource;
                if (quocgiacoll.IsDirty == true)
                {
                    quocgiacoll.Save();
                    StateSave();
                    radgQuocGia.DataSource = DIC_QuocGia_Coll.GetDIC_QuocGia_Coll();
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
                radgQuocGia.DataSource = DanhMuc.LIB.DIC_QuocGia_Coll.GetDIC_QuocGia_Coll();
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
                quocgiacoll = (DIC_QuocGia_Coll)radgQuocGia.DataSource;
                if (quocgiacoll.IsDirty == true)
                    StateDirty();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void CursorChanged(object sender, EventArgs e)
        {
            try
            {
                quocgiacoll = (DIC_QuocGia_Coll)radgQuocGia.DataSource;
                if (quocgiacoll.IsDirty == true)
                    StateDirty();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
    }
}
