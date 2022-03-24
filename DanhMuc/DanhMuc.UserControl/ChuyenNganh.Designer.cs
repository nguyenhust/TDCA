﻿namespace DanhMuc.UserControl
{
    partial class ChuyenNganh
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            this.radgChuyenNganh = new Telerik.WinControls.UI.RadGridView();
            this.bindChuyenNganh = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radgChuyenNganh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgChuyenNganh.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindChuyenNganh)).BeginInit();
            this.SuspendLayout();
            // 
            // radgChuyenNganh
            // 
            this.radgChuyenNganh.BackColor = System.Drawing.SystemColors.Control;
            this.radgChuyenNganh.Cursor = System.Windows.Forms.Cursors.Default;
            this.radgChuyenNganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radgChuyenNganh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.radgChuyenNganh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radgChuyenNganh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radgChuyenNganh.Location = new System.Drawing.Point(0, 28);
            // 
            // radgChuyenNganh
            // 
            this.radgChuyenNganh.MasterTemplate.AllowAddNewRow = false;
            this.radgChuyenNganh.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
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
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Mã";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.MaxLength = 10;
            gridViewTextBoxColumn1.Name = "Ma";
            gridViewTextBoxColumn1.Width = 49;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Ten";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Tên";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.MaxLength = 100;
            gridViewTextBoxColumn2.Name = "Ten";
            gridViewTextBoxColumn2.Width = 49;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "TenTat";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Tên Tắt";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.MaxLength = 20;
            gridViewTextBoxColumn3.Name = "TenTat";
            gridViewTextBoxColumn3.Width = 49;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "TruongCN";
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "Trường CN";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.MaxLength = 50;
            gridViewTextBoxColumn4.Name = "TruongCN";
            gridViewTextBoxColumn4.Width = 49;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "ID_ChuyenKhoa";
            gridViewDecimalColumn2.HeaderText = "ID_ChuyenKhoa";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "ID_ChuyenKhoa";
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "GhiChu";
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "Ghi Chú";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "GhiChu";
            gridViewTextBoxColumn5.Width = 63;
            gridViewCheckBoxColumn1.DataType = typeof(System.Nullable<bool>);
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "SuDung";
            gridViewCheckBoxColumn1.FormatString = "";
            gridViewCheckBoxColumn1.HeaderText = "Sử Dụng";
            gridViewCheckBoxColumn1.IsAutoGenerated = true;
            gridViewCheckBoxColumn1.MaxWidth = 90;
            gridViewCheckBoxColumn1.MinWidth = 90;
            gridViewCheckBoxColumn1.Name = "SuDung";
            gridViewCheckBoxColumn1.Width = 90;
            this.radgChuyenNganh.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn5,
            gridViewCheckBoxColumn1});
            this.radgChuyenNganh.MasterTemplate.DataSource = this.bindChuyenNganh;
            this.radgChuyenNganh.MasterTemplate.EnableFiltering = true;
            this.radgChuyenNganh.Name = "radgChuyenNganh";
            this.radgChuyenNganh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radgChuyenNganh.Size = new System.Drawing.Size(365, 291);
            this.radgChuyenNganh.TabIndex = 1;
            this.radgChuyenNganh.Text = "radGridView1";
            this.radgChuyenNganh.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.CellFormatting);
            this.radgChuyenNganh.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radgChuyenNganh_CellDoubleClick);
            // 
            // bindChuyenNganh
            // 
            this.bindChuyenNganh.DataSource = typeof(DanhMuc.LIB.DIC_ChuyenNganh_Coll);
            // 
            // ChuyenNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radgChuyenNganh);
            this.Name = "ChuyenNganh";
            this.Controls.SetChildIndex(this.radgChuyenNganh, 0);
            ((System.ComponentModel.ISupportInitialize)(this.radgChuyenNganh.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgChuyenNganh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindChuyenNganh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radgChuyenNganh;
        private System.Windows.Forms.BindingSource bindChuyenNganh;
    }
}
