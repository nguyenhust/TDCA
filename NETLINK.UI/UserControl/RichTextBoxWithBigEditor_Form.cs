using NETLINK.LIB;
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
    public partial class RichTextBoxWithBigEditor_Form : Telerik.WinControls.UI.RadForm
    {
        private FormMode _mode;
        public RichTextBoxWithBigEditor_Form(FormMode mode)
        {
            InitializeComponent();
            _mode = mode;
            richTextBox1.Text = _mode.Item.ToString();
            richTextBox1.MaxLength = _mode.Id;
            richTextBox1.Enabled = mode.IsEnable;
        }

        private void RichTextBoxWithBigEditor_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mode.Item = richTextBox1.Text;
        }
    }
}
