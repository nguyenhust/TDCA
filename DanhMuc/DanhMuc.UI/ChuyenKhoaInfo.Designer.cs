namespace DanhMuc.UI
{
    partial class ChuyenKhoaInfo
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
            this.radGhiChu = new NETLINK.UI.RichTextBoxWithBigEditor();
            this.bindingSourceChuyenKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.radCheckBoxIsUse = new Telerik.WinControls.UI.RadCheckBox();
            this.radTextBoxTen = new Telerik.WinControls.UI.RadTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceChuyenKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxIsUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(216, 205);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(354, 205);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radGhiChu);
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Controls.Add(this.radCheckBoxIsUse);
            this.radGroupBox1.Controls.Add(this.radTextBoxTen);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "Thông tin";
            this.radGroupBox1.Location = new System.Drawing.Point(13, 13);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(430, 176);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "Thông tin";
            // 
            // radGhiChu
            // 
            this.radGhiChu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceChuyenKhoa, "GhiChu", true));
            this.radGhiChu.Enable = true;
            this.radGhiChu.Location = new System.Drawing.Point(117, 89);
            this.radGhiChu.MaxLength = 2147483647;
            this.radGhiChu.Name = "radGhiChu";
            this.radGhiChu.Size = new System.Drawing.Size(276, 71);
            this.radGhiChu.TabIndex = 7;
            // 
            // bindingSourceChuyenKhoa
            // 
            this.bindingSourceChuyenKhoa.DataSource = typeof(DanhMuc.LIB.DIC_ChuyenKhoa);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(22, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Viết tắt:";
            // 
            // radCheckBoxIsUse
            // 
            this.radCheckBoxIsUse.Location = new System.Drawing.Point(117, 53);
            this.radCheckBoxIsUse.Name = "radCheckBoxIsUse";
            this.radCheckBoxIsUse.Size = new System.Drawing.Size(62, 18);
            this.radCheckBoxIsUse.TabIndex = 5;
            this.radCheckBoxIsUse.Text = "Sử dụng";
            // 
            // radTextBoxTen
            // 
            this.radTextBoxTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceChuyenKhoa, "Ten", true));
            this.radTextBoxTen.Location = new System.Drawing.Point(117, 27);
            this.radTextBoxTen.Name = "radTextBoxTen";
            this.radTextBoxTen.Size = new System.Drawing.Size(276, 20);
            this.radTextBoxTen.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuyên khoa:";
            // 
            // ChuyenKhoaInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 251);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "ChuyenKhoaInfo";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Quản lý thông tin chuyên khoa";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.ChuyenKhoaInfo_Load);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.radGroupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceChuyenKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxIsUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox radTextBoxTen;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxIsUse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSourceChuyenKhoa;
        private NETLINK.UI.RichTextBoxWithBigEditor radGhiChu;
    }
}
