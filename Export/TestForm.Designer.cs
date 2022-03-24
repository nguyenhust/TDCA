namespace Export
{
    partial class TestForm
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
            this.cbDaoTao = new System.Windows.Forms.ComboBox();
            this.btnDaoTao = new System.Windows.Forms.Button();
            this.btnHanhChinh = new System.Windows.Forms.Button();
            this.cbHanhChinh = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbDaoTao
            // 
            this.cbDaoTao.FormattingEnabled = true;
            this.cbDaoTao.Location = new System.Drawing.Point(195, 130);
            this.cbDaoTao.Name = "cbDaoTao";
            this.cbDaoTao.Size = new System.Drawing.Size(172, 21);
            this.cbDaoTao.TabIndex = 0;
            // 
            // btnDaoTao
            // 
            this.btnDaoTao.Location = new System.Drawing.Point(433, 128);
            this.btnDaoTao.Name = "btnDaoTao";
            this.btnDaoTao.Size = new System.Drawing.Size(125, 23);
            this.btnDaoTao.TabIndex = 1;
            this.btnDaoTao.Text = "Export Dao Tao";
            this.btnDaoTao.UseVisualStyleBackColor = true;
            this.btnDaoTao.Click += new System.EventHandler(this.btnDaoTao_Click);
            // 
            // btnHanhChinh
            // 
            this.btnHanhChinh.Location = new System.Drawing.Point(433, 251);
            this.btnHanhChinh.Name = "btnHanhChinh";
            this.btnHanhChinh.Size = new System.Drawing.Size(125, 23);
            this.btnHanhChinh.TabIndex = 3;
            this.btnHanhChinh.Text = "Export Hanh Chinh";
            this.btnHanhChinh.UseVisualStyleBackColor = true;
            this.btnHanhChinh.Click += new System.EventHandler(this.btnHanhChinh_Click);
            // 
            // cbHanhChinh
            // 
            this.cbHanhChinh.FormattingEnabled = true;
            this.cbHanhChinh.Location = new System.Drawing.Point(195, 253);
            this.cbHanhChinh.Name = "cbHanhChinh";
            this.cbHanhChinh.Size = new System.Drawing.Size(172, 21);
            this.cbHanhChinh.TabIndex = 2;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 458);
            this.Controls.Add(this.btnHanhChinh);
            this.Controls.Add(this.cbHanhChinh);
            this.Controls.Add(this.btnDaoTao);
            this.Controls.Add(this.cbDaoTao);
            this.Name = "TestForm";
            this.Text = "Export PDF";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDaoTao;
        private System.Windows.Forms.Button btnDaoTao;
        private System.Windows.Forms.Button btnHanhChinh;
        private System.Windows.Forms.ComboBox cbHanhChinh;
    }
}

