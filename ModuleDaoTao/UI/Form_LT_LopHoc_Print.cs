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
using System.Collections;
using ExportLib.Entities.DaoTao;
using ExportLib;

namespace ModuleDaoTao.UI
{
    public partial class Form_LT_LopHoc_Print : Telerik.WinControls.UI.RadForm
    {
        private DT_LienTuc_LopHoc_Info objLophoc;
        private DT_LienTuc_HocVien_Coll hocviendaxeplop;
        private FormMode formMode;
        public Form_LT_LopHoc_Print(FormMode _formMode)
        {
            InitializeComponent();
            formMode = _formMode;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                ExportHanhChinh ex = new ExportHanhChinh();
                ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
                cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
                cv.E_TieuDe = new List<string>() { "Họ tên", "Ngày sinh", "Trình độ", "Nơi công tác", "Điện thoại", "Ghi Chú", TextMessages.Itemvalue.RemoveSimblo };
                cv.E_Width = new List<string>() { "160", "70", "100", "230", "90", "", "" };
                string PhongBan = string.Empty;
                string TenLop = string.Empty;
                string MaLop = string.Empty;
                foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridView1.ChildRows)
                {
                    if (rowInfo.IsVisible)
                    {
                        DT_LienTuc_HocVien_Info itemInfo = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                        ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                        cvItem.E_Value = new List<string>() { itemInfo.HoTen, itemInfo.NgaySinh, itemInfo.TenTrinhDo, itemInfo.TenBenhVien, itemInfo.DiDong, itemInfo.GhiChu, TextMessages.Itemvalue.RemoveSimblo + itemInfo.NgayDangKi };
                        cv.E_Content.Add(cvItem);
                        PhongBan = itemInfo.TenPhongQuanLy;
                        TenLop = itemInfo.NoiDungDaoTao;
                        MaLop = itemInfo.MaLopHoc;
                    }
                }
                cv.E_TieuDeBaoCao = "Danh sách học viên";
                //cv.E_NguoiKi = PTIdentity.FullName;
                cv.E_ThongTinKhac = string.Format("KHÓA ĐÀO TẠO: {0}", TenLop);
                cv.E_CongHoaXaHoi = "bM.09.07";
                cv.E_TieuDeLop = TenLop;
                cv.E_MaLop = "( " + MaLop + " )";
                cv.E_DocLapTuDo = string.Empty;
                cv.E_TenTrungTam = cv.E_TenBenhVien == "BỆNH VIỆN BẠCH MAI" ? "TRUNG TÂM ĐÀO TẠO VÀ CHỈ ĐẠO TUYẾN" : PhongBan;
                cv.E_isCenter = false;
                // cv.IsNamDoc = false;
                DateTime tungay = Convert.ToDateTime(objLophoc.NgayBatDau);
                DateTime denngay = Convert.ToDateTime(objLophoc.NgayKetThuc);

                cv.ProcessTuNgayDenNgay(tungay.ToString("dd/MM/yyyy"), denngay.ToString("dd/MM/yyyy")); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
                ex.B100_GenReport(cv);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void Form_LT_LopHoc_Print_Load(object sender, EventArgs e)
        {
            try
            {
                if (formMode.Item != null)
                {
                    objLophoc = (DT_LienTuc_LopHoc_Info)formMode.Item;
                    txtKhoa.Text = objLophoc.KhoaHoc;
                    txtTenLop.Text = objLophoc.TenLop;
                    BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetHocVienLienTucByMaLop);
                    function.ItemID = (int)PTIdentity.IDNguoiDung;
                    function.Item = objLophoc.MaLop;
                    hocviendaxeplop = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
                    radGridView1.DataSource = hocviendaxeplop;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            try
            {
                ExportHanhChinh ex = new ExportHanhChinh();
                ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
                cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
                cv.E_TieuDe = new List<string>() { "Họ tên", "Ngày sinh", "Trình độ", "Nơi công tác","Xếp loại" , TextMessages.Itemvalue.RemoveSimblo };
                cv.E_Width = new List<string>() { "160", "70", "100", "230", "", "" };
                string PhongBan = string.Empty;
                string TenLop = string.Empty;
                string MaLop = string.Empty;
                foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridView1.ChildRows)
                {
                    if (rowInfo.IsVisible)
                    {
                        DT_LienTuc_HocVien_Info itemInfo = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                        ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                        cvItem.E_Value = new List<string>() { itemInfo.HoTen, itemInfo.NgaySinh, itemInfo.TenTrinhDo, itemInfo.TenBenhVien, itemInfo.XepLoai, TextMessages.Itemvalue.RemoveSimblo + itemInfo.NgayDangKi };
                        cv.E_Content.Add(cvItem);
                        PhongBan = itemInfo.TenPhongQuanLy;
                        TenLop = itemInfo.NoiDungDaoTao;
                        MaLop = itemInfo.MaLopHoc;
                    }
                    //7625 -- Vũ Văn Thành
                }
                cv.E_TieuDeBaoCao = "Danh sách học viên";
                //cv.E_NguoiKi = PTIdentity.FullName;
                cv.E_ThongTinKhac = string.Format("KHÓA ĐÀO TẠO: {0}", TenLop);
                cv.E_CongHoaXaHoi = string.Empty;
                cv.E_TieuDeLop = TenLop;
                cv.E_MaLop = MaLop;
                cv.E_DocLapTuDo = string.Empty;
                cv.E_TenTrungTam = cv.E_TenBenhVien == "BỆNH VIỆN BẠCH MAI" ? "TRUNG TÂM ĐÀO TẠO VÀ CHỈ ĐẠO TUYẾN" : PhongBan;
                cv.E_isCenter = false;
                // cv.IsNamDoc = false;
                DateTime tungay = Convert.ToDateTime(objLophoc.NgayBatDau);
                DateTime denngay = Convert.ToDateTime(objLophoc.NgayKetThuc);
                cv.ProcessTuNgayDenNgay(tungay.ToString("dd/MM/yyyy"), denngay.ToString("dd/MM/yyyy")); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
                ex.B100_GenReport(cv);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            try
            {
                ExportHanhChinh ex = new ExportHanhChinh();
                ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
                cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
                cv.E_TieuDe = new List<string>() { "Họ tên", "Ngày sinh", "Trình độ", "Nơi công tác","LT1","LT2","TH1","TH2","TH3","TH4", "Xếp loại", TextMessages.Itemvalue.RemoveSimblo };
                cv.E_Width = new List<string>() { "160", "70", "140", "360","25","25","25","25","25","25", "", "" };
                string PhongBan = string.Empty;
                string TenLop = string.Empty;
                string MaLop = string.Empty;
                string LT1, LT2, TH1, TH2, TH3, TH4;
                foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridView1.ChildRows)
                {
                    if (rowInfo.IsVisible)
                    {
                        DT_LienTuc_HocVien_Info itemInfo = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                        ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                        if (itemInfo.DiemThi == null || itemInfo.DiemThi == 0)
                            LT1 = string.Empty;
                        else
                            LT1 = itemInfo.DiemThi.ToString();

                        if (itemInfo.Lan1 == null || itemInfo.Lan1 == 0)
                            LT2 = string.Empty;
                        else
                            LT2 = itemInfo.Lan1.ToString();

                        if (itemInfo.Lan2 == null || itemInfo.Lan2 == 0)
                            TH1 = string.Empty;
                        else
                            TH1 = itemInfo.Lan2.ToString();

                        if (itemInfo.Lan3 == null || itemInfo.Lan3 == 0)
                            TH2 = string.Empty;
                        else
                            TH2 = itemInfo.Lan3.ToString();

                        if (itemInfo.Lan4 == null || itemInfo.Lan4 == 0)
                            TH3 = string.Empty;
                        else
                            TH3 = itemInfo.Lan4.ToString();

                        if (itemInfo.Lan5 == null || itemInfo.Lan5 == 0)
                            TH4 = string.Empty;
                        else
                            TH4 = itemInfo.Lan5.ToString();
                        cvItem.E_Value = new List<string>() { itemInfo.HoTen, itemInfo.NgaySinh, itemInfo.TenTrinhDo, itemInfo.TenBenhVien,LT1,LT2,TH1,TH2,TH3,TH4, itemInfo.XepLoai, TextMessages.Itemvalue.RemoveSimblo + itemInfo.NgayDangKi };
                        cv.E_Content.Add(cvItem);
                        PhongBan = itemInfo.TenPhongQuanLy;
                        TenLop = itemInfo.NoiDungDaoTao;
                        MaLop = itemInfo.MaLopHoc;
                    }
                }
                cv.E_TieuDeBaoCao = "Kết quả kiểm tra khóa học";
                //cv.E_NguoiKi = PTIdentity.FullName;
                cv.E_ThongTinKhac = string.Format("KHÓA ĐÀO TẠO: {0} ({1})", objLophoc.TenLop,objLophoc.MaLop);
                cv.E_CongHoaXaHoi = string.Empty;
                cv.E_DocLapTuDo = string.Empty;
                cv.E_TieuDeLop = TenLop;
                cv.E_MaLop = MaLop;
                cv.E_TenTrungTam = cv.E_TenBenhVien == "BỆNH VIỆN BẠCH MAI" ? "TRUNG TÂM ĐÀO TẠO VÀ CHỈ ĐẠO TUYẾN" : PhongBan;
                cv.E_isCenter = false;
                cv.IsNamDoc = false;
                DateTime tungay = Convert.ToDateTime(objLophoc.NgayBatDau);
                DateTime denngay = Convert.ToDateTime(objLophoc.NgayKetThuc);
                cv.ProcessTuNgayDenNgay(tungay.ToString("dd/MM/yyyy"), denngay.ToString("dd/MM/yyyy")); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
                ex.B100_GenReport(cv);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            try
            {
                ExportHanhChinh ex = new ExportHanhChinh();
                ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
                cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
                cv.E_TieuDe = new List<string>() { "Thời gian", "Nội dung giảng", "Số tiết", "Giảng viên ký" };
                cv.E_Width = new List<string>() { "70", "350", "70", "" };
               
                for (int i = 0; i < 18; i++)
                {
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { TextMessages.Itemvalue.HTMLSpace, TextMessages.Itemvalue.HTMLSpace, TextMessages.Itemvalue.HTMLSpace, TextMessages.Itemvalue.HTMLSpace };
                    cv.E_Content.Add(cvItem);

                }

                //foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridView1.ChildRows)
                //{
                //    if (rowInfo.IsVisible)
                //    {
                //        DT_LienTuc_HocVien_Info itemInfo = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                //        ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                //        cvItem.E_Value = new List<string>() { itemInfo.HoTen, itemInfo.NgaySinh, itemInfo.TenTrinhDo, itemInfo.TenBenhVien, itemInfo.XepLoai, TextMessages.Itemvalue.RemoveSimblo + itemInfo.NgayDangKi };
                //        cv.E_Content.Add(cvItem);
                //        PhongBan = itemInfo.TenPhongQuanLy;
                //        TenLop = itemInfo.NoiDungDaoTao;
                //    }
                //}
                cv.E_TieuDeBaoCao = "bảng theo dõi lịch giảng thực hành";
                cv.AutoGenSTT = false;
                cv.E_ThongTinTongHop = "NHÓM TRƯỞNG";
                cv.E_HaNoiNgayThangNam = "TRUNG TÂM ĐÀO TẠO VÀ CHỈ ĐẠO TUYẾN";

                cv.E_NguoiKi = string.Empty;
                cv.E_ThongTinKhac = string.Format("Khóa đào tạo: {0}", objLophoc.TenLop);
                cv.E_TieuDeLop = objLophoc.TenLop;
                cv.E_MaLop = objLophoc.MaLop;
                cv.E_CongHoaXaHoi = string.Empty;
                cv.E_DocLapTuDo = string.Empty;
                cv.E_TenTrungTam = "Trung tâm Đào tạo và Chỉ đạo tuyến";
                cv.E_isCenter = false;
                cv.E_IsUseTongSo = false;
                DateTime tungay = Convert.ToDateTime(objLophoc.NgayBatDau);
                DateTime denngay = Convert.ToDateTime(objLophoc.NgayKetThuc);
                cv.E_TuNgayDenNgay = string.Format("Thời gian từ {0} đến {1}", tungay.ToString("dd/MM/yyyy"), denngay.ToString("dd/MM/yyyy"));
                // cv.IsNamDoc = false;
                //cv.ProcessTuNgayDenNgay(5); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
                ex.B100_GenReport(cv);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            try
            {
                ExportHanhChinh ex = new ExportHanhChinh();
                ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
                cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
                cv.E_TieuDe = new List<string>() {"Thời gian","Nội dung giảng", "Số tiết","Giảng viên ký"};
                cv.E_Width = new List<string>() { "70","350","70","" };
                for (int i = 0; i < 18; i++)
                {
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { TextMessages.Itemvalue.HTMLSpace, TextMessages.Itemvalue.HTMLSpace, TextMessages.Itemvalue.HTMLSpace, TextMessages.Itemvalue.HTMLSpace };
                    cv.E_Content.Add(cvItem);
                }
                
                //foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridView1.ChildRows)
                //{
                //    if (rowInfo.IsVisible)
                //    {
                //        DT_LienTuc_HocVien_Info itemInfo = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                //        ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                //        cvItem.E_Value = new List<string>() { itemInfo.HoTen, itemInfo.NgaySinh, itemInfo.TenTrinhDo, itemInfo.TenBenhVien, itemInfo.XepLoai, TextMessages.Itemvalue.RemoveSimblo + itemInfo.NgayDangKi };
                //        cv.E_Content.Add(cvItem);
                //        PhongBan = itemInfo.TenPhongQuanLy;
                //        TenLop = itemInfo.NoiDungDaoTao;
                //    }
                //}
                cv.E_TieuDeBaoCao = "bảng theo dõi lịch giảng lý thuyết";
                cv.AutoGenSTT = false;
                cv.E_ThongTinTongHop = "NHÓM TRƯỞNG";
                cv.E_HaNoiNgayThangNam = "TRUNG TÂM ĐÀO TẠO VÀ CHỈ ĐẠO TUYẾN";

                cv.E_NguoiKi = string.Empty;
                cv.E_ThongTinKhac = string.Format("Khóa đào tạo: {0}", objLophoc.TenLop);
                cv.E_CongHoaXaHoi = string.Empty;
                cv.E_DocLapTuDo = string.Empty;
                cv.E_TenTrungTam = "Trung tâm Đào tạo và Chỉ đạo tuyến";
                cv.E_isCenter = false;
                cv.E_IsUseTongSo = false;
                DateTime tungay = Convert.ToDateTime(objLophoc.NgayBatDau);
                DateTime denngay = Convert.ToDateTime(objLophoc.NgayKetThuc);
                cv.E_TuNgayDenNgay = string.Format("Thời gian từ {0} đến {1}", tungay.ToString("dd/MM/yyyy"), denngay.ToString("dd/MM/yyyy"));
                // cv.IsNamDoc = false;
                //cv.ProcessTuNgayDenNgay(5); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
                ex.B100_GenReport(cv);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButton6_Click(object sender, EventArgs e)
        {
            try
            {
                ExportHanhChinh ex = new ExportHanhChinh();
                ex.B020_SoTheoDoiHocTap("Lớp " + objLophoc.TenLop);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButton7_Click(object sender, EventArgs e)
        {
            try
            {
                ExportLib.Entities.DaoTao.DanhSachBangTheoDoiChiTieuThucHanh ds = new ExportLib.Entities.DaoTao.DanhSachBangTheoDoiChiTieuThucHanh();
                ds.list = new List<ExportLib.Entities.DaoTao.BangTheoDoiChiTieuThucHanh>();
                if (hocviendaxeplop != null)
                {
                    foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridView1.ChildRows)
                    {
                        if (rowInfo.IsVisible)
                        {
                            DT_LienTuc_HocVien_Info hv = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                            if (!string.IsNullOrEmpty(hv.MaHocVien) && !string.IsNullOrEmpty(hv.MaLopHoc))
                            {
                                ExportLib.Entities.DaoTao.BangTheoDoiChiTieuThucHanh b1 = new ExportLib.Entities.DaoTao.BangTheoDoiChiTieuThucHanh();
                                b1.HoTenHocVien = hv.HoTen;
                                b1.ThoiGianBatDau = hv.NgayBatDau;
                                b1.ThoiGianKetThuc = hv.NgayKetThuc;
                                b1.DonViCongTac = hv.TenBenhVien;
                                b1.TenKhoaDaoTao = hv.TenChuyenNganh;
                                b1.TenLop = hv.TenLopHoc + "(<i>"+hv.MaLopHoc+"</i>)";
                                ds.list.Add(b1);
                            }
                        }
                    }
                }

                ExportLib.ExportDaoTao dt = new ExportDaoTao();
                dt.ExportBangTheoDoiChiTieuThucHanh(ds, 20);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButton8_Click(object sender, EventArgs e)
        {
            
        }

        private void radButton9_Click(object sender, EventArgs e)
        {
            try
            {
                B001_BangDiemDanhTheoLop bangdiemdanh = new B001_BangDiemDanhTheoLop();

                DateTime tungay = Convert.ToDateTime(objLophoc.NgayBatDau);
                DateTime denngay = Convert.ToDateTime(objLophoc.NgayKetThuc);
                bangdiemdanh.NgayBatDau = tungay.ToString("dd/MM/yyyy");
                bangdiemdanh.NgayKetThuc = denngay.ToString("dd/MM/yyyy");
                //bangdiemdanh.ThoiGianNhap = DateTime.Now.ToString("dd/MM/yyyy");
                bangdiemdanh.ThoiGianNhap = "ngày " + DateTime.Now.ToString("dd") + " tháng " + DateTime.Now.ToString("MM") + " năm " + DateTime.Now.ToString("yyyy");
                bangdiemdanh.ListHocVien = new List<DanhSachLop>();
                bangdiemdanh.TenLop = objLophoc.TenLop + " (<i>" + objLophoc.MaLop + "</i>)";
                bangdiemdanh.KhoaDaoTao = objLophoc.TenChuyenKhoaLopHoc;

               
                int count = 1;
                foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridView1.ChildRows)
                {
                    if (rowInfo.IsVisible)
                    {
                        DT_LienTuc_HocVien_Info hv = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                        if (!string.IsNullOrEmpty(hv.MaHocVien) && !string.IsNullOrEmpty(hv.MaLopHoc))
                        {
                            bangdiemdanh.ListHocVien.Add(new DanhSachLop(count.ToString(), hv.HoTen));
                        }
                        count++;
                    }

                }

                ExportDaoTao daotao = new ExportDaoTao();
                daotao.B001_BangDiemDanhTheoLop(bangdiemdanh);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
    }
}
