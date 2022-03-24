namespace NETLINK.UI
{
    partial class ChangePassWord
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
            this.txtPassWordOld = new Telerik.WinControls.UI.RadTextBox();
            this.txtNewPass = new Telerik.WinControls.UI.RadTextBox();
            this.txtNewPassConfirm = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassWordOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(113, 120);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Đổi mật khẩu";
            // 
            // txtPassWordOld
            // 
            this.txtPassWordOld.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWordOld.Location = new System.Drawing.Point(171, 12);
            this.txtPassWordOld.Name = "txtPassWordOld";
            this.txtPassWordOld.PasswordChar = '*';
            this.txtPassWordOld.Size = new System.Drawing.Size(195, 23);
            this.txtPassWordOld.TabIndex = 0;
            this.txtPassWordOld.TabStop = true;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(171, 41);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(195, 23);
            this.txtNewPass.TabIndex = 1;
            this.txtNewPass.TabStop = true;
            this.txtNewPass.TextChanged += new System.EventHandler(this.txtNewPass_TextChanged);
            // 
            // txtNewPassConfirm
            // 
            this.txtNewPassConfirm.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassConfirm.Location = new System.Drawing.Point(171, 70);
            this.txtNewPassConfirm.Name = "txtNewPassConfirm";
            this.txtNewPassConfirm.PasswordChar = '*';
            this.txtNewPassConfirm.Size = new System.Drawing.Size(195, 23);
            this.txtNewPassConfirm.TabIndex = 2;
            this.txtNewPassConfirm.TabStop = true;
            this.txtNewPassConfirm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Click_KeyDown);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(11, 15);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(89, 20);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Mật khẩu cũ:";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(11, 42);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(99, 20);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Mật khẩu mới:";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(11, 73);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(154, 20);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Nhập lại mật khẩu mới:";
            // 
            // ChangePassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 166);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtNewPassConfirm);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtPassWordOld);
            this.Name = "ChangePassWord";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Đổi mật khẩu";
            this.ThemeName = "ControlDefault";
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.txtPassWordOld, 0);
            this.Controls.SetChildIndex(this.txtNewPass, 0);
            this.Controls.SetChildIndex(this.txtNewPassConfirm, 0);
            this.Controls.SetChildIndex(this.radLabel1, 0);
            this.Controls.SetChildIndex(this.radLabel2, 0);
            this.Controls.SetChildIndex(this.radLabel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassWordOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtPassWordOld;
        private Telerik.WinControls.UI.RadTextBox txtNewPass;
        private Telerik.WinControls.UI.RadTextBox txtNewPassConfirm;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
    }
}
