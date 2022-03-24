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
using DanhMuc.UI;

namespace DanhMuc.UserControl
{
    public partial class KhoaPhong : UsDictionary
    {
        private int selectedID = -1;
        private FormMode formMode = new FormMode();

        public KhoaPhong()
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            RadGrid = radgKhoaPhong;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            PrintToShow();
        }

        #region Overide

        public override object GetIdValue()
        {
            return "mnuKhoaPhong";
        }

        public override string ToString()
        {
            return "Quản lý danh mục khoa phòng";
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_KhoaPhong_Insert);
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_KhoaPhong_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_KhoaPhong_Del);
        }

        protected override void Save()
        {
            try
            {
                try
                {
                    formMode.IsInsert = true;
                    KhoaPhongInfo fr = new KhoaPhongInfo(formMode);
                    fr.ShowDialog();
                    LoadUS();
                }
                catch (Exception ex)
                {
                    NETLINK.LIB.GlobalCommon.ShowErrorMessager(ex);
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
            {radgKhoaPhong.DataSource = DanhMuc.LIB.DIC_VienKhoaPhong_Coll.GetDIC_VienKhoaPhong_Coll();}
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Delete()
        {
            try
            {
                if (int.TryParse(RadGrid.CurrentRow.Cells["IDKhoa"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    DIC_VienKhoaPhong.DeleteDIC_VienKhoaPhong(selectedID);
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        #endregion


        private void CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }

        private void radgKhoaPhong_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_KhoaPhong_Edit))
                {
                    if (int.TryParse(RadGrid.CurrentRow.Cells["IDKhoa"].Value.ToString(), out selectedID))
                    {
                        formMode.IsEdit = true;
                        formMode.Id = selectedID;
                        KhoaPhongInfo fr = new KhoaPhongInfo(formMode);
                        fr.ShowDialog();
                        LoadUS();
                    }
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }
    }
}
