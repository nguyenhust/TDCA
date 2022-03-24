using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NETLINK.UI;
using NETLINK.LIB;
using ModuleDaoTao.UI;
using ModuleDaoTao.LIB;
using Authoration.LIB;
using ExportLib;

namespace ModuleDaoTao.UserControls
{
    public partial class GridHocVienLienTucThongKe : UsDictionary
    {
        #region variables

        private FormMode formMode = new FormMode();
        private int selectedID = -1;
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
        private const string PreNamSinh = "2$Năm sinh_";
        private const string PreThoiGianHoc = "2$Thời gian học_";
        private const string PreSLThe = "9$Số lượng thẻ đã in_";
        private const string PreSLGiayChungNhan = "9$Số lượng giấy chứng nhận đã in_";

        int Mode;

        #endregion

        public GridHocVienLienTucThongKe()
        {
            InitializeComponent();

            RadGrid = radGridView1;
            RadGrid.CellFormatting += radGridView_CellFormatting;
            STT();
            HideNew();
            HideSave();
            HideDelete();
            PrintToShow();
            ShowPrint2 = true;
            TextPrint2 = "In báo cáo thống kê";
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            dropDownLoaiHinhDaoTao1.FillData();
            dropDownLoaiHinhDaoTao1.Text = "Kèm cặp";
            netLink_DatePicker1.Value_String = string.Format("01/01/{0}", DateTime.Now.Year);
            netLink_DatePicker2.Value_String = string.Format("31/12/{0}", DateTime.Now.Year);
            //panel2.BackColor = Color.
        }

       
        #region Override

        public override object GetIdValue()
        {

            return TextMessages.ControlID.DT_HocVienLienTucThongKe;
            
        }
        private void radGridView_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }
        public override string ToString()
        {

            return TextMessages.FormTitle.DT_HocVienLienTucThongKe;
            

        }

        protected override void ApplyAuthorizationRules()
        {
            // nếu có được quyền tối thiểu thì cho phép vào form
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_HocVien_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_HocVien_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_HocVien_Delete);
        }

        protected override void Save()
        {
           
        }
        protected override void Print2()
        {
            try
            {
                ProcessData();
                PrintToHTML();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        protected override void LoadUS()
        {
            try
            {
                if (dropDownBoPhan1.GetListData() == null)
                {
                    dropDownBoPhan1.FillData(1);
                }
              LoadData();

            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Print()
        {
            LoadUS();
        }

        protected override void Delete()
        {
            try
            {
              

            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void MyClose()
        {
            this.Close();
        }

        #endregion
        private void LoadData()
        {
            function = new BusinessFunction(BusinessFunctionMode.GetHocVienLienTucThongKe);
            function.ItemFilterCondition_Date = netLink_DatePicker1.Value;
            function.ItemFilterCondition_Date2 = netLink_DatePicker2.Value;
            function.ItemFilterCondition_Int = Convert.ToInt32(dropDownBoPhan1.Selected_ID);
            function.ItemFilterCondition_String = dropDownLoaiHinhDaoTao1.Text;
            if (dropDownLoaiHinhDaoTao1.Text == "Theo Lớp")
            {
                if (radRadioDangHoc.IsChecked)
                    function.ItemTrangThai = DT_Common_value.TT_HocVien_DangHoc;
                else if (radRadioChuaBatDauHoc.IsChecked)
                    function.ItemTrangThai = DT_Common_value.TT_HocVien_ChuaHoc;
                else if (radRadioKTChuaCapCC.IsChecked)
                    function.ItemTrangThai = DT_Common_value.TT_HocVien_ChuaCapChungChi;
                else if (radRadioKTDaCapCC.IsChecked)
                    function.ItemTrangThai = DT_Common_value.TT_HocVien_DaCapChungChi;
                else if (radRadioBaoLuu.IsChecked)
                    function.ItemTrangThai = DT_Common_value.TT_HocVien_BaoLuu;
                else if (radRadioDinhChi.IsChecked)
                    function.ItemTrangThai = DT_Common_value.TT_HocVien_DinhChi;
                else if (radRadioThoiHoc.IsChecked)
                    function.ItemTrangThai = DT_Common_value.TT_HocVien_ThoiHoc;
                else if (radRadioTLAll.IsChecked)
                    function.ItemTrangThai = "";
            }
            else if (dropDownLoaiHinhDaoTao1.Text == "Kèm cặp")
            {
                if (radbtnChuaHoc.IsChecked)
                    function.ItemTrangThai = DT_Common.KC_ChuaHoc;
                else if (radbtnDaHoc_DCCC.IsChecked)
                    function.ItemTrangThai = DT_Common.KC_KetThucDCCC;
                else if (radDaHoc_CCCC.IsChecked)
                    function.ItemTrangThai = DT_Common.KC_KetThucCCCC;
                else if (radThoiHoc.IsChecked)
                    function.ItemTrangThai = DT_Common.KC_ThoiHoc;
                else if (radbtnDangHoc.IsChecked)
                    function.ItemTrangThai = DT_Common.KC_DangHoc;
                else if (radbtnKCALL.IsChecked)
                    function.ItemTrangThai = DT_Common.KC_All;

            }
            

            listHV = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
            
            RadGrid.DataSource = listHV;
            TotalRecordValue = listHV.Count.ToString() ;
        }
        private void CheckPlusOrInsertKey(string key)
        {
            if (result.ContainsKey(key))
            {
                result[key]++;
            }
            else
            {
                result.Add(key, 1);
            }
        }
        private void ProcessData()
        {
            result = new Dictionary<string, int>();
            TongSoHV = 0;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    DT_LienTuc_HocVien_Info hv = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;

                    if (function.ItemFilterCondition_String == "Kèm cặp" || function.ItemFilterCondition_Int2 == DT_Common.IN_XepLop_All || (function.ItemFilterCondition_Int2 == DT_Common.IN_DaXepLop && !string.IsNullOrEmpty(hv.MaLopHoc)) || (function.ItemFilterCondition_Int2 == DT_Common.IN_ChuaXepLop && string.IsNullOrEmpty(hv.MaLopHoc)))
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

                        if (string.IsNullOrEmpty(hv.NgaySinh))
                            CheckPlusOrInsertKey(PreNamSinh + BoTrongKhongNhap);
                        else
                        {
                            int n = hv.DateNgaySinh.Year;
                            if (n >= 2000)
                                CheckPlusOrInsertKey(PreNamSinh + "Sau 2000");
                            else if (n <= 1999 && n >= 1990)
                                CheckPlusOrInsertKey(PreNamSinh + "1990 - 1999");
                            else if (n <= 1989 && n >= 1980)
                                CheckPlusOrInsertKey(PreNamSinh + "1980 - 1989");
                            else if (n <= 1979 && n >= 1970)
                                CheckPlusOrInsertKey(PreNamSinh + "1970 - 1979");
                            else if (n <= 1969 && n >= 1960)
                                CheckPlusOrInsertKey(PreNamSinh + "1960 - 1969");
                            else if (n <= 1959 && n >= 1950)
                                CheckPlusOrInsertKey(PreNamSinh + "1950 - 1959");
                            else
                                CheckPlusOrInsertKey(PreNamSinh + "Trước 1950");
                        }
                        if (hv.TongSoLanInThe > 0)
                            CheckPlusOrInsertKey(PreSLThe + "Số lượng");
                        if (hv.TongSoLanInGiayChungNhan > 0)
                            CheckPlusOrInsertKey(PreSLGiayChungNhan + "Số lượng");
                        if (!string.IsNullOrEmpty(hv.NgayBatDau) && !string.IsNullOrEmpty(hv.NgayKetThuc))
                        {
                            int tsThang = Convert.ToInt32(GlobalCommon.TotalMonths(hv.DateNgayBatDau, hv.DateNgayKetThuc));

                            if (tsThang < 1)
                                CheckPlusOrInsertKey(PreThoiGianHoc + " dưới 1 tháng");
                            else if (tsThang == 1)
                                CheckPlusOrInsertKey(PreThoiGianHoc + "1 tháng");
                            else if (tsThang == 2)
                                CheckPlusOrInsertKey(PreThoiGianHoc + "2 tháng");
                            else if (tsThang == 3)
                                CheckPlusOrInsertKey(PreThoiGianHoc + "3 tháng");
                            else if (tsThang > 3 && tsThang < 6)
                                CheckPlusOrInsertKey(PreThoiGianHoc + "từ hơn 3 tháng đến dưới 6 tháng");
                            else if (tsThang >= 6 && tsThang <= 12)
                                CheckPlusOrInsertKey(PreThoiGianHoc + "từ 6 tháng đến 1 năm");
                            else if (tsThang > 12)
                                CheckPlusOrInsertKey(PreThoiGianHoc + "trên 1 năm");

                        }
                        else
                        {
                            CheckPlusOrInsertKey(PreThoiGianHoc + BoTrongKhongNhap);
                        }
                        TongSoHV++;
                    }
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
            root = root.Replace(PreThoiGianHoc, string.Empty);
            root = root.Replace(PreSLGiayChungNhan, string.Empty);
            root = root.Replace(PreSLThe, string.Empty);
            root = root.Replace(PreNamSinh, string.Empty);
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
        private void dropDownLoaiHinhDaoTao1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
            {
                if (dropDownLoaiHinhDaoTao1.Text == "Theo Lớp")
                {
                    panel4.Visible = true;
                    panel5.Visible = false;
                }
                else
                {
                    panel4.Visible = false;
                    panel5.Visible = true;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
    }
}
