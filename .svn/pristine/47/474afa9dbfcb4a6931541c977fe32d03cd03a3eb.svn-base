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
using DanhMuc.LIB;
using ExportLib;

namespace ModuleDaoTao.UserControls
{
    public partial class GridHocVienLienTucDiem : UsDictionary
    {
        #region variables
        
        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        private bool isSaved = true;
        private int Mode; // da dong hoc phi hay chua
        private string _malop= string.Empty;

        #endregion

        public GridHocVienLienTucDiem(int mode)
        { 
            this.Mode = mode; 
           
            InitializeComponent();
            RadGrid = radGridView1;
            RadGrid.CellFormatting += radGridView1_CellFormatting;
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            STT();
            HideDelete();
            PrintToShow();
            //ShowPrint5 = true;
            //TextPrint5 = " Kem Cap";
            if (this.Mode == DT_Common.DIEM_THEOLOP)
            {
                ShowPrint6 = true;
                TextPrint6 = " In DSHVTL được cấp chứng chỉ ";
                radLabelChonLop.Visible = true;
                dropDownLopHocLienTuc1.Visible = true;
                radLabelNgayHoc.Visible = false;
                netLink_DatePickerNgayHoc.Visible = false;
                dropDownNam1.Visible = false;
            }

            else
            {
                ShowPrint5 = true;
                TextPrint5 = " In DSHVKC được cấp chứng chỉ";
                radLabelChonLop.Visible = false;
                dropDownLopHocLienTuc1.Visible = false;
                dropDownChuyenNganh.Visible = false;
                radLabel1.Visible = false;
                radLabelNgayHoc.Visible = false;
                netLink_DatePickerNgayHoc.Visible = false;
                dropDownNam1.FillData();
                dropDownNam1.Text = GlobalCommon.GetTimeServer().Year.ToString();
                
            }
            LoadUS();
        }

        public GridHocVienLienTucDiem(string malop)
        {
            InitializeComponent();
            RadGrid = radGridView1;
            RadGrid.CellFormatting += radGridView1_CellFormatting;
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            STT();
            HideDelete();
            this._malop = malop; 
            radLabelChonLop.Visible = false;
            dropDownLopHocLienTuc1.Visible = false;
            dropDownChuyenNganh.Visible = false;
            radLabel1.Visible = false;
            radLabelNgayHoc.Visible = false;
            netLink_DatePickerNgayHoc.Visible = false;
            radChonNam.Visible = false;
            radtxtNam.Visible = false;
            ShowPrint6 = true;
            TextPrint6 = " In DSHVTL được cấp chứng chỉ ";
            try
            {
                    BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDTLienTuc_DiemTheoLop);
                    if (GlobalCommon.IsHavePermission(string.Empty))
                        function.ItemID = -1;
                    else
                        function.ItemID = (int)PTIdentity.IDNguoiDung;
                    function.Item = malop;
                    bindingSourceHocVien.DataSource = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
                
                TotalRecordValue = radGridView1.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        #region Override

        public override object GetIdValue()
        {
            if (Mode == DT_Common.DIEM_THEOLOP)
                return TextMessages.ControlID.DT_HocVienLienTuc_DiemTheoLop;
            else
                return TextMessages.ControlID.DT_HocVienLienTuc_DiemKemCap;
        }

        public override string ToString()
        {
            if (Mode == DT_Common.DIEM_KEMCAP)
                return TextMessages.FormTitle.DT_HocVienLienTuc_DiemKemCap;
            else
                return TextMessages.FormTitle.DT_HocVienLienTuc_DiemTheoLop;
        }
        
        protected override void ApplyAuthorizationRules()
        {
            // nếu có được quyền tối thiểu thì cho phép vào form
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_QuanLyDiem_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_QuanLyDiem_Print);
            //bl_In = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_QuanLyDiem_Print);
            bl_btnMyClose = true;
           
           // bl_btnVisbleMyClose = false;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_QuanLyDiem_Delete);
        }

        
        protected override void Save()
        {
            try
            {
                DT_LienTuc_HocVien_Coll hocVienColl = (DT_LienTuc_HocVien_Coll)bindingSourceHocVien.DataSource;
                hocVienColl.Save();
                isSaved = true;
                GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
                
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        protected override void LoadUS()
        {
           if(_malop == "")
            try
            {
                bl_btnDelete = false;
                bl_btnPrint = false;
                bl_btnSave = false;
                //bl_In = false;
                if (!GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_QuanLyDiem_View))
                {
                    bl_btnDelete = false;
                    bl_btnPrint = false;
                    bl_btnSave = false;
                    //bl_In = false;
                    throw new Exception(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
                }
                else
                {
                    BusinessFunction function = null;
                    if (Mode == DT_Common.DIEM_THEOLOP)
                    {
                        //dropDownChuyenNganh.DataSource = DIC_ChuyenKhoa_Coll.GetDIC_ChuyenKhoa_Coll();
                        
                        dropDownLopHocLienTuc1.FillData();
                    }
                    else
                    {
                        bindingSourceHocVien.DataSource = DT_LienTuc_HocVien_Coll.NewDT_LienTuc_HocVien_Coll();
                        function = new BusinessFunction(BusinessFunctionMode.GetDTLienTuc_DiemKemCap);
                        //Nếu là user sysman thì có quyền xem toàn bộ
                        if (GlobalCommon.IsHavePermission(string.Empty))
                            function.ItemID = -1;
                        else
                            function.ItemID = (int)PTIdentity.IDNguoiDung;
                        int nam = 0;
                        if (int.TryParse(dropDownNam1.Text == "Tất cả" ? "0" : dropDownNam1.Text, out nam))
                        {
                            function.ItemSoNam = int.Parse(dropDownNam1.Text == "Tất cả" ? "0" : dropDownNam1.Text);
                            bindingSourceHocVien.DataSource = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
                        }
                    }
                    TotalRecordValue = radGridView1.Rows.Count.ToString(); 
                }

                if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_QuanLyDiem_Print))
                    bl_btnPrint = true;
                //if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_QuanLyDiem_Print))
                //    bl_In = true;
                if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_QuanLyDiem_Insert))
                    bl_btnDelete = true;
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Print()
        {
            try
            {
                //if (!isSaved)
                //{
                //    if (GlobalCommon.ShowInformation_YesNo("Bạn chưa lưu, Bạn có muốn lưu không?"))
                //    {
                //        Save();
                //    }
                //}
                PrintToHTML();
                LoadUS();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        protected override void Print5()
        {
            try
            {
                //if (!issaved)
                //{
                //    if (globalcommon.showinformation_yesno("bạn chưa lưu, bạn có muốn lưu không?"))
                //    {
                //        save();
                //    }
                //}
                PrintToHTMLKemCapDaHocDuocCapChungChi();
                LoadUS();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        protected override void Print6()
        {
            try
            {
                //if (!issaved)
                //{
                //    if (globalcommon.showinformation_yesno("bạn chưa lưu, bạn có muốn lưu không?"))
                //    {
                //        save();
                //    }
                //}
                PrintToHTMLTheoLopDuocCapChungChi();
                LoadUS();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void PrintToHTMLKemCapDaHocDuocCapChungChi()
        {

            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();

            cv.E_TieuDe = new List<string>() { "Họ tên", "Ngày sinh", "Trình độ", "Đơn vị công tác", "Nội dung học", "Chuyên Khoa", "Số tiết", "Xếp loại", "Từ ngày", "Đến ngày" };
            cv.E_Phong1 = "P.GĐ TRUNG TÂM ĐÀO TẠO VÀ CHỈ ĐẠO TUYẾN";
            cv.E_Phong2 = "VĂN PHÒNG TRUNG TÂM";
            cv.E_FilterExpression = this.FilterExpression;
            string PhongBan = string.Empty;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible && rowInfo.Cells["XepLoai"].Value != "")
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
        private void PrintToHTMLTheoLopDuocCapChungChi()
        {

            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B103_HVduoccapchungchitheolop cv = new ExportLib.Entities.HanhChinh.B103_HVduoccapchungchitheolop();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B103_Table>();

            cv.E_TieuDe = new List<string>() { "Họ tên", "Ngày sinh", "Trình độ", "Nơi công tác", "Xếp loại" };
            cv.E_Phong1 = "P.GĐ TRUNG TÂM ĐÀO TẠO VÀ CHỈ ĐẠO TUYẾN";
            cv.E_Phong2 = "VĂN PHÒNG TRUNG TÂM<br></br>";
            cv.E_FilterExpression = this.FilterExpression;
            string PhongBan = string.Empty;
            string TenLop = string.Empty;
            string MaLop = string.Empty;
            string SoTiet = string.Empty;
            string TuNgay = string.Empty;
            string DenNgay = string.Empty;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible && rowInfo.Cells["XepLoai"].Value != "")
                {
                    DT_LienTuc_HocVien_Info itemInfo = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B103_Table cvItem = new ExportLib.Entities.HanhChinh.B103_Table();

                    cvItem.E_Value = new List<string>() { itemInfo.HoTen, itemInfo.NgaySinh, itemInfo.TenTrinhDo, itemInfo.NoiCongTac, "<align:center; >" + itemInfo.XepLoai };

                    cv.E_Content.Add(cvItem);
                    PhongBan = itemInfo.TenPhongQuanLy;
                    TenLop = itemInfo.NoiDungDaoTao;
                    MaLop = itemInfo.MaLopHoc;
                    SoTiet = Convert.ToString(itemInfo.SoTiet);
                    TuNgay = itemInfo.NgayBatDau;
                    DenNgay = itemInfo.NgayKetThuc;
                }
            }
            cv.E_HaNoiNgayThangNam = string.Empty;
            cv.E_ThongTinTongHop = "";
            cv.E_CongHoaXaHoi = string.Empty;
            cv.E_DocLapTuDo = string.Empty;
            cv.E_TieuDeBaoCao = "Danh sách đề nghị cấp chứng chỉ/Chứng nhận";
            cv.E_TenTrungTamLapBC = "CÁN BỘ QUẢN LÝ<br></br>";
            cv.E_NguoiKi = "<b>" + PTIdentity.FullName + "<b>";
            cv.E_TenTrungTam = "TRUNG TÂM ĐÀO TẠO VÀ CHỈ ĐẠO TUYẾN";
            DateTime today = DateTime.Now;
            cv.E_TuNgayDenNgay = "Từ ngày " + TuNgay + " đến ngày " + DenNgay;
            cv.E_TieuDeLop = "<b>" + TenLop + "</b>";
            cv.E_MaLop = "<b>" + "( " + MaLop + " )" + "</b>";
            cv.E_SoTiet = "Tổng số tiết: " + SoTiet;
            cv.E_QuyetDinh = "( Kèm &nbsp;theo&nbsp;Quyết&nbsp;định&nbsp;số&nbsp;&nbsp;&nbsp;&nbsp;/" + today.Year + "/QĐ-TDC &nbsp;&nbsp;&nbsp;ngày&nbsp;&nbsp;&nbsp;&nbsp; tháng &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;năm&nbsp;" + today.Year + ")";
            cv.E_CongHoaXaHoi = "BM.09.07";
            cv.E_P1 = "<b>" + " ThS. Nguyễn Thị Mỹ Châu" + "<b>";
            cv.E_P2 = "<b>" + " CN. Nguyễn Thị Hạnh" + "<b>";
            //cv.ProcessTuNgayDenNgay(6); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B103_GenReport(cv);
        }
        protected override void Delete()
        {
            try
            {
                if (int.TryParse(radGridView1.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    DT_LienTuc_HocVien.DeleteDT_LienTuc_HocVien(selectedID);
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void MyClose()
        {
            if (!isSaved)
            {
                if (GlobalCommon.ShowInformation_YesNo("Bạn chưa lưu, Bạn có muốn lưu không?"))
                {
                    Save();
                }
            }
            this.Close();
        }

        #endregion

        private void radGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(radGridView1.CurrentRow.Cells["Id"].Value.ToString(), out selectedID)
                    && GlobalCommon.IsHavePermission(new string[]{TextMessages.RolePermission.DT_LT_QuanLyDiem_View,TextMessages.RolePermission.DT_LT_QuanLyDiem_Edit}))
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

        private void dropDownLopHocLienTuc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DT_LienTuc_LopHoc_Info lophoc = (DT_LienTuc_LopHoc_Info)dropDownLopHocLienTuc1.Selected_Item;
                if (lophoc != null)
                {
                    BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDTLienTuc_DiemTheoLop);
                    if (GlobalCommon.IsHavePermission(string.Empty))
                        function.ItemID = -1;
                    else
                        function.ItemID = (int)PTIdentity.IDNguoiDung;
                    function.Item = lophoc.MaLop;
                    bindingSourceHocVien.DataSource = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
                }
                TotalRecordValue = radGridView1.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radGridView1_CellEndEdit_1(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                // just save when HoaDonHocPhi
                if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_QuanLyDiem_Edit))
                {
                    DT_LienTuc_HocVien_Info item = (DT_LienTuc_HocVien_Info)e.Row.DataBoundItem;
                    XepLoai(item);
                    isSaved = false;
                }
            }
            catch (Exception ex)
            {
                radGridView1.CancelEdit();
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void XepLoai(DT_LienTuc_HocVien_Info item) {
            double tong = 0;
            int   count = 0;

            if (item.DiemThi.HasValue && item.DiemThi > 0) {
                tong += (double)item.DiemThi;
                count++;
            }

            if (item.Lan1.HasValue && item.Lan1 > 0)
            {
                tong += (double)item.Lan1;
                count++;
            }
            
            if (item.Lan2.HasValue && item.Lan2 > 0)
            {
                tong += (double)item.Lan2;
                count++;
            }

            if (item.Lan3.HasValue && item.Lan3 > 0)
            {
                tong += (double)item.Lan3;
                count++;
            }

            if (item.DiemThi.HasValue && item.Lan4 > 0)
            {
                tong += (double)item.Lan4;
                count++;
            }

            if (item.DiemThi.HasValue && item.Lan5 > 0)
            {
                tong += (double)item.Lan5;
                count++;
            }
            if (tong > 0 && count > 0)
            {
                double average = tong / count;
                average = Math.Round(average,2);

                if (average >= TextMessages.HocVienXepLoaiValue.XepLoai_XSac)
                    item.XepLoai = TextMessages.HocVienXepLoai.XepLoai_XSac;
                else if (average >= TextMessages.HocVienXepLoaiValue.XepLoai_Gioi)
                    item.XepLoai = TextMessages.HocVienXepLoai.XepLoai_Gioi;
                else if (average >= TextMessages.HocVienXepLoaiValue.XepLoai_Kha)
                    item.XepLoai = TextMessages.HocVienXepLoai.XepLoai_Kha;
                else if (average >= TextMessages.HocVienXepLoaiValue.XepLoai_TrungBinhKha)
                    item.XepLoai = TextMessages.HocVienXepLoai.XepLoai_TrungBinhKha;
                else if (average >= TextMessages.HocVienXepLoaiValue.XepLoai_TrungBinh)
                    item.XepLoai = TextMessages.HocVienXepLoai.XepLoai_TrungBinh;
                else
                    item.XepLoai = TextMessages.HocVienXepLoai.XepLoai_Yeu;
            }
        }
        private void PrintToHTML()
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Họ tên", "Ngày bắt đầu", "Trình độ", "LT1","LT2","TH1","TH2","TH3","TH4","Xếp Loại" };
            cv.E_FilterExpression = this.FilterExpression;
            string PhongBan = string.Empty;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    DT_LienTuc_HocVien_Info itemInfo = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { itemInfo.HoTen, itemInfo.NgayBatDau, itemInfo.TenTrinhDo, itemInfo.Lan1.ToString(), itemInfo.Lan3.ToString(), itemInfo.DiemThi.ToString(), itemInfo.Lan2.ToString(), itemInfo.Lan4.ToString(), itemInfo.Lan5.ToString(), itemInfo.XepLoai.ToString() };
                    cv.E_Content.Add(cvItem);
                    cv.E_TieuDeLop = itemInfo.TenLopHoc;
                    cv.E_MaLop = "("+itemInfo.MaLopHoc+")";
                    PhongBan = itemInfo.TenPhongQuanLy;
                }
            }
            cv.E_TieuDeBaoCao = "Danh sách điểm học viên";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TenTrungTam = PhongBan;
            cv.ProcessTuNgayDenNgay(1); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }

        private void radGridView1_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }
        public void BinData(int nam, long id)
        {
            try
            {
                if (nam > 2010)
                {
                    DT_LienTuc_LopHoc_Coll item = DT_LienTuc_LopHoc_Coll.GetDT_LienTuc_LopHoc_Coll(nam, id);
                    dropDownLopHocLienTuc1.DataSource = item;
                    dropDownLopHocLienTuc1.DisplayMember = "TenLop";
                    dropDownLopHocLienTuc1.ValueMember = "MaLop";
                }
            }
            catch (Exception ex)
            {
                dropDownLopHocLienTuc1.DataSource = null;
            }
        }

        private void dropDownChuyenNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BinData(Convert.ToInt32(radtxtNam.Text), Convert.ToInt64(dropDownChuyenNganh.SelectedValue));
            }
            catch (Exception ex)
            { }
        }

        private void radGridView1_RowValidated(object sender, Telerik.WinControls.UI.RowValidatedEventArgs e)
        {            
        }

        private void netLink_DatePickerNgayHoc_TextChanged(object sender, EventArgs e)
        {
            LoadUS();
        }

        private void radtxtNam_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void netLink_DatePickerNgayHoc_MouseLeave(object sender, EventArgs e)
        {
            LoadUS();
        }

        private void radtxtNam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (this.Mode == DT_Common.DIEM_THEOLOP)
                {
                    try
                    {
                        BinData(Convert.ToInt32(radtxtNam.Text), Convert.ToInt64(dropDownChuyenNganh.SelectedValue));
                    }
                    catch (Exception ex)
                    { }
                }
                else
                {
                    LoadUS();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUS();
        }

    }
}
