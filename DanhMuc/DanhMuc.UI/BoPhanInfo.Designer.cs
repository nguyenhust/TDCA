namespace DanhMuc.UI
{
    partial class BoPhanInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radCheckBoxIsUser = new Telerik.WinControls.UI.RadCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radTextBoxTen = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBoxMa = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox2 = new Telerik.WinControls.UI.RadTextBox();
            this.bindingSourceBoPhan = new System.Windows.Forms.BindingSource(this.components);
            this.radGhiChu = new NETLINK.UI.RichTextBoxWithBigEditor();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxIsUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBoPhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(158, 229);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(311, 229);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bộ phận";
            // 
            // radCheckBoxIsUser
            // 
            this.radCheckBoxIsUser.Location = new System.Drawing.Point(91, 80);
            this.radCheckBoxIsUser.Name = "radCheckBoxIsUser";
            // 
            // 
            // 
            this.radCheckBoxIsUser.RootElement.StretchHorizontally = true;
            this.radCheckBoxIsUser.RootElement.StretchVertically = true;
            this.radCheckBoxIsUser.Size = new System.Drawing.Size(62, 18);
            this.radCheckBoxIsUser.TabIndex = 4;
            this.radCheckBoxIsUser.Text = "Sử dụng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ghi chú";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radGhiChu);
            this.groupBox1.Controls.Add(this.radTextBoxTen);
            this.groupBox1.Controls.Add(this.radTextBoxMa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radCheckBoxIsUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 210);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = true;
            this.groupBox1.Text = "Thông tin bộ phận";
            // 
            // radTextBoxTen
            // 
            this.radTextBoxTen.Location = new System.Drawing.Point(91, 54);
            this.radTextBoxTen.Name = "radTextBoxTen";
            this.radTextBoxTen.Size = new System.Drawing.Size(272, 20);
            this.radTextBoxTen.TabIndex = 8;
            this.radTextBoxTen.TabStop = true;
            // 
            // radTextBoxMa
            // 
            this.radTextBoxMa.Location = new System.Drawing.Point(91, 28);
            this.radTextBoxMa.Name = "radTextBoxMa";
            this.radTextBoxMa.Size = new System.Drawing.Size(272, 20);
            this.radTextBoxMa.TabIndex = 7;
            this.radTextBoxMa.TabStop = true;
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(91, 26);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(221, 20);
            this.radTextBox1.TabIndex = 2;
            this.radTextBox1.TabStop = true;
            // 
            // radTextBox2
            // 
            this.radTextBox2.Location = new System.Drawing.Point(91, 54);
            this.radTextBox2.Name = "radTextBox2";
            this.radTextBox2.Size = new System.Drawing.Size(221, 20);
            this.radTextBox2.TabIndex = 3;
            this.radTextBox2.TabStop = true;
            // 
            // bindingSourceBoPhan
            // 
            this.bindingSourceBoPhan.DataSource = typeof(DanhMuc.LIB.DIC_BoPhan);
            // 
            // radGhiChu
            // 
            this.radGhiChu.Location = new System.Drawing.Point(91, 109);
            this.radGhiChu.MaxLength = 2147483647;
            this.radGhiChu.Name = "radGhiChu";
            this.radGhiChu.Size = new System.Drawing.Size(272, 82);
            this.radGhiChu.TabIndex = 9;
            // 
            // BoPhanInfo
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 297);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(30, 30);
            this.Name = "BoPhanInfo";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Quản lý bộ phận";
            this.ThemeName = "ControlDefault";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxIsUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBoPhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxIsUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadTextBox radTextBox2;
        private Telerik.WinControls.UI.RadTextBox radTextBoxMa;
        private Telerik.WinControls.UI.RadTextBox radTextBoxTen;
        private System.Windows.Forms.BindingSource bindingSourceBoPhan;
        private NETLINK.UI.RichTextBoxWithBigEditor radGhiChu;


    }
}
