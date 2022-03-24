using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ExportLib.Entities.ChiDaoTuyen;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data;
using System.ComponentModel;
using System.Diagnostics;

namespace ExportLib
{
    public class ExportChiDaoTuyen
    {
        #region B013_BaoCaoKetQuaDaoTaoHoiChan

        public ReportDocument B013_BaoCaoKetQuaDaoTaoHoiChanCRVBinding(B013_BaoCaoKetQuaDaoTaoHoiChan data)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B013_BaoCaoKetQuaDaoTaoHoiChanRpt);
                rpt.Load(path);
                B013_BindingData(data, rpt);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void B012_BaoCaoQuanLyAnhCungCap(B013_BaoCaoKetQuaDaoTaoHoiChan data, Constants.ExportType type)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B013_BaoCaoKetQuaDaoTaoHoiChanRpt);
                rpt.Load(path);
                B013_BindingData(data, rpt);
                string tempPath = Path.Combine(Path.GetTempPath(), Constants.FileName.ChiDaoTuyen.B013_BaoCaoKetQuaDaoTaoHoiChan);
                tempPath = Export(rpt, tempPath, type);
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void B013_BindingData(B013_BaoCaoKetQuaDaoTaoHoiChan data, ReportDocument rpt)
        {
            if (data.ListSoLieuThongKe != null)
            {
                DataTable dt = ConvertToDataTable(data.ListSoLieuThongKe);
                rpt.SetDataSource(dt);
            }

            ReplaceData(rpt, "NgayTienHanh", string.IsNullOrEmpty(data.NgayTienHanh) ? string.Empty : data.NgayTienHanh);
            ReplaceData(rpt, "NoiDung", string.IsNullOrEmpty(data.NoiDung) ? string.Empty : data.NoiDung);
            ReplaceData(rpt, "ChuTri", string.IsNullOrEmpty(data.ChuTri) ? Constants.EmptyData.LongEmpty : data.ChuTri);
            ReplaceData(rpt, "ChucVuChuTri", string.IsNullOrEmpty(data.ChucVuChuTri) ? Constants.EmptyData.LongEmpty : data.ChucVuChuTri);
            ReplaceData(rpt, "hoaChuTri", string.IsNullOrEmpty(data.KhoaChuTri) ? Constants.EmptyData.LongEmpty : data.KhoaChuTri);
            ReplaceData(rpt, "ThuKy1", string.IsNullOrEmpty(data.ThuKy1) ? string.Empty : data.ThuKy1);
            ReplaceData(rpt, "ThuKy2", string.IsNullOrEmpty(data.ThuKy2) ? string.Empty : data.ThuKy2);
            ReplaceData(rpt, "DeMuc1", string.IsNullOrEmpty(data.DeMuc1) ? string.Empty : data.DeMuc1);
            ReplaceData(rpt, "DeMuc2", string.IsNullOrEmpty(data.DeMuc2) ? string.Empty : data.DeMuc2);
            ReplaceData(rpt, "DeMuc3", string.IsNullOrEmpty(data.DeMuc3) ? string.Empty : data.DeMuc3);
            ReplaceData(rpt, "NgayLapBaoCao", string.IsNullOrEmpty(data.NgayLapBaoCao) ? Constants.EmptyData.NgayViet : data.NgayLapBaoCao);
            ReplaceData(rpt, "PhongChiDaoTuyen", string.IsNullOrEmpty(data.PhongChiDaoTuyen) ? string.Empty : data.PhongChiDaoTuyen);
            ReplaceData(rpt, "NguoiLamBaoCao", string.IsNullOrEmpty(data.NguoiLamBaoCao) ? string.Empty : data.NguoiLamBaoCao);
        }

        public void B013_BaoCaoKetQuaDaoTaoHoiChan(B013_BaoCaoKetQuaDaoTaoHoiChan data)
        {
            if (data == null)
                return;

            string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B013_BaoCaoKetQuaDaoTaoHoiChan);
            string tempPath = string.Empty;
            String result = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = ReplaceDataB013(data, line);
                        line = result = result + line;
                    }

                    string fileName = Constants.FileName.ChiDaoTuyen.B013_BaoCaoKetQuaDaoTaoHoiChan + ".html";
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

        private static string ReplaceDataB013(B013_BaoCaoKetQuaDaoTaoHoiChan data, String line)
        {
            line = line.Replace("$NgayTienHanh", string.IsNullOrEmpty(data.NgayTienHanh) ? string.Empty : data.NgayTienHanh);
            line = line.Replace("$NoiDung", string.IsNullOrEmpty(data.NoiDung) ? string.Empty : data.NoiDung);
            line = line.Replace("$ChuTri", string.IsNullOrEmpty(data.ChuTri) ? Constants.EmptyData.LongEmpty : data.ChuTri);
            line = line.Replace("$ChucVuChuTri", string.IsNullOrEmpty(data.ChucVuChuTri) ? Constants.EmptyData.LongEmpty : data.ChucVuChuTri);
            line = line.Replace("$KhoaChuTri", string.IsNullOrEmpty(data.KhoaChuTri) ? Constants.EmptyData.LongEmpty : data.KhoaChuTri);
            line = line.Replace("$Thuky1", string.IsNullOrEmpty(data.ThuKy1) ? string.Empty : data.ThuKy1);
            line = line.Replace("$Thuky2", string.IsNullOrEmpty(data.ThuKy2) ? string.Empty : data.ThuKy2);
            line = line.Replace("$DeMuc1", string.IsNullOrEmpty(data.DeMuc1) ? string.Empty : data.DeMuc1);
            line = line.Replace("$DeMuc2", string.IsNullOrEmpty(data.DeMuc2) ? string.Empty : data.DeMuc2);
            line = line.Replace("$DeMuc3", string.IsNullOrEmpty(data.DeMuc3) ? string.Empty : data.DeMuc3);
            line = line.Replace("$NgayLapBaoCao", string.IsNullOrEmpty(data.NgayLapBaoCao) ? Constants.EmptyData.NgayViet : data.NgayLapBaoCao);
            line = line.Replace("$PhongChiDaoTuyen", string.IsNullOrEmpty(data.PhongChiDaoTuyen) ? string.Empty : data.PhongChiDaoTuyen);
            line = line.Replace("$NguoiLamBaoCao", string.IsNullOrEmpty(data.NguoiLamBaoCao) ? string.Empty : data.NguoiLamBaoCao);
            string dataTable = GetDanhSachSoLieuThongKe(data.ListSoLieuThongKe);
            line = line.Replace("$DataTable", string.IsNullOrEmpty(dataTable) ? string.Empty : dataTable);
            return line;
        }

        private static string GetDanhSachSoLieuThongKe(List<SoLieuThongKe> list)
        {
            if (list.Count == 0)
                return string.Empty;

            string dataTable = string.Empty;
            int stt = 0;
            foreach (SoLieuThongKe item in list)
            {
                stt++;
                dataTable = dataTable + "<tr>";
                dataTable = dataTable + "<td class='cs-td' height='24px'>"+stt+"</td>";
                dataTable = dataTable + "<td class='cs-td'>"+item.TenBVThamGia+"</td>";
                dataTable = dataTable + "<td class='cs-td'>"+item.SoLuongThamGia+"</td>";
                dataTable = dataTable + "<td class='cs-td-last'>"+item.BaoCaoBA+"</td>";
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
