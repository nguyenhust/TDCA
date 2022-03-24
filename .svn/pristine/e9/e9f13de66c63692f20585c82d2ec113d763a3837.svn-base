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
using Authoration.LIB;

namespace ModuleDaoTao.UI
{
    public partial class Form_ThongKeHocPhi : NETLINK.UI.Dictionary
    {
        private string[] quater = { "Quý I", "Quý II", "Quý III", "Quý IV"};
        private string[] month = { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" };
        public Form_ThongKeHocPhi()
        {
            InitializeComponent();

            radDropDownListQuy.DataSource = quater;
            radDropDownListThang.DataSource = month;

            radRadioButtonThang.IsChecked = true;
            radTextBoxNam.Text = DateTime.Now.Year.ToString();
        }

        private void radRadioButtonNam_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            string value = args.ToggleState.ToString().ToLower();
            if (value.CompareTo("on") == 0)
                ShowForYear();
        }

        private void radRadioButtonQuy_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            string value = args.ToggleState.ToString().ToLower();
            if (value.CompareTo("on") == 0)
                ShowForQuater();
        }

        private void radRadioButtonNgay_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            string value = args.ToggleState.ToString().ToLower();
            if (value.CompareTo("on") == 0)
                ShowForDay();
        }

        private void radRadioButtonThang_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            string value = args.ToggleState.ToString().ToLower();
            if (value.CompareTo("on") == 0)
                ShowForThang();
        }

        private void ShowForYear() {
            radDropDownListQuy.Visible = false;
            radLabelQuy.Visible = false;
            radNgayBatDau.Visible = false;
            radLabelNgayBatDau.Visible = false;
            radNgayKetThucs.Visible = false;
            radLabelNgayKetthuc.Visible = false;
            radTextBoxNam.Visible = true;
            radLabelNam.Visible = true;
            radLabelThang.Visible = false;
            radDropDownListThang.Visible = false;
        }

        private void ShowForQuater() {
            radDropDownListQuy.Visible = true;
            radLabelQuy.Visible = true;
            radTextBoxNam.Visible = true;
            radLabelNam.Visible = true;
            radNgayBatDau.Visible = false;
            radLabelNgayBatDau.Visible = false;
            radNgayKetThucs.Visible = false;
            radLabelNgayKetthuc.Visible = false;
            radLabelThang.Visible = false;
            radDropDownListThang.Visible = false;
        }

        private void ShowForDay() {
            radDropDownListQuy.Visible = false;
            radLabelQuy.Visible = false;
            radTextBoxNam.Visible = false;
            radLabelNam.Visible = false;
            radNgayBatDau.Visible = true;
            radLabelNgayBatDau.Visible = true;
            radNgayKetThucs.Visible = true;
            radLabelNgayKetthuc.Visible = true;
            radLabelThang.Visible = false;
            radDropDownListThang.Visible = false;
        }

        private void ShowForThang()
        {
            radDropDownListQuy.Visible = false;
            radLabelQuy.Visible = false;
            radNgayBatDau.Visible = false;
            radLabelNgayBatDau.Visible = false;
            radNgayKetThucs.Visible = false;
            radLabelNgayKetthuc.Visible = false;
            radTextBoxNam.Visible = true;
            radLabelNam.Visible = true;
            radLabelThang.Visible = true;
            radDropDownListThang.Visible = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DateTime? startTime = null;
            DateTime? endTime = null;

            // if radio button ngay check
            if (radRadioButtonNgay.IsChecked)
            {
                startTime = radNgayBatDau.Value;
                endTime = radNgayKetThucs.Value;
            }
            else if (radRadioButtonThang.IsChecked)
            {
                int year = 0;
                int.TryParse(radTextBoxNam.Text, out year);
                int month = radDropDownListThang.SelectedIndex + 1;
                startTime = new DateTime(year, month, 1);
                endTime = new DateTime(year, month, DateTime.DaysInMonth(year, month), 23, 59, 59);
            }
            else if (radRadioButtonQuy.IsChecked)
            {
                int year = 0;
                int.TryParse(radTextBoxNam.Text, out year);
                int startMonth = 0;
                int endMonth = 0;
                switch (radDropDownListQuy.SelectedIndex)
                {
                    case 0:
                        startMonth = 1;
                        endMonth = 3;
                        break;
                    case 1:
                        startMonth = 4;
                        endMonth = 6;
                        break;
                    case 2:
                        startMonth = 7;
                        endMonth = 9;
                        break;
                    case 3:
                        startMonth = 10;
                        endMonth = 12;
                        break;
                }

                startTime = new DateTime(year, startMonth, 1);
                endTime = new DateTime(year, endMonth, DateTime.DaysInMonth(year, endMonth), 23, 59, 59);
            }
            else if (radRadioButtonNam.IsChecked)
            {
                int year = 0;
                int.TryParse(radTextBoxNam.Text, out year);
                if (year > 0) {
                    startTime = new DateTime(year, 1, 1);
                    endTime = new DateTime(year, 12, 31, 23, 59, 59);
                }
            }

            if (startTime != null && endTime != null)
            {
                BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDateByNgayDongHoc);
                DT_Lientuc_HocVienRangeTime time = new DT_Lientuc_HocVienRangeTime();
                time.StartTime = (DateTime)startTime;
                time.EndTime = (DateTime)endTime;
                function.Item = time;
                function.ItemID = (int)PTIdentity.IDNguoiDung;
                DT_LienTuc_HocVien_Coll lstHocVien = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
                bindingSourceHocVien.DataSource = lstHocVien;

                long tongtien = 0;
                if (lstHocVien != null && lstHocVien.Count > 0)
                {
                    foreach (DT_LienTuc_HocVien_Info hv in lstHocVien)
                    {
                        long sotien = 0;
                        long.TryParse(hv.TongTienHoc, out sotien);
                        tongtien += sotien;
                    }
                }

                lblTongCong.Text = "Tổng tiền: " + tongtien + "VNĐ";
            }else{
                GlobalCommon.ShowErrorMessager("Bạn phải chọn tất cả các ô tương ứng");
            }
        }

        
    }
}
