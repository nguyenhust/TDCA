﻿namespace DanhMuc.UserControl
{
    partial class TinhThanh
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            this.radGTinhThanh = new Telerik.WinControls.UI.RadGridView();
            this.bindTinhThanh = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radGTinhThanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGTinhThanh.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindTinhThanh)).BeginInit();
            this.SuspendLayout();
            // 
            // radGTinhThanh
            // 
            this.radGTinhThanh.AutoScroll = true;
            this.radGTinhThanh.AutoSizeRows = true;
            this.radGTinhThanh.BackColor = System.Drawing.SystemColors.Control;
            this.radGTinhThanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radGTinhThanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGTinhThanh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.radGTinhThanh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGTinhThanh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGTinhThanh.Location = new System.Drawing.Point(0, 28);
            // 
            // radGTinhThanh
            // 
            this.radGTinhThanh.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(long);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 144;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Text;
            gridViewTextBoxColumn1.FieldName = "Ten";
            gridViewTextBoxColumn1.FormatInfo = new System.Globalization.CultureInfo("vi-VN");
            gridViewTextBoxColumn1.HeaderText = "Tên tỉnh";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.MaxLength = 100;
            gridViewTextBoxColumn1.Name = "Ten";
            gridViewTextBoxColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn1.Width = 111;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Ma";
            gridViewTextBoxColumn2.HeaderText = "Mã tỉnh";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.MaxLength = 10;
            gridViewTextBoxColumn2.Name = "Ma";
            gridViewTextBoxColumn2.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn2.Width = 111;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "MaDK";
            gridViewTextBoxColumn3.HeaderText = "Mã đăng ký";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.MaxLength = 2;
            gridViewTextBoxColumn3.Name = "MaDK";
            gridViewTextBoxColumn3.Width = 111;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "TieuDe";
            gridViewTextBoxColumn4.HeaderText = "TieuDe";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "TieuDe";
            gridViewTextBoxColumn4.Width = 120;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<long>);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "IDRefer";
            gridViewDecimalColumn2.HeaderText = "ID Refer";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "IDRefer";
            gridViewDecimalColumn2.Width = 76;
            gridViewCheckBoxColumn1.DataType = typeof(System.Nullable<bool>);
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "SuDung";
            gridViewCheckBoxColumn1.HeaderText = "Sử dụng";
            gridViewCheckBoxColumn1.IsAutoGenerated = true;
            gridViewCheckBoxColumn1.MaxWidth = 90;
            gridViewCheckBoxColumn1.MinWidth = 90;
            gridViewCheckBoxColumn1.Name = "SuDung";
            gridViewCheckBoxColumn1.Width = 90;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "GhiChu";
            gridViewTextBoxColumn5.HeaderText = "Ghi chú";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.MaxLength = 100;
            gridViewTextBoxColumn5.Name = "GhiChu";
            gridViewTextBoxColumn5.Width = 103;
            gridViewTextBoxColumn6.DataType = typeof(DanhMuc.LIB.DIC_TinhChild_Coll);
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "DIC_TinhChild";
            gridViewTextBoxColumn6.HeaderText = "DIC_TinhChild";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "DIC_TinhChild";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 82;
            this.radGTinhThanh.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn2,
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.radGTinhThanh.MasterTemplate.DataSource = this.bindTinhThanh;
            this.radGTinhThanh.MasterTemplate.EnableFiltering = true;
            sortDescriptor1.PropertyName = "Ten";
            sortDescriptor2.PropertyName = "Ma";
            this.radGTinhThanh.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1,
            sortDescriptor2});
            this.radGTinhThanh.Name = "radGTinhThanh";
            this.radGTinhThanh.ReadOnly = true;
            this.radGTinhThanh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGTinhThanh.Size = new System.Drawing.Size(543, 249);
            this.radGTinhThanh.TabIndex = 1;
            this.radGTinhThanh.Text = "radGTinhThanh";
            this.radGTinhThanh.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGTinhThanh_CellDoubleClick);
            // 
            // bindTinhThanh
            // 
            this.bindTinhThanh.DataSource = typeof(DanhMuc.LIB.DIC_Tinh);
            // 
            // TinhThanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGTinhThanh);
            this.Name = "TinhThanh";
            this.Size = new System.Drawing.Size(543, 277);
            this.Controls.SetChildIndex(this.radGTinhThanh, 0);
            ((System.ComponentModel.ISupportInitialize)(this.radGTinhThanh.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGTinhThanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindTinhThanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGTinhThanh;
        private System.Windows.Forms.BindingSource bindTinhThanh;
    }
}
