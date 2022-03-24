using Export.Entities.DaoTao;
using Export.Entities.HanhChinh;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExportLib.Entities.DaoTao;
using System.Collections.Generic;

namespace Export
{
    public class MainExport
    {
        public void ExportGIayHenTraThe()
        {
            DataDaoTao getdt = new DataDaoTao();

            G001_GiayHenTraChungChiHocVien data1 = getdt.GetGiayHenTraTheHocVien();
            G001_GiayHenTraChungChiHocVien data2 = getdt.GetGiayHenTraTheHocVien();
            List<G001_GiayHenTraChungChiHocVien> list = new List<G001_GiayHenTraChungChiHocVien>();
            list.Add(data1);
            list.Add(data2);
            ExportLib.Export export = new ExportLib.Export();
            export.G001_GiayHenTraChungChiHocVien(list);
        }

        public void ExportSoTheoDoiHocTap()
        {
            DataDaoTao getdt = new DataDaoTao();
            SoTheoDoiHocTap data = getdt.getSoTheoDoiHocTap();
            string appPath = Application.StartupPath.Substring(0, Application.StartupPath.IndexOf("bin"));
            string dbPath = @"Templates\Daotao\SoTheoDoiHocTap.html";

            string fullpath = appPath + dbPath;
            String result = String.Empty;
            using (StreamReader sr = new StreamReader(fullpath))
            {
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Replace("$Khoa", data.Khoa);
                    line = line.Replace("$Tie", data.Khoas);
                    line = line.Replace("$Nam", data.Nam);
                    line = result = result + line;
                }
                string tenFiles = "SoTheoDoiHocTap.html";
                StreamWriter oWriter = new StreamWriter(@"C:\" + tenFiles);
                oWriter.Write(result);
                oWriter.Close();
            }
        }

        public void ExportBaoCaoDuTruVanPhongPham()
        {
            DataHanhChinh getdt = new DataHanhChinh();
            BaoCaoDuTruVanPhongPham data = getdt.GetDataBaoCaoDuTruVanPhongPham();
            string appPath = Application.StartupPath.Substring(0, Application.StartupPath.IndexOf("bin"));
            string dbPath = @"Templates\HanhChinh\BaoCaoDuTruVanPhongPham.html";

            string fullpath = appPath + dbPath;
            String result = String.Empty;

            String table = String.Empty;
            int stt = 0;
            foreach (var item in data.listVanPhongPham)
            {
                stt++;
                table = table + "<TR>";
                table = table + "<TD class='tr0 td12'><P class='p5 ft4'>" + stt.ToString() + "</P></TD>";
                table = table + "<TD class='tr0 td13'><P class='p5 ft4'>" + item.DanhMuc + "</P></TD>";
                table = table + "<TD class='tr0 td14'><P class='p6 ft4'>" + item.DonVi + "</P></TD>";
                table = table + "<TD class='tr0 td15'><P class='p7 ft4'>" + item.SoLuong + "</P></TD>";
                table = table + "<TD class='tr0 td16'><P class='p8 ft4'>" + item.GhiChu + "</P></TD>";
                table = table + "</TR>";
            }

            using (StreamReader sr = new StreamReader(fullpath))
            {
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Replace("$ThangNam", data.ThangNam);
                    line = line.Replace("$Khoan", data.Khoan);
                    line = line.Replace("$ThoiGian", data.ThoiGian);
                    line = line.Replace("$DataTable", table);
                    line = result = result + line;
                }
                string tenFiles = "BaoCaoDuTruVanPhongPham.html";
                StreamWriter oWriter = new StreamWriter(@"C:\" + tenFiles);
                oWriter.Write(result);
                oWriter.Close();
            }

            System.Diagnostics.Process.Start(@"C:\" + "BaoCaoDuTruVanPhongPham.html");
        }

        public  void ExportBaoTonKhoThietBiLamSang()
        {
            DataHanhChinh getdt = new DataHanhChinh();
            BaoCaoTonKhoThietBiLamSang data = getdt.GetDataBaoCaoTonKhoThietBiLamSang();
            string appPath = Application.StartupPath.Substring(0, Application.StartupPath.IndexOf("bin"));
            string dbPath = @"Templates\HanhChinh\BaoCaoTonKhoThietBiLamSang.html";

            string fullpath = appPath + dbPath;
            String result = String.Empty;

            String table = String.Empty;
            int stt = 0;
            foreach (var item in data.listThietBi)
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

            using (StreamReader sr = new StreamReader(fullpath))
            {
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Replace("$Loai", data.Loai);
                    line = line.Replace("$DataTable", table);
                    line = result = result + line;
                }
                string tenFiles = "BaoCaoTonKhoThietBiLamSang.html";
                StreamWriter oWriter = new StreamWriter(@"C:\" + tenFiles);
                oWriter.Write(result);
                oWriter.Close();
            }
        }
    }
}
