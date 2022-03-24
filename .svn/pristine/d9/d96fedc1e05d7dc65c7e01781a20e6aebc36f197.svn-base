using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NETLINK.LIB;
using NETLINK.UI;
using DanhMuc.UserControl;
using TruyenThong.UI;
using Authoration.UserControls;
using System.Data.SqlClient;
using Authoration.LIB;
using Csla.Data;
using TruyenThong.UserControl;
using ModuleChiDaoTuyen.UI;
using ModuleHanhChinh.UI;
using ModuleHanhChinh.UserControl;
//using ModuleChiDaoTuyen.UI;
//using ModuleChiDaoTuyen.LIB;

namespace TDCA
{
    public partial class Menu : Telerik.WinControls.UI.RadRibbonForm
    {
        System.Security.Principal.IPrincipal user = Csla.ApplicationContext.User;

        public Menu()
        {
            InitializeComponent();
            this.AdjustFormScrollbars(true);
        }

        private void LoadFormMenu(object sender, EventArgs e)
        {
            try
            {
                Click_DangNhap(sender, e);
                LoadControl();
            }
            catch (SqlException ex)
            {
                LoadControl();
                MessageBox.Show("Lỗi làm việc với SQL: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                LoadControl();
                MessageBox.Show("Lỗi khởi tạo: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void LoadControl()
        {
            #region Status hệ thống
            var ctx = ConnectionManager<SqlConnection>.GetManager("Connection");

            //Tên làm việc
            this.TenDangNhap.Text = (PTIdentity.VaiTro + ": " + PTIdentity.FullName);
            //gan ten Server
            // radStatusStrip1.Items["ServerName"].Text = ctx.Connection.DataSource.ToUpper();
            //gan ten CSDL lam viec
            //  radStatusStrip1.Items["StatusDatabase"].Text = ctx.Connection.Database.ToUpper();
            //gan gio lam viec
            radStatusStrip1.Items["StatusDate"].Text = GlobalCommon.GetTimeServer().ToString().ToUpper();
            //ShowLogo(new NullUITemplate());

            #endregion

            #region Anthoration

            #region Phân quyền
            // Người dùng
            mnuNguoiDung.Enabled = (Csla.ApplicationContext.User.IsInRole("NguoiDung:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            // Vài trò
            mnuVaiTro.Enabled = (Csla.ApplicationContext.User.IsInRole("VaiTro:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            // Phân hệ
            mnuPhaHe.Enabled = (Csla.ApplicationContext.User.IsInRole("PhanHe:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            // Nhóm chức năng
            mnuNhomChucNang.Enabled = (Csla.ApplicationContext.User.IsInRole("NhomChucNang:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            // Nhóm người dùng
            mnuNhomNguoiDung.Enabled = (Csla.ApplicationContext.User.IsInRole("NhomNguoiDung:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            #endregion

            #region Danh mục
            //Danh Muc --> BoPhan
            radmnuBoPhan.Enabled = (Csla.ApplicationContext.User.IsInRole("BoPhan:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            //Danh Muc --> Bệnh Viện
            radmnuBenhVien.Enabled = (Csla.ApplicationContext.User.IsInRole("BenhVien:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            //Danh Muc --> Chức Vụ
            radmnuChucVu.Enabled = (Csla.ApplicationContext.User.IsInRole("ChucVu:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            //Danh Mục --> Cơ Quan
            radmnuCoQuan.Enabled = (Csla.ApplicationContext.User.IsInRole("CoQuan:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            //Danh Mục --> Chuyên Khoa
            radmnuChuyenKhoa.Enabled = (Csla.ApplicationContext.User.IsInRole("ChuyenKhoa:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            //Danh Muc --> Chuyên Ngành
            radmnuChuyenNganh.Enabled = (Csla.ApplicationContext.User.IsInRole("ChuyenNganh:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            //Danh Mục --> Dân Tộc
            radmnuDanToc.Enabled = (Csla.ApplicationContext.User.IsInRole("DanToc:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            //Danh Mục --> Giới Tính
            radmnuGioiTinh.Enabled = (Csla.ApplicationContext.User.IsInRole("GioiTinh:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            //Danh Mục --> Quốc Gia
            radmnuQuocGia.Enabled = (Csla.ApplicationContext.User.IsInRole("QuocGia:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            //Danh Mục --> Đơn Vị Tính
            radmnuDonViTinh.Enabled = (Csla.ApplicationContext.User.IsInRole("DonViTinh:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            //Danh Mục --> Loại
            radmnuLoai.Enabled = (Csla.ApplicationContext.User.IsInRole("Loai:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            //Danh Mục --> Biến Hệ Thống
            radmnuParameter.Enabled = (Csla.ApplicationContext.User.IsInRole("BienHeThong:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            //Danh Mục --> Học Hàm
            radmnuHocHam.Enabled = (Csla.ApplicationContext.User.IsInRole("HocHam:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            //Danh Mục --> Học Vị
            radmnuHocVi.Enabled = (Csla.ApplicationContext.User.IsInRole("HocVi:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            //Danh Mục --> Nguồn Kinh Phí
            radmnuNguonKinhPhi.Enabled = (Csla.ApplicationContext.User.IsInRole("NguonKinhPhi:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            //Danh Mục --> Cán Bộ
            radmnuCanBo.Enabled = (Csla.ApplicationContext.User.IsInRole("CanBo:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            //Danh Mục --> Tỉnh Thành
            radmnuTinhThanh.Enabled = (Csla.ApplicationContext.User.IsInRole("TinhThanh:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            //Danh Mục --> Khoa Phòng
            radmnuKhoaPhong.Enabled = (Csla.ApplicationContext.User.IsInRole("KhoaPhong:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            #endregion

            #region Truyền thông
            // Phỏng vấn
            btnPhongVan.Enabled = (Csla.ApplicationContext.User.IsInRole("PhongVan:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            // Đăng ký thiết kế 
            btnDKThietKe.Enabled = (Csla.ApplicationContext.User.IsInRole("PhieuDangKyThietKe:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            // Sự kiện
            btnSuKien.Enabled = (Csla.ApplicationContext.User.IsInRole("SuKien:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            // Bài viết
            btnBaiViet.Enabled = (Csla.ApplicationContext.User.IsInRole("BaiViet:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            // Ấn phẩm
            btnAnPham.Enabled = (Csla.ApplicationContext.User.IsInRole("AnPham:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            // Ảnh và video
            btnAnhVideo.Enabled = (Csla.ApplicationContext.User.IsInRole("AnhVideo:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            #endregion

            #region Chi dao Tuyen

            btnCDTCanBoNhanCGKT.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_CanBoNhanCGKT_View);
            btnCDTGoiKT.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_GoiKyThuat_View);
            btnCDTHoiChuan.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_HoiChuan_View);
            btnCDTHopDong.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_HopDongKyThuat_View);
            btnCDTPhieuKhaoSat.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_PhieuKhaoSat_View);
            
            #endregion

            #region Hanh chinh

           // btnHCChamCong.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission
            btnHCCongVanDen.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_CongVanDen_View);
            btnHCCongVanDi.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_CongVanDi_View);
            btnHCDKGiangDuong.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_GiangDuong_Phong_View);
            btnHCDSDangKi.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_GiangDuong_Phong_View);
            btnHCGiangDuong.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_GiangDuong_Phong_View);
            btnHCThietBiVatTu.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_ThietBiVatTu_View);
            btnHCVanPhongPham.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_VanPhongPham_View);
            btnHCXinXe.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_XinXe_View);
            btnHCChamCong.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_ChamCong_View);
            btnHCPhieuGiaoViec.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_PhieuGiaoViec_View);
            

            #endregion

            #region dao tao

            btnDTCQHocVien.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_CQ_HocVien_View);
            btnDTCQMonHoc.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_MonHocChinhQuy_View);
            btnDTLTChuyenGiaoHV.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_ChuyenGiaoHocVien_View);
            btnDTLTDiem.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_QuanLyDiem_View);
            btnDTLTDuAn.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_QuanLyDuAn_View);
            btnDTLTHocPhi.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_TraCuuHocPhi_View);
            btnDTLTHocVien.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_ChuyenGiaoHocVien_View);
            btnDTLTLop.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_LopHoc_View);
            btnDTLTNghienCuuKhoaHoc.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_NghienCuuKhoaHoc_View);
            btnDTCQLichHoc.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_CQ_LichHoc_View);
            btnDTCQDiem.Enabled = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_CQ_QuanLyDiem_View);

            #endregion

            #endregion

        }

        #region Hệ thống

        private void Click_DangNhap(object sender, EventArgs e)
        {
            LogIn frm = new LogIn();
            frm.ShowDialog();
            LoadControl();
            ChangeColorButton(rb_HT_dangnhap);
        }

        private void Click_DoiMatKhau(object sender, EventArgs e)
        {
            ChangeColorButton(rb_HT_doimatkhau);
            ChangePassWord frm = new ChangePassWord();
            frm.ShowDialog();
        }

        #endregion

        #region Danh mục

        private void Click_DMBenhVien(object sender, EventArgs e)
        {
            string TenMayClient = NETLINK.LIB.GlobalCommon.GetIPClient();
            MessageBox.Show(TenMayClient, "Test NETLINK.LIB");
        }

        private void Click_DMChuyenKhoa(object sender, EventArgs e)
        {

        }

        private void Click_DMBoPhan(object sender, EventArgs e)
        {
            ShowBoPhanListControl(new DanhMuc.UserControl.BoPhan());
        }

        private void Click_DMChucVu(object sender, EventArgs e)
        {

        }
        private void radCanBo_Click(object sender, EventArgs e)
        {
            ShowCanBoListControl(new DanhMuc.UserControl.CanBo());
        }
        private void radmnuTinhThanh_Click(object sender, EventArgs e)
        {
            ShowTinhThanhListControl(new DanhMuc.UserControl.TinhThanh());
        }

        private void radKhoaPhong_Click(object sender, EventArgs e)
        {
            ShowKhoaPhongListControl(new DanhMuc.UserControl.KhoaPhong());
        }

        #endregion

        #region Hành chính
        #endregion

        #region Đào tạo
        #endregion

        #region Chỉ đạo tuyến
        #endregion

        #region Báo cáo
        #endregion

        #region Bản quyền
        #endregion

        #region Khac

        private void Click_Thoat(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Click_Help(object sender, EventArgs e)
        {
            AboutBox1 frm = new AboutBox1();
            frm.ShowDialog();
        }

        #endregion

        #region DanhMucUserControl

        /// <summary>
        /// bộ phân 
        /// </summary>
        /// <param name="part"></param>
        public void ShowBoPhanListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is DanhMuc.UserControl.BoPhan)
                {
                    DanhMuc.UserControl.BoPhan oPart = (DanhMuc.UserControl.BoPhan)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách bộ phận..."))
            {
                try
                {
                    AddWinPart(new DanhMuc.UserControl.BoPhan());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách bộ phận");
                }
            }
        }

        /// <summary>
        /// Khoa phòng 
        /// </summary>
        /// <param name="part"></param>
        public void ShowKhoaPhongListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is DanhMuc.UserControl.KhoaPhong)
                {
                    DanhMuc.UserControl.KhoaPhong oPart = (DanhMuc.UserControl.KhoaPhong)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách bộ phận..."))
            {
                try
                {
                    AddWinPart(new DanhMuc.UserControl.KhoaPhong());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách bộ phận");
                }
            }
        }

        /// <summary>
        /// bộ phân 
        /// </summary>
        /// <param name="part"></param>
        public void ShowChucVuListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is DanhMuc.UserControl.ChucVu)
                {
                    DanhMuc.UserControl.ChucVu oPart = (DanhMuc.UserControl.ChucVu)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách chức vụ..."))
            {
                try
                {
                    AddWinPart(new DanhMuc.UserControl.ChucVu());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách chức vụ");
                }
            }
        }

        /// <summary>
        /// dantoc
        /// </summary>
        /// <param name="part"></param>
        public void ShowDanTocListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is DanhMuc.UserControl.DanToc)
                {
                    DanhMuc.UserControl.DanToc oPart = (DanhMuc.UserControl.DanToc)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách dân tộc..."))
            {
                try
                {
                    AddWinPart(new DanhMuc.UserControl.DanToc());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách dân tộc");
                }
            }
        }

        /// <summary>
        /// quốc gia
        /// </summary>
        /// <param name="part"></param>
        public void ShowQuocGiaListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is DanhMuc.UserControl.QuocGia)
                {
                    DanhMuc.UserControl.QuocGia oPart = (DanhMuc.UserControl.QuocGia)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách quốc gia..."))
            {
                try
                {
                    AddWinPart(new DanhMuc.UserControl.QuocGia());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách quốc gia");
                }
            }
        }

        /// <summary>
        /// cơ quan
        /// </summary>
        /// <param name="part"></param>
        public void ShowCoQuanListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is DanhMuc.UserControl.CoQuan)
                {
                    DanhMuc.UserControl.CoQuan oPart = (DanhMuc.UserControl.CoQuan)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách dân tộc..."))
            {
                try
                {
                    AddWinPart(new DanhMuc.UserControl.CoQuan());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách dân tộc");
                }
            }
        }

        /// <summary>
        /// Biến Hệ Thống
        /// </summary>
        /// <param name="part"></param>
        public void ShowBienHeThongListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                //if (oCtl is DanhMuc.UserControl.BienHeThong)
                //{
                //    DanhMuc.UserControl.BienHeThong oPart = (DanhMuc.UserControl.BienHeThong)oCtl;
                //    // group list control already loaded so just
                //    // display the existing winpart
                //    ShowWinPart(oPart);
                //    return;
                //}
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách Biến hệ thống..."))
            {
                try
                {
                    //AddWinPart(new DanhMuc.UserControl.BienHeThong());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách Biến hệ thống");
                }
            }
        }
        /// <summary>
        /// học hàm
        /// </summary>
        /// <param name="part"></param>
        public void ShowHọcHamListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is DanhMuc.UserControl.HocHam)
                {
                    DanhMuc.UserControl.HocHam oPart = (DanhMuc.UserControl.HocHam)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách học hàm..."))
            {
                try
                {
                    AddWinPart(new DanhMuc.UserControl.HocHam());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách học hàm");
                }
            }

        }

        /// <summary>
        /// học vị
        /// </summary>
        /// <param name="part"></param>
        public void ShowHocViListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is DanhMuc.UserControl.HocVi)
                {
                    DanhMuc.UserControl.HocVi oPart = (DanhMuc.UserControl.HocVi)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách học vị..."))
            {
                try
                {
                    AddWinPart(new DanhMuc.UserControl.HocVi());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách học vị");
                }
            }
        }
        /// <summary>
        /// loại
        /// </summary>
        /// <param name="part"></param>
        public void ShowLoaiListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is DanhMuc.UserControl.Loai)
                {
                    DanhMuc.UserControl.Loai oPart = (DanhMuc.UserControl.Loai)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách loại..."))
            {
                try
                {
                    AddWinPart(new DanhMuc.UserControl.Loai());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách loại");
                }
            }
        }

        /// <summary>
        /// đơn vị tính
        /// </summary>
        /// <param name="part"></param>
        public void ShowDonViTinhListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is DanhMuc.UserControl.DonViTinh)
                {
                    DanhMuc.UserControl.DonViTinh oPart = (DanhMuc.UserControl.DonViTinh)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách đơn vị tính..."))
            {
                try
                {
                    AddWinPart(new DanhMuc.UserControl.DonViTinh());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đơn vị tính");
                }
            }
        }

        /// <summary>
        /// chuyên khoa
        /// </summary>
        /// <param name="part"></param>
        public void ShowChuyenKhoaListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is DanhMuc.UserControl.ChuyenKhoa)
                {
                    DanhMuc.UserControl.ChuyenKhoa oPart = (DanhMuc.UserControl.ChuyenKhoa)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách chuyên khoa..."))
            {
                try
                {
                    AddWinPart(new DanhMuc.UserControl.ChuyenKhoa());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách chuyên khoa");
                }
            }
        }

        /// <summary>
        /// chuyen nganh
        /// </summary>
        /// <param name="part"></param>
        public void ShowChuyenNganhListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is DanhMuc.UserControl.ChuyenNganh)
                {
                    DanhMuc.UserControl.ChuyenNganh oPart = (DanhMuc.UserControl.ChuyenNganh)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách chuyên ngành..."))
            {
                try
                {
                    AddWinPart(new DanhMuc.UserControl.ChuyenNganh());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách chuyên ngành");
                }
            }
        }

        /// <summary>
        /// dantoc
        /// </summary>
        /// <param name="part"></param>
        public void ShowGioiTinhListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is DanhMuc.UserControl.GioiTinh)
                {
                    DanhMuc.UserControl.GioiTinh oPart = (DanhMuc.UserControl.GioiTinh)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách giới tính..."))
            {
                try
                {
                    AddWinPart(new DanhMuc.UserControl.GioiTinh());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách giới tính");
                }
            }
        }

        /// <summary>
        /// Nguon kinh phi
        /// </summary>
        /// <param name="part"></param>
        public void ShowNguonKinhPhiListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is DanhMuc.UserControl.NguonKinhPhi)
                {
                    DanhMuc.UserControl.NguonKinhPhi oPart = (DanhMuc.UserControl.NguonKinhPhi)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách nguồn kinh phí..."))
            {
                try
                {
                    AddWinPart(new DanhMuc.UserControl.NguonKinhPhi());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách nguồn kinh phí");
                }
            }
        }

        /// <summary>
        /// phòng
        /// </summary>
        /// <param name="part"></param>
        public void ShowPhongListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is DanhMuc.UserControl.Phong)
                {
                    DanhMuc.UserControl.Phong oPart = (DanhMuc.UserControl.Phong)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách phòng..."))
            {
                try
                {
                    AddWinPart(new DanhMuc.UserControl.Phong());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách phòng");
                }
            }
        }


        public void ShowCanBoListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is DanhMuc.UserControl.CanBo)
                {
                    DanhMuc.UserControl.CanBo oPart = (DanhMuc.UserControl.CanBo)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách Cán Bộ..."))
            {
                try
                {
                    AddWinPart(new DanhMuc.UserControl.CanBo());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách cán bộ");
                }
            }
        }
        public void ShowTinhThanhListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is DanhMuc.UserControl.TinhThanh)
                {
                    DanhMuc.UserControl.TinhThanh oPart = (DanhMuc.UserControl.TinhThanh)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách Tỉnh Thành..."))
            {
                try
                {
                    AddWinPart(new DanhMuc.UserControl.TinhThanh());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách cán bộ");
                }
            }
        }
        public void ShowBenhVienListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is DanhMuc.UserControl.BenhVien)
                {
                    DanhMuc.UserControl.BenhVien oPart = (DanhMuc.UserControl.BenhVien)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new DanhMuc.UserControl.BenhVien());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }
        #endregion

        #region AuthorationUserControls

        /// <summary>
        /// Vài trò 
        /// </summary>
        /// <param name="part"></param>
        public void ShowVaiTroListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is Authoration.UserControls.VaiTro)
                {
                    Authoration.UserControls.VaiTro oPart = (Authoration.UserControls.VaiTro)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách bộ phận..."))
            {
                try
                {
                    AddWinPart(new Authoration.UserControls.VaiTro());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách bộ phận");
                }
            }
        }

        /// <summary>
        /// Phân hệ
        /// </summary>
        /// <param name="part"></param>
        public void ShowPhanHeListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is Authoration.UserControls.PhanHe)
                {
                    Authoration.UserControls.PhanHe oPart = (Authoration.UserControls.PhanHe)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách bộ phận..."))
            {
                try
                {
                    AddWinPart(new Authoration.UserControls.PhanHe());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách bộ phận");
                }
            }
        }

        /// <summary>
        /// Phân hệ
        /// </summary>
        /// <param name="part"></param>
        public void ShowNguoiDungListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is Authoration.UserControls.NguoiDung)
                {
                    Authoration.UserControls.NguoiDung oPart = (Authoration.UserControls.NguoiDung)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách bộ phận..."))
            {
                try
                {
                    AddWinPart(new Authoration.UserControls.NguoiDung());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách bộ phận");
                }
            }
        }
        public void ShowNhomNguoiDungListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is Authoration.UserControls.NhomNguoiDung)
                {
                    Authoration.UserControls.NhomNguoiDung oPart = (Authoration.UserControls.NhomNguoiDung)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách nhóm người dùng..."))
            {
                try
                {
                    AddWinPart(new Authoration.UserControls.NhomNguoiDung());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách nhóm người dùng");
                }
            }
        }

        #endregion

        #region TruyenThongUserControls

        /// <summary>
        /// truyền thông
        /// </summary>
        /// <param name="part"></param>
        public void ShowDKthietKeListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is TruyenThong.UserControl.DKThietKe)
                {
                    TruyenThong.UserControl.DKThietKe oPart = (TruyenThong.UserControl.DKThietKe)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new TruyenThong.UserControl.DKThietKe());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }



        public void ShowSuKienListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is TruyenThong.UserControl.SuKien)
                {
                    TruyenThong.UserControl.SuKien oPart = (TruyenThong.UserControl.SuKien)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new TruyenThong.UserControl.SuKien());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }


        public void ShowAnPhamListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is TruyenThong.UserControl.AnPham)
                {
                    TruyenThong.UserControl.AnPham oPart = (TruyenThong.UserControl.AnPham)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new TruyenThong.UserControl.AnPham());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }

        public void ShowBaiVietListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is TruyenThong.UserControl.BaiViet)
                {
                    TruyenThong.UserControl.BaiViet oPart = (TruyenThong.UserControl.BaiViet)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách bài viết..."))
            {
                try
                {
                    AddWinPart(new TruyenThong.UserControl.BaiViet());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách bài viết");
                }
            }
        }

        public void ShowAnhVideoListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is TruyenThong.UserControl.AnhVideo)
                {
                    TruyenThong.UserControl.AnhVideo oPart = (TruyenThong.UserControl.AnhVideo)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new TruyenThong.UserControl.AnhVideo());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }

        public void ShowPhongVanListControl(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is TruyenThong.UserControl.PhongVan)
                {
                    TruyenThong.UserControl.PhongVan oPart = (TruyenThong.UserControl.PhongVan)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách phong van..."))
            {
                try
                {
                    AddWinPart(new TruyenThong.UserControl.PhongVan());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách phong van");
                }
            }
        }
        #endregion

        #region ChiDaoTuyenUserControls

        private void ShowHopDongGoiKyThuat(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is ModuleChiDaoTuyen.UserControl.GridHopDongGoiKT)
                {
                    ModuleChiDaoTuyen.UserControl.GridHopDongGoiKT oPart = (ModuleChiDaoTuyen.UserControl.GridHopDongGoiKT)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new ModuleChiDaoTuyen.UserControl.GridHopDongGoiKT());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }
        private void ShowCDTBaoCao(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is ModuleChiDaoTuyen.UserControl.GridCDTReport)
                {
                    ModuleChiDaoTuyen.UserControl.GridCDTReport oPart = (ModuleChiDaoTuyen.UserControl.GridCDTReport)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new ModuleChiDaoTuyen.UserControl.GridCDTReport());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }
        private void ShowGoiKyThuat(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is ModuleChiDaoTuyen.UserControl.GridGoiKT)
                {
                    ModuleChiDaoTuyen.UserControl.GridGoiKT oPart = (ModuleChiDaoTuyen.UserControl.GridGoiKT)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new ModuleChiDaoTuyen.UserControl.GridGoiKT());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }
        private void ShowPhieuKhaoSat(WinPart part)
        {
            // see if this user list control is already loaded
            /*foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is ModuleChiDaoTuyen.UserControl.GridPhieuKhaoSat)
                {
                    ModuleChiDaoTuyen.UserControl.GridPhieuKhaoSat oPart = (ModuleChiDaoTuyen.UserControl.GridPhieuKhaoSat)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new ModuleChiDaoTuyen.UserControl.GridPhieuKhaoSat());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }*/
            FormMode mode = new FormMode();
            mode.IsEdit = true;
            mode.Id = 6;
            PhieuKhaoSatTuyenTruoc pks = new PhieuKhaoSatTuyenTruoc(mode);
            pks.ShowDialog();
        }
        private void ShowHoiChuanTrucTuyen(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is ModuleChiDaoTuyen.UserControl.GridHoiThaoTrucTuyen)
                {
                    ModuleChiDaoTuyen.UserControl.GridHoiThaoTrucTuyen oPart = (ModuleChiDaoTuyen.UserControl.GridHoiThaoTrucTuyen)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new ModuleChiDaoTuyen.UserControl.GridHoiThaoTrucTuyen());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }
        private void ShowCanBoNhanCGKT(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is ModuleChiDaoTuyen.UserControl.GridCanBoNhanCGKT)
                {
                    ModuleChiDaoTuyen.UserControl.GridCanBoNhanCGKT oPart = (ModuleChiDaoTuyen.UserControl.GridCanBoNhanCGKT)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new ModuleChiDaoTuyen.UserControl.GridCanBoNhanCGKT());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }

        #endregion

        #region HanhChinhUserControls

        private void ShowHanhChinhXinXe(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is ModuleHanhChinh.UserControl.Grid_HC_XinXe)
                {
                    ModuleHanhChinh.UserControl.Grid_HC_XinXe oPart = (ModuleHanhChinh.UserControl.Grid_HC_XinXe)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new ModuleHanhChinh.UserControl.Grid_HC_XinXe());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }
        private void ShowHanhChinhCongVanDen(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is ModuleHanhChinh.UserControl.Grid_HC_CongVanDen)
                {
                    ModuleHanhChinh.UserControl.Grid_HC_CongVanDen oPart = (ModuleHanhChinh.UserControl.Grid_HC_CongVanDen)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new ModuleHanhChinh.UserControl.Grid_HC_CongVanDen());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }
        private void ShowHanhChinhCongVanDi(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is ModuleHanhChinh.UserControl.Grid_HC_CongVanDi)
                {
                    ModuleHanhChinh.UserControl.Grid_HC_CongVanDi oPart = (ModuleHanhChinh.UserControl.Grid_HC_CongVanDi)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new ModuleHanhChinh.UserControl.Grid_HC_CongVanDi());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }
        private void ShowHanhChinhPhongHoc(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is ModuleHanhChinh.UserControl.Grid_HC_GiangDuong)
                {
                    ModuleHanhChinh.UserControl.Grid_HC_GiangDuong oPart = (ModuleHanhChinh.UserControl.Grid_HC_GiangDuong)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new ModuleHanhChinh.UserControl.Grid_HC_GiangDuong());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }
        private void ShowHanhVanPhongPham(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is ModuleHanhChinh.UserControl.Grid_HC_VanPhongPham)
                {
                    ModuleHanhChinh.UserControl.Grid_HC_VanPhongPham oPart = (ModuleHanhChinh.UserControl.Grid_HC_VanPhongPham)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new ModuleHanhChinh.UserControl.Grid_HC_VanPhongPham());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }
        private void ShowNhapXuatTienLamSang(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is ModuleHanhChinh.UserControl.Grid_NhapXuatTienLamSang)
                {
                    ModuleHanhChinh.UserControl.Grid_NhapXuatTienLamSang oPart = (ModuleHanhChinh.UserControl.Grid_NhapXuatTienLamSang)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new ModuleHanhChinh.UserControl.Grid_NhapXuatTienLamSang());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }
        private void ShowTienLamSang(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is ModuleHanhChinh.UserControl.Grid_HC_ThietBiTienLamSang)
                {
                    ModuleHanhChinh.UserControl.Grid_HC_ThietBiTienLamSang oPart = (ModuleHanhChinh.UserControl.Grid_HC_ThietBiTienLamSang)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new ModuleHanhChinh.UserControl.Grid_HC_ThietBiTienLamSang());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }
        private void ShowHanhChinhGiaoViec(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is ModuleHanhChinh.UserControl.Grid_HC_GiaoViec)
                {
                    ModuleHanhChinh.UserControl.Grid_HC_GiaoViec oPart = (ModuleHanhChinh.UserControl.Grid_HC_GiaoViec)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new ModuleHanhChinh.UserControl.Grid_HC_GiaoViec());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }
        private void ShowHanhThietBiVatTu(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is ModuleHanhChinh.UserControl.Grid_HC_ThietBiVatTu)
                {
                    ModuleHanhChinh.UserControl.Grid_HC_ThietBiVatTu oPart = (ModuleHanhChinh.UserControl.Grid_HC_ThietBiVatTu)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new ModuleHanhChinh.UserControl.Grid_HC_ThietBiVatTu());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }
        private void ShowHanhChinhThietBiTienLamSang(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is ModuleHanhChinh.UserControl.Grid_NhapXuatTienLamSang)
                {
                    ModuleHanhChinh.UserControl.Grid_NhapXuatTienLamSang oPart = (ModuleHanhChinh.UserControl.Grid_NhapXuatTienLamSang)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new ModuleHanhChinh.UserControl.Grid_NhapXuatTienLamSang());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }

        #endregion

        #region DaoTaoUserControls

        private void ShowDaoTaoLTHocVienLienTuc(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is ModuleDaoTao.UserControls.GridHocVienLienTuc)
                {
                    ModuleDaoTao.UserControls.GridHocVienLienTuc oPart = (ModuleDaoTao.UserControls.GridHocVienLienTuc)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new ModuleDaoTao.UserControls.GridHocVienLienTuc());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }
        private void ShowDaoTaoCQHocVienChinhQuy(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is ModuleDaoTao.UserControls.GridHocVienChinhQuy)
                {
                    ModuleDaoTao.UserControls.GridHocVienChinhQuy oPart = (ModuleDaoTao.UserControls.GridHocVienChinhQuy)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new ModuleDaoTao.UserControls.GridHocVienChinhQuy());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }
        private void ShowDaoTaoLTLopHoc(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is ModuleDaoTao.UserControls.GridLopHoc)
                {
                    ModuleDaoTao.UserControls.GridLopHoc oPart = (ModuleDaoTao.UserControls.GridLopHoc)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new ModuleDaoTao.UserControls.GridLopHoc());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }
        private void ShowDaoTaoNghienCuuKhoaHoc(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is ModuleDaoTao.UserControls.GridNghienCuuKhoaHoc)
                {
                    ModuleDaoTao.UserControls.GridNghienCuuKhoaHoc oPart = (ModuleDaoTao.UserControls.GridNghienCuuKhoaHoc)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new ModuleDaoTao.UserControls.GridNghienCuuKhoaHoc());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }
        private void ShowDaoTaoDuAn(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is ModuleDaoTao.UserControls.GridQuanLyDuAn)
                {
                    ModuleDaoTao.UserControls.GridQuanLyDuAn oPart = (ModuleDaoTao.UserControls.GridQuanLyDuAn)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new ModuleDaoTao.UserControls.GridQuanLyDuAn());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }
        private void ShowDaoTaoCQMonHoc(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is ModuleDaoTao.UserControls.GridMonHoc)
                {
                    ModuleDaoTao.UserControls.GridMonHoc oPart = (ModuleDaoTao.UserControls.GridMonHoc)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    AddWinPart(new ModuleDaoTao.UserControls.GridMonHoc());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }


        #endregion

        #region Menu usercontrol

        private void ShowLogo(WinPart part)
        {
            // see if this user list control is already loaded
            foreach (Control oCtl in panel1.Controls)
            {
                if (oCtl is ModuleHanhChinh.UserControl.Grid_HC_XinXe)
                {
                    //NullUITemplate oPart = (NullUITemplate)oCtl;
                    // group list control already loaded so just
                    // display the existing winpart
                    //ShowWinPart(oPart);
                    return;
                }
            }

            // the user list control wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy oBusy = new StatusBusy("Đang tải danh sách thiết kế..."))
            {
                try
                {
                    //AddWinPart(new NullUITemplate());
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, "Lỗi khi tải danh sách đăng ký thiết kế");
                }
            }
        }

        #endregion

        #region WinPart handling

        /// <summary>
        /// Add a new WinPart control to the
        /// list of available documents and
        /// make it the active WinPart.
        /// </summary>
        /// <param name="part">The WinPart control to add and display.</param>
        private void AddWinPart(WinPart part)
        {
            part.CloseWinPart += new EventHandler(CloseWinPart);
            panel1.Controls.Add(part);
            //this.uiCommandManager.CommandBars["Menu"].Commands["popTailieu"].Enabled = Janus.Windows.UI.InheritableBoolean.True;
            ShowWinPart(part);
        }

        /// <summary>
        /// Make the specified WinPart the 
        /// active, displayed control.
        /// </summary>
        /// <param name="part">The WinPart control to display.</param>
        private void ShowWinPart(WinPart part)
        {
            part.Dock = DockStyle.Fill;
            part.Visible = true;
            part.BringToFront();
            //this.Text = GHMS.LIB.Common.APPLICATION_NAME + " - " + part.ToString();
            this.Text = part.ToString();
            //Clear Menu popTailieu
            //ClearMenuPopTailieu();
        }

        /// <summary>
        /// Handles event from WinPart when that
        /// WinPart is closing.
        /// </summary>
        private void CloseWinPart(object sender, EventArgs e)
        {
            WinPart part = (WinPart)sender;
            part.CloseWinPart -= new EventHandler(CloseWinPart);
            part.Visible = false;
            panel1.Controls.Remove(part);
            part.Dispose();
            if (DocumentCount == 0)
            {
                //this.uiCommandManager.CommandBars["Menu"].Commands["popTailieu"].Enabled = Janus.Windows.UI.InheritableBoolean.False;
                //this.Text = GHMS.LIB.Common.APPLICATION_NAME;
            }
            else
            {
                // Find the first WinPart control and set
                // the main form's Text property accordingly.
                // This works because the first WinPart 
                // is the active one.
                foreach (Control ctl in panel1.Controls)
                {
                    if (ctl is WinPart)
                    {
                        //this.Text = GHMS.LIB.Common.APPLICATION_NAME + " - " + ((WinPart)ctl).ToString();
                        this.Text = ((WinPart)ctl).ToString();
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Make selected WinPart the active control.
        /// </summary>
        private void DocumentClick(object sender, EventArgs e)
        {
            //WinPart ctl = (WinPart)((Janus.Windows.UI.CommandBars.UICommand)sender).Tag;
            WinPart ctl = (WinPart)((Telerik.WinControls.UI.CommandBarButton)sender).Tag;
            ShowWinPart(ctl);
        }

        ///// <summary>
        ///// Gets a count of the number of loaded
        ///// documents.
        ///// </summary>
        public int DocumentCount
        {
            get
            {
                int count = 0;
                foreach (Control ctl in panel1.Controls)
                    if (ctl is WinPart)
                        count++;
                return count;
            }
        }

        #endregion

        #region Event

        private void radmuBoPhan_Click(object sender, EventArgs e)
        {
            ShowBoPhanListControl(new DanhMuc.UserControl.BoPhan());
        }

        private void mnuVaiTro_Click(object sender, EventArgs e)
        {
            ShowVaiTroListControl(new Authoration.UserControls.VaiTro());
        }

        private void mnuPhanHe_Click(object sender, EventArgs e)
        {
            ShowPhanHeListControl(new Authoration.UserControls.PhanHe());
        }

        private void mnuNhomChucNang_Click(object sender, EventArgs e)
        {
            Authoration.UI.NhomChucNang frm = new Authoration.UI.NhomChucNang();
            frm.ShowDialog();
        }

        private void mnuNguoiDung_Click(object sender, EventArgs e)
        {
            ShowNguoiDungListControl(new Authoration.UserControls.NguoiDung());
        }

        private void mnuNhomNguoiDung_Click(object sender, EventArgs e)
        {
            //Authoration.UI.NhomNguoiDung frm = new Authoration.UI.NhomNguoiDung();
            //frm.ShowDialog();
            ShowNhomNguoiDungListControl(new Authoration.UserControls.NhomNguoiDung());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            ChangeColorButton(rb_HT_dangxuat);
            Authoration.LIB.PTPrincipal.Logout();
            panel1.Controls.Clear();
            LogIn frm = new LogIn();
            frm.ShowDialog();
            LoadControl();
            
        }

        private void radmnuChucVu_Click(object sender, EventArgs e)
        {
            ShowChucVuListControl(new DanhMuc.UserControl.ChucVu());
        }

        private void radmnuDangKyThietKe_Click(object sender, EventArgs e)
        {
            ShowDKthietKeListControl(new TruyenThong.UserControl.DKThietKe());
            ChangeColorButton(rb_TT_DKDichVu);
        }

        private void radmnuBenhVien_Click(object sender, EventArgs e)
        {
            ShowBenhVienListControl(new DanhMuc.UserControl.BenhVien());
        }

        private void radmnuCoQuan_Click(object sender, EventArgs e)
        {
            ShowCoQuanListControl(new DanhMuc.UserControl.CoQuan());
        }

        private void radmnuChuyenKhoa_Click(object sender, EventArgs e)
        {
            ShowChuyenKhoaListControl(new DanhMuc.UserControl.ChuyenKhoa());
        }

        private void radmnuChuyenNganh_Click(object sender, EventArgs e)
        {
            ShowChuyenNganhListControl(new DanhMuc.UserControl.ChuyenNganh());
        }

        private void radmnuDanToc_Click(object sender, EventArgs e)
        {
            ShowDanTocListControl(new DanhMuc.UserControl.DanToc());
        }

        private void radmnuGioiTinh_Click(object sender, EventArgs e)
        {
            ShowGioiTinhListControl(new DanhMuc.UserControl.GioiTinh());
        }

        private void radmnuQuocGia_Click(object sender, EventArgs e)
        {
            ShowQuocGiaListControl(new DanhMuc.UserControl.QuocGia());
        }

        private void radmnuDonViTinh_Click(object sender, EventArgs e)
        {
            ShowDonViTinhListControl(new DanhMuc.UserControl.DonViTinh());
        }

        private void radmnuLoai_Click(object sender, EventArgs e)
        {
            ShowLoaiListControl(new DanhMuc.UserControl.Loai());
        }

        private void radmnuParameter_Click(object sender, EventArgs e)
        {
            //ShowBienHeThongListControl(new DanhMuc.UserControl.BienHeThong());
        }

        private void radmnuHocHam_Click(object sender, EventArgs e)
        {
            ShowHọcHamListControl(new DanhMuc.UserControl.HocHam());
        }

        private void radmnuHocVi_Click(object sender, EventArgs e)
        {
            ShowHocViListControl(new DanhMuc.UserControl.HocVi());
        }

        private void radmnuNguonKinhPhi_Click(object sender, EventArgs e)
        {
            ShowNguonKinhPhiListControl(new DanhMuc.UserControl.NguonKinhPhi());
        }
        private void radmnuPhong_Click(object sender, EventArgs e)
        {
            ShowPhongListControl(new DanhMuc.UserControl.Phong());
        }

        #region Truyền thông
        private void SuKien_Click(object sender, EventArgs e)
        {
            ShowSuKienListControl(new TruyenThong.UserControl.SuKien());
            ChangeColorButton(rb_TT_sukien);
        }

        private void AnPham_Click(object sender, EventArgs e)
        {
            ShowAnPhamListControl(new TruyenThong.UserControl.AnPham());
            ChangeColorButton(rb_TT_anpham);
        }

        private void BaiViet_Click(object sender, EventArgs e)
        {
            ShowBaiVietListControl(new TruyenThong.UserControl.BaiViet());
            ChangeColorButton(rb_TT_Baiviet);
        }

        private void AnhVideo_Click(object sender, EventArgs e)
        {
            ShowAnhVideoListControl(new TruyenThong.UserControl.AnhVideo());
            ChangeColorButton(rb_TT_anhVideo);
        }

        private void Click_DoanPhongVien(object sender, EventArgs e)
        {
            //DoanPhongVien frm = new DoanPhongVien();
            //frm.ShowDialog();
            ShowPhongVanListControl(new TruyenThong.UserControl.PhongVan());
            ChangeColorButton(rb_TT_PhongVan);
        }
        #endregion

        private void btnBCBaiViet_Click(object sender, EventArgs e)
        {

        }








        #endregion

        #region Chi Dao Tuyen

        /// <summary>
        /// Hop dong
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement2_Click(object sender, EventArgs e)
        {
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_HopDongKyThuat_View))
            {
                ShowHopDongGoiKyThuat(new ModuleChiDaoTuyen.UserControl.GridHopDongGoiKT());
                ChangeColorButton(rb_CDT_HopDong);
            }
            else
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
            }
        }

        /// <summary>
        /// Goi Ky Thuat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement3_Click(object sender, EventArgs e)
        {
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_GoiKyThuat_View))
            {
                ShowGoiKyThuat(new ModuleChiDaoTuyen.UserControl.GridGoiKT());
                ChangeColorButton(rb_CDT_GoiKT);
            }
            else
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
            }
        }

        /// <summary>
        /// Phieu Khao Sat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_PhieuKhaoSat_View))
            {
                ShowPhieuKhaoSat(new ModuleChiDaoTuyen.UserControl.GridPhieuKhaoSat());
                ChangeColorButton(rb_CDT_PhieuKhaoSat);
            }
            else
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
            }
        }

        /// <summary>
        /// Hoi Chuan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement5_Click(object sender, EventArgs e)
        {
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_HoiChuan_View))
            {
                ShowHoiChuanTrucTuyen(new ModuleChiDaoTuyen.UserControl.GridHoiThaoTrucTuyen());
                ChangeColorButton(rb_CDT_HoiChuan);
            }
            else
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
            }
        }

        /// <summary>
        /// Xuat bao cao
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement6_Click(object sender, EventArgs e)
        {
            ShowCDTBaoCao(new ModuleChiDaoTuyen.UserControl.GridCDTReport());
            ChangeColorButton(rb_CDT_XuaBaoCao);
        }

        /// <summary>
        /// Can bo tiep nhan CGKT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement4_Click(object sender, EventArgs e)
        {
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_CanBoNhanCGKT_View))
            {
                ShowCanBoNhanCGKT(new ModuleChiDaoTuyen.UserControl.GridCanBoNhanCGKT());
                ChangeColorButton(rb_CDT_CanbonhanCGKT);
            }
            else
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
            }
        }

        #endregion

        private void radButtonElement9_Click(object sender, EventArgs e)
        {
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_ChuyenGiaoHocVien_View))
            {
                ModuleDaoTao.UI.Form_LT_ChuyenGiaoHocVien fr = new ModuleDaoTao.UI.Form_LT_ChuyenGiaoHocVien(new FormMode());
                fr.ShowDialog();
                ChangeColorButton(rb_LT_ChuyenGiaoHV);
            }
            else
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
            }
        }

        private void radButtonElement17_Click(object sender, EventArgs e)
        {
            if(GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_XinXe_View))
            {
            ShowHanhChinhXinXe(new ModuleHanhChinh.UserControl.Grid_HC_XinXe());
            ChangeColorButton(rb_HC_xinxe);
            }
            else
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
            }
            //ShowHanhChinhThietBiTienLamSang(new ModuleHanhChinh.UserControl.Grid_NhapXuatTienLamSang());
        }

        private void radButtonElement12_Click(object sender, EventArgs e)
        {

            ModuleHanhChinh.UI.Form_ChamCong fr = new ModuleHanhChinh.UI.Form_ChamCong(new FormMode());
            fr.ShowDialog();
            ChangeColorButton(rb_HC_chamcong);
        }

        private void radButtonElement15_Click(object sender, EventArgs e)
        {
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_CongVanDi_View))
            {
                ShowHanhChinhCongVanDi(new ModuleHanhChinh.UserControl.Grid_HC_CongVanDi());
                ChangeColorButton(rb_HC_congvandi);
            }
            else
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
            }
        }

        private void radButtonElement13_Click(object sender, EventArgs e)
        {
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_ThietBiVatTu_View))
            {
                ShowHanhThietBiVatTu(new ModuleHanhChinh.UserControl.Grid_HC_ThietBiVatTu());
                ChangeColorButton(rb_HC_thietbivattu);
            }
            else
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
            }
        }

        private void radButtonElement16_Click(object sender, EventArgs e)
        {
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_VanPhongPham_View))
            {
                ShowHanhVanPhongPham(new ModuleHanhChinh.UserControl.Grid_HC_VanPhongPham());
                ChangeColorButton(rb_HC_vanphongpham);
            }
            else
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
            }
        }

        private void radButtonElement14_Click(object sender, EventArgs e)
        {
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_GiangDuong_Phong_View))
            {
                ShowHanhChinhPhongHoc(new ModuleHanhChinh.UserControl.Grid_HC_GiangDuong());
                ChangeColorButton(rb_HC_giangduongphonghop);
            }
            else
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
            }
        }

        private void radButtonElement18_Click(object sender, EventArgs e)
        {
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_XinXe_View))
            {
                ShowHanhChinhXinXe(new ModuleHanhChinh.UserControl.Grid_HC_XinXe());
            }
            else
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radButtonElement7_Click(object sender, EventArgs e)
        {
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_HocVien_View))
            {
                ShowDaoTaoLTHocVienLienTuc(new ModuleDaoTao.UserControls.GridHocVienLienTuc());
                ChangeColorButton(rb_LT_ThongTinHocVien);
            }
            else
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
            }
        }

        private void radButtonElement8_Click(object sender, EventArgs e)
        {
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_LopHoc_View))
            {
                ShowDaoTaoLTLopHoc(new ModuleDaoTao.UserControls.GridLopHoc());
                ChangeColorButton(rb_LT_ThongTinLopHoc);
            }
            else
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
            }
        }

        private void radButtonElement11_Click(object sender, EventArgs e)
        {
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_QuanLyDiem_View))
            {
                ModuleDaoTao.UI.Form_LT_NhapDiemThi fr = new ModuleDaoTao.UI.Form_LT_NhapDiemThi(new FormMode());
                fr.ShowDialog();
                ChangeColorButton(rb_LT_QLDiem);
            }
            else
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
            }
        }

        private void radButtonElement19_Click(object sender, EventArgs e)
        {
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_TraCuuHocPhi_View))
            {
                ModuleDaoTao.UI.Form_LT_TraCuuHocPhi fr = new ModuleDaoTao.UI.Form_LT_TraCuuHocPhi(new FormMode());
                fr.ShowDialog();
                ChangeColorButton(rb_LT_TraCuuHocPhi);
            }
            else
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
            }
        }

        private void radButtonElement10_Click(object sender, EventArgs e)
        {
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_NghienCuuKhoaHoc_View))
            {
                ShowDaoTaoNghienCuuKhoaHoc(new ModuleDaoTao.UserControls.GridNghienCuuKhoaHoc());
                ChangeColorButton(rb_LT_NghienCuuKhoaHoc);
            }
            else
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
            }
        }

        private void radButtonElement20_Click(object sender, EventArgs e)
        {
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_QuanLyDuAn_View))
            {
                ShowDaoTaoDuAn(new ModuleDaoTao.UserControls.GridQuanLyDuAn());
                ChangeColorButton(rb_LT_QLDuAn);
            }
            else
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
            }
        }

        private void radButtonElement21_Click(object sender, EventArgs e)
        {
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_CQ_HocVien_View))
            {
                ShowDaoTaoCQHocVienChinhQuy(new ModuleDaoTao.UserControls.GridHocVienChinhQuy());
                ChangeColorButton(rb_CQ_ThongTinHV);
            }
            else
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
            }
        }

        private void radButtonElement23_Click(object sender, EventArgs e)
        {
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_QuanLyDiem_View))
            {
                ModuleDaoTao.UI.Form_CQ_NhapDiemThi fr = new ModuleDaoTao.UI.Form_CQ_NhapDiemThi(new FormMode());
                fr.ShowDialog();
            }
            else
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
            }
        }

        private void radButtonElement24_Click(object sender, EventArgs e)
        {

            ModuleDaoTao.UI.Form_CQ_ThoiKhoaBieu fr = new ModuleDaoTao.UI.Form_CQ_ThoiKhoaBieu(new FormMode());
            fr.ShowDialog();
            ChangeColorButton(rb_CQ_LichHoc);
        }

        private void radButtonElement22_Click(object sender, EventArgs e)
        {
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_MonHocChinhQuy_View))
            {
                ShowDaoTaoCQMonHoc(new ModuleDaoTao.UserControls.GridMonHoc());
                ChangeColorButton(rb_CQ_Mon);
            }
            else
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
            }
        }

        private void radButtonElement25_Click(object sender, EventArgs e)
        {

                ShowHanhChinhCongVanDen(new ModuleHanhChinh.UserControl.Grid_HC_CongVanDen());
                ChangeColorButton(rb_HC_Congvanden);

        }

        private void radButtonElement26_Click(object sender, EventArgs e)
        {
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_GiangDuong_Phong_View))
            {
                Form_GiangDuongPhongHop_DangKiPhong fr = new Form_GiangDuongPhongHop_DangKiPhong(new FormMode());
                fr.ShowDialog();
                ChangeColorButton(rb_HC_DSDangKi);
            }
            else
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
            }
        }

        private void radButtonElement27_Click(object sender, EventArgs e)
        {
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_GiangDuong_Phong_View))
            {
                Form_GiangDuongPhongHop_PhieuDangKi fr = new Form_GiangDuongPhongHop_PhieuDangKi(new FormMode());
                fr.ShowDialog();
                ChangeColorButton(rb_HC_GiangDuongDangKi);
            }
            else
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
            }
        }

        private void radRibbonBarGroup24_Click(object sender, EventArgs e)
        {
            ShowHanhChinhThietBiTienLamSang(new Grid_NhapXuatTienLamSang());
        }

        private void ribbonTab1_Click(object sender, EventArgs e)
        {
            //ShowLogo(new NullUITemplate());
        }

        private void ribbonTab3_Click(object sender, EventArgs e)
        {
            //ShowLogo(new NullUITemplate());
        }

        private void ribbonTab4_Click(object sender, EventArgs e)
        {
            //ShowLogo(new NullUITemplate());
        }

        private void ribbonTab2_Click(object sender, EventArgs e)
        {
            //ShowLogo(new NullUITemplate());
        }

        private void ribbonTab5_Click(object sender, EventArgs e)
        {
            //ShowLogo(new NullUITemplate());
        }


        private void ribbonTab6_Click(object sender, EventArgs e)
        {
            //ShowLogo(new NullUITemplate());
        }



        #region Linh Tinh

        private Telerik.WinControls.UI.RadRibbonBarGroup oldButton;

        private void ChangeColorButton(Telerik.WinControls.UI.RadRibbonBarGroup button)
        {
            if (oldButton != button)
            {
                button.GroupFill.BackColor = Color.Silver;
                if (oldButton != null)
                    oldButton.GroupFill.BackColor = Color.White;
                oldButton = button;
            }
        }

        #endregion

        private void radButtonElement1_Click_1(object sender, EventArgs e)
        {
            ChangeColorButton(rb_HC_GiaoViec);
            ShowHanhChinhGiaoViec(new ModuleHanhChinh.UserControl.Grid_HC_GiaoViec());
            
        }

        private void radButtonElement1_Click_2(object sender, EventArgs e)
        {
            ChangeColorButton(rb_HC_ThietBiTienLamSang_NhapXuat);
            ShowNhapXuatTienLamSang(new ModuleHanhChinh.UserControl.Grid_NhapXuatTienLamSang());

        }

        private void radButtonElement2_Click_1(object sender, EventArgs e)
        {
            ChangeColorButton(rb_HC_ThietBiTienLamSang);
            ShowTienLamSang(new ModuleHanhChinh.UserControl.Grid_HC_ThietBiTienLamSang());
        }

        private void radRibbonBar1_Click(object sender, EventArgs e)
        {

        }

    }
}
