namespace NETLINK.UI
{
    partial class UsDictionary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsDictionary));
            this.toolStrControl = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.ts_Save = new System.Windows.Forms.ToolStripSeparator();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.ts_New = new System.Windows.Forms.ToolStripSeparator();
            this.btnListData = new System.Windows.Forms.ToolStripButton();
            this.ts_List = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.ts_Print = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrint2 = new System.Windows.Forms.ToolStripButton();
            this.ts_Print2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrint3 = new System.Windows.Forms.ToolStripButton();
            this.ts_Print3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnInCCTL = new System.Windows.Forms.ToolStripButton();
            this.ts_Print6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnInCCKC = new System.Windows.Forms.ToolStripButton();
            this.ts_Print5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrint4 = new System.Windows.Forms.ToolStripButton();
            this.ts_Print4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.ts_Excel = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.ts_Del = new System.Windows.Forms.ToolStripSeparator();
            this.btnMyClose = new System.Windows.Forms.ToolStripButton();
            this.TotalRecord = new System.Windows.Forms.ToolStripLabel();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new Telerik.WinControls.UI.RadLabel();
            this.toolStrControl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Title)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrControl
            // 
            this.toolStrControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.ts_Save,
            this.btnNew,
            this.ts_New,
            this.btnListData,
            this.ts_List,
            this.btnMyClose,
            this.btnPrint,
            this.ts_Print,
            this.btnPrint2,
            this.ts_Print2,
            this.btnPrint3,
            this.ts_Print3,
            this.btnInCCTL,
            this.ts_Print6,
            this.btnInCCKC,
            this.ts_Print5,
            this.btnPrint4,
            this.ts_Print4,
            this.btnExcel,
            this.ts_Excel,
            this.btnDelete,
            this.ts_Del,
            this.TotalRecord});
            this.toolStrControl.Location = new System.Drawing.Point(0, 33);
            this.toolStrControl.Name = "toolStrControl";
            this.toolStrControl.Size = new System.Drawing.Size(1140, 28);
            this.toolStrControl.TabIndex = 0;
            this.toolStrControl.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 25);
            this.btnSave.Text = "Lưu ";
            this.btnSave.ToolTipText = "Phím tắt: CTRL + S";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ts_Save
            // 
            this.ts_Save.Name = "ts_Save";
            this.ts_Save.Size = new System.Drawing.Size(6, 28);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Image = global::NETLINK.UI.Properties.Resources._new;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(106, 25);
            this.btnNew.Text = "Thêm mới";
            this.btnNew.ToolTipText = "Phím tắt: CTRL + N";
            this.btnNew.Visible = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // ts_New
            // 
            this.ts_New.Name = "ts_New";
            this.ts_New.Size = new System.Drawing.Size(6, 28);
            this.ts_New.Visible = false;
            // 
            // btnListData
            // 
            this.btnListData.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnListData.ForeColor = System.Drawing.Color.Black;
            this.btnListData.Image = global::NETLINK.UI.Properties.Resources.cloud_download;
            this.btnListData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnListData.Name = "btnListData";
            this.btnListData.Size = new System.Drawing.Size(80, 25);
            this.btnListData.Text = "Liệt kê";
            this.btnListData.ToolTipText = "Phím tắt: CTRL + L";
            this.btnListData.Visible = false;
            this.btnListData.Click += new System.EventHandler(this.btnListData_Click);
            // 
            // ts_List
            // 
            this.ts_List.Name = "ts_List";
            this.ts_List.Size = new System.Drawing.Size(6, 28);
            this.ts_List.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Image = global::NETLINK.UI.Properties.Resources.printer_and_fax;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(45, 25);
            this.btnPrint.Text = "In";
            this.btnPrint.ToolTipText = "Phím tắt: CTRL + P";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ts_Print
            // 
            this.ts_Print.Name = "ts_Print";
            this.ts_Print.Size = new System.Drawing.Size(6, 28);
            // 
            // btnPrint2
            // 
            this.btnPrint2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnPrint2.ForeColor = System.Drawing.Color.Black;
            this.btnPrint2.Image = global::NETLINK.UI.Properties.Resources.printer_and_fax;
            this.btnPrint2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint2.Name = "btnPrint2";
            this.btnPrint2.Size = new System.Drawing.Size(45, 25);
            this.btnPrint2.Text = "In";
            this.btnPrint2.Visible = false;
            this.btnPrint2.Click += new System.EventHandler(this.btnPrint2_Click);
            // 
            // ts_Print2
            // 
            this.ts_Print2.Name = "ts_Print2";
            this.ts_Print2.Size = new System.Drawing.Size(6, 28);
            this.ts_Print2.Visible = false;
            // 
            // btnPrint3
            // 
            this.btnPrint3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnPrint3.Image = global::NETLINK.UI.Properties.Resources.printer_and_fax;
            this.btnPrint3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint3.Name = "btnPrint3";
            this.btnPrint3.Size = new System.Drawing.Size(45, 25);
            this.btnPrint3.Text = "In";
            this.btnPrint3.Visible = false;
            this.btnPrint3.Click += new System.EventHandler(this.btnPrint3_Click);
            // 
            // ts_Print3
            // 
            this.ts_Print3.Name = "ts_Print3";
            this.ts_Print3.Size = new System.Drawing.Size(6, 28);
            this.ts_Print3.Visible = false;
            // 
            // btnInCCTL
            // 
            this.btnInCCTL.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnInCCTL.Image = global::NETLINK.UI.Properties.Resources.printer_and_fax;
            this.btnInCCTL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInCCTL.Name = "btnInCCTL";
            this.btnInCCTL.Size = new System.Drawing.Size(99, 25);
            this.btnInCCTL.Text = "In CCTL";
            this.btnInCCTL.Visible = false;
            this.btnInCCTL.Click += new System.EventHandler(this.btnInCCTL_Click);
            // 
            // ts_Print6
            // 
            this.ts_Print6.Name = "ts_Print6";
            this.ts_Print6.Size = new System.Drawing.Size(6, 28);
            this.ts_Print6.Visible = false;
            // 
            // btnInCCKC
            // 
            this.btnInCCKC.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnInCCKC.Image = global::NETLINK.UI.Properties.Resources.printer_and_fax;
            this.btnInCCKC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInCCKC.Name = "btnInCCKC";
            this.btnInCCKC.Size = new System.Drawing.Size(106, 25);
            this.btnInCCKC.Text = "IN CCKC";
            this.btnInCCKC.Visible = false;
            this.btnInCCKC.Click += new System.EventHandler(this.btnInCCKC_Click);
            // 
            // ts_Print5
            // 
            this.ts_Print5.Name = "ts_Print5";
            this.ts_Print5.Size = new System.Drawing.Size(6, 28);
            this.ts_Print5.Visible = false;
            // 
            // btnPrint4
            // 
            this.btnPrint4.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnPrint4.Image = global::NETLINK.UI.Properties.Resources.printer_and_fax;
            this.btnPrint4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint4.Name = "btnPrint4";
            this.btnPrint4.Size = new System.Drawing.Size(45, 25);
            this.btnPrint4.Text = "In";
            this.btnPrint4.Visible = false;
            this.btnPrint4.Click += new System.EventHandler(this.btnPrint4_Click);
            // 
            // ts_Print4
            // 
            this.ts_Print4.Name = "ts_Print4";
            this.ts_Print4.Size = new System.Drawing.Size(6, 28);
            this.ts_Print4.Visible = false;
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnExcel.Image = global::NETLINK.UI.Properties.Resources.printer_and_fax;
            this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(71, 25);
            this.btnExcel.Text = "Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // ts_Excel
            // 
            this.ts_Excel.Name = "ts_Excel";
            this.ts_Excel.Size = new System.Drawing.Size(6, 28);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = global::NETLINK.UI.Properties.Resources.del;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(61, 25);
            this.btnDelete.Text = "Xóa";
            this.btnDelete.ToolTipText = "Phím tắt: CTRL + DEL";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ts_Del
            // 
            this.ts_Del.Name = "ts_Del";
            this.ts_Del.Size = new System.Drawing.Size(6, 28);
            // 
            // btnMyClose
            // 
            this.btnMyClose.Enabled = false;
            this.btnMyClose.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyClose.ForeColor = System.Drawing.Color.Black;
            this.btnMyClose.Image = global::NETLINK.UI.Properties.Resources.exit;
            this.btnMyClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMyClose.Name = "btnMyClose";
            this.btnMyClose.Size = new System.Drawing.Size(152, 25);
            this.btnMyClose.Text = "Đóng danh sách";
            this.btnMyClose.ToolTipText = "Phím tắt: CTRL + ESC";
            this.btnMyClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TotalRecord
            // 
            this.TotalRecord.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TotalRecord.Name = "TotalRecord";
            this.TotalRecord.Size = new System.Drawing.Size(0, 25);
            // 
            // StatusPanel
            // 
            this.StatusPanel.BackColor = System.Drawing.Color.Transparent;
            this.StatusPanel.BackgroundImage = global::NETLINK.UI.Properties.Resources.space;
            this.StatusPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StatusPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatusPanel.Location = new System.Drawing.Point(0, 0);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(1140, 10);
            this.StatusPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 23);
            this.panel1.TabIndex = 2;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Title.Location = new System.Drawing.Point(244, 1);
            this.Title.Name = "Title";
            this.Title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Title.Size = new System.Drawing.Size(2, 2);
            this.Title.TabIndex = 0;
            this.Title.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StatusPanel);
            this.Name = "UsDictionary";
            this.Size = new System.Drawing.Size(1140, 319);
            this.Load += new System.EventHandler(this.LoadUserControl);
            this.toolStrControl.ResumeLayout(false);
            this.toolStrControl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Title)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnMyClose;
        protected System.Windows.Forms.ToolStrip toolStrControl;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnListData;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripSeparator ts_Save;
        private System.Windows.Forms.ToolStripSeparator ts_New;
        private System.Windows.Forms.ToolStripSeparator ts_List;
        private System.Windows.Forms.ToolStripSeparator ts_Print;
        private System.Windows.Forms.ToolStripSeparator ts_Del;
        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadLabel Title;
        private System.Windows.Forms.ToolStripButton btnPrint2;
        private System.Windows.Forms.ToolStripSeparator ts_Print2;
        private System.Windows.Forms.ToolStripButton btnPrint3;
        private System.Windows.Forms.ToolStripSeparator ts_Print3;
        private System.Windows.Forms.ToolStripButton btnPrint4;
        private System.Windows.Forms.ToolStripSeparator ts_Print4;
        private System.Windows.Forms.ToolStripLabel TotalRecord;
        private System.Windows.Forms.ToolStripSeparator ts_Excel;
        private System.Windows.Forms.ToolStripButton btnExcel;
        private System.Windows.Forms.ToolStripButton btnInCCTL;
        private System.Windows.Forms.ToolStripSeparator ts_Print6;
        private System.Windows.Forms.ToolStripButton btnInCCKC;
        private System.Windows.Forms.ToolStripSeparator ts_Print5;
    }
}
