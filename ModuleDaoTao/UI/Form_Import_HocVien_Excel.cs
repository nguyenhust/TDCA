using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using xls = Microsoft.Office.Interop.Excel;
using System.Linq;
using System.Threading.Tasks;
using ModuleDaoTao.LIB;
using NETLINK.LIB;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using Authoration.LIB;
using Telerik.WinControls.UI;

namespace ModuleDaoTao.UI
{
    public partial class Form_Import_HocVien_Excel : Telerik.WinControls.UI.RadForm
    {
        private string fileName;
        private DataTable data;
        public Form_Import_HocVien_Excel()
        {
            InitializeComponent();
            ThemCot();
        }

        private void readExcel()
        {
            if (fileName == null)
            {
                MessageBox.Show("Chưa chọn file Excel");
            }
            else
            {
                xls.Application ExcelApp = new xls.Application();
                // Kiểm tra xem có mở được file dữ liệu không
                try
                {
                    ExcelApp.Workbooks.Open(fileName);
                }
                catch
                {
                    MessageBox.Show("Không thể mở file dữ liệu");
                }
                // Tạo cấu trúc cho table
                data = new DataTable();
                data.Columns.Add("HoTen", typeof(string));
                data.Columns.Add("NgaySinh", typeof(string));
                data.Columns.Add("GioiTinh", typeof(string));
                data.Columns.Add("CMND", typeof(string));
                data.Columns.Add("NgayCap", typeof(string));
                data.Columns.Add("Tai", typeof(string));
                data.Columns.Add("TrinhDo", typeof(string));
                data.Columns.Add("ChuyenNganh", typeof(string));
                data.Columns.Add("TruongTotNghiep", typeof(string));
                data.Columns.Add("SoBang", typeof(string));
                data.Columns.Add("NamTotNghiep", typeof(string));
                data.Columns.Add("NoiCongTac", typeof(string));
                data.Columns.Add("TinhThanh", typeof(string));
                data.Columns.Add("DiaChiCoQuan", typeof(string));
                data.Columns.Add("BoPhanQuanLy", typeof(string));
                data.Columns.Add("HinhThucHoc", typeof(string));
                data.Columns.Add("NgayDangKy", typeof(string));
                data.Columns.Add("ChuyenKhoa", typeof(string));
                data.Columns.Add("NoiDungHoc", typeof(string));
                data.Columns.Add("TrangThai", typeof(string));
                data.Columns.Add("NgayBatDau", typeof(string));
                data.Columns.Add("NgayKetThuc", typeof(string));
                data.Columns.Add("SoTien", typeof(string));
                data.Columns.Add("IDNguoiQuanLy", typeof(Int64));
                // Đọc dữ liệu từng sheet của excel
                foreach (xls.Worksheet WSheet in ExcelApp.Worksheets)
                {
                    DataRow dr = data.NewRow();
                    // Tạo biến i để đọc từng dòng cỉa sheet excel
                    long i = 2;
                    try
                    {
                        do
                        {
                            if (WSheet.Range["A" + i].Value == null && WSheet.Range["B" + i].Value == null)
                            {
                                break; // nếu đến cuối dòng sheet thì dừng lại
                            }
                            dr = data.NewRow();
                            dr["HoTen"] = WSheet.Range["A" + i].Value.Trim();
                            dr["NgaySinh"] = WSheet.Range["B" + i].Value;
                            dr["GioiTinh"] = WSheet.Range["C" + i].Value;
                            dr["CMND"] = WSheet.Range["D" + i].Value;
                            dr["NgayCap"] = WSheet.Range["E" + i].Value;
                            dr["Tai"] = WSheet.Range["F" + i].Value;
                            dr["TrinhDo"] = WSheet.Range["G" + i].Value;
                            dr["ChuyenNganh"] = WSheet.Range["H" + i].Value;
                            dr["TruongTotNghiep"] = WSheet.Range["I" + i].Value;
                            dr["SoBang"] = WSheet.Range["J" + i].Value;
                            dr["NamTotNghiep"] = WSheet.Range["K" + i].Value;
                            dr["NoiCongTac"] = WSheet.Range["L" + i].Value;
                            dr["TinhThanh"] = WSheet.Range["M" + i].Value;
                            dr["DiaChiCoQuan"] = WSheet.Range["N" + i].Value;
                            dr["BoPhanQuanLy"] = WSheet.Range["O" + i].Value;
                            dr["HinhThucHoc"] = WSheet.Range["P" + i].Value.Trim();
                            dr["NgayDangKy"] = WSheet.Range["Q" + i].Value;
                            dr["ChuyenKhoa"] = WSheet.Range["R" + i].Value.Trim();
                            dr["NoiDungHoc"] = WSheet.Range["S" + i].Value.Trim();
                            dr["TrangThai"] = WSheet.Range["T" + i].Value;
                            dr["NgayBatDau"] = WSheet.Range["U" + i].Value;
                            dr["NgayKetThuc"] = WSheet.Range["V" + i].Value;
                            dr["SoTien"] = WSheet.Range["W" + i].Value;
                            dr["IDNguoiQuanLy"] = PTIdentity.IDNguoiDung;
                            data.Rows.Add(dr);
                            i++;
                        }
                        while (true);
                    }
                    catch
                    {
                        MessageBox.Show("Lối khi hiển thị");
                    }
                    ExcelApp.Workbooks.Close();
                }
            }
            
        }

        private void ThemCot()
        {
           // this.radGridViewDSHocVien.ShowGroupPanel = false;
            this.radGridViewDSHocVien.MasterTemplate.AllowAddNewRow = true;
            this.radGridViewDSHocVien.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            // thêm số thứ tự vào radgrid
            var lineNumbersColumn = new GridViewDecimalColumn(typeof(int), "STT", "STT");
            lineNumbersColumn.AllowSort = false;
            radGridViewDSHocVien.Columns.Add(lineNumbersColumn);
            this.radGridViewDSHocVien.Columns["STT"].MinWidth = 35;
            this.radGridViewDSHocVien.Columns["STT"].MaxWidth = 35;
            this.radGridViewDSHocVien.Columns["STT"].TextAlignment = ContentAlignment.TopCenter;
            this.radGridViewDSHocVien.Columns.Move(this.radGridViewDSHocVien.Columns["STT"].Index, 0);
        }
        private void DeleteTable()
        {
             using (SqlConnection con = new SqlConnection(NETLINK.LIB.DBConnection.Connection))
             {
                 con.Open();
                 using (SqlCommand cm = con.CreateCommand())
                 {
                     cm.CommandText = "DELETE FROM HocVienImport";
                     cm.CommandType = CommandType.Text;
                     cm.ExecuteScalar();
                 }
                 con.Close();
             }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            DeleteTable();
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Filter = " excel file |*.xls;*.xlsx";
            fDialog.FilterIndex = 1;
            fDialog.RestoreDirectory = true;
            fDialog.Multiselect = false;
            fDialog.Title = "Chọn file excel";
            //new chọn file thành công
            if(fDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = fDialog.FileName;
                // thực thi method readexcel
                readExcel();
                if (data != null)
                {
                    radGridViewDSHocVien.DataSource = data;

                }
                else
                {
                    MessageBox.Show("Không có dữ liệu");
                }

            }            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (data.Rows.Count > 0)
            {
                using (SqlConnection con = new SqlConnection(NETLINK.LIB.DBConnection.Connection))
                {
                    using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                    {
                        sqlBulkCopy.DestinationTableName = "dbo.HocVienImport";
                        sqlBulkCopy.ColumnMappings.Add("HoTen", "HoTen");
                        sqlBulkCopy.ColumnMappings.Add("NgaySinh", "NgaySinh");
                        sqlBulkCopy.ColumnMappings.Add("GioiTinh", "GioiTinh");
                        sqlBulkCopy.ColumnMappings.Add("CMND", "SoCMT");
                        sqlBulkCopy.ColumnMappings.Add("NgayCap", "NgayCap");
                        sqlBulkCopy.ColumnMappings.Add("Tai", "NoiCap");
                        sqlBulkCopy.ColumnMappings.Add("TrinhDo", "TrinhDo");
                        sqlBulkCopy.ColumnMappings.Add("ChuyenNganh", "ChuyenNganh");
                        sqlBulkCopy.ColumnMappings.Add("TruongTotNghiep", "TruongTotNghiep");
                        sqlBulkCopy.ColumnMappings.Add("SoBang", "SoBang");
                        sqlBulkCopy.ColumnMappings.Add("NamTotNghiep", "NamTotNghiep");
                        sqlBulkCopy.ColumnMappings.Add("NoiCongTac", "NoiCongTac");
                        sqlBulkCopy.ColumnMappings.Add("TinhThanh", "TinhThanh");
                        sqlBulkCopy.ColumnMappings.Add("DiaChiCoQuan", "DiaChiCoQuan");
                        sqlBulkCopy.ColumnMappings.Add("BoPhanQuanLy", "BoPhanQuanLy");
                        sqlBulkCopy.ColumnMappings.Add("HinhThucHoc", "HinhThucHoc");
                        sqlBulkCopy.ColumnMappings.Add("NgayDangKy", "NgayDangKy");
                        sqlBulkCopy.ColumnMappings.Add("ChuyenKhoa", "ChuyenKhoa");
                        sqlBulkCopy.ColumnMappings.Add("NoiDungHoc", "NoiDungHoc");
                        sqlBulkCopy.ColumnMappings.Add("TrangThai", "TrangThai");
                        sqlBulkCopy.ColumnMappings.Add("NgayBatDau", "NgayBatDau");
                        sqlBulkCopy.ColumnMappings.Add("NgayKetThuc", "NgayKetThuc");
                        sqlBulkCopy.ColumnMappings.Add("SoTien", "SoTien");
                        sqlBulkCopy.ColumnMappings.Add("IDNguoiQuanLy", "IDNguoiQuanLy");
                        con.Open();
                        sqlBulkCopy.WriteToServer(data);
                        con.Close();                        
                    }
                    //delete table import
                    con.Open();
                    using (SqlCommand cm = con.CreateCommand())
                    {
                        cm.CommandText = "HocVienImport_Ins";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.ExecuteScalar();
                    }
                    MessageBox.Show("Import thành công!");
                    data.Clear();
                    radGridViewDSHocVien.DataSource = data;
                }
            }
        }

        private void Form_Import_HocVien_Excel_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMyClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radGridViewDSHocVien_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.CellElement.ColumnInfo.Name == "STT" && string.IsNullOrEmpty(e.CellElement.Text))
            {
                e.CellElement.Text = (e.CellElement.RowIndex + 1).ToString();
            }
            //for (int i = 0; i < radGridViewDSHocVien.RowCount; i++)
            //{
            //    //radDS.Rows[i].Cells["btnDeleteRow"].Style.BackColor = Color.Red;
            //    //string str = radGridViewDSHocVien.Rows[i].Cells["NgayGiang"].Value.ToString().Substring(0, 10);
            //    if (Convert.ToString(radGridViewDSHocVien.Rows[i].Cells["NoiDungHoc"].Value) != GlobalCommon.getTenKhungLopHoc(Convert.ToString(radGridViewDSHocVien.Rows[i].Cells["NoiDungHoc"].Value), Convert.ToString(radGridViewDSHocVien.Rows[i].Cells["ChuyenKhoa"].Value)))
            //    {
            //        //radDS.Rows[i].Cells["NgayGiang"].Style.ForeColor = Color.Red;
            //        radGridViewDSHocVien.Rows[i].Cells["HoTen"].Style.ForeColor = Color.Red;
            //        radGridViewDSHocVien.Rows[i].Cells["NoiDungHoc"].Style.ForeColor = Color.Red;
            //    }
            //}

            //if (Convert.ToString(e.Row.Cells["ChuyenKhoa"].Value) != "" && Convert.ToString(e.Row.Cells["NoiDungHoc"].Value) != "")
            //{
            //    string str = GlobalCommon.getTenKhungLopHoc(Convert.ToString(e.Row.Cells["NoiDungHoc"].Value), Convert.ToString(e.Row.Cells["ChuyenKhoa"].Value));
            //    if (Convert.ToString(e.Row.Cells["NoiDungHoc"].Value) != GlobalCommon.getTenKhungLopHoc(Convert.ToString(e.Row.Cells["NoiDungHoc"].Value), Convert.ToString(e.Row.Cells["ChuyenKhoa"].Value)))
            //    {
            //        //e.CellElement.Font = new Font(e.CellElement.Font, FontStyle.Strikeout);
            //        e.CellElement.ForeColor = Color.Red;
            //    }
            //}
        }

        
        private void btnFileMau_Click(object sender, EventArgs e)
        {
            string fileExcel;
            fileExcel = AppConfig.ReportPath + "DL Test.xlsx";
            xls.Application xlapp;
            xls.Workbook xlworkbook;
            xlapp = new xls.Application();

            xlworkbook = xlapp.Workbooks.Open(fileExcel, 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

            xlapp.Visible = true;


            //var ExcelApp = new xls.Application();
            ////xls.Workbook work = ExcelApp.Workbooks;
            //ExcelApp.Workbooks.Open(AppConfig.ReportPath + "DL Test.xlsx");
            ////OpenFileDialog fDialog = new OpenFileDialog();
            ////if (fDialog.ShowDialog() == DialogResult.OK)
            ////{
            ////    string sourcePath = Application.StartupPath;
            ////    //xls.Application ExcelApp = new xls.Application();
            ////    //ExcelApp.Workbooks.Open(fileName);
            ////    //File.Copy(sourcePath + "\\filename.xls", fDialog.FileName);
            ////}
        }

        private void radGridViewDSHocVien_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            for (int i = 0; i < radGridViewDSHocVien.RowCount; i++)
            {
                if (Convert.ToString(radGridViewDSHocVien.Rows[i].Cells["NoiDungHoc"].Value) != GlobalCommon.getTenKhungLopHoc(Convert.ToString(radGridViewDSHocVien.Rows[i].Cells["NoiDungHoc"].Value), Convert.ToString(radGridViewDSHocVien.Rows[i].Cells["ChuyenKhoa"].Value)))
                {
                    //radDS.Rows[i].Cells["NgayGiang"].Style.ForeColor = Color.Red;
                    radGridViewDSHocVien.Rows[i].Cells["HoTen"].Style.ForeColor = Color.Red;
                    radGridViewDSHocVien.Rows[i].Cells["NoiDungHoc"].Style.ForeColor = Color.Red;
                }
            }
        }
    }
}
