using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace NETLINK.UI
{
    public partial class UsDictionary : WinPart
    {
        public UsDictionary()
        {
            InitializeComponent();
            ApplyAuthorizationRules();
        }

        #region Button Click

        private void btnSave_Click(object sender, EventArgs e)
        {
             Save();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
             Print();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
             MyClose();
        }

        private void LoadUserControl(object sender, EventArgs e)
        {
            LoadUS();
        }

        #endregion

        #region Virtual Method

        #region ApplyAuthorizationRules

        protected virtual void ApplyAuthorizationRules()
        {
            VNRadGridLP vn = new VNRadGridLP();
          //enable button
          //Duoc xay dung chi tiet tren form ke thua
        }

        #endregion

        protected virtual void Save()
        {
          //Duoc xay dung chi tiet tren doi tuong ke thua
        }

        protected virtual void Print()
        {
          //Duoc xay dung chi tiet tren doi tuong ke thua
        }

        protected virtual void MyClose()
        {
            //Duoc xay dung chi tiet tren doi tuong ke thua
        }

        protected virtual void LoadUS()
        {
            //Duoc xay dung chi tiet tren doi tuong ke thua
        }

        #endregion

        #region Thêm số thứ tự vào  trong radGridview

        RadGridView _RadGrid;
        public RadGridView RadGrid
        {
            get { return this._RadGrid; }
            set { this._RadGrid = value; }
        }

        protected virtual void STT()
        {
            // thêm số thứ tự vào radgrid
            this.RadGrid.ShowGroupPanel = false;
            this.RadGrid.MasterTemplate.AllowAddNewRow = true;
            this.RadGrid.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            var lineNumbersColumn = new GridViewDecimalColumn(typeof(int), "STT", "STT");
            lineNumbersColumn.AllowSort = false;
            RadGrid.Columns.Add(lineNumbersColumn);
            this.RadGrid.Columns["STT"].Width = 50;
            this.RadGrid.Columns["STT"].TextAlignment = ContentAlignment.TopCenter;
            this.RadGrid.Columns.Move(this.RadGrid.Columns["STT"].Index, 0);
        }

        protected virtual void radG_CellFormat(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement.ColumnInfo.Name == "STT" && string.IsNullOrEmpty(e.CellElement.Text))
            {
                e.CellElement.Text = (e.CellElement.RowIndex + 1).ToString();
            }
        }

        #endregion 
 
        #region Sate

        protected virtual void StateSave()
        {
            btnSave.Text = "Lưu thành công";
            btnSave.Enabled = false;
        }

        protected virtual void StateDirty()
        {
            btnSave.Text = "Lưu thông tin";
            btnSave.Enabled = true;
        }

        #endregion

        #region Xử lý phím tắt trong form

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F5)
            {
                Save();
            }

            else if (keyData == Keys.F1)
            {
                Print();
            }
            else if (keyData == Keys.F12)
            {
                MyClose();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion
    }
}
