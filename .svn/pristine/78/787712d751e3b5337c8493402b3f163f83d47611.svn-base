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
    public partial class LogIn : Dictionary
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            Save(txtUserName.Text, txtPassWord.Text);
        }

        protected virtual void Save(string username,string password)
        { 
            // detail method
        }

        private void Click_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.F5)
                Save(txtUserName.Text, txtPassWord.Text);
        }
    }
}
