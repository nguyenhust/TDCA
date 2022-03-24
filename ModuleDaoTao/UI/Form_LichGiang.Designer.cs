namespace WindowsFormsApplication3
{
    partial class Form2
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.calChonNhieuNgay = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.dateDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.dateTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoTietTH = new DevExpress.XtraEditors.TextEdit();
            this.txtSoTietLT = new DevExpress.XtraEditors.TextEdit();
            this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.bindLichGiang = new System.Windows.Forms.BindingSource(this.components);
            this.bindLichGiangCTList = new System.Windows.Forms.BindingSource(this.components);
            this.colIDLichGiangCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDLichGiang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayGiang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuoiGiang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoiDungGiang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiDaoTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDGiangVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDNguoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calChonNhieuNgay.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTietTH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTietLT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindLichGiang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindLichGiangCTList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindLichGiangCTList;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(769, 418);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDLichGiangCT,
            this.colIDLichGiang,
            this.colNgayGiang,
            this.colBuoiGiang,
            this.colNoiDungGiang,
            this.colLoaiDaoTao,
            this.colIDGiangVien,
            this.colIDNguoiDung});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.AllowCellMerge = true;
            this.gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawColumnHeader += new DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventHandler(this.gridView1_CustomDrawColumnHeader);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView1_CustomRowCellEdit);
            this.gridView1.TopRowChanged += new System.EventHandler(this.gridView1_TopRowChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelControl7);
            this.panel1.Controls.Add(this.calChonNhieuNgay);
            this.panel1.Controls.Add(this.dateDenNgay);
            this.panel1.Controls.Add(this.dateTuNgay);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.txtSoTietTH);
            this.panel1.Controls.Add(this.txtSoTietLT);
            this.panel1.Controls.Add(this.txtTenLop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 154);
            this.panel1.TabIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(422, 14);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(66, 14);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Chọn nhanh";
            // 
            // calChonNhieuNgay
            // 
            this.calChonNhieuNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calChonNhieuNgay.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calChonNhieuNgay.Appearance.Options.UseFont = true;
            this.calChonNhieuNgay.AutoSize = false;
            this.calChonNhieuNgay.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calChonNhieuNgay.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.calChonNhieuNgay.CellPadding = new System.Windows.Forms.Padding(0);
            this.calChonNhieuNgay.ContextButtonOptions.BottomPanelPadding = new System.Windows.Forms.Padding(0);
            this.calChonNhieuNgay.ContextButtonOptions.CenterPanelPadding = new System.Windows.Forms.Padding(0);
            this.calChonNhieuNgay.ContextButtonOptions.FarPanelPadding = new System.Windows.Forms.Padding(0);
            this.calChonNhieuNgay.ContextButtonOptions.NearPanelPadding = new System.Windows.Forms.Padding(0);
            this.calChonNhieuNgay.ContextButtonOptions.TopPanelPadding = new System.Windows.Forms.Padding(0);
            this.calChonNhieuNgay.DateTime = new System.DateTime(((long)(0)));
            this.calChonNhieuNgay.EditValue = new System.DateTime(((long)(0)));
            this.calChonNhieuNgay.Location = new System.Drawing.Point(499, 11);
            this.calChonNhieuNgay.MinimumSize = new System.Drawing.Size(140, 120);
            this.calChonNhieuNgay.Name = "calChonNhieuNgay";
            this.calChonNhieuNgay.Padding = new System.Windows.Forms.Padding(0);
            this.calChonNhieuNgay.SelectionMode = DevExpress.XtraEditors.Repository.CalendarSelectionMode.Multiple;
            this.calChonNhieuNgay.Size = new System.Drawing.Size(203, 128);
            this.calChonNhieuNgay.TabIndex = 11;
            this.calChonNhieuNgay.EditValueChanged += new System.EventHandler(this.calChonNhieuNgay_EditValueChanged);
            this.calChonNhieuNgay.Click += new System.EventHandler(this.calChonNhieuNgay_Click);
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindLichGiang, "NgayKetThuc", true));
            this.dateDenNgay.EditValue = null;
            this.dateDenNgay.Location = new System.Drawing.Point(203, 58);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDenNgay.Size = new System.Drawing.Size(208, 20);
            this.dateDenNgay.TabIndex = 9;
            this.dateDenNgay.EditValueChanged += new System.EventHandler(this.dateDenNgay_EditValueChanged);
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindLichGiang, "NgayBatDau", true));
            this.dateTuNgay.EditValue = null;
            this.dateTuNgay.Location = new System.Drawing.Point(203, 35);
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTuNgay.Size = new System.Drawing.Size(208, 20);
            this.dateTuNgay.TabIndex = 8;
            this.dateTuNgay.EditValueChanged += new System.EventHandler(this.dateTuNgay_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(97, 107);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(98, 14);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Số tiết thực hành";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(97, 84);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(90, 14);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Số tiết lý thuyết";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(97, 60);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(101, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Thời gian kết thúc";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(97, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 14);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Thời gian bắt đầu";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(97, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 14);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Tên lớp";
            // 
            // txtSoTietTH
            // 
            this.txtSoTietTH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindLichGiang, "SoTietThucHanh", true));
            this.txtSoTietTH.Location = new System.Drawing.Point(203, 104);
            this.txtSoTietTH.Name = "txtSoTietTH";
            this.txtSoTietTH.Size = new System.Drawing.Size(53, 20);
            this.txtSoTietTH.TabIndex = 2;
            // 
            // txtSoTietLT
            // 
            this.txtSoTietLT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindLichGiang, "SoTietLyThuyet", true));
            this.txtSoTietLT.Location = new System.Drawing.Point(203, 81);
            this.txtSoTietLT.Name = "txtSoTietLT";
            this.txtSoTietLT.Size = new System.Drawing.Size(53, 20);
            this.txtSoTietLT.TabIndex = 1;
            // 
            // txtTenLop
            // 
            this.txtTenLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindLichGiang, "TenLop", true));
            this.txtTenLop.Location = new System.Drawing.Point(203, 12);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(208, 20);
            this.txtTenLop.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 600);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 43);
            this.panel2.TabIndex = 2;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(573, 8);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(93, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Xóa";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(459, 8);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(93, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Lưu";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(769, 446);
            this.panel3.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.gridControl1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 28);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(769, 418);
            this.panel6.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.labelControl6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(769, 28);
            this.panel4.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(17, 8);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(53, 14);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Tháng 10";
            // 
            // bindLichGiang
            // 
            this.bindLichGiang.DataSource = typeof(ModuleDaoTao.LIB.DT_LichGiangTheoLop);
            // 
            // bindLichGiangCTList
            // 
            this.bindLichGiangCTList.DataSource = typeof(ModuleDaoTao.LIB.DT_LichGiangTheoLop_CT_Coll);
            // 
            // colIDLichGiangCT
            // 
            this.colIDLichGiangCT.FieldName = "IDLichGiangCT";
            this.colIDLichGiangCT.Name = "colIDLichGiangCT";
            this.colIDLichGiangCT.OptionsColumn.ReadOnly = true;
            // 
            // colIDLichGiang
            // 
            this.colIDLichGiang.FieldName = "IDLichGiang";
            this.colIDLichGiang.Name = "colIDLichGiang";
            // 
            // colNgayGiang
            // 
            this.colNgayGiang.FieldName = "NgayGiang";
            this.colNgayGiang.Name = "colNgayGiang";
            // 
            // colBuoiGiang
            // 
            this.colBuoiGiang.FieldName = "BuoiGiang";
            this.colBuoiGiang.Name = "colBuoiGiang";
            this.colBuoiGiang.Visible = true;
            this.colBuoiGiang.VisibleIndex = 0;
            // 
            // colNoiDungGiang
            // 
            this.colNoiDungGiang.FieldName = "NoiDungGiang";
            this.colNoiDungGiang.Name = "colNoiDungGiang";
            this.colNoiDungGiang.Visible = true;
            this.colNoiDungGiang.VisibleIndex = 1;
            // 
            // colLoaiDaoTao
            // 
            this.colLoaiDaoTao.FieldName = "LoaiDaoTao";
            this.colLoaiDaoTao.Name = "colLoaiDaoTao";
            this.colLoaiDaoTao.Visible = true;
            this.colLoaiDaoTao.VisibleIndex = 2;
            // 
            // colIDGiangVien
            // 
            this.colIDGiangVien.FieldName = "IDGiangVien";
            this.colIDGiangVien.Name = "colIDGiangVien";
            this.colIDGiangVien.Visible = true;
            this.colIDGiangVien.VisibleIndex = 3;
            // 
            // colIDNguoiDung
            // 
            this.colIDNguoiDung.FieldName = "IDNguoiDung";
            this.colIDNguoiDung.Name = "colIDNguoiDung";
            this.colIDNguoiDung.Visible = true;
            this.colIDNguoiDung.VisibleIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 643);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calChonNhieuNgay.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTietTH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTietLT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindLichGiang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindLichGiangCTList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.DateEdit dateDenNgay;
        private DevExpress.XtraEditors.DateEdit dateTuNgay;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSoTietTH;
        private DevExpress.XtraEditors.TextEdit txtSoTietLT;
        private DevExpress.XtraEditors.TextEdit txtTenLop;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.Controls.CalendarControl calChonNhieuNgay;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.BindingSource bindLichGiang;
        private System.Windows.Forms.BindingSource bindLichGiangCTList;
        private DevExpress.XtraGrid.Columns.GridColumn colIDLichGiangCT;
        private DevExpress.XtraGrid.Columns.GridColumn colIDLichGiang;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayGiang;
        private DevExpress.XtraGrid.Columns.GridColumn colBuoiGiang;
        private DevExpress.XtraGrid.Columns.GridColumn colNoiDungGiang;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiDaoTao;
        private DevExpress.XtraGrid.Columns.GridColumn colIDGiangVien;
        private DevExpress.XtraGrid.Columns.GridColumn colIDNguoiDung;


    }
}