using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace DanhMuc.UserControl
{
    public partial class DropDownGioiTinh : RadDropDownList
    {
        private string[] listItem = { "Nam", "Nữ" };
        public DropDownGioiTinh()
        {
            InitializeComponent();
            //
            this.NullText = "Chọn giới tính";
            DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
        }
        public void FillData()
        {
            this.Items.AddRange(listItem);
        }
    }
}
