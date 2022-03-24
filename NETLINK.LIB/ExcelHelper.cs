using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;
using sys= System.Data;

namespace NETLINK.LIB
{


    public class ExcelHelper
    {
        private Workbook MyBook = null;
        private Application MyApp = null;
        private Worksheet MySheet = null;

        public ExcelHelper()
        {
            MyApp = new     Application();

        }

        public List<ChamCongNhanVien> ReadExcel(string fileName)
        {
            List<ChamCongNhanVien> chamCong = new List<ChamCongNhanVien>();
            ChamCongNhanVien obj = null;
            MyApp.Visible = false;
            MyBook = MyApp.Workbooks.Open(fileName);
            MySheet = (Worksheet)MyBook.Sheets[1]; // Explicit cast is not required here
            int lastRow = MySheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell).Row;

            int i = 0;
            for (int index = 2; index <= lastRow; index++)
            {
                System.Array MyValues = (System.Array)MySheet.get_Range("A" +
                        index.ToString(), "P" + index.ToString()).Cells.Value;
                if (MyValues.GetValue(1,1) == null)
                    continue;

                string firstColumn = ConverterUnicode.VniToKD(MyValues.GetValue(1,1).ToString());

                if (string.IsNullOrEmpty(firstColumn))
                    continue;

                if (firstColumn.Contains("Mã nhân viên")) {
                    i = 1;
                    if (obj != null)
                        chamCong.Add(obj);
                    obj = new ChamCongNhanVien();
                    getInfo(firstColumn, ref obj);
                }else if (firstColumn.StartsWith("Giờ")){
                    string gio = MyValues.GetValue(1, 3).ToString().Trim();
                    obj.Gio = float.Parse(gio);
                    if (MyValues.GetValue(1, 8) != null) {
                        obj.VeTre = int.Parse(MyValues.GetValue(1, 8).ToString().Trim());
                    }

                    if (MyValues.GetValue(1, 12) != null)
                    {
                        obj.Phuttre = int.Parse(MyValues.GetValue(1, 12).ToString().Trim());
                    }
                }
                else if (firstColumn.StartsWith("Công")) {
                    string cong = MyValues.GetValue(1, 3).ToString().Trim();
                    obj.Cong = float.Parse(cong);
                    if (MyValues.GetValue(1, 8) != null)
                    {
                        obj.VeSom = int.Parse(MyValues.GetValue(1, 8).ToString().Trim());
                    }

                    if (MyValues.GetValue(1, 12) != null)
                    {
                        obj.PhutSom = int.Parse(MyValues.GetValue(1, 12).ToString().Trim());
                    }
                }
                else if (firstColumn.StartsWith("Ngoài giờ")) {
                    string ngoaigio = MyValues.GetValue(1, 3).ToString().Trim();
                    obj.Ngoaigio = float.Parse(ngoaigio);

                    if (MyValues.GetValue(1, 8) != null)
                    {
                        obj.VangKoPhep = int.Parse(MyValues.GetValue(1, 8).ToString().Trim());
                    }

                    if (MyValues.GetValue(1, 12) != null)
                    {
                        obj.VangCoPhep = int.Parse(MyValues.GetValue(1, 12).ToString().Trim());
                    }
                }
                else if (firstColumn.StartsWith("Chủ nhật"))
                {
                    string chunhat = MyValues.GetValue(1, 3).ToString().Trim();
                    obj.chunhat = chunhat;
                }
                else if (firstColumn.StartsWith("BẢNG CHI TIẾT")) {
                    continue;
                }

                if (i >= 7) { 
                    // start read ngay cong
                    NgayCong cong = new NgayCong();
                    cong.Ngay = Convert.ToDateTime(MyValues.GetValue(1, 1));
                    cong.Thu = MyValues.GetValue(1, 2) != null ? MyValues.GetValue(1, 2).ToString() : string.Empty;
                    cong.Thu = ConverterUnicode.VniToKD(cong.Thu);
                    cong.ThoigianVao1 = MyValues.GetValue(1, 3) != null ? MyValues.GetValue(1, 3).ToString() : string.Empty;
                    cong.Thoigianra1 = MyValues.GetValue(1, 4) != null ? MyValues.GetValue(1, 4).ToString() : string.Empty;
                    
                    cong.ThoigianVao2 = MyValues.GetValue(1, 5) != null ? MyValues.GetValue(1, 5).ToString() : string.Empty;
                    cong.Thoigianra2 = MyValues.GetValue(1, 6) != null ? MyValues.GetValue(1, 6).ToString() : string.Empty;
                    
                    cong.ThoigianVao3 = MyValues.GetValue(1, 7) != null ? MyValues.GetValue(1, 7).ToString() : string.Empty;
                    cong.Thoigianra3 = MyValues.GetValue(1, 8) != null ? MyValues.GetValue(1, 8).ToString() : string.Empty;

                    cong.ThoigianTre = MyValues.GetValue(1, 9) != null ?  int.Parse(MyValues.GetValue(1, 9).ToString().Trim()) : 0;
                    cong.ThoigianSom = MyValues.GetValue(1, 10) != null ? int.Parse(MyValues.GetValue(1, 10).ToString().Trim()) : 0;
                    cong.VeTre = MyValues.GetValue(1, 11) != null ? int.Parse(MyValues.GetValue(1, 11).ToString().Trim()) : 0;
                    cong.TongGio = MyValues.GetValue(1, 12) != null ? float.Parse(MyValues.GetValue(1, 12).ToString().Trim()) : 0;
                    cong.Cong = MyValues.GetValue(1, 13) != null ? float.Parse(MyValues.GetValue(1, 13).ToString().Trim()) : 0;
                    cong.TCA1 = MyValues.GetValue(1, 14) != null ? float.Parse(MyValues.GetValue(1, 14).ToString().Trim()) : 0;
                    cong.TCA2 = MyValues.GetValue(1, 15) != null ? float.Parse(MyValues.GetValue(1, 15).ToString().Trim()) : 0;
                    cong.KyHieu = MyValues.GetValue(1, 16) != null ? MyValues.GetValue(1, 16).ToString().Trim() : string.Empty;

                    obj.ngayCong.Add(cong);
                }
                i++;
            }

            MyBook.Close();
            MyApp.Quit();

            if (obj != null)
                chamCong.Add(obj);
            return chamCong;
        }

        public void WriteExcel(string[] colName,string[,] data)
        {
            try
            {
                MyApp = new Application();
                MyApp.Visible = true;
                MyBook = (Workbook)MyApp.Workbooks.Add();
                MySheet = (Worksheet)MyBook.ActiveSheet;
               
              
                    #region Create column
                string mL = string.Empty;
                if (colName.Length > 104)
                    mL = string.Format("D{0}", (char)(65 + colName.Length - 1 - 104));
                else if (colName.Length > 78)
                    mL = string.Format("C{0}", (char)(65 + colName.Length - 1 - 78));
                else if (colName.Length > 52)
                    mL = string.Format("B{0}", (char)(65 + colName.Length - 1 - 52));
                else if (colName.Length > 26)
                    mL = string.Format("A{0}", (char)(65 + colName.Length - 1 - 26));
                else
                    mL = ((char)(65 + colName.Length - 1)).ToString();
                string temp = string.Format("{0}1", mL);
                MySheet.get_Range("A1", temp).Value2 = colName;
                MySheet.get_Range("A1", temp).Font.Bold = true;
                MySheet.get_Range("A1", temp).VerticalAlignment = XlVAlign.xlVAlignCenter;
                MySheet.get_Range("A1", temp).Cells.Interior.Color = System.Drawing.Color.Yellow;

                    #endregion

                #region fill data

                //string aa1 = data[128, 1].ToString();
                //string aa2 = data[129, 1].ToString();
                //string aa3 = data[130, 1].ToString();

                MySheet.get_Range("A2", string.Format("{0}{1}", mL, data.GetLength(0))).Value2 = data;

                #endregion
                MyApp.Visible = true;
                MyApp.UserControl = true;
                try
                {
                    MyBook.SaveAs("C:\\BaoCaoTuPMTDC.xlsx", AccessMode: XlSaveAsAccessMode.xlShared);
                    GlobalCommon.ShowMessageInformation("File đã được lưu tại đường dẫn: C:\\BaoCaoTuPMTDC.xlsx");
                }
                catch (Exception ex)
                {
                    throw new Exception("Xuất file execl tự động thành công, xin vui lòng chọn save trên execl để lưu file");
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private static void getInfo(string value, ref ChamCongNhanVien nhanvien){
            int index = value.IndexOf(":");
            string s = value.Substring(index + 1).Trim();

            index = s.IndexOf(" ");
            string manhanvien = s.Substring(0, index).Trim();
            nhanvien.MaNhanVien = manhanvien;
            s = s.Substring(index).Trim();

            index = s.IndexOf(":");
            s = s.Substring(index + 1);

            index = s.IndexOf("Phòng ban:");
            nhanvien.HoTen = s.Substring(0, index).Trim();

            s = s.Substring(index);
            index = s.IndexOf(":");
            nhanvien.Phong = s.Substring(index + 1).Trim();
        }
    }
}

