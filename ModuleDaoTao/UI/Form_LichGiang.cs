using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        string Thang;
        string strMaLopHoc;
        public Form2()
        {
            InitializeComponent();
            //this.gridView1.InitNewRow += gridView1_InitNewRow;
            
            
        }
        #region
        private void CustomGridView()
        {
            gridControl1.DataSource = GetDataSource();

            gridControl1.ForceInitialize();

            #region add memoedit to gridcolumn
            //RepositoryItemMemoEdit repoMemoThoiGian = new RepositoryItemMemoEdit();
            //gridView1.Columns[0].ColumnEdit = repoMemoThoiGian;
            RepositoryItemMemoEdit repoMemo = new RepositoryItemMemoEdit();
            gridView1.Columns[2].ColumnEdit = repoMemo;

            #endregion

            #region add Combobox to gridcolumn

            RepositoryItemComboBox _riEditor = new RepositoryItemComboBox();
            for (int i = 1; i < 10; i++)
            {
                _riEditor.Items.Add("Giáo viên " + i.ToString());
            }
            gridControl1.RepositoryItems.Add(_riEditor);
            gridView1.Columns[3].ColumnEdit = _riEditor;

            #endregion


            gridView1.Columns[2].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            gridView1.Columns[3].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.Columns[0].AppearanceCell.Options.UseTextOptions = true;
            gridView1.Columns[0].AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;

            #region set header caption for columns

            gridView1.Columns[1].Caption = "Thời gian";
            gridView1.Columns[1].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            gridView1.Columns[2].Caption = "Nội dung giảng";
            gridView1.Columns[2].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns[3].Caption = "Giảng viên";
            gridView1.Columns[3].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            #endregion

            #region fixing Column
            gridView1.Columns[0].Width = 120;
            gridView1.Columns[1].Width = 80;
            gridView1.Columns[2].Width = 300;
            gridView1.Columns[3].Width = 150;
            gridView1.Columns[1].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            gridView1.Columns[0].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            gridView1.Columns[1].OptionsColumn.AllowEdit = false;
            gridView1.Columns[1].OptionsColumn.AllowFocus = false;
            #endregion
        }
        #endregion



        private BindingList<Custom> GetDataSource()
        {


            var culture = new System.Globalization.CultureInfo("vi-VN");
            //DateTime dt = Convert.ToDateTime("01-10-2018");
            DateTime dt = Convert.ToDateTime(dateTuNgay.Text);
            int month =  dt.Month;
            DateTime enddate = Convert.ToDateTime(dateDenNgay.Text + " 12:00:00 PM");
            BindingList<Custom> list = new BindingList<Custom>();
            for (DateTime i = dt; i <= enddate; i = i.AddDays(0.5))
            {
                list.Add(new Custom()
                {
                    Ngay = culture.DateTimeFormat.GetDayName(i.DayOfWeek).ToString() + " " + i.ToString("dd/MM/yyyy"),
                    Buoi = i.ToString("tt").Replace("AM", "Sáng").Replace("PM", "Chiều"),
                    NoiDung = "",
                    GiangVien = ""

                });
            }
            return list;
        }
        public class Custom
        {
            public string Ngay { get; set; }
            public string Buoi { get; set; }
            public string NoiDung { get; set; }
            public string GiangVien { get; set; }

           
        }     
        private void gridView1_CellMerge(object sender, CellMergeEventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null) return;
            if (e.Column == gridView1.Columns[0])
            {
                string text1 = view.GetRowCellDisplayText(e.RowHandle1, gridView1.Columns[0]);
                string text2 = view.GetRowCellDisplayText(e.RowHandle2, gridView1.Columns[0]);
                if(text1 != "")
                e.Merge = (text1 == text2);
                e.Handled = true;
            }
        }
        Rectangle boundsPrevColumn;
        private void gridView1_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column == null)
                return;
            if (e.Column.FieldName == "Ngay")
            {
                // e.Info.Caption = String.Empty;
                boundsPrevColumn = e.Info.Bounds;
                e.Handled = true;
            }
            if (e.Column.FieldName == "Buoi")
            {
                Rectangle bounds = (e.Painter as HeaderObjectPainter).CalcObjectBounds(e.Info);
                e.Info.Bounds = new Rectangle(boundsPrevColumn.X, bounds.Y, bounds.Width + boundsPrevColumn.Width, bounds.Height);
                //    e.Info.CaptionRect = new Rectangle(e.Info.CaptionRect.X -offset, e.Info.CaptionRect.Y, e.Info.CaptionRect.Width, e.Info.CaptionRect.Height);
            }
        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (gridView1.GetRowCellValue(e.RowHandle, "Ngay").ToString().ToUpper().Contains("THỨ BẢY") || gridView1.GetRowCellValue(e.RowHandle, "Ngay").ToString().ToUpper().Contains("CHỦ NHẬT"))//||gridView1.GetRowCellValue(e.RowHandle, "ThoiGian").ToString().ToUpper().Contains("CHỦ NHẬT")
            {
                if(e.Column.Name == "colNgay"|| e.Column.Name == "colBuoi")
                e.Appearance.ForeColor = Color.Red;
            }
            if (e.Column.Name == "colNgay" && (e.RowHandle == gridView1.FocusedRowHandle || gridView1.FocusedRowHandle == e.RowHandle+1))
                e.Appearance.BackColor = Color.LightSteelBlue;
            
        }

        private void gridView1_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            DevExpress.XtraEditors.ComboBoxEdit cmb = new DevExpress.XtraEditors.ComboBoxEdit();
            
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void calChonNhieuNgay_Click(object sender, EventArgs e)
        {
           
        }

        private void calChonNhieuNgay_EditValueChanged(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime(calChonNhieuNgay.EditValue);
            //MessageBox.Show("Thông báo", date.ToString());
            for(int i = 0 ;i < gridView1.DataRowCount;i++)
            {
                string a = gridView1.GetRowCellValue(i, "Ngay").ToString();
                DateTime Curdate = Convert.ToDateTime(a.Substring(a.Length - 10, 10));
                if (Curdate == date)
                {
                    gridView1.Focus();
                    gridView1.SelectCell(i-1,gridView1.Columns[0]);
                    if (i == gridView1.DataRowCount-1 && gridView1.DataRowCount % 2 != 0)
                    gridView1.FocusedRowHandle = i;
                    else
                        gridView1.FocusedRowHandle = i-1;
                    gridView1.FocusedColumn = gridView1.VisibleColumns[2];
                    gridView1.TopRowIndex = i - 1;
                    gridView1.ShowEditor();
                   
                    
                }
            }
        }

        private void dateTuNgay_EditValueChanged(object sender, EventArgs e)
        {
            Thang = dateTuNgay.Text.ToString();
            if (this.dateDenNgay.Text != "")
            {
                GetDataSource();
                CustomGridView();
            }
        }

        private void dateDenNgay_EditValueChanged(object sender, EventArgs e)
        {
            if (this.dateTuNgay.Text != "")
            {
                GetDataSource();
                CustomGridView();
            }
        }

        private void gridView1_TopRowChanged(object sender, EventArgs e)
        {
            if (gridView1.TopRowIndex == gridView1.PrevTopRowIndex + 1 && gridView1.TopRowIndex % 2 != 0)
            {
                gridView1.TopRowIndex = gridView1.TopRowIndex + 1;
            }
            if (gridView1.TopRowIndex == gridView1.PrevTopRowIndex - 1 && gridView1.TopRowIndex % 2 != 0)
            {
                gridView1.TopRowIndex = gridView1.TopRowIndex - 1;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Thang = Convert.ToDateTime(Thang).AddMonths(1).ToString();
            Thang = Thang.Substring(3, 7);
            string DK = "[Ngay] like '%" + Thang + "%'"; 
            gridView1.Columns["Ngay"].FilterInfo = new ColumnFilterInfo(DK);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Thang = Convert.ToDateTime(Thang).AddMonths(-1).ToString();
            Thang = Thang.Substring(3, 7);
            string DK = "[Ngay] like '%" + Thang + "%'";
            gridView1.Columns["Ngay"].FilterInfo = new ColumnFilterInfo(DK);
        }      
    }
}
