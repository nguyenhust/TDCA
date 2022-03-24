namespace TruyenThong.UI
{
    partial class BaiViet
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
            this.txtnguoiduyet = new Telerik.WinControls.UI.RadTextBoxControl();
            this.Open = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.txtLink = new Telerik.WinControls.UI.RadTextBox();
            this.txttacgia = new Telerik.WinControls.UI.RadTextBox();
            this.txtTieuDe = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel10 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtnoidung = new NETLINK.UI.RichTextBoxWithBigEditor();
            this.ngaydang = new NETLINK.UI.netLink_DatePicker();
            this.dropDownLoai1 = new DanhMuc.UserControl.DropDownLoai();
            this.ngayduyet = new NETLINK.UI.netLink_DatePicker();
            this.radBrowseEditor1 = new Telerik.WinControls.UI.RadBrowseEditor();
            this.txtghichu = new NETLINK.UI.RichTextBoxWithBigEditor();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnguoiduyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttacgia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTieuDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaydang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownLoai1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownLoai1.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownLoai1.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayduyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBrowseEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(259, 430);
            this.btnSave.TabIndex = 13;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(395, 430);
            this.btnClose.Size = new System.Drawing.Size(130, 34);
            this.btnClose.TabIndex = 14;
            // 
            // txtnguoiduyet
            // 
            this.txtnguoiduyet.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtnguoiduyet.Location = new System.Drawing.Point(109, 236);
            this.txtnguoiduyet.Name = "txtnguoiduyet";
            this.txtnguoiduyet.Size = new System.Drawing.Size(257, 24);
            this.txtnguoiduyet.TabIndex = 6;
            // 
            // Open
            // 
            this.Open.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Open.Location = new System.Drawing.Point(589, 295);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(128, 24);
            this.Open.TabIndex = 11;
            this.Open.Text = "Mở";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radButton1.Location = new System.Drawing.Point(589, 266);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(128, 24);
            this.radButton1.TabIndex = 9;
            this.radButton1.Text = "Truy cập bài viết";
            this.radButton1.Click += new System.EventHandler(this.Link_Click);
            // 
            // txtLink
            // 
            this.txtLink.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtLink.Location = new System.Drawing.Point(109, 266);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(474, 22);
            this.txtLink.TabIndex = 8;
            this.txtLink.TabStop = true;
            this.txtLink.TextChanged += new System.EventHandler(this.txtLink_TextChanged);
            // 
            // txttacgia
            // 
            this.txttacgia.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txttacgia.Location = new System.Drawing.Point(109, 182);
            this.txttacgia.Name = "txttacgia";
            this.txttacgia.Size = new System.Drawing.Size(257, 22);
            this.txttacgia.TabIndex = 3;
            this.txttacgia.TabStop = true;
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTieuDe.Location = new System.Drawing.Point(109, 12);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(608, 22);
            this.txtTieuDe.TabIndex = 1;
            this.txtTieuDe.TabStop = true;
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.radLabel5.Location = new System.Drawing.Point(373, 236);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(80, 18);
            this.radLabel5.TabIndex = 0;
            this.radLabel5.Text = "Ngày duyệt :";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.radLabel4.Location = new System.Drawing.Point(12, 208);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(77, 18);
            this.radLabel4.TabIndex = 0;
            this.radLabel4.Text = "Ngày đăng :";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.radLabel3.ForeColor = System.Drawing.Color.Red;
            this.radLabel3.Location = new System.Drawing.Point(373, 182);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(60, 18);
            this.radLabel3.TabIndex = 0;
            this.radLabel3.Text = "Thể loại :";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.radLabel2.ForeColor = System.Drawing.Color.Red;
            this.radLabel2.Location = new System.Drawing.Point(12, 38);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(66, 18);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "Nội dung :";
            // 
            // radLabel9
            // 
            this.radLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.radLabel9.Location = new System.Drawing.Point(12, 325);
            this.radLabel9.Name = "radLabel9";
            this.radLabel9.Size = new System.Drawing.Size(59, 18);
            this.radLabel9.TabIndex = 0;
            this.radLabel9.Text = "Ghi chú :";
            // 
            // radLabel8
            // 
            this.radLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.radLabel8.Location = new System.Drawing.Point(12, 266);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(83, 18);
            this.radLabel8.TabIndex = 0;
            this.radLabel8.Text = "Link bài viết :";
            // 
            // radLabel7
            // 
            this.radLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.radLabel7.Location = new System.Drawing.Point(12, 295);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(91, 18);
            this.radLabel7.TabIndex = 0;
            this.radLabel7.Text = "File đính kèm :";
            // 
            // radLabel10
            // 
            this.radLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.radLabel10.ForeColor = System.Drawing.Color.Red;
            this.radLabel10.Location = new System.Drawing.Point(12, 182);
            this.radLabel10.Name = "radLabel10";
            this.radLabel10.Size = new System.Drawing.Size(57, 18);
            this.radLabel10.TabIndex = 0;
            this.radLabel10.Text = "Tác giả :";
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.radLabel6.Location = new System.Drawing.Point(12, 236);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(83, 18);
            this.radLabel6.TabIndex = 0;
            this.radLabel6.Text = "Người duyệt :";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.radLabel1.ForeColor = System.Drawing.Color.Red;
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(57, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Tiêu đề :";
            // 
            // txtnoidung
            // 
            this.txtnoidung.Enable = true;
            this.txtnoidung.Location = new System.Drawing.Point(109, 38);
            this.txtnoidung.MaxLength = 2147483647;
            this.txtnoidung.Name = "txtnoidung";
            this.txtnoidung.Size = new System.Drawing.Size(608, 140);
            this.txtnoidung.TabIndex = 2;
            // 
            // ngaydang
            // 
            this.ngaydang.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ngaydang.Location = new System.Drawing.Point(109, 208);
            this.ngaydang.MyName = null;
            this.ngaydang.Name = "ngaydang";
            this.ngaydang.NullText = "dd/mm/yyyy";
            this.ngaydang.Size = new System.Drawing.Size(257, 22);
            this.ngaydang.TabIndex = 5;
            this.ngaydang.TabStop = true;
            this.ngaydang.Value = new System.DateTime(((long)(0)));
            this.ngaydang.Value_String = "";
            // 
            // dropDownLoai1
            // 
            // 
            // dropDownLoai1.NestedRadGridView
            // 
            this.dropDownLoai1.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.dropDownLoai1.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownLoai1.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dropDownLoai1.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.dropDownLoai1.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.dropDownLoai1.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.dropDownLoai1.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.dropDownLoai1.EditorControl.MasterTemplate.EnableGrouping = false;
            this.dropDownLoai1.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.dropDownLoai1.EditorControl.Name = "NestedRadGridView";
            this.dropDownLoai1.EditorControl.ReadOnly = true;
            this.dropDownLoai1.EditorControl.ShowGroupPanel = false;
            this.dropDownLoai1.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.dropDownLoai1.EditorControl.TabIndex = 0;
            this.dropDownLoai1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dropDownLoai1.Location = new System.Drawing.Point(460, 182);
            this.dropDownLoai1.Name = "dropDownLoai1";
            this.dropDownLoai1.NullText = "Chọn Loại";
            // 
            // 
            // 
            this.dropDownLoai1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.dropDownLoai1.Selected_ID = null;
            this.dropDownLoai1.Selected_TextValue = null;
            this.dropDownLoai1.Size = new System.Drawing.Size(257, 22);
            this.dropDownLoai1.TabIndex = 4;
            this.dropDownLoai1.TabStop = true;
            // 
            // ngayduyet
            // 
            this.ngayduyet.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ngayduyet.Location = new System.Drawing.Point(460, 236);
            this.ngayduyet.MyName = null;
            this.ngayduyet.Name = "ngayduyet";
            this.ngayduyet.NullText = "dd/mm/yyyy";
            this.ngayduyet.Size = new System.Drawing.Size(257, 22);
            this.ngayduyet.TabIndex = 7;
            this.ngayduyet.TabStop = true;
            this.ngayduyet.Value = new System.DateTime(((long)(0)));
            this.ngayduyet.Value_String = "";
            // 
            // radBrowseEditor1
            // 
            this.radBrowseEditor1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radBrowseEditor1.Location = new System.Drawing.Point(109, 295);
            this.radBrowseEditor1.Name = "radBrowseEditor1";
            this.radBrowseEditor1.Size = new System.Drawing.Size(474, 24);
            this.radBrowseEditor1.TabIndex = 10;
            this.radBrowseEditor1.Text = "radBrowseEditor1";
            // 
            // txtghichu
            // 
            this.txtghichu.Enable = true;
            this.txtghichu.Location = new System.Drawing.Point(109, 325);
            this.txtghichu.MaxLength = 2147483647;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(608, 77);
            this.txtghichu.TabIndex = 12;
            // 
            // BaiViet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 477);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.radBrowseEditor1);
            this.Controls.Add(this.ngayduyet);
            this.Controls.Add(this.dropDownLoai1);
            this.Controls.Add(this.ngaydang);
            this.Controls.Add(this.txtnoidung);
            this.Controls.Add(this.txtnguoiduyet);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radLabel10);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radLabel7);
            this.Controls.Add(this.radLabel8);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.radLabel9);
            this.Controls.Add(this.txttacgia);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.txtTieuDe);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel4);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "BaiViet";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Quản lý thông tin bài viết";
            this.ThemeName = "ControlDefault";
            this.Controls.SetChildIndex(this.radLabel4, 0);
            this.Controls.SetChildIndex(this.radLabel5, 0);
            this.Controls.SetChildIndex(this.radLabel3, 0);
            this.Controls.SetChildIndex(this.txtTieuDe, 0);
            this.Controls.SetChildIndex(this.radLabel2, 0);
            this.Controls.SetChildIndex(this.txttacgia, 0);
            this.Controls.SetChildIndex(this.radLabel9, 0);
            this.Controls.SetChildIndex(this.txtLink, 0);
            this.Controls.SetChildIndex(this.radLabel8, 0);
            this.Controls.SetChildIndex(this.radLabel7, 0);
            this.Controls.SetChildIndex(this.radButton1, 0);
            this.Controls.SetChildIndex(this.radLabel10, 0);
            this.Controls.SetChildIndex(this.radLabel6, 0);
            this.Controls.SetChildIndex(this.Open, 0);
            this.Controls.SetChildIndex(this.radLabel1, 0);
            this.Controls.SetChildIndex(this.txtnguoiduyet, 0);
            this.Controls.SetChildIndex(this.txtnoidung, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.ngaydang, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.dropDownLoai1, 0);
            this.Controls.SetChildIndex(this.ngayduyet, 0);
            this.Controls.SetChildIndex(this.radBrowseEditor1, 0);
            this.Controls.SetChildIndex(this.txtghichu, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnguoiduyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttacgia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTieuDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaydang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownLoai1.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownLoai1.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownLoai1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayduyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBrowseEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadTextBox txtLink;
        private Telerik.WinControls.UI.RadTextBox txtTieuDe;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txttacgia;
        private Telerik.WinControls.UI.RadLabel radLabel10;
        private Telerik.WinControls.UI.RadButton Open;
        private Telerik.WinControls.UI.RadTextBoxControl txtnguoiduyet;
        private NETLINK.UI.RichTextBoxWithBigEditor txtnoidung;
        private NETLINK.UI.netLink_DatePicker ngaydang;
        private DanhMuc.UserControl.DropDownLoai dropDownLoai1;
        private NETLINK.UI.netLink_DatePicker ngayduyet;
        private Telerik.WinControls.UI.RadBrowseEditor radBrowseEditor1;
        private NETLINK.UI.RichTextBoxWithBigEditor txtghichu;
    }
}
