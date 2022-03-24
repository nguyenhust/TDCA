using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ExportLib.Entities.TruyenThong;
using CrystalDecisions.CrystalReports.Engine;
using System.Diagnostics;
using CrystalDecisions.Shared;
using System.Data;
using System.ComponentModel;

namespace ExportLib
{
    public class ExportTruyenThong
    {
        #region B011_BaiVietTruyenThong

        public ReportDocument B011_BaiVietTruyenThongCRVBinding(B011_BaiVietTruyenThong data)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B011_BaiVietTruyenThongRpt);
                rpt.Load(path);
                B011_BindingData(data, rpt);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void B011_BaiVietTruyenThong(B011_BaiVietTruyenThong data, Constants.ExportType type)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B011_BaiVietTruyenThongRpt);
                rpt.Load(path);
                B011_BindingData(data, rpt);
                string tempPath = Path.Combine(Path.GetTempPath(), Constants.FileName.TruyenThong.B011_BaiVietTruyenThong);
                tempPath = Export(rpt, tempPath, type);
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void B011_BindingData(B011_BaiVietTruyenThong data, ReportDocument rpt)
        {
            if (data.ListBaiViet != null)
            {
                DataTable dt = ConvertToDataTable(data.ListBaiViet);
                rpt.SetDataSource(dt);
            }

            ReplaceData(rpt, "NgayBatDau", string.IsNullOrEmpty(data.NgayBatDau) ? string.Empty : data.NgayBatDau);
            ReplaceData(rpt, "NgayKetThuc", string.IsNullOrEmpty(data.NgayKetThuc) ? string.Empty : data.NgayKetThuc);
            ReplaceData(rpt, "NgayLapBaoCao", string.IsNullOrEmpty(data.NgayLapBaoCao) ? Constants.EmptyData.NgayViet : data.NgayLapBaoCao);
            ReplaceData(rpt, "NguoiLapBaoCao", string.IsNullOrEmpty(data.NguoiLapBaoCao) ? string.Empty : data.NguoiLapBaoCao);
        }

        public void B011_BaiVietTruyenThong(B011_BaiVietTruyenThong data)
        {
            if (data == null)
                return;

            string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B011_BaiVietTruyenThong);
            string tempPath = string.Empty;
            String result = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = ReplaceDataB011(data, line);
                        line = result = result + line;
                    }

                    string fileName = Constants.FileName.TruyenThong.B011_BaiVietTruyenThong + ".html";
                    tempPath = Path.Combine(Path.GetTempPath(), fileName);
                    StreamWriter oWriter = new StreamWriter(tempPath);
                    oWriter.Write(result);
                    oWriter.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (!string.IsNullOrEmpty(tempPath))
            {
                System.Diagnostics.Process.Start(tempPath);
            }
        }

        private static string ReplaceDataB011(B011_BaiVietTruyenThong data, String line)
        {
            line = line.Replace("$NgayBatDau", string.IsNullOrEmpty(data.NgayBatDau) ? string.Empty : data.NgayBatDau);
            line = line.Replace("$NgayKetThuc", string.IsNullOrEmpty(data.NgayKetThuc) ? string.Empty : data.NgayKetThuc);
            line = line.Replace("$NgayLapBaoCao", string.IsNullOrEmpty(data.NgayLapBaoCao) ? Constants.EmptyData.NgayViet : data.NgayLapBaoCao);
            line = line.Replace("$NguoiLapBaoCao", string.IsNullOrEmpty(data.NguoiLapBaoCao) ? string.Empty : data.NguoiLapBaoCao);
            string dataTable = GetDanhSachBaiViet(data.ListBaiViet);
            line = line.Replace("$DataTable", string.IsNullOrEmpty(dataTable) ? string.Empty : dataTable);
            return line;
        }

        private static string GetDanhSachBaiViet(List<BaiViet> list)
        {
            if (list.Count == 0)
                return string.Empty;

            string dataTable = string.Empty;
            int stt = 0;
            foreach (BaiViet item in list)
            {
                stt++;
                dataTable = dataTable + "<TR>";
                dataTable = dataTable + "<td class='tr1 td22' style='vertical-align: middle;border-bottom:#000000 1px solid;'><p class='p15 ft7'>"+stt+"</p></td>";
                dataTable = dataTable + "<td class='tr1 td23' style='vertical-align: middle;border-bottom:#000000 1px solid;'><p class='p15 ft7'>"+item.TenBai+"</p></td>";
                dataTable = dataTable + "<td class='tr1 td24' style='vertical-align: middle;border-bottom:#000000 1px solid;'><p class='p15 ft7'>"+item.SoAnh+"</p></td>";
                dataTable = dataTable + "<td colspan=3 class='tr1 td25' style='vertical-align: middle; border-bottom: #000000 1px solid; border-right: #000000 1px solid;'><p class='p15 ft7'>"+item.BaoDang+"</p></td>";
                dataTable = dataTable + "<td class='tr1 td27' style='vertical-align: middle;border-bottom:#000000 1px solid;'><p class='p15 ft7'>"+item.SoBao+"</p></td>";
                dataTable = dataTable + "<td class='tr1 td28' style='vertical-align: middle;border-bottom:#000000 1px solid;'><p class='p15 ft7'>"+item.ThoiGian+"</p></td>";
                dataTable = dataTable + "<td class='tr1 td29' style='vertical-align: middle;border-bottom:#000000 1px solid;'><p class='p15 ft7'>"+item.NoiDung+"</p></td>";
                dataTable = dataTable + "<td class='tr1 td30' style='vertical-align: middle;border-bottom:#000000 1px solid;'><p class='p15 ft7'>"+item.NguoiThucHien+"</p></td>";
                dataTable = dataTable + "<td colspan=2 class='tr1 td31' style='vertical-align: middle; border-bottom: #000000 1px solid;'><p class='p15 ft7'>"+item.GhiChu+"</p></td>";
                dataTable = dataTable + "</TR>";
            }

            return dataTable;
        }

        #endregion

        #region B012_BaoCaoQuanLyAnhCungCap

        public ReportDocument B012_BaoCaoQuanLyAnhCungCapCRVBinding(B012_BaoCaoQuanLyAnhCungCap data)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B012_BaoCaoQuanLyAnhCungCapRpt);
                rpt.Load(path);
                B012_BindingData(data, rpt);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void B012_BaoCaoQuanLyAnhCungCap(B012_BaoCaoQuanLyAnhCungCap data, Constants.ExportType type)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B012_BaoCaoQuanLyAnhCungCapRpt);
                rpt.Load(path);
                B012_BindingData(data, rpt);
                string tempPath = Path.Combine(Path.GetTempPath(), Constants.FileName.TruyenThong.B012_BaoCaoQuanLyAnhCungCap);
                tempPath = Export(rpt, tempPath, type);
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void B012_BindingData(B012_BaoCaoQuanLyAnhCungCap data, ReportDocument rpt)
        {
            if (data.ListBanGhiAnh != null)
            {
                DataTable dt = ConvertToDataTable(data.ListBanGhiAnh);
                rpt.SetDataSource(dt);
            }

            ReplaceData(rpt, "NgayBatDau", string.IsNullOrEmpty(data.NgayBatDau) ? string.Empty : data.NgayBatDau);
            ReplaceData(rpt, "NgayKetThuc", string.IsNullOrEmpty(data.NgayKetThuc) ? string.Empty : data.NgayKetThuc);
            ReplaceData(rpt, "NgayLapBaoCao", string.IsNullOrEmpty(data.NgayLapBaoCao) ? Constants.EmptyData.NgayViet : data.NgayLapBaoCao);
            ReplaceData(rpt, "NguoiLapBaoCao", string.IsNullOrEmpty(data.NguoiLapBaoCao) ? string.Empty : data.NguoiLapBaoCao);
        }

        public void B012_BaoCaoQuanLyAnhCungCap(B012_BaoCaoQuanLyAnhCungCap data)
        {
            if (data == null)
                return;

            string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B012_BaoCaoQuanLyAnhCungCap);
            string tempPath = string.Empty;
            String result = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = ReplaceDataB012(data, line);
                        line = result = result + line;
                    }

                    string fileName = Constants.FileName.TruyenThong.B012_BaoCaoQuanLyAnhCungCap + ".html";
                    tempPath = Path.Combine(Path.GetTempPath(), fileName);
                    StreamWriter oWriter = new StreamWriter(tempPath);
                    oWriter.Write(result);
                    oWriter.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (!string.IsNullOrEmpty(tempPath))
            {
                System.Diagnostics.Process.Start(tempPath);
            }
        }

        private static string ReplaceDataB012(B012_BaoCaoQuanLyAnhCungCap data, String line)
        {
            line = line.Replace("$NgayBatDau", string.IsNullOrEmpty(data.NgayBatDau) ? string.Empty : data.NgayBatDau);
            line = line.Replace("$NgayKetThuc", string.IsNullOrEmpty(data.NgayKetThuc) ? string.Empty : data.NgayKetThuc);
            line = line.Replace("$NgayLapBaoCao", string.IsNullOrEmpty(data.NgayLapBaoCao) ? Constants.EmptyData.NgayViet : data.NgayLapBaoCao);
            line = line.Replace("$NguoiLapBaoCao", string.IsNullOrEmpty(data.NguoiLapBaoCao) ? string.Empty : data.NguoiLapBaoCao);
            string dataTable = GetDanhSachBanGhiAnh(data.ListBanGhiAnh);
            line = line.Replace("$DataTable", string.IsNullOrEmpty(dataTable) ? string.Empty : dataTable);
            return line;
        }

        private static string GetDanhSachBanGhiAnh(List<BanGhiAnh> list)
        {
            if (list.Count == 0)
                return string.Empty;

            string dataTable = string.Empty;
            int stt = 0;
            foreach (BanGhiAnh item in list)
            {
                stt++;
                dataTable = dataTable + "<tr>";
                dataTable = dataTable + "<td class='tr4 td22'><p class='p3 ft5'>"+stt+"</p></td>";
                dataTable = dataTable + "<td colspan=2 class='tr4 td8' style='border-right: #000000 1px solid;'><p class='p3 ft5'>"+item.NoiDungAnh+"</p></td>";
                dataTable = dataTable + "<td class='tr4 td24'><p class='p3 ft5'>"+item.SoLuong+"</p></td>";
                dataTable = dataTable + "<td class='tr4 td25'><p class='p3 ft5'>"+item.ThoiGian+"</p></td>";
                dataTable = dataTable + "<td colspan=2 class='tr4 td26'><p class='p3 ft5'>"+item.DonViYeuCau+"</p></td>";
                dataTable = dataTable + "<td class='tr4 td27'><p class='p3 ft5'>"+item.KetQua+"</p></td>";
                dataTable = dataTable + "<td class='tr4 td28'><p class='p3 ft5'>"+item.GhiChu+"</p></td>";
                dataTable = dataTable + "</tr>";
            }

            return dataTable;
        }

        #endregion

        protected void ReplaceData(ReportDocument rpt, string field, string data)
        {
            TextObject myTextObjectOnReport;
            if (rpt.ReportDefinition.ReportObjects[field] != null)
            {
                myTextObjectOnReport = (TextObject)rpt.ReportDefinition.ReportObjects[field];
                myTextObjectOnReport.Text = data;
            }
        }

        private static string Export(ReportDocument rpt, string tempPath, Constants.ExportType type)
        {
            tempPath = GetFullTempPath(tempPath, type);
            ExportOptions rptExportOption;
            DiskFileDestinationOptions rptFileDestOption = new DiskFileDestinationOptions();
            rptFileDestOption.DiskFileName = tempPath;
            rptExportOption = rpt.ExportOptions;
            {
                rptExportOption.ExportDestinationType = ExportDestinationType.DiskFile;
                switch (type)
                {
                    case Constants.ExportType.Doc:
                        rptExportOption.ExportFormatType = ExportFormatType.RichText;
                        rptExportOption.ExportFormatOptions = new PdfRtfWordFormatOptions();
                        break;
                    case Constants.ExportType.Pdf:
                        rptExportOption.ExportFormatType = ExportFormatType.PortableDocFormat;
                        rptExportOption.ExportFormatOptions = new PdfRtfWordFormatOptions();
                        break;
                    case Constants.ExportType.Excel:
                        rptExportOption.ExportFormatType = ExportFormatType.Excel;
                        rptExportOption.ExportFormatOptions = new ExcelFormatOptions();
                        break;
                }

                rptExportOption.ExportDestinationOptions = rptFileDestOption;

            }

            rpt.Export();
            return tempPath;
        }

        private static string GetFullTempPath(string tempPath, Constants.ExportType type)
        {
            switch (type)
            {
                case Constants.ExportType.Doc:
                    tempPath = tempPath + ".doc";
                    break;
                case Constants.ExportType.Pdf:
                    tempPath = tempPath + ".pdf";
                    break;
                case Constants.ExportType.Excel:
                    tempPath = tempPath + ".xls";
                    break;
            }
            return tempPath;
        }

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }
    }
}
