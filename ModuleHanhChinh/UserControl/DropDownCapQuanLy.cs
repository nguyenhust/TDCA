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
    public partial class DropDownCapQuanLy : RadDropDownList
    {
        private string[] listItem = {"Chính phủ", "Liên bộ","Bộ y tế","Tỉnh thành", "Bệnh viện","Viện/Khoa", "Phòng" };
        public DropDownCapQuanLy()
        {
            InitializeComponent();
            this.NullText = "Chọn cấp quản lý";
        }
        public void FillData()
        {
            this.Items.AddRange(listItem);
        }
    }
}
