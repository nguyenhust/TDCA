using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ExportLib.Entities.HanhChinh;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Diagnostics;
using System.Data;
using System.ComponentModel;

namespace ExportLib
{
    public class ExportHanhChinh
    {
        #region Bao Cao Xin Xe

        public void B101_PhieuXinXe(P0010_PhieuXinXe data)
        {
            if (data == null)
                return;

            string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B101_PhieuXinXe);
            string tempPath = string.Empty;
            String result = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = ReplaceDataPhieuXinXe(data, line);
                        line = result = result + line;
                    }

                    string fileName = Constants.FileName.HanhChinh.B101_PhieuXinXe + ".html";
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

        private static string ReplaceDataPhieuXinXe(P0010_PhieuXinXe data, String line)
        {
            line = line.Replace("$canbodangki", string.IsNullOrEmpty(data.NguoiDangKy) ? string.Empty : data.NguoiDangKy);
            line = line.Replace("$chucvu", string.IsNullOrEmpty(data.ChucVu) ? string.Empty : data.ChucVu);
            line = line.Replace("$phongban", string.IsNullOrEmpty(data.Phong) ? string.Empty : data.Phong);
            line = line.Replace("$noidung", string.IsNullOrEmpty(data.NoiDung) ? Constants.EmptyData.NgayViet : data.NoiDung);
            line = line.Replace("$batdau", string.IsNullOrEmpty(data.NgayDi) ? string.Empty : data.NgayDi);
            line = line.Replace("$ketthuc", string.IsNullOrEmpty(data.NgayVe) ? string.Empty : data.NgayVe);
            line = line.Replace("$noiden", string.IsNullOrEmpty(data.NoiDen) ? string.Empty : data.NoiDen);
            line = line.Replace("$songuoi", string.IsNullOrEmpty(data.SoNguoi) ? string.Empty : data.SoNguoi);
            line = line.Replace("$sokm", string.IsNullOrEmpty(data.SoKm) ? string.Empty : data.SoKm);
            line = line.Replace("$nguonkinhphi", string.IsNullOrEmpty(data.NguonKinhPhi) ? string.Empty : data.NguonKinhPhi);
            line = line.Replace("$ngaylapbaocao", string.IsNullOrEmpty(data.NgayLapBaoCao) ? string.Empty : data.NgayLapBaoCao);
            line = line.Replace("$nguoiki", string.IsNullOrEmpty(data.NguoiKy) ? string.Empty : data.NguoiKy);
            return line;
        }

        #endregion

        #region Cong Van Den

        public void BaoCaoCongVanDen(BaoCaoXinXe data)
        {
            if (data == null)
                return;

            string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.BaoCaoXinXe);
            string tempPath = string.Empty;
            String result = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = ReplaceDataXinXe(data, line);
                        line = result = result + line;
                    }

                    string fileName = Constants.FileName.HanhChinh.BaoCaoXinXe + ".html";
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

        private static string ReplaceDataXinXe(BaoCaoXinXe data, String line)
        {
            string dataTable = GetDanhSachXinXe(data.DanhSachXinXe);
            line = line.Replace("$DataTable", string.IsNullOrEmpty(dataTable) ? string.Empty : dataTable);
            return line;
        }

        private static string GetDanhSachXinXe(List<BC_XinXe> list)
        {
            if (list.Count == 0)
                return string.Empty;

            string dataTable = string.Empty;
            int stt = 0;
            // header
            dataTable = dataTable + "<table>";
            dataTable = dataTable + "<tr>";
            dataTable = dataTable + "<td class='tr8 td31'><p class='p13 ft7'>STT</p></td>";
            dataTable = dataTable + "<td class='tr8 td31'><p class='p13 ft7'>Người Đăng Ký</p></td>";
            dataTable = dataTable + "<td class='tr8 td31'><p class='p13 ft7'>Chức vụ</p></td>";
            dataTable = dataTable + "<td class='tr8 td31'><p class='p13 ft7'>Phòng</p></td>";
            dataTable = dataTable + "<td class='tr8 td31'><p class='p13 ft7'>Ngày Đi</p></td>";
            dataTable = dataTable + "<td class='tr8 td31'><p class='p13 ft7'>Ngày Về</p></td>";
            dataTable = dataTable + "<td class='tr8 td31'><p class='p13 ft7'>Nơi Đến</p></td>";
            dataTable = dataTable + "<td class='tr8 td31'><p class='p13 ft7'>Nội Dung</p></td>";
            dataTable = dataTable + "<td class='tr8 td31'><p class='p13 ft7'>Nguồn Kinh Phí</p></td>";
            dataTable = dataTable + "<td class='tr8 td31'><p class='p13 ft7'>Số người</p></td>";
            dataTable = dataTable + "<td class='tr8 td31'><p class='p13 ft7'>Số KM</p></td>";
            dataTable = dataTable + "</tr>";
            foreach (BC_XinXe item in list)
            {
                stt++;
                dataTable = dataTable + "<tr>";
                dataTable = dataTable + "<td class='tr8 td31'><p class='p13 ft7'>" + stt + "</p></td>";
                dataTable = dataTable + "<td class='tr8 td32'><p class='p14 ft8'><nobr>" + item.NguoiDangKy + "</nobr></p></td>";
                dataTable = dataTable + "<td class='tr8 td33'><p class='p15 ft7'>" + item.ChucVu + "</p></td>";
                dataTable = dataTable + "<td class='tr8 td34'><p class='p14 ft7'>" + item.Phong + "</p></td>";
                dataTable = dataTable + "<td class='tr8 td35'><p class='p16 ft7'>" + item.NgayDi + "</p></td>";
                dataTable = dataTable + "<td class='tr8 td36'><p class='p17 ft7'>" + item.NgayVe + "</p></td>";
                dataTable = dataTable + "<td class='tr8 td36'><p class='p17 ft7'>" + item.NoiDen + "</p></td>";
                dataTable = dataTable + "<td class='tr8 td36'><p class='p17 ft7'>" + item.NoiDung + "</p></td>";
                dataTable = dataTable + "<td class='tr8 td36'><p class='p17 ft7'>" + item.NguonKinhPhi + "</p></td>";
                dataTable = dataTable + "<td class='tr8 td36'><p class='p17 ft7'>" + item.SoNguoi + "</p></td>";
                dataTable = dataTable + "<td class='tr8 td36'><p class='p17 ft7'>" + item.SoKm + "</p></td>";
                dataTable = dataTable + "</tr>";
            }
            dataTable = dataTable + "</table>";
            return dataTable;
        }

        #endregion
        #region B002_BaoCaoChamCong

        public void B002_BaoCaoChamCong(B002_BaoCaoChamCong data)
        {
            if (data == null)
                return;

            string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B002_BaoCaoChamCong);
            string tempPath = string.Empty;
            String result = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = ReplaceDataB002(data, line);
                        line = result = result + line;
                    }

                    string fileName = Constants.FileName.HanhChinh.B002_BaoCaoChamCong + ".html";
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

        private static string ReplaceDataB002(B002_BaoCaoChamCong data, String line)
        {
            line = line.Replace("$NgayBatDau", string.IsNullOrEmpty(data.NgayBatDau) ? string.Empty : data.NgayBatDau);
            line = line.Replace("$NgayKetThuc", string.IsNullOrEmpty(data.NgayKetThuc) ? string.Empty : data.NgayKetThuc);
            string dataTable = GetDanhSachNguoiDuocChamCong(data.ListNguoiDuocChamCong);
            line = line.Replace("$DataTable", string.IsNullOrEmpty(dataTable) ? string.Empty : dataTable);
            return line;
        }

        private static string GetDanhSachNguoiDuocChamCong(List<NguoiDuocChamCong> list)
        {
            if (list.Count == 0)
                return string.Empty;

            string dataTable = string.Empty;
            int stt = 0;
            foreach (NguoiDuocChamCong item in list)
            {
                stt++;
                dataTable = dataTable + "<tr>";
                dataTable = dataTable + "<td class='tr9 td35'><p class='p4 ft2'>" + stt + "</p></td>";
                dataTable = dataTable + "<td colspan='2' class='tr9 td12' style='border-right: #000000 1px solid;'><p class='p17 ft0'>" + item.HoTen + "</p></td>";
                dataTable = dataTable + "<td colspan='4' class='tr9 td37'><table cellpadding=0 cellspacing=0>" + GetDanhSachNgayNghi(item.ListNgayNghi) + "</table></td>";
                dataTable = dataTable + "<td class='tr9 td16'><p class='p4 ft2'>&nbsp;</p></td>";
                dataTable = dataTable + "<td class='tr9 td38'><p class='p14 ft0'>" + item.SoNgayNghi + "</p></td>";
                dataTable = dataTable + "<td class='tr9 td39'><table cellpadding=0 cellspacing=0>" + GetDanhSachNgayMuon(item.ListNgayMuon) + "</table></td>";
                dataTable = dataTable + "<td class='tr9 td40'><p class='p4 ft2'>" + item.SoNgayMuon + "</p></td>";
                dataTable = dataTable + "<td class='tr9 td41'><p class='p4 ft2'>" + item.NgayPhepNam + "</p></td>";
                dataTable = dataTable + "<td class='tr9 td42'><p class='p4 ft2'>" + item.NgayPhepConLai + "</p></td>";
                dataTable = dataTable + "</tr>";
            }

            return dataTable;
        }

        private static string GetDanhSachNgayMuon(List<NgayMuon> list)
        {
            if (list.Count == 0)
                return string.Empty;

            string dataTable = string.Empty;
            int stt = 0;
            foreach (NgayMuon item in list)
            {
                stt++;
                if (stt == list.Count)
                {
                    dataTable = dataTable + "<tr>";
                    dataTable = dataTable + "<td width='78'><p class='p18 ft0'>" + item.NgayDiMuon + "</p></td>";
                    dataTable = dataTable + "</tr>";
                    break;
                }

                dataTable = dataTable + "<tr>";
                dataTable = dataTable + "<td style='border-bottom: #000000 1px solid;' width='78'><p class='p18 ft0'>" + item.NgayDiMuon + "</p></td>";
                dataTable = dataTable + "</tr>";
            }

            return dataTable;
        }

        private static string GetDanhSachNgayNghi(List<NgayNghi> list)
        {
            if (list.Count == 0)
                return string.Empty;

            string dataTable = string.Empty;
            int stt = 0;
            foreach (NgayNghi item in list)
            {
                stt++;
                if (stt == list.Count)
                {
                    dataTable = dataTable + "<tr>";
                    dataTable = dataTable + "<td style='border-bottom: #000000 1px solid; border-right: #000000 1px solid;' width='76'><p class='p18 ft0'>" + item.NgayDaNghi + "</p></td>";
                    dataTable = dataTable + "<td width='132'><p class='p17 ft0'>" + item.LyDoNghi + "</p></td>";
                    dataTable = dataTable + "</tr>";
                    break;
                }

                dataTable = dataTable + "<tr>";
                dataTable = dataTable + "<td style='border-bottom: #000000 1px solid; border-right: #000000 1px solid;' width='76'><p class='p18 ft0'>" + item.NgayDaNghi + "</p></td>";
                dataTable = dataTable + "<td style='border-bottom: #000000 1px solid;' width='132'><p class='p17 ft0'>" + item.LyDoNghi + "</p></td>";
                dataTable = dataTable + "</tr>";
            }

            return dataTable;

        }

        #endregion

        #region B003_BaoCaoCongVanDen

        public ReportDocument B003_BaoCaoCongVanDen(B003_BaoCaoCongVanDen data)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B003_BaoCaoCongVanDen);
                rpt.Load(path);
                B003_BindingData(data, rpt);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void B003_BaoCaoCongVanDen(B003_BaoCaoCongVanDen data, Constants.ExportType type)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B003_BaoCaoCongVanDen);
                rpt.Load(path);
                B003_BindingData(data, rpt);
                string tempPath = Path.Combine(Path.GetTempPath(), Constants.FileName.HanhChinh.B003_BaoCaoCongVanDen);
                tempPath = Export(rpt, tempPath, type);
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void B003_BindingData(B003_BaoCaoCongVanDen data, ReportDocument rpt)
        {
            if (data.ListCongVanDen != null)
            {
                DataTable dt = ConvertToDataTable(data.ListCongVanDen);
                rpt.SetDataSource(dt);
            }

            ReplaceData(rpt, "NgayBatDau", string.IsNullOrEmpty(data.NgayBatDau) ? string.Empty : data.NgayBatDau);
            ReplaceData(rpt, "NgayKetThuc", string.IsNullOrEmpty(data.NgayKetThuc) ? string.Empty : data.NgayKetThuc);
            ReplaceData(rpt, "TongSoCongVanDen", string.IsNullOrEmpty(data.TongSoCongVanDen) ? string.Empty : data.TongSoCongVanDen);
            ReplaceData(rpt, "NgayLapBaoCao", string.IsNullOrEmpty(data.NgayLapBaoCao) ? Constants.EmptyData.NgayViet : data.NgayLapBaoCao);
            ReplaceData(rpt, "NguoiLapBaoCao", string.IsNullOrEmpty(data.NguoiLapBaoCao) ? string.Empty : data.NguoiLapBaoCao);
        }

        #endregion

        #region B004_BaoCaoCongVanDi

        public ReportDocument B004_BaoCaoCongVanDi(B004_BaoCaoCongVanDi data)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B004_BaoCaoCongVanDi);
                rpt.Load(path);
                B004_BindingData(data, rpt);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void B004_BaoCaoCongVanDi(B004_BaoCaoCongVanDi data, Constants.ExportType type)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B004_BaoCaoCongVanDi);
                rpt.Load(path);
                B004_BindingData(data, rpt);
                string tempPath = Path.Combine(Path.GetTempPath(), Constants.FileName.HanhChinh.B004_BaoCaoCongVanDi);
                tempPath = Export(rpt, tempPath, type);
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void B004_BindingData(B004_BaoCaoCongVanDi data, ReportDocument rpt)
        {
            if (data.ListCongVanDi != null)
            {
                DataTable dt = ConvertToDataTable(data.ListCongVanDi);
                rpt.SetDataSource(dt);
            }

            ReplaceData(rpt, "NgayBatDau", string.IsNullOrEmpty(data.NgayBatDau) ? string.Empty : data.NgayBatDau);
            ReplaceData(rpt, "NgayKetThuc", string.IsNullOrEmpty(data.NgayKetThuc) ? string.Empty : data.NgayKetThuc);
            ReplaceData(rpt, "TongSoCongVanDi", string.IsNullOrEmpty(data.TongSoCongVanDi) ? string.Empty : data.TongSoCongVanDi);
            ReplaceData(rpt, "NgayLapBaoCao", string.IsNullOrEmpty(data.NgayLapBaoCao) ? Constants.EmptyData.NgayViet : data.NgayLapBaoCao);
            ReplaceData(rpt, "NguoiLapBaoCao", string.IsNullOrEmpty(data.NguoiLapBaoCao) ? string.Empty : data.NguoiLapBaoCao);
        }

        #endregion

        #region B005_BaoCaoDangKiGiangDuongPhongHoc

        public ReportDocument B005_BaoCaoDangKiGiangDuongPhongHoc(B005_BaoCaoDangKiGiangDuongPhongHoc data)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B005_BaoCaoDangKiGiangDuongPhongHoc);
                rpt.Load(path);
                B005_BindingData(data, rpt);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void B005_BaoCaoDangKiGiangDuongPhongHoc(B005_BaoCaoDangKiGiangDuongPhongHoc data, Constants.ExportType type)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B005_BaoCaoDangKiGiangDuongPhongHoc);
                rpt.Load(path);
                B005_BindingData(data, rpt);
                string tempPath = Path.Combine(Path.GetTempPath(), Constants.FileName.HanhChinh.B005_BaoCaoDangKiGiangDuongPhongHoc);
                tempPath = Export(rpt, tempPath, type);
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void B005_BindingData(B005_BaoCaoDangKiGiangDuongPhongHoc data, ReportDocument rpt)
        {
            if (data.ListDangKy != null)
            {
                DataTable dt = ConvertToDataTable(data.ListDangKy);
                rpt.SetDataSource(dt);
            }

            ReplaceData(rpt, "NgayBatDau", string.IsNullOrEmpty(data.NgayBatDau) ? string.Empty : data.NgayBatDau);
            ReplaceData(rpt, "NgayKetThuc", string.IsNullOrEmpty(data.NgayKetThuc) ? string.Empty : data.NgayKetThuc);
            ReplaceData(rpt, "TongSoDangKy", string.IsNullOrEmpty(data.TongSoDangKy) ? string.Empty : data.TongSoDangKy);
            ReplaceData(rpt, "NgayLapBaoCao", string.IsNullOrEmpty(data.NgayLapBaoCao) ? Constants.EmptyData.NgayViet : data.NgayLapBaoCao);
            ReplaceData(rpt, "NguoiLapBaoCao", string.IsNullOrEmpty(data.NguoiLapBaoCao) ? string.Empty : data.NguoiLapBaoCao);
        }

        #endregion

        #region B006_BaoCaoDuTruVanPhongPhamTheoTo

        public ReportDocument B006_BaoCaoDuTruVanPhongPhamTheoTo(B006_BaoCaoDuTruVanPhongPhamTheoTo data)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B006_BaoCaoDuTruVanPhongPhamTheoTo);
                rpt.Load(path);
                B006_BindingData(data, rpt);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void B006_BaoCaoDuTruVanPhongPhamTheoTo(B006_BaoCaoDuTruVanPhongPhamTheoTo data, Constants.ExportType type)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B006_BaoCaoDuTruVanPhongPhamTheoTo);
                rpt.Load(path);
                B006_BindingData(data, rpt);
                string tempPath = Path.Combine(Path.GetTempPath(), Constants.FileName.HanhChinh.B006_BaoCaoDuTruVanPhongPhamTheoTo);
                tempPath = Export(rpt, tempPath, type);
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void B006_BindingData(B006_BaoCaoDuTruVanPhongPhamTheoTo data, ReportDocument rpt)
        {
            if (data.ListVanPhongPham != null)
            {
                DataTable dt = ConvertToDataTable(data.ListVanPhongPham);
                rpt.SetDataSource(dt);
            }

            ReplaceData(rpt, "ThangDuTru", string.IsNullOrEmpty(data.ThangDuTru) ? string.Empty : data.ThangDuTru);
            ReplaceData(rpt, "Nhom", string.IsNullOrEmpty(data.Nhom) ? string.Empty : data.Nhom);
            ReplaceData(rpt, "NguoiDuTru", string.IsNullOrEmpty(data.NguoiDuTru) ? string.Empty : data.NguoiDuTru);
            ReplaceData(rpt, "NguoiNhan", string.IsNullOrEmpty(data.NguoiNhan) ? string.Empty : data.NguoiNhan);
            ReplaceData(rpt, "NhomTruong", string.IsNullOrEmpty(data.NhomTruong) ? string.Empty : data.NhomTruong);
            ReplaceData(rpt, "LanhDao", string.IsNullOrEmpty(data.LanhDao) ? string.Empty : data.LanhDao);
        }

        #endregion

        #region B007_BaoCaoDuTruVanPhongPham

        public void B007_BaoCaoDuTruVanPhongPham(B007_BaoCaoDuTruVanPhongPham data)
        {
            if (data == null)
                return;

            string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B007_BaoCaoDuTruVanPhongPham);
            string tempPath = string.Empty;
            String result = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = ReplaceDataB007(data, line);
                        line = result = result + line;
                    }

                    string fileName = Constants.FileName.HanhChinh.B007_BaoCaoDuTruVanPhongPham + ".html";
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

        private static string ReplaceDataB007(B007_BaoCaoDuTruVanPhongPham data, String line)
        {
            line = line.Replace("$Tong", string.IsNullOrEmpty(data.Tong) ? string.Empty : data.Tong);
            line = line.Replace("$ThangDuTru", string.IsNullOrEmpty(data.ThangDuTru) ? string.Empty : data.ThangDuTru);
            string dataTable = GetDanhSachVanPhongPhamB007(data.ListVanPhongPham);
            line = line.Replace("$DataTable", string.IsNullOrEmpty(dataTable) ? string.Empty : dataTable);
            line = line.Replace("$NgayLap", string.IsNullOrEmpty(data.NgayLapBaoCao) ? Constants.EmptyData.NgayViet : data.NgayLapBaoCao);
            return line;
        }

        private static string GetDanhSachVanPhongPhamB007(List<VanPhongPham> list)
        {
            if (list.Count == 0)
                return string.Empty;

            string dataTable = string.Empty;
            int stt = 0;
            foreach (VanPhongPham item in list)
            {
                stt++;
                dataTable = dataTable + "<tr>";
                dataTable = dataTable + "<td class='tr10 td20'><p class='p5 ft4'>" + stt + "</p></td>";
                dataTable = dataTable + "<td class='tr10 td21'><p class='p5 ft4'>" + item.VatTuSanPham + "</p></td>";
                dataTable = dataTable + "<td class='tr10 td22'><p class='p6 ft4'>" + item.DonVi + "</p></td>";
                dataTable = dataTable + "<td class='tr10 td23'><p class='p7 ft4'>" + item.SoLuongDuTru + "</p></td>";
                dataTable = dataTable + "<td class='tr10 td24'><p class='p8 ft4'>" + item.GhiChu + "</p></td>";
                dataTable = dataTable + "</tr>";
            }

            return dataTable;
        }

        #endregion

        #region B008_BaoCaoTonKhoThietBiLamSang

        public void B008_BaoCaoTonKhoThietBiLamSang(B008_BaoCaoTonKhoThietBiLamSang data)
        {
            if (data == null)
                return;

            string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B008_BaoCaoTonKhoThietBiLamSang);
            string tempPath = string.Empty;
            String result = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = ReplaceDataB008(data, line);
                        line = result = result + line;
                    }

                    string fileName = Constants.FileName.HanhChinh.B008_BaoCaoTonKhoThietBiLamSang + ".html";
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

        private static string ReplaceDataB008(B008_BaoCaoTonKhoThietBiLamSang data, String line)
        {
            line = line.Replace("$Loai", string.IsNullOrEmpty(data.Loai) ? string.Empty : data.Loai);
            string dataTable = GetDanhSachThietBi(data.ListThietBi);
            line = line.Replace("$DataTable", string.IsNullOrEmpty(dataTable) ? string.Empty : dataTable);
            return line;
        }

        private static string GetDanhSachThietBi(List<ThietBi> list)
        {
            if (list.Count == 0)
                return string.Empty;

            string table = string.Empty;
            int stt = 0;
            foreach (ThietBi item in list)
            {
                stt++;
                table = table + "<TR>";
                table = table + "<TD class='tr8 td15'><P class='p10 ft4'>" + stt.ToString() + "</P></TD>";
                table = table + "<TD class='tr8 td16'><P class='p0 ft0'>&nbsp;</P></TD>";
                table = table + "<TD class='tr8 td17'><P class='p11 ft6'>" + item.Ngay + "</P></TD>";
                table = table + "<TD class='tr8 td11'><P class='p0 ft4'>" + item.NoiDung + "</P></TD>";
                table = table + "<TD class='tr8 td18'><P class='p0 ft0'>&nbsp;</P></TD>";
                table = table + "<TD class='tr8 td19'><P class='p12 ft4'>" + item.TinhTrang + "</P></TD>";
                table = table + "<TD class='tr8 td20'><P class='p13 ft4'>" + item.Nhap + "</P></TD>";
                table = table + "<TD class='tr8 td20'><P class='p0 ft0'>" + item.Xuat + "</P></TD>";
                table = table + "<TD class='tr8 td20'><P class='p13 ft4'>" + item.Ton + "</P></TD>";
                table = table + "</TR>";
            }

            return table;
        }

        #endregion

        #region B009_BaoCaoTonKhoThietBiTienLamSang

        public ReportDocument B009_BaoCaoTonKhoThietBiTienLamSang(List<B009_BaoCaoTonKhoThietBiTienLamSang> data)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B009_BaoCaoTonKhoThietBiTienLamSang);
                rpt.Load(path);
                B009_BindingData(data, rpt);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void B009_BaoCaoTonKhoThietBiTienLamSang(List<B009_BaoCaoTonKhoThietBiTienLamSang> data, Constants.ExportType type)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B009_BaoCaoTonKhoThietBiTienLamSang);
                rpt.Load(path);
                B009_BindingData(data, rpt);
                string tempPath = Path.Combine(Path.GetTempPath(), Constants.FileName.HanhChinh.B009_BaoCaoTonKhoThietBiTienLamSang);
                tempPath = Export(rpt, tempPath, type);
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void B009_BindingData(List<B009_BaoCaoTonKhoThietBiTienLamSang> data, ReportDocument rpt)
        {
            if (data.Count() > 0)
            {
                DataTable dt = ConvertToDataTable(data);
                rpt.SetDataSource(dt);
            }
        }

        #endregion

        #region B010_BaoCaoTrangThietBi

        public ReportDocument B010_BaoCaoTrangThietBi(B010_BaoCaoTrangThietBi data)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B010_BaoCaoTrangThietBi);
                rpt.Load(path);
                B010_BindingData(data, rpt);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void B010_BaoCaoTrangThietBi(B010_BaoCaoTrangThietBi data, Constants.ExportType type)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B010_BaoCaoTrangThietBi);
                rpt.Load(path);
                B010_BindingData(data, rpt);
                string tempPath = Path.Combine(Path.GetTempPath(), Constants.FileName.HanhChinh.B010_BaoCaoTrangThietBi);
                tempPath = Export(rpt, tempPath, type);
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void B010_BindingData(B010_BaoCaoTrangThietBi data, ReportDocument rpt)
        {
            if (data.ListTrangThietBi != null)
            {
                DataTable dt = ConvertToDataTable(data.ListTrangThietBi);
                rpt.SetDataSource(dt);
            }

            ReplaceData(rpt, "NgayBatDau", string.IsNullOrEmpty(data.NgayBatDau) ? string.Empty : data.NgayBatDau);
            ReplaceData(rpt, "NgayKetThuc", string.IsNullOrEmpty(data.NgayKetThuc) ? string.Empty : data.NgayKetThuc);
            ReplaceData(rpt, "TongSoTrangThietBi", string.IsNullOrEmpty(data.TongSoTrangThietBi) ? string.Empty : data.TongSoTrangThietBi);
            ReplaceData(rpt, "NgayLapBaoCao", string.IsNullOrEmpty(data.NgayLapBaoCao) ? Constants.EmptyData.NgayViet : data.NgayLapBaoCao);
            ReplaceData(rpt, "NguoiLapBaoCao", string.IsNullOrEmpty(data.NguoiLapBaoCao) ? string.Empty : data.NguoiLapBaoCao);
        }

        #endregion

        #region P001_PhieuMuonThietBi

        public ReportDocument P001_PhieuMuonThietBi(P001_PhieuMuonThietBi data)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.P001_PhieuMuonThietBi);
                rpt.Load(path);
                P001_BindingData(data, rpt);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void P001_PhieuMuonThietBi(P001_PhieuMuonThietBi data, Constants.ExportType type)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.P001_PhieuMuonThietBi);
                rpt.Load(path);
                P001_BindingData(data, rpt);
                string tempPath = Path.Combine(Path.GetTempPath(), Constants.FileName.HanhChinh.P001_PhieuMuonThietBi);
                tempPath = Export(rpt, tempPath, type);
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void P001_BindingData(P001_PhieuMuonThietBi data, ReportDocument rpt)
        {
            if (data.ListNoiDungThietBi != null)
            {
                DataTable dt = ConvertToDataTable(data.ListNoiDungThietBi);
                rpt.SetDataSource(dt);
            }

            ReplaceData(rpt, "NgayVietPhieu", string.IsNullOrEmpty(data.NgayVietPhieu) ? Constants.EmptyData.NgayViet : data.NgayVietPhieu);
            ReplaceData(rpt, "DaiDienBenGiao", string.IsNullOrEmpty(data.DaiDienBenGiao) ? string.Empty : data.DaiDienBenGiao);
            ReplaceData(rpt, "NguoiGiao1", string.IsNullOrEmpty(data.NguoiGiao1) ? string.Empty : data.NguoiGiao1);
            ReplaceData(rpt, "NguoiGiao2", string.IsNullOrEmpty(data.NguoiGiao2) ? string.Empty : data.NguoiGiao2);
            ReplaceData(rpt, "NguoiGiao3", string.IsNullOrEmpty(data.NguoiGiao3) ? string.Empty : data.NguoiGiao3);
            ReplaceData(rpt, "ChucVuGiao1", string.IsNullOrEmpty(data.ChucVuGiao1) ? string.Empty : data.ChucVuGiao1);
            ReplaceData(rpt, "ChucVuGiao2", string.IsNullOrEmpty(data.ChucVuGiao2) ? string.Empty : data.ChucVuGiao2);
            ReplaceData(rpt, "ChucVuGiao3", string.IsNullOrEmpty(data.ChucVuGiao3) ? string.Empty : data.ChucVuGiao3);
            ReplaceData(rpt, "DaiDienBenMuon", string.IsNullOrEmpty(data.DaiDienBenMuon) ? string.Empty : data.DaiDienBenMuon);
            ReplaceData(rpt, "NguoiMuon1", string.IsNullOrEmpty(data.NguoiMuon1) ? string.Empty : data.NguoiMuon1);
            ReplaceData(rpt, "NguoiMuon2", string.IsNullOrEmpty(data.NguoiMuon2) ? string.Empty : data.NguoiMuon2);
            ReplaceData(rpt, "NguoiMuon3", string.IsNullOrEmpty(data.NguoiMuon3) ? string.Empty : data.NguoiMuon3);
            ReplaceData(rpt, "ChucVuMuon1", string.IsNullOrEmpty(data.ChucVuMuon1) ? string.Empty : data.ChucVuMuon1);
            ReplaceData(rpt, "ChucVuMuon2", string.IsNullOrEmpty(data.ChucVuMuon2) ? string.Empty : data.ChucVuMuon2);
            ReplaceData(rpt, "ChucVuMuon3", string.IsNullOrEmpty(data.ChucVuMuon3) ? string.Empty : data.ChucVuMuon3);
            ReplaceData(rpt, "DiaDiemMuon", string.IsNullOrEmpty(data.DiaDiemMuon) ? string.Empty : data.DiaDiemMuon);
            ReplaceData(rpt, "ThoiGianMuon", string.IsNullOrEmpty(data.ThoiGianMuon) ? string.Empty : data.ThoiGianMuon);
            ReplaceData(rpt, "KyDaiDienBenGiao", string.IsNullOrEmpty(data.KyDaiDienBenGiao) ? string.Empty : data.KyDaiDienBenGiao);
            ReplaceData(rpt, "KyDaiDienBenNhan", string.IsNullOrEmpty(data.KyDaiDienBenNhan) ? string.Empty : data.KyDaiDienBenNhan);
        }

        #endregion

        #region B100_BaoCaoChung

        

        private static string B100_GenTableTitle(B100_BaoCaoChung baocao)
        {
            string str = string.Empty;
            str += "<tr style='font-weight: bold;'>";
            if (baocao.AutoGenSTT)
                str += "<td class='cell' style='width:20px'>STT</td>";
            if (baocao.E_Width != null && baocao.E_Width.Count == baocao.E_TieuDe.Count)
            {
                for (int i = 0; i < baocao.E_TieuDe.Count; i++)
                {
                    if (baocao.E_TieuDe[i].IndexOf("[$..") < 0)
                        str += string.Format("<td class='cell' style='width:{0}px'>{1}</td>", baocao.E_Width[i], baocao.E_TieuDe[i]);
                }
            }
            else
            {
                foreach (string td in baocao.E_TieuDe)
                {
                    if (td.IndexOf("[$..") < 0)
                        str += string.Format("<td class='cell'>{0}</td>", td);
                }
            }
            str += "</tr>";
            return str;
        }
        private static string B100_GenTableType1(B100_BaoCaoChung baocao)
        {
            if (baocao.E_TieuDe == null)
                return string.Empty;
            string str = B100_GenTableTitle(baocao);
            int count = 1;
            foreach (B100_Table tb in baocao.E_Content)
            {
                str += "<tr>";
                if (baocao.AutoGenSTT)
                {

                    str += "<td class='cell' >" + count.ToString() + "</td>";
                    count++;
                }
                
                foreach (string td in tb.E_Value)
                {
                    if (td.IndexOf("[$..") < 0)
                    {
                        if (baocao.E_isCenter)
                            str += "<td class='cell'>" + ReplaceContent(td) + "</td>";
                        else
                            str += "<td class = 'cell2'>" + ReplaceContent(td) + "</td>";
                    }
                }
                str += "</tr>";
            }
            return str;
        }
        private static string[] RS = new string[] {"\n" };
        private static string[] RF = new string[] { "</br>"};
        private static string ReplaceContent(string content)
        {
            for (int i = 0; i < RS.Length; i++)
            {
                content = content.Replace(RS[i], RF[i]);
            }
            return content;
        }
        private static string B100_GenTableType2(B100_BaoCaoChung baocao)
        {
            if (baocao.E_TieuDe == null)
                return string.Empty;
            string str = B100_GenTableTitle(baocao);
            int count = 1;
            int countSimilarRow = 1;
            string Similar = string.Empty;
            foreach (B100_Table tb in baocao.E_Content)
            {
                str += "<tr>";
                if (baocao.AutoGenSTT)
                {
                    str += "<td class='cell' >" + count.ToString() + "</td>";
                    count++;
                }
                for (int i = 0; i < tb.E_Value.Count; i++)
                {
                    if (i == 0)
                    {
                        if (tb.E_Value[i] == Similar)
                        {
                            countSimilarRow++;
                        }
                        else
                        {
                            str = str.Replace("$rowsspanNum", countSimilarRow.ToString());
                            if (baocao.E_isCenter)
                                str += "<td class='cell' rowSpan='$rowsspanNum'>" + ReplaceContent(tb.E_Value[i]) + "</td>";
                            else
                                str += "<td class='cell2' rowSpan='$rowsspanNum'>" + ReplaceContent(tb.E_Value[i]) + "</td>";
                            Similar = tb.E_Value[i];
                            countSimilarRow = 1;
                        }
                    }
                    else
                    {
                        if (baocao.E_isCenter)
                            str += "<td class='cell'>" + ReplaceContent(tb.E_Value[i]) + "</td>";
                        else
                            str += "<td class='cell2'>" + ReplaceContent(tb.E_Value[i]) + "</td>";
                    }
                }
                str += "</tr>";
            }
            str = str.Replace("$rowsspanNum", countSimilarRow.ToString());
            return str;
        }
        public void B100_GenReport(B100_BaoCaoChung data)
        {
            B100_GenReport(data, 1);
        }
        public void B100_GenReport(B100_BaoCaoChung data, int type)
        {
            if (data == null)
                return;

            string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B100_BaoCaoChung);
            string tempPath = string.Empty;
            String result = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = ReplaceDataB100(data, line,type);
                        line = result = result + line;
                    }

                    string fileName = Constants.FileName.HanhChinh.B100_BaoCaoChung + ".html";
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
        private static string ReplaceDataB100(B100_BaoCaoChung data, String line, int type)
        { 
            char[] tenTrungTam = data.E_TenTrungTam.ToCharArray();
            if (tenTrungTam.Length > 15)
                line = line.Replace("$TenBenhVienWidth", "380px");
            else
                line = line.Replace("$TenBenhVienWidth", "220px");
            line = line.Replace("$tentrungtam", data.E_TenTrungTam);
            line = line.Replace("$tenbaocao", data.E_TieuDeBaoCao);
            line = line.Replace("$tenlophoc", data.E_TieuDeLop);
            line = line.Replace("$malop", data.E_MaLop);
            line = line.Replace("$tungaydenngay", data.E_TuNgayDenNgay);
            line = line.Replace("$ngaylapbaocao", data.E_HaNoiNgayThangNam);
            //line = line.Replace("$sotiet", data.E_SoTiet);
            //line = line.Replace("$quyetdinh", data.E_QuyetDinh);
            line = line.Replace("$nguoiki", data.E_NguoiKi);
            line = line.Replace("$paperWidth", data.E_PaperWidth);
            line = line.Replace("$conghoaxahoi", data.E_CongHoaXaHoi);
            line = line.Replace("$doclaptudohanhphuc", data.E_DocLapTuDo);
            line = line.Replace("$thongtinkhac", data.E_ThongTinKhac);
            line = line.Replace("$TenBenhVien", data.E_TenBenhVien);
            line = line.Replace("$TDCnlbc", data.E_NoiLapBC);
            line = line.Replace("$TenPhong1", data.E_Phong1);
            line = line.Replace("$TenPhong2", data.E_Phong2);
            line = line.Replace("$P1", data.E_P1);
            line = line.Replace("$P2", data.E_P2);
            if (!string.IsNullOrEmpty(data.E_TenTrungTamLapBC))
                line = line.Replace("$TenTrungTamLapBC", data.E_TenTrungTamLapBC.ToUpper());
            else
                line = line.Replace("$TenTrungTamLapBC", string.Empty);
            
            if (data.E_IsUseTongSo)
                line = line.Replace("$thongtintonghop", string.Format("Tổng số: {0}",data.E_TongSoBanGhi));
            else
                line = line.Replace("$thongtintonghop", data.E_ThongTinTongHop);

            string dataTable = string.Empty;
            switch (type)
            {
                case 2: dataTable = B100_GenTableType2(data); break;
                default: dataTable = B100_GenTableType1(data); break;
            }


            line = line.Replace("$table", string.IsNullOrEmpty(dataTable) ? string.Empty : dataTable);
            return line;
        }

        #endregion
        #region B103_HVduoccapchungchitheolop



        private static string B103_GenTableTitle(B103_HVduoccapchungchitheolop baocao)
        {
            string str = string.Empty;
            str += "<tr style='font-weight: bold;'>";
            if (baocao.AutoGenSTT)
                str += "<td class='cell' style='width:20px'>STT</td>";
            if (baocao.E_Width != null && baocao.E_Width.Count == baocao.E_TieuDe.Count)
            {
                for (int i = 0; i < baocao.E_TieuDe.Count; i++)
                {
                    if (baocao.E_TieuDe[i].IndexOf("[$..") < 0)
                        str += string.Format("<td class='cell' style='width:{0}px'>{1}</td>", baocao.E_Width[i], baocao.E_TieuDe[i]);
                }
            }
            else
            {
                foreach (string td in baocao.E_TieuDe)
                {
                    if (td.IndexOf("[$..") < 0)
                        str += string.Format("<td class='cell'>{0}</td>", td);
                }
            }
            str += "</tr>";
            return str;
        }
        private static string B103_GenTableType1(B103_HVduoccapchungchitheolop baocao)
        {
            if (baocao.E_TieuDe == null)
                return string.Empty;
            string str = B103_GenTableTitle(baocao);
            int count = 1;
            foreach (B103_Table tb in baocao.E_Content)
            {
                str += "<tr>";
                if (baocao.AutoGenSTT)
                {

                    str += "<td class='cell' >" + count.ToString() + "</td>";
                    count++;
                }

                foreach (string td in tb.E_Value)
                {
                    if (td.IndexOf("[$..") < 0)
                    {
                        if (baocao.E_isCenter)
                            str += "<td class='cell'>" + ReplaceContents(td) + "</td>";
                        else
                            str += "<td class = 'cell2'>" + ReplaceContents(td) + "</td>";
                    }
                }
                str += "</tr>";
            }
            return str;
        }
        private static string[] RSS = new string[] { "\n" };
        private static string[] RFF = new string[] { "</br>" };
        private static string ReplaceContents(string content)
        {
            for (int i = 0; i < RSS.Length; i++)
            {
                content = content.Replace(RSS[i], RFF[i]);
            }
            return content;
        }
        private static string B103_GenTableType2(B103_HVduoccapchungchitheolop baocao)
        {
            if (baocao.E_TieuDe == null)
                return string.Empty;
            string str = B103_GenTableTitle(baocao);
            int count = 1;
            int countSimilarRow = 1;
            string Similar = string.Empty;
            foreach (B103_Table tb in baocao.E_Content)
            {
                str += "<tr>";
                if (baocao.AutoGenSTT)
                {
                    str += "<td class='cell' >" + count.ToString() + "</td>";
                    count++;
                }
                for (int i = 0; i < tb.E_Value.Count; i++)
                {
                    if (i == 0)
                    {
                        if (tb.E_Value[i] == Similar)
                        {
                            countSimilarRow++;
                        }
                        else
                        {
                            str = str.Replace("$rowsspanNum", countSimilarRow.ToString());
                            if (baocao.E_isCenter)
                                str += "<td class='cell' rowSpan='$rowsspanNum'>" + ReplaceContents(tb.E_Value[i]) + "</td>";
                            else
                                str += "<td class='cell2' rowSpan='$rowsspanNum'>" + ReplaceContents(tb.E_Value[i]) + "</td>";
                            Similar = tb.E_Value[i];
                            countSimilarRow = 1;
                        }
                    }
                    else
                    {
                        if (baocao.E_isCenter)
                            str += "<td class='cell'>" + ReplaceContents(tb.E_Value[i]) + "</td>";
                        else
                            str += "<td class='cell2'>" + ReplaceContents(tb.E_Value[i]) + "</td>";
                    }
                }
                str += "</tr>";
            }
            str = str.Replace("$rowsspanNum", countSimilarRow.ToString());
            return str;
        }
        public void B103_GenReport(B103_HVduoccapchungchitheolop data)
        {
            B103_GenReport(data, 1);
        }
        public void B103_GenReport(B103_HVduoccapchungchitheolop data, int type)
        {
            if (data == null)
                return;

            string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B103_HVduoccapchungchitheolop);
            string tempPath = string.Empty;
            String result = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = ReplaceDataB103(data, line, type);
                        line = result = result + line;
                    }

                    string fileName = Constants.FileName.HanhChinh.B103_HVduoccapchungchitheolop + ".html";
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
        private static string ReplaceDataB103(B103_HVduoccapchungchitheolop data, String line, int type)
        {
            char[] tenTrungTam = data.E_TenTrungTam.ToCharArray();
            if (tenTrungTam.Length > 15)
                line = line.Replace("$TenBenhVienWidth", "380px");
            else
                line = line.Replace("$TenBenhVienWidth", "220px");
            line = line.Replace("$tentrungtam", data.E_TenTrungTam);
            line = line.Replace("$tenbaocao", data.E_TieuDeBaoCao);
            line = line.Replace("$tenlophoc", data.E_TieuDeLop);
            line = line.Replace("$malop", data.E_MaLop);
            line = line.Replace("$tungaydenngay", data.E_TuNgayDenNgay);
            line = line.Replace("$ngaylapbaocao", data.E_HaNoiNgayThangNam);
            line = line.Replace("$sotiet", data.E_SoTiet);
            line = line.Replace("$quyetdinh", data.E_QuyetDinh);
            line = line.Replace("$nguoiki", data.E_NguoiKi);
            line = line.Replace("$paperWidth", data.E_PaperWidth);
            line = line.Replace("$conghoaxahoi", data.E_CongHoaXaHoi);
            line = line.Replace("$doclaptudohanhphuc", data.E_DocLapTuDo);
            line = line.Replace("$thongtinkhac", data.E_ThongTinKhac);
            line = line.Replace("$TenBenhVien", data.E_TenBenhVien);
            line = line.Replace("$TDCnlbc", data.E_NoiLapBC);
            line = line.Replace("$TenPhong1", data.E_Phong1);
            line = line.Replace("$TenPhong2", data.E_Phong2);
            line = line.Replace("$P1", data.E_P1);
            line = line.Replace("$P2", data.E_P2);
            if (!string.IsNullOrEmpty(data.E_TenTrungTamLapBC))
                line = line.Replace("$TenTrungTamLapBC", data.E_TenTrungTamLapBC.ToUpper());
            else
                line = line.Replace("$TenTrungTamLapBC", string.Empty);

            if (data.E_IsUseTongSo)
                line = line.Replace("$thongtintonghop", string.Format("Tổng số: {0}", data.E_TongSoBanGhi));
            else
                line = line.Replace("$thongtintonghop", data.E_ThongTinTongHop);

            string dataTable = string.Empty;
            switch (type)
            {
                case 2: dataTable = B103_GenTableType2(data); break;
                default: dataTable = B103_GenTableType1(data); break;
            }


            line = line.Replace("$table", string.IsNullOrEmpty(dataTable) ? string.Empty : dataTable);
            return line;
        }

        #endregion

        #region B020_SoTheoDoiHocTap

        public void B020_SoTheoDoiHocTap(string tenLop)
        {
            string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B020_SoTheoDoiHocTap);
            string tempPath = string.Empty;
            String result = string.Empty;
            string HN = "Hà Nội, năm " + DateTime.Now.Year.ToString();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.Replace("$tenlop", tenLop);
                        line = line.Replace("$hanoingaythangnam", HN);
                        result += line;
                    }

                    string fileName = Constants.FileName.HanhChinh.B020_SoTheoDoiHocTap + ".html";
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
       

        #endregion


        #region P100_PhieuMuon

        private static string P100_GenTable(P001_PhieuMuonThietBi baocao)
        {
            if (baocao == null || baocao.ListNoiDungThietBi == null)
                return string.Empty;
            string str = string.Empty;
            foreach (NoiDungThietBi item in baocao.ListNoiDungThietBi)
            {
                str += "<TR>";
                str += "	<TD colspan=2 class='tr6 td34'><P class='p9 ft5'>" + item.STT + "</P></TD>";
                str += "	<TD class='tr6 td35'><P class='p10 ft5'>" + item.TenThietBi + "</P></TD>";
                str += "	<TD class='tr6 td11'><P class='p0 ft0'>&nbsp;</P></TD>";
                str += "<TD class='tr6 td36'><P class='p0 ft0'>&nbsp;</P></TD>";
                str += "	<TD class='tr6 td7'><P class='p3 ft5'>" + item.Serial + "</P></TD>";
                str += "<TD class='tr6 td37'><P class='p0 ft0'>&nbsp;</P></TD>";
                str += "	<TD class='tr6 td38'><P class='p11 ft5'>" + item.XuatSu + "</P></TD>";
                str += "	<TD class='tr6 td39'><P class='p12 ft5'>" + item.DonVi + "</P></TD>";
                str += "	<TD colspan=2 class='tr6 td40'><P class='p13 ft5'>" + item.SoLuong + "</P></TD>";
                str += "	<TD class='tr6 td1'><P class='p0 ft0'>&nbsp;</P></TD>";
                str += "	<TD class='tr6 td41'><P class='p14 ft5'>" + item.GhiChu + "</P></TD>";
                str += "</TR>";
            }
            return str;
        }
        public void P100_GenReport(P001_PhieuMuonThietBi data)
        {
            if (data == null)
                return;

            string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.P100_PhieuMuon);
            string tempPath = string.Empty;
            String result = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = ReplaceDataP100(data, line);
                        line = result = result + line;
                    }

                    string fileName = Constants.FileName.HanhChinh.P001_PhieuMuonThietBi + ".html";
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
        private static string ReplaceDataP100(P001_PhieuMuonThietBi data, String line)
        {
            line = line.Replace("$NgayVietPhieu", data.NgayVietPhieu);
            line = line.Replace("$DaiDienBenGiao", data.DaiDienBenGiao);
            line = line.Replace("$NguoiGiao1", data.NguoiGiao1);
            line = line.Replace("$NguoiGiao2", data.NguoiGiao2);
            line = line.Replace("$NguoiGiao3", data.NguoiGiao3);
            line = line.Replace("$ChucVuGiao1", data.ChucVuGiao1);
            line = line.Replace("$ChucVuGiao2", data.ChucVuGiao2);
            line = line.Replace("$ChucVuGiao3", data.ChucVuGiao3);
            line = line.Replace("$DaiDienBenMuon", data.DaiDienBenMuon);
            line = line.Replace("$NguoiMuon1", data.NguoiMuon1);
            line = line.Replace("$NguoiMuon2", data.NguoiMuon2);
            line = line.Replace("$NguoiMuon3", data.NguoiMuon3);
            line = line.Replace("$ChucVuMuon1", data.ChucVuMuon1);
            line = line.Replace("$ChucVuMuon2", data.ChucVuMuon2);
            line = line.Replace("$ChucVuMuon3", data.ChucVuMuon3);
            line = line.Replace("$DiaDiemMuon", data.DiaDiemMuon);
            line = line.Replace("$ThoiGianMuon", data.ThoiGianMuon);
            line = line.Replace("$KyDaiDienBenGiao", data.KyDaiDienBenGiao);
            line = line.Replace("$KyDaiDienBenNhan", data.KyDaiDienBenNhan);
            line = line.Replace("$GiaoMuon", data.NhanOrMuon);
            line = line.Replace("$TieuDe", data.TenBaoCao);
            line = line.Replace("$other", data.Warning);
            string dataTable = P100_GenTable(data);
            line = line.Replace("$DataTable",  dataTable);
            return line;
        }

        #endregion

        #region P005_PhieuDangKiGiangDuongPhongHoc

        public ReportDocument P005_PhieuDangKiGiangDuongPhongHoc(P005_PhieuDangKiGiangDuongPhongHoc data)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.P005_PhieuDangKiGiangDuongPhongHoc);
                rpt.Load(path);
                P005_BindingData(data, rpt);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void P005_PhieuDangKiGiangDuongPhongHoc(P005_PhieuDangKiGiangDuongPhongHoc data, Constants.ExportType type)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.P005_PhieuDangKiGiangDuongPhongHoc);
                rpt.Load(path);
                P005_BindingData(data, rpt);
                string tempPath = Path.Combine(Path.GetTempPath(), Constants.FileName.HanhChinh.P005_PhieuDangKiGiangDuongPhongHoc);
                tempPath = Export(rpt, tempPath, type);
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void P005_BindingData(P005_PhieuDangKiGiangDuongPhongHoc data, ReportDocument rpt)
        {
            ReplaceData(rpt, "NoiDungSuDung", string.IsNullOrEmpty(data.NoiDungSuDung) ? string.Empty : data.NoiDungSuDung);
            ReplaceData(rpt, "PhongDangKy", string.IsNullOrEmpty(data.PhongDangKy) ? string.Empty : data.PhongDangKy);
            ReplaceData(rpt, "NguoiChuTri", string.IsNullOrEmpty(data.NguoiChuTri) ? string.Empty : data.NguoiChuTri);
            ReplaceData(rpt, "ThoiGianSuDung", string.IsNullOrEmpty(data.ThoiGianSuDung) ? string.Empty : data.ThoiGianSuDung);
            ReplaceData(rpt, "SoNguoiThamDu", string.IsNullOrEmpty(data.SoNguoiThamDu) ? string.Empty : data.SoNguoiThamDu);
            ReplaceData(rpt, "YeuCauKhac", string.IsNullOrEmpty(data.YeuCauKhac) ? string.Empty : data.YeuCauKhac);
            ReplaceData(rpt, "ThoiGianNhap", string.IsNullOrEmpty(data.ThoiGianNhap) ? string.Empty : data.ThoiGianNhap);
            ReplaceData(rpt, "CanBoDangKy", string.IsNullOrEmpty(data.CanBoDangKy) ? string.Empty : data.CanBoDangKy);
            ReplaceData(rpt, "CanBoQuanLy", string.IsNullOrEmpty(data.CanBoQuanLy) ? string.Empty : data.CanBoQuanLy);
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
