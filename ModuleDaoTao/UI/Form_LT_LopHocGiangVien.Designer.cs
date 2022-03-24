namespace ModuleDaoTao.UI
{
    partial class Form_LT_LopHocGiangVien
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.richTextBoxWithBigEditor1 = new NETLINK.UI.RichTextBoxWithBigEditor();
            this.radDropChuyenKhoa = new Telerik.WinControls.UI.RadDropDownList();
            this.radDropGiangVien = new Telerik.WinControls.UI.RadDropDownList();
            this.bindGiangVien = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropChuyenKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(181, 228);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(328, 228);
            this.btnClose.Size = new System.Drawing.Size(130, 34);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radLabel1.Location = new System.Drawing.Point(21, 65);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(74, 20);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "Giảng viên :";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radLabel3.Location = new System.Drawing.Point(21, 27);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(88, 20);
            this.radLabel3.TabIndex = 6;
            this.radLabel3.Text = "Chuyên khoa :";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radLabel5.Location = new System.Drawing.Point(21, 105);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(57, 20);
            this.radLabel5.TabIndex = 7;
            this.radLabel5.Text = "Ghi chú :";
            // 
            // richTextBoxWithBigEditor1
            // 
            this.richTextBoxWithBigEditor1.Enable = true;
            this.richTextBoxWithBigEditor1.Location = new System.Drawing.Point(117, 105);
            this.richTextBoxWithBigEditor1.MaxLength = 2147483647;
            this.richTextBoxWithBigEditor1.Name = "richTextBoxWithBigEditor1";
            this.richTextBoxWithBigEditor1.Size = new System.Drawing.Size(479, 82);
            this.richTextBoxWithBigEditor1.TabIndex = 10;
            // 
            // radDropChuyenKhoa
            // 
            this.radDropChuyenKhoa.AllowShowFocusCues = false;
            this.radDropChuyenKhoa.AutoCompleteDisplayMember = null;
            this.radDropChuyenKhoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.radDropChuyenKhoa.AutoCompleteValueMember = null;
            this.radDropChuyenKhoa.DisplayMember = "Ten";
            this.radDropChuyenKhoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDropChuyenKhoa.Location = new System.Drawing.Point(117, 27);
            this.radDropChuyenKhoa.Name = "radDropChuyenKhoa";
            this.radDropChuyenKhoa.NullText = "Chọn chuyên khoa";
            this.radDropChuyenKhoa.Size = new System.Drawing.Size(479, 23);
            this.radDropChuyenKhoa.TabIndex = 12;
            this.radDropChuyenKhoa.ValueMember = "ID";
            this.radDropChuyenKhoa.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropChuyenKhoa_SelectedIndexChanged);
            // 
            // radDropGiangVien
            // 
            this.radDropGiangVien.AllowShowFocusCues = false;
            this.radDropGiangVien.AutoCompleteDisplayMember = null;
            this.radDropGiangVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.radDropGiangVien.AutoCompleteValueMember = null;
            this.radDropGiangVien.DisplayMember = "HoTen";
            this.radDropGiangVien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDropGiangVien.Location = new System.Drawing.Point(117, 65);
            this.radDropGiangVien.Name = "radDropGiangVien";
            this.radDropGiangVien.NullText = "Chọn giảng viên";
            this.radDropGiangVien.Size = new System.Drawing.Size(479, 23);
            this.radDropGiangVien.TabIndex = 13;
            this.radDropGiangVien.ValueMember = "IDGiangVien";
            // 
            // bindGiangVien
            // 
            this.bindGiangVien.DataSource = typeof(DanhMuc.LIB.DIC_GiangVien_Coll);
            // 
            // Form_LT_LopHocGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 293);
            this.Controls.Add(this.radDropGiangVien);
            this.Controls.Add(this.radDropChuyenKhoa);
            this.Controls.Add(this.richTextBoxWithBigEditor1);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "Form_LT_LopHocGiangVien";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Lớp học - Giảng viên";
            this.ThemeName = "ControlDefault";
            this.Controls.SetChildIndex(this.radLabel1, 0);
            this.Controls.SetChildIndex(this.radLabel3, 0);
            this.Controls.SetChildIndex(this.radLabel5, 0);
            this.Controls.SetChildIndex(this.richTextBoxWithBigEditor1, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.radDropChuyenKhoa, 0);
            this.Controls.SetChildIndex(this.radDropGiangVien, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropChuyenKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private NETLINK.UI.RichTextBoxWithBigEditor richTextBoxWithBigEditor1;
        private System.Windows.Forms.BindingSource bindGiangVien;
        private Telerik.WinControls.UI.RadDropDownList radDropChuyenKhoa;
        private Telerik.WinControls.UI.RadDropDownList radDropGiangVien;
    }
}
