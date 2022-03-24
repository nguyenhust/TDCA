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
    public partial class DropDownLoaiHinhChuyenGiao : RadDropDownList
    {
        private string[] listItem = { "Tại bệnh viên tuyến dưới", "Tại Bạch Mai", "Một phần BM - một phần tuyến dưới" };
        public DropDownLoaiHinhChuyenGiao()
        {
            InitializeComponent();
            this.NullText = "Chọn loại hình chuyển giao";
        }
        public void FillData()
        {
            this.Items.AddRange(listItem);
        }
    }
}
