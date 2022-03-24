namespace ModuleDaoTao.UI
{
    partial class FromNhapSoTien
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.txtDonGia = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSL = new Telerik.WinControls.UI.RadTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radNoiDung = new Telerik.WinControls.UI.RadDropDownList();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radNoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(49, 139);
            this.btnSave.Text = "In báo cáo";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(228, 139);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.label4);
            this.radGroupBox1.Controls.Add(this.radNoiDung);
            this.radGroupBox1.Controls.Add(this.txtDonGia);
            this.radGroupBox1.Controls.Add(this.label6);
            this.radGroupBox1.Controls.Add(this.txtSL);
            this.radGroupBox1.Controls.Add(this.label5);
            this.radGroupBox1.Controls.Add(this.panel1);
            this.radGroupBox1.HeaderText = "Thông tin về số tiền làm thẻ học viên và làm chứng chỉ";
            this.radGroupBox1.Location = new System.Drawing.Point(3, 5);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(347, 128);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "Thông tin về số tiền làm thẻ học viên và làm chứng chỉ";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(212, 79);
            this.txtDonGia.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(122, 20);
            this.txtDonGia.TabIndex = 41;
            this.txtDonGia.TabStop = false;
            this.txtDonGia.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Đơn giá:";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(69, 79);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(89, 20);
            this.txtSL.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Số lượng:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(9, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 43);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập đơn giá làm chứng chỉ là 50,000 VND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập đơn giá làm thẻ học viên là 30,000 VND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lưu ý:";
            // 
            // radNoiDung
            // 
            this.radNoiDung.AllowShowFocusCues = false;
            this.radNoiDung.AutoCompleteDisplayMember = null;
            this.radNoiDung.AutoCompleteValueMember = null;
            radListDataItem1.Text = "Phiếu thu học phí";
            radListDataItem1.TextWrap = true;
            radListDataItem2.Text = "Phiếu đề nghị TT làm thẻ học viên";
            radListDataItem2.TextWrap = true;
            radListDataItem3.Text = "Phiếu đề nghị TT làm chứng chỉ";
            radListDataItem3.TextWrap = true;
            this.radNoiDung.Items.Add(radListDataItem1);
            this.radNoiDung.Items.Add(radListDataItem2);
            this.radNoiDung.Items.Add(radListDataItem3);
            this.radNoiDung.Location = new System.Drawing.Point(69, 103);
            this.radNoiDung.Name = "radNoiDung";
            this.radNoiDung.NullText = "Nội dung thu học phí";
            this.radNoiDung.Size = new System.Drawing.Size(265, 20);
            this.radNoiDung.TabIndex = 42;
            this.radNoiDung.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radNoiDung_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Nội dung:";
            // 
            // FromNhapSoTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 175);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FromNhapSoTien";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Nhập số lượng và đơn giá";
            this.Shown += new System.EventHandler(this.FromNhapSoTien_Shown);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.radGroupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radNoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Telerik.WinControls.UI.RadTextBox txtSL;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadMaskedEditBox txtDonGia;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadDropDownList radNoiDung;
    }
}