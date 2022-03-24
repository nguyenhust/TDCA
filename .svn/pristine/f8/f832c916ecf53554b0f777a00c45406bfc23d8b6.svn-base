using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NETLINK.LIB;
using NETLINK.UI;
using Authoration.LIB;

namespace Authoration.UserControls
{
    public partial class NhomNguoiDung : UsDictionary
    {
        Int64 _IDNhomND;
        ADM_NhomNguoiDung nhomnguoidung;
        ADM_QuyenNhomNguoiDung_Coll quyennhom_coll;
        ADM_ChucNang_Coll chucnang_coll = ADM_ChucNang_Coll.GetADM_ChucNang_Coll();
        //RadGridView dt;
        public NhomNguoiDung()
        {
            InitializeComponent();
           // STT();
            RadGrid = radgNhomND;
            SaveToNew();
            PrintToShow();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
        }
        #region Override

        public override object GetIdValue()
        {
            return "mnuNhomNguoiDung";
        }

        public override string ToString()
        {
            return "Quản lý danh mục nhóm người dùng";
        }

        protected override void ApplyAuthorizationRules()
        {
            this.bl_btnSave = (Csla.ApplicationContext.User.IsInRole("NhomNguoiDung:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            this.bl_btnPrint = (Csla.ApplicationContext.User.IsInRole("NhomNguoiDung:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            this.bl_btnMyClose = true;
            this.bl_btnDelete = (Csla.ApplicationContext.User.IsInRole("NhomNguoiDung:D")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
        }

        protected override void Save()
        {
            UI.NhomNguoiDung frm = new UI.NhomNguoiDung();
            frm.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            try
            {
                bindNhomND.DataSource = ADM_NhomNguoiDung_Coll.GetADM_NhomNguoiDung_Coll();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Print()
        {
            try
            {
                bindNhomND.DataSource = ADM_NhomNguoiDung_Coll.GetADM_NhomNguoiDung_Coll();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void MyClose()
        {
            base.MyClose();
        }

        #endregion

        private void radgNhomND_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (radgNhomND.CurrentRow.Cells["ID"] != null)
                    _IDNhomND = Convert.ToInt64(radgNhomND.CurrentRow.Cells["ID"].Value);
                UI.NhomNguoiDung frm = new UI.NhomNguoiDung(_IDNhomND);
                frm.ShowDialog();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void radgNhomND_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (radgNhomND.CurrentRow.Cells["ID"] != null)
                    _IDNhomND = Convert.ToInt64(radgNhomND.CurrentRow.Cells["ID"].Value);
                UI.NhomNguoiDung frm = new UI.NhomNguoiDung(_IDNhomND);
                frm.ShowDialog();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
           
        }
    }
}
