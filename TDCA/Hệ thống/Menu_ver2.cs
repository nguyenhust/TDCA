using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ModuleDaoTao.LIB;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using NETLINK.LIB;
using Authoration.LIB;
using NETLINK.UI;
using ModuleHanhChinh.UI;
using ModuleDaoTao.UI;
using DanhMuc.LIB;
using DanhMuc.UI;
using TDCA.Report.BaoCaoForm;
using ModuleHanhChinh.ThanhToan;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
/// QuangBH:01/07/2014
namespace TDCA
{
    public partial class Menu_ver2 : Telerik.WinControls.UI.RadForm
    {
        private FormMode _formMode = new FormMode();
        public Menu_ver2()
        {
            InitializeComponent();
        }

        #region Variable

        #endregion

        #region UI Controller

        #region Variable

        private Telerik.WinControls.UI.RadMenuItem ui_ActiveMenuButton;
        private NETLINK.UI.WinPart ui_ActiveWinPart;

        #endregion

        #region Function

        #region WinPart Controller

        /// <summary>
        /// 
        /// </summary>
        private void UI_WinPart_CloseAll()
        {
            foreach (WinPart part in control_MainPanel.Controls)
            {
                UI_WinPart_Close(part, EventArgs.Empty);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        private void UI_WinPart_Add(WinPart item)
        {
            item.CloseWinPart += new EventHandler(UI_WinPart_Close);
            control_MainPanel.Controls.Add(item);
            UI_WinPart_Show(item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        private void UI_WinPart_Show(WinPart item)
        {
            if (ui_ActiveWinPart != null)
            {
                ui_ActiveWinPart.Visible = false;
            }
            item.Dock = DockStyle.Fill;
            item.Visible = true;
            item.BringToFront();
           
            ui_ActiveWinPart = item;
            item.SetTitle(item.ToString());

        }

        /// <summary>
        /// Load GridView vào main form
        /// </summary>
        /// <param name="item"></param>
        private void UI_WinPart_Load(WinPart item)
        {
            if (ui_ActiveWinPart != null && ui_ActiveWinPart.GetIdValue() == item.GetIdValue())
            {
                return;
            }
            foreach (WinPart part in control_MainPanel.Controls)
            {
                if (part.GetIdValue() == item.GetIdValue())
                {
                    UI_WinPart_Show(part);
                    return;
                }
            }
            using (StatusBusy oBusy = new StatusBusy(TextMessages.InfoMessage.DangTaiDanhSach))
            {
                try
                {
                    UI_WinPart_Add(item);
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowError(ex.Message, TextMessages.ErrorMessage.LoiKhiTaiDanhSach);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_WinPart_Close(object sender, EventArgs e)
        {
            WinPart part = (WinPart)sender;
            part.CloseWinPart -= new EventHandler(UI_WinPart_Close);
            part.Visible = false;
            control_MainPanel.Controls.Remove(part);
            part.Dispose();
            ui_ActiveWinPart = null;
            UI_ColorRemove_ActiveMenuButton();
        }

        private void UI_WinPart_CloseActivedWinPart()
        {
            if (ui_ActiveWinPart != null)
            {
                ui_ActiveWinPart.Visible = false;
            }
        }

        #endregion


        #region Color controller

        /// <summary>
        /// Thay doi mau cua button khi duoc click
        /// </summary>
        /// <param name="menuButton"></param>
        private void UI_ColorSet_MenuButton(Telerik.WinControls.UI.RadMenuItem menuButton)
        {
            if (menuButton != null)
            {
                UI_ColorRemove_ActiveMenuButton();
                menuButton.FillPrimitive.BackColor = Color.Gray;
                ui_ActiveMenuButton = menuButton;
            }
        }

        /// <summary>
        /// Xoa mau tren Button
        /// </summary>
        /// <param name="menuButton"></param>
        private void UI_ColorRemove_MenuButton(Telerik.WinControls.UI.RadMenuItem menuButton)
        {
            if (menuButton != null)
            {
                menuButton.FillPrimitive.BackColor = Color.Transparent;
                menuButton.FillPrimitive.BackColor2 = Color.Transparent;
                menuButton.FillPrimitive.BackColor3 = Color.Transparent;
                menuButton.FillPrimitive.BackColor4 = Color.Transparent;
            }
        }

        /// <summary>
        /// Xoa mau tren button
        /// </summary>
        private void UI_ColorRemove_ActiveMenuButton()
        {
            UI_ColorRemove_MenuButton(ui_ActiveMenuButton);
        }

        #endregion

        #endregion

        #endregion

        #region System Controler

        private void Sys_CallForm_LoginForm()
        {
            LogIn fr = new LogIn();
            //this.Hide();
            fr.MainForm = this;
            fr.ShowDialog();
            Sys_Update_UserName();
            //Aut_SetAuthoration_Main();
            this.Show();
        }

        private void Sys_CheckVersion()
        {
            DIC_PARAMETERES_Coll pr = DIC_PARAMETERES_Coll.GetDIC_PARAMETERES_Coll();
            bool done = false;
            foreach (DIC_PARAMETERES_Info pr1 in pr)
            {
                if (pr1.ParaName.ToLower() == "version")
                {
                    if (pr1.ParaValue.ToLower() == "1.0.0.1")
                    {
                        done = true;
                        break;
                    }
                    else
                    {
                        done = false;
                        break;
                    }
                }
            }
            if (done)
            {
                GlobalCommon.ShowErrorMessager("Phần mềm chưa được update, hãy đóng phần mềm và chạy lại");
                this.Close();
            }
        }

        private void Sys_CallForm_LoadingForm()
        {
           
            LoadingForm fr = new LoadingForm();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        private void Sys_Update_UserName()
        {
            userStatus1.UserName = PTIdentity.FullName;
        }

        #endregion

        #region Authoration

        /// <summary>
        /// Phân quyền cho người dùng đăng nhập hệ thống
        /// </summary>
        private void Aut_SetAuthoration_Main()
        {
            #region Variable

            bool Author_HeThong = false;
            bool Author_DanhMuc = false;
            bool Author_HanhChinh = false;
            bool Author_TruyenThong = false;
            bool Author_DaoTaoLT = false;
            bool Author_DaoTaoCQ = true;
            bool Author_ChiDaoTuyen = false;
            bool Author_ThanhToan = false;

            #endregion

            #region Danh Muc
           
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_Phong_View))
            {
                rd_Menu_DM_BoPhan.Visibility = ElementVisibility.Visible;
                Author_DanhMuc = true;
            }
            else
            {
                rd_Menu_DM_BoPhan.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_ChucVu_View))
            {
                rd_Menu_DM_ChucVu.Visibility = ElementVisibility.Visible;
                Author_DanhMuc = true;
            }
            else
            {
                rd_Menu_DM_ChucVu.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_ChuyenKhoa_View))
            {
                rd_Menu_DM_ChuyenKhoa.Visibility = ElementVisibility.Visible;
                Author_DanhMuc = true;
            }
            else
            {
                rd_Menu_DM_ChuyenKhoa.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_ChuyenNganh_View))
            {
                rd_Menu_DM_ChuyenNganh.Visibility = ElementVisibility.Visible;
                Author_DanhMuc = true;
            }
            else
            {
                rd_Menu_DM_ChuyenNganh.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_CoQuan_View))
            {
                rd_Menu_DM_CoQuan.Visibility = ElementVisibility.Visible;
                Author_DanhMuc = true;
            }
            else
            {
                rd_Menu_DM_CoQuan.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_HocHam_View))
            {
                rd_Menu_DM_HocHam.Visibility = ElementVisibility.Visible;
                Author_DanhMuc = true;
            }
            else
            {
                rd_Menu_DM_HocHam.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_Loai_View))
            {
                rd_Menu_DM_LoaiAnPham.Visibility = ElementVisibility.Visible;
                Author_DanhMuc = true;
            }
            else
            {
                rd_Menu_DM_LoaiAnPham.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_HocVi_View))
            {
                rd_Menu_DM_HocVi.Visibility = ElementVisibility.Visible;
                Author_DanhMuc = true;
            }
            else
            {
                rd_Menu_DM_HocVi.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_NguonKinhPhi_View))
            {
                rd_Menu_DM_NguonKinhPhi.Visibility = ElementVisibility.Visible;
                Author_DanhMuc = true;
            }
            else
            {
                rd_Menu_DM_NguonKinhPhi.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_CanBoCDT_View))
            {
                rd_Menu_DM_CanBo_CDT.Visibility = ElementVisibility.Visible;
                Author_DanhMuc = true;
            }
            else
            {
                rd_Menu_DM_CanBo_CDT.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_CanBoNgoaiCDT_View))
            {
                rd_Menu_DM_CanBo_GiaoVien.Visibility = ElementVisibility.Visible;
                Author_DanhMuc = true;
            }
            else
            {
                rd_Menu_DM_CanBo_GiaoVien.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(new string[] { TextMessages.RolePermission.DM_CanBoCDT_View, TextMessages.RolePermission.DM_CanBoNgoaiCDT_View }))
            {
                rd_Menu_DM_CanBo.Visibility = ElementVisibility.Visible;
                Author_DanhMuc = true;
            }
            else
            {
                rd_Menu_DM_CanBo.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_PhongHopTDC_View))
            {
                rd_Menu_DM_PhongHop.Visibility = ElementVisibility.Visible;
                Author_DanhMuc = true;
            }
            else
            {
                rd_Menu_DM_PhongHop.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_ThietBiTienLamSang_View))
            {
                rd_Menu_DM_ThietBiTLS.Visibility = ElementVisibility.Visible;
                Author_DanhMuc = true;
            }
            else
            {
                rd_Menu_DM_ThietBiTLS.Visibility = ElementVisibility.Collapsed;
            }
         
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_VanPhongPham_View))
            {
                 rd_Menu_DM_VanPhongPham.Visibility = ElementVisibility.Visible;
                Author_DanhMuc = true;
            }
            else
            {
                rd_Menu_DM_VanPhongPham.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_LopHoc_View))
            {
                rd_Menu_DM_KhungLopHoc.Visibility = ElementVisibility.Visible;
                Author_DanhMuc = true;
            }
            else
            {
                rd_Menu_DM_KhungLopHoc.Visibility = ElementVisibility.Collapsed;
            }

         if(GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_LyDoHuy_View))
         {
             rad_LyDoHuyBienLai.Visibility = ElementVisibility.Visible;
             Author_DanhMuc = true;
         }
            else
         {
             rad_LyDoHuyBienLai.Visibility = ElementVisibility.Collapsed;
         }


            #endregion

            #region System

            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.Sys_NguoiDung_View))
            {
                rd_Menu_HT_QuanTriNguoiDung.Visibility = ElementVisibility.Visible;
                Author_HeThong = true;
            }
            else
            {
                rd_Menu_HT_QuanTriNguoiDung.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.Sys_NhomNguoiDung_View))
            {
                rd_Menu_HT_NhomNguoiDung.Visibility = ElementVisibility.Visible;
                Author_HeThong = true;
            }
            else
            {
                rd_Menu_HT_NhomNguoiDung.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission("sysman"))
            {
                rd_Menu_HT_DSLoi.Visibility = ElementVisibility.Visible;
                Author_HeThong = true;
            }
            else
            {
                rd_Menu_HT_DSLoi.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission("sysman"))
            {

                rd_Menu_HT_DLRac.Visibility = ElementVisibility.Visible;
                Author_HeThong = true;
            }
            else
            {
                rd_Menu_HT_DLRac.Visibility = ElementVisibility.Collapsed;
            }


            #endregion

            #region HanhChinh

            //if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_CanBoCDT_View))
            //{
            //    rd_Menu_HC_DScanBo.Visibility = ElementVisibility.Visible;
            //    Author_HanhChinh = true;
            //}
            //else
            //{
            //    rd_Menu_HC_DScanBo.Visibility = ElementVisibility.Collapsed;
            //}
            
            if (GlobalCommon.IsHavePermission(new string[]{ TextMessages.RolePermission.HC_ChamCong_View,TextMessages.RolePermission.HC_ChamCong_Insert}))
            {
                rd_Menu_HC_ChamCong.Visibility = ElementVisibility.Visible;
                Author_HanhChinh = true;
            }
            else
            {
                rd_Menu_HC_ChamCong.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_ChamCong_View))
            {
                rd_Menu_HC_XemThongTinChamCong.Visibility = ElementVisibility.Visible;
                Author_HanhChinh = true;
            }
            else
            {
                rd_Menu_HC_XemThongTinChamCong.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_ChamCong_Insert))
            {
                rd_Menu_HC_NapChamCong.Visibility = ElementVisibility.Visible;
                Author_HanhChinh = true;
            }
            else
            {
                rd_Menu_HC_NapChamCong.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_GiaoViec_View))
            {
                rd_Menu_HC_GiaoViec.Visibility = ElementVisibility.Visible;
                Author_HanhChinh = true;
            }
            else
            {
                rd_Menu_HC_GiaoViec.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_LichLamViec_View))
            {
                rd_Menu_HC_LichLamViec.Visibility = ElementVisibility.Visible;
                Author_HanhChinh = true;
            }
            else
            {
                rd_Menu_HC_LichLamViec.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_CongVanDen_View))
            {
                rd_Menu_HC_CongVan_CVDen.Visibility = ElementVisibility.Visible;
                Author_HanhChinh = true;
            }
            else
            {
                rd_Menu_HC_CongVan_CVDen.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_CongVanDi_View))
            {
                rd_Menu_HC_CongVan_CVDi.Visibility = ElementVisibility.Visible;
                Author_HanhChinh = true;
            }
            else
            {
                rd_Menu_HC_CongVan_CVDi.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_GiangDuong_Phong_View))
            {
                rd_Menu_HC_GiangDuong.Visibility = ElementVisibility.Visible;
                Author_HanhChinh = true;
            }
            else
            {
                rd_Menu_HC_GiangDuong.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_VanPhongPham_NhapXuat_View))
            {
                rd_Menu_HC_VanPhongPham.Visibility = ElementVisibility.Visible;
                Author_HanhChinh = true;
            }
            else
            {
                rd_Menu_HC_VanPhongPham.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_ThietBiVatTu_View))
            {
                rd_Menu_HC_TrangThietBi.Visibility = ElementVisibility.Visible;
                Author_HanhChinh = true;
            }
            else
            {
                rd_Menu_HC_TrangThietBi.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_XinXe_View))
            {
                rd_Menu_HC_Xinxe.Visibility = ElementVisibility.Visible;
                Author_HanhChinh = true;
            }
            else
            {
                rd_Menu_HC_Xinxe.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_BieuMauISO_View))
            {
                rd_Menu_HC_BieuMauISO.Visibility = ElementVisibility.Visible;
                Author_HanhChinh = true;
            }
            else
            {
                rd_Menu_HC_BieuMauISO.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_ThietBiTienLamSang_NhapXuat_View))
            {
               rd_Menu_HC_TBTLS.Visibility = ElementVisibility.Visible;
                Author_HanhChinh = true;
            }
            else
            {
                rd_Menu_HC_TBTLS.Visibility = ElementVisibility.Collapsed;
            }

            #endregion

            //#region Dao Tao Chinh Quy

            //if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_HocVienChinhQUy_View))
            //{
            //    rd_Menu_DTCQ_HocVien.Visibility = ElementVisibility.Visible;
            //    Author_DaoTaoCQ = true;
            //}
            //else
            //{
            //    rd_Menu_DTCQ_HocVien.Visibility = ElementVisibility.Collapsed;
            //}

            //#endregion

            #region Dao Tao Lien Tuc
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_BenhVien_View))
            {
                rd_Menu_CDT_BenhVien.Visibility = ElementVisibility.Visible;
                Author_ChiDaoTuyen = true;
            }
            else
            {
                rd_Menu_CDT_BenhVien.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_HocVien_View))
            {
                rd_Menu_DT_HocVien.Visibility = ElementVisibility.Visible;
                Author_DaoTaoLT = true;
            }
            else
            {
                rd_Menu_DT_HocVien.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_LopHoc_View))
            {
                rd_Menu_DT_LopHoc.Visibility = ElementVisibility.Visible;
                Author_DaoTaoLT = true;
            }
            else
            {
                rd_Menu_DT_LopHoc.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_ChuyenGiaoHocVien_View))
            {
                rd_Menu_DT_ChuyenGiaoHocVien.Visibility = ElementVisibility.Visible;
                Author_DaoTaoLT = true;
            }
            else
            {
                rd_Menu_DT_ChuyenGiaoHocVien.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_TraCuuHocPhi_View))
            {
                rd_Menu_DT_HocPhi.Visibility = ElementVisibility.Visible;
                Author_DaoTaoLT = true;
            }
            else
            {
                rd_Menu_DT_HocPhi.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_QuanLyDiem_View))
            {
                rd_Menu_DT_DiemThi.Visibility = ElementVisibility.Visible;
                Author_DaoTaoLT = true;
            }
            else
            {
                rd_Menu_DT_DiemThi.Visibility = ElementVisibility.Collapsed;
            }
            rd_Menu_DT_InChungChi.Visibility = ElementVisibility.Visible;

            //if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_InChungChi_View))
            //{
            //    rd_Menu_DT_InChungChi.Visibility = ElementVisibility.Visible;
            //    Author_DaoTaoLT = true;
            //}
            //else
            //{
            //    rd_Menu_DT_InChungChi.Visibility = ElementVisibility.Collapsed;
            //}

            //if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_InChungChi_View))
            //{
            //    radMenuItemHenChungChi.Visibility = ElementVisibility.Visible;
            //    Author_DaoTaoLT = true;
            //}
            //else
            //{
            //    radMenuItemHenChungChi.Visibility = ElementVisibility.Collapsed;
            //}

            #endregion

            #region Chi Dao Tuyen

            //if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_HoiChuan_View))
            //{

            //    rd_Menu_CDT_HCTT.Visibility = ElementVisibility.Visible;
            //    Author_ChiDaoTuyen = true;
            //}
            //else
            //{
            //    rd_Menu_CDT_HCTT.Visibility = ElementVisibility.Collapsed;
            //}
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_BenhVien_View))
            {

                rd_Menu_CDT_BenhVien.Visibility = ElementVisibility.Visible;
                Author_ChiDaoTuyen = true;
            }
            else
            {
                rd_Menu_CDT_BenhVien.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_CanBoDiTinh_View))
            {
                rd_Menu_CDT_CanBoDiCongTac.Visibility = ElementVisibility.Visible;
                Author_ChiDaoTuyen = true;
            }
            else
            {
                rd_Menu_CDT_CanBoDiCongTac.Visibility = ElementVisibility.Collapsed;
            }

            #endregion
           
            #region Truyen Thong

            //if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.TT_AnhVideo_View))
            //{
            //    rd_Menu_TT_AnhVideo.Visibility = ElementVisibility.Visible;
            //    Author_TruyenThong = true;
            //}
            //else
            //{
            //    rd_Menu_TT_AnhVideo.Visibility = ElementVisibility.Collapsed;
            //}
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.TT_AnPham_View))
            {
                rd_Menu_TT_anpham.Visibility = ElementVisibility.Visible;
                Author_TruyenThong = true;
            }
            else
            {
                rd_Menu_TT_anpham.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.TT_BaiViet_View))
            {
                rd_Menu_TT_BaiViet.Visibility = ElementVisibility.Visible;
                Author_TruyenThong = true;
            }
            else
            {
                rd_Menu_TT_BaiViet.Visibility = ElementVisibility.Collapsed;
            }
            //if (GlobalCommon.IsHavePermission(new []{TextMessages.RolePermission.TT_PhieuDangKyThietKe_View,TextMessages.RolePermission.TT_DuyetPhieuDangKyThietKe_View}))
            //{
            //    rd_Menu_TT_DichVu.Visibility = ElementVisibility.Visible;
            //    Author_TruyenThong = true;
            //}
            //else
            //{
            //    rd_Menu_TT_DichVu.Visibility = ElementVisibility.Collapsed;
            //}
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.TT_PhongVan_View))
            {
                rd_Menu_TT_PhongVan.Visibility = ElementVisibility.Visible;
                Author_TruyenThong = true;
            }
            else
            {
                rd_Menu_TT_PhongVan.Visibility = ElementVisibility.Collapsed;
            }
            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.TT_SuKien_View))
            {
                rd_Menu_TT_SuKien.Visibility = ElementVisibility.Visible;
                Author_TruyenThong = true;
            }
            else
            {
                rd_Menu_TT_SuKien.Visibility = ElementVisibility.Collapsed;
            }


            #endregion

            #region Thanh toán

            if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.TT_TamThu_View))
            {
                rd_Menu_ThanhToan_BienLaiTamUng.Visibility = ElementVisibility.Visible;
                Author_ThanhToan = true;
            }
            else
            {
                rd_Menu_ThanhToan_BienLaiTamUng.Visibility = ElementVisibility.Collapsed;
            }
            //if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.TT_HoanTamThu_View))
            //{
            //    rd_Manu_BaoCao_HuyBienLai_Click.Visibility = ElementVisibility.Visible;
            //    Author_ThanhToan = true;
            //}
         
            #endregion

            #region Parent Menu

            if (Author_HeThong)
            {
                rd_Menu_HT_Separator.Visibility = ElementVisibility.Visible;
            }
            else
            {
                rd_Menu_HT_Separator.Visibility = ElementVisibility.Collapsed;
            }

            if (Author_DanhMuc)
            {
                rd_Menu_DanhMuc.Visibility = ElementVisibility.Visible;
            }
            else
            {
                rd_Menu_DanhMuc.Visibility = ElementVisibility.Collapsed;
            }

            if (Author_HanhChinh)
            {
                rd_Menu_HanhChinh.Visibility = ElementVisibility.Visible;
            }
            else
            {
                rd_Menu_HanhChinh.Visibility = ElementVisibility.Collapsed;
            }

            if (Author_ChiDaoTuyen)
            {
                rd_Menu_CDT.Visibility = ElementVisibility.Visible;
            }
            else
            {
                rd_Menu_CDT.Visibility = ElementVisibility.Collapsed;
            }

            if (Author_DaoTaoCQ)
            {
                rd_Menu_DaoTaoCQ.Visibility = ElementVisibility.Visible;
            }
            else
            {
                rd_Menu_DaoTaoCQ.Visibility = ElementVisibility.Collapsed;
            }

            if (Author_DaoTaoLT)
            {
                rd_Menu_DaoTaoLT.Visibility = ElementVisibility.Visible;
            }
            else
            {
                rd_Menu_DaoTaoLT.Visibility = ElementVisibility.Collapsed;
            }

            if (Author_TruyenThong)
            {
                rd_Menu_TruyenThong.Visibility = ElementVisibility.Visible;
            }
            else
            {
                rd_Menu_TruyenThong.Visibility = ElementVisibility.Collapsed;
            }

            // TODO remove later
            rd_Menu_DaoTaoLT.Visibility = ElementVisibility.Visible;
            
            #endregion
        }

        #endregion


        #region Menu Form

        private void userStatus1_LogOut(object sender, EventArgs e)
        {
            try
            {
                Authoration.LIB.PTPrincipal.Logout();
                UI_WinPart_CloseAll();
                //Gọi form Login
                Sys_CallForm_LoginForm();
                // Phân quyền cho người dùng vừa đăng nhập
                Aut_SetAuthoration_Main();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void Menu_ver2_Load(object sender, EventArgs e)
        {
            try
            {
                Sys_CheckVersion();

                Sys_CallForm_LoadingForm();
                //Gọi form Login
                Sys_CallForm_LoginForm();
                // Phân quyền cho người dùng vừa đăng nhập
                Aut_SetAuthoration_Main();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        #endregion

        #region Hệ Thống

        private void rd_Menu_HT_Reload_Click(object sender, EventArgs e)
        {
            try
            {
                LoadingForm fr = new LoadingForm();
                fr.ShowDialog();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void rd_Menu_HT_DLRac_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_HT_DLRac);
                UI_WinPart_CloseActivedWinPart();
                testNumberOfRecords fr = new testNumberOfRecords();
                fr.ShowDialog();
                UI_ColorRemove_MenuButton(rd_Menu_HT_DLRac);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HT_DSLoi_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_HT_QuanTriNguoiDung);
                UI_WinPart_Load(new DanhMuc.UserControl.AdminTracker());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HT_QuanTriNguoiDung_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_HT_QuanTriNguoiDung);
                UI_WinPart_Load(new Authoration.UserControls.NguoiDung());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HT_NhomNguoiDung_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_HT_NhomNguoiDung);
                UI_WinPart_Load(new Authoration.UserControls.NhomNguoiDung());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        #endregion

        #region Hành là chính

        private void rd_Menu_CDT_BenhVien_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DM_BenhVien);
                UI_WinPart_Load(new DanhMuc.UserControl.BenhVien());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HC_BieuMauISO_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_HC_BieuMauISO);
                UI_WinPart_Load(new ModuleHanhChinh.UserControl.Grid_HC_BieuMauISO());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HC_LichLamViec_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_HC_DScanBo);
                UI_WinPart_Load(new ModuleHanhChinh.UserControl.Grid_HC_LichLamViec());                
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HC_DScanBo_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_HC_DScanBo);
                UI_WinPart_Load(new DanhMuc.UserControl.Grid_DM_CanBoCDT());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HC_ChamCong_Click(object sender, EventArgs e)
        {
           
        }

        private void rd_Menu_HC_CongVan_CVDen_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_HC_CongVan_CVDen);
                UI_WinPart_Load(new ModuleHanhChinh.UserControl.Grid_HC_CongVanDi());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HC_CongVan_CVDi_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_HC_CongVan_CVDi);
                UI_WinPart_Load(new ModuleHanhChinh.UserControl.Grid_HC_CongVanDen());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HC_GiaoViec_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_HC_GiaoViec);
                UI_WinPart_Load(new ModuleHanhChinh.UserControl.Grid_HC_GiaoViec());
                //Form_LichLamViec_TheoPhong frm = new Form_LichLamViec_TheoPhong();
                //frm.ShowDialog();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HC_VanPhongPham_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_HC_VanPhongPham);
                UI_WinPart_Load(new ModuleHanhChinh.UserControl.Grid_NhapXuatVanPhongPham());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HC_Xinxe_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_HC_Xinxe);
                UI_WinPart_Load(new ModuleHanhChinh.UserControl.Grid_HC_XinXe());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HC_TrangThietBi_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_HC_TrangThietBi);
                UI_WinPart_Load(new ModuleHanhChinh.UserControl.Grid_HC_ThietBiVatTu());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HC_TBTLS_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_HC_TBTLS);
                UI_WinPart_Load(new ModuleHanhChinh.UserControl.Grid_NhapXuatTLS());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HC_TBTLS_New_Click(object sender, EventArgs e)
        {
            try
            {
                //UI_ColorSet_MenuButton(rd_Menu_HC_TBTLS_New);
                //UI_WinPart_CloseActivedWinPart();
                //ModuleHanhChinh.UI.Form_ThietBiTLS fr = new ModuleHanhChinh.UI.Form_ThietBiTLS(new FormMode());
                //fr.ShowDialog();
                //UI_ColorRemove_MenuButton(rd_Menu_HC_TBTLS_New);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }



        private void rd_Menu_HC_GiangDuong_Phong_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_HC_GiangDuong_Phong);
                UI_WinPart_Load(new ModuleHanhChinh.UserControl.Grid_HC_GiangDuong());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HC_GiangDuong_PhieuDangKi_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_HC_GiangDuong_PhieuDangKi);
                UI_WinPart_CloseActivedWinPart();
                Form_GiangDuongPhongHop_PhieuDangKi fr = new Form_GiangDuongPhongHop_PhieuDangKi(new FormMode());
                fr.ShowDialog();
                UI_ColorRemove_MenuButton(rd_Menu_HC_GiangDuong_PhieuDangKi);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HC_GiangDuong_DangKiMuon_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_HC_GiangDuong_DangKiMuon);
                UI_WinPart_CloseActivedWinPart();
                Form_GiangDuongPhongHop_DangKiPhong fr = new Form_GiangDuongPhongHop_DangKiPhong(new FormMode());
                fr.ShowDialog();
                UI_ColorRemove_MenuButton(rd_Menu_HC_GiangDuong_DangKiMuon);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HC_BC_CongVanDi_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_HC_BC_CongVanDi);
                UI_WinPart_CloseActivedWinPart();
                Form_HCReportExport fr = new Form_HCReportExport(new FormMode(CDTReport.HC_CongVanDi));
                fr.ShowDialog();
                UI_ColorRemove_MenuButton(rd_Menu_HC_BC_CongVanDi);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HC_BC_CongVanDen_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_HC_BC_CongVanDen);
                UI_WinPart_CloseActivedWinPart();
                Form_HCReportExport fr = new Form_HCReportExport(new FormMode(CDTReport.HC_CongVanDen));
                fr.ShowDialog();
                UI_ColorRemove_MenuButton(rd_Menu_HC_BC_CongVanDen);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HC_BC_DangKiGiangDuongPhongHoc_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_HC_BC_DangKiGiangDuongPhongHoc);
                UI_WinPart_CloseActivedWinPart();
                Form_HCReportExport fr = new Form_HCReportExport(new FormMode(CDTReport.HC_DangKiGiangDuong));
                fr.ShowDialog();
                UI_ColorRemove_MenuButton(rd_Menu_HC_BC_DangKiGiangDuongPhongHoc);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HC_BC_DuTruVanPhongPham_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_HC_BC_DuTruVanPhongPham);
                UI_WinPart_CloseActivedWinPart();
                Form_HCReportExport fr = new Form_HCReportExport(new FormMode(CDTReport.HC_DuTruVanPhongPham));
                fr.ShowDialog();
                UI_ColorRemove_MenuButton(rd_Menu_HC_BC_DuTruVanPhongPham);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HC_BC_TrangThietBi_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_HC_BC_TrangThietBi);
                UI_WinPart_CloseActivedWinPart();
                Form_HCReportExport fr = new Form_HCReportExport(new FormMode(CDTReport.HC_TrangThietBi));
                fr.ShowDialog();
                UI_ColorRemove_MenuButton(rd_Menu_HC_BC_TrangThietBi);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HC_GiangDuong_DanhSachPhieuDangKi_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_HC_GiangDuong_DanhSachPhieuDangKi);
                UI_WinPart_Load(new ModuleHanhChinh.UserControl.Grid_HC_PhieuDangKiMuonGiangDuong());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HC_XemThongTinChamCong_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_HC_XemThongTinChamCong);
                UI_WinPart_Load(new ModuleHanhChinh.UserControl.Grid_HC_ChamCong());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HC_NapChamCong_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_HC_NapChamCong);
                UI_WinPart_CloseActivedWinPart();
                Form_ChamCong fr = new Form_ChamCong(new FormMode());
                fr.ShowDialog();
                UI_ColorRemove_MenuButton(rd_Menu_HC_NapChamCong);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        
        
        #endregion

        #region Danh Mục

        private void rd_Menu_DM_KhungLopHoc_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DM_KhungLopHoc);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridKhungLopHoc());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void rd_Menu_DM_ThietBiTLS_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DM_ThietBiTLS);
                UI_WinPart_Load(new ModuleHanhChinh.UserControl.Grid_HC_ThietBiTienLamSang());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DM_PhongHop_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DM_PhongHop);
                UI_WinPart_Load(new ModuleHanhChinh.UserControl.Grid_HC_GiangDuong());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DM_BenhVien_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DM_BenhVien);
                UI_WinPart_Load(new DanhMuc.UserControl.BenhVien());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DM_LoaiAnPham_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DM_LoaiAnPham);
                UI_WinPart_Load(new DanhMuc.UserControl.Loai());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DM_LoaiTrangThietBi_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DM_LoaiTrangThietBi);
                UI_WinPart_Load(new DanhMuc.UserControl.LoaiTrangThietBi());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DM_BoPhan_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DM_BoPhan);
                UI_WinPart_Load(new DanhMuc.UserControl.BoPhan());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DM_ChucVu_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DM_ChucVu);
                UI_WinPart_Load(new DanhMuc.UserControl.ChucVu());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DM_ChuyenKhoa_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DM_ChuyenKhoa);
                UI_WinPart_Load(new DanhMuc.UserControl.ChuyenKhoa());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DM_ChuyenNganh_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DM_ChuyenNganh);
                UI_WinPart_Load(new DanhMuc.UserControl.ChuyenNganh());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DM_CoQuan_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DM_CoQuan);
                UI_WinPart_Load(new DanhMuc.UserControl.CoQuan());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DM_HocHam_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DM_HocHam);
                UI_WinPart_Load(new DanhMuc.UserControl.HocHam());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DM_HocVi_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DM_HocVi);
                UI_WinPart_Load(new DanhMuc.UserControl.HocVi());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DM_NguonKinhPhi_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DM_NguonKinhPhi);
                UI_WinPart_Load(new DanhMuc.UserControl.NguonKinhPhi());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DM_CanBo_CDT_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DM_CanBo_CDT);
                UI_WinPart_Load(new DanhMuc.UserControl.Grid_DM_CanBoCDT());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DM_CanBo_GiaoVien_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DM_CanBo_GiaoVien);
                UI_WinPart_Load(new DanhMuc.UserControl.Grid_DM_CanBo_NgoaiCDT());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DM_VanPhongPham_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DM_VanPhongPham);
                UI_WinPart_Load(new ModuleHanhChinh.UserControl.Grid_HC_VanPhongPham());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DM_TinhThanh_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DM_TinhThanh);
                UI_WinPart_Load(new DanhMuc.UserControl.TinhThanh());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        #endregion

        #region Đào tạo chính quy

        private void rd_Menu_DTCQ_HocVien_List_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DTCQ_HocVien_List);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienChinhQuy());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void rd_Menu_DTCQ_HocVien_DiemDauVao_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DTCQ_HocVien_DiemDauVaoCKI);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienChinhQuyKetQuaTuyenSinhCKI());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void rd_Menu_DTCQ_HocVien_DiemDauVaoCKII_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DTCQ_HocVien_DiemDauVaoCKII);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienChinhQuy_KetQuaTuyenSinhCKII());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void rd_Menu_DTCQ_HocVien_DiemDauVaoBSNT_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DTCQ_HocVien_DiemDauVaoBSNT);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienChinhQuy_KetQuaTuyenSinhBSNT());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void rd_Menu_DTCQ_HocPhi_HocVien_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DTCQ_HocVien_List);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridChinhQuyHocPhi());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DTCQ_LopHoc_list_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DTCQ_LopHoc_list);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridChinhQuyLopHoc());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DTCQ_LichHoc_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DTCQ_LichHoc);
                UI_WinPart_CloseActivedWinPart();
                ModuleDaoTao.UI.Form_CQ_TaiLenLichHoc fr = new ModuleDaoTao.UI.Form_CQ_TaiLenLichHoc(new FormMode());
                fr.ShowDialog();
                UI_ColorRemove_MenuButton(rd_Menu_DTCQ_LichHoc);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

  

        private void rd_Menu_DTCQ_HocVien_MonHoc_List_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DTCQ_HocVien_List);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridChinhQuyMonHoc());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DTCQ_HocVien_DiemThi_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    UI_ColorSet_MenuButton(rd_Menu_DTCQ_HocVien_List);
            //    UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienChinhQuy());
            //}
            //catch (Exception ex)
            //{
            //    GlobalCommon.ShowErrorMessager(ex);
            //}
        }

        private void rd_Menu_DTCQ_HocVien_HocPhi_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DTCQ_HocVien_List);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienChinhQuy());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void rd_Menu_DTCQ_DiemThi_TheoLop_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DTCQ_DiemThi_TheoLop);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridChinhQuyNhapDiemLopHoc());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DTCQ_DiemThi_TheoHocVien_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DTCQ_DiemThi_TheoHocVien);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridChinhQuyNhapDiemHocVien());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        #endregion

        #region Truyền Thông

        private void rd_Menu_TT_anpham_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_TT_anpham);
                UI_WinPart_Load(new TruyenThong.UserControl.AnPham());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_TT_AnhVideo_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_TT_AnhVideo);
                UI_WinPart_Load(new TruyenThong.UserControl.AnhVideo());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_TT_BaiViet_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_TT_BaiViet);
                UI_WinPart_Load(new TruyenThong.UserControl.BaiViet());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_TT_DichVu_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_TT_DichVu);
                UI_WinPart_Load(new TruyenThong.UserControl.DKThietKe());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_TT_PhongVan_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_TT_PhongVan);
                UI_WinPart_Load(new TruyenThong.UserControl.PhongVan());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_TT_SuKien_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_TT_SuKien);
                UI_WinPart_Load(new TruyenThong.UserControl.SuKien());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_TT_BC_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Đào tạo liên tục
        private void rd_Menu_DT_HocVien_ThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DT_HocVien_ThemMoi);
                UI_WinPart_CloseActivedWinPart();
                ModuleDaoTao.UI.Form_LT_HocVienLienTuc fr = new ModuleDaoTao.UI.Form_LT_HocVienLienTuc(new FormMode());
                fr.ShowDialog();
                UI_ColorRemove_MenuButton(rd_Menu_DT_HocVien_ThemMoi);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void rd_Menu_DT_HocVien_ThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DT_HocVien_ThongKe);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTucThongKe());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void rd_Menu_DT_InChungChi_DSDaCapChungChi_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DT_InChungChi_DSDaCapChungChi);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTucChuaInChungChi(ModuleDaoTao.LIB.DT_Common.IN_DaCapChungChi, false));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void rd_Menu_DT_InChungChi_DSChuaCapChungChi_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DT_InChungChi_DSChuaCapChungChi);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTucChuaInChungChi(ModuleDaoTao.LIB.DT_Common.IN_ChuaCapChungChi, false));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DT_InChungChi_DaInThe_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DT_InChungChi_DaInThe);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTucChuaInChungChi(ModuleDaoTao.LIB.DT_Common.IN_DaInThe, false));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DT_InChungChi_ChuaInThe_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DT_InChungChi_ChuaInThe);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTucChuaInChungChi(ModuleDaoTao.LIB.DT_Common.IN_ChuaInThe, true));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void rd_DTLT_HP_ChuaHoanThanh_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_DTLT_HP_ChuaHoanThanh);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTucHocPhi((int)DT_Common.HOCPHI_CHUADONG));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_DTLT_HP_DaHoanThanh_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_DTLT_HP_DaHoanThanh);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTucHocPhi((int)DT_Common.HOCPHI_DADONG));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_DTLT_HP_HoanTien_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_DTLT_HP_HoanTien);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTucHocPhi((int)DT_Common.HOCPHI_HOANTIEN));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_DTLT_HP_ToanBo_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_DTLT_HP_ToanBo);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTucHocPhi((int)DT_Common.HOCPHI_TOANBO));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DT_HocVien_Click(object sender, EventArgs e)
        {

        }

        private void rd_Menu_DT_HocVien_DSChung_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DT_HocVien_DSChung);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTuc());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DT_HocVien_TuCTT_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DT_HocVien_TuCTT);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTuc(6));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DT_LopHoc_Click(object sender, EventArgs e)
        {
            try
            {
                //UI_ColorSet_MenuButton(rd_Menu_DT_LopHoc);
                //UI_WinPart_Load(new ModuleDaoTao.UserControls.GridLopHoc());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DT_ChuyenGiaoHocVien_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_DT_ChuyenGiaoHocVien);
                UI_WinPart_CloseActivedWinPart();
                ModuleDaoTao.UI.Form_LT_ChuyenGiaoHocVien fr = new ModuleDaoTao.UI.Form_LT_ChuyenGiaoHocVien(new FormMode());
                fr.ShowDialog();
                UI_ColorRemove_MenuButton(rd_Menu_DT_ChuyenGiaoHocVien);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_DT_DiemThi_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    UI_ColorSet_MenuButton(rd_Menu_DT_DiemThi);
            //    UI_WinPart_CloseActivedWinPart();
            //    ModuleDaoTao.UI.Form_LT_NhapDiemThi fr = new ModuleDaoTao.UI.Form_LT_NhapDiemThi(new FormMode());
            //    fr.ShowDialog();
            //    UI_ColorRemove_MenuButton(rd_Menu_DT_DiemThi);
            //}
            //catch (Exception ex)
            //{
            //    GlobalCommon.ShowErrorMessager(ex);
            //}
        }

        private void rd_Menu_DT_HocPhi_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    UI_ColorSet_MenuButton(rd_Menu_DT_HocPhi);
            //    UI_WinPart_CloseActivedWinPart();
            //    ModuleDaoTao.UI.Form_LT_TraCuuHocPhi fr = new ModuleDaoTao.UI.Form_LT_TraCuuHocPhi(new FormMode());
            //    fr.ShowDialog();
            //    UI_ColorRemove_MenuButton(rd_Menu_DT_HocPhi);
            //}
            //catch (Exception ex)
            //{
            //    GlobalCommon.ShowErrorMessager(ex);
            //}
        }

        private void radMenuItemNhapDiemThiTheoLop_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(radMenuItemNhapDiemThiTheoLop);

                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridLopHoc_Diem(DT_Common.DIEM_THEOLOP));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
            //try
            //{
            //    UI_ColorSet_MenuButton(radMenuItemNhapDiemThiTheoLop);
            //UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTucDiem(DT_Common.DIEM_THEOLOP));
            //}
            //catch (Exception ex)
            //{
            //    GlobalCommon.ShowErrorMessager(ex);
            //}
        }

        private void radMenuItemQuanLyHocPhi_Click(object sender, EventArgs e)
        {
            try
            {
               // UI_ColorSet_MenuButton(radMenuItemQuanLyHocPhi);
                //UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTucHocPhi(DT_Common.HOCPHI_CHUADONG));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radMenuItemHoanTien_Click(object sender, EventArgs e)
        {
            try
            {
               // UI_ColorSet_MenuButton(radMenuItemHoanTien);
               // UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTucHocPhiHoanTien());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radMenuItemDanhSachHocVienDaDon_Click(object sender, EventArgs e)
        {
            try
            {
               // UI_ColorSet_MenuButton(radMenuItemDanhSachHocVienDaDon);
               // UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTucHocPhi(DT_Common.HOCPHI_DADONG));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radMenuItemTheoLopDaHoc_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(radMenuItemTheoLopDaHoc);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTuc(DT_Common.DS_HOCVIEN_THEOLOP_DAHOC));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radMenuItemHocVienDangHoc_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(radMenuItemHocVienDangHoc);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTuc(DT_Common.DS_HOCVIEN_THEOLOP_DANGHOC));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radMenuItemDT_LT_HocVienChoXepLop_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(radMenuItemDT_LT_HocVienChoXepLop);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTuc(DT_Common.DS_HOCVIEN_CHOXEPLOP));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radMenuItemDT_LT_HocVienKemCapDangHoc_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(radMenuItemDT_LT_HocVienKemCapDangHoc);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTuc(DT_Common.DS_HOCVIEN_KEMCAP_DANGHOC));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radMenuItemDT_LT_HocVienKemCapDahoc_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(radMenuItemDT_LT_HocVienKemCapDahoc);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTuc(DT_Common.DS_HOCVIEN_KEMCAP_DAHOC));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void radMenuItemDT_LT_HocVienKemCapChuaHoc_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(radMenuItemDT_LT_HocVienKemCapChuaHoc);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTuc(DT_Common.DS_HOCVIEN_KEMCAP_CHUAHOC));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radMenuItemDanhSachLop_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(radMenuItemDanhSachLop);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridLopHoc());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radMenuItemInBangDiemDanh_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(radMenuItemInBangDiemDanh);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridLopHoc());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radMenuItemNhapDiemThiKemCap_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(radMenuItemNhapDiemThiKemCap);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTucDiem(DT_Common.DIEM_KEMCAP));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radMenuItemInBangDiemDanhTheoNhom_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(radMenuItemInBangDiemDanhTheoNhom);
                UI_WinPart_CloseActivedWinPart();
                Form_InDiemDanh fr = new Form_InDiemDanh();
                fr.ShowDialog();
                UI_ColorRemove_MenuButton(radMenuItemInBangDiemDanhTheoNhom);
            }
            catch (Exception ex) {
                GlobalCommon.ShowErrorMessager(ex);    
            }
        }

        private void radMenuItemThongKeHocPhi_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(radMenuItemInBangDiemDanhTheoNhom);
                UI_WinPart_CloseActivedWinPart();
                Form_ThongKeHocPhi fr = new Form_ThongKeHocPhi();
                fr.ShowDialog();
                UI_ColorRemove_MenuButton(radMenuItemInBangDiemDanhTheoNhom);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radMenuItemHenCCKemCap_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(radMenuItemHenCCKemCap);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTucInHenChungNhan(DT_Common.HEN_CHUNGCHIKEMCAP));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radMenuItemInCCKemCap_Click(object sender, EventArgs e)
        {
            try
            {
               // UI_ColorSet_MenuButton(radMenuItemInCCKemCap);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTucInHenChungNhan(DT_Common.CHUNGCHI_KEMCAP));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radMenuItemHenChungChiTheoLop_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(radMenuItemHenChungChiTheoLop);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTucInHenChungNhan(DT_Common.HEN_CHUNGCHITHEOLOP));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radMenuItemInChungChiTheoLop_Click(object sender, EventArgs e)
        {
            try
            {
               // UI_ColorSet_MenuButton(radMenuItemInChungChiTheoLop);
                UI_WinPart_Load(new ModuleDaoTao.UserControls.GridHocVienLienTucInHenChungNhan(DT_Common.CHUNGCHI_THEOLOP));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        #endregion

        #region Chỉ đạo tuyến

        private void rd_Menu_HC_CanBoDiCongTac_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_CDT_CanBoDiCongTac);
                UI_WinPart_Load(new ModuleChiDaoTuyen.UserControl.GridCanBoDiTinh());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void rd_Menu_CDT_KinhPhi_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_CDT_KinhPhi);
                UI_WinPart_Load(new ModuleChiDaoTuyen.UserControl.GridKinhPhi());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void rd_Menu_CDT_GiangVien_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_CDT_GiangVien);
               // UI_WinPart_Load(new ModuleChiDaoTuyen.UserControl.GridCanBoCGKT());
                UI_WinPart_Load(new DanhMuc.UserControl.Grid_DM_CanBo_NgoaiCDT());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HC_CBNCGKT_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_CDT_CBNCGKT);
                UI_WinPart_Load(new ModuleChiDaoTuyen.UserControl.GridCanBoNhanCGKT());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_CDT_HDCG_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_CDT_HDCG);
                UI_WinPart_Load(new ModuleChiDaoTuyen.UserControl.GridHopDongCGKT());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HC_HCTT_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_CDT_HCTT);
                UI_WinPart_Load(new ModuleChiDaoTuyen.UserControl.GridHoiThaoTrucTuyen());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HC_PhieuKhaoSat_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_CDT_PhieuKhaoSat);
                UI_WinPart_Load(new ModuleChiDaoTuyen.UserControl.GridPhieuKhaoSat());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_HC_GoiKiThuat_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_CDT_GoiKiThuat);
                UI_WinPart_Load(new ModuleChiDaoTuyen.UserControl.GridGoiKT());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        #endregion

        #region Thanh toán
        private void rd_Menu_ThanhToan_BienLaiTamUng_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_ThanhToan_BienLaiTamUng);
                UI_WinPart_CloseActivedWinPart();
                ModuleHanhChinh.ThanhToan.FormTamThuHP fr = new ModuleHanhChinh.ThanhToan.FormTamThuHP();
                fr.ShowDialog();
                UI_ColorRemove_MenuButton(rd_Menu_ThanhToan_BienLaiTamUng);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Manu_BaoCao_ThuHocPhiHocVien_Click(object sender, EventArgs e)
        {
            FormLopHocThuHP frm = new FormLopHocThuHP();
            frm.Show();
            //try
            //{
            //    UI_ColorSet_MenuButton(rd_Manu_BaoCao_ThuHocPhiHocVien);
            //    UI_WinPart_CloseActivedWinPart();
            //    TDCA.Report.BaoCaoForm.frmBCHocVienDongHocPhi fr = new TDCA.Report.BaoCaoForm.frmBCHocVienDongHocPhi();
            //    fr.ShowDialog();
            //    UI_ColorRemove_MenuButton(rd_Manu_BaoCao_ThuHocPhiHocVien);
            //}
            //catch (Exception ex)
            //{
            //    GlobalCommon.ShowErrorMessager(ex);
            //}
        }

        private void rd_Manu_BaoCao_HuyBienLai_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Manu_BaoCao_ThuHocPhiHocVien);
                UI_WinPart_CloseActivedWinPart();
                TDCA.Report.BaoCaoForm.frmBCHocVienDongHocPhi fr = new TDCA.Report.BaoCaoForm.frmBCHocVienDongHocPhi();
                fr.ShowDialog();
                UI_ColorRemove_MenuButton(rd_Manu_BaoCao_ThuHocPhiHocVien);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }

            //try
            //{
            //    UI_ColorSet_MenuButton(rd_Manu_BaoCao_HuyBienLai);
            //    UI_WinPart_CloseActivedWinPart();
            //    TDCA.Report.BaoCaoForm.frmBaoCaoHuy fr = new TDCA.Report.BaoCaoForm.frmBaoCaoHuy();
            //    fr.ShowDialog();
            //    UI_ColorRemove_MenuButton(rd_Manu_BaoCao_HuyBienLai);
            //}
            //catch (Exception ex)
            //{
            //    GlobalCommon.ShowErrorMessager(ex);
            //}
        }
        
        #endregion

        #region Trợ giúp

        private void rd_Menu_Help_HDSD_HeThong_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalCommon.Helper.OpenFile("HDSD_HeThong.pdf");
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_Help_HDSD_DanhMuc_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalCommon.Helper.OpenFile("HDSD_DanhMuc.pdf");
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_Help_HDSD_HanhChinh_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalCommon.Helper.OpenFile("HDSD_HanhChinh.pdf");
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_Help_HDSD_ChinhQuy_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalCommon.Helper.OpenFile("HDSD_ChinhQuy.pdf");
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_Help_HDSD_LienTuc_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalCommon.Helper.OpenFile("HDSD_LienTuc.pdf");
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_Help_HDSD_ChiDaoTuyen_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalCommon.Helper.OpenFile("HDSD_ChiDaoTuyen.pdf");
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_Help_HDSD_TruyenThong_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalCommon.Helper.OpenFile("HDSD_TruyenThong.pdf");
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_Help_HuongDan_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_Help_Update_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalCommon.Helper.OpenFile("MDCTVersion.pdf");
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void rd_Menu_Help_AboutUs_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        #endregion

        private void rd_Menu_DTCQ_LopHoc_Click(object sender, EventArgs e)
        {

        }

        private void rd_Menu_DTCQ_HocVien_MonHoc_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem8_Click(object sender, EventArgs e)
        {

        }


        private void rd_Menu_DTCQ_HocVien_Click(object sender, EventArgs e)
        {

        }

        private void userStatus1_Load(object sender, EventArgs e)
        {

        }

        private void userStatus1_Link2Click(object sender, EventArgs e)
        {
            ChangePassWord fr = new ChangePassWord();
            fr.ShowDialog();
            try
            {
                Authoration.LIB.PTPrincipal.Logout();
                UI_WinPart_CloseAll();
                //Gọi form Login
                Sys_CallForm_LoginForm();
                // Phân quyền cho người dùng vừa đăng nhập
                Aut_SetAuthoration_Main();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radmnHocVienDongHocPhi_Click(object sender, EventArgs e)
        {
            FormHocVienDongHocPhi frm = new FormHocVienDongHocPhi();       
            frm.ShowDialog(this);
        }

        private void rad_LyDoHuyBienLai_Click(object sender, EventArgs e)
        {
            FormLyDoHuy.close = true;
            LyDoHuy fm = new LyDoHuy(FormLyDoHuy.close);
            fm.ShowDialog();
           
        }

        private void rad_ThanhToan_Click(object sender, EventArgs e)
        {          
            try
            {
                UI_ColorSet_MenuButton(rd_Manu_BaoCao_HuyBienLai);
                UI_WinPart_CloseActivedWinPart();
                TDCA.Report.BaoCaoForm.frmBaoCaoHuy fr = new TDCA.Report.BaoCaoForm.frmBaoCaoHuy();
                fr.ShowDialog();
                UI_ColorRemove_MenuButton(rd_Manu_BaoCao_HuyBienLai);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radMenuItem9_Click(object sender, EventArgs e)
        {
            //SeachHocVien seach = new SeachHocVien();
            //seach.ShowDialog();
        }

        private void radMenuItem9_Click_1(object sender, EventArgs e)
        {
           // SeachHocVien seach = new SeachHocVien();
          //  seach.ShowDialog();            
           //// FormThemMoi frm = new FormThemMoi();
        //    Test1 frm = new Test1();
          //  frm.ShowDialog();
        }

        private void radMenuItem10_Click(object sender, EventArgs e)
        {
            FormHocVienChuaDongHocPhi frm = new FormHocVienChuaDongHocPhi();
            frm.ShowDialog();
        }

        private void radMenuItem11_Click(object sender, EventArgs e)
        {
            NETLINK.UI.Form.PreviewReport preview = new NETLINK.UI.Form.PreviewReport();
            ReportDocument rp = new ReportDocument();
            preview.Text = "Báo cáo học viên chưa hoàn thành học phí";
            rp.Load(AppConfig.ReportPath + "rptBaoCaoTest.rpt");
            //rp.Load(AppConfig.ReportPath + "BC_SoLieuHoatDongTelemedicine.rpt");
            ModuleHanhChinh.ThanhToan.BaoCao dsdata = new ModuleHanhChinh.ThanhToan.BaoCao();
            rp.SetDataSource(dsdata);

            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {

                    cm.CommandText = "BC_SoLieuHoatDongTELEMEDICINE";
                    cm.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cm))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds, "BC_SoLieuHoatDongTELEMEDICINE");
                        if (ds.Tables[0].Rows.Count <= 0)
                        {
                            GlobalCommon.ShowError("Không có dữ liệu để báo cáo !", "Thông báo");
                            return;
                        }
                        else
                        {

                            rp.SetDataSource(ds);
                            preview.crystalReportViewer.ReportSource = rp;

                            // rp.SetParameterValue("paraNgayThangNam", "Thời gian : từ ngày " + radTuNgay.Value.ToString("dd/MM/yyyy") + "  đến ngày  " + radDenNgay.Value.ToString("dd/MM/yyyy") + "");

                            rp.SetParameterValue("NgayThangNam", "Hà Nội, Ngày " + GlobalCommon.GetTimeServer().ToString("dd") + " tháng " + GlobalCommon.GetTimeServer().ToString("MM") + " năm " + GlobalCommon.GetTimeServer().ToString("yyyy"));
                            //rp.SetParameterValue("paraTenMay", "In từ máy tính: " + GlobalCommon.DisplayLocalHostName().ToUpper() + "   ngày:" + DateTime.Now.ToString("dd/MM/yyyy") + " vào lúc:" + DateTime.Now.ToString("hh:mm:ss")); 
                            rp.SetParameterValue("NguoiLap", PTIdentity.FullName);
                            //   rp.SetParameterValue("paraTenMay", "In từ máy tính: " + GlobalCommon.DisplayLocalHostName().ToUpper() + "   ngày:" + DateTime.Now.ToString("dd/MM/yyyy") + " vào lúc:" + DateTime.Now.ToString("hh:mm:ss"));
                            preview.ShowDialog();
                        }
                    }
                }
            }
        }

        private void radMenuItem12_Click(object sender, EventArgs e)
        {
            FormDanhSachCacLopDaoTao frm = new FormDanhSachCacLopDaoTao();
            frm.ShowDialog();
        }

        private void radMenuItem13_Click(object sender, EventArgs e)
        {
            FromSoLuongHocVienHocThucHanh frm = new FromSoLuongHocVienHocThucHanh();
            frm.ShowDialog();
           
            
        }

        private void radImportExcel_Click(object sender, EventArgs e)
        {
            Form_Import_HocVien_Excel frm = new Form_Import_HocVien_Excel();
            frm.ShowDialog();
        }

        private void radMenuTrangThaiHocVien_Click(object sender, EventArgs e)
        {
            DanhMuc.UI.DM_TrangThai_HocVien frm = new DanhMuc.UI.DM_TrangThai_HocVien();
            frm.ShowDialog();
        }

        private void radBangChamCongGiangVien_Click(object sender, EventArgs e)
        {
            //BC_ChamCongGiangVien frm = new BC_ChamCongGiangVien();
            //frm.ShowDialog();
        }

        //private void radMenuTruongTotNghiep_Click(object sender, EventArgs e)
        //{
        //    TruongTotNghiep frm = new TruongTotNghiep();
        //    frm.ShowDialog();
        //}

        //private void radMenuTinh_Click(object sender, EventArgs e)
        //{
        //    DanhMuc.UI.DIC_TinhThanh frm = new DanhMuc.UI.DIC_TinhThanh();
        //    frm.ShowDialog();
        //}

        private void radmenuTrangThaiTrangThietBi_Click(object sender, EventArgs e)
        {
            DanhMuc.UI.DM_TrangThai_TrangThietBi frm = new DanhMuc.UI.DM_TrangThai_TrangThietBi();
            frm.ShowDialog();
        }

        private void radMenuItem15_Click(object sender, EventArgs e)
        {
            try
            {
                UI_ColorSet_MenuButton(rd_Menu_CDT_HCTT);
                UI_WinPart_Load(new ModuleChiDaoTuyen.UserControl.GridHoiThaoTrucTuyen());
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

    }
}
