using DanhMuc.LIB;
using ModuleDaoTao.LIB;
using NETLINK.LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace TDCA
{
    public partial class LoadingForm : Telerik.WinControls.UI.RadForm
    {
        private BackgroundWorker bw;
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            try
            {
        
                radProgressBar1.Maximum = 38;
                radProgressBar1.Value1 = 0;
                bw = new BackgroundWorker();
                bw.DoWork += bw_DoWork;
                bw.RunWorkerCompleted += bw_RunWorkerCompleted;
                bw.RunWorkerAsync();

                
                
            }
            catch (Exception ex)
            {
               GlobalCommon.ShowErrorMessager(ex);
                this.Close();
            }
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //this.Hide();
            //MainForm.Show();
            this.Close();
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            LoadingDate();
        }
        private string GetText(string text)
        {
            return "Đang tải danh mục " + text;
        }
        private void LoadingDate()
        {
            radProgressBar1.Text = GetText("Bệnh viện");
            DIC_BenhVien_Coll benhVien = DIC_BenhVien_Coll.GetDIC_BenhVien_Coll();
            radProgressBar1.Value1++;
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_BenhVien + "1", benhVien);
            radProgressBar1.Value1++;
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_BenhVien + "2", benhVien.Clone());
            radProgressBar1.Value1++;
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_BenhVien + "3", benhVien.Clone());
            radProgressBar1.Value1++;

            radProgressBar1.Text = GetText("Phòng Ban");
            DIC_BoPhan_Coll boPhan = DIC_BoPhan_Coll.GetDIC_BoPhan_Coll();
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_BoPhan + "1", boPhan);
            radProgressBar1.Value1++;

            radProgressBar1.Text = GetText("Chức vụ");
            DIC_ChucVu_Coll chucvu = DIC_ChucVu_Coll.GetDIC_ChucVu_Coll();
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_ChucVu + "1", chucvu);
            radProgressBar1.Value1++;
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_ChucVu + "2", chucvu.Clone());
            radProgressBar1.Value1++;
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_ChucVu + "3", chucvu.Clone());
            radProgressBar1.Value1++;

            radProgressBar1.Text = GetText("Chuyên Khoa");
            DIC_ChuyenKhoa_Coll chuyenKhoa = DIC_ChuyenKhoa_Coll.GetDIC_ChuyenKhoa_Coll();
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_ChuyenKhoa + "1", chuyenKhoa);
            radProgressBar1.Value1++;
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_ChuyenKhoa + "2", chuyenKhoa.Clone());
            radProgressBar1.Value1++;
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_ChuyenKhoa + "3", chuyenKhoa.Clone());
            radProgressBar1.Value1++;


            radProgressBar1.Text = GetText("Chuyên ngành");
            DIC_ChuyenNganh_Coll chuyenNganh = DIC_ChuyenNganh_Coll.GetDIC_ChuyenNganh_Coll();
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_ChuyenNganh + "1", chuyenNganh); radProgressBar1.Value1++;
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_ChuyenNganh + "2", chuyenNganh.Clone()); radProgressBar1.Value1++;
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_ChuyenNganh + "3", chuyenNganh.Clone()); radProgressBar1.Value1++;

            radProgressBar1.Text = GetText("Cơ quan");
            DIC_CoQuan_Coll coquan = DIC_CoQuan_Coll.GetDIC_CoQuan_Coll();
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_CoQuan + "1", coquan); radProgressBar1.Value1++;

            radProgressBar1.Text = GetText("Dân tộc");
            DIC_DanToc_Coll dantoc = DIC_DanToc_Coll.GetDIC_DanToc_Coll();
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_DanToc, dantoc); radProgressBar1.Value1++;

            radProgressBar1.Text = GetText("Trình độ");
            DIC_HocVi_Coll hocVi = DIC_HocVi_Coll.GetDIC_HocVi_Coll();
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_TrinhDo + "1", hocVi); radProgressBar1.Value1++;
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_TrinhDo + "2", hocVi.Clone()); radProgressBar1.Value1++;
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_TrinhDo + "3", hocVi.Clone()); radProgressBar1.Value1++;

            radProgressBar1.Text = GetText("Loại");
            DIC_Loai_Coll loai = DIC_Loai_Coll.GetDIC_Loai_Coll();
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_Loai +"1", loai); radProgressBar1.Value1++;
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_Loai + "2", loai.Clone()); radProgressBar1.Value1++;

            radProgressBar1.Text = GetText("Nguồn kinh phí");
            DIC_NguonKinhPhi_Coll nguonKinhPhi = DIC_NguonKinhPhi_Coll.GetDIC_NguonKinhPhi_Coll();
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_NguonKinhPhi + "1", nguonKinhPhi); radProgressBar1.Value1++;

            radProgressBar1.Text = GetText("Tỉnh thành");
            DIC_Tinh_Coll tinh = DIC_Tinh_Coll.GetDIC_Tinh_Coll();
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_Tinh + "1", tinh); radProgressBar1.Value1++;
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_Tinh + "2", tinh.Clone()); radProgressBar1.Value1++;
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_Tinh + "3", tinh.Clone()); radProgressBar1.Value1++;

            radProgressBar1.Text = GetText("Bộ Phận");
            DIC_BoPhan_Coll bophan = DIC_BoPhan_Coll.GetDIC_BoPhan_Coll();
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_BoPhan + "1", bophan); radProgressBar1.Value1++;

            radProgressBar1.Text = GetText("Cán bộ TDC");
            DIC_CanBo_Coll canBoTDC = DIC_CanBo_Coll.GetDIC_CanBo_Coll();
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_CanBo + (Convert.ToInt32(LoaiCanBo.CanBoThuocTrungTamCDT)).ToString() +"1", canBoTDC); radProgressBar1.Value1++;
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_CanBo + (Convert.ToInt32(LoaiCanBo.CanBoThuocTrungTamCDT)).ToString()+"2", canBoTDC.Clone()); radProgressBar1.Value1++;
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_CanBo + (Convert.ToInt32(LoaiCanBo.CanBoThuocTrungTamCDT)).ToString() + "3", canBoTDC.Clone()); radProgressBar1.Value1++;
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_CanBo + (Convert.ToInt32(LoaiCanBo.CanBoThuocTrungTamCDT)).ToString() + "4", canBoTDC.Clone()); radProgressBar1.Value1++;

            radProgressBar1.Text = GetText("Giảng viên");
            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForDropDownWithCondition);
            function.Item = LoaiCanBo.GiaoVien;
            DIC_CanBo_Coll canBoGV = DIC_CanBo_Coll.GetDIC_CanBo_Coll(function);
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_CanBo + (Convert.ToInt32(LoaiCanBo.GiaoVien)).ToString() + "1", canBoGV); radProgressBar1.Value1++;
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_CanBo + (Convert.ToInt32(LoaiCanBo.GiaoVien)).ToString() + "2", canBoGV.Clone()); radProgressBar1.Value1++;
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_CanBo + (Convert.ToInt32(LoaiCanBo.GiaoVien)).ToString() + "3", canBoGV.Clone()); radProgressBar1.Value1++;
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_CanBo + (Convert.ToInt32(LoaiCanBo.GiaoVien)).ToString() + "4", canBoGV.Clone()); radProgressBar1.Value1++;
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_CanBo + (Convert.ToInt32(LoaiCanBo.GiaoVien)).ToString() + "5", canBoGV.Clone()); radProgressBar1.Value1++;
            GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_CanBo + (Convert.ToInt32(LoaiCanBo.GiaoVien)).ToString() + "6", canBoGV.Clone()); radProgressBar1.Value1++;

            radProgressBar1.Text = GetText("Khung Lớp học");
            DT_LienTuc_KhungLopHoc_Coll KhungLopHoc = DT_LienTuc_KhungLopHoc_Coll.GetDT_LienTuc_KhungLopHoc_Coll();
            GlobalCommon.CacheWriter(TextMessages.CacheID.DT_KhungLopHoc + "1", KhungLopHoc); radProgressBar1.Value1++;

            radProgressBar1.Text = GetText("Môn học chính quy");
            DT_ChinhQuy_MonHoc_Coll monhoc = DT_ChinhQuy_MonHoc_Coll.GetDT_ChinhQuy_MonHoc_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));
            GlobalCommon.CacheWriter(TextMessages.CacheID.DT_MonHocCQ + "1", monhoc); radProgressBar1.Value1++;

            radProgressBar1.Text = "Đã hoàn thành";
            
           
        }
    }
}
