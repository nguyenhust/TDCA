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
using ExportLib.Entities.DaoTao;
using System.IO;
using Telerik.WinControls.UI;

namespace ModuleDaoTao.UserControls
{
    public partial class GridHocVienLienTucChuaInChungChi : UsDictionary
    {
        #region variables

        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        private Dictionary<string, DT_LienTuc_HocVien_Info> dicHocVien;
        private bool StartBinding = false;
        private int FormType;
        private DT_LienTuc_HocVien_Coll listHV;
        private string urlPicture = string.Empty;
        BusinessFunction function;
        int nam = 0;

        #endregion

        public GridHocVienLienTucChuaInChungChi(int formType, bool dk)
        {
            InitializeComponent();
            RadGrid = radGridView1;
            RadGrid.CellFormatting += radGridView_CellFormatting;
            FormType = formType;
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            STT();            
            SaveToNew();
            PrintToShow();
            ShowControlBaseOnFormType();
            HideSave();
            HideNew();
            HideDelete();
            //dropDownBoPhan1.FillData(1);
            dropDownLoaiHinhDaoTao1.FillData();
            dropDownNam1.FillData();
            if (dk == true)
            {
                radDropDoiTuongIn.Visible = true;
                radLblDoiTuongIn.Visible = true;
                AddColumns();
            }                
            //radDropDoiTuongIn.SelectedIndex = 0;
        }

        #region hien thi cot

        private void AddColumns()
        {
            #region Thêm buttion copyadd
            GridViewCommandColumn combCopyAdd = new GridViewCommandColumn();
            combCopyAdd.Width = 60;
            combCopyAdd.MaxWidth = 60;
            combCopyAdd.MinWidth = 60;
            combCopyAdd.Name = "btnAddImages";
            combCopyAdd.FieldName = "btnAddImages";
            combCopyAdd.HeaderText = "Thêm ảnh";
            combCopyAdd.TextAlignment = ContentAlignment.MiddleCenter;
            combCopyAdd.UseDefaultText = true;
            combCopyAdd.DefaultText = "Add";
            this.radGridView1.Columns.Add(combCopyAdd);
            //end add
            #endregion
        }

        #endregion

        private bool Business_UploadFile()
        {
            if (!string.IsNullOrEmpty(urlPicture) && urlPicture != radGridView1.CurrentRow.Cells["Anh"].Value.ToString())
            {
                FtpUltilies ftp = new FtpUltilies();
                return ftp.UploadLargeFile(urlPicture, true, out urlPicture);
            }
            return true;
        }

        private void ShowControlBaseOnFormType()
        {
            switch (FormType)
            {
                case DT_Common.IN_ChuaCapChungChi:
                    ShowPrint2 = true;
                    ShowPrint3 = true;
                    ShowPrint4 = true;
                    TextPrint2 = "Mẫu xếp loại";
                    TextPrint3 = "Mẫu Hoàn thành khóa học";
                    TextPrint4 = "Mẫu HTKH - Dự án";
                    if (RadGrid != null && RadGrid.Columns["TongSoLanInThe"] != null)
                    {
                        RadGrid.Columns["TongSoLanInThe"].IsVisible = false;
                    }
                    break;
                case DT_Common.IN_ChuaInThe:
                    ShowPrint2 = true;
                    ShowPrint3 = true;
                    ShowPrint4 = true;
                    TextPrint2 = "In Danh sách";
                    TextPrint3 = "In Thẻ";
                    TextPrint4 = "In tất cả thẻ";
                    if (RadGrid != null && RadGrid.Columns["TongSoLanInGiayChungNhan"] != null)
                    {
                        RadGrid.Columns["TongSoLanInGiayChungNhan"].IsVisible = false;
                    }
                    break;
                case DT_Common.IN_DaCapChungChi:
                    ShowPrint2 = true;
                    TextPrint2 = "In";
                    if (RadGrid != null && RadGrid.Columns["TongSoLanInThe"] != null && RadGrid.Columns["In"] != null)
                    {
                        RadGrid.Columns["TongSoLanInThe"].IsVisible = false;
                        RadGrid.Columns["In"].IsVisible = false;
                    }
                    break;
                default:
                    ShowPrint2 = true;
                    TextPrint2 = "In danh sách";
                    if (RadGrid != null && RadGrid.Columns["TongSoLanInGiayChungNhan"] != null && RadGrid.Columns["In"] != null)
                    {
                        RadGrid.Columns["TongSoLanInGiayChungNhan"].IsVisible = false;
                        RadGrid.Columns["In"].IsVisible = false;
                    }
                    break;
            }

        }
        #region Override

        public override object GetIdValue()
        {
            switch (FormType)
            {
                case DT_Common.IN_ChuaInThe: return TextMessages.ControlID.DT_HocVienLienTuc_ChuaInThe;
                case DT_Common.IN_DaCapChungChi: return TextMessages.ControlID.DT_HocVienLienTuc_DaInChungChi;
                case DT_Common.IN_DaInThe: return TextMessages.ControlID.DT_HocVienLienTuc_DaInThe;
                default: return TextMessages.ControlID.DT_HocVienLienTuc_DuDieuKienCapChungChi;
            }
        }
        private void radGridView_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }
        public override string ToString()
        {
            switch (FormType)
            {
                case DT_Common.IN_ChuaInThe: return TextMessages.FormTitle.DT_HocVienLienTuc_ChuaInThe;
                case DT_Common.IN_DaCapChungChi: return TextMessages.FormTitle.DT_HocVienLienTuc_DaInChungChi;
                case DT_Common.IN_DaInThe: return TextMessages.FormTitle.DT_HocVienLienTuc_DaInThe;
                default: return TextMessages.FormTitle.DT_HocVienLienTuc_DuDieuKienCapChungChi;
            }
            //return TextMessages.FormTitle.DT_HocVienLienTuc_DuDieuKienCapChungChi;
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
                switch (FormType)
                {
                    case DT_Common.IN_ChuaCapChungChi:
                        PrintChungChiToHTML(1);
                        break;
                    case DT_Common.IN_ChuaInThe:
                        PrintDanhSachChuaInTheToHTML();
                        break;
                    case DT_Common.IN_DaCapChungChi:
                        PrintDanhSachDaInChungChiToHTML();
                        break;
                    default:
                        PrintDanhSachDaInTheToHTML();
                        break;
                }
                
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        protected override void Print3()
        {
            try
            {
                switch (FormType)
                {
                    case DT_Common.IN_ChuaCapChungChi:
                        PrintChungChiToHTML(2);
                        break;
                    case DT_Common.IN_ChuaInThe:
                        PrintThe();
                        break;
                    case DT_Common.IN_DaCapChungChi:
                        break;
                    default:
                        break;
                }
                
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        protected override void Print4()
        {
            try
            {
                switch (FormType)
                {
                    case DT_Common.IN_ChuaCapChungChi:
                        PrintChungChiToHTML(3);
                        break;
                    case DT_Common.IN_ChuaInThe:
                        foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
                        {
                            rowInfo.Cells["In"].Value = true;
                        }
                        PrintThe();
                        break;
                    case DT_Common.IN_DaCapChungChi:
                        break;
                    default:
                        break;
                }
                
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
                if(dropDownBoPhan1.GetListData() == null)
                    dropDownBoPhan1.FillData(1);
                if (dropDownBoPhan1.Selected_Item == null)
                    dropDownBoPhan1.SetText("Tất cả các phòng");
                if (string.IsNullOrEmpty(dropDownLoaiHinhDaoTao1.Text))
                    dropDownLoaiHinhDaoTao1.Text = "Theo Lớp";
                if (string.IsNullOrEmpty(dropDownNam1.Text))
                    dropDownNam1.Text = DateTime.Now.Year.ToString();
                //int nam = 0;
                if (!string.IsNullOrEmpty(dropDownLoaiHinhDaoTao1.Text) && int.TryParse(dropDownNam1.Text == "Tất cả" ? "0" : dropDownNam1.Text, out nam) && dropDownBoPhan1.Selected_TextValue != null)
                {

                    //BusinessFunction function;
                    switch (FormType)
                    {
                        case DT_Common.IN_DaInThe: function = new BusinessFunction(BusinessFunctionMode.GetDTLienTuc_HVDaInThe); break;
                        case DT_Common.IN_DaCapChungChi: function = new BusinessFunction(BusinessFunctionMode.GetDTLienTuc_HVDaInChungChi); break;
                        case DT_Common.IN_ChuaInThe: function = new BusinessFunction(BusinessFunctionMode.GetDTLienTuc_HVChuaInThe); break;
                        default: function = new BusinessFunction(BusinessFunctionMode.GetDTLienTuc_HVChuaInChungChi);
                            break;
                    }
                    function.ItemFilterCondition_Int = nam;
                    function.ItemFilterCondition_String = dropDownLoaiHinhDaoTao1.Text;
                    function.ItemFilterCondition_Int2 = Convert.ToInt32(dropDownBoPhan1.Selected_ID);
                    listHV = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
                    bindingSourceHocVien.DataSource = listHV;
                    TotalRecordValue = listHV.Count.ToString();
                    foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
                    {
                        if (rowInfo.Cells["Anh"].Value == null || rowInfo.Cells["Anh"].Value == "")
                        {
                            rowInfo.Cells["HoTen"].Style.ForeColor = Color.Red;
                            rowInfo.Cells["MaHocVien"].Style.ForeColor = Color.Red;
                            rowInfo.Cells["SoCMT"].Style.ForeColor = Color.Red;
                        }
                    }
                }
                else
                {
                    GlobalCommon.ShowErrorMessager("Bộ lọc tổng có lỗi, có thể bạn chưa chọn phòng, loại hình đào tạo hoặc giá trị năm không phải là một số");
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
                if (int.TryParse(radGridView1.CurrentRow.Cells["Id"].Value.ToString(), out selectedID)
                    && GlobalCommon.IsHavePermission(new string[] { TextMessages.RolePermission.DT_LT_HocVien_View, TextMessages.RolePermission.DT_LT_HocVien_Edit }))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    Form_LT_HocVienLienTuc fr = new Form_LT_HocVienLienTuc(formMode);
                    fr.ShowDialog();
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void PrintChungChiToHTML(int type)
        {

            //if (objHocvien.HinhThucHoc.CompareTo(radRadioButtonTheoLop.Text) == 0)
            //{
     
            DT_GiayChungChi chungchi = new DT_GiayChungChi();
            chungchi.ListChungChi = new List<ChungChi>();
            string today = string.Format("{0}, Ngày {1} tháng {2} năm {3}", "Hà Nội", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            DT_LienTuc_HocVien_Coll listHV = DT_LienTuc_HocVien_Coll.NewDT_LienTuc_HocVien_Coll();
            //DT_LienTuc_KhungLopHoc_Coll lstKhungLopHoc = dropDownLopHocLienTucKhung.GetListData();
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {

                if (rowInfo.IsVisible && Convert.ToBoolean(rowInfo.Cells["In"].Value))
                {
                    DT_LienTuc_HocVien_Info objHocvien = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                    ChungChi objNeedPrint = new ChungChi();
                    objNeedPrint.ThongTin = today;
                    objNeedPrint.HocVien = objHocvien.HoTen;
                    objNeedPrint.KhoaHocHoanThanh = objHocvien.NoiDungDaoTao;
                    objNeedPrint.NgayBatDau = objHocvien.NgayBatDau;
                    objNeedPrint.NgayKetThuc = objHocvien.NgayKetThuc;
                    objNeedPrint.NgaySinh = objHocvien.NgaySinh;
                    objNeedPrint.SoTietHoc = objHocvien.TongSoTiet.ToString() + " tiết";
                    objNeedPrint.TrinhDo = objHocvien.TenTrinhDo;
                    objNeedPrint.DonViCongTac = objHocvien.TenBenhVien;
                    objNeedPrint.MaHocVien = GlobalCommon.StringProcess.ForReport.RemoveSTTInMaHocVien(objHocvien.MaHocVien);
                    objNeedPrint.CoVan = string.Empty;
                    int tongsolanin = 0;
                    if (int.TryParse(objHocvien.TongSoLanInGiayChungNhan.ToString(), out tongsolanin))
                    {
                        objHocvien.TongSoLanInGiayChungNhan = tongsolanin + 1;
                        objHocvien.TrangThai = DT_Common_value.TT_HocVien_DaCapChungChi;
                    }
                    if (type == 1)
                    {
                        objNeedPrint.XepLoaiTitle = objNeedPrint.strXepLoaiTitle;
                        objNeedPrint.XepLoai = objHocvien.XepLoai == "" ? "Hoàn thành khóa học" : objHocvien.XepLoai;
                    }
                    else if (type == 3)
                    {
                        objNeedPrint.CoVan = objNeedPrint.strCoVan;
                        objNeedPrint.XepLoai = string.Empty;
                        objNeedPrint.XepLoaiTitle = string.Empty;
                    }
                    else
                    {
                        objNeedPrint.XepLoai = string.Empty;
                        objNeedPrint.XepLoaiTitle = string.Empty;
                    }
                    chungchi.ListChungChi.Add(objNeedPrint);
                    listHV.Add(objHocvien);
                }
            }
            if (listHV != null && listHV.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn in " + listHV.Count.ToString() + " giấy chứng nhận", "Xác nhận hành động", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    ExportDaoTao daotao = new ExportDaoTao();
                    if (type == 1)
                    {
                        daotao.ExportGiayChungChi(chungchi);
                    }
                    else
                    {
                        daotao.ExportGiayChungNhan(chungchi);
                    }
                    listHV.Save();
                    GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.ExportSuccess);
                    LoadUS();
                }
            }
        }

        private void PrintThe()
        {
            if (!string.IsNullOrEmpty(radDropDoiTuongIn.Text ))
            {
                DT_TheHocVienLienTuc lstHocvienLt = new DT_TheHocVienLienTuc();
                lstHocvienLt.ListTheHocVienLienTuc = new List<TheHocVienLienTuc>();
                ExportDaoTao daotao = new ExportDaoTao();
                string temp = Path.GetTempPath();
                FtpUltilies ftpU = new FtpUltilies();
                foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
                {

                    if (rowInfo.IsVisible && Convert.ToBoolean(rowInfo.Cells["In"].Value))
                    {
                        DT_LienTuc_HocVien_Info objHocvien = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                        string imgFileName = objHocvien.MaHocVien + ".jpg";
                        imgFileName = Path.Combine(temp, imgFileName);
                        TheHocVienLienTuc needPrint = new TheHocVienLienTuc();
                        needPrint.TenHocVien = GlobalCommon.StringProcess.ForReport.VietTatMotSoKiTu(objHocvien.HoTen);
                        needPrint.MaHocVien = objHocvien.MaHocVien;
                        try
                        {
                            if (!string.IsNullOrEmpty(objHocvien.Anh))
                                ftpU.DownloadFile(objHocvien.Anh, temp + "\\" + objHocvien.MaHocVien + ".jpg");
                        }
                        catch
                        {
                        }
                        needPrint.AnhHocVien = temp + "\\" + objHocvien.MaHocVien + ".jpg";
                        needPrint.TrinhDo = objHocvien.TenTrinhDo;
                        needPrint.KhoaHoc = objHocvien.NoiDungDaoTao;
                        needPrint.ThoiGian = string.Format("{0} - {1}", objHocvien.NgayBatDau, objHocvien.NgayKetThuc);
                        needPrint.SoCMT = objHocvien.SoCMT;
                        needPrint.TruongHoc = objHocvien.TruongTotNghiep;
                        lstHocvienLt.ListTheHocVienLienTuc.Add(needPrint);
                        int tslinthe = 0;
                        if (int.TryParse(objHocvien.TongSoLanInThe.ToString(), out tslinthe))
                        {
                            objHocvien.TongSoLanInThe = tslinthe + 1;
                        }

                    }

                }
                if (listHV != null && listHV.Count > 0 && lstHocvienLt.ListTheHocVienLienTuc.Count > 0)
                {
                    if (MessageBox.Show("Bạn có muốn in " + lstHocvienLt.ListTheHocVienLienTuc.Count.ToString() + " thẻ học viên", "Xác nhận hành động", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        listHV.Save();
                        daotao.ExportTheHocVienLienTuc(lstHocvienLt, Convert.ToInt32(radDropDoiTuongIn.SelectedIndex));
                        GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.ExportSuccess);
                        LoadUS();
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn loại thẻ muốn in","Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void PrintDanhSachChuaInTheToHTML()
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Họ tên", "Ngày sinh", "Trình độ", "Giới tính", "Nơi công tác", "Tỉnh", "Ngày đăng kí", "Trạng Thái", "Nội đào tạo", "Số lần in chứng chỉ" };
            cv.E_FilterExpression = this.FilterExpression;
            string PhongBan = string.Empty;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    DT_LienTuc_HocVien_Info itemInfo = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { itemInfo.HoTen, itemInfo.NgaySinh, itemInfo.TenTrinhDo, itemInfo.GioiTinh, itemInfo.TenBenhVien, itemInfo.TenTinhThanh, itemInfo.NgayDangKi, itemInfo.TrangThai, itemInfo.NoiDungDaoTao, itemInfo.TongSoLanInGiayChungNhan.ToString() };
                    cv.E_Content.Add(cvItem);
                    PhongBan = itemInfo.TenPhongQuanLy;
                }
            }
            cv.E_TieuDeBaoCao = "Danh sách học viên chưa in thẻ";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TenTrungTam = PhongBan;
            cv.IsNamDoc = false;
            cv.ProcessTuNgayDenNgay(6); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }

        private void PrintDanhSachDaInChungChiToHTML()
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Họ tên", "Ngày sinh", "Trình độ", "Giới tính", "Nơi công tác", "Tỉnh", "Ngày đăng kí", "Trạng Thái", "Nội đào tạo", "Số lần in chứng chỉ" };
            cv.E_FilterExpression = this.FilterExpression;
            string PhongBan = string.Empty;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    DT_LienTuc_HocVien_Info itemInfo = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { itemInfo.HoTen, itemInfo.NgaySinh, itemInfo.TenTrinhDo, itemInfo.GioiTinh, itemInfo.TenBenhVien, itemInfo.TenTinhThanh, itemInfo.NgayDangKi, itemInfo.TrangThai, itemInfo.NoiDungDaoTao, itemInfo.TongSoLanInGiayChungNhan.ToString() };
                    cv.E_Content.Add(cvItem);
                    PhongBan = itemInfo.TenPhongQuanLy;
                }
            }
            cv.E_TieuDeBaoCao = "Danh sách học viên đã in giấy chứng nhận";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TenTrungTam = PhongBan;
            cv.IsNamDoc = false;
            cv.ProcessTuNgayDenNgay(6); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }

        private void PrintDanhSachDaInTheToHTML()
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Họ tên", "Ngày sinh", "Trình độ", "Giới tính", "Nơi công tác", "Tỉnh", "Ngày đăng kí", "Trạng Thái", "Nội đào tạo", "Số lần in thẻ" };
            cv.E_FilterExpression = this.FilterExpression;
            string PhongBan = string.Empty;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    DT_LienTuc_HocVien_Info itemInfo = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { itemInfo.HoTen, itemInfo.NgaySinh, itemInfo.TenTrinhDo, itemInfo.GioiTinh, itemInfo.TenBenhVien, itemInfo.TenTinhThanh, itemInfo.NgayDangKi, itemInfo.TrangThai, itemInfo.NoiDungDaoTao, itemInfo.TongSoLanInThe.ToString() };
                    cv.E_Content.Add(cvItem);
                    PhongBan = itemInfo.TenPhongQuanLy;
                }
            }
            cv.E_TieuDeBaoCao = "Danh sách học viên đã in thẻ";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TenTrungTam = PhongBan;
            cv.IsNamDoc = false;
            cv.ProcessTuNgayDenNgay(6); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }

        private void btnUploadImages_Click(object sender, EventArgs e)
        {
            Form_HocVien_Chua_Upload_Images frm = new Form_HocVien_Chua_Upload_Images();
            frm.ShowDialog();
        }

        private void radGridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                if (radGridView1.CurrentColumn.Name == "btnAddImages" )
                {
                    openFileDialog.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|jpeg files (*.jpeg)|*.jpeg";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string strFileName = openFileDialog.FileName;

                        if (strFileName == string.Empty)
                            return;

                        urlPicture = strFileName;
                    }
                    if (Business_UploadFile())
                    {
                        radGridView1.CurrentRow.Cells["Anh"].Value = urlPicture;
                        if (listHV.IsDirty == true)
                        {
                            listHV.Save();
                            function.ItemFilterCondition_Int = nam;
                            function.ItemFilterCondition_String = dropDownLoaiHinhDaoTao1.Text;
                            function.ItemFilterCondition_Int2 = Convert.ToInt32(dropDownBoPhan1.Selected_ID);
                            listHV = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
                            bindingSourceHocVien.DataSource = listHV;
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void btnAnHocVien_Click(object sender, EventArgs e)
        {
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                    DT_LienTuc_HocVien_Info objHocvien = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                    int tslinthe = 0;
                    if (int.TryParse(objHocvien.TongSoLanInThe.ToString(), out tslinthe))
                    {
                        objHocvien.TongSoLanInThe = tslinthe + 1;
                    }

            }
            if (listHV != null && listHV.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn ẩn học viên trong danh sách học viên chưa in thẻ?", "Xác nhận hành động", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    listHV.Save();
                    GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.Hidesuccessfully);
                    LoadUS();
                }
            }
        }
    }
}
