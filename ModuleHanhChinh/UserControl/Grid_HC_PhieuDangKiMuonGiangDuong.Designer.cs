namespace ModuleHanhChinh.UserControl
{
    partial class Grid_HC_PhieuDangKiMuonGiangDuong
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn3 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
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
            this.radGridView.MasterTemplate.AllowDeleteRow = false;
            this.radGridView.MasterTemplate.AllowDragToGroup = false;
            this.radGridView.MasterTemplate.AllowEditRow = false;
            this.radGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.FormatString = "";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.Width = 17;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn2.FieldName = "IdPhong";
            gridViewDecimalColumn2.FormatString = "";
            gridViewDecimalColumn2.HeaderText = "IdPhong";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "IdPhong";
            gridViewDecimalColumn2.Width = 16;
            gridViewTextBoxColumn1.FieldName = "TenPhong";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Phòng";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "TenPhong";
            gridViewTextBoxColumn1.Width = 180;
            gridViewTextBoxColumn2.FieldName = "MaPhong";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "MaPhong";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "MaPhong";
            gridViewTextBoxColumn2.Width = 16;
            gridViewTextBoxColumn3.FieldName = "NoiDungSuDung";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Nội dung";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "NoiDungSuDung";
            gridViewTextBoxColumn3.Width = 180;
            gridViewTextBoxColumn4.FieldName = "ChuTri";
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "ChuTri";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "ChuTri";
            gridViewTextBoxColumn4.Width = 16;
            gridViewTextBoxColumn5.DataType = typeof(Csla.SmartDate);
            gridViewTextBoxColumn5.FieldName = "GioBatDau";
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "GioBatDau";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "GioBatDau";
            gridViewTextBoxColumn5.Width = 16;
            gridViewTextBoxColumn6.DataType = typeof(Csla.SmartDate);
            gridViewTextBoxColumn6.FieldName = "GioKetThuc";
            gridViewTextBoxColumn6.FormatString = "";
            gridViewTextBoxColumn6.HeaderText = "GioKetThuc";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "GioKetThuc";
            gridViewTextBoxColumn6.Width = 16;
            gridViewDecimalColumn3.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn3.FieldName = "SoNguoiThamGia";
            gridViewDecimalColumn3.FormatString = "";
            gridViewDecimalColumn3.HeaderText = "Số người";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "SoNguoiThamGia";
            gridViewDecimalColumn3.Width = 175;
            gridViewTextBoxColumn7.FieldName = "NgayGuiPhieu";
            gridViewTextBoxColumn7.FormatString = "";
            gridViewTextBoxColumn7.HeaderText = "Lập yêu cầu ngày";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "NgayGuiPhieu";
            gridViewTextBoxColumn7.Width = 148;
            gridViewTextBoxColumn8.FieldName = "NgayBatDau";
            gridViewTextBoxColumn8.FormatString = "";
            gridViewTextBoxColumn8.HeaderText = "Bắt đầu ngày";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "NgayBatDau";
            gridViewTextBoxColumn8.Width = 148;
            gridViewTextBoxColumn9.FieldName = "NgayKetThuc";
            gridViewTextBoxColumn9.FormatString = "";
            gridViewTextBoxColumn9.HeaderText = "Kết thúc ngày";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.IsVisible = false;
            gridViewTextBoxColumn9.Name = "NgayKetThuc";
            gridViewTextBoxColumn9.Width = 250;
            gridViewDateTimeColumn1.FieldName = "DateNgayGuiPhieu";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn1.FormatString = "{0:d}";
            gridViewDateTimeColumn1.HeaderText = "Lập yêu cầu ngày";
            gridViewDateTimeColumn1.Name = "DateNgayGuiPhieu";
            gridViewDateTimeColumn1.Width = 228;
            gridViewDateTimeColumn2.FieldName = "DateNgayBatDau";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn2.FormatString = "{0:d}";
            gridViewDateTimeColumn2.HeaderText = "Bắt đầu ngày";
            gridViewDateTimeColumn2.Name = "DateNgayBatDau";
            gridViewDateTimeColumn2.Width = 177;
            gridViewDateTimeColumn3.FieldName = "DateNgayKetThuc";
            gridViewDateTimeColumn3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn3.FormatString = "{0:d}";
            gridViewDateTimeColumn3.HeaderText = "Kết thúc ngày";
            gridViewDateTimeColumn3.Name = "DateNgayKetThuc";
            gridViewDateTimeColumn3.Width = 184;
            this.radGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewDecimalColumn3,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2,
            gridViewDateTimeColumn3});
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
            this.radbindingSource.DataSource = typeof(ModuleHanhChinh.LIB.HC_GiangDuong_PhieuDangKi_Coll);
            // 
            // Grid_HC_PhieuDangKiMuonGiangDuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView);
            this.Name = "Grid_HC_PhieuDangKiMuonGiangDuong";
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
