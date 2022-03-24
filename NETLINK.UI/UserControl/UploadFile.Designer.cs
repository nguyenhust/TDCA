namespace NETLINK.UI
{
    partial class UploadFile
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
            this.Upload = new System.Windows.Forms.Panel();
            this.Download = new System.Windows.Forms.Panel();
            this.radBrowseEditor1 = new Telerik.WinControls.UI.RadBrowseEditor();
            this.Upload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radBrowseEditor1)).BeginInit();
            this.SuspendLayout();
            // 
            // Upload
            // 
            this.Upload.Controls.Add(this.radBrowseEditor1);
            this.Upload.Dock = System.Windows.Forms.DockStyle.Left;
            this.Upload.Location = new System.Drawing.Point(0, 0);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(200, 30);
            this.Upload.TabIndex = 0;
            // 
            // Download
            // 
            this.Download.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Download.Location = new System.Drawing.Point(200, 0);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(279, 30);
            this.Download.TabIndex = 1;
            // 
            // radBrowseEditor1
            // 
            this.radBrowseEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radBrowseEditor1.Location = new System.Drawing.Point(0, 0);
            this.radBrowseEditor1.Name = "radBrowseEditor1";
            this.radBrowseEditor1.Size = new System.Drawing.Size(200, 30);
            this.radBrowseEditor1.TabIndex = 0;
            this.radBrowseEditor1.Text = "radBrowseEditor1";
            // 
            // UploadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Download);
            this.Controls.Add(this.Upload);
            this.Name = "UploadFile";
            this.Size = new System.Drawing.Size(479, 30);
            this.Upload.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radBrowseEditor1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Upload;
        private System.Windows.Forms.Panel Download;
        private Telerik.WinControls.UI.RadBrowseEditor radBrowseEditor1;

    }
}
