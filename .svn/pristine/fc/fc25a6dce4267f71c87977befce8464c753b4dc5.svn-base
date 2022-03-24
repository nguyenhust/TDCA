using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TDCA
{
    public partial class UserStatus : UserControl
    {
        public UserStatus()
        {
            InitializeComponent();
        }
        public event EventHandler LogOut
        {
            add { radLink.Click += value; }
            remove { radLink.Click -= value; }
        }

        public event EventHandler Link2Click
        {
            add { radLink2.Click += value; }
            remove { radLink2.Click -= value; }
        }

        public string Link2Text
        {
            get { return radLink2.Text; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    radLink2.Visible = false;
                    radSeparate.Visible = false;
                }
                else
                {
                    radLink2.Text = value;
                    radLink2.Visible = true;
                    radSeparate.Visible = true;
                }
            }
        }

        public string UserName
        {
            get { return radName.Text; }
            set { radName.Text = value; }
        }
    }
}
