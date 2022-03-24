namespace DanhMuc.UI
{
    partial class DM_TrangThai_TrangThietBi
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
            this.btnClose = new Telerik.WinControls.UI.RadButton();
            this.txtGhiChu = new Telerik.WinControls.UI.RadTextBox();
            this.bindThongTin = new System.Windows.Forms.BindingSource(this.components);
            this.txtTrangThai = new Telerik.WinControls.UI.RadTextBox();
            this.radbtnAddNew = new Telerik.WinControls.UI.RadButton();
            this.radbtnSave = new Telerik.WinControls.UI.RadButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGirdTrangThaiList = new Telerik.WinControls.UI.RadGridView();
            this.bindtrangThaiList = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindThongTin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrangThai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnAddNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGirdTrangThaiList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGirdTrangThaiList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindtrangThaiList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnClose);
            this.radGroupBox1.Controls.Add(this.txtGhiChu);
            this.radGroupBox1.Controls.Add(this.txtTrangThai);
            this.radGroupBox1.Controls.Add(this.radbtnAddNew);
            this.radGroupBox1.Controls.Add(this.radbtnSave);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "Thông tin";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(1376, 74);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Thông tin";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1231, 30);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 24);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Thoát";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindThongTin, "GhiChu", true));
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(563, 29);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(361, 23);
            this.txtGhiChu.TabIndex = 11;
            // 
            // bindThongTin
            // 
            this.bindThongTin.DataSource = typeof(DanhMuc.LIB.DIC_TrangThaiTrangThietBi);
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindThongTin, "TenTrangThai", true));
            this.txtTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThai.Location = new System.Drawing.Point(110, 31);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(361, 23);
            this.txtTrangThai.TabIndex = 10;
            // 
            // radbtnAddNew
            // 
            this.radbtnAddNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnAddNew.Location = new System.Drawing.Point(961, 28);
            this.radbtnAddNew.Name = "radbtnAddNew";
            this.radbtnAddNew.Size = new System.Drawing.Size(110, 24);
            this.radbtnAddNew.TabIndex = 9;
            this.radbtnAddNew.Text = "Thêm mới";
            this.radbtnAddNew.Click += new System.EventHandler(this.radbtnAddNew_Click);
            // 
            // radbtnSave
            // 
            this.radbtnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnSave.Location = new System.Drawing.Point(1099, 28);
            this.radbtnSave.Name = "radbtnSave";
            this.radbtnSave.Size = new System.Drawing.Size(110, 24);
            this.radbtnSave.TabIndex = 8;
            this.radbtnSave.Text = "Lưu";
            this.radbtnSave.Click += new System.EventHandler(this.radbtnSave_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(505, 31);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(52, 21);
            this.radLabel3.TabIndex = 7;
            this.radLabel3.Text = "Ghi chú";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(12, 32);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(89, 21);
            this.radLabel4.TabIndex = 6;
            this.radLabel4.Text = "Tên trạng thái";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.radGirdTrangThaiList);
            this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox2.HeaderText = "Danh sách trạng thái";
            this.radGroupBox2.Location = new System.Drawing.Point(0, 74);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(1376, 688);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.Text = "Danh sách trạng thái";
            // 
            // radGirdTrangThaiList
            // 
            this.radGirdTrangThaiList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGirdTrangThaiList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGirdTrangThaiList.Location = new System.Drawing.Point(2, 18);
            // 
            // radGirdTrangThaiList
            // 
            this.radGirdTrangThaiList.MasterTemplate.AllowAddNewRow = false;
            this.radGirdTrangThaiList.MasterTemplate.AllowDragToGroup = false;
            this.radGirdTrangThaiList.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
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
            gridViewTextBoxColumn1.MaxWidth = 1000;
            gridViewTextBoxColumn1.MinWidth = 400;
            gridViewTextBoxColumn1.Name = "TenTrangThai";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 676;
            gridViewTextBoxColumn2.FieldName = "GhiChu";
            gridViewTextBoxColumn2.HeaderText = "Ghi chú";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.MaxWidth = 1000;
            gridViewTextBoxColumn2.MinWidth = 400;
            gridViewTextBoxColumn2.Name = "GhiChu";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 677;
            this.radGirdTrangThaiList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.radGirdTrangThaiList.MasterTemplate.DataSource = this.bindtrangThaiList;
            this.radGirdTrangThaiList.Name = "radGirdTrangThaiList";
            this.radGirdTrangThaiList.ReadOnly = true;
            this.radGirdTrangThaiList.Size = new System.Drawing.Size(1372, 668);
            this.radGirdTrangThaiList.TabIndex = 0;
            this.radGirdTrangThaiList.Text = "radGridView1";
            this.radGirdTrangThaiList.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGirdTrangThaiList_CellClick);
            // 
            // bindtrangThaiList
            // 
            this.bindtrangThaiList.DataSource = typeof(DanhMuc.LIB.DIC_TrangThaiTrangThietBi_Coll);
            // 
            // DM_TrangThai_TrangThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 762);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DM_TrangThai_TrangThietBi";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trạng thái trang thiết bị";
            this.ThemeName = "ControlDefault";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DM_TrangThai_TrangThietBi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindThongTin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrangThai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnAddNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbtnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGirdTrangThaiList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGirdTrangThaiList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindtrangThaiList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadTextBox txtGhiChu;
        private Telerik.WinControls.UI.RadTextBox txtTrangThai;
        private Telerik.WinControls.UI.RadButton radbtnAddNew;
        private Telerik.WinControls.UI.RadButton radbtnSave;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private System.Windows.Forms.BindingSource bindThongTin;
        private Telerik.WinControls.UI.RadGridView radGirdTrangThaiList;
        private System.Windows.Forms.BindingSource bindtrangThaiList;
        private Telerik.WinControls.UI.RadButton btnClose;

    }
}
