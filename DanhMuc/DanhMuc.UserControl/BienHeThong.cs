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

namespace DanhMuc.UserControl
{
    public partial class BienHeThong : NETLINK.UI.UsDictionary
    {
        DIC_PARAMETERES_Coll bienhethongcoll;
        public BienHeThong()
        {
            InitializeComponent();
            RadGrid = radgBienHeThong;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
        }
        #region Override
        public override object GetIdValue()
        {
            return "mnuBienHeThong";
        }
        public override string ToString()
        {
            return "Quản lý biến hệ thống";
        }
        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = (Csla.ApplicationContext.User.IsInRole("BienHeThong:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            bl_btnPrint = (Csla.ApplicationContext.User.IsInRole("BienHeThong:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            bl_btnMyClose = (Csla.ApplicationContext.User.IsInRole("BienHeThong:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
        }
        protected override void LoadUS()
        {
            try
            {
                radgBienHeThong.DataSource = DIC_PARAMETERES_Coll.GetDIC_PARAMETERES_Coll();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        protected override void Save()
        {
            try
            {
                bienhethongcoll = (DIC_PARAMETERES_Coll)radgBienHeThong.DataSource;
                if (bienhethongcoll.IsDirty == true)
                {
                    bienhethongcoll.Save();
                    StateSave();
                    radgBienHeThong.DataSource = DIC_PARAMETERES_Coll.GetDIC_PARAMETERES_Coll();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        protected override void MyClose()
        {
            base.MyClose();
        }
        protected override void Print()
        {
            base.Print();
        }

        #endregion

        

        private void CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                bienhethongcoll = (DIC_PARAMETERES_Coll)radgBienHeThong.DataSource;
                if (bienhethongcoll.IsDirty == true)
                    StateDirty();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }

        
    }
}
