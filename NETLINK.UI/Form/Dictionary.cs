using NETLINK.LIB;
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
        protected FormMode formMode;
        public Dictionary()
        {
            InitializeComponent();
            _main = this;
        }

        public static Dictionary Instance
        {
            get { return _main; }
        }

        RadGridView _RadGridChild;
        public RadGridView RadGridChild
        {
            get { return this._RadGridChild; }
            set { this._RadGridChild = value; }
        }

        RadGridView _RadGrid;
        public RadGridView RadGrid
        {
            get { return this._RadGrid; }
            set { this._RadGrid = value; }
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

        #region Combox

        protected void AddComboxToGrid(RadGridView dt, string Display, string value, string field, string combname, string headertext, int with,int sottcomb)
        {
            //add column combobox
            //create the combo box column
            GridViewComboBoxColumn comboColumn = new GridViewComboBoxColumn(value);
            //set the column data source - the possible column values
            comboColumn.DataSource = dt.DataSource;
            comboColumn.Width = with;
            comboColumn.DisplayMember = Display;
            comboColumn.ValueMember = value;
            comboColumn.FieldName = field;
            comboColumn.Name = combname;
            comboColumn.HeaderText = headertext;
            comboColumn.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //add the column to the grid
            RadGrid.Columns.Add(comboColumn);
            this.RadGrid.Columns.Move(this.RadGrid.Columns["STT"].Index, 0);
            this.RadGrid.Columns.Move(this.RadGrid.Columns[combname].Index, sottcomb);
        }

        protected void AddComboxToGridParent(RadGridView dt, string Display, string value, string field, string combname, string headertext, int with)
        {
            //add column combobox
            //create the combo box column
            GridViewComboBoxColumn comboColumn = new GridViewComboBoxColumn(value);
            //set the column data source - the possible column values
            comboColumn.DataSource = dt.DataSource;
            comboColumn.Width = with;
            comboColumn.DisplayMember = Display;
            comboColumn.ValueMember = value;
            comboColumn.FieldName = field;
            comboColumn.Name = combname;
            comboColumn.HeaderText = headertext;
            comboColumn.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //add the column to the grid
            RadGridChild.Columns.Add(comboColumn);
            this.RadGridChild.Columns.Move(this.RadGridChild.Columns["STT"].Index, 0);
            this.RadGridChild.Columns.Move(this.RadGridChild.Columns[combname].Index, 1);
        }

        #endregion

        #region Thêm số thứ tự vào  trong radGridview

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
            this.RadGrid.Columns["STT"].MaxWidth = 50;
            this.RadGrid.Columns["STT"].MinWidth = 50;
            this.RadGrid.Columns["STT"].TextAlignment = ContentAlignment.TopCenter;
            this.RadGrid.Columns.Move(this.RadGrid.Columns["STT"].Index, 0);
        }

       
        protected virtual void STTChild()
        {
            // thêm số thứ tự vào RadGridChild
            this.RadGridChild.ShowGroupPanel = false;
            this.RadGridChild.MasterTemplate.AllowAddNewRow = true;
            this.RadGridChild.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            var lineNumbersColumn = new GridViewDecimalColumn(typeof(int), "STT", "STT");
            lineNumbersColumn.AllowSort = false;
            RadGridChild.Columns.Add(lineNumbersColumn);
            this.RadGridChild.Columns["STT"].Width = 50;
            this.RadGridChild.Columns["STT"].TextAlignment = ContentAlignment.TopCenter;
            this.RadGridChild.Columns.Move(this.RadGridChild.Columns["STT"].Index, 0);
        }

        protected virtual void radG_CellFormat(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement.ColumnInfo.Name == "STT" && string.IsNullOrEmpty(e.CellElement.Text))
            {
                e.CellElement.Text = (e.CellElement.RowIndex + 1).ToString();
            }
        }

        #endregion 

        #region Event

        private void Save(object sender, EventArgs e)
        {
            Save();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void Close(object sender, EventArgs e)
        {
            Cancel();
        }

        #endregion

        #region Virtual Method

        protected virtual void ApplyAuthorizationRules()
        {
            //enable button
            //EnableButton();
            //Duoc xay dung chi tiet tren form ke thua
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
            this.Close();
        }

        protected virtual void FormLoad()
        {
            //detail method event Formload
        }
        protected virtual void ShowHelper()
        {
            GlobalCommon.Helper.OpenFile(formMode.FormID);
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
            switch (keyData)
            {
                case Keys.Control | Keys.S:
                    Save();
                    break;
                case Keys.Escape:
                    Cancel();
                    break;
                case Keys.Control | Keys.D:
                    Delete();
                    break;
                case Keys.F11:
                    ShowHelper();
                    break;
                default:
                    break;
            }
            //if (keyData == Keys.F1)
            //{
            //    New();
            //}
            //if (keyData == Keys.F5)
            //{
            //    Save();
            //}
            //else if (keyData == Keys.F7)
            //{
            //    Cancel();
            //}
            //else if (keyData == Keys.F12)
            //{
            //    Delete();
            //}
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion
    }
}
