namespace ModuleDaoTao.UI
{
    partial class Form_LT_LopHocDiaDiemToChuc
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.denngay = new NETLINK.UI.netLink_DatePicker();
            this.tungay = new NETLINK.UI.netLink_DatePicker();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.dropDownBenhVien1 = new DanhMuc.UserControl.DropDownBenhVien();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denngay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tungay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownBenhVien1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownBenhVien1.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownBenhVien1.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(74, 138);
            this.btnSave.TabIndex = 4;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(210, 138);
            this.btnClose.Size = new System.Drawing.Size(130, 34);
            this.btnClose.TabIndex = 5;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radLabel1.Location = new System.Drawing.Point(13, 14);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(91, 20);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "Tại Bệnh Viện :";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radLabel2.Location = new System.Drawing.Point(13, 42);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(105, 20);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Đơn vị tham gia :";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radLabel3.Location = new System.Drawing.Point(13, 70);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(91, 20);
            this.radLabel3.TabIndex = 5;
            this.radLabel3.Text = "Ngày bắt đầu :";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radLabel4.Location = new System.Drawing.Point(13, 98);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(94, 20);
            this.radLabel4.TabIndex = 6;
            this.radLabel4.Text = "Ngày kết thúc :";
            // 
            // denngay
            // 
            this.denngay.Location = new System.Drawing.Point(125, 98);
            this.denngay.MyName = "Ngày";
            this.denngay.Name = "denngay";
            this.denngay.NullText = "dd/mm/yyyy";
            this.denngay.Size = new System.Drawing.Size(273, 22);
            this.denngay.TabIndex = 3;
            this.denngay.TabStop = true;
            this.denngay.Value = new System.DateTime(((long)(0)));
            this.denngay.Value_String = "";
            // 
            // tungay
            // 
            this.tungay.Location = new System.Drawing.Point(125, 70);
            this.tungay.MyName = "Ngày";
            this.tungay.Name = "tungay";
            this.tungay.NullText = "dd/mm/yyyy";
            this.tungay.Size = new System.Drawing.Size(273, 22);
            this.tungay.TabIndex = 2;
            this.tungay.TabStop = true;
            this.tungay.Value = new System.DateTime(((long)(0)));
            this.tungay.Value_String = "";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radTextBox1.Location = new System.Drawing.Point(125, 42);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(273, 22);
            this.radTextBox1.TabIndex = 1;
            this.radTextBox1.TabStop = true;
            // 
            // dropDownBenhVien1
            // 
            // 
            // dropDownBenhVien1.NestedRadGridView
            // 
            this.dropDownBenhVien1.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.dropDownBenhVien1.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownBenhVien1.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dropDownBenhVien1.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.dropDownBenhVien1.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.dropDownBenhVien1.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.dropDownBenhVien1.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.dropDownBenhVien1.EditorControl.MasterTemplate.EnableGrouping = false;
            this.dropDownBenhVien1.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.dropDownBenhVien1.EditorControl.Name = "NestedRadGridView";
            this.dropDownBenhVien1.EditorControl.ReadOnly = true;
            this.dropDownBenhVien1.EditorControl.ShowGroupPanel = false;
            this.dropDownBenhVien1.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.dropDownBenhVien1.EditorControl.TabIndex = 0;
            this.dropDownBenhVien1.Location = new System.Drawing.Point(125, 14);
            this.dropDownBenhVien1.Name = "dropDownBenhVien1";
            this.dropDownBenhVien1.NullText = "Chọn bệnh viện";
            // 
            // 
            // 
            this.dropDownBenhVien1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.dropDownBenhVien1.Selected_ID = null;
            this.dropDownBenhVien1.Selected_TextValue = null;
            this.dropDownBenhVien1.Size = new System.Drawing.Size(273, 22);
            this.dropDownBenhVien1.TabIndex = 0;
            this.dropDownBenhVien1.TabStop = true;
            // 
            // Form_LT_LopHocDiaDiemToChuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 187);
            this.Controls.Add(this.dropDownBenhVien1);
            this.Controls.Add(this.radTextBox1);
            this.Controls.Add(this.tungay);
            this.Controls.Add(this.denngay);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "Form_LT_LopHocDiaDiemToChuc";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Lớp học - Địa điểm tổ chức";
            this.ThemeName = "ControlDefault";
            this.Controls.SetChildIndex(this.radLabel1, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.radLabel2, 0);
            this.Controls.SetChildIndex(this.radLabel3, 0);
            this.Controls.SetChildIndex(this.radLabel4, 0);
            this.Controls.SetChildIndex(this.denngay, 0);
            this.Controls.SetChildIndex(this.tungay, 0);
            this.Controls.SetChildIndex(this.radTextBox1, 0);
            this.Controls.SetChildIndex(this.dropDownBenhVien1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denngay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tungay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownBenhVien1.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownBenhVien1.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownBenhVien1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private NETLINK.UI.netLink_DatePicker denngay;
        private NETLINK.UI.netLink_DatePicker tungay;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private DanhMuc.UserControl.DropDownBenhVien dropDownBenhVien1;
    }
}
