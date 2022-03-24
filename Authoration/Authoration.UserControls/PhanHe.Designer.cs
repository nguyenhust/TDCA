﻿namespace Authoration.UserControls
{
    partial class PhanHe
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
            this.radgPhaHe = new Telerik.WinControls.UI.RadGridView();
            this.bindPhanHe = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radgPhaHe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgPhaHe.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindPhanHe)).BeginInit();
            this.SuspendLayout();
            // 
            // radgPhaHe
            // 
            this.radgPhaHe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radgPhaHe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radgPhaHe.Location = new System.Drawing.Point(0, 28);
            // 
            // radgPhaHe
            // 
            this.radgPhaHe.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.FormatString = "";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.Width = 87;
            gridViewTextBoxColumn1.FieldName = "Ma";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Mã";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Ma";
            gridViewTextBoxColumn1.Width = 116;
            gridViewTextBoxColumn2.FieldName = "TenPhanHe";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Tên phân hệ";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "TenPhanHe";
            gridViewTextBoxColumn2.Width = 116;
            gridViewTextBoxColumn3.FieldName = "MoTa";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Mô tả";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "MoTa";
            gridViewTextBoxColumn3.Width = 114;
            this.radgPhaHe.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.radgPhaHe.MasterTemplate.DataSource = this.bindPhanHe;
            this.radgPhaHe.MasterTemplate.EnableFiltering = true;
            this.radgPhaHe.Name = "radgPhaHe";
            this.radgPhaHe.Size = new System.Drawing.Size(365, 291);
            this.radgPhaHe.TabIndex = 1;
            this.radgPhaHe.Text = "radGridView1";
            this.radgPhaHe.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.CellFormatting);
            this.radgPhaHe.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.CellValueChanged);
            this.radgPhaHe.CursorChanged += new System.EventHandler(this.CursorChanged);
            // 
            // bindPhanHe
            // 
            this.bindPhanHe.DataSource = typeof(Authoration.LIB.ADM_PhanHe_Coll);
            // 
            // PhanHe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radgPhaHe);
            this.Name = "PhanHe";
            this.Controls.SetChildIndex(this.radgPhaHe, 0);
            ((System.ComponentModel.ISupportInitialize)(this.radgPhaHe.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgPhaHe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindPhanHe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radgPhaHe;
        private System.Windows.Forms.BindingSource bindPhanHe;
    }
}