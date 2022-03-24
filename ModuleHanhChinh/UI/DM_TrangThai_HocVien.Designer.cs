namespace ModuleHanhChinh.UI
{
    partial class DM_TrangThai_HocVien
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radbtnAddNew = new Telerik.WinControls.UI.RadButton();
            this.radbtnSave = new Telerik.WinControls.UI.RadButton();
            this.radtxtGhiChu = new Telerik.WinControls.UI.RadTextBox();
            this.bindTrangThaiHocVien = new System.Windows.Forms.BindingSource(this.components);
            this.radtxtTrangThai = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGridDSTrangThai = new Telerik.WinControls.UI.RadGridView();
            this.bindTrangThaiHocVienList = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnAddNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radtxtGhiChu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindTrangThaiHocVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radtxtTrangThai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridDSTrangThai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridDSTrangThai.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindTrangThaiHocVienList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radbtnAddNew);
            this.radGroupBox1.Controls.Add(this.radbtnSave);
            this.radGroupBox1.Controls.Add(this.radtxtGhiChu);
            this.radGroupBox1.Controls.Add(this.radtxtTrangThai);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "Thông tin";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(967, 68);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Thông tin";
            // 
            // radbtnAddNew
            // 
            this.radbtnAddNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnAddNew.Location = new System.Drawing.Point(670, 30);
            this.radbtnAddNew.Name = "radbtnAddNew";
            this.radbtnAddNew.Size = new System.Drawing.Size(110, 24);
            this.radbtnAddNew.TabIndex = 5;
            this.radbtnAddNew.Text = "Thêm mới";
            this.radbtnAddNew.Click += new System.EventHandler(this.radbtnAddNew_Click);
            // 
            // radbtnSave
            // 
            this.radbtnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnSave.Location = new System.Drawing.Point(808, 30);
            this.radbtnSave.Name = "radbtnSave";
            this.radbtnSave.Size = new System.Drawing.Size(110, 24);
            this.radbtnSave.TabIndex = 4;
            this.radbtnSave.Text = "Lưu";
            this.radbtnSave.Click += new System.EventHandler(this.radbtnSave_Click);
            // 
            // radtxtGhiChu
            // 
            this.radtxtGhiChu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindTrangThaiHocVien, "GhiChu", true));
            this.radtxtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radtxtGhiChu.Location = new System.Drawing.Point(410, 28);
            this.radtxtGhiChu.Name = "radtxtGhiChu";
            this.radtxtGhiChu.Size = new System.Drawing.Size(226, 23);
            this.radtxtGhiChu.TabIndex = 3;
            // 
            // bindTrangThaiHocVien
            // 
            this.bindTrangThaiHocVien.DataSource = typeof(ModuleHanhChinh.LIB.TrangThaiCuaHocVien);
            // 
            // radtxtTrangThai
            // 
            this.radtxtTrangThai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindTrangThaiHocVien, "TenTrangThai", true));
            this.radtxtTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radtxtTrangThai.Location = new System.Drawing.Point(140, 26);
            this.radtxtTrangThai.Name = "radtxtTrangThai";
            this.radtxtTrangThai.Size = new System.Drawing.Size(202, 23);
            this.radtxtTrangThai.TabIndex = 2;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(351, 29);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(52, 21);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Ghi chú";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(34, 29);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(89, 21);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Tên trạng thái";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.radGridDSTrangThai);
            this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox2.HeaderText = "Danh sách trạng thái";
            this.radGroupBox2.Location = new System.Drawing.Point(0, 68);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(967, 432);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.Text = "Danh sách trạng thái";
            // 
            // radGridDSTrangThai
            // 
            this.radGridDSTrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridDSTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGridDSTrangThai.Location = new System.Drawing.Point(2, 18);
            // 
            // radGridDSTrangThai
            // 
            this.radGridDSTrangThai.MasterTemplate.AllowAddNewRow = false;
            gridViewDecimalColumn1.DataType = typeof(long);
            gridViewDecimalColumn1.FieldName = "IDTrangThai";
            gridViewDecimalColumn1.HeaderText = "IDTrangThai";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "IDTrangThai";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.FieldName = "TenTrangThai";
            gridViewTextBoxColumn1.HeaderText = "Tên trạng thái";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.MaxWidth = 600;
            gridViewTextBoxColumn1.MinWidth = 400;
            gridViewTextBoxColumn1.Name = "TenTrangThai";
            gridViewTextBoxColumn1.Width = 500;
            gridViewTextBoxColumn2.FieldName = "GhiChu";
            gridViewTextBoxColumn2.HeaderText = "Ghi chú";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.MaxWidth = 600;
            gridViewTextBoxColumn2.MinWidth = 400;
            gridViewTextBoxColumn2.Name = "GhiChu";
            gridViewTextBoxColumn2.Width = 500;
            this.radGridDSTrangThai.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.radGridDSTrangThai.MasterTemplate.DataSource = this.bindTrangThaiHocVienList;
            this.radGridDSTrangThai.Name = "radGridDSTrangThai";
            this.radGridDSTrangThai.ReadOnly = true;
            this.radGridDSTrangThai.Size = new System.Drawing.Size(963, 412);
            this.radGridDSTrangThai.TabIndex = 0;
            this.radGridDSTrangThai.Text = "radGridView1";
            this.radGridDSTrangThai.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridDSTrangThai_CellClick);
            // 
            // bindTrangThaiHocVienList
            // 
            this.bindTrangThaiHocVienList.DataSource = typeof(ModuleHanhChinh.LIB.TrangThaiCuaHocVien_Coll);
            // 
            // DM_TrangThai_HocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 500);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DM_TrangThai_HocVien";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục trạng thái của học viên";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.DM_TrangThai_HocVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnAddNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radtxtGhiChu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindTrangThaiHocVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radtxtTrangThai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridDSTrangThai.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridDSTrangThai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindTrangThaiHocVienList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton radbtnAddNew;
        private Telerik.WinControls.UI.RadButton radbtnSave;
        private Telerik.WinControls.UI.RadTextBox radtxtGhiChu;
        private Telerik.WinControls.UI.RadTextBox radtxtTrangThai;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGridView radGridDSTrangThai;
        private System.Windows.Forms.BindingSource bindTrangThaiHocVien;
        private System.Windows.Forms.BindingSource bindTrangThaiHocVienList;
    }
}
