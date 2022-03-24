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
    public partial class EditedBy_Name : Telerik.WinControls.UI.RadLabel
    {
        public EditedBy_Name()
        {
            InitializeComponent();
        }
        private string Sua { get { return "Sửa lần cuối bởi : "; } }
        public override string Text
        {
            get
            {
                return base.Text.Replace(Sua,string.Empty);
            }
            set
            {
                base.Text = Sua + value;
            }
        }
    }
}
