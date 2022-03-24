﻿namespace DanhMuc.UserControl
{
    partial class CoQuan
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
            this.radgCoQuan = new Telerik.WinControls.UI.RadGridView();
            this.bindCoQuan = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radgCoQuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgCoQuan.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindCoQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // radgCoQuan
            // 
            this.radgCoQuan.BackColor = System.Drawing.SystemColors.Control;
            this.radgCoQuan.Cursor = System.Windows.Forms.Cursors.Default;
            this.radgCoQuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radgCoQuan.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.radgCoQuan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radgCoQuan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radgCoQuan.Location = new System.Drawing.Point(0, 28);
            // 
            // radgCoQuan
            // 
            this.radgCoQuan.MasterTemplate.AllowAddNewRow = false;
            this.radgCoQuan.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Ten";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Tên";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.MaxLength = 100;
            gridViewTextBoxColumn1.MaxWidth = 250;
            gridViewTextBoxColumn1.MinWidth = 250;
            gridViewTextBoxColumn1.Name = "Ten";
            gridViewTextBoxColumn1.Width = 250;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "DiaChi";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Địa Chỉ";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.MaxLength = 100;
            gridViewTextBoxColumn2.MaxWidth = 300;
            gridViewTextBoxColumn2.MinWidth = 300;
            gridViewTextBoxColumn2.Name = "DiaChi";
            gridViewTextBoxColumn2.Width = 300;
            gridViewCheckBoxColumn1.DataType = typeof(System.Nullable<bool>);
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "SuDung";
            gridViewCheckBoxColumn1.HeaderText = "Sử Dụng";
            gridViewCheckBoxColumn1.IsAutoGenerated = true;
            gridViewCheckBoxColumn1.MaxWidth = 90;
            gridViewCheckBoxColumn1.MinWidth = 90;
            gridViewCheckBoxColumn1.Name = "SuDung";
            gridViewCheckBoxColumn1.Width = 90;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "GhiChu";
            gridViewTextBoxColumn3.HeaderText = "Ghi Chú";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.MaxLength = 100;
            gridViewTextBoxColumn3.Name = "GhiChu";
            gridViewTextBoxColumn3.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn3.Width = 5;
            this.radgCoQuan.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn3});
            this.radgCoQuan.MasterTemplate.DataSource = this.bindCoQuan;
            this.radgCoQuan.MasterTemplate.EnableFiltering = true;
            sortDescriptor1.PropertyName = "GhiChu";
            this.radgCoQuan.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.radgCoQuan.Name = "radgCoQuan";
            this.radgCoQuan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radgCoQuan.Size = new System.Drawing.Size(365, 291);
            this.radgCoQuan.TabIndex = 1;
            this.radgCoQuan.Text = "radGridView1";
            this.radgCoQuan.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.CellFormatting);
            this.radgCoQuan.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radgCoQuan_CellDoubleClick);
            // 
            // bindCoQuan
            // 
            this.bindCoQuan.DataSource = typeof(DanhMuc.LIB.DIC_CoQuan_Coll);
            // 
            // CoQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radgCoQuan);
            this.Name = "CoQuan";
            this.Controls.SetChildIndex(this.radgCoQuan, 0);
            ((System.ComponentModel.ISupportInitialize)(this.radgCoQuan.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgCoQuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindCoQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radgCoQuan;
        private System.Windows.Forms.BindingSource bindCoQuan;
    }
}