namespace DanhMuc.UserControl
{
    partial class QuocGia
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
            this.radgQuocGia = new Telerik.WinControls.UI.RadGridView();
            this.bindQuocGia = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radgQuocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgQuocGia.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindQuocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // radgQuocGia
            // 
            this.radgQuocGia.BackColor = System.Drawing.SystemColors.Control;
            this.radgQuocGia.Cursor = System.Windows.Forms.Cursors.Default;
            this.radgQuocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radgQuocGia.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.radgQuocGia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radgQuocGia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radgQuocGia.Location = new System.Drawing.Point(0, 28);
            // 
            // radgQuocGia
            // 
            this.radgQuocGia.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "TenQuocGia";
            gridViewTextBoxColumn1.HeaderText = "Tên Quốc Gia";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.MaxLength = 50;
            gridViewTextBoxColumn1.Name = "TenQuocGia";
            gridViewTextBoxColumn1.Width = 255;
            gridViewCheckBoxColumn1.DataType = typeof(System.Nullable<bool>);
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "SuDung";
            gridViewCheckBoxColumn1.HeaderText = "Sử Dụng";
            gridViewCheckBoxColumn1.IsAutoGenerated = true;
            gridViewCheckBoxColumn1.MaxWidth = 90;
            gridViewCheckBoxColumn1.MinWidth = 90;
            gridViewCheckBoxColumn1.Name = "SuDung";
            gridViewCheckBoxColumn1.Width = 90;
            this.radgQuocGia.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewCheckBoxColumn1});
            this.radgQuocGia.MasterTemplate.DataSource = this.bindQuocGia;
            this.radgQuocGia.MasterTemplate.EnableFiltering = true;
            this.radgQuocGia.Name = "radgQuocGia";
            this.radgQuocGia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radgQuocGia.Size = new System.Drawing.Size(365, 291);
            this.radgQuocGia.TabIndex = 1;
            this.radgQuocGia.Text = "radGridView1";
            this.radgQuocGia.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.CellFormatting);
            this.radgQuocGia.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.CellValueChanged);
            this.radgQuocGia.CursorChanged += new System.EventHandler(this.CursorChanged);
            // 
            // bindQuocGia
            // 
            this.bindQuocGia.DataSource = typeof(DanhMuc.LIB.DIC_QuocGia_Coll);
            // 
            // QuocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radgQuocGia);
            this.Name = "QuocGia";
            this.Controls.SetChildIndex(this.radgQuocGia, 0);
            ((System.ComponentModel.ISupportInitialize)(this.radgQuocGia.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgQuocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindQuocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radgQuocGia;
        private System.Windows.Forms.BindingSource bindQuocGia;
    }
}
