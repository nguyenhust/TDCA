using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;


namespace NETLINK.UI
{
    public partial class Dictionary : Telerik.WinControls.UI.RadForm
    {
        public static Dictionary _main;
        /// <summary>
        /// Đánh dấu đã làm những thứ trong OnPaint method
        /// </summary>
        public bool _isDaOnPaint = true;

        public Dictionary()
        {
             InitializeComponent();
            _main = this;
        }

        public static Dictionary Instance
        {
            get { return _main; }
        }

        /// <summary>
        /// Resize button control
        /// </summary>
        /// <param name="btnResize">Button resize</param>
        /// <param name="x">x</param>
        /// <param name="y">y</param>
        protected virtual void ResizeButton(Button btnResize, int x, int y)
        {
            Point p = new Point(x, y);
            btnResize.Location = p;
        }

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

        #region Đối tượng  

        private void Save(object sender, EventArgs e)
        {
            Save();
        }

        protected virtual void New()
        { 
            //detail method new
        }

        protected virtual void Save()
        { 
            //detail method save
        }

        protected virtual void Delete()
        { 
            //detail method delete
        }

        protected virtual void Cancel()
        { 
            //detail method Cancel
        }

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

        private void FormLoad(object sender, EventArgs e)
        {
            FormLoad();
        }

        protected virtual void FormLoad()
        {
            //detail method event Formload
        }

        #region Xử lý phím tắt trong form

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                New();
            }
            if (keyData == Keys.F5)
            {
                Save();
            }

            else if (keyData == Keys.F5)
            {
                Cancel();
            }
            else if (keyData == Keys.F12)
            {
                Delete();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion
    }
}
