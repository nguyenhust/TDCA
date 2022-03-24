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
    public partial class DanToc : NETLINK.UI.UsDictionary
    {
        DIC_DanToc_Coll dantoccoll;
        public DanToc()
        {
            InitializeComponent();
            RadGrid = radgDanToc;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
        }

        #region Overide

        public override object GetIdValue()
        {
            return "mnuDanToc";
        }

        public override string ToString()
        {
            return "Quản lý danh mục dân tộc";
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = (Csla.ApplicationContext.User.IsInRole("DanToc:I") ||
                Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            bl_btnPrint = (Csla.ApplicationContext.User.IsInRole("DanToc:I") ||
                Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            bl_btnMyClose = true;
        }

        protected override void Save()
        {
            try
            {
                dantoccoll = (DIC_DanToc_Coll)radgDanToc.DataSource;
                if (dantoccoll.IsDirty == true)
                {
                    dantoccoll.Save();
                    StateSave();
                    radgDanToc.DataSource = DIC_DanToc_Coll.GetDIC_DanToc_Coll();
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
                radgDanToc.DataSource = DanhMuc.LIB.DIC_DanToc_Coll.GetDIC_DanToc_Coll();
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
                dantoccoll = (DIC_DanToc_Coll)radgDanToc.DataSource;
                if (dantoccoll.IsDirty == true)
                    StateDirty();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void CursorChanged(object sender, EventArgs e)
        {
            try
            {
                dantoccoll = (DIC_DanToc_Coll)radgDanToc.DataSource;
                if (dantoccoll.IsDirty == true)
                    StateDirty();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
    }
}
