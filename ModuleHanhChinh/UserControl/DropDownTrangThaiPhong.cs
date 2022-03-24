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
    public partial class DropDownTrangThaiPhong : RadDropDownList
    {
        private string Hong = "Đang Hỏng";
        private string[] listItem = {"Tốt - Có thể sử dụng", "Đang Hỏng" };
        public DropDownTrangThaiPhong()
        {
            InitializeComponent();
            this.NullText = "Chọn trạng thái phòng";
        }
        public void FillData()
        {
            this.Items.AddRange(listItem);
        }
        public bool IsAvaible
        {
            get
            {
                if (this.Text == Hong)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
