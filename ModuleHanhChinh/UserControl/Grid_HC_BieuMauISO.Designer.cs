﻿namespace ModuleHanhChinh.UserControl
{
    partial class Grid_HC_BieuMauISO
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewHyperlinkColumn gridViewHyperlinkColumn1 = new Telerik.WinControls.UI.GridViewHyperlinkColumn();
            this.radGridView = new Telerik.WinControls.UI.RadGridView();
            this.radbindingSource = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView
            // 
            this.radGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView.Location = new System.Drawing.Point(0, 61);
            // 
            // radGridView
            // 
            this.radGridView.MasterTemplate.AllowAddNewRow = false;
            this.radGridView.MasterTemplate.AllowDeleteRow = false;
            this.radGridView.MasterTemplate.AllowDragToGroup = false;
            this.radGridView.MasterTemplate.AllowEditRow = false;
            this.radGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.Width = 43;
            gridViewTextBoxColumn1.FieldName = "Ten";
            gridViewTextBoxColumn1.HeaderText = "Tên";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Ten";
            gridViewTextBoxColumn1.Width = 192;
            gridViewTextBoxColumn2.FieldName = "MaSo";
            gridViewTextBoxColumn2.HeaderText = "MaSo";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "MaSo";
            gridViewTextBoxColumn2.Width = 46;
            gridViewTextBoxColumn3.FieldName = "NgayBatDau";
            gridViewTextBoxColumn3.HeaderText = "Áp dụng từ";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "NgayBatDau";
            gridViewTextBoxColumn3.Width = 199;
            gridViewDateTimeColumn1.FieldName = "DateNgayBatDau";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn1.FormatString = "{0:d}";
            gridViewDateTimeColumn1.HeaderText = "Áp dụng từ";
            gridViewDateTimeColumn1.Name = "DateNgayBatDau";
            gridViewDateTimeColumn1.Width = 166;
            gridViewTextBoxColumn4.FieldName = "TenBoPhan";
            gridViewTextBoxColumn4.HeaderText = "Nơi ban hành";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "TenBoPhan";
            gridViewTextBoxColumn4.Width = 192;
            gridViewTextBoxColumn5.FieldName = "Link";
            gridViewTextBoxColumn5.HeaderText = "Link";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "Link";
            gridViewTextBoxColumn6.FieldName = "NoiDungApDung";
            gridViewTextBoxColumn6.HeaderText = "NoiDungApDung";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "NoiDungApDung";
            gridViewTextBoxColumn6.Width = 55;
            gridViewTextBoxColumn7.FieldName = "GhiChu";
            gridViewTextBoxColumn7.HeaderText = "GhiChu";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "GhiChu";
            gridViewTextBoxColumn7.Width = 61;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<long>);
            gridViewDecimalColumn2.FieldName = "LastEdited_UserID";
            gridViewDecimalColumn2.HeaderText = "LastEdited_UserID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "LastEdited_UserID";
            gridViewDecimalColumn2.Width = 68;
            gridViewTextBoxColumn8.FieldName = "LastEdited_Date";
            gridViewTextBoxColumn8.HeaderText = "LastEdited_Date";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "LastEdited_Date";
            gridViewTextBoxColumn8.Width = 77;
            gridViewDecimalColumn3.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn3.FieldName = "IdBoPhan";
            gridViewDecimalColumn3.HeaderText = "IdBoPhan";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.IsVisible = false;
            gridViewDecimalColumn3.Name = "IdBoPhan";
            gridViewDecimalColumn3.Width = 89;
            gridViewDecimalColumn4.DataType = typeof(System.Nullable<long>);
            gridViewDecimalColumn4.FieldName = "IdUserUp";
            gridViewDecimalColumn4.HeaderText = "IdUserUp";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.IsVisible = false;
            gridViewDecimalColumn4.Name = "IdUserUp";
            gridViewDecimalColumn4.Width = 106;
            gridViewTextBoxColumn9.FieldName = "Version";
            gridViewTextBoxColumn9.HeaderText = "Phiên bản";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.Name = "Version";
            gridViewTextBoxColumn9.Width = 192;
            gridViewTextBoxColumn10.FieldName = "TenUserUp";
            gridViewTextBoxColumn10.HeaderText = "Người tải lên";
            gridViewTextBoxColumn10.Name = "TenUserUp";
            gridViewTextBoxColumn10.Width = 192;
            gridViewHyperlinkColumn1.HeaderText = "";
            gridViewHyperlinkColumn1.Name = "xem";
            gridViewHyperlinkColumn1.Width = 191;
            this.radGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn8,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewHyperlinkColumn1});
            this.radGridView.MasterTemplate.DataSource = this.radbindingSource;
            this.radGridView.MasterTemplate.EnableFiltering = true;
            this.radGridView.Name = "radGridView";
            this.radGridView.ReadOnly = true;
            this.radGridView.Size = new System.Drawing.Size(1140, 258);
            this.radGridView.TabIndex = 1;
            this.radGridView.Text = "radGridView1";
            this.radGridView.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.radGridView_CellFormatting);
            this.radGridView.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView_CellClick);
            this.radGridView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView_CellDoubleClick);
            // 
            // radbindingSource
            // 
            this.radbindingSource.DataSource = typeof(ModuleHanhChinh.LIB.HC_BieuMauISO_Coll);
            // 
            // Grid_HC_BieuMauISO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView);
            this.Name = "Grid_HC_BieuMauISO";
            this.Controls.SetChildIndex(this.radGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView;
        private System.Windows.Forms.BindingSource radbindingSource;
    }
}
