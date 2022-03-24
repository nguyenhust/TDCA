using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExportLib.Entities.HanhChinh
{
    public class B100_BaoCaoChung
    {
        public B100_BaoCaoChung()
        {
            E_TenTrungTam = "VĂN PHÒNG TRUNG TÂM";
            E_TieuDeBaoCao = "BÁO CÁO TỔNG HỢP";
            E_TieuDeLop = "";
            E_MaLop = "";
            E_TuNgayDenNgay = "Từ ngày.......... Đến ngày..........";
            DateTime today = DateTime.Now;
            E_HaNoiNgayThangNam = "Hà Nội, ngày " + today.Day.ToString() + " tháng " + today.Month.ToString() + " năm " + today.Year.ToString();
            E_NguoiKi = string.Empty;
            AutoGenSTT = true;
            IsNamDoc = true;
            E_TuDinhDangWidth = false;
            E_IsUseTongSo = true;
            E_isCenter = false;
            E_TenBenhVien = "BỆNH VIỆN BẠCH MAI";
            //E_NoiLapBC = "TDC, ";
            E_Phong1 = string.Empty;
            E_Phong2 = string.Empty;
            E_P1 = string.Empty;
            E_P2 = string.Empty;
            //E_SoTiet = string.Empty;
            //E_QuyetDinh = string.Empty;
        }
        public bool IsNamDoc
        {
            
            set
            {
                if (value)
                {
                    E_PaperWidth = "208mm";//210
                }
                else
                {
                    E_PaperWidth = "295mm";//297
                }
            }
        }
        public string E_SoTiet { get; set; }
        public string E_QuyetDinh { get; set; }
        public string E_P1 { get; set; }
        public string E_P2 { get; set; }
        public string E_Phong1 { get; set; }
        public string E_Phong2 { get; set; }
        public string E_TenBenhVien { get { return e_tenbenhvien; } set { e_tenbenhvien = value.ToUpper(); } }
        public bool E_IsUseTongSo { get; set; }
        public bool E_TuDinhDangWidth { get; set; }
        public string E_PaperWidth { get; set; }
        public string E_FilterExpression { get; set; }
        private string e_tenbenhvien;
        private string e_tentrungtam;
        private string e_tieudebaocao;
        private string e_malop;
        private string e_tieudelop;
        private string e_conghoaxahoi = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM";
        private string e_doclaptudo= "ĐỘC LẬP - TỰ DO - HẠNH PHÚC";
        public string E_TenTrungTam { get { return e_tentrungtam; } set { e_tentrungtam = value.ToUpper(); } }
        public string E_TieuDeBaoCao { get { return e_tieudebaocao; } set { e_tieudebaocao = value.ToUpper(); } }
        public string E_TieuDeLop { get { return e_tieudelop; } set { e_tieudelop = value; } }
        public string E_MaLop { get { return e_malop; } set { e_malop = value.ToUpper(); } }
        public string E_CongHoaXaHoi { get { return e_conghoaxahoi; } set { e_conghoaxahoi = value.ToUpper(); } }
        public string E_DocLapTuDo { get { return e_doclaptudo; } set { e_doclaptudo = value.ToUpper(); } }
        public string E_ThongTinKhac { get; set; }
        public string E_TuNgayDenNgay { get; set; }
        public string E_ThongTinTongHop { get; set; }
        public string E_CellHeight { get; set; }
        public string E_TenTrungTamLapBC { get; set; }
        public string E_NoiLapBC { get; set; }
        public string E_TongSoBanGhi
        {
            get
            {
                if (E_Content != null)
                    return E_Content.Count.ToString();
                else
                    return "0";
            }
        }
        public bool AutoGenSTT { get; set; }
        public bool E_isCenter { get; set; }
        public string E_HaNoiNgayThangNam { get; set; }
        public string E_NguoiKi { get; set; }
        /// <summary>
        /// Nếu thêm kí tự [$.. thì cột đó sẽ không hiện ra
        /// </summary>
        public List<string> E_TieuDe { get; set; }

        public List<string> E_Width { get; set; }
        /// <summary>
        /// Nếu thêm kí tự [$.. thì cột đó sẽ không hiện ra
        /// </summary>
        public List<B100_Table> E_Content
        {
            get;
            set;
        }
        public void ProcessTuNgayDenNgay(string minDate, string maxDate)
        {
            E_TuNgayDenNgay = string.Format("Từ ngày {0} đến ngày {1}", minDate, maxDate);
        }
        public void ProcessTuNgayDenNgay(DateTime minDate, DateTime maxDate)
        {
            E_TuNgayDenNgay = string.Format("Từ ngày {0} đến ngày {1}", minDate.ToShortDateString(), maxDate.ToShortDateString());
        }
        public void ProcessTuNgayDenNgay(int SoThuTuTruongNgayThang)
        {

            DateTime minDate = new DateTime(3000, 12, 30);
            DateTime maxDate = new DateTime(1900, 1, 1);
            DateTime temDate;
            foreach (B100_Table tb in E_Content)
            {
                string x = tb.E_Value[SoThuTuTruongNgayThang].Replace("[$..",string.Empty);
                if (DateTime.TryParse(x, out temDate))
                {
                    if (DateTime.Compare(temDate, minDate) < 0)
                    {
                        minDate = temDate;
                    }
                    if (DateTime.Compare(temDate, maxDate) > 0)
                    {
                        maxDate = temDate;
                    }

                }
            }
            ProcessTuNgayDenNgay(minDate, maxDate);
        }
    }
    public class B100_Table
    {
        public List<string> E_Value { get; set; }
    }

    public class B103_HVduoccapchungchitheolop
    {
        public B103_HVduoccapchungchitheolop()
        {
            E_TenTrungTam = "VĂN PHÒNG TRUNG TÂM";
            E_TieuDeBaoCao = "BÁO CÁO TỔNG HỢP";
            E_TieuDeLop = "";
            E_MaLop = "";
            E_TuNgayDenNgay = "Từ ngày.......... Đến ngày..........";
            DateTime today = DateTime.Now;
            E_HaNoiNgayThangNam = "Hà Nội, ngày " + today.Day.ToString() + " tháng " + today.Month.ToString() + " năm " + today.Year.ToString();
            E_NguoiKi = string.Empty;
            AutoGenSTT = true;
            IsNamDoc = true;
            E_TuDinhDangWidth = false;
            E_IsUseTongSo = true;
            E_isCenter = false;
            E_TenBenhVien = "BỆNH VIỆN BẠCH MAI";
            //E_NoiLapBC = "TDC, ";
            E_Phong1 = string.Empty;
            E_Phong2 = string.Empty;
            E_P1 = string.Empty;
            E_P2 = string.Empty;
            E_SoTiet = string.Empty;
            E_QuyetDinh = string.Empty;
        }
        public bool IsNamDoc
        {

            set
            {
                if (value)
                {
                    E_PaperWidth = "208mm";//210
                }
                else
                {
                    E_PaperWidth = "295mm";//297
                }
            }
        }
        public string E_SoTiet { get; set; }
        public string E_QuyetDinh { get; set; }
        public string E_P1 { get; set; }
        public string E_P2 { get; set; }
        public string E_Phong1 { get; set; }
        public string E_Phong2 { get; set; }
        public string E_TenBenhVien { get { return e_tenbenhvien; } set { e_tenbenhvien = value.ToUpper(); } }
        public bool E_IsUseTongSo { get; set; }
        public bool E_TuDinhDangWidth { get; set; }
        public string E_PaperWidth { get; set; }
        public string E_FilterExpression { get; set; }
        private string e_tenbenhvien;
        private string e_tentrungtam;
        private string e_tieudebaocao;
        private string e_malop;
        private string e_tieudelop;
        private string e_conghoaxahoi = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM";
        private string e_doclaptudo = "ĐỘC LẬP - TỰ DO - HẠNH PHÚC";
        public string E_TenTrungTam { get { return e_tentrungtam; } set { e_tentrungtam = value.ToUpper(); } }
        public string E_TieuDeBaoCao { get { return e_tieudebaocao; } set { e_tieudebaocao = value.ToUpper(); } }
        public string E_TieuDeLop { get { return e_tieudelop; } set { e_tieudelop = value.ToUpper(); } }
        public string E_MaLop { get { return e_malop; } set { e_malop = value.ToUpper(); } }
        public string E_CongHoaXaHoi { get { return e_conghoaxahoi; } set { e_conghoaxahoi = value.ToUpper(); } }
        public string E_DocLapTuDo { get { return e_doclaptudo; } set { e_doclaptudo = value.ToUpper(); } }
        public string E_ThongTinKhac { get; set; }
        public string E_TuNgayDenNgay { get; set; }
        public string E_ThongTinTongHop { get; set; }
        public string E_CellHeight { get; set; }
        public string E_TenTrungTamLapBC { get; set; }
        public string E_NoiLapBC { get; set; }
        public string E_TongSoBanGhi
        {
            get
            {
                if (E_Content != null)
                    return E_Content.Count.ToString();
                else
                    return "0";
            }
        }
        public bool AutoGenSTT { get; set; }
        public bool E_isCenter { get; set; }
        public string E_HaNoiNgayThangNam { get; set; }
        public string E_NguoiKi { get; set; }
        /// <summary>
        /// Nếu thêm kí tự [$.. thì cột đó sẽ không hiện ra
        /// </summary>
        public List<string> E_TieuDe { get; set; }

        public List<string> E_Width { get; set; }
        /// <summary>
        /// Nếu thêm kí tự [$.. thì cột đó sẽ không hiện ra
        /// </summary>
        public List<B103_Table> E_Content
        {
            get;
            set;
        }
        public void ProcessTuNgayDenNgay(string minDate, string maxDate)
        {
            E_TuNgayDenNgay = string.Format("Từ ngày {0} đến ngày {1}", minDate, maxDate);
        }
        public void ProcessTuNgayDenNgay(DateTime minDate, DateTime maxDate)
        {
            E_TuNgayDenNgay = string.Format("Từ ngày {0} đến ngày {1}", minDate.ToShortDateString(), maxDate.ToShortDateString());
        }
        public void ProcessTuNgayDenNgay(int SoThuTuTruongNgayThang)
        {

            DateTime minDate = new DateTime(3000, 12, 30);
            DateTime maxDate = new DateTime(1900, 1, 1);
            DateTime temDate;
            foreach (B103_Table tb in E_Content)
            {
                string x = tb.E_Value[SoThuTuTruongNgayThang].Replace("[$..", string.Empty);
                if (DateTime.TryParse(x, out temDate))
                {
                    if (DateTime.Compare(temDate, minDate) < 0)
                    {
                        minDate = temDate;
                    }
                    if (DateTime.Compare(temDate, maxDate) > 0)
                    {
                        maxDate = temDate;
                    }

                }
            }
            ProcessTuNgayDenNgay(minDate, maxDate);
        }
    }
    public class B103_Table
    {
        public List<string> E_Value { get; set; }
    }

    public class B1002_BaoCaoChung
    {
        public B1002_BaoCaoChung()
        {
            E_TenTrungTam = "VĂN PHÒNG TRUNG TÂM";
            E_TieuDeBaoCao = "BÁO CÁO TỔNG HỢP";
            E_TuNgayDenNgay = "Từ ngày.......... Đến ngày..........";
            DateTime today = DateTime.Now;
            E_HaNoiNgayThangNam = "Hà Nội, ngày " + today.Day.ToString() + " tháng " + today.Month.ToString() + " năm " + today.Year.ToString();
            E_NguoiKi = string.Empty;
            AutoGenSTT = true;
            E_PaperWidth = "210mm";
        }
        public string E_PaperWidth { get; set; }
        public string E_CongHoaXaHoi { get; set; }
        public string E_DocLapTuDo { get; set; }
        public string E_FilterExpression { get; set; }
        private string e_tentrungtam;
        private string e_tieudebaocao;
        public string E_TenTrungTam { get { return e_tentrungtam; } set { e_tentrungtam = value.ToUpper(); } }
        public string E_TieuDeBaoCao { get { return e_tieudebaocao; } set { e_tieudebaocao = value.ToUpper(); } }
        public string E_TuNgayDenNgay { get; set; }
        public string E_TongSoBanGhi
        {
            get
            {
                if (E_Content != null)
                    return E_Content.Count.ToString();
                else
                    return "0";
            }
        }
        public bool AutoGenSTT { get; set; }
        public string E_HaNoiNgayThangNam { get; set; }
        public string E_NguoiKi { get; set; }
        public List<string> E_TieuDe { get; set; }
        public List<B1002_Table> E_Content
        {
            get;
            set;
        }
        public void ProcessTuNgayDenNgay(string minDate, string maxDate)
        {
            E_TuNgayDenNgay = string.Format("Từ ngày {0} đến ngày {1}", minDate, maxDate);
        }
        public void ProcessTuNgayDenNgay(DateTime minDate, DateTime maxDate)
        {
            E_TuNgayDenNgay = string.Format("Từ ngày {0} đến ngày {1}", minDate.ToShortDateString(), maxDate.ToShortDateString());
        }
        public void ProcessTuNgayDenNgay(int SoThuTuTruongNgayThang)
        {

            DateTime minDate = new DateTime(3000, 12, 30);
            DateTime maxDate = new DateTime(1900, 1, 1);
            DateTime temDate;
            foreach (B1002_Table tb in E_Content)
            {
                if (DateTime.TryParse(tb.E_Value[SoThuTuTruongNgayThang], out temDate))
                {
                    if (DateTime.Compare(temDate, minDate) < 0)
                    {
                        minDate = temDate;
                    }
                    if (DateTime.Compare(temDate, maxDate) > 0)
                    {
                        maxDate = temDate;
                    }

                }
            }
            ProcessTuNgayDenNgay(minDate, maxDate);
        }
    }
    public class B1002_Table
    {
        public List<string> E_Value { get; set; }
    }
}
