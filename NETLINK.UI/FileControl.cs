using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NETLINK.UI
{
    public partial class FileControl : UserControl
    {
        public FileControl()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "pdf files (*.pdf)|*.pdf|doc files (*.doc)|*.doc|docx files (*.docx)|*.docx";
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string strFileName = openFileDialog.FileName;

                if (strFileName == string.Empty)
                    return;

                txtFileName.Text = strFileName;
            }
        }

        public string Filter {
            set { openFileDialog.Filter = value; }
        }
        public string Title {
            set { openFileDialog.Title = value; }
        }
    }
}
