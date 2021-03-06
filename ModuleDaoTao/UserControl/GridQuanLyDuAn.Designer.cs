namespace ModuleDaoTao.UserControls
{
    partial class GridQuanLyDuAn
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
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            this.radGridView = new Telerik.WinControls.UI.RadGridView();
            this.bindingSourceDuAn = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDuAn)).BeginInit();
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
            gridViewDecimalColumn1.FieldName = "Id";
            gridViewDecimalColumn1.FormatString = "";
            gridViewDecimalColumn1.HeaderText = "Id";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "Id";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.Width = 132;
            gridViewTextBoxColumn1.FieldName = "TenDuAn";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Tên dự án";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "TenDuAn";
            gridViewTextBoxColumn1.Width = 155;
            gridViewDateTimeColumn1.DataType = typeof(Csla.SmartDate);
            gridViewDateTimeColumn1.FieldName = "NgayBatDau";
            gridViewDateTimeColumn1.FormatString = "";
            gridViewDateTimeColumn1.HeaderText = "Ngày bắt đầu";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "NgayBatDau";
            gridViewDateTimeColumn1.Width = 157;
            gridViewDateTimeColumn2.DataType = typeof(Csla.SmartDate);
            gridViewDateTimeColumn2.FieldName = "NgayKetThuc";
            gridViewDateTimeColumn2.FormatString = "";
            gridViewDateTimeColumn2.HeaderText = "Ngày kết thúc";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "NgayKetThuc";
            gridViewDateTimeColumn2.Width = 161;
            gridViewTextBoxColumn2.FieldName = "NguonKinhPhi";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Nguồn kinh phí";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "NguonKinhPhi";
            gridViewTextBoxColumn2.Width = 178;
            gridViewTextBoxColumn3.FieldName = "TongKinhPhi";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Tổng kinh phí";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "TongKinhPhi";
            gridViewTextBoxColumn3.Width = 159;
            gridViewDecimalColumn2.DataType = typeof(string);
            gridViewDecimalColumn2.FieldName = "NguoiThucHien";
            gridViewDecimalColumn2.FormatString = "";
            gridViewDecimalColumn2.HeaderText = "Người thực hiện";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "NguoiThucHien";
            gridViewDecimalColumn2.Width = 183;
            this.radGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewDecimalColumn2});
            this.radGridView.MasterTemplate.DataSource = this.bindingSourceDuAn;
            this.radGridView.MasterTemplate.EnableFiltering = true;
            this.radGridView.Name = "radGridView";
            this.radGridView.ReadOnly = true;
            this.radGridView.Size = new System.Drawing.Size(1140, 258);
            this.radGridView.TabIndex = 1;
            this.radGridView.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.radGridView_CellFormatting);
            this.radGridView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView_CellDoubleClick);
            // 
            // bindingSourceDuAn
            // 
            this.bindingSourceDuAn.DataSource = typeof(ModuleDaoTao.LIB.DT_DuAn_Coll);
            // 
            // GridQuanLyDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView);
            this.Name = "GridQuanLyDuAn";
            this.Controls.SetChildIndex(this.radGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDuAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView;
        private System.Windows.Forms.BindingSource bindingSourceDuAn;
    }
}
