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
    public partial class DropDownTrangThaiCNTT : RadDropDownList
    {
        private string[] listItem = { "Tín hiệu tốt","Thỉnh thoảng bị ngắt","Tín hiệu kém","Mất tín hiệu" };
        public DropDownTrangThaiCNTT()
        {
            InitializeComponent();
            this.NullText = "Chọn đánh giá về đường truyền";
        }
        public void FillData()
        {
            this.Items.AddRange(listItem);
        }
    }
}
