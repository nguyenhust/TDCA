namespace TDCA.Report.BaoCaoForm
{
    partial class frmHocVienDongHocPhi_DTLT
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem6 = new Telerik.WinControls.UI.RadListDataItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHinhThucHoc = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.radHinhThuc = new Telerik.WinControls.UI.RadDropDownList();
            this.lblChuyenKhoa = new System.Windows.Forms.Label();
            this.lblLopHoc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dropDownLopHocLienTucKhung1 = new ModuleDaoTao.UserControls.DropDownLopHocLienTucKhung();
            this.dropDownChuyenKhoa1 = new DanhMuc.UserControl.DropDownChuyenKhoa();
            this.rdbExcel = new Telerik.WinControls.UI.RadRadioButton();
            this.rdbPDF = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.radHinhThuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownLopHocLienTucKhung1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownLopHocLienTucKhung1.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownLopHocLienTucKhung1.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownChuyenKhoa1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownChuyenKhoa1.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownChuyenKhoa1.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ Ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến Ngày:";
            // 
            // lblHinhThucHoc
            // 
            this.lblHinhThucHoc.AutoSize = true;
            this.lblHinhThucHoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHinhThucHoc.Location = new System.Drawing.Point(11, 128);
            this.lblHinhThucHoc.Name = "lblHinhThucHoc";
            this.lblHinhThucHoc.Size = new System.Drawing.Size(94, 15);
            this.lblHinhThucHoc.TabIndex = 2;
            this.lblHinhThucHoc.Text = "Hình Thức Học:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(120, 18);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(121, 22);
            this.dtpTuNgay.TabIndex = 4;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(120, 54);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(121, 22);
            this.dtpDenNgay.TabIndex = 5;
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXuat.Enabled = false;
            this.btnXuat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.Location = new System.Drawing.Point(27, 241);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(122, 40);
            this.btnXuat.TabIndex = 8;
            this.btnXuat.Text = "Xuất Báo Cáo";
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(177, 241);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(122, 40);
            this.btnQuayLai.TabIndex = 9;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // radHinhThuc
            // 
            this.radHinhThuc.AllowShowFocusCues = false;
            this.radHinhThuc.AutoCompleteDisplayMember = null;
            this.radHinhThuc.AutoCompleteValueMember = null;
            this.radHinhThuc.AutoSize = false;
            this.radHinhThuc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radListDataItem4.Text = "Tất cả học viên";
            radListDataItem4.TextWrap = true;
            radListDataItem5.Text = "Học viên kèm cặp";
            radListDataItem5.TextWrap = true;
            radListDataItem6.Text = "Học viên theo lớp";
            radListDataItem6.TextWrap = true;
            this.radHinhThuc.Items.Add(radListDataItem4);
            this.radHinhThuc.Items.Add(radListDataItem5);
            this.radHinhThuc.Items.Add(radListDataItem6);
            this.radHinhThuc.Location = new System.Drawing.Point(120, 123);
            this.radHinhThuc.Name = "radHinhThuc";
            this.radHinhThuc.NullText = "Chọn một hình thức học";
            this.radHinhThuc.Size = new System.Drawing.Size(179, 25);
            this.radHinhThuc.TabIndex = 10;
            this.radHinhThuc.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radHinhThuc_SelectedIndexChanged);
            // 
            // lblChuyenKhoa
            // 
            this.lblChuyenKhoa.AutoSize = true;
            this.lblChuyenKhoa.Enabled = false;
            this.lblChuyenKhoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuyenKhoa.Location = new System.Drawing.Point(13, 166);
            this.lblChuyenKhoa.Name = "lblChuyenKhoa";
            this.lblChuyenKhoa.Size = new System.Drawing.Size(84, 15);
            this.lblChuyenKhoa.TabIndex = 11;
            this.lblChuyenKhoa.Text = "Chuyên Khoa:";
            // 
            // lblLopHoc
            // 
            this.lblLopHoc.AutoSize = true;
            this.lblLopHoc.Enabled = false;
            this.lblLopHoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLopHoc.Location = new System.Drawing.Point(11, 205);
            this.lblLopHoc.Name = "lblLopHoc";
            this.lblLopHoc.Size = new System.Drawing.Size(88, 15);
            this.lblLopHoc.TabIndex = 12;
            this.lblLopHoc.Text = "Chọn Lớp Học:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dạng File:";
            // 
            // dropDownLopHocLienTucKhung1
            // 
            // 
            // dropDownLopHocLienTucKhung1.NestedRadGridView
            // 
            this.dropDownLopHocLienTucKhung1.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.dropDownLopHocLienTucKhung1.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownLopHocLienTucKhung1.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dropDownLopHocLienTucKhung1.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.dropDownLopHocLienTucKhung1.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.dropDownLopHocLienTucKhung1.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.dropDownLopHocLienTucKhung1.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.dropDownLopHocLienTucKhung1.EditorControl.MasterTemplate.EnableGrouping = false;
            this.dropDownLopHocLienTucKhung1.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.dropDownLopHocLienTucKhung1.EditorControl.Name = "NestedRadGridView";
            this.dropDownLopHocLienTucKhung1.EditorControl.ReadOnly = true;
            this.dropDownLopHocLienTucKhung1.EditorControl.ShowGroupPanel = false;
            this.dropDownLopHocLienTucKhung1.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.dropDownLopHocLienTucKhung1.EditorControl.TabIndex = 0;
            this.dropDownLopHocLienTucKhung1.Enabled = false;
            this.dropDownLopHocLienTucKhung1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownLopHocLienTucKhung1.Location = new System.Drawing.Point(120, 200);
            this.dropDownLopHocLienTucKhung1.Name = "dropDownLopHocLienTucKhung1";
            this.dropDownLopHocLienTucKhung1.NullText = "Chọn Lớp Học";
            // 
            // 
            // 
            this.dropDownLopHocLienTucKhung1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.dropDownLopHocLienTucKhung1.Selected_ID = null;
            this.dropDownLopHocLienTucKhung1.Selected_TextValue = null;
            this.dropDownLopHocLienTucKhung1.Size = new System.Drawing.Size(179, 25);
            this.dropDownLopHocLienTucKhung1.TabIndex = 14;
            this.dropDownLopHocLienTucKhung1.TabStop = false;
            this.dropDownLopHocLienTucKhung1.SelectedIndexChanged += new System.EventHandler(this.dropDownLopHocLienTucKhung1_SelectedIndexChanged);
            // 
            // dropDownChuyenKhoa1
            // 
            // 
            // dropDownChuyenKhoa1.NestedRadGridView
            // 
            this.dropDownChuyenKhoa1.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.dropDownChuyenKhoa1.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownChuyenKhoa1.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dropDownChuyenKhoa1.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.dropDownChuyenKhoa1.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.dropDownChuyenKhoa1.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.dropDownChuyenKhoa1.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.dropDownChuyenKhoa1.EditorControl.MasterTemplate.EnableGrouping = false;
            this.dropDownChuyenKhoa1.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.dropDownChuyenKhoa1.EditorControl.Name = "NestedRadGridView";
            this.dropDownChuyenKhoa1.EditorControl.ReadOnly = true;
            this.dropDownChuyenKhoa1.EditorControl.ShowGroupPanel = false;
            this.dropDownChuyenKhoa1.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.dropDownChuyenKhoa1.EditorControl.TabIndex = 0;
            this.dropDownChuyenKhoa1.Enabled = false;
            this.dropDownChuyenKhoa1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownChuyenKhoa1.Location = new System.Drawing.Point(120, 161);
            this.dropDownChuyenKhoa1.Name = "dropDownChuyenKhoa1";
            this.dropDownChuyenKhoa1.NullText = "Chọn Chuyên Khoa";
            this.dropDownChuyenKhoa1.Selected_ID = null;
            this.dropDownChuyenKhoa1.Selected_TextValue = null;
            this.dropDownChuyenKhoa1.Size = new System.Drawing.Size(179, 25);
            this.dropDownChuyenKhoa1.TabIndex = 13;
            this.dropDownChuyenKhoa1.TabStop = false;
            this.dropDownChuyenKhoa1.SelectedIndexChanged += new System.EventHandler(this.dropDownChuyenKhoa1_SelectedIndexChanged);
            // 
            // rdbExcel
            // 
            this.rdbExcel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.rdbExcel.Location = new System.Drawing.Point(222, 91);
            this.rdbExcel.Name = "rdbExcel";
            this.rdbExcel.Size = new System.Drawing.Size(77, 18);
            this.rdbExcel.TabIndex = 20;
            this.rdbExcel.Text = "File Excel";
            // 
            // rdbPDF
            // 
            this.rdbPDF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rdbPDF.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.rdbPDF.Location = new System.Drawing.Point(120, 91);
            this.rdbPDF.Name = "rdbPDF";
            this.rdbPDF.Size = new System.Drawing.Size(72, 18);
            this.rdbPDF.TabIndex = 21;
            this.rdbPDF.TabStop = true;
            this.rdbPDF.Text = "File PDF";
            this.rdbPDF.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // frmHocVienDongHocPhi_DTLT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 289);
            this.Controls.Add(this.rdbPDF);
            this.Controls.Add(this.rdbExcel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dropDownLopHocLienTucKhung1);
            this.Controls.Add(this.dropDownChuyenKhoa1);
            this.Controls.Add(this.lblLopHoc);
            this.Controls.Add(this.lblChuyenKhoa);
            this.Controls.Add(this.radHinhThuc);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.lblHinhThucHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(349, 328);
            this.MinimumSize = new System.Drawing.Size(349, 328);
            this.Name = "frmHocVienDongHocPhi_DTLT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Báo cáo học viên đóng học phí";
            this.Load += new System.EventHandler(this.frmHocVienDongHocPhi_DTLT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radHinhThuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownLopHocLienTucKhung1.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownLopHocLienTucKhung1.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownLopHocLienTucKhung1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownChuyenKhoa1.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownChuyenKhoa1.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownChuyenKhoa1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbPDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHinhThucHoc;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnQuayLai;
        private Telerik.WinControls.UI.RadDropDownList radHinhThuc;
        private System.Windows.Forms.Label lblChuyenKhoa;
        private System.Windows.Forms.Label lblLopHoc;
        private DanhMuc.UserControl.DropDownChuyenKhoa dropDownChuyenKhoa1;
        private ModuleDaoTao.UserControls.DropDownLopHocLienTucKhung dropDownLopHocLienTucKhung1;
        private System.Windows.Forms.Label label6;
        private Telerik.WinControls.UI.RadRadioButton rdbExcel;
        private Telerik.WinControls.UI.RadRadioButton rdbPDF;
    }
}