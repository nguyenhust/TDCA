using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using NETLINK.LIB;

namespace NETLINK.UI
{
    public partial class UsDictionary : WinPart
    {
        protected bool bl_btnVisbleMyClose = true;
        protected  bool bl_btnSave = false;
        protected  bool bl_btnPrint = false;
        protected  bool bl_btnMyClose = false;
        protected bool bl_btnDelete = false;
        private bool _printToShow = false;
        private bool _saveToNew = false;
        //private long total = 0;
        protected FormMode mode;
        protected string FilterExpression { get; set; }
        protected void ShowHelper()
        {
            GlobalCommon.Helper.OpenFile(this.GetIdValue().ToString());
        }
        public UsDictionary()
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            btnSave.Enabled = bl_btnSave;
            btnMyClose.Enabled = bl_btnMyClose;
            btnPrint.Enabled = bl_btnPrint;
            btnMyClose.Visible = bl_btnVisbleMyClose;
            btnDelete.Enabled = bl_btnDelete;
            btnNew.Enabled = bl_btnSave;
            if (_RadGrid != null)
                _RadGrid.Font = new System.Drawing.Font("Segoe UI", 8.25f);
            //total = 0;
        }

        //void CaculateTotalRecord(CellFormattingEventArgs e)
        //{
        //    if (e.Row.IsVisible)
        //    {
        //        total++;
        //    }
        //    else
        //    {
        //        total--;
        //    }
        //    TotalRecord.Text = "Tổng số : " + total.ToString();
        //}

        #region Button Click

        private void btnSave_Click(object sender, EventArgs e)
        {
            CallCellEndEdit();
             Save();
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            CallCellEndEdit();
             Print();
             
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
             MyClose();
        }

        private void LoadUserControl(object sender, EventArgs e)
        {
            LoadUS();
            ApplyAuthorizationRules();
            CaculateTongSo();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
            CallCellEndEdit();
        }

        private void btnPrint2_Click(object sender, EventArgs e)
        {
            CallCellEndEdit();
            Print2();
        }

        private void btnPrint3_Click(object sender, EventArgs e)
        {
            CallCellEndEdit();
            Print3();
        }

        private void btnPrint4_Click(object sender, EventArgs e)
        {
            CallCellEndEdit();
            Print4();
}
        private void btnInCCKC_Click(object sender, EventArgs e)
        {
            CallCellEndEdit();
            Print5();
        }
        private void btnInCCTL_Click(object sender, EventArgs e)
        {
            CallCellEndEdit();
            Print6();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            CallCellEndEdit();
            Save();
        }

        private void btnListData_Click(object sender, EventArgs e)
        {
            if (_printToShow)
                Print();
            else
                List();
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            int X = Convert.ToInt32((panel1.Width - Title.Width) / 2);
            Title.Location = new Point(X, Title.Location.Y);
        }
        #endregion

        #region Virtual Method

        protected virtual void ApplyAuthorizationRules()
        {
            //enable button
            //EnableButton();
            //Duoc xay dung chi tiet tren form ke thua
        }

        protected virtual void Save()
        {
          //Duoc xay dung chi tiet tren doi tuong ke thua
        }

        protected virtual void Print()
        {
          //Duoc xay dung chi tiet tren doi tuong ke thua
        }
        protected virtual void Print2()
        {
            //Duoc xay dung chi tiet tren doi tuong ke thua
        }
        protected virtual void Print3()
        {
            //Duoc xay dung chi tiet tren doi tuong ke thua
        }
        protected virtual void Print4()
        {
            //Duoc xay dung chi tiet tren doi tuong ke thua
        }
        protected virtual void Print5()
        {
            //Duoc xay dung chi tiet tren doi tuong ke thua
        }
        protected virtual void Print6()
        {
            //Duoc xay dung chi tiet tren doi tuong ke thua
        }

        protected virtual void MyClose()
        {
            this.Close();
            //Duoc xay dung chi tiet tren doi tuong ke thua
        }

        protected virtual void LoadUS()
        {
            //Duoc xay dung chi tiet tren doi tuong ke thua
        }

        protected virtual void Delete()
        {
            //Duoc xay dung chi tiet tren doi tuong ke thua
        }
        protected virtual void List()
        {

        }
        protected virtual void PrintToExcel()
        {
            try
            {
                if (RadGrid == null)
                {
                    return;
                }
                string[] colName = new string[RadGrid.Columns.Count];
                string[,] data = new string[RadGrid.Rows.Count + 1, RadGrid.Columns.Count];
                int cR = 0;
                int cC = 0;
                //data[0, 0] = null;
                foreach (Telerik.WinControls.UI.GridViewColumn colInfo in RadGrid.Columns)
                {
                    if (colInfo.IsVisible && !string.IsNullOrEmpty(colInfo.HeaderText))
                        colName[cC] = colInfo.HeaderText;
                    else
                        colName[cC] = string.Format("{0}", colInfo.HeaderText);
                    cC++;
                }
                cC = 0;
                DateTime day = DateTime.Now;
                foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
                {
                    if (rowInfo.IsVisible)
                    {
                        foreach (Telerik.WinControls.UI.GridViewCellInfo cl in rowInfo.Cells)
                        {
                            if (cl != null && cl.Value != null && !string.IsNullOrEmpty(cl.Value.ToString()))
                            {
                                try
                                {
                                    if (DateTime.TryParse(cl.Value.ToString().Replace(".",""), out day))
                                          data[cR, cC] = Convert.ToDateTime(cl.Value).ToString("dd/MM/yyyy");   
                                    else
                                        data[cR, cC] = cl.Value.ToString();
                                }
                                catch(Exception ex)
                                {
                                    throw(ex);
                                }
                            }
                            else
                            {
                                
                                data[cR, cC] = string.Empty;
                            }
                            cC++;
                        }
                        cC = 0;
                        cR++;
                    }
                }
                //for (int i = cR; i < RadGrid.Rows.Count; i++)
                //{
                //    for (int j = 0; j < RadGrid.Columns.Count; j++)
                //    {
                //        data[i, j] = string.Empty;
                //    }
                //}
                ExcelHelper exH = new ExcelHelper();
                exH.WriteExcel(colName, data);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        #endregion

        #region Thêm số thứ tự vào  trong radGridview

        RadGridView _RadGrid;
        public RadGridView RadGrid
        {
            get { return this._RadGrid; }
            set
            {
                this._RadGrid = value;
                this._RadGrid.FilterExpressionChanged += _RadGrid_FilterExpressionChanged;
                this._RadGrid.FilterChanged += _RadGrid_FilterChanged;
            }
        }
        protected string TotalRecordValue
        {
            get { return TotalRecord.Text; }
            set { TotalRecord.Text = "Tổng số :" + value + "    ";}
        }
        void _RadGrid_FilterChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            CaculateTongSo();
        }
        private void CaculateTongSo()
        {
            if (_RadGrid != null)
            {
                int TongSo = 0;
                foreach (GridViewRowInfo rowInfo in _RadGrid.ChildRows)
                {
                    if (rowInfo.IsVisible)
                        TongSo++;
                }
                TotalRecord.Text = "Tổng số :" + TongSo.ToString() + "    ";
            }
        }
        void _RadGrid_FilterExpressionChanged(object sender, FilterExpressionChangedEventArgs e)
        {
          
        }

        protected void STT()
        {
            // thêm số thứ tự vào radgrid
            this.RadGrid.ShowGroupPanel = false;
            //this.RadGrid.MasterTemplate.AllowAddNewRow = true;
            this.RadGrid.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            var lineNumbersColumn = new GridViewDecimalColumn(typeof(int), "STT", "STT");
            lineNumbersColumn.AllowSort = false;
            RadGrid.Columns.Add(lineNumbersColumn);
            this.RadGrid.Columns["STT"].Width = 50;
            this.RadGrid.Columns["STT"].MaxWidth = 50;
            this.RadGrid.Columns["STT"].MinWidth = 50;
            this.RadGrid.Columns["STT"].ReadOnly = true;
            this.RadGrid.Columns["STT"].TextAlignment = ContentAlignment.TopCenter;
            this.RadGrid.Columns.Move(this.RadGrid.Columns["STT"].Index, 0);
        }
        protected void STT(RadGridView radgrid)
        {
            // thêm số thứ tự vào radgrid
            radgrid.ShowGroupPanel = false;
            //radgrid.MasterTemplate.AllowAddNewRow = true;
            radgrid.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            var lineNumbersColumn = new GridViewDecimalColumn(typeof(int), "STT", "STT");
            lineNumbersColumn.AllowSort = false;
            radgrid.Columns.Add(lineNumbersColumn);
            radgrid.Columns["STT"].Width = 50;
            radgrid.Columns["STT"].MaxWidth = 50;
            radgrid.Columns["STT"].MinWidth = 50;
            radgrid.Columns["STT"].TextAlignment = ContentAlignment.TopCenter;
            radgrid.Columns["STT"].ReadOnly = true;
            radgrid.Columns.Move(radgrid.Columns["STT"].Index, 0);
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

        protected void StateSave()
        {
            btnSave.Text = "Lưu thành công";
            btnSave.Enabled = false;
        }

        protected void StateDirty()
        {
            btnSave.Text = "Lưu thông tin";
            btnSave.Enabled = true;
        }
        protected void HidenButton()
        {
            btnNew.Visible = false;
            ts_New.Visible = false;
        }
        protected void SaveToNew()
        {
            _saveToNew = true;
            btnSave.Visible = false;
            ts_Save.Visible = false;
            btnNew.Visible = true;
            ts_New.Visible = true;
        }

        protected void PrintToShow()
        {
            _printToShow = true;
            btnPrint.Visible = false;
            ts_Print.Visible = false;
            btnListData.Visible = true;
            ts_List.Visible = true;
        }
        protected void HideSave()
        {
            btnSave.Visible = false;
            ts_Save.Visible = false;
        }
        protected void HideNew()
        {
            btnNew.Visible = false;
            ts_New.Visible = false;
        }
        protected void ShowNew()
        {
            btnNew.Visible = true;
            ts_New.Visible = true;
        }
        protected void HidePrint()
        {
            btnPrint.Visible = false;
            ts_Print.Visible = false;
        }
        protected void HideDelete()
        {
            btnDelete.Visible = false;
            ts_Del.Visible = false;
        }
        protected void HideList()
        {
            btnListData.Visible = false;
            ts_List.Visible = false;
        }
        protected void ShowSave()
        {
            btnSave.Visible = true;
        }
        protected void ShowPrint()
        {
            btnPrint.Visible = true;
        }
        protected void ShowDelete()
        {
            btnDelete.Visible = true;
        }
        protected void StateDelete()
        {
            btnDelete.Text = "Xóa Thành Công";
            btnDelete.Enabled = false;
            LoadUS();
        }
        protected void PrintToOther(string text)
        {
            btnPrint.Text = text;
            btnPrint.Enabled = true;
        }
        protected void SaveToOther(string text)
        {
            btnSave.Text = text;
            btnSave.Enabled = true;
        }

        #endregion

        #region Xử lý phím tắt trong form

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Control | Keys.N:
                    Save();
                    break;
                case Keys.Control | Keys.S:
                    Save();
                    break;
                case Keys.Control | Keys.P:
                    Print();
                    break;
                case Keys.Control | Keys.L:
                    if (_printToShow)
                        Print();
                    else
                        List();
                    break;
                case Keys.Control | Keys.Escape:
                    MyClose();
                    break;
                case Keys.Control | Keys.Delete:
                    Delete();
                    break;
                case Keys.F11:
                    ShowHelper();
                    break;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public bool ProcessKeys(ref Message msg,Keys keyData)
        {
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        #region Control

        protected void HideToolBar()
        {
            toolStrControl.Visible = false;
        }

        protected void CallCellEndEdit()
        {
            try
            {
                if (_RadGrid != null && _RadGrid.AllowEditRow && !_RadGrid.CurrentRow.Cells[_RadGrid.CurrentColumn.Name].ReadOnly)
                {
                    _RadGrid.CurrentRow.Cells[_RadGrid.CurrentColumn.Name].EndEdit();
                    //_RadGrid.CellEndEdit(_RadGrid, new GridViewCellEventArgs(_RadGrid.CurrentRow, _RadGrid.CurrentColumn, new IInputEditor()));
                }
            }
            catch
            {
            }
        }

     
        #endregion



        public override void SetTitle(string text)
        {
            Title.Text = text;
            int X = Convert.ToInt32((panel1.Width - (Title.Text.Length * 6.29)) / 2);
            Title.Location = new Point(X, Title.Location.Y);
        }

        public bool ShowPrint2
        {
            set { btnPrint2.Visible = value;
            ts_Print2.Visible = value;
            }
        }
        public bool ShowPrint3
        {
            set { btnPrint3.Visible = value; ts_Print3.Visible = value; }
        }
        public bool ShowPrint4
        {
            set { btnPrint4.Visible = value; ts_Print4.Visible = value; }
        }
        public bool ShowPrint5
        {
            set { btnInCCKC.Visible = value; ts_Print5.Visible = value; }
        }
        public bool ShowPrint6
        {
            set { btnInCCTL.Visible = value; ts_Print6.Visible = value; }
        }
        public string TextPrint
        {
            get { return btnPrint.Text; }
            set { btnPrint.Text = value; }
        }
        public string TextPrint2
        {
            get { return btnPrint2.Text; }
            set { btnPrint2.Text = value; }
        }
        public string TextPrint3
        {
            get { return btnPrint3.Text; }
            set { btnPrint3.Text = value; }
        }
        public string TextPrint4
        {
            get { return btnPrint4.Text; }
            set { btnPrint4.Text = value; }
        }
        public string TextPrint5
        {
            get { return btnInCCKC.Text; }
            set { btnInCCKC.Text = value; }
        }
        public string TextPrint6
        {
            get { return btnInCCTL.Text; }
            set { btnInCCTL.Text = value; }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            PrintToExcel();
        }

    }
}
