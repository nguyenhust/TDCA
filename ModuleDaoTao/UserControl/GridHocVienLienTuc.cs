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
    public partial class GridHocVienLienTuc : UsDictionary
    {
        #region variables

        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        private Dictionary<string, DT_LienTuc_HocVien_Info> dicHocVien;
        private bool StartBinding = false;
        int Mode;
        private DT_LienTuc_HocVien_Info objHocVien;
        #endregion

        public GridHocVienLienTuc()
        {
            InitializeComponent();

            RadGrid = radGridView1;
            RadGrid.CellFormatting += radGridView_CellFormatting;
            string str = GlobalCommon.GetTenDangNhap(PTIdentity.IDNguoiDung);
            STT();
            SaveToNew();
            HidenButton();
            PrintToShow();
            ShowPrint2 = true;
            TextPrint2 = "In";
            this.Mode = DT_Common.DS_HOCVIEN_ALL;
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            ShowColumnByStatus();
            dropDownNam1.FillData();
            dropDownNam1.Text = GlobalCommon.GetTimeServer().Year.ToString();
            //string str = GlobalCommon.GetTenDangNhap(PTIdentity.IDNguoiDung);
            //panel2.BackColor = Color.
            //radInTatCa.Visible = true;
        }

        public GridHocVienLienTuc(int mode)
        {
            try
            {
                this.Mode = mode;
                InitializeComponent();

                RadGrid = radGridView1;
                RadGrid.CellFormatting += radGridView_CellFormatting;
                VNRadGridLP.CurrentProvider = new VNRadGridLP();
                STT();
                SaveToNew();
                HidenButton();
                PrintToShow();
                ShowPrint2 = true;
                TextPrint2 = "In";
                ShowColumnByStatus();
                dropDownNam1.FillData();
                dropDownNam1.Text = GlobalCommon.GetTimeServer().Year.ToString();
                //radInTatCa.Visible = false;
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }

        }
        
        private void ShowColumnByStatus()
        {

            switch (Mode)
            {
                case DT_Common.DS_HOCVIEN_ALL:
                    RadGrid.Columns["In"].IsVisible = true;
                    RadGrid.Columns["HinhThucHoc"].IsVisible = true;
                    RadGrid.Columns["TrangThai"].IsVisible = true;
                    RadGrid.Columns["DateNgayDangKi"].IsVisible = true;
                    if (GlobalCommon.GetTenDangNhap(PTIdentity.IDNguoiDung) == "sysman") ;
                    RadGrid.Columns["ThoiGianHoc"].IsVisible = true;
                    //panel2.Visible = true;
                    break;
                case DT_Common.DS_HOCVIEN_THEOLOP_DAHOC:
                    RadGrid.Columns["TrangThai"].IsVisible = true;
                    RadGrid.Columns["In"].IsVisible = true;
                    break;
                case DT_Common.DS_HOCVIEN_KEMCAP_DAHOC:
                    RadGrid.Columns["In"].IsVisible = true;
                    RadGrid.Columns["KhoaHoc"].IsVisible = false;
                    RadGrid.Columns["TrangThai"].IsVisible = true;

                    break;
                case DT_Common.DS_HOCVIEN_KEMCAP_DANGHOC:
                    RadGrid.Columns["In"].IsVisible = true;
                    RadGrid.Columns["KhoaHoc"].IsVisible = false;
                    break;
                case DT_Common.DS_HOCVIEN_KEMCAP_CHUAHOC:
                    RadGrid.Columns["In"].IsVisible = true;
                    RadGrid.Columns["KhoaHoc"].IsVisible = false;
                    break;
                case DT_Common.DS_HOCVIEN_DANGKITUCTT:
                    RadGrid.Columns["In"].IsVisible = true;
                    break;
                case DT_Common.DS_HOCVIEN_CHOXEPLOP:
                    RadGrid.Columns["In"].IsVisible = true;
                    break;
                default: break;

            }

        }
        #region Override
        
        public override object GetIdValue()
        {
            switch (Mode)
            {
                case DT_Common.DS_HOCVIEN_ALL:
                    return TextMessages.ControlID.DT_HocVienLienTuc;
                case DT_Common.DS_HOCVIEN_CHOXEPLOP:
                    return TextMessages.ControlID.DT_HocVienLienTuc_ChoXepLop;
                case DT_Common.DS_HOCVIEN_KEMCAP_DAHOC:
                    return TextMessages.ControlID.DT_HocVienLienTuc_KemCap_DaHoc;
                case DT_Common.DS_HOCVIEN_KEMCAP_DANGHOC:
                    return TextMessages.ControlID.DT_HocVienLienTuc_KemCap_DangHoc;
                case DT_Common.DS_HOCVIEN_THEOLOP_DAHOC:
                    return TextMessages.ControlID.DT_HocVienLienTuc_TheoLop_DaHoc;
                case DT_Common.DS_HOCVIEN_THEOLOP_DANGHOC:
                    return TextMessages.ControlID.DT_HocVienLienTuc_TheoLop_DangHoc;
                case DT_Common.DS_HOCVIEN_DANGKITUCTT:
                    return TextMessages.ControlID.DT_HocVienLienTucCTT;
                case DT_Common.DS_HOCVIEN_KEMCAP_CHUAHOC:
                    return TextMessages.ControlID.DT_HocVienLienTuc_KemCap_ChuaHoc;
                default:
                    return TextMessages.ControlID.DT_HocVienLienTuc;
            }
        }
        private void radGridView_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }
        public override string ToString()
        {
            switch (Mode)
            {
                case DT_Common.DS_HOCVIEN_ALL:
                    return TextMessages.FormTitle.DT_HocVienLienTuc;
                case DT_Common.DS_HOCVIEN_CHOXEPLOP:
                    return TextMessages.FormTitle.DT_HocVienLienTuc_ChoXepLop;
                case DT_Common.DS_HOCVIEN_KEMCAP_DAHOC:
                    return TextMessages.FormTitle.DT_HocVienLienTuc_KemCap_DaHoc;
                case DT_Common.DS_HOCVIEN_KEMCAP_DANGHOC:
                    return TextMessages.FormTitle.DT_HocVienLienTuc_KemCap_DangHoc;
                case DT_Common.DS_HOCVIEN_THEOLOP_DAHOC:
                    return TextMessages.FormTitle.DT_HocVienLienTuc_TheoLopDaHoc;
                case DT_Common.DS_HOCVIEN_THEOLOP_DANGHOC:
                    return TextMessages.FormTitle.DT_HocVienLienTuc_TheoLopDangHoc;
                case DT_Common.DS_HOCVIEN_KEMCAP_CHUAHOC:
                    return TextMessages.FormTitle.DT_HocVienLienTuc_KemCap_ChuaHoc;
                case DT_Common.DS_HOCVIEN_DANGKITUCTT:
                    return TextMessages.FormTitle.DT_HocVienLienTucCTT;
                default:
                    return TextMessages.FormTitle.DT_HocVienLienTuc;
            }
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
            formMode.IsInsert = true;
            formMode.ItemColl = dicHocVien;
            Form_LT_HocVienLienTuc fr = new Form_LT_HocVienLienTuc(formMode);
            fr.ShowDialog();
            LoadUS();
        }
        protected override void Print2()
        {
            try
            {
                if (Mode == DT_Common.DS_HOCVIEN_KEMCAP_CHUAHOC)
                    PrintToHTMLKemCapChuaHoc();
                else if (Mode == DT_Common.DS_HOCVIEN_KEMCAP_DANGHOC)
                    PrintToHTMLKemCapDangHoc();
                else if (Mode == DT_Common.DS_HOCVIEN_KEMCAP_DAHOC)
                    //PrintToHTMLKemCapDaHoc();
                    PrintToHTMLKemCapDaHocDuocCapChungChi();
                else
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
                if(dropDownBoPhan1.DataSource == null)
                    if (dropDownBoPhan1.GetListData() == null)
                    {
                        dropDownBoPhan1.FillData(1);
                        dropDownBoPhan1.SelectedIndex = 0;
                    }
                if (!GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_HocVien_View))
                {
                    bl_btnDelete = false;
                    bl_btnPrint = false;
                    bl_btnSave = false;
                    throw new Exception(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
                }
                else
                {
                    BusinessFunction function = null;
                    switch (Mode)
                    {
                        case DT_Common.DS_HOCVIEN_ALL:
                            function = new BusinessFunction(BusinessFunctionMode.GetDataForGridView);
                            break;
                        case DT_Common.DS_HOCVIEN_CHOXEPLOP:
                            function = new BusinessFunction(BusinessFunctionMode.GetDataChoXepLopForGridView);
                            break;
                        case DT_Common.DS_HOCVIEN_KEMCAP_DAHOC:
                            function = new BusinessFunction(BusinessFunctionMode.GetDataKemCapDaHocForGridView);
                            break;
                        case DT_Common.DS_HOCVIEN_KEMCAP_DANGHOC:
                            function = new BusinessFunction(BusinessFunctionMode.GetDataKemCapDangHocForGridView);
                            break;
                        case DT_Common.DS_HOCVIEN_KEMCAP_CHUAHOC:
                            function = new BusinessFunction(BusinessFunctionMode.GetDataKemCapChuaHocForGridView);
                            break;
                        case DT_Common.DS_HOCVIEN_THEOLOP_DAHOC:
                            function = new BusinessFunction(BusinessFunctionMode.GetDataTheoLopDaHocForGridView);
                            break;
                        case DT_Common.DS_HOCVIEN_THEOLOP_DANGHOC:
                            function = new BusinessFunction(BusinessFunctionMode.GetDataTheoLopDangHocForGridView);
                            break;
                        case DT_Common.DS_HOCVIEN_DANGKITUCTT:
                            function = new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition2);
                            HideNew();
                            HideSave();
                            break;
                        default:
                            function = new BusinessFunction(BusinessFunctionMode.GetDataForGridView);
                            break;
                    }

                    function.ItemID = (int)PTIdentity.IDNguoiDung;
                    int year = 0;
                    if (dropDownBoPhan1.Selected_Item == null)
                        dropDownBoPhan1.SetText("đào tạo");
                    if ((int.TryParse(dropDownNam1.Text == "Tất cả" ? GlobalCommon.GetTimeServer().Year.ToString() : dropDownNam1.Text, out year) && dropDownBoPhan1.Selected_TextValue != null) || Mode == DT_Common.DS_HOCVIEN_ALL || Mode == DT_Common.DS_HOCVIEN_DANGKITUCTT)
                    {
                        function.ItemFilterCondition_Int = Convert.ToInt32(dropDownNam1.Text == "Tất cả" ? "0" : dropDownNam1.Text);
                        function.ItemFilterCondition_Int2 = Convert.ToInt32(dropDownBoPhan1.Selected_ID);
                        dicHocVien = new Dictionary<string, DT_LienTuc_HocVien_Info>();
                        DT_LienTuc_HocVien_Coll lItems = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
                        bindingSourceHocVien.DataSource = lItems;
                        TotalRecordValue = lItems.Count.ToString();
                    }
                    else
                    {
                        GlobalCommon.ShowErrorMessager("Bộ lọc tổng có lỗi, có thể bạn chưa chọn phòng hoặc giá trị năm không phải là một số");
                    }
                }
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
                if (radGridView1.CurrentRow != null)
                {
                    DT_LienTuc_HocVien_Info itemInfo = (DT_LienTuc_HocVien_Info)radGridView1.CurrentRow.DataBoundItem;
                    if (itemInfo.IdNguoiQuanLy != PTIdentity.IDNguoiDung)
                    {
                        GlobalCommon.ShowErrorMessager("Bạn không thể xóa học viên do người khác quản lý");
                    }
                    else
                    {
                        if (GlobalCommon.AcceptDelete())
                        {
                            DT_LienTuc_HocVien.DeleteDT_LienTuc_HocVien(itemInfo.Id);
                            GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, FormAction.Delete, string.Format("Xóa HV: {0} {1} {2}", itemInfo.HinhThucHoc, itemInfo.HoTen, itemInfo.SoCMT));
                            LoadUS();
                        }
                    }
                }

            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void MyClose()
        {
            this.Close();
        }

        #endregion

        private void radGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {
                int rowindex = radGridView1.CurrentRow.Index;
                if (int.TryParse(radGridView1.CurrentRow.Cells["Id"].Value.ToString(), out selectedID)
                    && GlobalCommon.IsHavePermission(new string[] { TextMessages.RolePermission.DT_LT_HocVien_View, TextMessages.RolePermission.DT_LT_HocVien_Edit }))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    Form_LT_HocVienLienTuc fr = new Form_LT_HocVienLienTuc(formMode);
                    fr.ShowDialog();
                    LoadUS();
                    //radGridView1.Rows[rowindex].IsSelected = true;
                    //radGridView1.Rows[rowindex].IsCurrent = true;
                    //radGridView1.Rows[rowindex].EnsureVisible();
                    //////this.radGridView1.TableElement.ScrollToRow(rowindex);
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }
        private void PrintToHTML()
        {

            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();

            cv.E_TieuDe = new List<string>() { "Họ tên", "Ngày sinh", "Trình độ", "Giới tính", "Nơi công tác", "Tỉnh", "Ngày đăng kí", "Trạng Thái", "Nội đào tạo" };

            cv.E_FilterExpression = this.FilterExpression;
            string PhongBan = string.Empty;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.Cells["In"].Value != null && Convert.ToBoolean(rowInfo.Cells["In"].Value) == true)
                //if (rowInfo.IsVisible)
                {
                    DT_LienTuc_HocVien_Info itemInfo = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();


                    cvItem.E_Value = new List<string>() { itemInfo.HoTen, itemInfo.NgaySinh, itemInfo.TenTrinhDo, itemInfo.GioiTinh, itemInfo.TenBenhVien, itemInfo.TenTinhThanh, itemInfo.NgayDangKi, itemInfo.TrangThai, itemInfo.NoiDungDaoTao };

                    cv.E_Content.Add(cvItem);
                    PhongBan = itemInfo.TenPhongQuanLy;
                }
            }
            cv.E_TieuDeBaoCao = "Danh sách học viên";
            cv.E_NguoiKi = "GSTS Phạm Minh Thông";
            //cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TenTrungTam = cv.E_TenBenhVien == "BỆNH VIỆN BẠCH MAI" ? "TRUNG TÂM DÀO TẠO VÀ CHỈ ĐẠO TUYẾN" : PhongBan;
            cv.E_TuNgayDenNgay = string.Empty;
            cv.IsNamDoc = false;
           // cv.ProcessTuNgayDenNgay(6); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }
        private void PrintToHTMLKemCapChuaHoc()
        {

            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();

            cv.E_TieuDe = new List<string>() { "Họ tên", "Ngày sinh", "Trình độ", "Nơi công tác", "Nội dung đào tạo", "Chuyên Khoa","Điện thoại", "Ghi chú" };
            cv.E_Width = new List<string>() { "130", "90", "120", "150", "", "160", "", "80" };
            cv.E_FilterExpression = this.FilterExpression;
            string PhongBan = string.Empty;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.Cells["In"].Value != null && Convert.ToBoolean(rowInfo.Cells["In"].Value) == true)
                {
                    DT_LienTuc_HocVien_Info itemInfo = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();

                    cvItem.E_Value = new List<string>() { itemInfo.HoTen, itemInfo.NgaySinh, itemInfo.TenTrinhDo, itemInfo.TenBenhVien, itemInfo.NoiDungDaoTao, itemInfo.TenChuyenKhoaLopHoc,itemInfo.DiDong, itemInfo.GhiChu };

                    cv.E_Content.Add(cvItem);
                    PhongBan = itemInfo.TenPhongQuanLy;
                }
            }

            cv.E_TieuDeBaoCao = "Danh sách học viên đăng ký học kèm cặp";
         
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TenTrungTam = PhongBan;
            cv.E_TuNgayDenNgay = "Nhập học ngày &nbsp;&nbsp;&nbsp;&nbsp; tháng &nbsp;&nbsp;&nbsp;&nbsp; năm";
            cv.IsNamDoc = false;
           // cv.ProcessTuNgayDenNgay(6); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }
        private void PrintToHTMLKemCapDangHoc()
        {

            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();

            cv.E_TieuDe = new List<string>() {"Mã học viên", "Họ tên", "Ngày sinh", "Trình độ", "Nơi công tác", "Nội dung đào tạo", "Chuyên Khoa", "Thời gian học", "Ghi chú" };
            //cv.E_Phong1 = "PHÒNG ĐÀO TẠO";
            //cv.E_Phong2 = "VĂN PHÒNG TRUNG TÂM";
            cv.E_Width = new List<string>() { "100", "120", "50", "120","", "160", "","","60" };
            cv.E_FilterExpression = this.FilterExpression;
            string PhongBan = string.Empty;
            string ngaybatdau = string.Empty;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.Cells["In"].Value != null && Convert.ToBoolean(rowInfo.Cells["In"].Value) == true)
                {
                    DT_LienTuc_HocVien_Info itemInfo = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();

                    cvItem.E_Value = new List<string>() {/*string.Format("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;-{0}", GlobalCommon.StringProcess.ForReport.RemoveSTTInMaHocVien(itemInfo.MaHocVien))*/itemInfo.MaHocVien, itemInfo.HoTen, itemInfo.NgaySinh, itemInfo.TenTrinhDo, itemInfo.TenBenhVien, itemInfo.NoiDungDaoTao, itemInfo.TenChuyenKhoaLopHoc, string.Format("{0} - {1}", itemInfo.NgayBatDau, itemInfo.NgayKetThuc),itemInfo.GhiChu  };

                    cv.E_Content.Add(cvItem);
                    PhongBan = itemInfo.TenPhongQuanLy;
                    //ngaybatdau = itemInfo.NgayBatDau;
                }
            }

            cv.E_TieuDeBaoCao = "Danh sách học viên nhập học kèm cặp";
            cv.E_TenTrungTamLapBC = "NGƯỜI LẬP BẢNG";
            //cv.E_NguoiKi = string.Empty;
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TenTrungTam = PhongBan;
            cv.IsNamDoc = false;
            cv.E_TuNgayDenNgay = "Nhập học ngày &nbsp;&nbsp;&nbsp;&nbsp; tháng &nbsp;&nbsp;&nbsp;&nbsp; năm";
            //cv.ProcessTuNgayDenNgay(6); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }
        private void PrintToHTMLKemCapDaHoc()
        {

            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();

            cv.E_TieuDe = new List<string>() { "Họ tên", "Ngày sinh", "Trình độ", "Đơn vị công tác", "Nội dung học", "Chuyên Khoa", "Số tiết", "Từ ngày", "Đến ngày" };

            cv.E_FilterExpression = this.FilterExpression;
            string PhongBan = string.Empty;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.Cells["In"].Value != null && Convert.ToBoolean(rowInfo.Cells["In"].Value) == true)
                {
                    DT_LienTuc_HocVien_Info itemInfo = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();

                    cvItem.E_Value = new List<string>() { itemInfo.HoTen, itemInfo.NgaySinh, itemInfo.TenTrinhDo, itemInfo.TenBenhVien, itemInfo.NoiDungDaoTao, itemInfo.TenChuyenKhoaLopHoc, itemInfo.TongSoTiet.ToString(), itemInfo.NgayBatDau, itemInfo.NgayKetThuc };

                    cv.E_Content.Add(cvItem);
                    PhongBan = itemInfo.TenPhongQuanLy;
                }
            }

            cv.E_TieuDeBaoCao = "Danh sách học viên kèm cặp đã học";

            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TenTrungTam = PhongBan;
            cv.E_TuNgayDenNgay = string.Empty;
            cv.IsNamDoc = false;
            //cv.ProcessTuNgayDenNgay(6); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }
        private void PrintToHTMLKemCapDaHocDuocCapChungChi()
        {

            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();

            cv.E_TieuDe = new List<string>() { "Họ tên", "Ngày sinh", "Trình độ", "Đơn vị công tác", "Nội dung học", "Chuyên Khoa", "Số tiết","Xếp loại", "Từ ngày", "Đến ngày" };
            cv.E_Phong1 = "P.GĐ TRUNG TÂM ĐÀO TẠO VÀ CHỈ ĐẠO TUYẾN";
            cv.E_Phong2 = "VĂN PHÒNG TRUNG TÂM";
            cv.E_FilterExpression = this.FilterExpression;
            string PhongBan = string.Empty;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible && rowInfo.Cells["XepLoai"].Value != "")
                //if (rowInfo.Cells["In"].Value != null && Convert.ToBoolean(rowInfo.Cells["In"].Value) == true && rowInfo.Cells["XepLoai"].Value != "")
                {
                        DT_LienTuc_HocVien_Info itemInfo = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                        ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();

                        cvItem.E_Value = new List<string>() { itemInfo.HoTen, itemInfo.NgaySinh, itemInfo.TenTrinhDo, itemInfo.TenBenhVien, itemInfo.NoiDungDaoTao, itemInfo.TenChuyenKhoaLopHoc, itemInfo.TongSoTiet.ToString(), itemInfo.XepLoai, itemInfo.NgayBatDau, itemInfo.NgayKetThuc };

                        cv.E_Content.Add(cvItem);
                        PhongBan = itemInfo.TenPhongQuanLy;
                }
            }
            cv.E_CongHoaXaHoi = string.Empty;
            cv.E_DocLapTuDo = string.Empty;
            cv.E_TieuDeBaoCao = "Danh sách học viên kèm cặp được cấp chứng chỉ";
            cv.E_TenTrungTamLapBC = "NGƯỜI LẬP BIỂU";
            cv.E_NguoiKi = "<b>" + PTIdentity.FullName + "<b>";
            cv.E_TenTrungTam = "TRUNG TÂM ĐÀO TẠO VÀ CHỈ ĐẠO TUYẾN";
            DateTime today = DateTime.Now;
            cv.E_TuNgayDenNgay = string.Empty;
            cv.E_TieuDeLop = "<b>" + "( Kèm &nbsp;&nbsp;&nbsp;theo&nbsp;Quyết&nbsp;định&nbsp;số&nbsp;&nbsp;&nbsp;&nbsp;/" + today.Year + "/QĐ-TDC &nbsp;&nbsp;&nbsp;ngày&nbsp;&nbsp;&nbsp;&nbsp; tháng &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;năm&nbsp;" + today.Year + ")" + "<b>";
            cv.IsNamDoc = false;
            cv.E_P1 = "<b>" + " ThS. Nguyễn Thị Mỹ Châu" + "<b>";
            cv.E_P2 = "<b>" + " CN. Nguyễn Thị Hạnh" + "<b>";
            //cv.ProcessTuNgayDenNgay(6); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }

        private void radLabel1_Click(object sender, EventArgs e)
        {

        }

        private void radInTatCa_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridView1.ChildRows)
                {
                    rowInfo.Cells["In"].Value = radInTatCa.Checked;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

    }
}
