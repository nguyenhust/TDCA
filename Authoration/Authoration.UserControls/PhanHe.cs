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

namespace Authoration.UserControls
{
    public partial class PhanHe : UsDictionary
    {
        LIB.ADM_PhanHe_Coll phanhe_coll;

        public PhanHe()
        {
            InitializeComponent();
            RadGrid = radgPhaHe;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
        }

        #region Overide

        public override object GetIdValue()
        {
            return "mnuPhanHe";
        }

        public override string ToString()
        {
            return "Quản lý phân hệ";
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = (Csla.ApplicationContext.User.Identity.Name.ToUpper() =="SYSMAN"||
                Csla.ApplicationContext.User.IsInRole("PhanHe:I"));
            bl_btnPrint = (Csla.ApplicationContext.User.IsInRole("PhanHe:I") ||
                Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            bl_btnMyClose = true;
        }

        protected override void Save()
        {
            try
            {
                phanhe_coll = (LIB.ADM_PhanHe_Coll)radgPhaHe.DataSource;
                if (phanhe_coll.IsDirty == true)
                {
                    phanhe_coll.Save();
                    StateSave();
                    radgPhaHe.DataSource = LIB.ADM_PhanHe_Coll.GetADM_PhanHe_Coll();
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
            { radgPhaHe.DataSource = Authoration.LIB.ADM_PhanHe_Coll.GetADM_PhanHe_Coll(); }
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
                phanhe_coll = (LIB.ADM_PhanHe_Coll)radgPhaHe.DataSource;
                if (phanhe_coll.IsDirty == true)
                    StateDirty();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void CursorChanged(object sender, EventArgs e)
        {
            try
            {
                phanhe_coll = (LIB.ADM_PhanHe_Coll)radgPhaHe.DataSource;
                if (phanhe_coll.IsDirty == true)
                    StateDirty();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
    }
}
