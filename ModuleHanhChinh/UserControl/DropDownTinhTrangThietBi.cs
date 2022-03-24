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
    public partial class DropDownTinhTrangThietBi : RadDropDownList
    {
        private string[] listItem = { "Tốt", "Bình thường", "Hỏng", "Đang Cho Mượn", "Đã Thanh Lý" };
        public DropDownTinhTrangThietBi()
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
