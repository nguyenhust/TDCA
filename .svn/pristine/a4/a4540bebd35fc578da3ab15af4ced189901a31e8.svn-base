using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace TruyenThong.UserControl
{
    public partial class DropDownTinhTrang : RadDropDownList
    {
        private string[] listItem = { "Chờ duyệt", "Đã Duyệt", "Hủy", "Yêu cầu thay đổi" };
        public DropDownTinhTrang()
        {
            InitializeComponent();
            this.NullText = "Chọn tình trạng";
        }
        public void FillData()
        {
            this.Items.AddRange(listItem);
        }
    }
}
