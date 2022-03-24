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
    public partial class DropDownDoiTuong : RadDropDownList
    {
        private string[] danhMuc = { "Bác sĩ", "Điều dưỡng", "Kỹ thuật viên", "Bác sĩ + Điều dưỡng", "Bác sĩ + KTV", "Điều dưỡng + KTV", "BS + ĐD + KTV" };
        public DropDownDoiTuong()
        {
            InitializeComponent();
            this.Items.AddRange(danhMuc);
            this.NullText = "Chọn đối tượng áp dụng";
        }
    }
}
