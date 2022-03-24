namespace DanhMuc.UI
{
    partial class ChucvuInfo
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
            this.bindingSourceChucVu = new System.Windows.Forms.BindingSource();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radSuDung = new Telerik.WinControls.UI.RadCheckBox();
            this.radTextBoxTen = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radGhiChu = new NETLINK.UI.RichTextBoxWithBigEditor();
            this.radChucVu = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSuDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(89, 162);
            this.btnSave.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(225, 162);
            this.btnClose.Size = new System.Drawing.Size(130, 34);
            this.btnClose.TabIndex = 4;
            // 
            // bindingSourceChucVu
            // 
            this.bindingSourceChucVu.DataSource = typeof(DanhMuc.LIB.DIC_ChucVu);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(52, 18);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Chức vụ :";
            // 
            // radSuDung
            // 
            this.radSuDung.Location = new System.Drawing.Point(89, 124);
            this.radSuDung.Name = "radSuDung";
            // 
            // 
            // 
            this.radSuDung.RootElement.StretchHorizontally = true;
            this.radSuDung.RootElement.StretchVertically = true;
            this.radSuDung.Size = new System.Drawing.Size(62, 18);
            this.radSuDung.TabIndex = 2;
            this.radSuDung.Text = "Sử dụng";
            this.radSuDung.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radTextBoxTen
            // 
            this.radTextBoxTen.Location = new System.Drawing.Point(33, 47);
            this.radTextBoxTen.Name = "radTextBoxTen";
            this.radTextBoxTen.Size = new System.Drawing.Size(276, 20);
            this.radTextBoxTen.TabIndex = 2;
            this.radTextBoxTen.TabStop = true;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(12, 36);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(50, 18);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Ghi chú :";
            // 
            // radGhiChu
            // 
            this.radGhiChu.Enable = true;
            this.radGhiChu.Location = new System.Drawing.Point(89, 36);
            this.radGhiChu.MaxLength = 2147483647;
            this.radGhiChu.Name = "radGhiChu";
            this.radGhiChu.Size = new System.Drawing.Size(272, 82);
            this.radGhiChu.TabIndex = 1;
            // 
            // radChucVu
            // 
            this.radChucVu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceChucVu, "Ten", true));
            this.radChucVu.Location = new System.Drawing.Point(89, 12);
            this.radChucVu.Name = "radChucVu";
            this.radChucVu.NullText = "Nhập tên chức vụ";
            this.radChucVu.Size = new System.Drawing.Size(272, 20);
            this.radChucVu.TabIndex = 0;
            this.radChucVu.TabStop = true;
            // 
            // ChucvuInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 207);
            this.Controls.Add(this.radChucVu);
            this.Controls.Add(this.radGhiChu);
            this.Controls.Add(this.radSuDung);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "ChucvuInfo";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Quản lý Chức vụ";
            this.ThemeName = "ControlDefault";
            this.Controls.SetChildIndex(this.radLabel1, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.radLabel2, 0);
            this.Controls.SetChildIndex(this.radSuDung, 0);
            this.Controls.SetChildIndex(this.radGhiChu, 0);
            this.Controls.SetChildIndex(this.radChucVu, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSuDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceChucVu;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadCheckBox radSuDung;
        private Telerik.WinControls.UI.RadTextBox radTextBoxTen;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private NETLINK.UI.RichTextBoxWithBigEditor radGhiChu;
        private Telerik.WinControls.UI.RadTextBox radChucVu;
    }
}
