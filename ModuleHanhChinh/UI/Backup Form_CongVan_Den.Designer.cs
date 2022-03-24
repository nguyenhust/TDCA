namespace ModuleHanhChinh.UI
{
    partial class BackupForm_CongVan_Den
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
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radtxtVeVanDe = new NETLINK.UI.RichTextBoxWithBigEditor();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radtxtNoiDung = new NETLINK.UI.RichTextBoxWithBigEditor();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox2 = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox3 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.radtxtHuongGiaiQuyet = new NETLINK.UI.RichTextBoxWithBigEditor();
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel11 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox4 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel12 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox5 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel13 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox6 = new Telerik.WinControls.UI.RadTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dropDownCapQuanLy1 = new ModuleHanhChinh.UserControl.DropDownCapQuanLy();
            this.dropDownLoaiCongVan1 = new ModuleHanhChinh.UserControl.DropDownLoaiCongVan();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownCapQuanLy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownLoaiCongVan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(176, 377);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(312, 377);
            this.btnClose.Size = new System.Drawing.Size(130, 34);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(73, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Số công văn :";
            // 
            // radTextBox1
            // 
            this.radTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radBindingSource, "SoCongVan", true));
            this.radTextBox1.Location = new System.Drawing.Point(120, 12);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(186, 20);
            this.radTextBox1.TabIndex = 3;
            this.radTextBox1.TabStop = true;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(312, 219);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(89, 18);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Ngày tiếp nhận :";
            // 
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.radDateTimePicker1.Location = new System.Drawing.Point(407, 12);
            this.radDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.radDateTimePicker1.MinDate = new System.DateTime(((long)(0)));
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.NullableValue = new System.DateTime(2014, 5, 15, 11, 35, 47, 585);
            this.radDateTimePicker1.NullDate = new System.DateTime(((long)(0)));
            this.radDateTimePicker1.Size = new System.Drawing.Size(186, 20);
            this.radDateTimePicker1.TabIndex = 4;
            this.radDateTimePicker1.TabStop = true;
            this.radDateTimePicker1.Text = "15 May 2014";
            this.radDateTimePicker1.Value = new System.DateTime(2014, 5, 15, 11, 35, 47, 585);
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(12, 64);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(61, 18);
            this.radLabel3.TabIndex = 3;
            this.radLabel3.Text = "Về vấn đề :";
            // 
            // radtxtVeVanDe
            // 
            this.radtxtVeVanDe.Location = new System.Drawing.Point(120, 64);
            this.radtxtVeVanDe.MaxLength = 2147483647;
            this.radtxtVeVanDe.Name = "radtxtVeVanDe";
            this.radtxtVeVanDe.Size = new System.Drawing.Size(473, 45);
            this.radtxtVeVanDe.TabIndex = 5;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(12, 115);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(81, 18);
            this.radLabel4.TabIndex = 3;
            this.radLabel4.Text = "Loại công văn :";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(312, 115);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(71, 18);
            this.radLabel5.TabIndex = 4;
            this.radLabel5.Text = "Cấp quản lý :";
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(12, 139);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(59, 18);
            this.radLabel6.TabIndex = 4;
            this.radLabel6.Text = "Nội dung :";
            // 
            // radtxtNoiDung
            // 
            this.radtxtNoiDung.Location = new System.Drawing.Point(120, 142);
            this.radtxtNoiDung.MaxLength = 2147483647;
            this.radtxtNoiDung.Name = "radtxtNoiDung";
            this.radtxtNoiDung.Size = new System.Drawing.Size(473, 45);
            this.radtxtNoiDung.TabIndex = 8;
            // 
            // radLabel7
            // 
            this.radLabel7.Location = new System.Drawing.Point(12, 219);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(71, 18);
            this.radLabel7.TabIndex = 5;
            this.radLabel7.Text = "Người nhận :";
            // 
            // radTextBox2
            // 
            this.radTextBox2.Location = new System.Drawing.Point(120, 219);
            this.radTextBox2.Name = "radTextBox2";
            this.radTextBox2.Size = new System.Drawing.Size(186, 20);
            this.radTextBox2.TabIndex = 4;
            this.radTextBox2.TabStop = true;
            // 
            // radTextBox3
            // 
            this.radTextBox3.Location = new System.Drawing.Point(407, 219);
            this.radTextBox3.Name = "radTextBox3";
            this.radTextBox3.Size = new System.Drawing.Size(186, 20);
            this.radTextBox3.TabIndex = 5;
            this.radTextBox3.TabStop = true;
            // 
            // radLabel8
            // 
            this.radLabel8.Location = new System.Drawing.Point(312, 12);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(38, 18);
            this.radLabel8.TabIndex = 4;
            this.radLabel8.Text = "Ngày :";
            // 
            // radtxtHuongGiaiQuyet
            // 
            this.radtxtHuongGiaiQuyet.Location = new System.Drawing.Point(120, 271);
            this.radtxtHuongGiaiQuyet.MaxLength = 2147483647;
            this.radtxtHuongGiaiQuyet.Name = "radtxtHuongGiaiQuyet";
            this.radtxtHuongGiaiQuyet.Size = new System.Drawing.Size(473, 45);
            this.radtxtHuongGiaiQuyet.TabIndex = 9;
            // 
            // radLabel9
            // 
            this.radLabel9.Location = new System.Drawing.Point(12, 271);
            this.radLabel9.Name = "radLabel9";
            this.radLabel9.Size = new System.Drawing.Size(99, 18);
            this.radLabel9.TabIndex = 5;
            this.radLabel9.Text = "Hướng giải quyết :";
            // 
            // radLabel11
            // 
            this.radLabel11.Location = new System.Drawing.Point(12, 40);
            this.radLabel11.Name = "radLabel11";
            this.radLabel11.Size = new System.Drawing.Size(48, 18);
            this.radLabel11.TabIndex = 4;
            this.radLabel11.Text = "Tiêu đề :";
            // 
            // radTextBox4
            // 
            this.radTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radBindingSource, "TieuDe", true));
            this.radTextBox4.Location = new System.Drawing.Point(120, 38);
            this.radTextBox4.Name = "radTextBox4";
            this.radTextBox4.Size = new System.Drawing.Size(473, 20);
            this.radTextBox4.TabIndex = 4;
            this.radTextBox4.TabStop = true;
            // 
            // radLabel12
            // 
            this.radLabel12.Location = new System.Drawing.Point(12, 191);
            this.radLabel12.Name = "radLabel12";
            this.radLabel12.Size = new System.Drawing.Size(49, 18);
            this.radLabel12.TabIndex = 6;
            this.radLabel12.Text = "Nơi gửi :";
            // 
            // radTextBox5
            // 
            this.radTextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radBindingSource, "NoiGui", true));
            this.radTextBox5.Location = new System.Drawing.Point(120, 193);
            this.radTextBox5.Name = "radTextBox5";
            this.radTextBox5.Size = new System.Drawing.Size(473, 20);
            this.radTextBox5.TabIndex = 5;
            this.radTextBox5.TabStop = true;
            // 
            // radLabel13
            // 
            this.radLabel13.Location = new System.Drawing.Point(12, 243);
            this.radLabel13.Name = "radLabel13";
            this.radLabel13.Size = new System.Drawing.Size(63, 18);
            this.radLabel13.TabIndex = 6;
            this.radLabel13.Text = "Lưu trữ tại :";
            // 
            // radTextBox6
            // 
            this.radTextBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radBindingSource, "LuuTruTai", true));
            this.radTextBox6.Location = new System.Drawing.Point(120, 245);
            this.radTextBox6.Name = "radTextBox6";
            this.radTextBox6.Size = new System.Drawing.Size(347, 20);
            this.radTextBox6.TabIndex = 6;
            this.radTextBox6.TabStop = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(473, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Mở file gửi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // radBindingSource
            // 
            this.radBindingSource.DataSource = typeof(ModuleHanhChinh.LIB.HC_CongVanDi);
            // 
            // dropDownCapQuanLy1
            // 
            this.dropDownCapQuanLy1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radBindingSource, "CapQuanLy", true));
            this.dropDownCapQuanLy1.DropDownAnimationEnabled = true;
            this.dropDownCapQuanLy1.Location = new System.Drawing.Point(407, 116);
            this.dropDownCapQuanLy1.MaxDropDownItems = 0;
            this.dropDownCapQuanLy1.Name = "dropDownCapQuanLy1";
            this.dropDownCapQuanLy1.NullText = "Chọn cấp quản lý";
            this.dropDownCapQuanLy1.ShowImageInEditorArea = true;
            this.dropDownCapQuanLy1.Size = new System.Drawing.Size(186, 20);
            this.dropDownCapQuanLy1.TabIndex = 7;
            // 
            // dropDownLoaiCongVan1
            // 
            this.dropDownLoaiCongVan1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radBindingSource, "LoaiCongVan", true));
            this.dropDownLoaiCongVan1.DropDownAnimationEnabled = true;
            this.dropDownLoaiCongVan1.Location = new System.Drawing.Point(120, 116);
            this.dropDownLoaiCongVan1.MaxDropDownItems = 0;
            this.dropDownLoaiCongVan1.Name = "dropDownLoaiCongVan1";
            this.dropDownLoaiCongVan1.NullText = "Chọn loại công văn";
            this.dropDownLoaiCongVan1.ShowImageInEditorArea = true;
            this.dropDownLoaiCongVan1.Size = new System.Drawing.Size(186, 20);
            this.dropDownLoaiCongVan1.TabIndex = 6;
            // 
            // Form_CongVan_Den
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radTextBox6);
            this.Controls.Add(this.radLabel13);
            this.Controls.Add(this.radTextBox5);
            this.Controls.Add(this.radLabel12);
            this.Controls.Add(this.radTextBox4);
            this.Controls.Add(this.radLabel11);
            this.Controls.Add(this.radLabel9);
            this.Controls.Add(this.radtxtHuongGiaiQuyet);
            this.Controls.Add(this.radLabel8);
            this.Controls.Add(this.radTextBox3);
            this.Controls.Add(this.radTextBox2);
            this.Controls.Add(this.radLabel7);
            this.Controls.Add(this.radtxtNoiDung);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.dropDownCapQuanLy1);
            this.Controls.Add(this.dropDownLoaiCongVan1);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radtxtVeVanDe);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radDateTimePicker1);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radTextBox1);
            this.Controls.Add(this.radLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "Form_CongVan_Den";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Quản lý công văn đến";
            this.ThemeName = "ControlDefault";
            this.Controls.SetChildIndex(this.radLabel1, 0);
            this.Controls.SetChildIndex(this.radTextBox1, 0);
            this.Controls.SetChildIndex(this.radLabel2, 0);
            this.Controls.SetChildIndex(this.radDateTimePicker1, 0);
            this.Controls.SetChildIndex(this.radLabel3, 0);
            this.Controls.SetChildIndex(this.radtxtVeVanDe, 0);
            this.Controls.SetChildIndex(this.radLabel4, 0);
            this.Controls.SetChildIndex(this.dropDownLoaiCongVan1, 0);
            this.Controls.SetChildIndex(this.dropDownCapQuanLy1, 0);
            this.Controls.SetChildIndex(this.radLabel5, 0);
            this.Controls.SetChildIndex(this.radLabel6, 0);
            this.Controls.SetChildIndex(this.radtxtNoiDung, 0);
            this.Controls.SetChildIndex(this.radLabel7, 0);
            this.Controls.SetChildIndex(this.radTextBox2, 0);
            this.Controls.SetChildIndex(this.radTextBox3, 0);
            this.Controls.SetChildIndex(this.radLabel8, 0);
            this.Controls.SetChildIndex(this.radtxtHuongGiaiQuyet, 0);
            this.Controls.SetChildIndex(this.radLabel9, 0);
            this.Controls.SetChildIndex(this.radLabel11, 0);
            this.Controls.SetChildIndex(this.radTextBox4, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.radLabel12, 0);
            this.Controls.SetChildIndex(this.radTextBox5, 0);
            this.Controls.SetChildIndex(this.radLabel13, 0);
            this.Controls.SetChildIndex(this.radTextBox6, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownCapQuanLy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownLoaiCongVan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private NETLINK.UI.RichTextBoxWithBigEditor radtxtVeVanDe;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private UserControl.DropDownLoaiCongVan dropDownLoaiCongVan1;
        private UserControl.DropDownCapQuanLy dropDownCapQuanLy1;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private NETLINK.UI.RichTextBoxWithBigEditor radtxtNoiDung;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadTextBox radTextBox2;
        private Telerik.WinControls.UI.RadTextBox radTextBox3;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private NETLINK.UI.RichTextBoxWithBigEditor radtxtHuongGiaiQuyet;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        private Telerik.WinControls.UI.RadLabel radLabel11;
        private Telerik.WinControls.UI.RadTextBox radTextBox4;
        private Telerik.WinControls.UI.RadLabel radLabel12;
        private Telerik.WinControls.UI.RadTextBox radTextBox5;
        private Telerik.WinControls.UI.RadLabel radLabel13;
        private Telerik.WinControls.UI.RadTextBox radTextBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource radBindingSource;
    }
}
