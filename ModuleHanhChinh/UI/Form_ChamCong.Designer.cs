namespace ModuleHanhChinh.UI
{
    partial class Form_ChamCong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ChamCong));
            this.bindingSourceCanBo = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.bindingSourceNgayCong = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.radButtonFromExcel = new Telerik.WinControls.UI.RadButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCanBo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNgayCong)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonFromExcel)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(391, 330);
            this.btnSave.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnClose.Location = new System.Drawing.Point(66, 71);
            this.btnClose.Size = new System.Drawing.Size(105, 34);
            // 
            // bindingSourceCanBo
            // 
            this.bindingSourceCanBo.DataSource = typeof(DanhMuc.LIB.DIC_CanBo_Coll);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // bindingSourceNgayCong
            // 
            this.bindingSourceNgayCong.DataSource = typeof(ModuleHanhChinh.LIB.HC_NhanVien_ChamCong_Coll);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 46);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radButtonFromExcel);
            this.panel3.Controls.Add(this.pictureBoxLoading);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 41);
            this.panel3.TabIndex = 6;
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoading.Image")));
            this.pictureBoxLoading.Location = new System.Drawing.Point(177, 5);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(27, 30);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLoading.TabIndex = 4;
            this.pictureBoxLoading.TabStop = true;
            this.pictureBoxLoading.Visible = false;
            // 
            // radButtonFromExcel
            // 
            this.radButtonFromExcel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radButtonFromExcel.Location = new System.Drawing.Point(3, 3);
            this.radButtonFromExcel.Name = "radButtonFromExcel";
            this.radButtonFromExcel.Size = new System.Drawing.Size(168, 32);
            this.radButtonFromExcel.TabIndex = 3;
            this.radButtonFromExcel.Text = "Tải file chấm công";
            this.radButtonFromExcel.Click += new System.EventHandler(this.radButtonFromExcel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 46);
            this.panel1.TabIndex = 2;
            // 
            // Form_ChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 129);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "Form_ChamCong";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Bảng chấm công";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.Form_ChamCong_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCanBo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNgayCong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonFromExcel)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource bindingSourceNgayCong;
        private System.Windows.Forms.BindingSource bindingSourceCanBo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Telerik.WinControls.UI.RadButton radButtonFromExcel;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.Windows.Forms.Panel panel1;



    }
}
