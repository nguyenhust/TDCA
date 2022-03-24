namespace TDCA
{
    partial class LoadingForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.radProgressBar1 = new Telerik.WinControls.UI.RadProgressBar();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TDCA.Properties.Resources.Untitled_211;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.radProgressBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 545);
            this.panel2.TabIndex = 1;
            // 
            // radProgressBar1
            // 
            this.radProgressBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radProgressBar1.ImageIndex = -1;
            this.radProgressBar1.ImageKey = "";
            this.radProgressBar1.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radProgressBar1.Location = new System.Drawing.Point(0, 523);
            this.radProgressBar1.Name = "radProgressBar1";
            this.radProgressBar1.SeparatorColor1 = System.Drawing.Color.White;
            this.radProgressBar1.SeparatorColor2 = System.Drawing.Color.White;
            this.radProgressBar1.SeparatorColor3 = System.Drawing.Color.White;
            this.radProgressBar1.SeparatorColor4 = System.Drawing.Color.White;
            this.radProgressBar1.Size = new System.Drawing.Size(648, 22);
            this.radProgressBar1.TabIndex = 0;
            this.radProgressBar1.Text = "Đang Tải - Vui Lòng Chờ";
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 545);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingForm";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.LoadingForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.UI.RadProgressBar radProgressBar1;
    }
}
