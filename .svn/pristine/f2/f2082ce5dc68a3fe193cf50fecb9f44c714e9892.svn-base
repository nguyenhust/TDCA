using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ModuleChiDaoTuyen.UserControl
{
    public partial class DropDownLoaiHC : RadDropDownList
    {
        private string[] listItem = { "Thường quy", "Đột xuất","Đào tạo trực tuyến" };
        public DropDownLoaiHC()
        {
            InitializeComponent();
            this.NullText = "Chọn loại hội chẩn";
        }
        public void FillData()
        {
            this.Items.AddRange(listItem);
        }
    }
}
