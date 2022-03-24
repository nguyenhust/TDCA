using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using NETLINK.LIB;
using ExportLib;
using ExportLib.Entities.HanhChinh;
using Telerik.WinControls.Data;
using NETLINK.UI;
using ExportLib.Entities;
using ModuleDaoTao.LIB;
using Authoration.LIB;
using ExportLib.Entities.DaoTao;

namespace TDCA
{
    public partial class testForm : Telerik.WinControls.UI.RadForm
    {
        public testForm()
        {
            InitializeComponent();
            //VNRadGridLP.CurrentProvider = new VNRadGridLP();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {

        }

        private void dropDownBoPhan1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dropDownCanBo1.FilterData(FilterColumn.IDKhoaNgoai32, dropDownBoPhan1.Selected_ID);
        }

        private void testForm_Load(object sender, EventArgs e)
        {
            //dropDownBoPhan1.FillData();
            //dropDownCanBo1.FillData(LoaiCanBo.CanBoThuocTrungTamCDT);
            //CreateData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>();
            for (int i = 0; i < 7; i++)
            {
                cv.E_TieuDe.Add("Ố la la" + i.ToString());
                
                
            }
            for (int i = 0; i < 30; i++)
            {
                B100_Table tb = new B100_Table();
                tb.E_Value = new List<string>();
                for (int j = 0; j < 7; j++)
                {
                    
                    if (j == 2)
                    {
                        if (i == 20)
                        {
                            tb.E_Value.Add("01/01/2014");
                        }
                        else if (i == 5)
                        {
                            tb.E_Value.Add("25/01/2014");
                        }
                        else
                        {
                            tb.E_Value.Add("02/01/2014");
                        }

                    }
                    else
                    {
                        tb.E_Value.Add("Test ho ho");
                    }
                }
                cv.E_Content.Add(tb);
            }
           
            cv.E_NguoiKi = "Bùi Hồng";
            cv.E_TieuDeBaoCao = "BÁO CÁO TEST";
            cv.ProcessTuNgayDenNgay(2);
            ex.B100_GenReport(cv);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Phòng", "Nội dung", "Người thực hiện", "Thời gian" };
            //cv.E_FilterExpression = this.FilterExpression;
            //foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            //{
            //    if (rowInfo.IsVisible)
            //    {
            //        HC_LichLamViecTT_Info itemInfo = (HC_LichLamViecTT_Info)rowInfo.DataBoundItem;
            //        ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
            //        cvItem.E_Value = new List<string>() {  };
            //        cv.E_Content.Add(cvItem);
            //    }
            //}
            for (int i = 0; i < 100; i++)
            {
                ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                if (i < 9)
                {
                    cvItem.E_Value = new List<string>() { "test", "alo" + i.ToString(), "alo", "alo" };
                }
                else if (i < 20)
                {
                    cvItem.E_Value = new List<string>() { "testxx", "alo" + i.ToString(), "alo", "alo" };
                }
                else
                {
                    cvItem.E_Value = new List<string>() { "co ve ngon", "alo" + i.ToString(), "alo", "alo" };
                }
                cv.E_Content.Add(cvItem);
            }
            cv.E_TieuDeBaoCao = "báo cáo xin xe";
            //cv.E_NguoiKi = PTIdentity.FullName;
            cv.ProcessTuNgayDenNgay(2); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv, 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExportDaoTao dt = new ExportDaoTao();
            //dt.ExportTheHocVien();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExportDaoTao dt = new ExportDaoTao();
            //dt.ExportTheHocVienLienTuc();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ExportDaoTao dt = new ExportDaoTao();
           // dt.ExportGiayChungNhan();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ExportDaoTao dt = new ExportDaoTao();
           // dt.ExportGiayChungChi();
        }
        
        private void CreateData()
        {
            List<test> lb = new List<test>();
            DateTime date = DateTime.Now;
            for(int i=0;i<100;i++)
            {
                lb.Add(new test(i.ToString(), date.AddDays(i).ToShortDateString(),date.AddDays(i)));
            }
            bindingSource1.DataSource = lb;
            //radGridView1.CustomFiltering += radGridView1_CustomFiltering;
            //FilterDescriptor descriptor = new FilterDescriptor("STT", FilterOperator.StartsWith, 0);
            //descriptor.IsFilterEditor = true;
            //radGridView1.FilterDescriptors.Add(descriptor);
        }

        void radGridView1_CustomFiltering(object sender, Telerik.WinControls.UI.GridViewCustomFilteringEventArgs e)
        {
            e.Visible = Convert.ToInt32(e.Row.Cells["STT"].Value) > 20; 
        }



        private void CreateNewFilterForGridView()
        {
            
        }

        private void radGridView1_FilterExpressionChanged(object sender, Telerik.WinControls.UI.FilterExpressionChangedEventArgs e)
        {
           // richTextBox1.Text = e.FilterExpression;
          // MessageBox.Show(e.FilterExpression);
            //e.FilterExpression = "((Date LIKE '0%'))";
            
        }

        private void radGridView1_FilterChanged(object sender, Telerik.WinControls.UI.GridViewCollectionChangedEventArgs e)
        {
            //MessageBox.Show(e.NewItems.Count.ToString());
            //FilterDescriptor desc = e.NewItems[0] as FilterDescriptor;
            //MessageBox.Show(desc.Value.ToString());
        }

        private void radGridView1_FilterChanging(object sender, Telerik.WinControls.UI.GridViewCollectionChangingEventArgs e)
        {
           // e. = "Date Like'0%'";
        }

        List<string> listDateColumn = new List<string>() { "Date" };
        private string ProcessFilterExpression(string oldExpression)
        {

            return string.Empty;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<ExportLib.Entities.DaoTao.BangTheoDoiChiTieuThucHanh> b_list = new List<ExportLib.Entities.DaoTao.BangTheoDoiChiTieuThucHanh>();
            ExportLib.Entities.DaoTao.BangTheoDoiChiTieuThucHanh b1 = new ExportLib.Entities.DaoTao.BangTheoDoiChiTieuThucHanh();
            b1.TenKhoaDaoTao = "khoa dao tao 1";
            b1.ThoiGianBatDau = "1/1/2014";
            b1.ThoiGianKetThuc = "12/12/2014";
            b1.HoTenHocVien = "Nguyen Van A";
            b1.DonViCongTac = "Benh Vien Xanh Pon";

            ExportLib.Entities.DaoTao.BangTheoDoiChiTieuThucHanh b2 = new ExportLib.Entities.DaoTao.BangTheoDoiChiTieuThucHanh();
            b2.TenKhoaDaoTao = "khoa dao tao 2";
            b2.ThoiGianBatDau = "1/1/2014";
            b2.ThoiGianKetThuc = "12/12/2014";
            b2.HoTenHocVien = "Nguyen Van B";
            b2.DonViCongTac = "Benh Vien Da Khoa Ha Dong";

            b_list.Insert(0, b1);
            b_list.Insert(1, b2);

            ExportLib.Entities.DaoTao.DanhSachBangTheoDoiChiTieuThucHanh ds = new ExportLib.Entities.DaoTao.DanhSachBangTheoDoiChiTieuThucHanh();
            ds.list = b_list;

            ExportLib.ExportDaoTao dt = new ExportDaoTao();
            dt.ExportBangTheoDoiChiTieuThucHanh(ds, 20);

        }

        private void radButton1_Click_1(object sender, EventArgs e)
        {
            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForGridView);
            function.ItemID = (int)PTIdentity.IDNguoiDung;
            DT_LienTuc_HocVien_Coll hocvien = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Họ tên", "Ngày sinh", "Trình độ", "Nơi công tác","Điện thoại","Ghi Chú",TextMessages.Itemvalue.RemoveSimblo};
            cv.E_Width = new List<string>() { "160", "70", "100", "230", "90", "","" };
            string PhongBan = string.Empty;
            string TenLop = string.Empty;
            foreach (DT_LienTuc_HocVien_Info itemInfo in hocvien)
            {

                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { itemInfo.HoTen, itemInfo.NgaySinh, itemInfo.TenTrinhDo, itemInfo.TenBenhVien, itemInfo.DiDong, itemInfo.GhiChu, TextMessages.Itemvalue.RemoveSimblo+ itemInfo.NgayDangKi };
                    cv.E_Content.Add(cvItem);
                    PhongBan = itemInfo.TenPhongQuanLy;
                    TenLop = itemInfo.NoiDungDaoTao;
            }
            cv.E_TieuDeBaoCao = "Danh sách học viên";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_ThongTinKhac = string.Format("KHÓA ĐÀO TẠO: {0}", TenLop);
            cv.E_CongHoaXaHoi = "bM.09.07";
            cv.E_DocLapTuDo = string.Empty;
            cv.E_TenTrungTam = PhongBan;
            cv.E_isCenter = false;
           // cv.IsNamDoc = false;
            cv.ProcessTuNgayDenNgay(6); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                DT_LienTuc_HocVien_Coll hv = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));
                progressBar1.Maximum = hv.Count;
                progressBar1.Value = 0;
                foreach (DT_LienTuc_HocVien_Info hvinfor in hv)
                {
                    if (hvinfor.HinhThucHoc.ToLower() == "theo lớp" && hvinfor.MaHocVien.IndexOf("BM--14") >=0)
                    {
                        DT_LienTuc_HocVien hvx = DT_LienTuc_HocVien.GetDT_LienTuc_HocVien(hvinfor.Id);
                        hvx.MaHocVien = hvx.MaHocVien.Replace("BM--14", "BM-TDC-14");
                        hvx.MaLopHoc = hvx.MaLopHoc.Replace("BM--14", "BM-TDC-14");
                        hvx.ApplyEdit();
                        hvx.Save();
                    }
                    progressBar1.Value = progressBar1.Value + 1;
                    
                }
                //hv.Save();
                GlobalCommon.ShowMessageInformation("xong");
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }


        }

        private void button10_Click(object sender, EventArgs e)
        {
            DT_GiayChungChi chungchi = new DT_GiayChungChi();
            chungchi.ListChungChi = new List<ChungChi>();
            string today = string.Format("{0}, Ngày {1} tháng {2} năm {3}", "Hà Nội", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            //DT_LienTuc_KhungLopHoc_Coll lstKhungLopHoc = dropDownLopHocLienTucKhung.GetListData();
        
                    
                    ChungChi objNeedPrint = new ChungChi();
                    objNeedPrint.ThongTin = today;
                    objNeedPrint.HocVien = "Nguyen van Nam";
                    objNeedPrint.KhoaHocHoanThanh = string.Format("lớp {0}", "Sieu Am Tim Mach");
                    objNeedPrint.NgayBatDau = "01/01/2014";
                    objNeedPrint.NgayKetThuc = "01/01/2015";
                    objNeedPrint.NgaySinh ="05/05/2014";
                    objNeedPrint.SoTietHoc = "150 tiết";
                    objNeedPrint.TrinhDo = "bac Si";
                    objNeedPrint.DonViCongTac = "Benh Vien Da Khoa Lao Cai";
                    chungchi.ListChungChi.Add(objNeedPrint);
          
                
            
            ExportDaoTao daotao = new ExportDaoTao();
            daotao.ExportGiayChungChi(chungchi);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                ExportChiDaoTuyen ex = new ExportChiDaoTuyen();
                ExportLib.Entities.ChiDaoTuyen.B013_BaoCaoKetQuaDaoTaoHoiChan bx = new ExportLib.Entities.ChiDaoTuyen.B013_BaoCaoKetQuaDaoTaoHoiChan();
                bx.ChucVuChuTri = "Giam doc";
                bx.ChuTri = "Bui Hong Quang";
                bx.DeMuc1 = "Test xyz";
                bx.DeMuc2 = "Test abc";
                bx.DeMuc3 = "O la la";
                bx.KhoaChuTri = "Truyen Nhiem";
                bx.NgayLapBaoCao = "01012014";
                bx.NgayTienHanh = "02022014";
                bx.NguoiLamBaoCao = "Bui Hong Quang";
                bx.NoiDung = "Test xxxxxx";
                bx.PhongChiDaoTuyen = "Phong chi dao tuyen x";
                bx.ThuKy1 = "Nguyen van 1";
                bx.ThuKy2 = "Nguyen van 2";
                bx.ListSoLieuThongKe = new List<ExportLib.Entities.ChiDaoTuyen.SoLieuThongKe>();
                for (int i = 0; i < 20; i++)
                {
                    ExportLib.Entities.ChiDaoTuyen.SoLieuThongKe itemInfo = new ExportLib.Entities.ChiDaoTuyen.SoLieuThongKe();
                    itemInfo.BaoCaoBA = "5";
                    itemInfo.SoLuongThamGia = "10";
                    itemInfo.TenBVThamGia = "Benh vien bach mai " + i.ToString();
                    bx.ListSoLieuThongKe.Add(itemInfo);
                }
                ex.B013_BaoCaoKetQuaDaoTaoHoiChan(bx);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                textBox2.Text = ex.ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string[] tencot = new string[] {"t1","t2","t3","t4","t5" };
            string[,] data = new string[50, 5];
            for (int i = 0; i < 50; i++)
            {
                data[i,0] = "a";
                data[i,1] = "b";
                data[i, 2] = "c";
                data[i, 3] = "d";
                data[i, 4] = "e";
                   
               
            }
            ExcelHelper x = new ExcelHelper();
            x.WriteExcel(tencot, data);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ModuleDaoTao.UI.Form_LT_ThongKe fr = new ModuleDaoTao.UI.Form_LT_ThongKe();
            fr.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //FtpHelper ftp = new FtpHelper();
            //ftp.progressBar = progressBar1;
            //ftp.
        }
    }
    public class test
    {
        public test(string stt, string date,DateTime date2)
        {
            STT = stt;
            Date = date;
            Date2 = date2;
        }
        public string STT { get; set; }
        public string Date { get; set; }
        public DateTime Date2 { get; set; }
    }
}
