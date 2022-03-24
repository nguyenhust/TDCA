﻿namespace ModuleHanhChinh.ThanhToan
{
    partial class FormLyDoHuy
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLyDoHuy));
            this.radgDSBienLai = new Telerik.WinControls.UI.RadGridView();
            this.bindLyDo = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.radbtnDelete = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radgDSBienLai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgDSBienLai.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindLyDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // radgDSBienLai
            // 
            this.radgDSBienLai.AutoSizeRows = true;
            this.radgDSBienLai.Dock = System.Windows.Forms.DockStyle.Top;
            this.radgDSBienLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.radgDSBienLai.Location = new System.Drawing.Point(0, 0);
            // 
            // radgDSBienLai
            // 
            this.radgDSBienLai.MasterTemplate.AllowAddNewRow = false;
            this.radgDSBienLai.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "LyDoHuy";
            gridViewTextBoxColumn1.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn1.HeaderText = "Lý do hủy";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "LyDoHuy";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 504;
            gridViewDecimalColumn1.DataType = typeof(long);
            gridViewDecimalColumn1.FieldName = "IDHuy";
            gridViewDecimalColumn1.HeaderText = "IDHuy";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "IDHuy";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.Width = 42;
            this.radgDSBienLai.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDecimalColumn1});
            this.radgDSBienLai.MasterTemplate.DataSource = this.bindLyDo;
            this.radgDSBienLai.MasterTemplate.EnableGrouping = false;
            this.radgDSBienLai.MasterTemplate.ShowGroupedColumns = true;
            this.radgDSBienLai.Name = "radgDSBienLai";
            this.radgDSBienLai.Size = new System.Drawing.Size(524, 218);
            this.radgDSBienLai.TabIndex = 7;
            this.radgDSBienLai.Text = "radGridView1";
            this.radgDSBienLai.ThemeName = "Office2010Blue";
            this.radgDSBienLai.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.radgDSBienLai_CellFormatting);
            this.radgDSBienLai.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radgDSBienLai_CellDoubleClick);
            this.radgDSBienLai.Click += new System.EventHandler(this.radgDSBienLai_Click);
            // 
            // bindLyDo
            // 
            this.bindLyDo.DataSource = typeof(ModuleHanhChinh.LIB.LyDoHuy_Coll);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnSave.Image = global::ModuleHanhChinh.Properties.Resources.Ok_icon32;
            this.btnSave.Location = new System.Drawing.Point(399, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 34);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Xác nhận";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(264, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 34);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // radbtnDelete
            // 
            this.radbtnDelete.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.radbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("radbtnDelete.Image")));
            this.radbtnDelete.Location = new System.Drawing.Point(129, 230);
            this.radbtnDelete.Name = "radbtnDelete";
            this.radbtnDelete.Size = new System.Drawing.Size(118, 34);
            this.radbtnDelete.TabIndex = 10;
            this.radbtnDelete.Text = "Xoá lý do ";
            this.radbtnDelete.Click += new System.EventHandler(this.radbtnDelete_Click);
            // 
            // FormLyDoHuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 276);
            this.Controls.Add(this.radbtnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.radgDSBienLai);
            this.Name = "FormLyDoHuy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lý Do Hủy";
            //this.Load += new System.EventHandler(this.FormLyDoHuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radgDSBienLai.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgDSBienLai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindLyDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radgDSBienLai;
        private Telerik.WinControls.UI.RadButton btnSave;
        private System.Windows.Forms.BindingSource bindLyDo;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadButton radbtnDelete;

    }
}