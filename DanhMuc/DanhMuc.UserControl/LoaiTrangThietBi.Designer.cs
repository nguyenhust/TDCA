﻿namespace DanhMuc.UserControl
{
    partial class LoaiTrangThietBi
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.radgLoaiTrangThietBi = new Telerik.WinControls.UI.RadGridView();
            this.bindLoaiTrangThietBi = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radgLoaiTrangThietBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgLoaiTrangThietBi.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindLoaiTrangThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // radgLoaiTrangThietBi
            // 
            this.radgLoaiTrangThietBi.BackColor = System.Drawing.SystemColors.Control;
            this.radgLoaiTrangThietBi.Cursor = System.Windows.Forms.Cursors.Default;
            this.radgLoaiTrangThietBi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radgLoaiTrangThietBi.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.radgLoaiTrangThietBi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radgLoaiTrangThietBi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radgLoaiTrangThietBi.Location = new System.Drawing.Point(0, 61);
            // 
            // radgLoaiTrangThietBi
            // 
            this.radgLoaiTrangThietBi.MasterTemplate.AllowAddNewRow = false;
            this.radgLoaiTrangThietBi.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Ma";
            gridViewTextBoxColumn1.HeaderText = "Mã";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.MaxLength = 10;
            gridViewTextBoxColumn1.MaxWidth = 100;
            gridViewTextBoxColumn1.MinWidth = 100;
            gridViewTextBoxColumn1.Name = "Ma";
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Ten";
            gridViewTextBoxColumn2.HeaderText = "Tên Loại";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.MaxLength = 100;
            gridViewTextBoxColumn2.MaxWidth = 150;
            gridViewTextBoxColumn2.MinWidth = 150;
            gridViewTextBoxColumn2.Name = "Ten";
            gridViewTextBoxColumn2.Width = 150;
            gridViewCheckBoxColumn1.DataType = typeof(System.Nullable<bool>);
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "SuDung";
            gridViewCheckBoxColumn1.HeaderText = "Sử Dụng";
            gridViewCheckBoxColumn1.IsAutoGenerated = true;
            gridViewCheckBoxColumn1.MaxWidth = 90;
            gridViewCheckBoxColumn1.MinWidth = 90;
            gridViewCheckBoxColumn1.Name = "SuDung";
            gridViewCheckBoxColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewCheckBoxColumn1.Width = 90;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "GhiChu";
            gridViewTextBoxColumn3.HeaderText = "Ghi Chú";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.MaxLength = 100;
            gridViewTextBoxColumn3.Name = "GhiChu";
            gridViewTextBoxColumn3.Width = 783;
            this.radgLoaiTrangThietBi.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn3});
            this.radgLoaiTrangThietBi.MasterTemplate.DataSource = this.bindLoaiTrangThietBi;
            this.radgLoaiTrangThietBi.MasterTemplate.EnableFiltering = true;
            sortDescriptor1.PropertyName = "SuDung";
            this.radgLoaiTrangThietBi.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.radgLoaiTrangThietBi.Name = "radgLoaiTrangThietBi";
            this.radgLoaiTrangThietBi.ReadOnly = true;
            this.radgLoaiTrangThietBi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radgLoaiTrangThietBi.Size = new System.Drawing.Size(1140, 258);
            this.radgLoaiTrangThietBi.TabIndex = 1;
            this.radgLoaiTrangThietBi.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.CellFormatting);
            this.radgLoaiTrangThietBi.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radgLoai_CellDoubleClick);
            // 
            // bindLoaiTrangThietBi
            // 
            this.bindLoaiTrangThietBi.DataSource = typeof(DanhMuc.LIB.DIC_LoaiTrangThietBi_Coll);
            // 
            // Loai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radgLoaiTrangThietBi);
            this.Name = "Loai";
            this.Controls.SetChildIndex(this.radgLoaiTrangThietBi, 0);
            ((System.ComponentModel.ISupportInitialize)(this.radgLoaiTrangThietBi.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgLoaiTrangThietBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindLoaiTrangThietBi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radgLoaiTrangThietBi;
        private System.Windows.Forms.BindingSource bindLoaiTrangThietBi;
    }
}
