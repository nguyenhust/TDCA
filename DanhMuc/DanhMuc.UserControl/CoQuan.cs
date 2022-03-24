﻿using System;
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
    public partial class CoQuan : NETLINK.UI.UsDictionary
    {
        private int selectedID = -1;
        private FormMode formMode = new FormMode();

        public CoQuan()
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            RadGrid = radgCoQuan;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            PrintToShow();
        }

        #region Overide

        public override object GetIdValue()
        {
            return "mnuCoQuan";
        }

        public override string ToString()
        {
            return "Quản lý danh mục cơ quan";
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_CoQuan_Insert);
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_CoQuan_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_CoQuan_Del);
        }

        protected override void Save()
        {
            try
            {
                formMode.IsInsert = true;
                CoQuanInfo fr = new CoQuanInfo(formMode);
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
                radgCoQuan.DataSource = DanhMuc.LIB.DIC_CoQuan_Coll.GetDIC_CoQuan_Coll();
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
                    DIC_CoQuan.DeleteDIC_CoQuan(selectedID);
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

        private void radgCoQuan_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_CoQuan_Edit))
                {
                    if (int.TryParse(RadGrid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                    {
                        formMode.IsEdit = true;
                        formMode.Id = selectedID;
                        CoQuanInfo fr = new CoQuanInfo(formMode);
                        fr.ShowDialog();
                        LoadUS();
                    }
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }
    }
}
