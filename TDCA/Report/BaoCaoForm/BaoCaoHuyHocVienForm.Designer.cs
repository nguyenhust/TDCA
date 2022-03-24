namespace TDCA.Report.BaoCaoForm
{
    partial class frmBaoCaoHuy
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rdoTatCa = new Telerik.WinControls.UI.RadRadioButton();
            this.rdoNguoiDung = new Telerik.WinControls.UI.RadRadioButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdoTatCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.rdoTatCa);
            this.radGroupBox1.Controls.Add(this.rdoNguoiDung);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.dtpTuNgay);
            this.radGroupBox1.Controls.Add(this.dtpDenNgay);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.radGroupBox1.HeaderText = "Thông tin ngày hủy";
            this.radGroupBox1.Location = new System.Drawing.Point(7, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(326, 156);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Thông tin ngày hủy";
            // 
            // rdoTatCa
            // 
            this.rdoTatCa.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.rdoTatCa.Location = new System.Drawing.Point(221, 129);
            this.rdoTatCa.Name = "rdoTatCa";
            this.rdoTatCa.Size = new System.Drawing.Size(58, 22);
            this.rdoTatCa.TabIndex = 7;
            this.rdoTatCa.Text = "Tất cả";
            // 
            // rdoNguoiDung
            // 
            this.rdoNguoiDung.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rdoNguoiDung.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.rdoNguoiDung.Location = new System.Drawing.Point(99, 129);
            this.rdoNguoiDung.Name = "rdoNguoiDung";
            this.rdoNguoiDung.Size = new System.Drawing.Size(96, 22);
            this.rdoNguoiDung.TabIndex = 6;
            this.rdoNguoiDung.TabStop = true;
            this.rdoNguoiDung.Text = "Người dùng";
            this.rdoNguoiDung.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.radLabel3.Location = new System.Drawing.Point(7, 129);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(86, 22);
            this.radLabel3.TabIndex = 5;
            this.radLabel3.Text = "Nhóm theo:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(99, 33);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(182, 26);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(97, 84);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(182, 26);
            this.dtpDenNgay.TabIndex = 1;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.radLabel2.Location = new System.Drawing.Point(5, 84);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(69, 22);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "Đến ngày:";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.radLabel1.Location = new System.Drawing.Point(5, 33);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(60, 22);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Từ ngày:";
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.btnHuy.Location = new System.Drawing.Point(32, 205);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(119, 35);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.LightGray;
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.btnXem.Location = new System.Drawing.Point(165, 205);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(138, 35);
            this.btnXem.TabIndex = 1;
            this.btnXem.Text = "Xem Báo Cáo";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // frmBaoCaoHuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(345, 244);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.radGroupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(353, 274);
            this.MinimumSize = new System.Drawing.Size(353, 274);
            this.Name = "frmBaoCaoHuy";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(353, 274);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Báo cáo hủy học viên";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdoTatCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXem;
        private Telerik.WinControls.UI.RadRadioButton rdoTatCa;
        private Telerik.WinControls.UI.RadRadioButton rdoNguoiDung;
        private Telerik.WinControls.UI.RadLabel radLabel3;
    }
}