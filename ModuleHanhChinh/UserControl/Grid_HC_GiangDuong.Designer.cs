﻿namespace ModuleHanhChinh.UserControl
{
    partial class Grid_HC_GiangDuong
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radGridView = new Telerik.WinControls.UI.RadGridView();
            this.radbindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.radGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.FormatString = "";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.Width = 39;
            gridViewTextBoxColumn1.FieldName = "MaPhong";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Mã";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "MaPhong";
            gridViewTextBoxColumn1.Width = 49;
            gridViewTextBoxColumn2.FieldName = "TenPhong";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Phòng";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "TenPhong";
            gridViewTextBoxColumn2.Width = 220;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<long>);
            gridViewDecimalColumn2.FieldName = "IdNguoiQuanLy";
            gridViewDecimalColumn2.FormatString = "";
            gridViewDecimalColumn2.HeaderText = "IdNguoiQuanLy";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "IdNguoiQuanLy";
            gridViewDecimalColumn2.Width = 44;
            gridViewTextBoxColumn3.FieldName = "TrangThai";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Trạng thái";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "TrangThai";
            gridViewTextBoxColumn3.Width = 220;
            gridViewTextBoxColumn4.FieldName = "NoiDung";
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "Sức chứa";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "NoiDung";
            gridViewTextBoxColumn4.Width = 220;
            gridViewTextBoxColumn5.FieldName = "DiaDiem";
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "Địa điểm";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "DiaDiem";
            gridViewTextBoxColumn5.Width = 220;
            gridViewTextBoxColumn6.FieldName = "ThietBiDiKem";
            gridViewTextBoxColumn6.FormatString = "";
            gridViewTextBoxColumn6.HeaderText = "Thiết bị đi kèm";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "ThietBiDiKem";
            gridViewTextBoxColumn6.Width = 243;
            gridViewTextBoxColumn7.FieldName = "GhiChu";
            gridViewTextBoxColumn7.FormatString = "";
            gridViewTextBoxColumn7.HeaderText = "GhiChu";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "GhiChu";
            gridViewTextBoxColumn7.Width = 59;
            this.radGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.radGridView.MasterTemplate.DataSource = this.radbindingSource;
            this.radGridView.MasterTemplate.EnableFiltering = true;
            this.radGridView.Name = "radGridView";
            this.radGridView.ReadOnly = true;
            this.radGridView.Size = new System.Drawing.Size(1140, 258);
            this.radGridView.TabIndex = 1;
            this.radGridView.Text = "radGridView1";
            // 
            // radbindingSource
            // 
            this.radbindingSource.DataSource = typeof(ModuleHanhChinh.LIB.HC_GiangDuong_Phong_Coll);
            // 
            // Grid_HC_GiangDuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView);
            this.Name = "Grid_HC_GiangDuong";
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
