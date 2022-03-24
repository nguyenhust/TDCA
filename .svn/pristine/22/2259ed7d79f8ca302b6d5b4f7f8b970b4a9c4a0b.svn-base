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
    public partial class BoPhan : NETLINK.UI.UsDictionary
    {
        DIC_BoPhan_Coll bophancoll;
       // DIC_BoPhan_Info bophaninfo;
        int IDBoPhan;

        public BoPhan()
        {
            InitializeComponent();
            RadGrid = radgBoPhan;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
        }
        public BoPhan(Int32 _ID)
        {
            IDBoPhan = _ID;
        }
        #region Overide

        public override object GetIdValue()
        {
            return "mnuBoPhan";
        }

        public override string ToString()
        {
            return "Quản lý danh mục bộ phận";
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_Phong_Insert);
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_Phong_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_Phong_Del);
        }

        protected override void Save()
        {
            try
            {
                bophancoll = (DIC_BoPhan_Coll)radgBoPhan.DataSource;
                if (bophancoll.IsDirty == true)
                {
                    bophancoll.Save();
                    StateSave();
                    radgBoPhan.DataSource = DIC_BoPhan_Coll.GetDIC_BoPhan_Coll();
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
                
                radgBoPhan.DataSource = DanhMuc.LIB.DIC_BoPhan_Coll.GetDIC_BoPhan_Coll();
                //if (IDBoPhan == 0)
                //    UsDictionary.btnDelete.Enable = false;
            }

            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Delete()
        {
            try
            {
                bophancoll = (DIC_BoPhan_Coll)radgBoPhan.DataSource;
                if (radgBoPhan.CurrentRow.Cells["ID"].Value != null)
                    IDBoPhan = Convert.ToInt32(radgBoPhan.CurrentRow.Cells["ID"].Value);
                    if (GlobalCommon.AcceptDelete())
                    {
                        DIC_BoPhan.Delete_BoPhan(IDBoPhan);
                        LoadUS();
                    }
                
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
                bophancoll = (DIC_BoPhan_Coll)radgBoPhan.DataSource;
                if (bophancoll.IsDirty == true)
                    StateDirty();
            }
            catch(Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void CursorChanged(object sender, EventArgs e)
        {
            try
            {
                bophancoll = (DIC_BoPhan_Coll)radgBoPhan.DataSource;
                if (bophancoll.IsDirty == true)
                    StateDirty();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
    }
}
