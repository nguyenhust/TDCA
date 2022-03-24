namespace ModuleDaoTao.UI
{
    partial class Form_NCKH_NghienCuuKhoaHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_NCKH_NghienCuuKhoaHoc));
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.bindingSourceMain = new System.Windows.Forms.BindingSource(this.components);
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.richTextBoxWithBigEditorGhichu = new NETLINK.UI.RichTextBoxWithBigEditor();
            this.dropDownCanBo1 = new DanhMuc.UserControl.DropDownCanBo();
            this.errorProvider_NCKH = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownCanBo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownCanBo1.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownCanBo1.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_NCKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(68, 206);
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(204, 206);
            this.btnClose.Size = new System.Drawing.Size(130, 34);
            this.btnClose.TabIndex = 5;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(13, 13);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(64, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Tên đề tài : ";
            // 
            // radTextBox1
            // 
            this.radTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMain, "TenDeTai", true));
            this.radTextBox1.Location = new System.Drawing.Point(112, 13);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(291, 20);
            this.radTextBox1.TabIndex = 0;
            this.radTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.radTextBox1_Validating);
            // 
            // bindingSourceMain
            // 
            this.bindingSourceMain.DataSource = typeof(ModuleDaoTao.LIB.DT_NghienCuuKhoaHoc);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(13, 37);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(93, 18);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Người thực hiện :";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(13, 61);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(82, 18);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Ngày kết thúc :";
            // 
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceMain, "NgayKetThuc", true));
            this.radDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMain, "NgayKetThuc", true));
            this.radDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.radDateTimePicker1.Location = new System.Drawing.Point(112, 61);
            this.radDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.radDateTimePicker1.MinDate = new System.DateTime(((long)(0)));
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.NullableValue = new System.DateTime(2014, 5, 14, 16, 5, 22, 313);
            this.radDateTimePicker1.NullDate = new System.DateTime(((long)(0)));
            this.radDateTimePicker1.Size = new System.Drawing.Size(291, 20);
            this.radDateTimePicker1.TabIndex = 2;
            this.radDateTimePicker1.Text = "Wednesday, May 14, 2014";
            this.radDateTimePicker1.Value = new System.DateTime(2014, 5, 14, 16, 5, 22, 313);
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(13, 88);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(50, 18);
            this.radLabel4.TabIndex = 5;
            this.radLabel4.Text = "Ghi chú :";
            // 
            // richTextBoxWithBigEditorGhichu
            // 
            this.richTextBoxWithBigEditorGhichu.Enable = true;
            this.richTextBoxWithBigEditorGhichu.Location = new System.Drawing.Point(112, 88);
            this.richTextBoxWithBigEditorGhichu.MaxLength = 2147483647;
            this.richTextBoxWithBigEditorGhichu.Name = "richTextBoxWithBigEditorGhichu";
            this.richTextBoxWithBigEditorGhichu.Size = new System.Drawing.Size(291, 89);
            this.richTextBoxWithBigEditorGhichu.TabIndex = 3;
            // 
            // dropDownCanBo1
            // 
            this.dropDownCanBo1.DanhMucCotHienThi = ((System.Collections.Generic.List<string>)(resources.GetObject("dropDownCanBo1.DanhMucCotHienThi")));
            // 
            // dropDownCanBo1.NestedRadGridView
            // 
            this.dropDownCanBo1.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.dropDownCanBo1.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownCanBo1.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dropDownCanBo1.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.dropDownCanBo1.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.dropDownCanBo1.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.dropDownCanBo1.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.dropDownCanBo1.EditorControl.MasterTemplate.EnableGrouping = false;
            this.dropDownCanBo1.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.dropDownCanBo1.EditorControl.Name = "NestedRadGridView";
            this.dropDownCanBo1.EditorControl.ReadOnly = true;
            this.dropDownCanBo1.EditorControl.ShowGroupPanel = false;
            this.dropDownCanBo1.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.dropDownCanBo1.EditorControl.TabIndex = 0;
            this.dropDownCanBo1.Location = new System.Drawing.Point(113, 37);
            this.dropDownCanBo1.Name = "dropDownCanBo1";
            this.dropDownCanBo1.NullText = "Chọn Cán bộ";
            // 
            // 
            // 
            this.dropDownCanBo1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.dropDownCanBo1.Selected_ID = null;
            this.dropDownCanBo1.Selected_TextValue = null;
            this.dropDownCanBo1.Size = new System.Drawing.Size(291, 20);
            this.dropDownCanBo1.TabIndex = 1;
            this.dropDownCanBo1.TenTuongUng = ((System.Collections.Generic.List<string>)(resources.GetObject("dropDownCanBo1.TenTuongUng")));
            // 
            // errorProvider_NCKH
            // 
            this.errorProvider_NCKH.ContainerControl = this;
            // 
            // Form_NCKH_NghienCuuKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 270);
            this.Controls.Add(this.dropDownCanBo1);
            this.Controls.Add(this.richTextBoxWithBigEditorGhichu);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radDateTimePicker1);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radTextBox1);
            this.Controls.Add(this.radLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "Form_NCKH_NghienCuuKhoaHoc";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Quản lý đề tài nghiên cứu khoa học";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.Form_NCKH_NghienCuuKhoaHoc_Load);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.radLabel1, 0);
            this.Controls.SetChildIndex(this.radTextBox1, 0);
            this.Controls.SetChildIndex(this.radLabel2, 0);
            this.Controls.SetChildIndex(this.radLabel3, 0);
            this.Controls.SetChildIndex(this.radDateTimePicker1, 0);
            this.Controls.SetChildIndex(this.radLabel4, 0);
            this.Controls.SetChildIndex(this.richTextBoxWithBigEditorGhichu, 0);
            this.Controls.SetChildIndex(this.dropDownCanBo1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownCanBo1.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownCanBo1.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownCanBo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_NCKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private NETLINK.UI.RichTextBoxWithBigEditor richTextBoxWithBigEditorGhichu;
        private DanhMuc.UserControl.DropDownCanBo dropDownCanBo1;
        private System.Windows.Forms.BindingSource bindingSourceMain;
        private System.Windows.Forms.ErrorProvider errorProvider_NCKH;
    }
}
