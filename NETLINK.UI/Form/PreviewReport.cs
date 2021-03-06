using System;
using System.Windows.Forms;

namespace NETLINK.UI.Form
{
    public partial class PreviewReport : System.Windows.Forms.Form
    {
        public PreviewReport()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Closed);
            _instance = this;
        }
        /// <summary>
        /// Giải phóng bộ nhớ
        /// </summary>
        private void Closed(object sender, EventArgs e)
        {
            Dispose(true);
        }
        private PreviewReport _instance;

        public PreviewReport Instance
        {
            get { return _instance; }
            set { _instance = value; }
        }

        public void CloseForm(bool isClose)
        {
            if (isClose)
                this.Close();
        }
        private void PreviewReport_Load(object sender, EventArgs e)
        {
        }

        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (keyData == (Keys.Alt | Keys.F4))
        //        return true;
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}

        
    }
}