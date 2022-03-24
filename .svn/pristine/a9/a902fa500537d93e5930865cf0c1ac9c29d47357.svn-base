using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ModuleDaoTao.LIB;
using NETLINK.LIB;
using NETLINK.UI.Form;
using Authoration.LIB;
using CrystalDecisions.CrystalReports.Engine;
using COMExcel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using ModuleHanhChinh.LIB;
using Telerik.WinControls.UI;
using NETLINK.LIB;
using ModuleDaoTao.LIB;

namespace TDCA.Report.BaoCaoForm
{
    public partial class FormHocVienDongHocPhi : NETLINK.UI.Dictionary
    {
        #region variables    
        int TraCuu;
        int TongSoHV;
        int selectHinhThuc;
        int LoaiHinh;
        int HocPhi;
        int selectLop = 0;
        string tenLop = string.Empty;
        private SeachHocVien_Coll obj;
        private BusinessFunction function;
       
      
        #endregion

        #region thông tin trên form 
        public FormHocVienDongHocPhi()
        {
            InitializeComponent();
            RadGrid = radGridView12;
            RadGrid.CellFormatting += radGridView_CellFormatting;
            RadGrid.CellDoubleClick += radGridView_CellDoubleClick;
            STT();          
            radTimKiem.Items[2].Selected = true;
            radHocPhi.Items[2].Selected = true;
            radHinhThuc.Items[0].Selected = true;
           
            btnSave.Enabled = true;
            radHocPhi.Enabled = false;
            radGridView12.AllowAddNewRow = false;          
        }
      
        private void EnableControl(bool _bool)
        {          
            dropDownChuyenKhoa1.Enabled = _bool;          
        }   
        private void radHinhThuc_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {        
            selectHinhThuc = radHinhThuc.SelectedIndex;
          
            if (selectHinhThuc == 1)
            {
             
              //  dropDownChuyenKhoa1.FillData(1);              
                radTimKiem.Enabled = true;
                radMaHocVien.Enabled = false;
                EnableControl(true);
                dropDownLopHocLienTucKhung1.Enabled = true;
            }
            else if (selectHinhThuc == 2)
            {
            
             //   dropDownChuyenKhoa1.FillData(1);
                radTimKiem.Enabled = true;
                radMaHocVien.Enabled = false;
                EnableControl(true);
                dropDownLopHocLienTucKhung1.Enabled = true;
            }    
            btnSave.Enabled = true;
        }
        private void XuatBaoCao(int total)
        {

            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {

                    cm.CommandText = "SeachHocVien_Get";
                
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.AddWithValue("@TimKiem", Convert.ToInt32(radTimKiem.SelectedIndex));
                    cm.Parameters.AddWithValue("@TrangThaiDHP", Convert.ToInt32(radHocPhi.SelectedIndex));
                    cm.Parameters.AddWithValue("@TuNgay", dtpTuNgay.Value);
                    cm.Parameters.AddWithValue("@DenNgay", dtpDenNgay.Value);
                    cm.Parameters.AddWithValue("@IDKhungLop", Convert.ToInt32(dropDownLopHocLienTucKhung1.Selected_ID));
                    cm.Parameters.AddWithValue("@IDChuyenKhoa", Convert.ToInt32(dropDownChuyenKhoa1.Selected_ID));
                    cm.Parameters.AddWithValue("@MaHocVien", radMaHocVien.Text);

                    if (selectHinhThuc == 0)
                        cm.Parameters.AddWithValue("@LoaiHinhDT", 0);
                    if (selectHinhThuc == 1)
                        cm.Parameters.AddWithValue("@LoaiHinhDT", 1);
                    if (selectHinhThuc == 2)
                    {
                        cm.Parameters.AddWithValue("@LoaiHinhDT", 2);
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cm))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds, "BaoCaoThuHocPhi");
                        if (ds.Tables[0].Rows.Count <= 0)
                        {
                            GlobalCommon.ShowError("Không có dữ liệu để báo cáo !", "Thông báo");
                            return;
                        }
                        else
                        {
                            int totalRows = ds.Tables[0].Rows.Count;
                            int totalColumns = ds.Tables[0].Columns.Count;

                            if (rdbPDF.IsChecked == true)
                            {
                                CreateFileReportOnCrystal(ds, totalRows);
                            }
                            else
                            {
                                CreateFileReportOnExcel(ds, totalRows, totalColumns, total);
                            }
                        }
                    }
                }
            }
        }
        private void CreateFileReportOnCrystal(DataSet ds, int totalRows)
        {
            PreviewReport PreviewReport = new PreviewReport();
            ReportDocument ReportDocument = new ReportDocument();
            ReportDocument.Load(AppConfig.ReportPath + "rptHocVienDongHocPhi_DTLT.rpt");
            ModuleHanhChinh.ThanhToan.BaoCao dsData = new ModuleHanhChinh.ThanhToan.BaoCao();
            ReportDocument.SetDataSource(dsData);
            ReportDocument.SetDataSource(ds);
            PreviewReport.crystalReportViewer.ReportSource = ReportDocument;
            if (selectHinhThuc == 0)
                ReportDocument.SetParameterValue("fmTenBaoCao", "BÁO CÁO TỔNG HỢP THU HỌC PHÍ ĐÀO TẠO");
            if (selectHinhThuc == 1)
                ReportDocument.SetParameterValue("fmTenBaoCao", "BÁO CÁO TỔNG HỢP THU HỌC PHÍ ĐÀO TẠO KÈM CẶP");
            if (selectHinhThuc == 2)
                ReportDocument.SetParameterValue("fmTenBaoCao", "BÁO CÁO TỔNG HỢP THU HỌC PHÍ ĐÀO TẠO THEO LỚP");
            ReportDocument.SetParameterValue("fmTuNgay", GlobalCommon.ConvertNgayBaoCao(dtpTuNgay.Value, dtpDenNgay.Value));
            //    ReportDocument.SetParameterValue("fmDenNgay", dtpDenNgay.Value.ToShortDateString());
            ReportDocument.SetParameterValue("fmNgayThangNam", " Ngày " + GlobalCommon.GetTimeServer().ToString("dd") + " Tháng " + GlobalCommon.GetTimeServer().ToString("MM") + " Năm " + GlobalCommon.GetTimeServer().ToString("yyyy"));
            ReportDocument.SetParameterValue("fmTenNguoiDung", PTIdentity.FullName);
            ReportDocument.SetParameterValue("fmTongSo", totalRows);
            ReportDocument.SetParameterValue("fmTenLop", "Lớp: " + tenLop);
            PreviewReport.ShowDialog();
        }
        #region Khởi  tạo file excel
        private void CreateFileReportOnExcel(DataSet ds, int totalRows, int totalColumns, int total)
        {
            DataRow dr;
            COMExcel.Application app = new COMExcel.Application();
            object valueMissing = System.Reflection.Missing.Value;

            COMExcel.Workbook exBook = app.Workbooks.Add(
            COMExcel.XlWBATemplate.xlWBATWorksheet);

            COMExcel.Worksheet sheet = (COMExcel.Worksheet)exBook.Worksheets[1];
            app.Visible = true;

            sheet.PageSetup.PaperSize = COMExcel.XlPaperSize.xlPaperA4;

            sheet.Range["A10", "I11"].HorizontalAlignment = 3;
            //sheet.Range["A1"].ColumnWidth = 2.29;
            //sheet.Range["B1"].ColumnWidth = 8;
            //sheet.Range["C1"].ColumnWidth = 8.57;
            //sheet.Range["D1"].ColumnWidth = 8;
            //sheet.Range["E1"].ColumnWidth = 4.43;
            //sheet.Range["F1"].ColumnWidth = 10.43;
            //sheet.Range["G1"].ColumnWidth = 6.29;
            //sheet.Range["H1"].ColumnWidth = 8.43;
            //sheet.Range["I1"].ColumnWidth = 9.57;


            sheet.Range["A1"].ColumnWidth = 3.43;
            sheet.Range["B1"].ColumnWidth = 9.14;
            sheet.Range["C1"].ColumnWidth = 8.43;
            sheet.Range["D1"].ColumnWidth = 8.43;
            sheet.Range["E1"].ColumnWidth = 10.43;
            sheet.Range["F1"].ColumnWidth = 8.43;
            sheet.Range["G1"].ColumnWidth = 10.43;
            sheet.Range["H1"].ColumnWidth = 9.43;
            sheet.Range["I1"].ColumnWidth = 8.43;
            //sheet.Range["J1"].ColumnWidth = 6.15;

            sheet.Range["A1", "D1"].MergeCells = true;
            sheet.Range["A1", "D1"].Value = "BỆNH VIỆN BẠCH MAI ";
            sheet.Range["A1", "D1"].WrapText = true;
            sheet.Range["A1", "D1"].HorizontalAlignment = 3;
            sheet.Range["A1", "D1"].Font.Bold = true;
            sheet.Range["A1", "I2"].Font.Size = 10;

            sheet.Range["A2", "E2"].MergeCells = true;
            sheet.Range["A2", "E2"].Value = "TRUNG TÂM ĐÀO TẠO VÀ CHỈ ĐẠO TUYẾN ";
            sheet.Range["A2", "E2"].WrapText = true;
            //     sheet.Range["A1", "J6"].HorizontalAlignment = 3;
            sheet.Range["A1", "I2"].Font.Size = 10;


            sheet.Range["A4", "I4"].MergeCells = true;
            sheet.Range["A4", "I4"].WrapText = true;
            sheet.Range["A4", "I4"].Font.Size = 11;
            sheet.Range["A4", "I4"].HorizontalAlignment = 3;
            if (selectHinhThuc == 0)
                sheet.Range["A4", "I4"].Value = "BÁO CÁO TỔNG HỢP THU HỌC PHÍ ĐÀO TẠO";
            sheet.Range["A4", "I4"].Font.Bold = true;
            if (selectHinhThuc == 1)
                sheet.Range["A4", "I4"].Value = "BÁO CÁO TỔNG HỢP THU HỌC PHÍ ĐÀO TẠO KÈM CẶP";
            sheet.Range["A4", "I4"].Font.Bold = true;
            if (selectHinhThuc == 2)
            {
                sheet.Range["A4", "I4"].Value = "BÁO CÁO TỔNG HỢP THU HỌC PHÍ ĐÀO TẠO THEO LỚP";
                sheet.Range["A4", "I4"].Font.Bold = true;
                //   sheet.Range["A8", "I8"].MergeCells = true;
                //   sheet.Range["A8", "I8"].Value = "Tên lớp: " + tenLop;
                //    sheet.Range["A8", "I8"].WrapText = true;
                //    sheet.Range["A8", "I8"].HorizontalAlignment = 1;
                //    sheet.Range["A8", "I8"].Font.Bold = true;
            }

            sheet.Range["A5", "I5"].MergeCells = true;
            sheet.Range["A5", "I5"].Value = "Thời gian: từ " + dtpTuNgay.Value.ToShortDateString() + " đến " + dtpDenNgay.Value.ToShortDateString();
            sheet.Range["A5", "I5"].WrapText = true;
            sheet.Range["A5", "I5"].Font.Size = 9;
            sheet.Range["A5", "I5"].HorizontalAlignment = 3;

            sheet.Range["A10", "I11"].HorizontalAlignment = 3;
            sheet.Range["A10", "I11"].Font.Bold = true;
            sheet.Range["A10", "I11"].WrapText = true;


            sheet.Range["A10", "A11"].MergeCells = true;
            sheet.Range["A10", "A11"].Value = "STT";
            sheet.Range["B10", "B11"].MergeCells = true;
            sheet.Range["B10", "B11"].Value = "Ngày/Tháng/Năm";
            sheet.Range["C10", "C11"].MergeCells = true;
            sheet.Range["C10", "C11"].Value = "Mã Biên Lai";
            sheet.Range["D10", "D11"].MergeCells = true;
            sheet.Range["D10", "D11"].Value = "Hình Thức Học";
            sheet.Range["E10", "E11"].MergeCells = true;
            sheet.Range["E10", "E11"].Value = "Mã Học Viên";
            sheet.Range["F10", "F11"].MergeCells = true;
            sheet.Range["F10", "F11"].Value = "Họ Và Tên";
            sheet.Range["G10", "G11"].MergeCells = true;
            sheet.Range["G10", "G11"].Value = "Nội Dung";
            sheet.Range["H10", "H11"].MergeCells = true;
            sheet.Range["H10", "H11"].Value = "Chuyên Khoa Đào Tạo";
            sheet.Range["I10", "I11"].MergeCells = true;
            sheet.Range["I10", "I11"].Value = "Số Tiền";


            for (int i = 0; i < totalRows; i++)
            {
                dr = ds.Tables[0].Rows[i];

                sheet.Range["A" + (total)].Value = i + 1;
                for (int j = 0; j < totalColumns; j++)
                {
                    sheet.Cells[total, j + 2] = dr.ItemArray.GetValue(j);
                }
                total++;
            }

            sheet.Range["A10", "I" + total].VerticalAlignment = 2;
            sheet.Range["A" + (total + 1), "I" + (total + 1)].Font.Bold = true;
            sheet.Range["A" + (total), "G" + (total)].MergeCells = true;
            sheet.Range["A" + (total), "G" + (total)].Font.Bold = true;
            sheet.Range["A" + (total), "G" + (total)].Value = "TỔNG TIỀN ĐÃ ĐÓNG:";

            sheet.Range["H" + (total), "I" + (total)].MergeCells = true;
            sheet.Range["H" + (total), "I" + (total)].Font.Bold = true;
            sheet.Range["H" + (total), "I" + (total)].Formula = "=Sum(I12:I" + (total) + ")";

            //sheet.Range["A" + (total + 3), "C" + (total + 3)].MergeCells = true;
            //    sheet.Range["A" + (total + 3), "C" + (total + 3)].Value = "Tổng số:" + totalRows;
            sheet.Range["F" + (total + 2), "I" + (total + 2)].MergeCells = true;
            sheet.Range["F" + (total + 2), "I" + (total + 2)].HorizontalAlignment = 3;
            sheet.Range["F" + (total + 2), "I" + (total + 2)].Value = "Hà Nội,  Ngày " + GlobalCommon.GetTimeServer().ToString("dd") + " Tháng " + GlobalCommon.GetTimeServer().ToString("MM") + " Năm " + GlobalCommon.GetTimeServer().ToString("yyyy");

            sheet.Range["A" + (total + 4), "I" + (total + 8)].HorizontalAlignment = 3;
            sheet.Range["A" + (total + 4), "I" + (total + 4)].Font.Bold = true;
            sheet.Range["A" + (total + 4), "I" + (total + 4)].Font.Size = 10;
            //sheet.Range["A" + (total + 5), "C" + (total + 5)].MergeCells = true;
            // sheet.Range["A" + (total + 5), "C" + (total + 5)].Value = "KIỂM SOÁT NỘI BỘ";
            // sheet.Range["D" + (total + 5), "F" + (total + 5)].MergeCells = true;
            // sheet.Range["D" + (total + 5), "F" + (total + 5)].Value = "LÃNH ĐẠO TRUNG TÂM";
            sheet.Range["F" + (total + 3), "I" + (total + 3)].MergeCells = true;
            sheet.Range["F" + (total + 3), "I" + (total + 3)].HorizontalAlignment = 3;
            sheet.Range["F" + (total + 3), "I" + (total + 3)].Value = "NGƯỜI LẬP BIỂU";

            sheet.Range["A1", "I" + (total + 11)].Font.Name = "Times New Roman";
            sheet.Range["A10", "I" + (total)].Font.Size = 9;
            sheet.Range["A10", "I" + (total)].WrapText = true;
            sheet.Range["A10", "I" + (total - 1)].HorizontalAlignment = 3;
            sheet.Range["A10", "I" + (total)].Borders.LineStyle = 1;

            sheet.Range["F" + (total + 6), "I" + (total + 6)].Font.Bold = true;
            sheet.Range["F" + (total + 6), "I" + (total + 6)].Font.Size = 9;
            sheet.Range["F" + (total + 6), "I" + (total + 6)].MergeCells = true;
            sheet.Range["F" + (total + 6), "I" + (total + 6)].HorizontalAlignment = 3;
            sheet.Range["F" + (total + 6), "I" + (total + 6)].Value = PTIdentity.FullName;
        }
        #endregion
        private void dropDownChuyenKhoa1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dropDownChuyenKhoa1.Selected_ID;
                BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForDropDownWithCondition);
                function.ItemID = id;
                DT_LienTuc_KhungLopHoc_Coll coll = DT_LienTuc_KhungLopHoc_Coll.GetDT_LienTuc_KhungLopHoc_Coll(function);
                dropDownLopHocLienTucKhung1.FillData(coll);
            }
            catch (Exception)
            {
                //GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void dropDownLopHocLienTucKhung1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectLop = (int)dropDownLopHocLienTucKhung1.Selected_ID;
                tenLop = dropDownLopHocLienTucKhung1.Selected_TextValue.ToString();
            }
            catch (Exception) { }
        }
        #region Override
        protected override void Save()
        {           
                TraCuu = radTimKiem.SelectedIndex;
                ModuleHanhChinh.LIB.SeachHocVien_Coll.So = radTimKiem.SelectedIndex;
                obj = SeachHocVien_Coll.GetSeachHocVien_Coll_NgayBatDau(Convert.ToInt32(radTimKiem.SelectedIndex), Convert.ToInt32(radHocPhi.SelectedIndex), Convert.ToString(radMaHocVien.Text), dtpTuNgay.Value, dtpDenNgay.Value, Convert.ToInt32(dropDownChuyenKhoa1.Selected_ID), Convert.ToInt32(dropDownLopHocLienTucKhung1.Selected_ID), Convert.ToInt32(radHinhThuc.SelectedIndex));                                               
                RadGrid.DataSource = obj;
                TotalRecordValue = obj.Count.ToString();
        }      
        private void radTimKiem_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {         
            TraCuu = radTimKiem.SelectedIndex;
            if(TraCuu==0)
            {
                dropDownChuyenKhoa1.Enabled = false;
                dropDownLopHocLienTucKhung1.Enabled = false;
                radHocPhi.Enabled = false;
                radMaHocVien.Enabled = true;
                radHinhThuc.Enabled = false;
            }

           if (TraCuu == 1)
            {
                dropDownChuyenKhoa1.FillData(1);
                radMaHocVien.Text = string.Empty;
                dropDownChuyenKhoa1.Enabled = true;
                dropDownLopHocLienTucKhung1.Enabled = true;
                radHocPhi.Enabled = false;
                radHinhThuc.Enabled = true;
               

            }
            else if (TraCuu == 2 )
            {        
                radMaHocVien.Text = string.Empty;
                dropDownChuyenKhoa1.Enabled = false;
                dropDownLopHocLienTucKhung1.Enabled = false;
                radHocPhi.Enabled = false;
                radMaHocVien.Enabled = false;
                radHinhThuc.Text = string.Empty;
                radHinhThuc.Enabled = false;
            }
        }   
        private void radGridView_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }
         private void radGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {

        }
        private void FormHocVienDongHocPhi_Shown(object sender, EventArgs e)
        {
     
        }      
        #endregion
        #region Đếm số lượng học viên
         public string TotalRecordValue
       {
            get { return lblTongSo.Text; }
            set {  lblTongSo.Text = "Tổng số học viên :" + value + "    ";}
        }
        void _RadGrid_FilterChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            CaculateTongSo();
        }
        private void CaculateTongSo()
        {
            if (RadGrid != null)
            {
                int TongSo = 0;
                foreach (GridViewRowInfo rowInfo in RadGrid.ChildRows)
                {
                    if (rowInfo.IsVisible)
                        TongSo++;
                }
               lblTongSo.Text = "Tổng số học viên :" + TongSo.ToString() + "    ";
            }
        }
       #endregion
        private void radButton1_Click(object sender, EventArgs e)
        {
            int total = 12;
            XuatBaoCao(total);
        }
        private bool Business_ValidateDataBeforeSave()
        {
            if (GlobalCommon.CheckArrayTextIsNull(new object[] { radHinhThuc.Text}))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            return true;
        }      
        private void radHocPhi_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {             
            HocPhi = radHocPhi.SelectedIndex;         
        }
        #endregion
    }
}
