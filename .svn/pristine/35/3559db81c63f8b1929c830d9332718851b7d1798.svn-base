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
using DanhMuc.UI;

namespace DanhMuc.UserControl
{
    public partial class NguonKinhPhi : NETLINK.UI.UsDictionary
    {
        private int selectedID = -1;
        private FormMode formMode = new FormMode();
         
        public NguonKinhPhi()
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            RadGrid = radgNguonKinhPhi;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            PrintToShow();
        }

        #region Override
        public override object GetIdValue()
        {
            return "mnuNguonKinhPhi";
        }
        public override string ToString()
        {
            return "Quản lý danh mục Nguồn kinh phí";
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_NguonKinhPhi_Insert);
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_NguonKinhPhi_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_NguonKinhPhi_Del);
        }
        protected override void Save()
        {
            try
            {
                formMode.IsInsert = true;
                NguonKinhPhiInfo fr = new NguonKinhPhiInfo(formMode);
                fr.ShowDialog();
                LoadUS();
            }
            catch (Exception ex)
            {
                NETLINK.LIB.GlobalCommon.ShowErrorMessager(ex);
            }
        }

        protected override void Print()
        {
            try
            {
                LoadUS();
            }
            catch (Exception ex)
            {
                NETLINK.LIB.GlobalCommon.ShowErrorMessager(ex);
            }
        }

        protected override void MyClose()
        {
            base.MyClose();
        }

        protected override void LoadUS()
        {
            try{
                radgNguonKinhPhi.DataSource = DIC_NguonKinhPhi_Coll.GetDIC_NguonKinhPhi_Coll();
            }
            catch(Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        protected override void Delete()
        {
            try
            {
                if (int.TryParse(RadGrid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    DIC_NguonKinhPhi.DeleteDIC_NguonKinhPhi(selectedID);
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }


        #endregion

        private void CellFormatting(object sender, CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }


        private void radgNguonKinhPhi_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_NguonKinhPhi_Edit))
                {
                    if (int.TryParse(RadGrid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                    {
                        formMode.IsEdit = true;
                        formMode.Id = selectedID;
                        NguonKinhPhiInfo fr = new NguonKinhPhiInfo(formMode);
                        fr.ShowDialog();
                        LoadUS();
                    }
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }
    }
}
