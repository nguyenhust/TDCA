namespace ModuleHanhChinh.UI
{
    partial class Form_VanPhongPham
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
            this.radBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radTen = new Telerik.WinControls.UI.RadTextBox();
            this.radDonVi = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox3 = new Telerik.WinControls.UI.RadTextBox();
            this.richTextBoxWithBigEditor1 = new NETLINK.UI.RichTextBoxWithBigEditor();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDonVi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(146, 215);
            this.btnSave.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(282, 215);
            this.btnClose.Size = new System.Drawing.Size(130, 34);
            this.btnClose.TabIndex = 6;
            // 
            // radBindingSource
            // 
            this.radBindingSource.DataSource = typeof(ModuleHanhChinh.LIB.HC_DuTruVanPhongPham);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radLabel1.ForeColor = System.Drawing.Color.Red;
            this.radLabel1.Location = new System.Drawing.Point(13, 13);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(80, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Tên vật phẩm :";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radLabel2.ForeColor = System.Drawing.Color.Red;
            this.radLabel2.Location = new System.Drawing.Point(13, 46);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(67, 18);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Đơn vị tính :";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radLabel3.Location = new System.Drawing.Point(13, 79);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(83, 18);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Hãng sản xuất :";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radLabel4.Location = new System.Drawing.Point(13, 112);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(50, 18);
            this.radLabel4.TabIndex = 5;
            this.radLabel4.Text = "Ghi chú :";
            // 
            // radTen
            // 
            this.radTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radBindingSource, "TenThietBi", true));
            this.radTen.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radTen.Location = new System.Drawing.Point(134, 13);
            this.radTen.Name = "radTen";
            this.radTen.Size = new System.Drawing.Size(330, 20);
            this.radTen.TabIndex = 1;
            this.radTen.TabStop = true;
            // 
            // radDonVi
            // 
            this.radDonVi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radBindingSource, "DonVi", true));
            this.radDonVi.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radDonVi.Location = new System.Drawing.Point(134, 46);
            this.radDonVi.Name = "radDonVi";
            this.radDonVi.Size = new System.Drawing.Size(330, 20);
            this.radDonVi.TabIndex = 2;
            this.radDonVi.TabStop = true;
            // 
            // radTextBox3
            // 
            this.radTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radBindingSource, "HangSanXuat", true));
            this.radTextBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radTextBox3.Location = new System.Drawing.Point(134, 79);
            this.radTextBox3.Name = "radTextBox3";
            this.radTextBox3.Size = new System.Drawing.Size(330, 20);
            this.radTextBox3.TabIndex = 3;
            this.radTextBox3.TabStop = true;
            this.radTextBox3.TextChanged += new System.EventHandler(this.radTextBox3_TextChanged);
            // 
            // richTextBoxWithBigEditor1
            // 
            this.richTextBoxWithBigEditor1.Enable = true;
            this.richTextBoxWithBigEditor1.Location = new System.Drawing.Point(134, 112);
            this.richTextBoxWithBigEditor1.MaxLength = 2147483647;
            this.richTextBoxWithBigEditor1.Name = "richTextBoxWithBigEditor1";
            this.richTextBoxWithBigEditor1.Size = new System.Drawing.Size(330, 81);
            this.richTextBoxWithBigEditor1.TabIndex = 4;
            // 
            // Form_VanPhongPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 271);
            this.Controls.Add(this.radTextBox3);
            this.Controls.Add(this.richTextBoxWithBigEditor1);
            this.Controls.Add(this.radDonVi);
            this.Controls.Add(this.radTen);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "Form_VanPhongPham";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Quản lý văn phòng phẩm";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.Form_VanPhongPham_Load_1);
            this.Controls.SetChildIndex(this.radLabel1, 0);
            this.Controls.SetChildIndex(this.radLabel2, 0);
            this.Controls.SetChildIndex(this.radLabel3, 0);
            this.Controls.SetChildIndex(this.radLabel4, 0);
            this.Controls.SetChildIndex(this.radTen, 0);
            this.Controls.SetChildIndex(this.radDonVi, 0);
            this.Controls.SetChildIndex(this.richTextBoxWithBigEditor1, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.radTextBox3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDonVi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource radBindingSource;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox radTen;
        private Telerik.WinControls.UI.RadTextBox radDonVi;
        private Telerik.WinControls.UI.RadTextBox radTextBox3;
        private NETLINK.UI.RichTextBoxWithBigEditor richTextBoxWithBigEditor1;
    }
}
