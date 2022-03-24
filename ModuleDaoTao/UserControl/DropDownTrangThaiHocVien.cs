using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ModuleDaoTao.UserControls
{
    public partial class DropDownTrangThaiHocVien : RadDropDownList
    {
        private string[] listTrangThai = { "Chưa học", "Đang học", "Đã học","Đã cấp chứng chỉ", "Bị thôi học", "Tự bỏ học" };
        public DropDownTrangThaiHocVien()
        {
            InitializeComponent();
            this.Items.AddRange(listTrangThai);
            this.NullText = "Chọn trạng thái học viên";
        }
    }
}
