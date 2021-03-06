namespace DanhMuc.UserControl
{
    partial class GioiTinh
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radgGioiTinh = new Telerik.WinControls.UI.RadGridView();
            this.bindGioiTinh = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radgGioiTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgGioiTinh.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindGioiTinh)).BeginInit();
            this.SuspendLayout();
            // 
            // radgGioiTinh
            // 
            this.radgGioiTinh.BackColor = System.Drawing.SystemColors.Control;
            this.radgGioiTinh.Cursor = System.Windows.Forms.Cursors.Default;
            this.radgGioiTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radgGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.radgGioiTinh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radgGioiTinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radgGioiTinh.Location = new System.Drawing.Point(0, 28);
            // 
            // radgGioiTinh
            // 
            this.radgGioiTinh.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
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
            gridViewTextBoxColumn1.HeaderText = "Tên";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.MaxLength = 10;
            gridViewTextBoxColumn1.MaxWidth = 200;
            gridViewTextBoxColumn1.MinWidth = 200;
            gridViewTextBoxColumn1.Name = "Ten";
            gridViewTextBoxColumn1.Width = 200;
            gridViewCheckBoxColumn1.DataType = typeof(System.Nullable<bool>);
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "SuDung";
            gridViewCheckBoxColumn1.HeaderText = "Sử Dụng";
            gridViewCheckBoxColumn1.IsAutoGenerated = true;
            gridViewCheckBoxColumn1.MaxWidth = 90;
            gridViewCheckBoxColumn1.MinWidth = 90;
            gridViewCheckBoxColumn1.Name = "SuDung";
            gridViewCheckBoxColumn1.Width = 90;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "GhiChu";
            gridViewTextBoxColumn2.HeaderText = "Ghi Chú";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.MaxLength = 100;
            gridViewTextBoxColumn2.Name = "GhiChu";
            gridViewTextBoxColumn2.Width = 56;
            this.radgGioiTinh.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn2});
            this.radgGioiTinh.MasterTemplate.DataSource = this.bindGioiTinh;
            this.radgGioiTinh.MasterTemplate.EnableFiltering = true;
            this.radgGioiTinh.Name = "radgGioiTinh";
            this.radgGioiTinh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radgGioiTinh.Size = new System.Drawing.Size(365, 291);
            this.radgGioiTinh.TabIndex = 1;
            this.radgGioiTinh.Text = "radGridView1";
            this.radgGioiTinh.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.CellFormatting);
            this.radgGioiTinh.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.CellValueChanged);
            this.radgGioiTinh.CursorChanged += new System.EventHandler(this.CursorChanged);
            // 
            // bindGioiTinh
            // 
            this.bindGioiTinh.DataSource = typeof(DanhMuc.LIB.DIC_GioiTinh_Coll);
            // 
            // GioiTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radgGioiTinh);
            this.Name = "GioiTinh";
            this.Controls.SetChildIndex(this.radgGioiTinh, 0);
            ((System.ComponentModel.ISupportInitialize)(this.radgGioiTinh.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgGioiTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindGioiTinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radgGioiTinh;
        private System.Windows.Forms.BindingSource bindGioiTinh;
    }
}
