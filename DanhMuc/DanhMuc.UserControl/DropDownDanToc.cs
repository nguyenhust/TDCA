using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DanhMuc.UserControl
{
    public partial class DropDownDanToc : Telerik.WinControls.UI.RadDropDownList
    {
        private string[] listItem = new string[] {"Kinh","Ba Na","Bố Y","Brâu","Bru-Vân Kiều","Chăm","Chơ Ro","Chu Ru","Chứt","Co","Cơ Ho","Cờ Lao","Cơ Tu","Cống","Dao","Ê Đê","Gia rai","Giáy","Giẻ-Triêng","Hà Nhì","Hmông","Hoa","Hrê","Kháng","Khơ Me","Khơ Mú"," La Chí","La Ha","La Hủ","Lào","Lô Lô","Lự","Mạ","Mảng","Mnông","Mường","Ngái","Nùng","Ơ Đu","Pà Thẻn","Phú Lá","Pu Péo","Ra Glai","Rơ măm","Sán Chay","Sán Dìu","Si La","Tà Ôi","Tày","Thái","Thổ","Xinh Mun","Xơ Đăng","Xtiêng","Người nước ngoài"};
        public DropDownDanToc()
        {
            InitializeComponent();
            this.NullText = "Chọn dân tộc";
            this.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
        }

        public void FillData()
        {
            this.Items.AddRange(listItem);
        }
    }
}
