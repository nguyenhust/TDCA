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
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnMyClose = new System.Windows.Forms.ToolStripButton();
            this.toolStrControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrControl
            // 
            this.toolStrControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnPrint,
            this.btnMyClose});
            this.toolStrControl.Location = new System.Drawing.Point(0, 0);
            this.toolStrControl.Name = "toolStrControl";
            this.toolStrControl.Size = new System.Drawing.Size(365, 28);
            this.toolStrControl.TabIndex = 0;
            this.toolStrControl.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 25);
            this.btnSave.Text = "Lưu ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(65, 25);
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnMyClose
            // 
            this.btnMyClose.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyClose.Image = ((System.Drawing.Image)(resources.GetObject("btnMyClose.Image")));
            this.btnMyClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMyClose.Name = "btnMyClose";
            this.btnMyClose.Size = new System.Drawing.Size(74, 25);
            this.btnMyClose.Text = "Thoát";
            this.btnMyClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // UsDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrControl);
            this.Name = "UsDictionary";
            this.Size = new System.Drawing.Size(365, 319);
            this.Load += new System.EventHandler(this.LoadUserControl);
            this.toolStrControl.ResumeLayout(false);
            this.toolStrControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnMyClose;
        protected System.Windows.Forms.ToolStrip toolStrControl;
    }
}
