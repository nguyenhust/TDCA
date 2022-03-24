namespace TDCA.Report.BaoCaoForm
{
    partial class FormHocVienChuaDongHocPhi
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
            this.radDenNgay = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radTuNgay = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCLose = new Telerik.WinControls.UI.RadButton();
            this.btnPrint = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDenNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTuNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radDenNgay);
            this.radGroupBox1.Controls.Add(this.radTuNgay);
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.HeaderText = "Thông tin tìm kiếm";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(280, 107);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Thông tin tìm kiếm";
            // 
            // radDenNgay
            // 
            this.radDenNgay.Culture = new System.Globalization.CultureInfo("vi-VN");
            this.radDenNgay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.radDenNgay.Location = new System.Drawing.Point(72, 72);
            this.radDenNgay.Name = "radDenNgay";
            this.radDenNgay.Size = new System.Drawing.Size(195, 23);
            this.radDenNgay.TabIndex = 4;
            this.radDenNgay.TabStop = false;
            this.radDenNgay.Text = "24/10/2018";
            this.radDenNgay.Value = new System.DateTime(2018, 10, 24, 22, 39, 20, 408);
            // 
            // radTuNgay
            // 
            this.radTuNgay.Culture = new System.Globalization.CultureInfo("vi-VN");
            this.radTuNgay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.radTuNgay.Location = new System.Drawing.Point(73, 37);
            this.radTuNgay.Name = "radTuNgay";
            this.radTuNgay.Size = new System.Drawing.Size(194, 23);
            this.radTuNgay.TabIndex = 3;
            this.radTuNgay.TabStop = false;
            this.radTuNgay.Text = "24/10/2018";
            this.radTuNgay.Value = new System.DateTime(2018, 10, 24, 22, 39, 20, 408);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến ngày :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ngày :";
            // 
            // btnCLose
            // 
            this.btnCLose.Location = new System.Drawing.Point(169, 119);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(83, 24);
            this.btnCLose.TabIndex = 1;
            this.btnCLose.Text = "Thoát";
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(36, 120);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(91, 24);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Xem báo cáo";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FormHocVienChuaDongHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 146);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FormHocVienChuaDongHocPhi";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "From xem báo cáo";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDenNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTuNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnCLose;
        private Telerik.WinControls.UI.RadButton btnPrint;
        private Telerik.WinControls.UI.RadDateTimePicker radDenNgay;
        private Telerik.WinControls.UI.RadDateTimePicker radTuNgay;
    }
}
