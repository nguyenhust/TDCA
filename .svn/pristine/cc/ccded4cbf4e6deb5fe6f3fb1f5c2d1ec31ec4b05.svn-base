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
    public partial class DropDownLoaiCongVan : RadDropDownList
    {
        private string[] listItem = { "Điện khẩn","Liên ngành","Thông tư","Thông báo" };
        public DropDownLoaiCongVan()
        {
            InitializeComponent();
            this.NullText = "Chọn loại công văn";
        }
        public void FillData()
        {
            this.Items.AddRange(listItem);
        }
    }
}
