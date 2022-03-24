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
    public partial class DropDownQuocGia : Telerik.WinControls.UI.RadDropDownList
    {
        private string[] listItem = new string[] {"Việt Nam","Afghanistan","Ai Cập","Albania","Algeria","Ấn Độ","Andorra","Angola","Anh","Antigua and Barbuda","Áo","Argentina","Armeni","Australia","Azerbaijan","Ba Lan","Bahamas","Bahrain","Bangladesh","Barbados","Belarus","Belize","BeninBhutan","Bỉ","Bồ Đào Nha","Bolivia","Bosnia and Herzegovina","Botswana","Brazil","Brunei Darussalam","Bulgaria","Burkina Faso","Burma","Burundi","Cambodia","Cameroon","Canada","Cape Verde","Chad","Chile","Colombia","Comoros","Cộng Hòa Nam Phi","Cộng Hòa Tiệp","Cộng Hòa Trung Phi","Congo, Democratic Republic of the","Congo, Republic of","Costa Rica","Côte d'Ivoire","Croatia","Cuba","Cyprus","Đan Mạch","Djibouti","Dominica","Dominican Republic","Đức","Ecuador","El Salvador","Equatorial Guinea","Eritrea","Estonia","Ethiopia","Fiji","Gabon","Gambia","Georgia","Ghana","Grenada","Guatemala","Guinea","Guinea-Bissau","Guyana","Haiti","Hàn Quốc","Honduras","Hungary","Hy Lạp","Iceland","Indonesia","Iran","Iraq","Ireland","Israel","Italy","Jamaica","Jordan","Kazakhstan","Kenya","Kiribati","Kuwait","Kyrgyzstan","Lào","Latvia","Lebanon","Lesotho","Liberia","Libya","Liechtenstein","Lithuania","Luxembourg","Macedonia","Madagascar","Malawi","Malaysia","Maldives","Mali","Malta","Marshall Islands","Mauritania","Mauritius","Mexico","Micronesia","Moldova","Monaco","Mông Cổ","Montenegro","Morocco","Mozambique","Mỹ","Myanmar","Na Uy","Nam Tư","Namibia","Nauru","Nepal","Netherlands","New Zealand","Nga","Nhật Bản","Nicaragua","Niger","Nigeria","Oman","Pakistan","Palau","Palestinian State","Panama","Papua New Guinea","Paraguay","Peru","Phần Lan","Pháp","Philippines","Qatar","Romania","Rwanda","Samoa","San Marino","São Tomé and Príncipe","Saudi Arabia","Senegal","Serbia","Seychelles","Sierra Leone","Singapore","Slovakia","Slovenia","Solomon Islands","Somalia","Sri Lanka","St. Kitts and Nevis","St. Lucia","St. Vincent and The Grenadines","Sudan","Suriname","Syria","Tajikistan","Tây Ban Nha","Thái Lan","Thổ Nhĩ Kỳ","Thụy Điển","Toà Thánh Vatican","Togo","Tonga","Triều Tiên","Trinidad and Tobago","Trung Quốc","Tunisia","Turkmenistan","Tuvalu","Uganda","Ukraine","United Arab Emirates","Uruguay","Uzbekistan","Vanuatu","Venezuela","Western Sahara","Yemen, Republic of","Zaire","Zambia","Zimbabwe" };
        public DropDownQuocGia()
        {
            InitializeComponent();
           // this.Items.AddRange(listItem);
            this.NullText = "Chọn quốc gia";
            this.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
        }
        public void FillData()
        {
            this.Items.AddRange(listItem);
        }
    }
}
