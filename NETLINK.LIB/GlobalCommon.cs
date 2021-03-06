using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Threading;
using SECURITY;
using Csla;
using Csla.Data;
using System.Runtime;
using System.Runtime.Caching;
using System.IO;
using System.Diagnostics;
using Telerik.WinControls.Data;


namespace NETLINK.LIB
{

    public enum NghiLam
    {
        KhongLyDo = 0,
        DiCongTac = 1,
        Phep = 2
    }
    public enum BusinessFunctionMode
    {
        GetAllData = 0,
        GetDataForGridView = 1,
        GetDataForReport = 2,
        GetDataForDropDown = 3,
        GetAllDataWithCondition = 4,
        GetAllDataWithCondition2 = 9,
        GetDataForGridViewWithCondition = 5,
        GetDataForGridViewWithCondition2 = 8,
        GetDataForGridViewWithCondition3 = 11,
        GetDataForReportWithCondition = 6,
        GetDataForDropDownWithCondition = 7,
        GetDataForDropDownWithCondition2 = 10,
        GetDataForGridViewChuaDongHP = 12,
        GetDataForGridViewDaDongHP = 13,
        GetDataForGridViewHoanTienHP = 28,
        GetDataForGridViewTheoLop = 14,
        GetDataForGridViewKemCap = 15,
        GetDataTheoLopDaHocForGridView = 16,
        GetDataTheoLopDangHocForGridView = 17,
        GetDataKemCapDaHocForGridView = 18,
        GetDataKemCapDangHocForGridView = 19,
        GetDataKemCapChuaHocForGridView =40,
        GetDataChoXepLopForGridView = 20,
        GetDataByNhom = 21,
        GetDateByNgayDongHoc = 22,
        Default = 23,
        GetDataWithCondition = 24,
        GetDataHenChungChiKemCap = 25,
        GetDataHenChungChiTheoLop = 26,
        GetDataBySoCMT = 27,
        GetHocVienLienTucByMaLop = 29,

        GetDTLienTuc_HVDaInChungChi = 30,
        GetDTLienTuc_HVDaInThe = 31,
        GetDTLienTuc_HVChuaInChungChi = 32,
        GetDTLienTuc_HVChuaInThe = 33,
        GetDTLienTuc_HVChuaUploadAnh = 42,

        GetDTLienTuc_DiemKemCap = 34,
        GetDTLienTuc_DiemTheoLop = 35,
        GetHocVienLienTucThongKe = 41
      
    }

    public enum LoaiCanBo
    {
        CanBoThuocTrungTamCDT = 0,
        CanBoKhoaKhacTrongBenhVien = 1,
        CanBoBenhVienKhac = 2,
        GiaoVien = 3
    }

    /// <summary>
    /// Enum cac loai benh nhan
    /// </summary>
    public enum PatientType
    {
        BENH_NHAN_DANG_DIEU_TRI = 1,
        BENH_NHAN_RA_VIEN_DA_THANH_TOAN = 2,
        BENH_NHAN_RA_VIEN_CHUA_THANH_TOAN = 3,
        BENH_NHAN_TRON_VIEN = 4,
        BENH_NHAN_TU_VONG = 5,
        BENH_NHAN_CHUYEN_KHOA_CHUA_THANH_TOAN = 6,
        BENH_NHAN_THANH_TOAN_CHUA_RA_VIEN = 7,
        BENH_NHAN_THAN_TOAN_CHUA_CHUYEN_KHOA = 8,
        BENH_NHAN_KHONG_SU_DUNG_DICH_VU = 9,
        TAT_CA_BENH_NHAN = 10
    }
    public enum LoaiXuatNhap
    {
        PhieuXuat =2,
        PhieuNhap =1
    }
    public enum LoaiPhieu
    {
        PhieuBanGiaoThietBi = 2,
        PhieuMuonThietBi = 1
    }

    /// <summary>
    /// Trạng thái của bệnh nhân ngoại trú
    /// </summary>
    public enum PatientStatus
    {
        CHO_KHAM = 1,
        CHO_VE = 2,
        KE_DON = 3,
        NHAP_VIEN = 4,
        CHUYEN_VIEN = 5
    }
    /// <summary>
    /// Enum kiểu Convert
    /// Define by: Nguyen Anh Duc
    /// </summary>
    public enum ConvertType
    {
        StringType = 1,
        NumberType = 2
    }

    /// <summary>
    /// Enum kiểu tìm kiếm đối với các giá trị logic
    /// Define by: Nguyen Anh Duc
    /// </summary>
    public enum FindBooleanType
    {
        TRUE = 1,
        FALSE = 0,
        ALL = -1
    }

    /// <summary>
    /// Enum định dạng kiểu ngày
    /// Define by: Nguyen Anh Duc
    /// </summary>
    public enum FormatDate
    {
        MM_DD_YYYY = 0,
        DD_MM_YYYY = 1
    }

    /// <summary>
    /// Kiểu cập nhật dữ liệu
    /// </summary>
    public enum UpdateDataType
    {
        INSERT = 0,
        UPDATE = 1,
        DELETE = 2
    }

    /// <summary>
    /// Enum dung de chuyen ngay trong bao cao
    /// </summary>
    public enum NLKtimetype
    {
        NLK_DATE = 0,
        NLK_MONTH = 1,
        NLK_QUATER = 2,
        NLK_YEAR = 3,
        NLK_DATEERROR = 4
    }
    public enum FormAction
    {
        Insert = 0,
        Edit = 1,
        View = 2,
        Print = 3,
        Delete = 4,
        Download = 5,
        Other = 6
    }
    /// <summary>
    /// Enum cac tham so cho phep tung nguoi dung dinh nghia
    /// </summary>
    public enum ThamSo
    {
        TU_LUU_DON_THUOC_KHI_XAC_NHAN = 1,
        TU_TAO_TEN_DON_THUOC = 2,
        TU_HIEN_DU_LIEU_LEN_LUOI = 3,
        HIEN_THI_BENH_NHAN_TOI_DIEU_TRI = 4,
        HIEN_THI_BENH_NHAN_THEO_SO_GIUONG = 5,
        KHONG_XEM_TRUOC_KHI_IN = 6,
        THU_PHI_DUNG_MAY_DOC_BARCODE = 7
    }

    public enum PatientTable
    {
        IP_BENH_NHAN = 1,
        OP_TIEP_NHAN_BENH_NHAN = 2
    }

    public enum CDTReport
    {
        HC_CongVanDen = 0,
        HC_CongVanDi = 1,
        HC_DangKiGiangDuong = 2,
        HC_DuTruVanPhongPham = 3,
        HC_TrangThietBi = 4
    }

    public enum FilterColumn
    {
        IDKhoaNgoai32 = 0,
        IDKhoaNgoai64 = 1,
        Date = 2
    }
    public class NETLINK_Permission
    {
        public bool All { get; set; }
        public bool View_Condition { get; set; }
        public bool View_All { get; set; }
        public bool Insert_Condition { get; set; }
        public bool Insert_All { get; set; }
        public bool Delete_Condition { get; set; }
        public bool Delete_All { get; set; }
        public bool Edit_Conditon { get; set; }
        public bool Edit_All { get; set; }

    }
    public static class GlobalCommon
    {
        public static CultureInfo Culture { get { return CultureInfo.CreateSpecificCulture("vi-VN"); } }

        public static string[] DateFormat = new[] { "dd/MM/yyyy" };

        public static string CutYear(object year)
        {
            if (year != null)
            {
                string yearx = year.ToString();
                return yearx.Substring(yearx.Length - 2);

            }
            return string.Empty;
        }
        public static string ConvertMoney(object money)
        {
            if (money != null)
            {
                string str = string.Empty;
                char[] strsplit = money.ToString().ToCharArray();
                for (int i = strsplit.Length - 1; i > -1; i--)
                {
                    str = strsplit[i].ToString() + str;
                    if (i != strsplit.Length - 1 && i > 0 && (strsplit.Length - i) % 3 == 0)
                    {
                        str = "," + str;
                    }
                }
                return str;
            }
            else
                return string.Empty;
        }


        public static string GetTextKieuNghi(NghiLam nghi)
        {
            switch (nghi)
            {
                case NghiLam.DiCongTac: return "Đi công tác";
                    break;
                case NghiLam.Phep: return "Nghỉ Phép";
                    break;
                default: return "Không lý do";
                    break;
            }
        }
        public static class FilterProcess
        {
            public static CompositeFilterDescriptor DateInThisWeek(string fieldName)
            {

                try
                {
                    DateTime minDate;
                    DateTime maxDate;
                    switch (DateTime.Today.DayOfWeek)
                    {
                        case DayOfWeek.Monday:
                            minDate = DateTime.Today;
                            maxDate = DateTime.Today.AddDays(6);
                            break;
                        case DayOfWeek.Tuesday:
                            minDate = DateTime.Today.AddDays(-1);
                            maxDate = DateTime.Today.AddDays(5);
                            break;
                        case DayOfWeek.Wednesday:
                            minDate = DateTime.Today.AddDays(-2);
                            maxDate = DateTime.Today.AddDays(4);
                            break;
                        case DayOfWeek.Thursday:
                            minDate = DateTime.Today.AddDays(-3);
                            maxDate = DateTime.Today.AddDays(3);
                            break;
                        case DayOfWeek.Friday:
                            minDate = DateTime.Today.AddDays(-4);
                            maxDate = DateTime.Today.AddDays(2);
                            break;
                        case DayOfWeek.Saturday:
                            minDate = DateTime.Today.AddDays(-5);
                            maxDate = DateTime.Today.AddDays(1);
                            break;
                        default:
                            minDate = DateTime.Today.AddDays(-6);
                            maxDate = DateTime.Today;
                            break;

                    }
                    return DateInTerm(fieldName, minDate, maxDate);
                }
                catch (Exception ex)
                {
                    throw ex;

                }
            }

            public static CompositeFilterDescriptor DateInTerm(string fieldName, DateTime minDate, DateTime maxDate)
            {
                try
                {
                    FilterDescriptor descriptor = new FilterDescriptor();
                    CompositeFilterDescriptor compositeFilterDescriptor1 = new CompositeFilterDescriptor();
                    DateFilterDescriptor dateFilterDescriptor1 = new DateFilterDescriptor();
                    // descriptor.PropertyName = fieldName;
                    //// descriptor.Value = string.Format("({0} >= #{1}# AND {0} <= #{2}#)", fieldName, minDate.ToShortDateString(), maxDate.ToShortDateString());
                    // descriptor.Value = "(Date2 >= #08/25/2014 00:00:00# AND Date2 <= #08/28/2014 00:00:00#)";
                    // //descriptor.Operator = Dat
                    // descriptor.IsFilterEditor = true;
                    // //return descriptor;

                    dateFilterDescriptor1.IgnoreTimePart = false;
                    dateFilterDescriptor1.Operator = Telerik.WinControls.Data.FilterOperator.IsGreaterThanOrEqualTo;
                    dateFilterDescriptor1.PropertyName = fieldName;
                    dateFilterDescriptor1.Value = minDate;
                    descriptor.Operator = Telerik.WinControls.Data.FilterOperator.IsLessThanOrEqualTo;
                    descriptor.PropertyName = fieldName;
                    descriptor.Value = maxDate;
                    compositeFilterDescriptor1.FilterDescriptors.AddRange(new Telerik.WinControls.Data.FilterDescriptor[] {
            dateFilterDescriptor1,
            descriptor});
                    compositeFilterDescriptor1.IsFilterEditor = true;
                    compositeFilterDescriptor1.NotOperator = false;
                    compositeFilterDescriptor1.PropertyName = fieldName;
                    return compositeFilterDescriptor1;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public static class DateTimeProcess
        {
            public static int MinusDateTime_Month(object ealier, object later)
            {
                try
                {
                    DateTime laterx = Convert.ToDateTime(later);
                    DateTime ealierx = Convert.ToDateTime(ealier);
                    double month = GlobalCommon.TotalMonths(ealierx, laterx);
                    if (month < 1)
                        month = 1;
                    return Convert.ToInt32(month);
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }
        public static class Log
        {
            public static bool WriteLog(long idUser, string FullName, FormMode mode, string NoiDung)
            {
                return WriteLog(idUser, FullName, mode, NoiDung,string.Empty);
            }
            public static bool WriteLog(long idUser, string FullName, FormMode mode, string NoiDung,string GhiChu)
            {
                if (mode.IsInsert)
                    return WriteLog(idUser, FullName, FormAction.Insert, NoiDung,GhiChu);
                else
                    return WriteLog(idUser, FullName, FormAction.Edit, NoiDung, GhiChu);
            }
            public static bool WriteLog(long idUser, string FullName, FormAction Action, string NoiDung)
            {
                return WriteLog(idUser, FullName, Action, NoiDung, string.Empty);
            }
            public static bool WriteLog(long idUser, string FullName, FormAction Action, string NoiDung,string GhiChu)
            {
                try
                {
                    ADM_AdminTracker item = ADM_AdminTracker.NewADM_AdminTracker();
                    item.IdUser = idUser;
                    item.Date = DateTime.Now;
                    item.FullName = FullName;
                    item.GhiChu = "";
                    switch (Action)
                    {
                        case FormAction.Delete: item.JobType = "Xóa"; break;
                        case FormAction.Edit: item.JobType = "Sửa"; break;
                        case FormAction.Insert: item.JobType = "Tạo mới"; break;
                        case FormAction.Print: item.JobType = "In"; break;
                        case FormAction.View: item.JobType = "Xem"; break;
                        case FormAction.Download: item.JobType = "Download"; break;
                        default: item.JobType = "Sửa hoặc tạo mới"; break;
                    }
                    item.NoiDung = NoiDung;
                    item.ApplyEdit();
                    item.Save();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }
        public static class Helper
        {

            public static void OpenFile(string fileName)
            {
                bool isContinue = true;
                try
                {
                    Process.Start(@"Helper\" + fileName + ".html");
                    isContinue = false;
                }
                catch
                {
                }
                if (isContinue)
                {
                    try
                    {
                        Process.Start(@"Helper\" + fileName);
                        isContinue = false;
                    }
                    catch
                    {
                    }
                }

            }
        }
        public static class StringProcess
        {
            public static class ForReport
            {
                public static string TongThoiGianHoc(object batdau, object ketthuc)
                {
                    if (batdau != null && ketthuc != null && !string.IsNullOrEmpty(batdau.ToString()) && !string.IsNullOrEmpty(ketthuc.ToString()))
                        return string.Format("{0} tháng (từ ngày {1} đến ngày {2})", GlobalCommon.DateTimeProcess.MinusDateTime_Month(batdau, ketthuc).ToString(), batdau, ketthuc);
                    else
                        return "... tháng (từ ngày ........... đến ngày ...........)";
                }
                //public static string TongThoiGianHoc(object batdau, object ketthuc)
                //{
                    
                //    if (batdau != null && ketthuc != null && !string.IsNullOrEmpty(batdau.ToString()) && !string.IsNullOrEmpty(ketthuc.ToString()))
                //      System.TimeSpan diff =
                //}
                

                public static string GetSoThangHoc(Int64 IDKhungLopHoc)
                {
                    string result = string.Empty;
                    using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
                    {
                        cn.Open();
                        using (SqlCommand cm = cn.CreateCommand())
                        {
                            cm.CommandType = CommandType.Text;
                            cm.CommandText = "select ThoiGianHoc from dbo.DT_LienTuc_KhungLopHoc where ID = " + IDKhungLopHoc;
                            using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                            {
                                dr.Read();
                                try
                                {
                                    result = Convert.ToString(dr.GetString("ThoiGianHoc"));
                                }
                                catch (Exception ex) { MessageBox.Show(ex.ToString(), "Lấy số hóa đơn lỗi"); }
                            }
                        }
                    }
                    return result;
                }
                public static string TongThoiGianHocHV(object batdau, object ketthuc,string ThoiGianHoc)
                {
                
                        if (batdau != null && ketthuc != null && !string.IsNullOrEmpty(batdau.ToString()) && !string.IsNullOrEmpty(ketthuc.ToString()))
                        {
                            if (!string.IsNullOrEmpty(ThoiGianHoc))
                                return string.Format("{0}  (từ ngày {1} đến ngày {2})", ThoiGianHoc, batdau, ketthuc);
                            else
                                return string.Format("{0} tháng (từ ngày {1} đến ngày {2})", GlobalCommon.DateTimeProcess.MinusDateTime_Month(batdau, ketthuc).ToString(), batdau, ketthuc); 
                        }                            
                        else
                            return "... tháng (từ ngày ........... đến ngày ...........)";
                   
                }
                public static string RemoveSTTInMaHocVien(string maHV)
                {
                    string kc = "-KC-";
                    string tl = "-TL-";
                    string newCode = string.Empty;
                    if (maHV.IndexOf(kc) >= 0)
                    {
                        newCode = maHV.Substring(maHV.IndexOf(kc) + 1, maHV.Length - maHV.IndexOf(kc) - 1);
                    }
                    else if (maHV.IndexOf(tl) >= 0) 
                    {
                        newCode = maHV.Substring(maHV.IndexOf(tl) + 1, maHV.Length - maHV.IndexOf(tl) - 1);
                    }
                    return newCode;
                }
                /// <summary>
                /// Trả về dòng chữ Từ Ngày Đến Ngày
                /// </summary>
                /// <param name="filterExpression"></param>
                /// <returns></returns>
                public static string GetTuNgayDenNgay(string filterExpression)
                {
                    return string.Empty;
                }

                public static string VietTatMotSoKiTu(string hoTen)
                {
                    if (!string.IsNullOrEmpty(hoTen) && hoTen.Length > 16)
                    {
                        hoTen.Replace("Nguyễn", "Ng.");
                        hoTen.Replace("Thị", "T.");
                        hoTen.Replace("Văn", "V.");
                    }
                    return hoTen;
                }
                /// <summary>
                /// Trả về dòng chữ Hà Nội, Ngày tháng năm...
                /// </summary>
                /// <param name="dt"></param>
                /// <returns></returns>
                public static string HaNoiNgayThangNam(DateTime dt)
                {
                    return "Hà Nội, Ngày " + dt.Day.ToString() + " tháng " + dt.Month.ToString() + " năm " + dt.Year.ToString();
                }
                /// <summary>
                /// Trả về dòng chữ Ngày tháng năm...
                /// </summary>
                /// <param name="dt"></param>
                /// <returns></returns>
                public static string NgayThangNam(DateTime dt)
                {
                    return "Ngày " + dt.Day.ToString() + " tháng " + dt.Month.ToString() + " năm " + dt.Year.ToString();
                }
            }

            public static class NumberToString
            {
                private static string[] strSo = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
                private static int a;
                private static int b;
                private static int c;
                private static string[] slipArray(string input)
                {
                    int i = 0;
                    string[] strArray;
                    int length = input.Length;
                    if (length % 3 == 0)//Nếu chỗi chia hết cho 3 thì lấy độ dài bằng phần nguyên
                        strArray = new string[length / 3];
                    else//Nếu chỗi không chia hết cho 3 thì lấy độ dài bằng phần nguyên+1
                        strArray = new string[length / 3 + 1];
                    if (length < 3)
                        strArray[0] = input;
                    else
                    {
                        while (length >= 3)
                        {
                            strArray[i] = input.Remove(0, length - 3);
                            input = input.Remove(length - 3, 3);
                            i++;
                            length = length - 3;
                        }
                        if (length > 0)
                            strArray[i] = input;
                    }
                    return strArray;
                }
                private static string converNumToString(string[] list)
                {

                    int i;
                    string results = "";
                    int length = list.Length;
                    if (length <= 4)
                    {
                        if (length == 1)
                            results = readThousand(list[0]);
                        if (length == 2)
                            results = readThousand(list[1]) + " nghìn " + readThousand(list[0]);
                        if (length == 3)
                        {
                            if (readThousand(list[1]) != "" && readThousand(list[2]) != "")
                                results = readThousand(list[2]) + " triệu " + readThousand(list[1]) + " nghìn " + readThousand(list[0]);
                            if (readThousand(list[1]) == "" && readThousand(list[2]) != "")
                                results = readThousand(list[2]) + " triệu";
                            if (readThousand(list[1]) == "" && readThousand(list[2]) == "")
                                results = "";
                        }
                        if (length == 4)
                        {
                            if (readThousand(list[2]) != "" && readThousand(list[1]) != "")
                                results = readThousand(list[3]) + " tỷ " + readThousand(list[2]) + " triệu " + readThousand(list[1]) + " nghìn " + readThousand(list[0]);
                            if (readThousand(list[2]) == "" && readThousand(list[1]) != "")
                                results = readThousand(list[3]) + " tỷ " + readThousand(list[1]) + " nghìn " + readThousand(list[0]);
                            if (readThousand(list[2]) != "" && readThousand(list[1]) == "")
                                results = readThousand(list[3]) + " tỷ " + readThousand(list[2]) + " triệu " + readThousand(list[0]);
                            if (readThousand(list[2]) == "" && readThousand(list[1]) == "")
                                results = readThousand(list[3]) + " tỷ " + readThousand(list[0]);
                        }
                    }
                    if (length > 4)
                    {
                        string[] strArray1 = new string[3];
                        string[] strArray2 = new string[length - 3];
                        for (i = 0; i < 3; i++)
                        {
                            strArray1[i] = list[i];
                        }
                        for (i = 0; i < length - 3; i++)
                        {
                            strArray2[i] = list[3 + i];
                        }
                        //Gọi đệ quy
                        results = converNumToString(strArray2) + " tỷ " + converNumToString(strArray1);
                    }
                    return results;
                }
                private static string readThousand(string input)
                {
                    string output = "";
                    input = input.Trim();
                    string numStr = input;
                    int length = numStr.Length;
                    if (length == 1)
                        output = strSo[Convert.ToInt32(input)];
                    if (length == 2)
                    {
                        a = Convert.ToInt32(Convert.ToString(numStr[0]));
                        b = Convert.ToInt32(Convert.ToString(numStr[1]));
                        if (a != 1)
                        {
                            if (b != 5 && b != 0 && b != 1)
                                output = strSo[a] + " mươi " + readThousand(Convert.ToString(numStr[1]));
                            if (b == 5)
                                output = strSo[a] + " mươi lăm";
                            if (b == 0)
                                output = strSo[a] + " mươi";
                            if (b == 1)
                                output = strSo[a] + " mươi mốt";
                        }
                        if (a == 1)
                        {
                            if (b != 5)//chỗ này phải thêm đoạn &&b!==0 khưng mà nó đè ở dưới rồi nên lười viết kết quả vẫn đúng
                                output = "mười " + readThousand(Convert.ToString(numStr[1]));
                            else
                                output = "mười lăm";
                            if (b == 0)
                                output = "mười";
                        }
                    }
                    if (length == 3)
                    {
                        a = Convert.ToInt32(Convert.ToString(numStr[0]));
                        b = Convert.ToInt32(Convert.ToString(numStr[1]));
                        c = Convert.ToInt32(Convert.ToString(numStr[2]));
                        if (b == 0 && c != 0)
                            output = strSo[a] + " trăm linh " + readThousand(Convert.ToString(numStr[2]));
                        if (b != 0 && c != 0)
                            output = strSo[a] + " trăm " + readThousand(Convert.ToString(numStr[1]) + Convert.ToString(numStr[2]));
                        if (b == 0 && c == 0)
                        {
                            output = strSo[a] + " trăm";
                        }
                        if (a != 0 && b != 0 && c == 0)
                        {
                            output = strSo[a] + " trăm " + readThousand(Convert.ToString(numStr[1]) + Convert.ToString(numStr[2]));
                        }
                        if (a == 0 && b == 0 && c == 0)
                        {
                            output = "";
                        }
                    }
                    return output;
                }
                public static string ConvertToString(object NumberToConvert)
                {
                    long x = 0;
                    if(NumberToConvert != null && long.TryParse(NumberToConvert.ToString(), out x))
                    {
                        return (converNumToString(slipArray(NumberToConvert.ToString())));
                    }
                    return string.Empty;
                }
                public static string ConvertToStringMoney(object NumberToConvert)
                {
                    return string.Format("{0} VNĐ", ConvertToString(NumberToConvert));
                }
            }

            public static string UpperFirstChar(string str)
            {
                str = str.Trim();
                char[] charx = str.ToCharArray();
                str = string.Empty;
                char lastChar = ' ';
                for (int i = 0; i < charx.Length; i++)
                {
                    if(char.IsWhiteSpace(lastChar))
                    {
                        charx[i] = char.ToUpper(charx[i]);
                    }
                    str += charx[i].ToString();
                    lastChar = charx[i];
                }
                return str;
            }

            
        }
        public static string GenLastEditString(string name, string time)
        {
            return string.Format("Chỉnh sửa lần cuối bởi '{0}' lúc {1}", name, time);
        }
        public static bool CheckIsNumberLong(string text)
        {
            if (string.IsNullOrEmpty(text))
                return true;
            long x;
            return long.TryParse(text, out x);
        }
        public static bool CheckIsNumber(string text)
        {
            if (string.IsNullOrEmpty(text))
                return true;
            int x;
            return int.TryParse(text, out x);
        }
        public static bool CheckIsDiem(string[] text)
        {
            foreach (string str in text)
            {
                if (!CheckIsDiem(str))
                    return false;
            }
            return true;
        }
        public static bool CheckIsDiem(string text)
        {
            if (string.IsNullOrEmpty(text))
                return true;
            double x;
            if (double.TryParse(text, out x) && x >= 0 && x <= 10)
            {
                return true;
            }
            return false;
        }
        public static bool CheckIsAYear(string text)
        {
            if (string.IsNullOrEmpty(text))
                return true;
            int x;
            if (int.TryParse(text, out x))
            {
                if (1900 <= x && x <= 2100)
                {
                    return true;
                }
            }
            return false;
        }
        #region Convert To String From Date1 To Date2
        //Chuyen Doi Ra Xau Tu Ngay Den Ngay
        //Dau Vao: tungay(DateTime), denngay(DateTime)
        //Dau Ra: Chuoi Ngay.
        private static NLKtimetype timetype;
        private static string resNgay = string.Empty;
        private static int resQuy;
        private static string quy = string.Empty;
        private static long dateno;

        private static CultureInfo CulFr = new CultureInfo("fr-FR", true);
        /// <summary>
        /// Chuyển ngày tháng ra kiểu chuỗi tùy thuộc vào 2 ngày truyền vào
        /// </summary>
        /// <param name="tungay">Từ Ngày (datetime) </param>
        /// <param name="denngay">Đến ngày (datetime)</param>
        /// <returns></returns>
        public static string ConvertNgayBaoCao(DateTime tungay, DateTime denngay)
        {
            dateno = MergeTime(tungay.Date, denngay.Date, timetype);
            switch (timetype)
            {
                case NLKtimetype.NLK_DATE:
                    if (dateno == 1)
                        resNgay = "Ngày " + tungay.Day.ToString() + " tháng " + tungay.Month.ToString() + " năm " + tungay.Year.ToString();
                    else
                        resNgay = "Từ ngày " + tungay.ToString("dd/MM/yyyy") + " đến " + denngay.ToString("dd/MM/yyyy");
                    break;
                case NLKtimetype.NLK_MONTH:
                    resNgay = "Tháng " + tungay.Month.ToString() + " năm " + tungay.Year.ToString();
                    break;
                case NLKtimetype.NLK_QUATER:
                    switch (dateno)
                    {
                        case 1:
                            quy = "I";
                            break;
                        case 2:
                            quy = "II";
                            break;
                        case 3:
                            quy = "III";
                            break;
                        case 4:
                            quy = "IV";
                            break;
                    }
                    resNgay = "Qúy " + quy;
                    break;
                case NLKtimetype.NLK_YEAR:
                    resNgay = "Năm " + tungay.Year.ToString();
                    break;
            }

            return resNgay;
        }
        private static int MergeTime(DateTime tungay, DateTime denngay, NLKtimetype TimeType)
        {
            long lday;//So ngay giua hai ngay tungay, denngay
            int bdayf = 0, bmonthf = 0, byearf = 0;
            int bdayt = 0, bmontht = 0, byeart = 0;
            timetype = NLKtimetype.NLK_DATEERROR;
            bdayf = tungay.Day;
            bmonthf = tungay.Month;
            byearf = tungay.Year;
            bdayt = denngay.Day;
            bmontht = denngay.Month;
            byeart = denngay.Year;
            lday = DateAndTime.DateDiff(DateInterval.Day, tungay, denngay, FirstDayOfWeek.System, FirstWeekOfYear.System) + 1;
            if (bdayf == 1)
            {
                switch (lday)
                {
                    case 90:
                        if (bmonthf == 1 && DateTime.DaysInMonth(byearf, 2) == 28)
                        {
                            timetype = NLKtimetype.NLK_QUATER;
                            resQuy = 1;
                        }
                        else
                            timetype = NLKtimetype.NLK_DATE;
                        break;
                    case 91:
                        switch (bmonthf)
                        {
                            case 1:
                                if (DateTime.DaysInMonth(byearf, 2) == 29)
                                {
                                    timetype = NLKtimetype.NLK_QUATER;
                                    resQuy = 1;
                                }
                                else timetype = NLKtimetype.NLK_DATE;
                                break;
                            case 4:
                                timetype = NLKtimetype.NLK_QUATER;
                                resQuy = 2;
                                break;
                            default:
                                timetype = NLKtimetype.NLK_DATE;
                                break;
                        }
                        break;
                    case 92:
                        switch (bmonthf)
                        {
                            case 7:
                                timetype = NLKtimetype.NLK_QUATER;
                                resQuy = 3;
                                break;
                            case 10:
                                timetype = NLKtimetype.NLK_QUATER;
                                resQuy = 4;
                                break;
                            default:
                                timetype = NLKtimetype.NLK_DATE;
                                break;
                        }
                        break;
                    default:
                        if (bmonthf == 1)
                        {
                            switch (lday)
                            {
                                case 365:
                                    if (DateTime.DaysInMonth(byearf, 2) == 28)
                                    {
                                        timetype = NLKtimetype.NLK_YEAR;
                                        resQuy = byearf;
                                    }
                                    else
                                        timetype = NLKtimetype.NLK_DATE;
                                    break;
                                case 366:
                                    if (DateTime.DaysInMonth(byearf, 2) == 29)
                                    {
                                        timetype = NLKtimetype.NLK_YEAR;
                                        resQuy = byearf;
                                    }
                                    else
                                        timetype = NLKtimetype.NLK_DATE;
                                    break;
                                default:
                                    if (bdayt == 31 && bmonthf == 1 && byearf == byeart)
                                    {
                                        timetype = NLKtimetype.NLK_MONTH;
                                        resQuy = 1;
                                    }
                                    else
                                        timetype = NLKtimetype.NLK_DATE;
                                    break;
                            }

                        }
                        else
                        {
                            if (bmonthf == bmontht && byearf == byeart)
                            {
                                if (bdayt == DateTime.DaysInMonth(byearf, bmonthf))
                                {
                                    timetype = NLKtimetype.NLK_MONTH;
                                    resQuy = bmonthf;
                                }
                                else
                                    timetype = NLKtimetype.NLK_DATE;
                            }
                            else
                                timetype = NLKtimetype.NLK_DATE;
                        }
                        break;
                }
            }
            else
            {
                timetype = NLKtimetype.NLK_DATE;
            }

            if (timetype == NLKtimetype.NLK_DATE)
                resQuy = (int)lday;
            return resQuy;
        }
        #endregion
        /// <summary>
        /// Hội tụ con trỏ xuống điều khiển có TABINDEX liền kề
        /// Define by: Nguyen Anh Duc
        /// </summary>
        /// <param name="e"></param>
        public static void SendKeyToControl(KeyEventArgs e)
        {
            //Check whether the key pressed is the Enter key 
            //13 is the Keycode for ENTER key
            if (e.KeyValue == 13)
                //If the key pressed is enter then simulate the TAB key.
                SendKeys.Send("{TAB}");
        }
        /// <summary>
        /// Kiểm tra xem thời gian có nằm trong khoảng hợp lệ không
        /// </summary>
        /// <param name="date">Ngày cần kiểm tra</param>
        /// <returns>true = hợp lệ</returns>
        public static bool IsDateLegal(DateTime date)
        {
            if (DateTime.Compare(date, new DateTime(2005, 1, 1)) < 0 || DateTime.Compare(date, new DateTime(2030, 1, 1)) > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool ShowInformation_YesNo(string message)
        {
            if (MessageBox.Show(message, TextMessages.InfoMessage.MessageBox_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                return true;
            else
                return false;
        }
        public static void ShowMessageInformation(string message)
        {
            MessageBox.Show(message, TextMessages.InfoMessage.MessageBox_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Cac Combo Box tự động xổ ra
        /// </summary>
        public static void AutoDrop()
        {
            SendKeys.Send("{F4}");
        }
        /// <summary>
        /// Khi con tro hoi tu vao Combo neu nhan phim Space-Bar thi xo ra
        /// </summary>
        /// <param name="e"></param>
        public static void SpaceBarDrop(KeyEventArgs e)
        {
            if (e.KeyValue == 32)
                SendKeys.Send("{F4}");
        }

        /// <summary>
        /// Kiểm tra quyền của người dùng trên form (mặc định admin trả về true)
        /// </summary>
        /// <param name="Role">Tên nhóm có quyền trên form</param>
        /// <returns>true = có quyền, false = không có quyền</returns>
        public static bool IsHavePermission(string Role)
        {
            if (Csla.ApplicationContext.User.IsInRole(Role)
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == TextMessages.RolePermission.SystemAdmin)
               {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Kiểm tra quyền của người dùng trên form (mặc định admin trả về true)
        /// </summary>
        /// <param name="Roles">Danh sách các nhóm có quyền trên form</param>
        /// <returns>true = có quyền, false = không có quyền</returns>
        public static bool IsHavePermission(string[] Roles)
        {
            foreach (string role in Roles)
            {
                if (IsHavePermission(role))
                    return true;
            }
            return false;
        }
        public static bool IsHavePermission_MustHasAll(string[] Roles)
        {
            foreach (string role in Roles)
            {
                if (!IsHavePermission(role))
                    return false;
            }
            return true;
        }
        /// <summary>
        /// Chuyển đổi các ký tự phía trước có dấu cách thành chữ Hoa
        ///  eg: Proper("chuoi can doi") return "Chuoi Can Doi"
        /// Define by: Nguyen Anh Duc
        /// </summary>
        /// <param name="strInput"></param>
        /// <returns></returns>
        public static string Proper(string strInput)
        {
            string strResult = string.Empty;
            bool bolSpace = true;
            string strChar = string.Empty;

            strInput = strInput.Equals(null) ? "" : strInput;
            for (int i = 0; i < strInput.Length; i++)
            {
                strChar = strInput.Substring(i, 1);
                if (bolSpace)
                {
                    if (strChar.CompareTo("a") >= 0 && strChar.CompareTo("z") <= 0)
                        strChar = strChar.ToUpper();
                }
                else
                {
                    if (strChar.CompareTo("A") >= 0 && strChar.CompareTo("Z") <= 0)
                        strChar = strChar.ToLower();
                }

                if (strChar.Equals(" "))
                {
                    if (bolSpace == false)
                        strResult += strChar;
                    bolSpace = true;
                }
                else
                {
                    bolSpace = false;
                    strResult += strChar;
                }
            }
            return strResult;
        }

        /// <summary>
        /// Hàm tìm kiếm một chuỗi ký tự con trong chuỗi ký tự cha, phụ thuộc vào vị trí xuất hiện 
        /// Của chuỗi con trong chuỗi cha do người dùng định nghĩa
        /// Define by: Nguyen Anh Duc
        /// </summary>
        /// <param name="strParentString"></param>
        /// <param name="strChildString"></param>
        /// <returns></returns>
        public static bool SearchResult(string strParentString, string strChildString)
        {
            bool bolResult = false;
            switch (AppConfig.SearchPosition)
            {
                case "1": //Vị trí Đầu chuỗi
                    {
                        bolResult = strParentString.ToLower().IndexOf(strChildString.ToLower()) == 0;
                        break;
                    }
                case "2": //Vị trí Bất kỳ trong chuỗi
                    {
                        bolResult = strParentString.ToLower().IndexOf(strChildString.ToLower()) >= 0;
                        break;
                    }
                case "3": //Vị trí Cuối chuỗi
                    {
                        bolResult = strParentString.ToLower().LastIndexOf(strChildString.ToLower()) >= 0;
                        break;
                    }
                default:
                    {
                        goto case "2";
                    }
            }
            return bolResult;
        }

        /// <summary>
        /// Chuyển đổi mảng đối tượng về xâu và làm tham số điều kiện câu lệnh SQL
        /// nếu convertType = StringType thì xâu chuyển về định dạng 'giá trị 1','giá trị 2'
        /// nếu convertType = NumberType thì xâu chuyển về định dạng giá trị 1,giá trị 2
        /// </summary>
        /// <param name="inputArray"></param>
        /// <param name="convertType"></param>
        /// <returns></returns>
        public static string ConvertArrayToString(object[] inputArray, ConvertType convertType)
        {
            string strResult = "'";

            if (inputArray != null)
            {
                foreach (object item in inputArray)
                {
                    strResult += item.ToString();
                    if (convertType == ConvertType.StringType)
                        strResult += "',";
                    else
                        strResult += ",";
                }
                if (convertType == ConvertType.StringType)
                    strResult = strResult.Substring(0, strResult.Length - 1);
                else
                    strResult = strResult.Substring(1, strResult.Length - 2);
                return strResult;
            }
            else
            {
                return strResult;
            }
        }

        /// <summary>
        /// Confirm delete data
        /// Define by: Nguyen Anh Duc
        /// </summary>
        /// <returns>bool</returns>
        public static bool AcceptDelete()
        {
            string strMessge = "Bạn có đồng ý xóa không ?";
            string strCaption = "Xác nhận lại hành động";

            if (MessageBox.Show(strMessge, strCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                return true;
            else
                return false;
        }


        /// <summary>
        /// Confirm update data
        /// Define by: Nguyen Anh Duc
        /// </summary>
        /// <returns>bool</returns>
        public static bool AcceptUpdate()
        {
            string strMessge = "Bạn có đồng ý cập nhập dữ liệu không ?";
            string strCaption = "Xác nhận lại hành động";

            if (MessageBox.Show(strMessge, strCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                return true;
            else
                return false;
        }
        public static bool AcceptHuy()
        {
            string strMessge = "Bạn có đồng ý hủy biên lai, hóa đơn này không ?";
            string strCaption = "Xác nhận lại hành động";

            if (MessageBox.Show(strMessge, strCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                return true;
            else
                return false;
        }


        public static bool AcceptHoanBienLai()
        {
            string strMessge = "Bạn có đồng ý hoàn biên lai này không ?";
            string strCaption = "Xác nhận lại hành động";
            if (MessageBox.Show(strMessge, strCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                return true;
            else
                return false;
        }
        public static void ShowError(Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        /// <summary>
        /// Show error
        /// Define by: Nguyen Anh Duc
        /// </summary>
        /// <param name="strMessage"></param>
        public static void ShowError(string strMessage, string strCaption)
        {
            string strSqlError = "(System.Data.SqlClient.SqlException:";
            string strSystemException = "(System.Exception:";
            string strEndError = "\r\n";
            string strError = strMessage.Trim();
            //Kiem tra loi co phai cua CSDL Sql tra ve khong
            if (strError.IndexOf(strSqlError) >= 0)
            {
                strError = strError.Substring(strError.IndexOf(strSqlError));
                strError = strError.Substring(strError.IndexOf(":") + 1, strError.IndexOf(strEndError) - strError.IndexOf(":"));
                MessageBox.Show(strError.Trim(), strCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (strError.IndexOf(strSystemException) >= 0)
            {
                strError = strError.Substring(strError.IndexOf(strSystemException));
                strError = strError.Substring(strError.IndexOf(":") + 1, strError.IndexOf(strEndError) - strError.IndexOf(":"));
                MessageBox.Show(strError.Trim(), strCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else//Co the mo rong cho nhieu loai biet le o day
                MessageBox.Show(strMessage, strCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            WriteErrorToDatabase(strMessage);
        }
        private static void WriteErrorToDatabase(string mess)
        {
            try
            {
                ADM_ErrorRemoteLog item = ADM_ErrorRemoteLog.NewADM_ErrorRemoteLog();
                item.Date = Convert.ToString(DateTime.Now);
                item.Message = mess;
                item.Version = TextMessages.SoftwareInformation.Version;
                item.ApplyEdit();
                item.Save();
            }
            catch
            {
            }
        }

        private static string GetErrorMessage(string errorMessage)
        {
            switch (errorMessage)
            {
                case "UPD_01":
                    return ErrorMessage.UDP_01;
                case "UDP_02":
                    return ErrorMessage.UDP_02;
                case "UDP_03":
                    return ErrorMessage.UDP_03;
                default:
                    return errorMessage;
                    
            }

        }

        /// <summary>
        /// Phương thức kiểm tra lỗi của một đối tượng. Trả về lỗi ở client hoặc lỗi gây ra ở server 
        /// Khi lưu một đối tượng
        /// </summary>
        /// <param name="ex"></param>
        public static void ShowErrorMessager(Exception ex)
        {
            
            if (ex.InnerException != null)
            {
                if (ex.InnerException.InnerException != null)
                {
                    MessageBox.Show(GetErrorMessage(ex.InnerException.InnerException.Message), "Thông báo từ hệ thống MCDT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show(GetErrorMessage(ex.InnerException.Message), "Thông báo từ hệ thống MCDT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show(GetErrorMessage(ex.Message), "Thông báo từ hệ thống MCDT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            WriteErrorToDatabase(Convert.ToString(ex));
        }
        /// <summary>
        /// only show message in messagebox, Exception detail will be log in other file.
        /// </summary>
        /// <param name="ex"></param>
        public static void ShowErrorMessager(Exception ex,string message)
        {
              MessageBox.Show(message, "Thông báo từ hệ thống MCDT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              WriteErrorToDatabase(Convert.ToString(ex));
        }

        /// <summary>
        /// Show message without log the Exceptions
        /// </summary>
        /// <param name="message"></param>
        public static void ShowErrorMessager(string message)
        {
            MessageBox.Show(message, "Thông báo từ hệ thống MCDT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           // WriteErrorToDatabase(message);
        }
        /// <summary>
        /// Get IDNguoiDung
        /// Define by: Nguyen Anh Duc
        /// </summary>
        /// <returns></returns>
        public static long GetIDNguoiDung()
        
        {
            string strIDNguoiDung = Csla.ApplicationContext.GlobalContext["IDNguoiDung"].ToString();
            if (strIDNguoiDung.Equals("") || strIDNguoiDung.Equals("0"))
                throw new Exception("Bạn phải đăng nhập lại hệ thống để tiếp tục làm việc");
            else
                return Convert.ToInt64(strIDNguoiDung);
        }

        /// <summary>
        /// Get name of login user
        /// Define by: Nguyen Anh Duc
        /// </summary>
        /// <returns></returns>
        public static string GetTenNguoiDung()
        {
            string strTenNguoiDung = Csla.ApplicationContext.User.Identity.Name;
            if (strTenNguoiDung.Equals("") || strTenNguoiDung.Equals(""))
                throw new Exception("Bạn phải đăng nhập lại hệ thống để tiếp tục làm việc");
            else
                return strTenNguoiDung;
        }

        /// <summary>
        /// Get fullname of login user
        /// Define by: Nguyen Anh Duc
        /// Date: 13/12/2008
        /// </summary>
        /// <returns></returns>
        public static string GetTenDayDu()
        {
            string strTenDayDu = Csla.ApplicationContext.GlobalContext["TenDayDu"].ToString();
            if (strTenDayDu.Equals("") || strTenDayDu.Equals(""))
                throw new Exception("Bạn phải đăng nhập lại hệ thống để tiếp tục làm việc");
            else
                return strTenDayDu;
        }

        /// <summary>
        /// Get rolename of login user
        /// Define by: Nguyen Anh Duc
        /// Date: 13/12/2008
        /// </summary>
        /// <returns></returns>
        public static string GetTenVaiTro()
        {
            string strTenVaiTro = Csla.ApplicationContext.GlobalContext["TenVaiTro"].ToString();
            if (strTenVaiTro.Equals("") || strTenVaiTro.Equals(""))
                throw new Exception("Bạn phải đăng nhập lại hệ thống để tiếp tục làm việc");
            else
                return strTenVaiTro;
        }

        /// <summary>
        /// Lay ve IDPhien lam viec cua nguoi dung hien thoi
        /// </summary>
        /// <returns></returns>
        public static long GetIDPhienLamViec()
        {
            string strIDPhienLamViec = "";
            if(Csla.ApplicationContext.GlobalContext["IDPhienLamViec"] != null)
                strIDPhienLamViec = Csla.ApplicationContext.GlobalContext["IDPhienLamViec"].ToString();
            return (strIDPhienLamViec.Equals("") ? 0 : Convert.ToInt64(strIDPhienLamViec));
        }

        /// <summary>
        /// Get value of system variable
        /// Define by: Nguyen Anh Duc
        /// </summary>
        /// <param name="strID"></param>
        /// <returns></returns>
        public static string GetParameter(string strID)
        {
            try
            {
                string strResult = string.Empty;
                using (SqlConnection cn = new SqlConnection(NETLINK.LIB.DBConnection.Connection))
                {
                    cn.Open();
                    using (SqlCommand cm = cn.CreateCommand())
                    {
                        cm.CommandText = "ADM_Parameter_get";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@ID", strID);
                        using (Csla.Data.SafeDataReader dr = new Csla.Data.SafeDataReader(cm.ExecuteReader()))
                        {
                            if (dr.Read())
                            {
                                if (strID == "HON" || strID == "MPH")
                                {
                                    strResult =SECURITY.MySecurity.Decrypt(dr.GetString("ParaValue"), true);
                                    strResult = strResult.Equals("") ?SECURITY.MySecurity.Decrypt(dr.GetString("DefaultValue"), true) : strResult;
                                    strResult = strResult.Replace(";", "\r\n");
                                }
                                else
                                {
                                    strResult = dr.GetString("ParaValue");
                                    strResult = strResult.Equals("") ? dr.GetString("DefaultValue") : strResult;
                                    strResult = strResult.Replace(";", "\r\n");
                                }
                            }
                        }
                    }
                }
                return strResult;
            }
            catch (Exception e)
            {
                GlobalCommon.ShowError(e.Message.ToString(), "Thông báo lỗi");
                return "";
            }
        }

        public static string CreateMaBienLai(int intYear,string strMaHocVien)
        {
            string strMaBienLai = string.Empty ;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.Text;
                    cm.CommandText = "select dbo.fn_taoSBL_TamThu(" + intYear + ", '"+ strMaHocVien + "' )";
                    strMaBienLai = (string)cm.ExecuteScalar();
                }
            }
            return strMaBienLai;
        }

        public static decimal GetChiPhiHVDaDong(Int32 intID)
        {
            decimal dclTongTien = 0;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.Text;
                    cm.CommandText = "select dbo.fn_GetChiPhiHVDaDong( '" + intID + "' )";
                    dclTongTien = (decimal)cm.ExecuteScalar();
                }
            }
            return dclTongTien;
        }

        /// <summary>
        /// Lấy về đối tượng trợ phí của thẻ khi có thẻ trợ phí
        /// Define by: Nguyen Anh Duc
        /// </summary>
        /// <param name="strSoThe"></param>
        /// <returns></returns>
        public static long GetIDDoiTuongBySoThe(string strSoThe)
        {
            object oIDDoiTuong;

            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    //Xử lý loại bỏ phân biệt trái tuyến xong lại đúng tuyến, đúng tuyến xong lại trái tuyến. Chuỗi phân biệt là [TD] hoặc [TT]
                    if (strSoThe.IndexOf("[") > 0)
                        strSoThe = strSoThe.Substring(0, strSoThe.IndexOf("["));
                    //Hết xử lý lấy số thẻ
                    cm.CommandText = "SELECT dbo.fn_FindInsuranceObject('" + strSoThe + "')";
                    cm.CommandType = CommandType.Text;
                    oIDDoiTuong = cm.ExecuteScalar();
                }
            }
            return (oIDDoiTuong == DBNull.Value ? 0 : Convert.ToInt64(oIDDoiTuong));
        }

        /// <summary>
        /// Lấy về nhận dạng mức hưởng ngoại lệ thông qua IDDoiTuong tro phi
        /// Define by: Nguyen Anh Duc
        /// </summary>
        /// <param name="IDDoiTuong"></param>
        /// <returns></returns>
        public static long GetIDMucHuongByIDDoiTuong(long IDDoiTuong)
        {
            object oIDMucHuong;

            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandText = "SELECT dbo.fn_FindLevelExtent(" + IDDoiTuong.ToString() + ")";
                    cm.CommandType = CommandType.Text;
                    oIDMucHuong = cm.ExecuteScalar();
                }
            }
            return (oIDMucHuong == DBNull.Value ? 0 : Convert.ToInt64(oIDMucHuong));
        }

        public static int DateToInt(string NgayThangNam)
        {
            try
            {
                string dd = NgayThangNam.Substring(0, 2);
                string mm = NgayThangNam.Substring(3, 2);
                string yyyy = NgayThangNam.Substring(6, 4);
                string yyyymmdd = yyyy + mm + dd;
                return int.Parse(yyyymmdd);
            }
            catch (Exception e)
            {
                GlobalCommon.ShowError(e.Message.ToString(), "Thông báo lỗi");
                return 0;
            }
        }
        /// <summary>
        /// Kiểm tra 1 mảng chuỗi đầu vào. nếu có bất kì chuỗi nào = null or "" thì trả về true
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static bool CheckArrayTextIsNull(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (string.IsNullOrEmpty(array[i]))
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Kiểm tra 1 mảng chuỗi đầu vào. nếu có bất kì chuỗi nào = null or "" thì trả về true
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static bool CheckArrayTextIsNull(object[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]== null || string.IsNullOrEmpty(array[i].ToString()))
                    return true;
            }
            return false;
        }

       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fullpath"></param>
        /// <returns></returns>
        public static string SetFileNameForFTP(string fullpath)
        {
            return string.Format("{0}_{1}{2}", Path.GetFileNameWithoutExtension(fullpath), Guid.NewGuid().ToString().Replace("-", string.Empty) ,Path.GetExtension(fullpath));
        }
        /// <summary>
        /// Kiểm tra xem date là giá trị thực hay chỉ là giá trị 1900 (kết quả hàm fixdate)(true is ok)
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns>true: ok, false: gán date = null</returns>
        public static bool CheckDate(DateTime datetime)
        {
            if (DateTime.Compare(new DateTime(1940, 1, 1), datetime) < 0 || DateTime.Compare(new DateTime(2050, 1, 1), datetime) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Check xem trong chuỗi có số nào xuất hiện không
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool Check_MustHasANumber(object str)
        {
            if (str == null)
                return false;
            string chuoi = str.ToString();
            if (chuoi.IndexOfAny(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }) >= 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Kiểm tra xem date là giá trị thực hay chỉ là giá trị 1900 (kết quả hàm fixdate)
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns>true: ok, false: gán date = null</returns>
        public static bool CheckDate_NotToday(DateTime datetime)
        {
            if (DateTime.Compare(DateTime.Today, datetime) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Kiem tra full Name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool CheckFullName(object name)
        {
            if (name == null)
                return false;
            if (name.ToString().Trim().IndexOf(" ") <= 0)
            {
                return false;
            }
            else
                return true;
        }
        /// <summary>
        /// Kiem tra dinh dang email
        /// </summary>
        /// <param name="email"></param>
        /// <returns>true: dinh dang email dung</returns>
        public static bool CheckEmail(object email)
        {
            if (email == null)
                return false;
            if (email.ToString().IndexOf("@") <= 0 || email.ToString().IndexOf(".") < 0)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Kiểm tra xem date là giá trị thực hay chỉ là giá trị 1900 (kết quả hàm fixdate)
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns>true: ok, false: gán date = null</returns>
        public static bool CheckDate(object obj)
        {
            DateTime datetime;
            try
            {
                datetime = Convert.ToDateTime(obj); 
            }
            catch
            {
                return false;
            }
            if (DateTime.Compare(new DateTime(1940, 1, 1), datetime) < 0 || DateTime.Compare(new DateTime(2050, 1, 1), datetime) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Nếu datetime nằm trong khoảng từ 1/1/1940 -> 31/12/2050 thì trả về datetime. nếu ko thì trả về ngày 1/1/1900
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static DateTime FixDate(DateTime datetime)
        {
            if (DateTime.Compare(new DateTime(1940, 1, 1), datetime) < 0 || DateTime.Compare(new DateTime(2050, 1, 1), datetime) <= 0)
            {
                return datetime;
            }
            else
            {
                return new DateTime(1900, 1, 1);
            }
        }

        public static string DateToString(object dt)
        {
            return FixDate_Return(dt);
        }
        public static string FixDate_Return(DateTime datetime)
        {
            if (CheckDate(datetime))
                return datetime.ToShortDateString();
            else
                return string.Empty;
        }
        public static string FixDate_Return(object datetime)
        {
            if (CheckDate(datetime))
                return Convert.ToDateTime(datetime).ToShortDateString();
            else
                return string.Empty;
        }
        /// <summary>
        /// convert datetime -> date only
        /// </summary>
        /// <param name="datetime">datetime</param>
        /// <returns>dateonly</returns>
        public static string DateToString(DateTime dt)
        {
          return  FixDate_Return(dt);
        }

        public static string GetMaLoaiDichVu(long lngIDLoaidichvu)
        {
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandText = "IP_GetMaLoaiDichVu";
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.AddWithValue("@IDLoaidichvu", lngIDLoaidichvu);
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {

                        dr.Read();
                        return dr.GetString("Maloaidichvu");

                    }
                }
            }

        }

        public static string KiemTraGiangVien(Int64 IDGiangVien, string NgayGiang, string BuoiGiang)
        {
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandText = "CDT_KiemTraLichGiang";
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.AddWithValue("@IDGiangVien", IDGiangVien);
                    cm.Parameters.AddWithValue("@Ngay", NgayGiang);
                    cm.Parameters.AddWithValue("@BuoiGiang", BuoiGiang);
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {

                        dr.Read();
                        return dr.GetString("NoiDung");
                    }
                }
            }

        }

        /// <summary>
        /// Trả về ngày sớm hơn trong 2 ngày cần compare
        /// </summary>
        /// <param name="dt1"></param>
        /// <param name="dt2"></param>
        /// <returns></returns>
        public static DateTime CompareDate_Earlier(DateTime dt1, DateTime dt2)
        {
            
            if (DateTime.Compare(dt1, dt2) < 0)
            {
                return dt1;
            }
            else
            {
                return dt2;
            }
        }

        public static bool CheckDateMustBeEarilierOrEqualOther(DateTime EarilierDate, DateTime LaterDate)
        {
            if (DateTime.Compare(EarilierDate, LaterDate) >= 0)
            {
                return true;
            }
            else
                return false;
        }
        public static bool CheckDateMustBeEarilierOrEqualOther(string EarilierDate, string LaterDate)
        {
            if (!string.IsNullOrEmpty(EarilierDate) && !string.IsNullOrEmpty(LaterDate))
                return CheckDateMustBeEarilierOrEqualOther(Convert.ToDateTime(EarilierDate,new CultureInfo("vi-VN")), Convert.ToDateTime(LaterDate,new CultureInfo("vi-VN")));
            else
                return true;
        }
        public static bool CheckDateMustBeEarilierThanOther(DateTime EarilierDate, DateTime LaterDate)
        {
            if (DateTime.Compare(EarilierDate, LaterDate) > 0)
            {
                return true;
            }
            else
                return false;
        }
        public static bool CheckDateMustBeEqualOther(DateTime EarilierDate, DateTime LaterDate)
        {
            if (DateTime.Compare(EarilierDate, LaterDate) == 0)
            {
                return true;
            }
            else
                return false;
        }
        public static bool CheckDateMustBeEarilierThanOther(string EarilierDate, string LaterDate)
        {
            try
            {
                return CheckDateMustBeEarilierThanOther(Convert.ToDateTime(EarilierDate), Convert.ToDateTime(LaterDate));
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool CheckDateMustBeEqualOther(string EarilierDate, string LaterDate)
        {
            try
            {
                return CheckDateMustBeEqualOther(Convert.ToDateTime(EarilierDate), Convert.ToDateTime(LaterDate));
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Trả về ngày muộn hơn trong 2 ngày cần compare
        /// </summary>
        /// <param name="dt1"></param>
        /// <param name="dt2"></param>
        /// <returns></returns>
        public static DateTime CompareDate_Later(DateTime dt1, DateTime dt2)
        {
            if (DateTime.Compare(dt1, dt2) < 0)
            {
                return dt2;
            }
            else
            {
                return dt1;
            }
        }
        /// <summary>
        /// Trả về dòng chữ Hà Nội, Ngày tháng năm...
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static String BC_HaNoiNgayThangNam(DateTime dt)
        {
            return "Hà Nội, Ngày " + dt.Day.ToString() + " tháng " + dt.Month.ToString() + " năm " + dt.Year.ToString();
        }
        /// <summary>
        /// Trả về dòng chữ Ngày tháng năm...
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static String BC_NgayThangNam(DateTime dt)
        {
            return "Ngày " + dt.Day.ToString() + " tháng " + dt.Month.ToString() + " năm " + dt.Year.ToString();
        }
        public static DateTime GetTimeServer()
        {
            DateTime strResult = DateTime.Today;
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cm = new SqlCommand("select getdate() as TimeServer", ctx.Connection))
                {          
                    cm.CommandType = CommandType.Text;
                    using (Csla.Data.SafeDataReader dr = new Csla.Data.SafeDataReader(cm.ExecuteReader()))
                    {
                        dr.Read();

                        strResult = dr.GetDateTime("TimeServer");
                    }
                    
                }
            }
            return strResult;
        }
        public static long getIDKhoa(long lngIDDieuTri)
        {
            long result;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "IP_GetIDKhoa";
                    cm.Parameters.AddWithValue("@IDDieuTri", lngIDDieuTri);
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        dr.Read();
                        result = dr.GetInt64("IDKhoa");
                    }
                }
            }
            return result;
        }

        public static string getTenKhungLopHoc(string strTenLop, string strTenChuyenKhoa)
        {
            string result;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "DT_GetKhungLopHoc";
                    cm.Parameters.AddWithValue("@TenLop", strTenLop);
                    cm.Parameters.AddWithValue("@TenChuyenKhoa", strTenChuyenKhoa);
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        dr.Read();
                        try
                        {
                            result = Convert.ToString(dr.GetString("TenLop"));
                        }
                        catch (Exception ex)
                        {
                            result = "a";
                        }
                    }
                }
            }
            return result;
        }
        public static string GetSoHoaDon(Int64 IDHocVien)
        {
            string result = string.Empty;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.Text;
                    cm.CommandText = "SELECT hd.SoHoaDon FROM dbo.HoaDon hd " +
                                       " join HoaDonCT hdct on hdct.IDHoaDon = hd.IDHoaDon" +
                                       " where IDHocVien = " + IDHocVien+ " and hd.IDHoaDon in (select top 1 IDHoaDon from HoaDon where IDHocVien = "+ IDHocVien+" order by IDHoaDon desc)";
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        dr.Read();
                        try
                        {
                            result = Convert.ToString(dr.GetString("SoHoaDon"));
                        }
                        catch (Exception ex) { MessageBox.Show(ex.ToString(), "Lấy số hóa đơn lỗi"); }
                    }
                }
            }
            return result;
        }
        public static string GetSoHoaDonLopHoc(Int32 IDLopHoc)
        {
            string result = string.Empty;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.Text;
                    cm.CommandText = "SELECT hd.SoHoaDon FROM dbo.HoaDon hd " +
                                       " join HoaDonCT hdct on hdct.IDHoaDon = hd.IDHoaDon" +
                                       " where IDLopHoc = " + IDLopHoc + " and hd.IDHoaDon in (select top 1 IDHoaDon from HoaDon where IDLopHoc = " + IDLopHoc + " order by IDHoaDon desc)";
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        dr.Read();
                        try
                        {
                            result = Convert.ToString(dr.GetString("SoHoaDon"));
                        }
                        catch (Exception ex) { MessageBox.Show(ex.ToString(), "Lấy số hóa đơn lỗi"); }
                    }
                }
            }
            return result;
        }
        public static string GetLyDoHuy(Int64 IDHuy)
        {
            string result = string.Empty;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.Text;
                    cm.CommandText = "SELECT LyDoHuy FROM dbo.LyDoHuyBienLai hd " +
                                       " where IDHuy = " + IDHuy ;
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        dr.Read();
                        try
                        {
                            result = Convert.ToString(dr.GetString("LyDoHuy"));
                        }
                        catch (Exception ex) { MessageBox.Show(ex.ToString(), "Lấy lý do lỗi"); }
                    }
                }
            }
            return result;
        }

        public static string GetTenDangNhap(Int64 IDNguoiDung)
        {
            string result = string.Empty;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.Text;
                    cm.CommandText = "SELECT TenDangNhap FROM ADM_NguoiDung " +
                                       " where IDNguoiDung = " + IDNguoiDung;
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        dr.Read();
                        try
                        {
                            result = Convert.ToString(dr.GetString("TenDangNhap"));
                        }
                        catch (Exception ex) { MessageBox.Show(ex.ToString(), "Lấy tên đăng nhập lỗi"); }
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// Hàm xác định IDDonvitrophi, làm cơ sở để load thông tin dịch vụ
        /// </summary>
        /// <param name="lngIDDieuTri"></param>
        /// <returns></returns>
        public static long getIDDonViTroPhi(long lngIDDieuTri)
        {
            long result;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "get_IDDonViTroPhi";
                    cm.Parameters.AddWithValue("@IDDieuTri", lngIDDieuTri);
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        dr.Read();
                        result = dr.GetInt64("IDDonvitrophi");
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// Hàm thực hiện kiểm tra xem tại 1 ngày bệnh nhân có được hưởng trợ phí hay không?
        /// Làm cơ sở load thông tin dịch vụ
        /// =0: không dùng thẻ,=1 :có thẻ nhưng hết hạn,=2 : có thẻ nhưng điều trị tự nguyện, =3: Điều trị bằng thẻ trợ phí
        /// </summary>
        /// <param name="lngIDDieutri"></param>
        /// <param name="strNgay"></param>
        /// <returns></returns>
        public static bool getTroPhi(long lngIDDieutri, string strNgay)
        {
            bool result;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "get_TroPhi";
                    cm.Parameters.AddWithValue("@IDDieuTri", lngIDDieutri);
                    cm.Parameters.AddWithValue("@Ngay", strNgay);
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        dr.Read();
                        result = dr.GetBoolean("Trophi");
                    }
                }
            }
            return result;
        }
        public static long getIDDieuTri(long lngIDYeuCau)
        {
            long result;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "get_IDDieuTri";
                    cm.Parameters.AddWithValue("@IDYeucau", lngIDYeuCau);
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        dr.Read();
                        result = dr.GetInt64("IDDieuTri");
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// Hàm xác định xem 1 IDYeuCau có phải do bác sĩ kê đơn hay không?
        /// </summary>
        /// <param name="lngIDYeuCau"></param>
        /// <returns></returns>
        public static bool IsDonThuoc(long lngIDYeuCau)
        {
            bool result;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "IP_IsDonThuoc";
                    cm.Parameters.AddWithValue("@IDYeucau", lngIDYeuCau);
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        dr.Read();
                        result = dr.GetBoolean("IsDonThuoc");
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// Hàm trả về ID đơn vị trợ phí từ ID đối tượng
        /// </summary>
        /// <param name="lngIDDoiTuong"></param>
        /// <returns></returns>
        public static long getIDDVTP(long lngIDDoiTuong)
        {
            long result;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "IP_GetIDDVTP";
                    cm.Parameters.AddWithValue("@IDDoiTuong", lngIDDoiTuong);
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        dr.Read();
                        result = dr.GetInt64("IDDonViTroPhi");
                    }
                }
            }
            return result;

        }
        public static bool DuocPhepTruDung(long lngIDKhoa, long lngIDLoaiDichVu, DateTime dteNgay)
        {
            bool result;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "IP_TruDung_KiemTraTruDung";
                    cm.Parameters.AddWithValue("@IDKhoa", lngIDKhoa);
                    cm.Parameters.AddWithValue("@IDLoaiDichVu", lngIDLoaiDichVu);
                    cm.Parameters.AddWithValue("@Ngay", dteNgay);
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        dr.Read();
                        result = dr.GetBoolean("Result");
                    }
                }
            }
            return result;
        }

        public static bool DuocPhepTraKho(long lngIDKhoa, long lngIDLoaiDichVu)
        {
            bool result;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "IP_TruDung_KiemTraTraKho";
                    cm.Parameters.AddWithValue("@IDKhoa", lngIDKhoa);
                    cm.Parameters.AddWithValue("@IDLoaiDichVu", lngIDLoaiDichVu);
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        dr.Read();
                        result = dr.GetBoolean("Result");
                    }
                }
            }
            return result;
        }
        public static string getTenDoiTuong(long lngIDDoiTuong)
        {
            string result;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "IP_GetTenDoiTuong";
                    cm.Parameters.AddWithValue("@IDDoiTuong", lngIDDoiTuong);
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        dr.Read();
                        result = dr.GetString("TenDoiTuong");
                    }
                }
            }
            return result;

        }
        public static bool KhoaDuLieu(long lngIDKhoa, DateTime dteNgay)
        {
            bool Result;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "IP_VienKhoaPhong_LockData";
                    cm.Parameters.AddWithValue("@IDKhoa", lngIDKhoa);
                    cm.Parameters.AddWithValue("@Ngay", dteNgay);
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        dr.Read();
                        Result = dr.GetBoolean("Result");
                    }
                }

            }
            return Result;
        }
        /// <summary>
        /// Hàm thực hiện kiểm tra xem danh sách số giường có hợp lệ, nếu hợp lệ thì đưa ra chuỗi số giường
        /// input: "1-3,5,7,10-15"
        /// output: in(1,2,3,5,7,10,11,12,13,14,15)
        /// </summary>
        /// <param name="strDanhSachGiuong"></param>
        /// <returns></returns>
        public static string DanhSachGiuong(string str)
        {
            string Result = "";
            string strTemp = "";
            //Loại bỏ khoảng trắng
            str = str.Replace(" ", "");
            //Nếu ký tự đầu không phải là số thì xóa bỏ
            while (IsNumber(str.Substring(0, 1)) == false) str = str.Substring(1, str.Length - 1);
            //Ký tự sau cùng không phải là số thì xóa bỏ
            while (IsNumber(str.Substring(str.Length - 1, 1)) == false) str = str.Substring(0, str.Length - 1);
            //Nếu... 
            while (str.IndexOf("--") >= 0) str = str.Replace("--", "-");
            while (str.IndexOf(",,") >= 0) str = str.Replace(",,", ",");
            if ((str.IndexOf("-,") >= 0) || (str.IndexOf(",-") > 0)) goto Loi;
            while (str.Length > 0)
            {
                if (str.IndexOf(",") >= 0)//Chưa phải là phần tử cuối
                {
                    strTemp = LayChiTietSoGiuong(str.Substring(0, str.IndexOf(",")));//Lấy phần tử đầu tiên
                    if (Result == "")
                    {
                        if (strTemp == "@") goto Loi;
                        else Result = strTemp;
                    }
                    else
                    {
                        if (strTemp == "@") goto Loi;
                        else Result = Result + "," + strTemp;
                    }
                    str = str.Substring(str.IndexOf(",") + 1, str.Length - str.IndexOf(",") - 1);
                }
                else//Nếu là phần tử cuối cùng thì lấy nốt
                {
                    strTemp = LayChiTietSoGiuong(str);
                    if (Result == "")
                    {
                        if (strTemp == "@") goto Loi;
                        else Result = strTemp;
                    }
                    else
                    {
                        if (strTemp == "@") goto Loi;
                        else Result = Result + "," + strTemp;
                    }
                    str = "";
                }
            }
            return Result;
        Loi:
            return "@";

        }
        /// <summary>
        /// Hàm lấy chi tiết số giường
        /// input : 1 hoặc 3-5 hoặc 7-9 hoặc 10...
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string LayChiTietSoGiuong(string str)
        {
            string Result = "";
            int index, i = 0;
            if (IsNumber(str) == true)//Trường hợp chuỗi đưa vào có dạng "1","3".."10"
            {
                Result = str;
            }
            else //Không phải là số
            {
                for (index = 0; index < str.Length; index++)
                {
                    if (str[index].ToString() == "-")
                        i++;
                }
                if (i > 1)//không đúng dịnh dạng
                {
                    Result = "@";
                    goto Loi;
                }
                i = str.IndexOf("-");
                if (i >= 0)
                {
                    try
                    {
                        for (index = Convert.ToInt32(str.Substring(0, i));
                            index <= Convert.ToInt32(str.Substring(i + 1, str.Length - i - 1));
                            index++)
                        {
                            if (Result == "")//phần tử đầu tiên
                                Result = index.ToString();
                            else
                                Result = Result + "," + index.ToString();
                        }
                    }
                    catch
                    {
                        Result = "@";
                    }


                }
            }
            return Result;
        Loi:
            return "@";
        }
        /// <summary>
        /// Hàm kiểm tra chuỗi đưa vào có phải là chuỗi số hay không?
        /// </summary>
        /// <param name="strNumber"></param>
        /// <returns></returns>
        public static bool IsNumber(string strNumber)
        {
            return Microsoft.VisualBasic.Information.IsNumeric(strNumber);
        }

        /// <summary>
        /// Hàm lấy về ngày làm việc được chọn trong khi đăng nhập
        /// Define by: Nguyen Anh Duc
        /// </summary>
        /// <returns></returns>
        public static string GetWorkingDate()
        {
            return Csla.ApplicationContext.GlobalContext["WORKING_DATE"].ToString();
        }

        /// <summary>
        /// Hàm lấy về trạng thái đã đổi mật khẩu hay chưa
        /// Define by: Nguyen Anh Duc
        /// </summary>
        /// <returns></returns>
        public static bool IsPasswordHasChanged()
        {           
                return Convert.ToBoolean(Csla.ApplicationContext.GlobalContext["DaDoiMatKhau"] == null ? false : Csla.ApplicationContext.GlobalContext["DaDoiMatKhau"]);
           
        }

        /// <summary>
        ///Đổi định dạng ngày dd/mm/yyyy
        ///Thành định dạng mm/dd/yyyy
        /// Define by: Nguyen Anh Duc
        /// </summary>
        /// <param name="strDate"></param>
        /// <returns></returns>
        public static string ConvertDateFrenchToUSA(string strDate)
        {
            string strDay, strMonth, strYear, strTMP;
            if (strDate.Trim().Length == 10)
            {
                strTMP = strDate.Trim();
                strTMP = strTMP.Replace(".", "/").Replace("-", "/");
                strDay = strTMP.Substring(0, 2);
                strMonth = strTMP.Substring(3, 2);
                strYear = strTMP.Substring(6, 4);
                if (IsNumber(strYear) && IsNumber(strMonth) && IsNumber(strDay))
                {
                    if (IsDate(Convert.ToInt32(strDay), Convert.ToInt32(strMonth), Convert.ToInt32(strYear)))
                        return strMonth + "/" + strDay + "/" + strYear;
                    else
                        throw new Exception("Ngày đưa vào không hợp lệ");
                }
                else
                    throw new Exception("Ngày hoặc Tháng hoặc Năm không đúng");
            }
            else
                throw new Exception("Định dạng ngày không tuân theo quy định ('dd/mm/yyyy' hoặc 'dd.mm.yyyy' hoặc 'dd-mm-yyyy')");
        }

        /// <summary>
        ///Đổi định dạng ngày mm/dd/yyyy
        ///Thành định dạng dd/mm/yyyy
        /// Define by: Nguyen Anh Duc
        /// </summary>
        /// <param name="strDate"></param>
        /// <returns></returns>
        public static string ConvertDateUSAToFrench(string strDate)
        {
            string strDay, strMonth, strYear, strTMP;
            if (strDate.Trim().Length == 10)
            {
                strTMP = strDate.Trim();
                strTMP = strTMP.Replace(".", "/").Replace("-", "/");
                strDay = strTMP.Substring(3, 2);
                strMonth = strTMP.Substring(0, 2);
                strYear = strTMP.Substring(6, 4);
                if (IsNumber(strYear) && IsNumber(strMonth) && IsNumber(strDay))
                {
                    if (IsDate(Convert.ToInt32(strDay), Convert.ToInt32(strMonth), Convert.ToInt32(strYear)))
                        return strMonth + "/" + strDay + "/" + strYear;
                    else
                        throw new Exception("Ngày đưa vào không hợp lệ");
                }
                else
                    throw new Exception("Ngày hoặc Tháng hoặc Năm không đúng");
            }
            else
                throw new Exception("Định dạng ngày không tuân theo quy định ('mm/dd/yyyy' hoặc 'mm.dd.yyyy' hoặc 'mm-dd-yyyy')");
        }

        /// <summary>
        /// Kiểm tra Ngày, Tháng, Năm có đúng là một ngày hay không
        /// Define by: Nguyen Anh Duc
        /// </summary>
        /// <param name="intDay"></param>
        /// <param name="intMonth"></param>
        /// <param name="intYear"></param>
        /// <returns></returns>
        public static bool IsDate(int intDay, int intMonth, int intYear)
        {
            if (intDay < 1 || intDay > 31 || intMonth < 1 || intMonth > 12 || intYear < 0 || intYear > 9999)
                return false;
            else
                return DaysInMonth(intMonth, intYear) >= intDay ? true : false;
        }
        public static bool IsDateInTerm(string date, string startTerm, string endterm)
        {
            DateTime start;
            DateTime end;
            DateTime d;
            if (DateTime.TryParse(startTerm, out start) && DateTime.TryParse(endterm, out end) && DateTime.TryParse(date, out d))
            {
                return IsDateInTerm(d, start, end);
            }
            else
            {
                return false;
            }
        }
        public static bool IsDateInTerm(DateTime date,DateTime startTerm,DateTime endTerm)
        {
            if (DateTime.Compare(startTerm, date) <= 0 && DateTime.Compare(date, endTerm) <= 0)

                return true;
            else
                return false;
        }

        /// <summary>
        /// Lấy số ngày trong tháng của một năm
        /// Define by: Nguyen Anh Duc
        /// </summary>
        /// <param name="intMonth"></param>
        /// <param name="intYear"></param>
        /// <returns></returns>
        public static int DaysInMonth(int intMonth, int intYear)
        {
            if (intMonth < 1 || intMonth > 12 || intYear < 0 || intYear > 9999)
                throw new Exception("Thông tin tháng và năm không đúng");
            else
            {
                if (intMonth == 4 || intMonth == 6 || intMonth == 9 || intMonth == 11)
                {
                    return 30;
                }
                if (intMonth == 2)
                {
                    if (intYear % 4 == 0)
                        if ((intYear % 1000 == 0) && (intYear % 2000 != 0))
                            return 28;
                        else
                            return 29;
                    else
                        return 28;
                }
                else
                    return 31;
            }
        }

        /// <summary>
        /// Lay gia tri logic cua kien tim kiem boolean
        /// Define by: Nguyen Anh Duc
        /// </summary>
        /// <param name="eFindBooleanType"></param>
        /// <returns></returns>
        public static bool GetFindBooleanType(FindBooleanType eFindBooleanType)
        {
            if (eFindBooleanType == FindBooleanType.TRUE)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Kiểm tra xem ngày đưa vào có phải là ngày thực sự không
        /// Define by: Nguyen Anh Duc
        /// </summary>
        /// <param name="strDate"></param>
        /// <param name="eFormat"></param>
        /// <returns></returns>
        public static bool IsTrueDate(string strDate, FormatDate eFormat)
        {
            string strDay, strMonth, strYear, strTMP;
            bool isRet = false;
            //Chuoi ngay thang dinh dang kieu my mm/dd/yyyy
            if (eFormat == FormatDate.MM_DD_YYYY)
            {
                if (strDate.Trim().Length == 10)
                {
                    strTMP = strDate.Trim();
                    strTMP = strTMP.Replace(".", "/").Replace("-", "/");
                    strDay = strTMP.Substring(3, 2);
                    strMonth = strTMP.Substring(0, 2);
                    strYear = strTMP.Substring(6, 4);
                    if (IsNumber(strYear) && IsNumber(strMonth) && IsNumber(strDay))
                    {
                        if (IsDate(Convert.ToInt32(strDay), Convert.ToInt32(strMonth), Convert.ToInt32(strYear)))
                            isRet = true;
                        else
                            isRet = false;
                    }
                    else
                        isRet = false;
                }
                else
                    isRet = false;
            }
            else if (eFormat == FormatDate.DD_MM_YYYY)//Chuoi ngay thang dinh dang kieu phap dd/mm/yyyy
            {
                if (strDate.Trim().Length == 10)
                {
                    strTMP = strDate.Trim();
                    strTMP = strTMP.Replace(".", "/").Replace("-", "/");
                    strDay = strTMP.Substring(0, 2);
                    strMonth = strTMP.Substring(3, 2);
                    strYear = strTMP.Substring(6, 4);
                    if (IsNumber(strYear) && IsNumber(strMonth) && IsNumber(strDay))
                    {
                        if (IsDate(Convert.ToInt32(strDay), Convert.ToInt32(strMonth), Convert.ToInt32(strYear)))
                            isRet = true;
                        else
                            isRet = false;
                    }
                    else
                        isRet = false;
                }
                else
                    isRet = false;
            }
            return isRet;
        }

        /// <summary>
        /// Lay ve so nam cua the bao hiem tu han cua the
        /// </summary>
        /// <param name="strFromDate"></param>
        /// <param name="strToDate"></param>
        /// <returns></returns>
        public static long GetTotalYearOfCard(string strFromDate, string strToDate)
        {
            return DateAndTime.DateDiff(DateInterval.Year, Convert.ToDateTime(strFromDate, CulFr), Convert.ToDateTime(strToDate, CulFr), FirstDayOfWeek.Monday, FirstWeekOfYear.Jan1) + 1;
        }

        /// <summary>
        /// Lay ve tong so ngay giua hai khoang ngay
        /// </summary>
        /// <param name="strFromDate"></param>
        /// <param name="strToDate"></param>
        /// <returns></returns>
        public static long GetTotalTwoDay(string strFromDate, string strToDate)
        {
            return DateAndTime.DateDiff(DateInterval.Day, Convert.ToDateTime(strFromDate, CulFr), Convert.ToDateTime(strToDate, CulFr), FirstDayOfWeek.Monday, FirstWeekOfYear.Jan1) + 1;
        }

        /// <summary>
        /// Hien thi ten may tinh local tren bao cao
        /// </summary>
        /// <returns></returns>
        public static string DisplayLocalHostName()
        {
            string hostName;
            try
            {
                // Get the local computer host name.
                hostName = System.Net.Dns.GetHostName();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "GHMS");
                hostName = "";
            }
            return hostName;
        }

        /// <summary>
        /// Lay ve IP cua may client
        /// </summary>
        /// <returns></returns>
        public static string GetIPClient()
        {
            #region Cu
            //string strHostName = "";
            //string strIPAddress = "";
            //// Getting Ip address of local machine...
            //// First get the host name of local machine.
            //strHostName = Dns.GetHostName();

            //// Then using host name, get the IP address list..
            //IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            //IPAddress[] addr = ipEntry.AddressList;

            //if (addr != null && addr.Length > 0)
            //    strIPAddress = addr[0].ToString();
            //else
            //    strIPAddress = "KHÔNG CÓ IP";

            //return strIPAddress;
            #endregion

            string strHostName = "";
            string strIPAddress = "";
            // Getting Ip address of local machine...
            // First get the host name of local machine.
            strHostName = Dns.GetHostName();

            // Then using host name, get the IP address list..
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            foreach (IPAddress ip in addr)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    strIPAddress = ip.ToString();
                    break;
                }
            }
            return strIPAddress;
        }

        /// <summary>
        /// Lay ve ten may tinh hien tai
        /// </summary>
        /// <returns></returns>
        public static string GetComputerName()
        {
            return SystemInformation.ComputerName;
        }

        /// <summary>
        /// Lay ve thoi gian hien tai
        /// </summary>
        /// <returns></returns>
        public static string GetDateTime()
        {
            return DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        
        /// <summary>
        /// Tra ve chuoi phia duoi cua bao cao
        /// </summary>
        /// <returns></returns>
        public static string GetButtomTitle()
        {
            return "Báo cáo được in từ máy " + GlobalCommon.GetComputerName() + " thời gian " + GlobalCommon.GetDateTime();
        }

        /// <summary>
        /// Lay trang thai dang nhap lam viec cua nguoi su dung
        /// Define by: Nguyen Anh Duc
        /// </summary>
        /// <returns></returns>
        public static bool GetLoginType()
        {
            return Convert.ToBoolean(Csla.ApplicationContext.GlobalContext["LOGIN_TYPE"]);
        }
        /// <summary>
        ///  lay ve phan du trong phep chia SoBiChia cho SoChia
        /// </summary>
        /// <param name="SoBiChia"></param>
        /// <param name="SoChia"></param>
        /// <returns></returns>
        public static int Mod(int SoBiChia, int SoChia)
        {
            return SoBiChia - (SoBiChia / SoChia) * SoChia;
        }
        public static long Mod(long SoBiChia, int SoChia)
        {
            return SoBiChia - (SoBiChia / SoChia) * SoChia;
        }
        /// <summary>
        /// Create: Nguyễn Công Chính
        /// Hàm đưa ra câu SQL điều kiện
        /// IDLoaiBenhNhan chính là ID đối tượng trợ phí
        /// TrangThai: =1:Tất cả, 2:Đang điều trị, 3:Đã ra viện ,4:trốn viện
        /// </summary>
        /// <param name="lngIDLoaiBenhNhan"></param>
        /// <param name="intTrangThai"></param>
        /// <returns></returns>
        public static string getConSQL(long lngIDLoaiBenhNhan, Int16 intTrangThai)
        {
            string strResult;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.Text;
                    cm.CommandText = "Select dbo.fn_GetConSQL(" + lngIDLoaiBenhNhan.ToString() + "," + intTrangThai.ToString() + ") as SQL ";
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        dr.Read();
                        strResult = dr.GetString("SQL");
                    }
                }
            }
            return strResult;
        }
        public static long getIDLoaiDichVuFormIDDichVu(long lngIDDichVu)
        {
            long lngResult;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandText = "Select dbo.fn_GetIDLoaiFromIDDichVu(" + lngIDDichVu.ToString() + ")as Result";
                    cm.CommandType = CommandType.Text;
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        dr.Read();
                        lngResult = dr.GetInt64("Result");
                    }
                }
            }
            return lngResult;

        }

        public static void KhoaNhapDuLieu(long lngIDKhoa, DateTime Ngay)
        {
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "IP_VienKhoaPhong_Lock_ins";
                    cm.Parameters.AddWithValue("@IDKhoa", lngIDKhoa);
                    cm.Parameters.AddWithValue("@Ngay", Ngay.Date);
                    cm.ExecuteNonQuery();
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="shtSoLuong"></param>
        /// <param name="shtSoLuongXD"></param>
        /// <param name="decGiaTP"></param>
        /// <param name="decGiaTN"></param>
        /// <returns></returns>
        public static byte getTrangThaiXD(short shtSoLuong, short shtSoLuongXD, decimal decGiaTP, decimal decGiaTN)
        {
            byte result;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.Text;
                    cm.CommandText = "Select dbo.fn_TrangThaiXetDuyet("
                        + shtSoLuong.ToString() + ","
                        + shtSoLuongXD.ToString() + ","
                        + decGiaTP.ToString() + ","
                        + decGiaTN.ToString() + ") as TrangThai";
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        dr.Read();
                        result = dr.GetByte("TrangThai");
                    }
                }
            }
            return result;
        }
        public static long getIDDonViTroPhiTheoNgay(long lngIDDieuTri, DateTime dteNgaySuDung)
        {
            long result;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "get_IDDonViTroPhiTheoNgay";
                    cm.Parameters.AddWithValue("@IDDieuTri", lngIDDieuTri);
                    cm.Parameters.AddWithValue("@NgaySuDung", dteNgaySuDung);
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        dr.Read();
                        result = dr.GetInt64("IDDonvitrophi");
                    }
                }
            }
            return result;
        }
        public static string GetTrinhDobyID(string trinhdo)
        {

            string result = string.Empty;
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                string str = "SELECT Top(1) TenTat FROM dbo.DIC_HocVi WHERE LOWER(TenHocVi) = LOWER(N'" + trinhdo + "')";
                using (var cm = new SqlCommand(str, ctx.Connection))
                {
                    cm.CommandType = CommandType.Text;
                    using (Csla.Data.SafeDataReader dr = new Csla.Data.SafeDataReader(cm.ExecuteReader()))
                    {
                        dr.Read();

                        result = dr.GetString(0);
                    }

                }
            }
            
            
            return result;
        }
        public static bool CheckCanBoPhuTrach(long idnguoidung, int? idkhunglop)
        {

            string result = string.Empty;
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                string str = "select MaLop from DT_LienTuc_LopHoc where idCanBoPhuTrach  = (select Idcanbo from ADM_NguoiDung where IDNguoiDung = "+idnguoidung.ToString()+") and idKhungLopHoc = " + idkhunglop.ToString();
                using (var cm = new SqlCommand(str, ctx.Connection))
                {
                    cm.CommandType = CommandType.Text;
                    using (Csla.Data.SafeDataReader dr = new Csla.Data.SafeDataReader(cm.ExecuteReader()))
                    {
                        try
                        {
                            dr.Read();
                            result = dr.GetString(0);
                        }catch(Exception ex)
                        {
                            result = string.Empty;
                        }
                    }

                }
            }

            if (result.Length == 0)
                return false;
            else
                return true;
        }
        public static long getIDNhomDichVuFromIDDichVu(long lngIDDichVu)
        {
            long result;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.Text;
                    cm.CommandText = " Select IDNhomDichVu from DIC_CacDichVu where IDDichVu=" + lngIDDichVu.ToString();
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        dr.Read();
                        result = dr.GetInt64("IDNhomDichVu");
                    }
                }
            }
            return result;
        }
        /// <summary>
        ///  tra ve so ngay cua mot ngay
        /// </summary>
        /// <param name="dteNgay"></param>
        /// <returns></returns>
        public static int SoNgay(DateTime dteDateTime)
        {
            int intmcode = 0;
            int d = dteDateTime.Day;
            int m = dteDateTime.Month;
            int y = dteDateTime.Year;
            string strThu = string.Empty;
            string[] strTempalete = "5 1 1 4 6 2 4 0 3 5 1 3".Split(' ');
            intmcode = Convert.ToInt32(strTempalete[m - 1]);
            return (int)(y * 1.25) + intmcode + d;
        }
        /// <summary>
        /// Author: Dang Van Thi
        /// Tra ve thu cua ngay truyen vao
        /// 
        /// </summary>
        /// <param name="dteDateTime"></param>
        /// <returns></returns>
        public static string LayVeThu(DateTime dteDateTime)
        {
            //            ' Return values:
            //' 0 = Sunday
            //' 1 = Monday
            //' 2 = Tuesday
            //' 3 = Wednesday
            //' 4 = Thursday
            //' 5 = Friday
            //' 6 = Saturday
            //    Dim y As Integer
            //    Dim m As Integer
            //    Dim d As Integer

            //    ' monthdays:
            //    ' This is a "template" for a year. Each number
            //    ' stands for a day of the week. The general idea
            //    ' is that, in a standard year, if Jan 1 is on a
            //    ' Friday, then Feb 1 will be a Monday, Mar 1
            //    ' will be a Monday, April 1 will be a Thursday,
            //    ' May 1 will be Saturday, etc..
            //    Dim mcode As Integer
            //    Dim monthdays() As String
            //    monthdays = Split("5 1 1 4 6 2 4 0 3 5 1 3")

            //    ' Grab our date info
            //    y = Val(Format(GregDate, "yyyy"))
            //    m = Val(Format(GregDate, "mm"))
            //    d = Val(Format(GregDate, "dd"))

            //    ' Snatch the corresponding month code
            //    mcode = Val(monthdays(m - 1))

            //    ' Multiplying by 1.25 takes care of leap years,
            //    ' but not completely. Jan and Feb of a leap year
            //    ' will end up a day extra.
            //    ' The 'mod 7' gives us our day.
            //    DOW = ((Int(y * 1.25) + mcode + d) Mod 7)

            //    ' This takes care of leap year Jan and Feb days.
            //    If y Mod 4 = 0 And m < 3 Then DOW = (DOW + 6) Mod 7
            int intmcode = 0;
            int d = dteDateTime.Day;
            int m = dteDateTime.Month;
            int y = dteDateTime.Year;
            int intResult = 0;
            string strThu = string.Empty;
            string[] strTempalete = "5 1 1 4 6 2 4 0 3 5 1 3".Split(' ');
            intmcode = Convert.ToInt32(strTempalete[m - 1]);
            intResult = Mod((int)(y * 1.25) + intmcode + d, 7);

            if (Mod(y, 4) == 0 && m < 3)
                intResult = Mod(intResult + 6, 7);
            switch (intResult)
            {
                case 0:
                    strThu = "Chủ nhật";
                    break;
                case 1:
                    strThu = "Thứ hai";
                    break;
                case 2:
                    strThu = "Thứ ba";
                    break;
                case 3:
                    strThu = "Thứ tư";
                    break;
                case 4:
                    strThu = "Thứ năm";
                    break;
                case 5:
                    strThu = "Thứ sáu";
                    break;
                case 6:
                    strThu = "Thứ bẩy";
                    break;
            }
            return strThu;
        }
        public static bool CanhBaoKyQuy(long lngIDDieuTri, DateTime dteNgay)
        {
            bool bolResult = false;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.Text;
                    cm.CommandText = "Select dbo.fn_CanhBaoKyQuy(" + lngIDDieuTri.ToString() + ",'" + dteNgay.ToString("MM/dd/yyyy") + "' ) as Result";
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        if (dr.Read())
                            bolResult = dr.GetBoolean("Result");
                    }
                }
            }
            return bolResult;
        }
        /// <summary>
        /// Lấy về mảng các thuộc người sử dụng đặt 
        /// </summary>
        /// <returns></returns>
        public static List<string[,]> ThuocTinhTenDonThuoc()
        {
            if (Csla.ApplicationContext.GlobalContext["MangThuocTinhTenDonThuoc"] == null)
                return null;
            else
                return (List<string[,]>)Csla.ApplicationContext.GlobalContext["MangThuocTinhTenDonThuoc"];
        }

        /// <summary>
        /// Phương thức lưu được khai báo bởi người sử dụng
        /// </summary>
        /// <param name="lngIDNguoiDung"></param>
        /// <param name="shtIDThamSo"></param>
        /// <param name="strGiaTri"></param>
        public static void ThemThamSoKhaiBao(long lngIDNguoiDung, ThamSo eThamSo, string strGiaTri)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(DBConnection.AdminConnection))
                {
                    //Open connection
                    cn.Open();
                    using (SqlCommand cm = cn.CreateCommand())
                    {
                        cm.CommandText = "DIC_ThamSoNguoiDung_ins";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@IDNguoiDung", lngIDNguoiDung);
                        cm.Parameters.AddWithValue("@IDThamSo", Convert.ToInt32(eThamSo));
                        cm.Parameters.AddWithValue("@GiaTri", strGiaTri);

                        cm.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowError(ex.Message, "Lỗi ghi tham số: " + eThamSo.ToString());
                return;
            }
        }

        /// <summary>
        /// Phương thức xóa tham số khai báo
        /// </summary>
        /// <param name="lngIDNguoiDung"></param>
        /// <param name="shtIDThamSo"></param>
        public static void XoaThamSoKhaiBao(long lngIDNguoiDung, ThamSo eThamSo)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(DBConnection.AdminConnection))
                {
                    //Open connection
                    cn.Open();
                    using (SqlCommand cm = cn.CreateCommand())
                    {
                        cm.CommandText = "DIC_ThamSoNguoiDung_del";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@IDNguoiDung", lngIDNguoiDung);
                        cm.Parameters.AddWithValue("@IDThamSo", Convert.ToInt32(eThamSo));

                        cm.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowError(ex.Message, "Lỗi xóa tham số: " + eThamSo.ToString());
                return;
            }
        }

        /// <summary>
        /// Phương thức xóa tham số khai báo co OffLine
        /// </summary>
        /// <param name="lngIDNguoiDung"></param>
        /// <param name="shtIDThamSo"></param>
        public static void XoaThamSoKhaiBaoForOffLine(long lngIDNguoiDung, ThamSo eThamSo)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(DBConnection.OffLineConnection))
                {
                    //Open connection
                    cn.Open();
                    using (SqlCommand cm = cn.CreateCommand())
                    {
                        cm.CommandText = "DIC_ThamSoNguoiDung_del";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@IDNguoiDung", lngIDNguoiDung);
                        cm.Parameters.AddWithValue("@IDThamSo", Convert.ToInt32(eThamSo));

                        cm.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowError(ex.Message, "Lỗi xóa tham số: " + eThamSo.ToString());
                return;
            }
        }

        /// <summary>
        /// Đọc giá trị của tham số được khai báo
        /// </summary>
        /// <param name="lngIDNguoiDung"></param>
        /// <param name="shtIDThamSo"></param>
        /// <returns></returns>
        public static string DocThamSoKhaiBao(long lngIDNguoiDung, ThamSo eThamSo)
        {
            object oRet = "";
            using (SqlConnection cn = new SqlConnection(DBConnection.AdminConnection))
            {
                //Open connection
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandText = "select dbo.fn_DocThamSo(" + lngIDNguoiDung.ToString() + "," + Convert.ToInt32(eThamSo).ToString() + ") as Result";
                    cm.CommandType = CommandType.Text;
                    oRet = cm.ExecuteScalar();
                }
            }
            return (oRet == null ? "" : oRet.ToString());
        }
        /// <summary>
        ///  dung de doc tham so khai khai bao o OffLine
        /// </summary>
        /// <param name="lngIDNguoiDung"></param>
        /// <param name="eThamSo"></param>
        /// <returns></returns>
        public static string DocThamSoKhaiBaoForOffLine(long lngIDNguoiDung, ThamSo eThamSo)
        {
            object oRet = "";
            using (SqlConnection cn = new SqlConnection(DBConnection.OffLineConnection))
            {
                //Open connection
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandText = "select dbo.fn_DocThamSo(" + lngIDNguoiDung.ToString() + "," + Convert.ToInt32(eThamSo).ToString() + ") as Result";
                    cm.CommandType = CommandType.Text;
                    oRet = cm.ExecuteScalar();
                }
            }
            return (oRet == null ? "" : oRet.ToString());
        }
        /// <summary>
        ///  lam tron tien
        /// </summary>
        /// <param name="lngNumber">286789, 498567</param>
        /// <param name="digit">=10, 100, 1000</param>
        /// <returns></returns>
        public static long MoneyRound(decimal decNumber, int digit)
        {
            long lngreturn=0;
            if (decNumber > 0 && digit > 0)
            {
                long tem1 = (decNumber.ToString().Contains(".")? Convert.ToInt64(decNumber.ToString().Split('.')[0].ToString()):Convert.ToInt64(decNumber.ToString()));
                long tem= Mod(tem1, digit);
                int Round  = Convert.ToInt32(tem.ToString());
                if (Round > digit / 2)
                    Round = digit;
                else
                    Round = 0;
                lngreturn = (tem1 / digit) * digit + Round;
            }
            return lngreturn;
        }

        /// <summary>
        /// Generate barcode from string
        /// </summary>
        /// <param name="strTextToBarCode"></param>
        /// <param name="isIncludeLabel"></param>
        /// <param name="type"></param>
        /// <param name="intWidth"></param>
        /// <param name="intHeight"></param>
        /// <returns></returns>
        public static byte[] GetBarCode(string strTextToBarCode, bool isIncludeLabel, BarcodeLib.TYPE type, int intWidth, int intHeight)
        {
            BarcodeLib.Barcode b = new BarcodeLib.Barcode();
            b.IncludeLabel = isIncludeLabel;
            return ConvertImageToByteArray(b.Encode(type, strTextToBarCode.Trim(), System.Drawing.Color.Black, System.Drawing.Color.White, intWidth, intHeight));
        }

        /// <summary>
        /// Convert Image to Byte Array
        /// </summary>
        /// <param name="imageIn"></param>
        /// <returns></returns>
        private static byte[] ConvertImageToByteArray(System.Drawing.Image imageIn)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            return ms.ToArray();
        }

        /// <summary>
        /// Convert chuỗi ngày tháng năm về kiểu nguyên(yyymmdd)
        /// </summary>
        /// <param name="strDatetime"></param>
        /// <returns></returns>
        public static int ConvertDateToInt(string strDatetime)
        {
            string strRevert;

            if (strDatetime.Trim().Equals(""))
                strRevert = "0";
            else
            {
                if (GlobalCommon.IsTrueDate(strDatetime, FormatDate.DD_MM_YYYY))
                {
                    strRevert = strDatetime.Substring(6, 4);//yyyy
                    strRevert += strDatetime.Substring(3, 2);//mm
                    strRevert += strDatetime.Substring(0, 2);//dd
                }
                else
                    strRevert = "-1";
            }
            return Convert.ToInt32(strRevert);
        }

        /// <summary>
        /// Kiểm tra xem có tồn tại một bản ghi trong một bảng thỏa mãn một cột đưa vào bằng một giá trị đưa vào
        /// </summary>
        /// <param name="strTenBang">Tên bảng</param>
        /// <param name="strTenCot">Tên cột</param>
        /// <param name="strGiaTri">Giá trị của một</param>
        /// <returns></returns>
        public static bool CoTonTai(string strTenBang, string strTenCot, string strGiaTri)
        {
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                //Open connection
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandText = "select 1 as RET from " + strTenBang + " where " + strTenCot + "='" + strGiaTri + "'";
                    cm.CommandType = CommandType.Text;
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        if (dr.Read())
                            return true;
                        else
                            return false;
                    }
                }
            }
        }

        /// <summary>
        /// Kiểm tra xem có thông với máy có địa chỉ IP được truyền vài hay không
        /// </summary>
        /// <param name="strDiaChiIP">Địa chỉ IP của máy cần kiểm tra</param>
        /// <returns></returns>
        public static bool IsCoThongVoiMay(string strDiaChiIP)
        {
            if(strDiaChiIP.Contains(@".\"))
                return true;
            IPAddress ip = (IPAddress)Dns.GetHostEntry(strDiaChiIP.Equals(".") ? "127.0.0.1" : strDiaChiIP).AddressList[0];
            PingOptions options = new PingOptions(128, true);
            Ping ping = new Ping();
            byte[] data = new byte[32];
            List<long> responseTimes = new List<long>();
            PingReply reply = ping.Send(ip, 1000, data, options);
            if (reply != null)
            {
                switch (reply.Status)
                {
                    case IPStatus.Success:
                        return true;
                    case IPStatus.TimedOut:
                        return false;
                    default:
                        return false;
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Lấy về 15% lương tối thiểu được áp dụng cho một bệnh nhân
        /// </summary>
        /// <param name="lngIDBenhNhan">ID Bệnh nhân</param>
        /// <param name="ePatientTable">Bảng cần lấy</param>
        /// <returns></returns>
        public static int Get15PercentMinSalary(long lngIDBenhNhan, PatientTable ePatientTable)
        {
            string strSQL = "SELECT LuongToiThieu FROM ";
            if (ePatientTable == PatientTable.IP_BENH_NHAN)
                strSQL += "IP_BenhNhan WHERE IDBenhNhan = " + lngIDBenhNhan.ToString();
            else if (ePatientTable == PatientTable.OP_TIEP_NHAN_BENH_NHAN)
                strSQL += "OP_TiepNhanBenhNhan WHERE IDBenhNhan = " + lngIDBenhNhan.ToString();
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                //Open connection
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandText = strSQL;
                    cm.CommandType = CommandType.Text;
                    int intLuongToiThieu = Convert.ToInt32(cm.ExecuteScalar());
                    return intLuongToiThieu;
                }
            }
        }

        public static string VietinbankSiteGet()
        {
            string _strReturn = string.Empty;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                //Open connection
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandText = "select ParaValue from adm_parameteres where ID = 'VTS'";
                    cm.CommandType = CommandType.Text;
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        if (dr.Read())
                            _strReturn = dr.GetString("ParaValue");
                    }
                }
            }
            return _strReturn;
        }

            public static double TotalMonths(this DateTime start, DateTime end)
            {
                if (end != null && start != null)
                {
                    //TimeSpan ts;
                    //double month = end.Subtract(start).Days / (365.25 / 12);
                    double month = end.Subtract(start).Days;
                    month = Math.Round(month / 30, MidpointRounding.AwayFromZero);
                    //double month = end.Subtract(start).Days / 30;
                    //ts = end - start;
                    month *= 2;
                    //month = Math.Round(month, MidpointRounding.AwayFromZero);
                    return month / 2;
                }
                return 0;
            }

        /// <summary>
        /// Lưu LOG trao đổi dữ liệu với ngân hàng khi thanh toán trực tuyến
        /// </summary>
        /// <param name="bteIDPhanBiet">IDPhanBiet=1 la Ky Quy, IDPhanBiet=2 là Nội trú, IDPhanBiet=3 là Ngoại trú</param>
        /// <param name="lngIDNguoiDung">IDNguoiDung khi gửi đi hoặc của webservice khi nhận kết quả</param>
        /// <param name="strLogInput">Dữ liệu nhận về</param>
        /// <param name="strLogOutput">Dữ liệu gửi đi</param>
        /// <param name="bteLogResult"> 0: thành công ; >0: lưu mã lỗi</param>
        public static void LOG_ThanhToanOnline(byte bteIDPhanBiet, long lngIDNguoiDung, string strLogInput, string strLogOutput, byte bteLogResult)
        {
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "LOG_ThanhToanOnline_ins";
                    cm.Parameters.AddWithValue("@IDPhanBiet", bteIDPhanBiet);
                    cm.Parameters.AddWithValue("@IDNguoiDung", lngIDNguoiDung);
                    if (strLogInput.Length > 0) 
                        cm.Parameters.AddWithValue("@LogInput", strLogInput);
                    if (strLogOutput.Length > 0)
                        cm.Parameters.AddWithValue("@LogOutput", strLogOutput);
                    cm.Parameters.AddWithValue("@LogResult", bteLogResult);
                    cm.ExecuteNonQuery();
                }
            }
        }
        #region Cache

        public static bool CacheRemove(string CacheID)
        {
            try
            {
                ObjectCache cache = MemoryCache.Default;
                CacheItemPolicy itemPolicy = new CacheItemPolicy();
                //itemPolicy.AbsoluteExpiration = DateTimeOffset.
                cache.Remove(CacheID);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool CacheWriter(string CacheID, object obj)
        {
            try
            {
                ObjectCache cache = MemoryCache.Default;
                CacheItemPolicy itemPolicy = new CacheItemPolicy();
                //itemPolicy.AbsoluteExpiration = DateTimeOffset.
                cache.Set(CacheID, obj, itemPolicy);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static object CacheReader(string CacheID)
        {
            try
            {
                ObjectCache cache = MemoryCache.Default;
                return cache.Get(CacheID);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        #endregion
        /*public static string generaUniqueId(){
            return Guid.NewGuid().ToString().Replace("-", string.Empty);
        }*/
        public static DateTime convertStringtoDateTime(string dateTime)
        {
           return DateTime.ParseExact(dateTime, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }




    }
}
