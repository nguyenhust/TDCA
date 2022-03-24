﻿namespace DanhMuc.UI
{
    partial class HocViInfo
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radCheckBoxIsUse = new Telerik.WinControls.UI.RadCheckBox();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.bindingSourceHocVi = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.radTextBoxTen = new Telerik.WinControls.UI.RadTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxIsUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHocVi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(174, 122);
            this.btnSave.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(310, 122);
            this.btnClose.Size = new System.Drawing.Size(100, 34);
            this.btnClose.TabIndex = 5;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.label4);
            this.radGroupBox1.Controls.Add(this.label3);
            this.radGroupBox1.Controls.Add(this.radCheckBoxIsUse);
            this.radGroupBox1.Controls.Add(this.radTextBox1);
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Controls.Add(this.radTextBoxTen);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "Thông tin";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(398, 104);
            this.radGroupBox1.TabIndex = 3;
            this.radGroupBox1.Text = "Thông tin";
            this.radGroupBox1.Click += new System.EventHandler(this.radGroupBox1_Click);
            // 
            // radCheckBoxIsUse
            // 
            this.radCheckBoxIsUse.Location = new System.Drawing.Point(94, 81);
            this.radCheckBoxIsUse.Name = "radCheckBoxIsUse";
            this.radCheckBoxIsUse.Size = new System.Drawing.Size(62, 18);
            this.radCheckBoxIsUse.TabIndex = 6;
            this.radCheckBoxIsUse.Text = "Sử dụng";
            // 
            // radTextBox1
            // 
            this.radTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceHocVi, "TenTat", true));
            this.radTextBox1.Location = new System.Drawing.Point(102, 47);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(276, 20);
            this.radTextBox1.TabIndex = 5;
            // 
            // bindingSourceHocVi
            // 
            this.bindingSourceHocVi.DataSource = typeof(DanhMuc.LIB.DIC_HocVi);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tắt:";
            // 
            // radTextBoxTen
            // 
            this.radTextBoxTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceHocVi, "TenHocVi", true));
            this.radTextBoxTen.Location = new System.Drawing.Point(102, 21);
            this.radTextBoxTen.Name = "radTextBoxTen";
            this.radTextBoxTen.Size = new System.Drawing.Size(276, 20);
            this.radTextBoxTen.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên học vị:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(73, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "( * )";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(73, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "( * )";
            // 
            // HocViInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 165);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "HocViInfo";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Quản lý thông tin học vị";
            this.ThemeName = "ControlDefault";
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.radGroupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxIsUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHocVi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxIsUse;
        private Telerik.WinControls.UI.RadTextBox radTextBoxTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSourceHocVi;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
