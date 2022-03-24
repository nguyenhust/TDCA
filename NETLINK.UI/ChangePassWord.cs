using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace NETLINK.UI
{
    public partial class ChangePassWord : Dictionary
    {
        public ChangePassWord()
        {
            InitializeComponent();
        }

        protected override void Save()
        {
            ChangePassWordSave(txtPassWordOld.Text, txtNewPass.Text, txtNewPassConfirm.Text);
        }

        private void PassWordOld_Click(object sender, EventArgs e)
        {
            
        }

        protected virtual void ChangePassWordSave(string oldPass, string NewPass, string NewPassConfirm)
        { 
            // detail method
        }

        private void Click_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                Save();
        }


    }
}
