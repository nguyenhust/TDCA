using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using DanhMuc.LIB;
using NETLINK.LIB;
using NETLINK.UI;
using DanhMuc.UI;

namespace DanhMuc.UserControl
{
    public partial class HocHam : NETLINK.UI.UsDictionary
    {
        private int selectedID = -1;
        private FormMode formMode = new FormMode();

        public HocHam()
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            RadGrid = radgHocHam;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            PrintToShow();
        }

        #region Overide

        public override object GetIdValue()
        {
            return "mnuhocham";
        }

        public override string ToString()
        {
            return "Quản lý danh mục học hàm";
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_HocHam_Insert);
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_HocHam_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_HocHam_Del);
        }

        protected override void Save()
        {
            try
            {
                formMode.IsInsert = true;
                HocHamInfo fr = new HocHamInfo(formMode);
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
                radgHocHam.DataSource = DanhMuc.LIB.DIC_HocHam_Coll.GetDIC_HocHam_Coll();
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
                    DIC_HocHam.DeleteDIC_HocHam(selectedID);
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
        

        private void radgHocHam_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_HocHam_Edit))
                {
                    if (int.TryParse(RadGrid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                    {
                        formMode.IsEdit = true;
                        formMode.Id = selectedID;
                        HocHamInfo fr = new HocHamInfo(formMode);
                        fr.ShowDialog();
                        LoadUS();
                    }
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }
    }
}
