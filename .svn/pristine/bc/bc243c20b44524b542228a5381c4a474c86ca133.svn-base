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
    public partial class DropDownTrangThaiCongViec : RadDropDownList
    {
        private string[] listItem = {"Chưa bắt đầu","Đang tiến hành","Xong","Hủy","Tạm dừng"  };
        public DropDownTrangThaiCongViec()
        {
            InitializeComponent();
            this.NullText = "Chọn trạng thái công việc";
        }
        public void FillData()
        {
            this.Items.AddRange(listItem);
        }
    }
}
