using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ModuleHanhChinh.UserControl
{
    public partial class DropDownThang : RadDropDownList
    {
        private string[] listItem = {"1","2","3","4","5","6","7","8","9","10","11","12"  };
        public DropDownThang()
        {
            InitializeComponent();
            this.NullText = "Chọn Tháng";
        }
        public void FillData()
        {
            this.Items.AddRange(listItem);
        }
    }
}
