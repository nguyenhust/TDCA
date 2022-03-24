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
using Authoration.LIB;
using Telerik.WinControls.UI;

namespace Authoration.UserControls
{
    public partial class NguoiDung : UsDictionary
    {
        Int64 _IDNguoiDung = 0;

        public NguoiDung()
        {
            InitializeComponent();
            RadGrid = radgNguoiDung;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            PrintToShow();
        }

        #region Override

        public override object GetIdValue()
        {
            return "mnuNguoiDung";
        }

        public override string ToString()
        {
            return "Quản lý danh mục người dùng";
        }

        protected override void ApplyAuthorizationRules()
        {
            this.bl_btnSave = (Csla.ApplicationContext.User.IsInRole("NguoiDung:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            this.bl_btnPrint = (Csla.ApplicationContext.User.IsInRole("NguoiDung:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            this.bl_btnMyClose = true;
        }

        protected override void Save()
        {
            UI.NguoiDung frm = new UI.NguoiDung();
            frm.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            try
            {
                bindNguoiDung.DataSource = ADM_NguoiDung_Coll.GetADM_NguoiDung_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Print()
        {
            try
            {
                bindNguoiDung.DataSource = ADM_NguoiDung_Coll.GetADM_NguoiDung_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void MyClose()
        {
            base.MyClose();
        }        

        #endregion

        private void CellClick_radgNguoiDung(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (radgNguoiDung.CurrentRow.Cells["IDNguoiDung"] != null)
                    _IDNguoiDung = Convert.ToInt64(radgNguoiDung.CurrentRow.Cells["IDNguoiDung"].Value);
                UI.NguoiDung frm = new UI.NguoiDung(_IDNguoiDung);
                frm.ShowDialog();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void CellFormmatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);

            GridViewDataColumn dataColumn = e.CellElement.ColumnInfo as GridViewDataColumn;

            if (dataColumn != null && dataColumn.Name == "MatKhau")
            {
                object value = e.CellElement.RowInfo.Cells["MatKhau"].Value;
                string text = String.Empty;
                if (value != null)
                {
                    int passwordLen = Convert.ToString(value).Length;
                    text = String.Join("*", new string[passwordLen]);
                }
                e.CellElement.Text = text;
            }
        }

        private void radgNguoi_CellEditorInitialized(object sender, GridViewCellEventArgs e)
        {
            GridViewDataColumn dataColumn = e.Column as GridViewDataColumn;
            if (dataColumn != null && dataColumn.Name == "MatKhau")
            {
                RadTextBoxEditor textBoxEditor = this.radgNguoiDung.ActiveEditor as RadTextBoxEditor;
                if (textBoxEditor != null)
                {
                    RadTextBoxEditorElement editorElement = textBoxEditor.EditorElement as RadTextBoxEditorElement;
                    editorElement.PasswordChar = '*';
                }
            }
        }
    }
}
