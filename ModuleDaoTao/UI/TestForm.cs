using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NETLINK.LIB;

namespace ModuleDaoTao.UI
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {

        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            
            FormMode mode = new FormMode();
            mode.IsInsert = true;
            Form_LT_HocVienLienTuc fr = new Form_LT_HocVienLienTuc(mode);
            fr.Show();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {

        }

        private void radButton4_Click(object sender, EventArgs e)
        {

        }

        private void radButton5_Click(object sender, EventArgs e)
        {

        }

        private void radButton6_Click(object sender, EventArgs e)
        {

        }
    }
}
