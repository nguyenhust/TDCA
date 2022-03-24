namespace ModuleDaoTao.UserControls
{
    partial class GridChinhQuyLopHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridChinhQuyLopHoc));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            this.radBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radBindingSource
            // 
            this.radBindingSource.DataSource = typeof(ModuleDaoTao.LIB.DT_ChinhQuy_LopHoc_Coll);
            // 
            // radGridView1
            // 
            resources.ApplyResources(this.radGridView1, "radGridView1");
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "ID";
            resources.ApplyResources(gridViewDecimalColumn1, "gridViewDecimalColumn1");
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.Width = 48;
            gridViewTextBoxColumn1.FieldName = "MaLop";
            resources.ApplyResources(gridViewTextBoxColumn1, "gridViewTextBoxColumn1");
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "MaLop";
            gridViewTextBoxColumn1.Width = 159;
            gridViewTextBoxColumn2.FieldName = "TenLop";
            resources.ApplyResources(gridViewTextBoxColumn2, "gridViewTextBoxColumn2");
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "TenLop";
            gridViewTextBoxColumn2.Width = 159;
            gridViewTextBoxColumn3.FieldName = "Khoa";
            resources.ApplyResources(gridViewTextBoxColumn3, "gridViewTextBoxColumn3");
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Khoa";
            gridViewTextBoxColumn3.Width = 159;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn2.FieldName = "IdChuyenNganh";
            resources.ApplyResources(gridViewDecimalColumn2, "gridViewDecimalColumn2");
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "IdChuyenNganh";
            gridViewDecimalColumn2.Width = 48;
            gridViewTextBoxColumn4.FieldName = "NamHoc";
            resources.ApplyResources(gridViewTextBoxColumn4, "gridViewTextBoxColumn4");
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "NamHoc";
            gridViewTextBoxColumn4.Width = 159;
            gridViewDecimalColumn3.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn3.FieldName = "IdChuyenKhoa";
            resources.ApplyResources(gridViewDecimalColumn3, "gridViewDecimalColumn3");
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.IsVisible = false;
            gridViewDecimalColumn3.Name = "IdChuyenKhoa";
            gridViewDecimalColumn3.Width = 48;
            gridViewDecimalColumn4.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn4.FieldName = "IdKhungLopHoc";
            resources.ApplyResources(gridViewDecimalColumn4, "gridViewDecimalColumn4");
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.IsVisible = false;
            gridViewDecimalColumn4.Name = "IdKhungLopHoc";
            gridViewDecimalColumn4.Width = 48;
            gridViewTextBoxColumn5.FieldName = "ThoiGianBatDau";
            resources.ApplyResources(gridViewTextBoxColumn5, "gridViewTextBoxColumn5");
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "ThoiGianBatDau";
            gridViewTextBoxColumn5.Width = 48;
            gridViewTextBoxColumn6.FieldName = "ThoiGianKetThuc";
            resources.ApplyResources(gridViewTextBoxColumn6, "gridViewTextBoxColumn6");
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "ThoiGianKetThuc";
            gridViewTextBoxColumn6.Width = 48;
            gridViewDecimalColumn5.DataType = typeof(System.Nullable<long>);
            gridViewDecimalColumn5.FieldName = "LastEdited_User";
            resources.ApplyResources(gridViewDecimalColumn5, "gridViewDecimalColumn5");
            gridViewDecimalColumn5.IsAutoGenerated = true;
            gridViewDecimalColumn5.IsVisible = false;
            gridViewDecimalColumn5.Name = "LastEdited_User";
            gridViewDecimalColumn5.Width = 48;
            gridViewTextBoxColumn7.FieldName = "LastEdited_Date";
            resources.ApplyResources(gridViewTextBoxColumn7, "gridViewTextBoxColumn7");
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "LastEdited_Date";
            gridViewTextBoxColumn7.Width = 48;
            gridViewTextBoxColumn8.FieldName = "Backup01";
            resources.ApplyResources(gridViewTextBoxColumn8, "gridViewTextBoxColumn8");
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "Backup01";
            gridViewTextBoxColumn8.Width = 48;
            gridViewTextBoxColumn9.FieldName = "Backup02";
            resources.ApplyResources(gridViewTextBoxColumn9, "gridViewTextBoxColumn9");
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.IsVisible = false;
            gridViewTextBoxColumn9.Name = "Backup02";
            gridViewTextBoxColumn9.Width = 48;
            gridViewTextBoxColumn10.FieldName = "Backup03";
            resources.ApplyResources(gridViewTextBoxColumn10, "gridViewTextBoxColumn10");
            gridViewTextBoxColumn10.IsAutoGenerated = true;
            gridViewTextBoxColumn10.IsVisible = false;
            gridViewTextBoxColumn10.Name = "Backup03";
            gridViewTextBoxColumn10.Width = 48;
            gridViewTextBoxColumn11.FieldName = "Backup04";
            resources.ApplyResources(gridViewTextBoxColumn11, "gridViewTextBoxColumn11");
            gridViewTextBoxColumn11.IsAutoGenerated = true;
            gridViewTextBoxColumn11.IsVisible = false;
            gridViewTextBoxColumn11.Name = "Backup04";
            gridViewTextBoxColumn11.Width = 48;
            gridViewDecimalColumn6.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn6.FieldName = "Backup05";
            resources.ApplyResources(gridViewDecimalColumn6, "gridViewDecimalColumn6");
            gridViewDecimalColumn6.IsAutoGenerated = true;
            gridViewDecimalColumn6.IsVisible = false;
            gridViewDecimalColumn6.Name = "Backup05";
            gridViewDecimalColumn6.Width = 48;
            gridViewDecimalColumn7.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn7.FieldName = "Backup06";
            resources.ApplyResources(gridViewDecimalColumn7, "gridViewDecimalColumn7");
            gridViewDecimalColumn7.IsAutoGenerated = true;
            gridViewDecimalColumn7.IsVisible = false;
            gridViewDecimalColumn7.Name = "Backup06";
            gridViewDecimalColumn7.Width = 48;
            gridViewTextBoxColumn12.FieldName = "Backup07";
            resources.ApplyResources(gridViewTextBoxColumn12, "gridViewTextBoxColumn12");
            gridViewTextBoxColumn12.IsAutoGenerated = true;
            gridViewTextBoxColumn12.IsVisible = false;
            gridViewTextBoxColumn12.Name = "Backup07";
            gridViewTextBoxColumn12.Width = 48;
            gridViewTextBoxColumn13.FieldName = "Backup08";
            resources.ApplyResources(gridViewTextBoxColumn13, "gridViewTextBoxColumn13");
            gridViewTextBoxColumn13.IsAutoGenerated = true;
            gridViewTextBoxColumn13.IsVisible = false;
            gridViewTextBoxColumn13.Name = "Backup08";
            gridViewTextBoxColumn13.Width = 48;
            gridViewTextBoxColumn14.FieldName = "TenChuyenKhoa";
            resources.ApplyResources(gridViewTextBoxColumn14, "gridViewTextBoxColumn14");
            gridViewTextBoxColumn14.IsAutoGenerated = true;
            gridViewTextBoxColumn14.Name = "TenChuyenKhoa";
            gridViewTextBoxColumn14.Width = 159;
            gridViewTextBoxColumn15.FieldName = "TenChuyenNganh";
            resources.ApplyResources(gridViewTextBoxColumn15, "gridViewTextBoxColumn15");
            gridViewTextBoxColumn15.IsAutoGenerated = true;
            gridViewTextBoxColumn15.IsVisible = false;
            gridViewTextBoxColumn15.Name = "TenChuyenNganh";
            gridViewTextBoxColumn15.Width = 48;
            gridViewDateTimeColumn1.FieldName = "DateThoiGianBatDau";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(gridViewDateTimeColumn1, "gridViewDateTimeColumn1");
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "DateThoiGianBatDau";
            gridViewDateTimeColumn1.ReadOnly = true;
            gridViewDateTimeColumn1.Width = 162;
            gridViewDateTimeColumn2.FieldName = "DateThoiGianKetThuc";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(gridViewDateTimeColumn2, "gridViewDateTimeColumn2");
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "DateThoiGianKetThuc";
            gridViewDateTimeColumn2.ReadOnly = true;
            gridViewDateTimeColumn2.Width = 168;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewDecimalColumn5,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewDecimalColumn6,
            gridViewDecimalColumn7,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14,
            gridViewTextBoxColumn15,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2});
            this.radGridView1.MasterTemplate.DataSource = this.radBindingSource;
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            // 
            // GridChinhQuyLopHoc
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "GridChinhQuyLopHoc";
            this.Controls.SetChildIndex(this.radGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.radBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource radBindingSource;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}
