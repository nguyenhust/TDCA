using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using NETLINK.LIB;
using NETLINK.UI;
using TruyenThong.LIB;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using DanhMuc.LIB;
using Csla.Windows;
using Authoration.LIB;
using ExportLib;
using System.Linq;

namespace TruyenThong.UI
{
    public partial class ThongKe : Dictionary
    {

        private const string PreAnPhamLoai = "1$Loại_";
        private const string PreAnPhamDonViDat = "2$Đơn vị đặt_";

        private const string PreBaiVietLoai = "1$Loại_";

        private const string PrePhongVienCoQuan = "1$Cơ Quan_";
        private const string PrePhongVienKhoaLamViec = "2$Khoa làm việc_";

        private const string PreSuKienLoai = "1$Loại_";
        private const string PreSuKienChuyenKhoa = "2$Chuyên khoa_";

        private const string BoTrongKhongNhap = "(Bị bỏ trống)";
        RadGridView RadGrid;
        private Dictionary<string, int> result;
        private string TenDeMuc = string.Empty;

        public ThongKe(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();

            this.formMode = _formMode;
            
            if (formMode.Item != null)
                RadGrid = (RadGridView)formMode.Item;
            else
                this.Close();
           
        }
        protected override void ApplyAuthorizationRules()
        {
        }
        protected override void Save()
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        protected override void FormLoad()
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void BindData(bool isLoad)
        {
     
        }
        private void CheckPlusOrInsertKey(string key)
        {
            CheckPlusOrInsertKey(key, 1);
        }
        private void CheckPlusOrInsertKey(string key,int number)
        {
           // key = key.ToLower().Trim();
            if (result.ContainsKey(key))
            {
                result[key] = result[key] + number;
            }
            else
            {
                result.Add(key, number);
            }
        }
        private bool ValidateDataBeforeSave()
        {
            if (!netLink_DatePicker1.isDateTime && !netLink_DatePicker1.isNull)
            {
                GlobalCommon.ShowErrorMessager(netLink_DatePicker1.Value_Error);
                return false;
            }
            if (!netLink_DatePicker2.isDateTime && !netLink_DatePicker2.isNull)
            {
                GlobalCommon.ShowErrorMessager(netLink_DatePicker2.Value_Error);
                return false;
            }
            if (GlobalCommon.CheckArrayTextIsNull(new object[] { netLink_DatePicker1.Value_String,netLink_DatePicker2.Value_String }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            return true;
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
            root = root.Replace(PreAnPhamLoai, string.Empty);
            root = root.Replace(PreAnPhamDonViDat, string.Empty);
            root = root.Replace(PreBaiVietLoai, string.Empty);
            root = root.Replace(PrePhongVienCoQuan, string.Empty);
            root = root.Replace(PrePhongVienKhoaLamViec, string.Empty);
            root = root.Replace(PreSuKienLoai, string.Empty);
            root = root.Replace(PreSuKienChuyenKhoa, string.Empty);

            return root;
        }
        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidateDataBeforeSave())
                {
                    result = new Dictionary<string, int>();
                    string startDate = netLink_DatePicker1.Value_String;
                    string endDate = netLink_DatePicker2.Value_String;                    
                    if (formMode.FormID == TextMessages.ControlID.TT_BaiViet)
                    {
                        TenDeMuc = "Bài viết";
                        foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
                        {
                            if (rowInfo.IsVisible)
                            {
                                TT_BaiViet_Info bv = (TT_BaiViet_Info)rowInfo.DataBoundItem;
                                if (GlobalCommon.IsDateInTerm(bv.ThoiGianDang, startDate, endDate))
                                {
                                    if (string.IsNullOrEmpty(bv.Loai))
                                        CheckPlusOrInsertKey(PreBaiVietLoai + BoTrongKhongNhap);
                                    else
                                        CheckPlusOrInsertKey(PreBaiVietLoai + bv.Loai);
                                }

                            }
                        }
                    }
                    else if (formMode.FormID == TextMessages.ControlID.TT_AnPham)
                    {
                        TenDeMuc = "Ấn Phẩm";
                        foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
                        {
                            if (rowInfo.IsVisible)
                            {
                                TT_AnPham_Info bv = (TT_AnPham_Info)rowInfo.DataBoundItem;
                                if (GlobalCommon.IsDateInTerm(bv.TuNgay, startDate, endDate))
                                {
                                    if (string.IsNullOrEmpty(bv.Loai))
                                        CheckPlusOrInsertKey(PreAnPhamLoai + BoTrongKhongNhap);
                                    else
                                        CheckPlusOrInsertKey(PreAnPhamLoai + bv.Loai,Convert.ToInt32(bv.SoLuong));

                                    if (string.IsNullOrEmpty(bv.DonViDat))
                                        CheckPlusOrInsertKey(PreAnPhamDonViDat + BoTrongKhongNhap);
                                    else
                                        CheckPlusOrInsertKey(PreAnPhamDonViDat + bv.DonViDat.ToLower(), Convert.ToInt32(bv.SoLuong));
                                }

                            }
                        }
                    }
                    else if (formMode.FormID == TextMessages.ControlID.TT_PhongVan)
                    {
                        TenDeMuc = "Đoàn Phỏng Vấn";
                        foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
                        {
                            if (rowInfo.IsVisible)
                            {
                                TT_PhongVan_Info bv = (TT_PhongVan_Info)rowInfo.DataBoundItem;
                                if (GlobalCommon.IsDateInTerm(bv.ThoiGian, startDate, endDate))
                                {
                                    if (string.IsNullOrEmpty(bv.TenCoQuan))
                                        CheckPlusOrInsertKey(PrePhongVienCoQuan + BoTrongKhongNhap);
                                    else
                                        CheckPlusOrInsertKey(PrePhongVienCoQuan + bv.TenCoQuan);

                                    if (string.IsNullOrEmpty(bv.TenKhoa))
                                        CheckPlusOrInsertKey(PrePhongVienKhoaLamViec + BoTrongKhongNhap);
                                    else
                                        CheckPlusOrInsertKey(PrePhongVienKhoaLamViec + bv.TenKhoa);
                                }

                            }
                        }
                    }
                    else if (formMode.FormID == TextMessages.ControlID.TT_SuKien)
                    {
                        TenDeMuc = "Sự kiện";
                        foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
                        {
                            if (rowInfo.IsVisible)
                            {
                                TT_SuKien_Info bv = (TT_SuKien_Info)rowInfo.DataBoundItem;
                                if (GlobalCommon.IsDateInTerm(bv.ThoiGian, startDate, endDate))
                                {
                                    if (string.IsNullOrEmpty(bv.TenChuyenNganh))
                                        CheckPlusOrInsertKey(PreSuKienChuyenKhoa + BoTrongKhongNhap);
                                    else
                                        CheckPlusOrInsertKey(PreSuKienChuyenKhoa + bv.TenChuyenNganh);

                                    if (string.IsNullOrEmpty(bv.Loai))
                                        CheckPlusOrInsertKey(PreSuKienLoai + BoTrongKhongNhap);
                                    else
                                        CheckPlusOrInsertKey(PreSuKienLoai + bv.Loai);
                                }

                            }
                        }
                    }
                }
                PrintToHTML();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void PrintToHTML()
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Đề mục", "Số lượng" };
            string lastkey = string.Empty;
            foreach (var r in result.OrderBy(i => i.Key))
            {
                if (lastkey != GetPredictFullName(r.Key))
                {
                    ExportLib.Entities.HanhChinh.B100_Table rKey = new ExportLib.Entities.HanhChinh.B100_Table();
                    rKey.E_Value = new List<string>() { string.Empty, string.Empty };
                    cv.E_Content.Add(rKey);
                    ExportLib.Entities.HanhChinh.B100_Table rKey2 = new ExportLib.Entities.HanhChinh.B100_Table();
                    rKey2.E_Value = new List<string>() { string.Format("<center><b>Phân loại theo {0}</b></center>", GetPredictFullName(r.Key)), string.Empty };
                    cv.E_Content.Add(rKey2);
                    lastkey = GetPredictFullName(r.Key);
                }
                ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                cvItem.E_Value = new List<string>() { RemovePredict(r.Key), r.Value.ToString() };
                cv.E_Content.Add(cvItem);

            }
            cv.E_TenTrungTam = "Phòng Truyền Thông";
            cv.E_TenBenhVien = "Trung tâm TDC";
            cv.E_TieuDeBaoCao = "Báo cáo thống kê tổng hợp";
            cv.E_TuNgayDenNgay = string.Format("Từ ngày {0} đến ngày {1}", netLink_DatePicker1.Value_String, netLink_DatePicker2.Value_String);
            cv.E_IsUseTongSo = false;
            cv.E_ThongTinKhac = "Chuyên mục: " + TenDeMuc;
            // cv.E_ThongTinTongHop = string.Format("Dành cho học viên {0} - Tổng số: {1}",dropDownLoaiHinhDaoTao1.Text,listHV.Count.ToString());
            cv.E_NguoiKi = PTIdentity.FullName;

            //cv.ProcessTuNgayDenNgay(5); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }
    }
}
