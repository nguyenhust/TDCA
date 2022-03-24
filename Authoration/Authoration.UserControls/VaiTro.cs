using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Authoration.LIB;
using NETLINK.UI;
using NETLINK.LIB;

namespace Authoration.UserControls
{
    public partial class VaiTro : NETLINK.UI.UsDictionary
    {
        ADM_VaiTro_Coll vaitro_coll;

        public VaiTro()
        {
            InitializeComponent();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            RadGrid = radgVaiTro;
            STT();
        }

        #region Overide

        public override object GetIdValue()
        {
            return "mnuVaiTro";
        }

        public override string ToString()
        {
            return "Quản lý danh mục vài trò";
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = (Csla.ApplicationContext.User.Identity.Name.ToUpper() =="SYSMAN" ||
                Csla.ApplicationContext.User.IsInRole("VaiTro:I"));
            bl_btnPrint = (Csla.ApplicationContext.User.IsInRole("VaiTro:I") ||
                Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            bl_btnMyClose = true;
        }

        protected override void Save()
        {
            try
            {
                vaitro_coll = (ADM_VaiTro_Coll)radgVaiTro.DataSource;
                if (vaitro_coll.IsDirty == true)
                {
                    vaitro_coll.Save();
                    StateSave();
                    radgVaiTro.DataSource = ADM_VaiTro_Coll.GetADM_VaiTro_Coll();
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
            { radgVaiTro.DataSource = LIB.ADM_VaiTro_Coll.GetADM_VaiTro_Coll(); }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        #endregion

        private void CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }

        private void CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                vaitro_coll = (ADM_VaiTro_Coll)radgVaiTro.DataSource;
                if (vaitro_coll.IsDirty == true)
                    StateDirty();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void CursorChanged(object sender, EventArgs e)
        {
            try {
                vaitro_coll = (ADM_VaiTro_Coll)radgVaiTro.DataSource;
                if (vaitro_coll.IsDirty == true)
                    StateDirty();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
    }
}
