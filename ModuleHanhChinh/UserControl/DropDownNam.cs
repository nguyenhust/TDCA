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
    public partial class DropDownNam : RadDropDownList
    {
        private string[] listItem = {};
        public DropDownNam()
        {
            InitializeComponent();
            this.NullText = "Chọn Năm";
        }
        public void FillData()
        {
            for (int i = 2010; i <= 2030; i++)
            {
                this.Items.Add(i.ToString());
            }
            //this.Items.AddRange(listItem);
        }
    }
}
