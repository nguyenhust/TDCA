using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NETLINK.LIB;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NETLINK.UI
{
    public partial class GridViewHoaDon : System.Windows.Forms.UserControl
    {
        #region Name Of Column
        private string ColMaHoaDon = "MaHoaDon";
        private string ColNgayHoaDon = "NgayHoaDon";
        private string ColSoTien = "SoTien";
        private string ColNoiXuat = "NoiXuat";
        private string ColHoanTien = "HoanTien";
        private string ColSoPT = "GhiChu";
        private string ColSTT = "STT";
        #endregion 
        private string c_maHoaDon = "grmhd";
        private string c_sotien = "grst";
        private string c_ngaynop = "grnn";
        private long tongTien = 0;
        private int tongSoHoaDon = 0;
        private string x_maHoaDon = string.Empty;
        private string x_ngayHoaDon = string.Empty;
        private string x_soTien = string.Empty;
        private string x_allInOne = string.Empty;
        private string x_soPT = string.Empty;
        private string spearte = ",";
        private string spearte2 = "^";
        

#region Variable
         private netLink_DatePicker datepicker = new netLink_DatePicker();
#endregion

        public GridViewHoaDon()
        {
            InitializeComponent();
        }

        private void radGridView1_DefaultValuesNeeded(object sender, GridViewRowEventArgs e)
        {
            try
            {
                GridViewRowInfo rowInfo = ((MasterGridViewTemplate)sender).CurrentRow;
                rowInfo.Cells[ColMaHoaDon].Value = GetCacheForMaHoaDon();
                rowInfo.Cells[ColNgayHoaDon].Value = GetCacheForNgayHoaDon();
                rowInfo.Cells[ColSoTien].Value = GetCachForSoTien();
                rowInfo.Cells[ColSoPT].Value = "0";

            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void radGridView1_UserAddingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            try
            {
                GridViewRowInfo rowInfo = ((MasterGridViewTemplate)sender).CurrentRow;
                if (!ValidateData(rowInfo))
                {
                    e.Cancel = true;
                }
                else
                {
                    GlobalCommon.CacheWriter(c_maHoaDon, rowInfo.Cells[ColMaHoaDon].Value);
                    GlobalCommon.CacheWriter(c_ngaynop, rowInfo.Cells[ColNgayHoaDon].Value);
                    GlobalCommon.CacheWriter(c_sotien, rowInfo.Cells[ColSoTien].Value);
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private string GetCacheForMaHoaDon()
        {
            object obj = GlobalCommon.CacheReader(c_maHoaDon);
            if (obj != null)
                return obj.ToString();
            else
                return string.Empty;
        }
        private string GetCacheForNgayHoaDon()
        {
            object obj = GlobalCommon.CacheReader(c_ngaynop);
            if (obj != null)
                return obj.ToString();
            else
                return string.Empty;
        }
        private string GetCachForSoTien()
        {
            object obj = GlobalCommon.CacheReader(c_sotien);
            if (obj != null)
                return obj.ToString();
            else
                return string.Empty;
        }

        private bool ValidateData(GridViewRowInfo rowInfo)
        {
            try
            {
                string temp = string.Empty;
                if (rowInfo == null)
                {
                    return false;
                }
                else
                {
                    if (GlobalCommon.CheckArrayTextIsNull(new object[] { rowInfo.Cells[ColNgayHoaDon].Value, rowInfo.Cells[ColMaHoaDon].Value, rowInfo.Cells[ColSoTien].Value,rowInfo.Cells[ColSoPT].Value }))
                    {
                        GlobalCommon.ShowErrorMessager("Bạn phải nhập đủ tất cả các thông tin");
                        return false;
                    }
                    datepicker.Text = rowInfo.Cells[ColNgayHoaDon].Value.ToString();
                    datepicker.ConvertData();
                    if (!datepicker.isDateTime && !datepicker.isNull)
                    {
                        GlobalCommon.ShowErrorMessager(datepicker.Value_Error);
                        return false;
                    }
                    if(!GlobalCommon.CheckIsNumberLong(rowInfo.Cells[ColSoTien].Value.ToString()))
                    {
                        GlobalCommon.ShowErrorMessager("'Số tiền' phải là số");
                        return false;
                    }
                    if (Convert.ToInt64(rowInfo.Cells[ColSoTien].Value) > 999999999999)
                    {
                        GlobalCommon.ShowErrorMessager("Phần mềm không chấp nhận số tiền lớn hơn 1 ngàn tỷ");
                        return false;
                    }
                    if (rowInfo.Cells[ColMaHoaDon].Value.ToString().IndexOf(spearte) >= 0 || rowInfo.Cells[ColMaHoaDon].Value.ToString().IndexOf(spearte) >= 0)
                    {
                        GlobalCommon.ShowErrorMessager(string.Format("Mã hóa đơn không được chứ kí tự '{0}' hoặc '{1}'", spearte, spearte2));
                        return false;
                    }
                    foreach (GridViewRowInfo rowInfoX in radGridView1.ChildRows)
                    {
                        if (rowInfo.Cells[ColMaHoaDon].Value.ToString() == rowInfoX.Cells[ColMaHoaDon].Value.ToString())
                        {
                            GlobalCommon.ShowErrorMessager("Mã hóa đơn đã tồn tại");
                            return false;
                        }
                    }
                    rowInfo.Cells[ColNgayHoaDon].Value = datepicker.Value_String;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void radGridView1_UserAddedRow(object sender, GridViewRowEventArgs e)
        {
            try
            {
                CalculateTotal();
            }
            catch (Exception ex_)
            {
            }
        }

        private void radGridView1_UserDeletedRow(object sender, GridViewRowEventArgs e)
        {
            try
            {
                CalculateTotal();
            }
            catch (Exception ex_)
            {
            }
        }
        private void CalculateTotal()
        {
            tongTien = 0;
            tongSoHoaDon = 0;
            long temp = 0;
            foreach (GridViewRowInfo row in radGridView1.ChildRows)
            {
                if (long.TryParse(row.Cells[ColSoTien].Value.ToString(), out temp))
                {
                    tongSoHoaDon++;
                    tongTien += temp;
                }
            }
            //tongTien *= 1000;
            lbSLHoaDon.Text = tongSoHoaDon.ToString();
            lbTongTien.Text = string.Format("{0} vnđ", GlobalCommon.ConvertMoney(tongTien));
        }
        private void BindData()
        {
            try
            {
                radGridView1.Rows.Clear();
                if (!string.IsNullOrEmpty(x_maHoaDon) && !string.IsNullOrEmpty(x_ngayHoaDon) && !string.IsNullOrEmpty(x_soTien) && !string.IsNullOrEmpty(x_soPT))
                {
                    
                    string[] y_ma = x_maHoaDon.Split(new string[] { spearte }, StringSplitOptions.RemoveEmptyEntries);
                    string[] y_ngay = x_ngayHoaDon.Split(new string[] { spearte }, StringSplitOptions.RemoveEmptyEntries);
                    string[] y_tien = x_soTien.Split(new string[] { spearte }, StringSplitOptions.RemoveEmptyEntries);
                    string[] y_pt = x_soPT.Split(new string[] { spearte }, StringSplitOptions.RemoveEmptyEntries);
                    if (y_ma.Length != y_ngay.Length || y_ma.Length != y_tien.Length || y_ma.Length != y_pt.Length)
                    {
                        return;
                    }
                    else
                    {

                        for (int i = 0; i < y_ma.Length; i++)
                        {
                            GridViewRowInfo itemInfo = radGridView1.Rows.AddNew();
                            itemInfo.Cells[ColMaHoaDon].Value = y_ma[i];
                            itemInfo.Cells[ColNgayHoaDon].Value = y_ngay[i];
                            itemInfo.Cells[ColSoTien].Value = y_tien[i];
                            itemInfo.Cells[ColSoPT].Value = y_pt[i];
                        }
                    }

                }
                else if (!string.IsNullOrEmpty(x_allInOne))
                {
                    string[] yAllInOne = x_allInOne.Split(new string[] { spearte2 }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < yAllInOne.Length; i++)
                    {
                        string[] rowSplit = yAllInOne[i].Split(new string[] { spearte }, StringSplitOptions.RemoveEmptyEntries);
                        GridViewRowInfo itemInfo = radGridView1.Rows.AddNew();
                        itemInfo.Cells[ColMaHoaDon].Value = rowSplit[0];
                        itemInfo.Cells[ColNgayHoaDon].Value = rowSplit[1];
                        itemInfo.Cells[ColSoTien].Value = rowSplit[2];
                        itemInfo.Cells[ColSoPT].Value = rowSplit[3];
                    }
                }
                CalculateTotal();

            }
            catch (Exception ex)
            {
                radGridView1.Rows.Clear();
            }
        }
        private void PrintValue()
        {
            try
            {
                x_maHoaDon = string.Empty;
                x_ngayHoaDon = string.Empty;
                x_soTien = string.Empty;
                x_soPT = string.Empty;
                x_allInOne = string.Empty;
                foreach (GridViewRowInfo itemInfo in radGridView1.ChildRows)
                {
                    x_maHoaDon = string.Format("{0}{2}{1}",x_maHoaDon,spearte, itemInfo.Cells[ColMaHoaDon].Value.ToString());
                    x_ngayHoaDon = string.Format("{0}{2}{1}", x_ngayHoaDon, spearte, itemInfo.Cells[ColNgayHoaDon].Value.ToString());
                    x_soTien = string.Format("{0}{2}{1}", x_soTien, spearte, itemInfo.Cells[ColSoTien].Value.ToString());
                    x_soPT = string.Format("{0}{2}{1}", x_soPT, spearte, itemInfo.Cells[ColSoPT].Value.ToString());
                    x_allInOne += string.Format("{0}{1}{2}{1}{3}{1}{4}{5}", itemInfo.Cells[ColMaHoaDon].Value.ToString(), spearte, itemInfo.Cells[ColNgayHoaDon].Value.ToString(), itemInfo.Cells[ColSoTien].Value.ToString(),itemInfo.Cells[ColSoPT].Value.ToString(), spearte2);
                }
                if (string.IsNullOrEmpty(x_maHoaDon) || string.IsNullOrEmpty(x_ngayHoaDon) || string.IsNullOrEmpty(x_soTien) || string.IsNullOrEmpty(x_soPT) || string.IsNullOrEmpty(x_allInOne))
                {
                    x_maHoaDon = string.Empty;
                    x_ngayHoaDon = string.Empty;
                    x_soTien = string.Empty;
                    x_soPT = string.Empty;
                    x_allInOne = string.Empty;
                }
            }
            catch (Exception ex)
            {
                x_maHoaDon = string.Empty;
                x_ngayHoaDon = string.Empty;
                x_soTien = string.Empty;
                x_soPT = string.Empty;
                x_allInOne = string.Empty;
            }
        }
        /// <summary>
        /// Lấy tổng số tiền trên tất cả các hóa đơn
        /// </summary>
        public long Value_GetTongTien
        {
            get { return tongTien; }
        }

        /// <summary>
        /// Lấy tổng số lượng hóa đơn
        /// </summary>
        public long Value_GetTongSoHoaDon
        {
            get { return tongSoHoaDon; }
        }

        /// <summary>
        /// Lấy tất cả  các mã hóa đơn (cách nhau bởi dấu ",")
        /// </summary>
        public string Value_MaHoaDon
        {
            get
            {
                PrintValue();
                return x_maHoaDon;
            }
            set
            {
                x_maHoaDon = value;
                BindData();
            }
        }

        /// <summary>
        /// Lấy tất cả ngày xuất hóa đơn (cách nhau bởi dấu ",")
        /// </summary>
        public string Value_NgayHoaDon
        {
            get
            {
                PrintValue();
                return x_ngayHoaDon;
            }
            set
            {
                x_ngayHoaDon = value;
                BindData();
            }
        }

        /// <summary>
        /// Lấy tất cả số tiền trên hóa đơn (cách nhau bởi dấu ",")
        /// </summary>
        public string Value_TienTrenHoaDon
        {
            get
            {
                PrintValue();
                return x_soTien;
            }
            set
            {
                x_soTien = value;
                BindData();
            }
        }

        public string Value_SoPhieuThu
        {
            get
            {
                PrintValue();
                return x_soPT;
            }
            set
            {
                x_soPT = value;
                BindData();
            }
        }

        /// <summary>
        /// Lấy tất cả thông tin trong control (chỉ dùng để lưu trữ)
        /// </summary>
        public string Value_AllInOne
        {
            get
            {
                PrintValue();
                return x_allInOne;
            }
            set
            {
                x_allInOne = value;
                BindData();
            }
        }
        public bool Enabled
        {
            get
            {
                return radGridView1.Enabled;
            }
            set
            {
                radGridView1.Enabled = value;
            }
        }

        private void radGridView1_Click(object sender, EventArgs e)
        {

        }

    



   


    }
}
