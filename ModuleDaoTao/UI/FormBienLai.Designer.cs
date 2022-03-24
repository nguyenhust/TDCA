namespace ModuleDaoTao.UI
{
    partial class FormBienLai
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn3 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radBienLai = new Telerik.WinControls.UI.RadGridView();
            this.bind = new System.Windows.Forms.BindingSource(this.components);
            this.bindTamThu = new System.Windows.Forms.BindingSource(this.components);
            this.radIntatCa = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radBienLai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBienLai.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindTamThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(239, 263);
            this.btnSave.Text = "In báo cáo";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(419, 263);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radBienLai);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 255);
            this.panel1.TabIndex = 8;
            // 
            // radBienLai
            // 
            this.radBienLai.AutoSizeRows = true;
            this.radBienLai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radBienLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBienLai.Location = new System.Drawing.Point(0, 0);
            // 
            // radBienLai
            // 
            this.radBienLai.MasterTemplate.AllowAddNewRow = false;
            gridViewDecimalColumn1.DataType = typeof(long);
            gridViewDecimalColumn1.FieldName = "IDBienLai";
            gridViewDecimalColumn1.HeaderText = "IDBienLai";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "IDBienLai";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.FieldName = "MaBienLai";
            gridViewTextBoxColumn1.HeaderText = "Số biên lai";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "MaBienLai";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 120;
            gridViewTextBoxColumn2.FieldName = "SoHoaDon";
            gridViewTextBoxColumn2.HeaderText = "Số hoá đơn";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "SoHoaDon";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 120;
            gridViewDecimalColumn2.DataType = typeof(byte);
            gridViewDecimalColumn2.FieldName = "SoLan";
            gridViewDecimalColumn2.HeaderText = "SoLan";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "SoLan";
            gridViewDecimalColumn3.DataType = typeof(byte);
            gridViewDecimalColumn3.FieldName = "SoLanIn";
            gridViewDecimalColumn3.HeaderText = "SoLanIn";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.IsVisible = false;
            gridViewDecimalColumn3.Name = "SoLanIn";
            gridViewDecimalColumn4.FieldName = "SoTien";
            gridViewDecimalColumn4.FormatString = "{0:0,0}";
            gridViewDecimalColumn4.HeaderText = "Số tiền";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.Name = "SoTien";
            gridViewDecimalColumn4.ReadOnly = true;
            gridViewDecimalColumn4.Width = 120;
            gridViewDateTimeColumn1.FieldName = "NgayThu";
            gridViewDateTimeColumn1.HeaderText = "Ngày thu";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "NgayThu";
            gridViewDateTimeColumn1.ReadOnly = true;
            gridViewDateTimeColumn1.Width = 100;
            gridViewTextBoxColumn3.FieldName = "NguoiDong";
            gridViewTextBoxColumn3.HeaderText = "NguoiDong";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "NguoiDong";
            gridViewDecimalColumn5.DataType = typeof(int);
            gridViewDecimalColumn5.FieldName = "IDHocVien";
            gridViewDecimalColumn5.HeaderText = "IDHocVien";
            gridViewDecimalColumn5.IsAutoGenerated = true;
            gridViewDecimalColumn5.IsVisible = false;
            gridViewDecimalColumn5.Name = "IDHocVien";
            gridViewDecimalColumn6.DataType = typeof(long);
            gridViewDecimalColumn6.FieldName = "IDNguoiThu";
            gridViewDecimalColumn6.HeaderText = "IDNguoiThu";
            gridViewDecimalColumn6.IsAutoGenerated = true;
            gridViewDecimalColumn6.IsVisible = false;
            gridViewDecimalColumn6.Name = "IDNguoiThu";
            gridViewDecimalColumn7.DataType = typeof(System.Nullable<byte>);
            gridViewDecimalColumn7.FieldName = "HinhThucThu";
            gridViewDecimalColumn7.HeaderText = "HinhThucThu";
            gridViewDecimalColumn7.IsAutoGenerated = true;
            gridViewDecimalColumn7.IsVisible = false;
            gridViewDecimalColumn7.Name = "HinhThucThu";
            gridViewTextBoxColumn4.FieldName = "Reference_Code";
            gridViewTextBoxColumn4.HeaderText = "Reference_Code";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "Reference_Code";
            gridViewDecimalColumn8.FieldName = "ThanhTien";
            gridViewDecimalColumn8.HeaderText = "ThanhTien";
            gridViewDecimalColumn8.IsAutoGenerated = true;
            gridViewDecimalColumn8.IsVisible = false;
            gridViewDecimalColumn8.Name = "ThanhTien";
            gridViewDecimalColumn8.ReadOnly = true;
            gridViewTextBoxColumn5.FieldName = "NguoiThu";
            gridViewTextBoxColumn5.HeaderText = "Người thu";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "NguoiThu";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 130;
            gridViewCheckBoxColumn1.FieldName = "XuatHD";
            gridViewCheckBoxColumn1.HeaderText = "XuatHD";
            gridViewCheckBoxColumn1.IsAutoGenerated = true;
            gridViewCheckBoxColumn1.IsVisible = false;
            gridViewCheckBoxColumn1.Name = "XuatHD";
            gridViewCheckBoxColumn2.Checked = Telerik.WinControls.Enumerations.ToggleState.On;
            gridViewCheckBoxColumn2.FieldName = "Huy";
            gridViewCheckBoxColumn2.HeaderText = "Huỷ";
            gridViewCheckBoxColumn2.IsAutoGenerated = true;
            gridViewCheckBoxColumn2.IsVisible = false;
            gridViewCheckBoxColumn2.Name = "Huy";
            gridViewCheckBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCheckBoxColumn3.FieldName = "INPYC";
            gridViewCheckBoxColumn3.HeaderText = "Chọn";
            gridViewCheckBoxColumn3.Name = "INPYC";
            gridViewCommandColumn1.DefaultText = "Huỷ ";
            gridViewCommandColumn1.FieldName = "btnHuyBL";
            gridViewCommandColumn1.HeaderText = "Huỷ BL";
            gridViewCommandColumn1.IsVisible = false;
            gridViewCommandColumn1.Name = "btnHuyBL";
            gridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn1.UseDefaultText = true;
            gridViewCommandColumn1.Width = 70;
            this.radBienLai.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn3,
            gridViewDecimalColumn5,
            gridViewDecimalColumn6,
            gridViewDecimalColumn7,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn8,
            gridViewTextBoxColumn5,
            gridViewCheckBoxColumn1,
            gridViewCheckBoxColumn2,
            gridViewCheckBoxColumn3,
            gridViewCommandColumn1});
            this.radBienLai.MasterTemplate.DataSource = this.bind;
            this.radBienLai.MasterTemplate.EnableGrouping = false;
            this.radBienLai.MasterTemplate.ShowRowHeaderColumn = false;
            this.radBienLai.Name = "radBienLai";
            this.radBienLai.Size = new System.Drawing.Size(637, 255);
            this.radBienLai.SynchronizeCurrentRowInSplitMode = true;
            this.radBienLai.TabIndex = 4;
            this.radBienLai.Text = "radGridView1";
            this.radBienLai.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.radBienLai_CellFormatting);
            // 
            // bind
            // 
            this.bind.AllowNew = false;
            this.bind.DataSource = typeof(ModuleDaoTao.LIB.BienLaiColl);
            // 
            // bindTamThu
            // 
            this.bindTamThu.DataSource = typeof(ModuleDaoTao.LIB.BienLaiInfo);
            // 
            // radIntatCa
            // 
            this.radIntatCa.AutoSize = true;
            this.radIntatCa.Location = new System.Drawing.Point(3, 263);
            this.radIntatCa.Name = "radIntatCa";
            this.radIntatCa.Size = new System.Drawing.Size(76, 21);
            this.radIntatCa.TabIndex = 1;
            this.radIntatCa.Text = "In tất cả";
            this.radIntatCa.UseVisualStyleBackColor = true;
            this.radIntatCa.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormBienLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 299);
            this.Controls.Add(this.radIntatCa);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormBienLai";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Thông tin phiếu yêu cầu";
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.radIntatCa, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radBienLai.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBienLai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindTamThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bind;
        private System.Windows.Forms.BindingSource bindTamThu;
        private System.Windows.Forms.CheckBox radIntatCa;
        private Telerik.WinControls.UI.RadGridView radBienLai;
    }
}