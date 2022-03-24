namespace DanhMuc.UI
{
    partial class KhoaPhongInfo
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radTextBoxMa = new Telerik.WinControls.UI.RadTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radTextBoxTen = new Telerik.WinControls.UI.RadTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radTextBoxTruongKhoa = new Telerik.WinControls.UI.RadTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radTextBoxYTaTruong = new Telerik.WinControls.UI.RadTextBox();
            this.radCheckBoxIsUse = new Telerik.WinControls.UI.RadCheckBox();
            this.bindingSourceKhoaPhong = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.radTextBoxTenTat = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxTruongKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxYTaTruong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxIsUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceKhoaPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxTenTat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(289, 210);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(425, 210);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radTextBoxTenTat);
            this.radGroupBox1.Controls.Add(this.label5);
            this.radGroupBox1.Controls.Add(this.radCheckBoxIsUse);
            this.radGroupBox1.Controls.Add(this.radTextBoxYTaTruong);
            this.radGroupBox1.Controls.Add(this.label4);
            this.radGroupBox1.Controls.Add(this.radTextBoxTruongKhoa);
            this.radGroupBox1.Controls.Add(this.label3);
            this.radGroupBox1.Controls.Add(this.radTextBoxTen);
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Controls.Add(this.radTextBoxMa);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Thông tin";
            this.radGroupBox1.Location = new System.Drawing.Point(13, 13);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(501, 191);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "Thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Khoa";
            // 
            // radTextBoxMa
            // 
            this.radTextBoxMa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceKhoaPhong, "MaKhoa", true));
            this.radTextBoxMa.Location = new System.Drawing.Point(135, 35);
            this.radTextBoxMa.Name = "radTextBoxMa";
            this.radTextBoxMa.Size = new System.Drawing.Size(329, 20);
            this.radTextBoxMa.TabIndex = 5;
            this.radTextBoxMa.TabStop = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Khoa";
            // 
            // radTextBoxTen
            // 
            this.radTextBoxTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceKhoaPhong, "TenKhoa", true));
            this.radTextBoxTen.Location = new System.Drawing.Point(135, 61);
            this.radTextBoxTen.Name = "radTextBoxTen";
            this.radTextBoxTen.Size = new System.Drawing.Size(329, 20);
            this.radTextBoxTen.TabIndex = 6;
            this.radTextBoxTen.TabStop = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trưởng Khoa";
            // 
            // radTextBoxTruongKhoa
            // 
            this.radTextBoxTruongKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceKhoaPhong, "TruongKhoa", true));
            this.radTextBoxTruongKhoa.Location = new System.Drawing.Point(135, 112);
            this.radTextBoxTruongKhoa.Name = "radTextBoxTruongKhoa";
            this.radTextBoxTruongKhoa.Size = new System.Drawing.Size(329, 20);
            this.radTextBoxTruongKhoa.TabIndex = 7;
            this.radTextBoxTruongKhoa.TabStop = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Y tá trưởng";
            // 
            // radTextBoxYTaTruong
            // 
            this.radTextBoxYTaTruong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceKhoaPhong, "YTaTruong", true));
            this.radTextBoxYTaTruong.Location = new System.Drawing.Point(135, 138);
            this.radTextBoxYTaTruong.Name = "radTextBoxYTaTruong";
            this.radTextBoxYTaTruong.Size = new System.Drawing.Size(329, 20);
            this.radTextBoxYTaTruong.TabIndex = 8;
            this.radTextBoxYTaTruong.TabStop = true;
            // 
            // radCheckBoxIsUse
            // 
            this.radCheckBoxIsUse.Location = new System.Drawing.Point(135, 164);
            this.radCheckBoxIsUse.Name = "radCheckBoxIsUse";
            this.radCheckBoxIsUse.Size = new System.Drawing.Size(62, 18);
            this.radCheckBoxIsUse.TabIndex = 9;
            this.radCheckBoxIsUse.Text = "Sử dụng";
            // 
            // bindingSourceKhoaPhong
            // 
            this.bindingSourceKhoaPhong.DataSource = typeof(DanhMuc.LIB.DIC_VienKhoaPhong);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tên tắt";
            // 
            // radTextBoxTenTat
            // 
            this.radTextBoxTenTat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceKhoaPhong, "TenTat", true));
            this.radTextBoxTenTat.Location = new System.Drawing.Point(135, 86);
            this.radTextBoxTenTat.Name = "radTextBoxTenTat";
            this.radTextBoxTenTat.Size = new System.Drawing.Size(329, 20);
            this.radTextBoxTenTat.TabIndex = 7;
            this.radTextBoxTenTat.TabStop = true;
            // 
            // KhoaPhongInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 248);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "KhoaPhongInfo";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Quản lý thông tin Khoa Phòng";
            this.ThemeName = "ControlDefault";
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.radGroupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxTruongKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxYTaTruong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxIsUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceKhoaPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxTenTat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox radTextBoxMa;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadTextBox radTextBoxTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadTextBox radTextBoxTruongKhoa;
        private Telerik.WinControls.UI.RadTextBox radTextBoxYTaTruong;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxIsUse;
        private System.Windows.Forms.BindingSource bindingSourceKhoaPhong;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadTextBox radTextBoxTenTat;
    }
}
