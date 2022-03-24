namespace ModuleDaoTao.UI
{
    partial class Form_DA_DuAn
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
            this.bindingSourceMain = new System.Windows.Forms.BindingSource(this.components);
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.richTextBoxWithBigEditorNoiDung = new NETLINK.UI.RichTextBoxWithBigEditor();
            this.radDateTimePicker2 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox2 = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox3 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.dropDownCanBo = new DanhMuc.UserControl.DropDownCanBo();
            this.errorProvider_Duan = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownCanBo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownCanBo.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownCanBo.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Duan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(72, 278);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(208, 278);
            this.btnClose.Size = new System.Drawing.Size(130, 34);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(13, 13);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(62, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Tên đự án :";
            // 
            // radTextBox1
            // 
            this.radTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMain, "TenDuAn", true));
            this.radTextBox1.Location = new System.Drawing.Point(112, 13);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(291, 20);
            this.radTextBox1.TabIndex = 3;
            this.radTextBox1.TabStop = true;
            this.radTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.radTextBox1_Validating);
            // 
            // bindingSourceMain
            // 
            this.bindingSourceMain.DataSource = typeof(ModuleDaoTao.LIB.DT_DuAn);
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
            this.radLabel3.Size = new System.Drawing.Size(79, 18);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Ngày bắt đầu :";
            // 
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMain, "NgayBatDau", true));
            this.radDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceMain, "NgayBatDau", true));
            this.radDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.radDateTimePicker1.Location = new System.Drawing.Point(112, 61);
            this.radDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.radDateTimePicker1.MinDate = new System.DateTime(((long)(0)));
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.NullableValue = new System.DateTime(2014, 5, 14, 16, 5, 22, 313);
            this.radDateTimePicker1.NullDate = new System.DateTime(((long)(0)));
            this.radDateTimePicker1.Size = new System.Drawing.Size(291, 20);
            this.radDateTimePicker1.TabIndex = 5;
            this.radDateTimePicker1.TabStop = true;
            this.radDateTimePicker1.Text = "Wednesday, May 14, 2014";
            this.radDateTimePicker1.Value = new System.DateTime(2014, 5, 14, 16, 5, 22, 313);
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(13, 161);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(59, 18);
            this.radLabel4.TabIndex = 5;
            this.radLabel4.Text = "Nội dung :";
            // 
            // richTextBoxWithBigEditorNoiDung
            // 
            this.richTextBoxWithBigEditorNoiDung.Location = new System.Drawing.Point(112, 161);
            this.richTextBoxWithBigEditorNoiDung.MaxLength = 2147483647;
            this.richTextBoxWithBigEditorNoiDung.Name = "richTextBoxWithBigEditorNoiDung";
            this.richTextBoxWithBigEditorNoiDung.Size = new System.Drawing.Size(291, 89);
            this.richTextBoxWithBigEditorNoiDung.TabIndex = 7;
            // 
            // radDateTimePicker2
            // 
            this.radDateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMain, "NgayKetThuc", true));
            this.radDateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceMain, "NgayKetThuc", true));
            this.radDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.radDateTimePicker2.Location = new System.Drawing.Point(112, 85);
            this.radDateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.radDateTimePicker2.MinDate = new System.DateTime(((long)(0)));
            this.radDateTimePicker2.Name = "radDateTimePicker2";
            this.radDateTimePicker2.NullableValue = new System.DateTime(2014, 5, 14, 16, 5, 22, 313);
            this.radDateTimePicker2.NullDate = new System.DateTime(((long)(0)));
            this.radDateTimePicker2.Size = new System.Drawing.Size(291, 20);
            this.radDateTimePicker2.TabIndex = 9;
            this.radDateTimePicker2.TabStop = true;
            this.radDateTimePicker2.Text = "Wednesday, May 14, 2014";
            this.radDateTimePicker2.Value = new System.DateTime(2014, 5, 14, 16, 5, 22, 313);
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(13, 85);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(82, 18);
            this.radLabel5.TabIndex = 8;
            this.radLabel5.Text = "Ngày kết thúc :";
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(13, 109);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(90, 18);
            this.radLabel6.TabIndex = 9;
            this.radLabel6.Text = "Nguồn kinh phí :";
            // 
            // radTextBox2
            // 
            this.radTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMain, "NguonKinhPhi", true));
            this.radTextBox2.Location = new System.Drawing.Point(112, 111);
            this.radTextBox2.Name = "radTextBox2";
            this.radTextBox2.Size = new System.Drawing.Size(291, 20);
            this.radTextBox2.TabIndex = 4;
            this.radTextBox2.TabStop = true;
            this.radTextBox2.Validating += new System.ComponentModel.CancelEventHandler(this.radTextBox2_Validating);
            // 
            // radTextBox3
            // 
            this.radTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMain, "TongKinhPhi", true));
            this.radTextBox3.Location = new System.Drawing.Point(112, 135);
            this.radTextBox3.Name = "radTextBox3";
            this.radTextBox3.Size = new System.Drawing.Size(291, 20);
            this.radTextBox3.TabIndex = 10;
            this.radTextBox3.TabStop = true;
            this.radTextBox3.Validating += new System.ComponentModel.CancelEventHandler(this.radTextBox3_Validating);
            // 
            // radLabel7
            // 
            this.radLabel7.Location = new System.Drawing.Point(12, 133);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(81, 18);
            this.radLabel7.TabIndex = 11;
            this.radLabel7.Text = "Tổng kinh phí :";
            // 
            // dropDownCanBo
            // 
            // 
            // dropDownCanBo.NestedRadGridView
            // 
            this.dropDownCanBo.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.dropDownCanBo.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownCanBo.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dropDownCanBo.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.dropDownCanBo.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.dropDownCanBo.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.dropDownCanBo.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.dropDownCanBo.EditorControl.MasterTemplate.EnableGrouping = false;
            this.dropDownCanBo.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.dropDownCanBo.EditorControl.Name = "NestedRadGridView";
            this.dropDownCanBo.EditorControl.ReadOnly = true;
            this.dropDownCanBo.EditorControl.ShowGroupPanel = false;
            this.dropDownCanBo.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.dropDownCanBo.EditorControl.TabIndex = 0;
            this.dropDownCanBo.Location = new System.Drawing.Point(113, 37);
            this.dropDownCanBo.Name = "dropDownCanBo";
            this.dropDownCanBo.NullText = "Chọn Cán bộ";
            // 
            // 
            // 
            this.dropDownCanBo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.dropDownCanBo.Selected_ID = null;
            this.dropDownCanBo.Selected_TextValue = null;
            this.dropDownCanBo.Size = new System.Drawing.Size(291, 20);
            this.dropDownCanBo.TabIndex = 12;
            this.dropDownCanBo.TabStop = true;
            // 
            // errorProvider_Duan
            // 
            this.errorProvider_Duan.ContainerControl = this;
            // 
            // Form_DA_DuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 333);
            this.Controls.Add(this.dropDownCanBo);
            this.Controls.Add(this.radTextBox3);
            this.Controls.Add(this.radLabel7);
            this.Controls.Add(this.radTextBox2);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radDateTimePicker2);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.richTextBoxWithBigEditorNoiDung);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radDateTimePicker1);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radTextBox1);
            this.Controls.Add(this.radLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "Form_DA_DuAn";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Quản lý dự án";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.Form_DA_DuAn_Load);
            this.Controls.SetChildIndex(this.radLabel1, 0);
            this.Controls.SetChildIndex(this.radTextBox1, 0);
            this.Controls.SetChildIndex(this.radLabel2, 0);
            this.Controls.SetChildIndex(this.radLabel3, 0);
            this.Controls.SetChildIndex(this.radDateTimePicker1, 0);
            this.Controls.SetChildIndex(this.radLabel4, 0);
            this.Controls.SetChildIndex(this.richTextBoxWithBigEditorNoiDung, 0);
            this.Controls.SetChildIndex(this.radLabel5, 0);
            this.Controls.SetChildIndex(this.radDateTimePicker2, 0);
            this.Controls.SetChildIndex(this.radLabel6, 0);
            this.Controls.SetChildIndex(this.radTextBox2, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.radLabel7, 0);
            this.Controls.SetChildIndex(this.radTextBox3, 0);
            this.Controls.SetChildIndex(this.dropDownCanBo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownCanBo.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownCanBo.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownCanBo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Duan)).EndInit();
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
        private NETLINK.UI.RichTextBoxWithBigEditor richTextBoxWithBigEditorNoiDung;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker2;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadTextBox radTextBox2;
        private Telerik.WinControls.UI.RadTextBox radTextBox3;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private DanhMuc.UserControl.DropDownCanBo dropDownCanBo;
        private System.Windows.Forms.BindingSource bindingSourceMain;
        private System.Windows.Forms.ErrorProvider errorProvider_Duan;
    }
}
