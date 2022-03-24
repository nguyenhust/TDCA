using NETLINK.LIB;
using NETLINK.UI;
using ModuleDaoTao.LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;
using ExportLib;
using Authoration.LIB;

namespace ModuleDaoTao.UI
{
    public partial class Form_LT_ThongKe : Telerik.WinControls.UI.RadForm
    {
        private DT_LienTuc_HocVien_Coll listHV;
        private BusinessFunction function;
        private Dictionary<string, int> result;
        private int TongSoHV;
        private const string PreTrinhDo = "1$Trình độ_";
        private const string PreChuyenKhoa = "4$Chuyên khoa đăng kí học_";
        private const string PreChuyenNganhTN = "8$Chuyên ngành đã tốt nghiệp_";
        private const string PreGiayChungNhan = "6$Giấy chứng nhận_";
        private const string PreGioiTinh = "0$Giới tính_";
        private const string PreTenLop = "5$Nội dung học_";
        private const string PreTrangThai = "2$Trạng thái_";
        private const string PreTinhThanh = "8$Tỉnh thành_";
        private const string PreXepLoai = "3$Xếp loại_";
        private const string PreBenhVien = "7$Nơi công tác_";
        private const string BoTrongKhongNhap = "(Bị bỏ trống)";

        public Form_LT_ThongKe()
        {
            InitializeComponent();
        }

        private void Form_LT_ThongKe_Load(object sender, EventArgs e)
        {
            try
            {
                dropDownBoPhan1.FillData(1);
                dropDownLoaiHinhDaoTao1.FillData();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void dropDownLoaiHinhDaoTao1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
            {
                if (dropDownLoaiHinhDaoTao1.Text == "Theo Lớp")
                    panel1.Visible = true;
                else
                    panel1.Visible = false;
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void LoadData()
        {
            function = new BusinessFunction(BusinessFunctionMode.GetHocVienLienTucThongKe);
            function.ItemFilterCondition_Date = netLink_DatePicker1.Value;
            function.ItemFilterCondition_Date2 = netLink_DatePicker2.Value;
            function.ItemFilterCondition_Int = Convert.ToInt32(dropDownBoPhan1.Selected_ID);
            function.ItemFilterCondition_String = dropDownLoaiHinhDaoTao1.Text;
            if (radRadioButton1.IsChecked)
                function.ItemFilterCondition_Int2 = DT_Common.IN_DaXepLop;
            else if (radRadioButton2.IsChecked)
                function.ItemFilterCondition_Int2 = DT_Common.IN_ChuaXepLop;
            else
                function.ItemFilterCondition_Int2 = DT_Common.IN_XepLop_All;

            listHV = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
        }
        private void CheckPlusOrInsertKey(string key)
        {
            if (result.ContainsKey(key))
            {
                result[key]++;
            }
            else
            {
                result.Add(key,1);
            }
        }
        private void ProcessData()
        {
            result = new Dictionary<string, int>();
            TongSoHV = 0;
            foreach (DT_LienTuc_HocVien_Info hv in listHV)
            {
                if (function.ItemFilterCondition_String == "Kèm cặp" || function.ItemFilterCondition_Int2== DT_Common.IN_XepLop_All || (function.ItemFilterCondition_Int2 == DT_Common.IN_DaXepLop && !string.IsNullOrEmpty(hv.MaLopHoc)) || (function.ItemFilterCondition_Int2 == DT_Common.IN_ChuaXepLop && string.IsNullOrEmpty(hv.MaLopHoc)))
                {
                    if (string.IsNullOrEmpty(hv.TenTrinhDo))
                        CheckPlusOrInsertKey(PreTrinhDo + BoTrongKhongNhap);
                    else
                        CheckPlusOrInsertKey(PreTrinhDo + hv.TenTrinhDo);

                    if (string.IsNullOrEmpty(hv.TenChuyenKhoaLopHoc))
                        CheckPlusOrInsertKey(PreChuyenKhoa + BoTrongKhongNhap);
                    else
                        CheckPlusOrInsertKey(PreChuyenKhoa + hv.TenChuyenKhoaLopHoc);

                    if (string.IsNullOrEmpty(hv.TenBenhVien))
                        CheckPlusOrInsertKey(PreBenhVien + BoTrongKhongNhap);
                    else
                        CheckPlusOrInsertKey(PreBenhVien + hv.TenBenhVien);

                    if (string.IsNullOrEmpty(hv.TenLopHoc))
                        CheckPlusOrInsertKey(PreTenLop + BoTrongKhongNhap);
                    else
                        CheckPlusOrInsertKey(PreTenLop + hv.TenLopHoc);

                    if (string.IsNullOrEmpty(hv.TenTinhThanh))
                        CheckPlusOrInsertKey(PreTinhThanh + BoTrongKhongNhap);
                    else
                        CheckPlusOrInsertKey(PreTinhThanh + hv.TenTinhThanh);

                    if (string.IsNullOrEmpty(hv.XepLoai))
                        CheckPlusOrInsertKey(PreXepLoai + BoTrongKhongNhap);
                    else
                        CheckPlusOrInsertKey(PreXepLoai + hv.XepLoai);

                    if (string.IsNullOrEmpty(hv.TrangThai))
                        CheckPlusOrInsertKey(PreTrangThai + BoTrongKhongNhap);
                    else
                        CheckPlusOrInsertKey(PreTrangThai + hv.TrangThai);

                    if (string.IsNullOrEmpty(hv.GioiTinh))
                        CheckPlusOrInsertKey(PreGioiTinh + BoTrongKhongNhap);
                    else
                        CheckPlusOrInsertKey(PreGioiTinh + hv.GioiTinh);

                    if (string.IsNullOrEmpty(hv.TenChuyenNganh))
                        CheckPlusOrInsertKey(PreChuyenNganhTN + BoTrongKhongNhap);
                    else
                        CheckPlusOrInsertKey(PreChuyenNganhTN + hv.TenChuyenNganh);

                    if (hv.TongSoLanInGiayChungNhan > 0)
                        CheckPlusOrInsertKey(PreGiayChungNhan + "Đã In chứng chỉ");
                    else
                        CheckPlusOrInsertKey(PreGiayChungNhan + "Chưa In chứng chỉ");
                    TongSoHV++;
                }
            }
        }
        private string GetPredictFullName(string root)
        {
            for (int i = 0; i < 10; i++)
            {
                root = root.Replace(string.Format("{0}$", i), string.Empty);
            }
            root = root.Substring(0, root.IndexOf("_"));
            return root;
        }
        private string RemovePredict(string root)
        {
            root = root.Replace(PreTrinhDo, string.Empty);
            root = root.Replace(PreChuyenKhoa, string.Empty);
            root = root.Replace(PreGiayChungNhan, string.Empty);
            root = root.Replace(PreGioiTinh, string.Empty);
            root = root.Replace(PreTenLop, string.Empty);
            root = root.Replace(PreTrangThai, string.Empty);
            root = root.Replace(PreTinhThanh, string.Empty);
            root = root.Replace(PreXepLoai, string.Empty);
            root = root.Replace(PreBenhVien, string.Empty);
            root = root.Replace(PreChuyenNganhTN, string.Empty);
            return root;
        }
        private void PrintToHTML()
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Đề mục", "Số lượng học viên" };
            string lastkey = string.Empty;
            foreach (var r in result.OrderBy(i => i.Key))
            {
                if (lastkey != GetPredictFullName(r.Key))
                {
                    ExportLib.Entities.HanhChinh.B100_Table rKey = new ExportLib.Entities.HanhChinh.B100_Table();
                    rKey.E_Value = new List<string>() { string.Empty, string.Empty};
                    cv.E_Content.Add(rKey);
                    ExportLib.Entities.HanhChinh.B100_Table rKey2 = new ExportLib.Entities.HanhChinh.B100_Table();
                    rKey2.E_Value = new List<string>() { string.Format("<center><b>Phân loại theo {0}</b></center>",GetPredictFullName(r.Key)), string.Empty};
                    cv.E_Content.Add(rKey2);
                    lastkey = GetPredictFullName(r.Key);
                }
                ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                cvItem.E_Value = new List<string>() { RemovePredict(r.Key),r.Value.ToString() };
                cv.E_Content.Add(cvItem);

            }
            cv.E_TenTrungTam = dropDownBoPhan1.Selected_TextValue.ToString();
            cv.E_TenBenhVien = "Trung tâm TDC";
            cv.E_TieuDeBaoCao = "Báo cáo thống kê tổng hợp";
            cv.E_TuNgayDenNgay = string.Format("Khai giảng trong khoảng từ ngày {0} đến ngày {1}", netLink_DatePicker1.Value_String, netLink_DatePicker2.Value_String);
            cv.E_IsUseTongSo = false;
            cv.E_ThongTinKhac = string.Format("Dành cho học viên loại hình {0} - Tổng số: {1}", dropDownLoaiHinhDaoTao1.Text, TongSoHV);
           // cv.E_ThongTinTongHop = string.Format("Dành cho học viên {0} - Tổng số: {1}",dropDownLoaiHinhDaoTao1.Text,listHV.Count.ToString());
            cv.E_NguoiKi = PTIdentity.FullName;
            
            //cv.ProcessTuNgayDenNgay(5); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }
        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                ProcessData();
                PrintToHTML();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
    }
}
