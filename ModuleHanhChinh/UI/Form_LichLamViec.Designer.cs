namespace ModuleHanhChinh.UI
{
    partial class Form_LichLamViec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LichLamViec));
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radGhiChu = new NETLINK.UI.RichTextBoxWithBigEditor();
            this.radBatDau = new NETLINK.UI.netLink_DatePicker();
            this.radKetThuc = new NETLINK.UI.netLink_DatePicker();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radNoiDung = new NETLINK.UI.RichTextBoxWithBigEditor();
            this.labelLastEdited = new Telerik.WinControls.UI.RadLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridViewCanBoTDC1 = new DanhMuc.UserControl.GridViewCanBoTDC();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dropDownBoPhan1 = new DanhMuc.UserControl.DropDownBoPhan();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBatDau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radKetThuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelLastEdited)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownBoPhan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownBoPhan1.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownBoPhan1.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(59, 367);
            this.btnSave.TabIndex = 6;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(195, 367);
            this.btnClose.Size = new System.Drawing.Size(130, 34);
            this.btnClose.TabIndex = 7;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radLabel1.ForeColor = System.Drawing.Color.Red;
            this.radLabel1.Location = new System.Drawing.Point(14, 14);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(91, 20);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Ngày bắt đầu :";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radLabel2.ForeColor = System.Drawing.Color.Red;
            this.radLabel2.Location = new System.Drawing.Point(14, 40);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(94, 20);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Ngày kết thúc :";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radLabel4.Location = new System.Drawing.Point(14, 269);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(57, 20);
            this.radLabel4.TabIndex = 8;
            this.radLabel4.Text = "Ghi chú :";
            // 
            // radGhiChu
            // 
            this.radGhiChu.Enable = true;
            this.radGhiChu.Location = new System.Drawing.Point(118, 269);
            this.radGhiChu.MaxLength = 2147483647;
            this.radGhiChu.Name = "radGhiChu";
            this.radGhiChu.Size = new System.Drawing.Size(265, 82);
            this.radGhiChu.TabIndex = 4;
            // 
            // radBatDau
            // 
            this.radBatDau.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radBatDau.Location = new System.Drawing.Point(118, 14);
            this.radBatDau.MyName = null;
            this.radBatDau.Name = "radBatDau";
            this.radBatDau.NullText = "dd/mm/yyyy";
            this.radBatDau.Size = new System.Drawing.Size(265, 22);
            this.radBatDau.TabIndex = 0;
            this.radBatDau.Value = new System.DateTime(((long)(0)));
            this.radBatDau.Value_String = "";
            // 
            // radKetThuc
            // 
            this.radKetThuc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radKetThuc.Location = new System.Drawing.Point(118, 40);
            this.radKetThuc.MyName = null;
            this.radKetThuc.Name = "radKetThuc";
            this.radKetThuc.NullText = "dd/mm/yyyy";
            this.radKetThuc.Size = new System.Drawing.Size(265, 22);
            this.radKetThuc.TabIndex = 1;
            this.radKetThuc.Value = new System.DateTime(((long)(0)));
            this.radKetThuc.Value_String = "";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radLabel3.ForeColor = System.Drawing.Color.Red;
            this.radLabel3.Location = new System.Drawing.Point(14, 64);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(61, 20);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Bộ phận :";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radLabel5.ForeColor = System.Drawing.Color.Red;
            this.radLabel5.Location = new System.Drawing.Point(14, 88);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(67, 20);
            this.radLabel5.TabIndex = 5;
            this.radLabel5.Text = "Nội dung :";
            // 
            // radNoiDung
            // 
            this.radNoiDung.Enable = true;
            this.radNoiDung.Location = new System.Drawing.Point(118, 93);
            this.radNoiDung.MaxLength = 2147483647;
            this.radNoiDung.Name = "radNoiDung";
            this.radNoiDung.Size = new System.Drawing.Size(265, 170);
            this.radNoiDung.TabIndex = 3;
            // 
            // labelLastEdited
            // 
            this.labelLastEdited.Location = new System.Drawing.Point(12, 424);
            this.labelLastEdited.Name = "labelLastEdited";
            this.labelLastEdited.Size = new System.Drawing.Size(2, 2);
            this.labelLastEdited.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridViewCanBoTDC1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 361);
            this.panel1.TabIndex = 16;
            // 
            // gridViewCanBoTDC1
            // 
            this.gridViewCanBoTDC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewCanBoTDC1.Enable = true;
            this.gridViewCanBoTDC1.IncludeCurrentUser = true;
            this.gridViewCanBoTDC1.Location = new System.Drawing.Point(402, 0);
            this.gridViewCanBoTDC1.Name = "gridViewCanBoTDC1";
            this.gridViewCanBoTDC1.Selected_ListItem = ((DanhMuc.LIB.DIC_CanBo_Coll)(resources.GetObject("gridViewCanBoTDC1.Selected_ListItem")));
            this.gridViewCanBoTDC1.Selected_ListItem_ID = "";
            this.gridViewCanBoTDC1.Selected_ListItem_Name = "";
            this.gridViewCanBoTDC1.Size = new System.Drawing.Size(461, 361);
            this.gridViewCanBoTDC1.TabIndex = 5;
            this.gridViewCanBoTDC1.TextColor = System.Drawing.Color.Red;
            this.gridViewCanBoTDC1.TextTitle = "Chọn Cán Bộ TDC";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radLabel1);
            this.panel2.Controls.Add(this.radLabel3);
            this.panel2.Controls.Add(this.radLabel2);
            this.panel2.Controls.Add(this.dropDownBoPhan1);
            this.panel2.Controls.Add(this.radKetThuc);
            this.panel2.Controls.Add(this.radLabel4);
            this.panel2.Controls.Add(this.radLabel5);
            this.panel2.Controls.Add(this.radBatDau);
            this.panel2.Controls.Add(this.radGhiChu);
            this.panel2.Controls.Add(this.radNoiDung);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 361);
            this.panel2.TabIndex = 15;
            // 
            // dropDownBoPhan1
            // 
            // 
            // dropDownBoPhan1.NestedRadGridView
            // 
            this.dropDownBoPhan1.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.dropDownBoPhan1.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownBoPhan1.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dropDownBoPhan1.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.dropDownBoPhan1.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.dropDownBoPhan1.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.dropDownBoPhan1.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.dropDownBoPhan1.EditorControl.MasterTemplate.EnableGrouping = false;
            this.dropDownBoPhan1.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.dropDownBoPhan1.EditorControl.Name = "NestedRadGridView";
            this.dropDownBoPhan1.EditorControl.ReadOnly = true;
            this.dropDownBoPhan1.EditorControl.ShowGroupPanel = false;
            this.dropDownBoPhan1.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.dropDownBoPhan1.EditorControl.TabIndex = 0;
            this.dropDownBoPhan1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dropDownBoPhan1.Location = new System.Drawing.Point(118, 67);
            this.dropDownBoPhan1.Name = "dropDownBoPhan1";
            this.dropDownBoPhan1.NullText = "Chọn bộ phận";
            // 
            // 
            // 
            this.dropDownBoPhan1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.dropDownBoPhan1.Selected_ID = null;
            this.dropDownBoPhan1.Selected_TextValue = null;
            this.dropDownBoPhan1.Size = new System.Drawing.Size(265, 22);
            this.dropDownBoPhan1.TabIndex = 2;
            this.dropDownBoPhan1.TabStop = false;
            // 
            // Form_LichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 454);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelLastEdited);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "Form_LichLamViec";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Lịch làm việc của trung tâm";
            this.ThemeName = "ControlDefault";
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.labelLastEdited, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBatDau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radKetThuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelLastEdited)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownBoPhan1.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownBoPhan1.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownBoPhan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private NETLINK.UI.RichTextBoxWithBigEditor radGhiChu;
        private NETLINK.UI.netLink_DatePicker radBatDau;
        private NETLINK.UI.netLink_DatePicker radKetThuc;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private DanhMuc.UserControl.DropDownBoPhan dropDownBoPhan1;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private NETLINK.UI.RichTextBoxWithBigEditor radNoiDung;
        private Telerik.WinControls.UI.RadLabel labelLastEdited;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DanhMuc.UserControl.GridViewCanBoTDC gridViewCanBoTDC1;


    }
}
