namespace DanhMuc.UI
{
    partial class HocHamInfo
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
            this.radCheckBoxIsUse = new Telerik.WinControls.UI.RadCheckBox();
            this.radTextBoxTen = new Telerik.WinControls.UI.RadTextBox();
            this.bindingSourceHocHam = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxIsUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHocHam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(140, 122);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(276, 122);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radCheckBoxIsUse);
            this.radGroupBox1.Controls.Add(this.radTextBoxTen);
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
            this.radGroupBox1.Size = new System.Drawing.Size(352, 101);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "Thông tin";
            // 
            // radCheckBoxIsUse
            // 
            this.radCheckBoxIsUse.Location = new System.Drawing.Point(37, 73);
            this.radCheckBoxIsUse.Name = "radCheckBoxIsUse";
            this.radCheckBoxIsUse.Size = new System.Drawing.Size(62, 18);
            this.radCheckBoxIsUse.TabIndex = 6;
            this.radCheckBoxIsUse.Text = "Sử dụng";
            // 
            // radTextBoxTen
            // 
            this.radTextBoxTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceHocHam, "TenHocHam", true));
            this.radTextBoxTen.Location = new System.Drawing.Point(37, 47);
            this.radTextBoxTen.Name = "radTextBoxTen";
            this.radTextBoxTen.Size = new System.Drawing.Size(276, 20);
            this.radTextBoxTen.TabIndex = 4;
            this.radTextBoxTen.TabStop = true;
            // 
            // bindingSourceHocHam
            // 
            this.bindingSourceHocHam.DataSource = typeof(DanhMuc.LIB.DIC_HocHam);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên học hàm:";
            // 
            // HocHamInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 163);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "HocHamInfo";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Quản lý thông tin học hàm";
            this.ThemeName = "ControlDefault";
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.radGroupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxIsUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHocHam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox radTextBoxTen;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxIsUse;
        private System.Windows.Forms.BindingSource bindingSourceHocHam;
    }
}
