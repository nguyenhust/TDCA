using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace NETLINK.UI.Form
{
    public partial class DictionaryEx : Dictionary
    {
        public DictionaryEx()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
