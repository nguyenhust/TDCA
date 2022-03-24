using NETLINK.UI;
using NETLINK.LIB;
using DanhMuc.LIB;
using DanhMuc.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using ModuleDaoTao.LIB;

namespace ModuleDaoTao.UI
{
    public partial class Form_InDiemDanh : NETLINK.UI.Dictionary
    {
        public Form_InDiemDanh()
        {
            InitializeComponent();

            
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            DT_LienTuc_LopHoc_Info objLopHoc = null;
            if (dropDownLopHocLienTuc1.Selected_Item != null) {
                objLopHoc = (DT_LienTuc_LopHoc_Info)dropDownLopHocLienTuc1.Selected_Item;
            }

            if (objLopHoc == null) {
                GlobalCommon.ShowMessageInformation("Bạn phải chọn một lớp để in");
                return;
            }
            if (radCheckBoxTatca.Checked) {
                DT_Common.InBangDiemDanh(objLopHoc);
                return;
            }

            string listNhom = string.Empty;
            if (radCheckBoxNhom1.Checked)
                listNhom += ",1";
            if (radCheckBoxNhom2.Checked)
                listNhom += ",2";
            if (radCheckBoxNhom3.Checked)
                listNhom += ",3";
            if (radCheckBoxNhom4.Checked)
                listNhom += ",4";
            if (radCheckBoxNhom5.Checked)
                listNhom += ",5";
            if (listNhom.Length > 0)
                listNhom = listNhom.Substring(1);

            DT_Common.InBangDiemDanhLopNhom(objLopHoc, listNhom);
        }

        private void Form_InDiemDanh_Load(object sender, EventArgs e)
        {
            dropDownLopHocLienTuc1.FillData();
        }
    }
}
