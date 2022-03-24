namespace TruyenThong.UI
{
    partial class ThongKe
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
            this.netLink_DatePicker1 = new NETLINK.UI.netLink_DatePicker();
            this.netLink_DatePicker2 = new NETLINK.UI.netLink_DatePicker();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netLink_DatePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netLink_DatePicker2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(192, 291);
            this.btnSave.TabIndex = 10;
            this.btnSave.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(328, 291);
            this.btnClose.Size = new System.Drawing.Size(130, 34);
            this.btnClose.TabIndex = 11;
            this.btnClose.Visible = false;
            // 
            // netLink_DatePicker1
            // 
            this.netLink_DatePicker1.Location = new System.Drawing.Point(74, 12);
            this.netLink_DatePicker1.MyName = "Ngày";
            this.netLink_DatePicker1.Name = "netLink_DatePicker1";
            this.netLink_DatePicker1.NullText = "dd/mm/yyyy";
            this.netLink_DatePicker1.Size = new System.Drawing.Size(100, 22);
            this.netLink_DatePicker1.TabIndex = 12;
            this.netLink_DatePicker1.TabStop = true;
            this.netLink_DatePicker1.Value = new System.DateTime(((long)(0)));
            this.netLink_DatePicker1.Value_String = "";
            // 
            // netLink_DatePicker2
            // 
            this.netLink_DatePicker2.Location = new System.Drawing.Point(250, 12);
            this.netLink_DatePicker2.MyName = "Ngày";
            this.netLink_DatePicker2.Name = "netLink_DatePicker2";
            this.netLink_DatePicker2.NullText = "dd/mm/yyyy";
            this.netLink_DatePicker2.Size = new System.Drawing.Size(100, 22);
            this.netLink_DatePicker2.TabIndex = 13;
            this.netLink_DatePicker2.TabStop = true;
            this.netLink_DatePicker2.Value = new System.DateTime(((long)(0)));
            this.netLink_DatePicker2.Value_String = "";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(126, 50);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(130, 24);
            this.radButton1.TabIndex = 14;
            this.radButton1.Text = "Xuất báo cáo";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(59, 20);
            this.radLabel1.TabIndex = 15;
            this.radLabel1.Text = "Từ ngày :";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radLabel2.Location = new System.Drawing.Point(176, 12);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(68, 20);
            this.radLabel2.TabIndex = 16;
            this.radLabel2.Text = "Đến ngày :";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 80);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(368, 22);
            this.progressBar1.TabIndex = 17;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 102);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.netLink_DatePicker2);
            this.Controls.Add(this.netLink_DatePicker1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "ThongKe";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Thống kê tổng hợp Truyền Thông";
            this.ThemeName = "ControlDefault";
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.netLink_DatePicker1, 0);
            this.Controls.SetChildIndex(this.netLink_DatePicker2, 0);
            this.Controls.SetChildIndex(this.radButton1, 0);
            this.Controls.SetChildIndex(this.radLabel1, 0);
            this.Controls.SetChildIndex(this.radLabel2, 0);
            this.Controls.SetChildIndex(this.progressBar1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netLink_DatePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netLink_DatePicker2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NETLINK.UI.netLink_DatePicker netLink_DatePicker1;
        private NETLINK.UI.netLink_DatePicker netLink_DatePicker2;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.ProgressBar progressBar1;

    }
}
