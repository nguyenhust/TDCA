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
    public partial class HocVi : NETLINK.UI.UsDictionary
    {
        private int selectedID = -1;
        private FormMode formMode = new FormMode();

        public HocVi()
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            RadGrid = radgHocVi;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            PrintToShow();
        }

        #region Overide

        public override object GetIdValue()
        {
            return "mnuhocvi";
        }

        public override string ToString()
        {
            return "Quản lý danh mục học vị";
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_HocVi_Insert);
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_HocVi_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_HocVi_Del);
        }

        protected override void Save()
        {
            try
            {
                formMode.IsInsert = true;
                HocViInfo fr = new HocViInfo(formMode);
                fr.ShowDialog();
                LoadUS();
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
            try
            {
                LoadUS();
            }
            catch (Exception ex)
            {
                NETLINK.LIB.GlobalCommon.ShowErrorMessager(ex);
            }
        }

        protected override void LoadUS()
        {
            try
            {
                bindHocVi.DataSource = DanhMuc.LIB.DIC_HocVi_Coll.GetDIC_HocVi_Coll();
                // radgBoPhan.DataSource = DIC_BoPhan_Coll.GetDIC_BoPhan_Coll();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Delete()
        {
            try
            {
                if (int.TryParse(RadGrid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    DIC_HocVi.DeleteDIC_HocVi(selectedID);
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
        

        private void radgHocVi_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                
                if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_HocVi_Edit))
                {
                    if (int.TryParse(RadGrid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                    {
                        
                        formMode.IsEdit = true;
                        formMode.Id = selectedID;
                        HocViInfo fr = new HocViInfo(formMode);
                        fr.ShowDialog();
                        LoadUS();
                    }
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }
    }
}
