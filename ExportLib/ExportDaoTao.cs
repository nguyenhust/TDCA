using System;
using System.Collections.Generic;
using System.IO;
using ExportLib.Entities.DaoTao;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Diagnostics;
using System.Data;
using System.ComponentModel;
using System.Reflection;
using System.Drawing;
using System.Drawing.Text;
using System.Data.SqlClient;
using NETLINK.LIB;

namespace ExportLib
{
    public class ExportDaoTao
    {
        #region The Hoc Vien
        public void ExportTheHocVien(DT_TheHocVien data)
        {
            Image BackImg = Image.FromFile(string.Format("{0}\\Templates\\DaoTao\\{1}", Environment.CurrentDirectory, thehocvien.TLBackImg));
            Image TypeImg = Image.FromFile(string.Format("{0}\\Templates\\DaoTao\\{1}", Environment.CurrentDirectory, thehocvien.TLKhung1));
            Font barCodeFont;
            PrivateFontCollection xFont = new PrivateFontCollection();
            xFont.AddFontFile(string.Format("{0}\\Templates\\DaoTao\\39.ttf", Environment.CurrentDirectory));
            FontFamily tempF = xFont.Families[0];
            barCodeFont = new Font(tempF, Convert.ToInt32(thehocvien.TLFontSizeBarCode), System.Drawing.FontStyle.Regular);
            string font = thehocvien.TLFont;
            Image FaceImg;
            int y1 = 520;
            foreach (TheHocVien the in data.ListTheHocVien)
            {
                the.TenHocVien = GetTrinhDo(the.TrinhDo) + the.TenHocVien;
                try
                {
                    FaceImg = Image.FromFile(the.AnhHocVien);
                }
                catch
                {
                    FaceImg = Image.FromFile(string.Format("{0}\\Templates\\DaoTao\\{1}", Environment.CurrentDirectory, thehocvien.TLNoImg));
                }
                //string font = ;
                using (Graphics gra = Graphics.FromImage(BackImg))
                {
                    #region Anh hoc vien

                    gra.DrawImage(FaceImg, new Rectangle(25, 185, 270, 360));

                    #endregion
                    #region Anh hoc vien

                    gra.DrawImage(TypeImg, new Rectangle(310, y1 - 295, 680, 75));

                    #endregion
                    #region For Name on Card

                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;
                    gra.DrawString(the.TenHocVien.ToUpper(), new Font(font, 11, System.Drawing.FontStyle.Bold), new SolidBrush(System.Drawing.Color.White), new Point(640, y1 - 255), stringFormat);

                    #endregion

                    #region Khóa học

                    stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Near;
                    stringFormat.LineAlignment = StringAlignment.Near;
                    gra.DrawString("Khóa học:", new Font(font, 9, System.Drawing.FontStyle.Regular), new SolidBrush(System.Drawing.Color.DarkBlue), new Point(315, y1 - 180), stringFormat);

                    #endregion

                    #region Process Ten Khoa Hoc

                    string[] tenKhoaHoc = the.KhoaHoc.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    string KHline1 = string.Empty;
                    string KHline2 = string.Empty;
                    string KHline3 = string.Empty;
                    int count = 1;
                    foreach (string str in tenKhoaHoc)
                    {
                        if (count <= 4)
                        {
                            KHline1 += string.Format("{0} ", str);
                            count++;
                        }
                        else if (count < 9)
                        {
                            KHline2 += string.Format("{0} ", str);
                            count++;
                        }
                        else
                        {
                            KHline3 += string.Format("{0} ", str);
                        }
                    }
                    

                    #endregion

                    #region Ten Khoa Hoc line1

                    stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Near;
                    gra.DrawString(KHline1.ToUpper().Trim(), new Font(font, 9, System.Drawing.FontStyle.Regular), new SolidBrush(System.Drawing.Color.DarkBlue), new Point(725, y1 - 180), stringFormat);

                    #endregion

                    #region Ten Khoa Hoc line2

                    stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Near;
                    gra.DrawString(KHline2.Trim().ToUpper(), new Font(font, 9, System.Drawing.FontStyle.Regular), new SolidBrush(System.Drawing.Color.DarkBlue), new Point(700, y1 - 130), stringFormat);

                    #endregion

                    #region Ten Khoa Hoc line3

                    stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Near;
                    gra.DrawString(KHline3.Trim().ToUpper(), new Font(font, 9, System.Drawing.FontStyle.Regular), new SolidBrush(System.Drawing.Color.DarkBlue), new Point(700, y1 - 75), stringFormat);

                    #endregion

                    #region Thoi gian

                    stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Near;
                    stringFormat.LineAlignment = StringAlignment.Near;
                    gra.DrawString("Thời gian:", new Font(font, 9, System.Drawing.FontStyle.Regular), new SolidBrush(System.Drawing.Color.Red), new Point(315, y1), stringFormat);

                    #endregion

                    #region Thoi gian

                    stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Near;
                    gra.DrawString(the.ThoiGian, new Font(font, 9, System.Drawing.FontStyle.Regular), new SolidBrush(System.Drawing.Color.Red), new Point(720, y1), stringFormat);

                    #endregion

                    #region Ma hoc vien

                    stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Near;
                    gra.DrawString(the.MaHocVien.ToUpper(), new Font(font, 5, System.Drawing.FontStyle.Regular), new SolidBrush(System.Drawing.Color.DarkBlue), new Point(160, 545), stringFormat);

                    #endregion


                    // QuangBH comment 01-02-2015: A Chien Confirm bo ma vach
                    //#region Ma vach

                    //stringFormat = new StringFormat();
                    //stringFormat.Alignment = StringAlignment.Center;
                    //stringFormat.LineAlignment = StringAlignment.Near;
                    //gra.DrawString(the.SoCMT, barCodeFont, new SolidBrush(System.Drawing.Color.Black), new Point(640, y1), stringFormat);

                    //#endregion


                }
                string link = string.Format("{0}\\{1}{2}.jpg", Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), the.TenHocVien, the.SoCMT);
                BackImg.Save(link);
                Process.Start(link);
            }
        } 
        private string GetTrinhDo(string trinhdo)
        {
            return GlobalCommon.GetTrinhDobyID(trinhdo);
            //if (!string.IsNullOrEmpty(trinhdo))
            //{
            //    trinhdo = trinhdo.ToLower();
            //    if (trinhdo.IndexOf("bác sĩ")>=0)
            //        return "BS. ";
            //    if (trinhdo.IndexOf("điều dưỡng") >= 0)
            //        return "ĐD. ";
            //    if (trinhdo.IndexOf("y sĩ") >= 0)
            //        return "YS. ";
            //    if (trinhdo.IndexOf("y sỹ") >= 0)
            //        return "YS. ";
            //    if (trinhdo.IndexOf("kỹ thuật viên") >= 0)
            //        return "KTV. ";
            //    if (trinhdo.IndexOf("kĩ thuật viên") >= 0)
            //        return "KTV. ";
            //    if (trinhdo.IndexOf("dược sĩ") >= 0)
            //        return "DS. ";
            //    if (trinhdo.IndexOf("trung cấp") >= 0)
            //        return "TC. ";
            //    if (trinhdo.IndexOf("cử nhân") >= 0)
            //        return "CN. ";
            //    if (trinhdo.IndexOf("tiến sĩ") >= 0)
            //        return "TS. ";
            //    if (trinhdo.IndexOf("phó tiến sĩ") >= 0)
            //        return "PTS. ";
            //    return string.Empty;
            //}
            //else
            //{
            //    return "";
            //}
        }
        
        public void ExportTheHocVienLienTuc(DT_TheHocVienLienTuc data, int doituong)
        {
            Image BackImgRoot = Image.FromFile(string.Format("{0}\\Templates\\DaoTao\\{1}", Environment.CurrentDirectory, thehocvien.TLBackImg));
            
            Image TypeImg = Image.FromFile(string.Format("{0}\\Templates\\DaoTao\\{1}", Environment.CurrentDirectory, thehocvien.TLKhung1));
            Font barCodeFont;
            PrivateFontCollection xFont = new PrivateFontCollection();
            xFont.AddFontFile(string.Format("{0}\\Templates\\DaoTao\\39.ttf", Environment.CurrentDirectory));
            FontFamily tempF = xFont.Families[0];
            barCodeFont = new Font(tempF, Convert.ToInt32(thehocvien.TLFontSizeBarCode), System.Drawing.FontStyle.Regular);
            string font = thehocvien.TLFont;
            Image FaceImg;
            int y1 = 520;
            foreach (TheHocVienLienTuc the in data.ListTheHocVienLienTuc)
            {
                Image BackImg = (Image)BackImgRoot.Clone();

                the.TenHocVien = GetTrinhDo(the.TrinhDo) +". "+ the.TenHocVien;
                try
                {
                    FaceImg = Image.FromFile(the.AnhHocVien);
                }
                catch
                {
                    FaceImg = Image.FromFile(string.Format("{0}\\Templates\\DaoTao\\{1}", Environment.CurrentDirectory, thehocvien.TLNoImg));
                }
                //string font = ;
                using (Graphics gra = Graphics.FromImage(BackImg))
                {
                    #region Anh hoc vien

                    gra.DrawImage(FaceImg, new Rectangle(25, 197, 270, 360));

                    #endregion
                    #region Anh hoc vien

                    gra.DrawImage(TypeImg, new Rectangle(310, y1 - 295, 680, 75));
                    

                    #endregion
                    #region For Name on Card

                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;
                    gra.DrawString(the.TenHocVien.ToUpper(), new Font(font, 10, System.Drawing.FontStyle.Bold), new SolidBrush(System.Drawing.Color.White), new Point(640, y1 - 255), stringFormat);

                    #endregion
                    //if (doituong == 2)
                    //    the.KhoaHoc = "Cán bộ quản lý đào tạo";
                    string[] tenKhoaHoc = the.KhoaHoc.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    string[] tenTruongHoc = the.TruongHoc.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    //int cout = tenKhoaHoc.Length;
                    string KHline1 = string.Empty;
                    string KHline2 = string.Empty;
                    string KHline3 = string.Empty;
                    string KHline4 = string.Empty;
                    int count = 1;
                    int counttruonghoc = 1;
                    if (doituong == 0)
                    {

                        #region Khóa học

                        stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Near;
                        stringFormat.LineAlignment = StringAlignment.Near;
                        gra.DrawString("Khóa học:", new Font(font, 9, System.Drawing.FontStyle.Regular), new SolidBrush(System.Drawing.Color.DarkBlue), new Point(315, y1 - 180), stringFormat);

                        #endregion

                        #region Process Ten Khoa Hoc
                        
                        foreach (string str in tenKhoaHoc)
                        {
                            if (count <= 4)
                            {
                                KHline1 += string.Format("{0} ", str);
                                count++;
                            }
                            else if (count <= 9)
                            {
                                KHline2 += string.Format("{0} ", str);
                                count++;
                            }
                            else if (count <= 14)
                            {
                                KHline3 += string.Format("{0} ", str);
                                count++;
                            }
                            else
                            {
                                KHline4 += string.Format("{0} ", str);
                            }
                        }

                        #endregion

                        #region Ten Khoa Hoc line1

                        stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Center;
                        stringFormat.LineAlignment = StringAlignment.Near;
                        gra.DrawString(KHline1.ToUpper().Trim(), new Font(font, 9, System.Drawing.FontStyle.Regular), new SolidBrush(System.Drawing.Color.DarkBlue), new Point(725, y1 - 180), stringFormat);
                        #endregion

                        #region Ten Khoa Hoc line2

                        stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Center;
                        stringFormat.LineAlignment = StringAlignment.Near;
                        gra.DrawString(KHline2.Trim().ToUpper(), new Font(font, 9, System.Drawing.FontStyle.Regular), new SolidBrush(System.Drawing.Color.DarkBlue), new Point(700, y1 - 130), stringFormat);

                        #endregion

                        #region Ten Khoa Hoc line3

                        stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Center;
                        stringFormat.LineAlignment = StringAlignment.Near;
                        gra.DrawString(KHline3.Trim().ToUpper(), new Font(font, 9, System.Drawing.FontStyle.Regular), new SolidBrush(System.Drawing.Color.DarkBlue), new Point(700, y1 - 75), stringFormat);

                        #endregion

                        #region Ten Khoa Hoc line4

                        stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Center;
                        stringFormat.LineAlignment = StringAlignment.Near;
                        gra.DrawString(KHline4.Trim().ToUpper(), new Font(font, 9, System.Drawing.FontStyle.Regular), new SolidBrush(System.Drawing.Color.DarkBlue), new Point(700, y1 - 25), stringFormat);

                        #endregion

                    }
                    if (doituong == 1)
                    {
                        if (tenKhoaHoc.Length <= 7)
                        {
                            foreach (string str in tenKhoaHoc)
                            {
                                KHline1 += string.Format("{0} ", str);
                                count++;
                            }
                            foreach (string str in tenTruongHoc)
                            {
                                if (counttruonghoc <= 7)
                                {
                                    KHline2 += string.Format("{0} ", str);
                                    counttruonghoc++;
                                }
                                else if (counttruonghoc <= 14)
                                {
                                    KHline3 += string.Format("{0} ", str);
                                    counttruonghoc++;
                                }
                                else
                                {
                                    KHline4 += string.Format("{0} ", str);
                                }
                            }
                        }
                        else if (tenKhoaHoc.Length > 7 && tenKhoaHoc.Length <=14)
                        {
                            foreach (string str in tenKhoaHoc)
                            {
                                if (count <= 7)
                                {
                                    KHline1 += string.Format("{0} ", str);
                                    count++;
                                }
                                else if (count <= 14)
                                {
                                    KHline2 += string.Format("{0} ", str);
                                    count++;
                                }
                            }
                            foreach (string str in tenTruongHoc)
                            {
                                if (counttruonghoc <= 7)
                                {
                                    KHline3 += string.Format("{0} ", str);
                                    counttruonghoc++;
                                }
                                else
                                {
                                    KHline4 += string.Format("{0} ", str);
                                }
                            }
                        }

                        
                    }
                    if (doituong == 2)
                    {
                        KHline1 = "Cán bộ quản lý đào tạo";
                        foreach (string str in tenTruongHoc)
                        {
                            if (counttruonghoc <= 7)
                            {
                                KHline2 += string.Format("{0} ", str);
                                counttruonghoc++;
                            }
                            else if (counttruonghoc <= 14)
                            {
                                KHline3 += string.Format("{0} ", str);
                                counttruonghoc++;
                            }
                            else
                            {
                                KHline4 += string.Format("{0} ", str);
                            }
                        }
                    }

                    if (doituong != 0)
                    {
                        #region Ten Khoa Hoc line1

                        stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Center;
                        stringFormat.LineAlignment = StringAlignment.Center;
                        gra.DrawString(KHline1.ToUpper().Trim(), new Font(font, 9, System.Drawing.FontStyle.Regular), new SolidBrush(System.Drawing.Color.DarkBlue), new Point(640, y1 - 180), stringFormat);
                        #endregion

                        #region Ten Khoa Hoc line2

                        stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Center;
                        stringFormat.LineAlignment = StringAlignment.Center;
                        gra.DrawString(KHline2.Trim().ToUpper(), new Font(font, 9, System.Drawing.FontStyle.Regular), new SolidBrush(System.Drawing.Color.DarkBlue), new Point(640, y1 - 130), stringFormat);

                        #endregion

                        #region Ten Khoa Hoc line3

                        stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Center;
                        stringFormat.LineAlignment = StringAlignment.Center;
                        gra.DrawString(KHline3.Trim().ToUpper(), new Font(font, 9, System.Drawing.FontStyle.Regular), new SolidBrush(System.Drawing.Color.DarkBlue), new Point(640, y1 - 75), stringFormat);

                        #endregion

                        #region Ten Khoa Hoc line4

                        stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Center;
                        stringFormat.LineAlignment = StringAlignment.Center;
                        gra.DrawString(KHline4.Trim().ToUpper(), new Font(font, 9, System.Drawing.FontStyle.Regular), new SolidBrush(System.Drawing.Color.DarkBlue), new Point(640, y1 - 25), stringFormat);

                        #endregion
                    }

                    

                    #region Thoi gian

                    stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Near;
                    stringFormat.LineAlignment = StringAlignment.Near;
                    gra.DrawString("Thời gian:", new Font(font, 9, System.Drawing.FontStyle.Regular), new SolidBrush(System.Drawing.Color.Red), new Point(315, y1 + 30), stringFormat);

                    #endregion

                    #region Thoi gian

                    stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Near;
                    gra.DrawString(the.ThoiGian, new Font(font, 9, System.Drawing.FontStyle.Regular), new SolidBrush(System.Drawing.Color.Red), new Point(720, y1 + 30), stringFormat);

                    #endregion

                    #region Ma hoc vien

                    stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Near;
                    gra.DrawString(the.MaHocVien.ToUpper(), new Font(font, 5, System.Drawing.FontStyle.Regular), new SolidBrush(System.Drawing.Color.DarkBlue), new Point(160, 565), stringFormat);

                    #endregion

                    //QuangBH comment 01-02-2015: A Chien Confirm bo ma vach
                    //#region Ma vach

                    //stringFormat = new StringFormat();
                    //stringFormat.Alignment = StringAlignment.Center;
                    //stringFormat.LineAlignment = StringAlignment.Near;
                    //gra.DrawString(the.SoCMT, barCodeFont, new SolidBrush(System.Drawing.Color.Black), new Point(640, y1), stringFormat);

                    //#endregion


                }
                string link = string.Format("{0}\\{1}{2}.jpg", Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), the.TenHocVien, the.SoCMT);
                BackImg.Save(link);
                Process.Start(link);
               
            }
        }

      
   
        #endregion

        #region Bang Theo Doi Chi Tieu Thuc Hanh

        public void ExportBangTheoDoiChiTieuThucHanh(DanhSachBangTheoDoiChiTieuThucHanh data, int totalRow)
        {
            try
            {
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.BangTheoDoiChiTieuThucHanh);

                String result = String.Empty;
                string tempPath = string.Empty;
                String article = String.Empty;

                foreach (var item in data.list)
                {
                    article = article + "<table class='table-1'>";
                    article = article + "<tr>";
                    article = article + "<td style='font-weight: bold; text-align: center; text-transform: uppercase; width: 30%;'>" + "Bộ y tế" + "<br />" + "Bệnh viện bạch mai" + "</td>";
                    article = article + "<td style='width: 70%; padding-left: 20px;'>";
                    article = article + "<h3>bảng theo dõi chỉ tiêu thực hành</h3>";
                    article = article + "</td>";
                    article = article + "</tr>";
                    article = article + "</table>";

                    article = article + "<table class='table-1'>";
                    article = article + "<tr>";
                    article = article + "<td style='width: 60%;'>" + "Tên chuyên khoa: " + item.TenKhoaDaoTao + "</td>";
                    article = article + "<td style='width: 20%;'>" + "Thời gian: từ " + item.ThoiGianBatDau + "</td>";
                    article = article + "<td style='width: 20%;'>" + "đến: " + item.ThoiGianKetThuc + "</td>";
                    article = article + "</tr>";
                    article = article + "<tr>";
                    article = article + "<td style='width: 60%;'>" + "Tên lớp: " + item.TenLop + "</td>";
                    article = article + "</tr>";
                    article = article + "</table>";

                    article = article + "<table class='table-1'>";
                    article = article + "<tr>";
                    article = article + "<td style='width: 40%;'>" + "Họ và tên học viên: " + item.HoTenHocVien + "</td>";
                    article = article + "<td>Đơn vị công tác: " + item.DonViCongTac + "</td>";
                    article = article + "</tr>";
                    article = article + "</table>";

                    article = article + "<p class='ghichu'>*Ghi chú: đánh số 1 or 2 or 3 ngay trước tên thủ thuật/kỹ thuật mà học viên thực hiện, trong đó: 1 = Quan sát;2 = Trợ giúp;3 = Tự làm</p>";

                    article = article + "<table class='table-2' style='border: solid 1px black;'>";
                    article = article + "<tr class='t-header'>";
                    article = article + "<td style='border-right: solid 1px black; border-bottom: solid 1px black; padding: 5px 0; width: 5%;text-align: center;'>STT</td>";
                    article = article + "<td style='border-right: solid 1px black; border-bottom: solid 1px black; padding: 5px 0; width: 20%;'>Họ và tên bệnh nhân</td>";
                    article = article + "<td style='border-right: solid 1px black; border-bottom: solid 1px black; padding: 5px 0; width: 5%;'>Tuổi</td>";
                    article = article + "<td style='border-right: solid 1px black; border-bottom: solid 1px black; padding: 5px 0; width: 15%;'>Địa chỉ</td>";
                    article = article + "<td style='border-right: solid 1px black; border-bottom: solid 1px black; padding: 5px 0; width: 10%;'>Chuẩn đoán</td>";
                    article = article + "<td style='border-right: solid 1px black; border-bottom: solid 1px black; padding: 5px 0; width: 10%;'>Tên khoa/BV điều trị</td>";
                    article = article + "<td style='border-right: solid 1px black; border-bottom: solid 1px black; padding: 5px 0; width: 25%;'>*Tên thủ thuật, kỹ thuật học viên thực hiện</td>";
                    article = article + "<td style='width: 10%; border-bottom: solid 1px black;'>GV ký xác nhận</td>";
                    article = article + "</tr>";

                    for (int i = 0; i <= totalRow -3; ++i)
                    {
                        article = article + "<tr class='t-nd'>";
                        article = article + "<td style='border-right: solid 1px black; border-bottom: solid 1px black; padding: 5px 0; width: 5%;'>" + "&nbsp;" + "</td>";
                        article = article + "<td style='border-right: solid 1px black; border-bottom: solid 1px black; padding: 5px 0; width: 20%;'>" + "&nbsp;" + "</td>";
                        article = article + "<td style='border-right: solid 1px black; border-bottom: solid 1px black; padding: 5px 0; width: 5%;'>" + "&nbsp;" + "</td>";
                        article = article + "<td style='border-right: solid 1px black; border-bottom: solid 1px black; padding: 5px 0; width: 15%;'>" + "&nbsp;" + "</td>";
                        article = article + "<td style='border-right: solid 1px black; border-bottom: solid 1px black; padding: 5px 0; width: 10%;'>" + "&nbsp;" + "</td>";
                        article = article + "<td style='border-right: solid 1px black; border-bottom: solid 1px black; padding: 5px 0; width: 10%;'>" + "&nbsp;" + "</td>";
                        article = article + "<td style='border-right: solid 1px black; border-bottom: solid 1px black; padding: 5px 0; width: 25%;'>" + "&nbsp;" + "</td>";
                        article = article + "<td style='width: 10%; border-bottom: solid 1px black;'>" + "&nbsp;" + "</td>";
                        article = article + "</tr>";
                    }

                    article = article + "</table>";
                }
                using (StreamReader sr = new StreamReader(path))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.Replace("$pagecontent", article);
                        line = result = result + line;
                    }
                    string fileName = Constants.FileName.DaoTao.BangTheoDoiChiTieuThucHanh + ".html";
                    tempPath = Path.Combine(Path.GetTempPath(), fileName);
                    StreamWriter oWriter = new StreamWriter(tempPath);
                    oWriter.Write(result);
                    oWriter.Close();
                    Process.Start(tempPath);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region Bang Top Hop Ket Qua Hoan Thanh Chi Tieu Thuc Hanh
        public void ExportBangTopHopKetQuaHoanThanhChiTieuThucHanh(DanhSachBangTongHopKetQuaHoanThanhChiTieuThucHanh data, int totalRow)
        {
            try
            {
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.BangTongHopKetQuaHoanThanhChiTieuThucHanh);

                String result = String.Empty;
                string tempPath = string.Empty;
                String article = String.Empty;

                foreach (var item in data.list)
                {
                    article = article + "<table class='table-1'>";
                    article = article + "<tr>";
                    article = article + "<td style='font-weight: bold; text-align: center; text-transform: uppercase; width: 30%;'>Bộ y tế" + "<br />" + "Bệnh viện bạch mai</td>";
                    article = article + "<td style='width: 70%; padding-left: 20px;'>";
                    article = article + "<h3>bảng tổng hợp kết quả hoàn thành chỉ tiêu thực hành</h3>";
                    article = article + "</td>";
                    article = article + "</tr>";
                    article = article + "</table>";

                    article = article + "<table class='table-1'>";
                    article = article + "<tr>";
                    article = article + "<td style='width: 60%;'>" + "Tên khóa học đào tạo: " + item.TenKhoaDaoTao + "</td>";
                    article = article + "<td style='width: 20%;'>Thời gian: từ " + item.ThoiGianBatDau + "</td>";
                    article = article + " <td style='width: 20%;'>đến: " + item.ThoiGianKetThuc + "</td>";
                    article = article + "</tr>";
                    article = article + "</table>";

                    article = article + "<table class='table-1'>";
                    article = article + "<tr>";
                    article = article + "<td style='width: 40%;'>Họ và tên học viên: " + item.HoTenHocVien + "</td>";
                    article = article + "<td>Đơn vị công tác: " + item.DonViCongTac + "</td>";
                    article = article + "</tr>";
                    article = article + "</table>";

                    article = article + "<table class='table-2'>";
                    article = article + "<tr class='t-header'>";
                    article = article + "<td style='border-right: solid 1px black; border-bottom: solid 1px black; padding: 0; width: 5%; text-align:center;'>STT</td>";
                    article = article + "<td style='border-right: solid 1px black; border-bottom: solid 1px black; padding: 0; width: 30%;'>Tên thủ thuật, kỹ thuật</td>";
                    article = article + "<td style='border-right: solid 1px black; border-bottom: solid 1px black; padding: 0; width: 15%;'>";
                    article = article + "<table class='table-mini'>";
                    article = article + "<tr>";
                    article = article + "<td colspan='3' style='border-bottom: solid 1px black; padding:5px 0;'>Chỉ tiêu thực hành" + "<br />" + "(số lượng)</td>";
                    article = article + "</tr>";
                    article = article + "<tr>";
                    article = article + "<td style='border-right: solid 1px black; padding: 5px 0; width: 33.33%;'>Quan sát</td>";
                    article = article + "<td style='border-right: solid 1px black; padding: 5px 0; width: 33.33%;'>Trợ giúp</td>";
                    article = article + "<td style='padding: 5px 0; width: 33.33%;'>Tự làm</td>";
                    article = article + "</tr>";
                    article = article + "</table>";
                    article = article + "</td>";
                    article = article + "<td style='border-right: solid 1px black; border-bottom: solid 1px black; padding: 0; width: 15%;'>";
                    article = article + "<table class='table-mini'>";
                    article = article + "<tr>";
                    article = article + "<td colspan='3' style='border-bottom: solid 1px black; padding:5px 0;'>Kết quả thực hiện" + "<br />" + "(ghi rõ số lượng)</td>";
                    article = article + "</tr>";
                    article = article + "<tr>";
                    article = article + "<td style='border-right: solid 1px black; padding: 5px 0; width: 33.33%;'>Quan sát</td>";
                    article = article + "<td style='border-right: solid 1px black; padding: 5px 0; width: 33.33%;'>Trợ giúp</td>";
                    article = article + "<td style='padding: 5px 0; width: 33.33%;'>Tự làm</td>";
                    article = article + "</tr>";
                    article = article + "</table>";
                    article = article + "</td>";
                    article = article + "<td style='border-bottom: solid 1px black; padding: 0; width: 30%;'>";
                    article = article + "<table class='table-mini'>";
                    article = article + "<tr>";
                    article = article + "<td colspan='6' style='border-bottom: solid 1px black; padding:5px 0;'>Học viên tự đánh giá kết quả chung" + "<br />" + "(đánh dấu x vào cột tương ứng)</td>";
                    article = article + "</tr>";
                    article = article + "<tr>";
                    article = article + "<td colspan='2' style='border-right: solid 1px black;border-bottom: solid 1px black; padding:5px 0;width:33.32%;'>Về số lượng</td>";
                    article = article + "<td colspan='4' style='border-bottom: solid 1px black; padding:5px 0;width:66.68%;'>Về chất lượng</td>";
                    article = article + "</tr>";
                    article = article + "<tr>";
                    article = article + "<td style='border-right: solid 1px black; padding: 5px 0; width: 16.66%;'>Đạt</td>";
                    article = article + "<td style='border-right: solid 1px black; padding: 5px 0; width: 16.66%;'>Ko Đạt</td>";
                    article = article + "<td style='border-right: solid 1px black; padding: 5px 0; width: 16.66%;'>Tốt</td>";
                    article = article + "<td style='border-right: solid 1px black; padding: 5px 0; width: 16.66%;'>Khá</td>";
                    article = article + "<td style='border-right: solid 1px black; padding: 5px 0; width: 16.66%;'>TB</td>";
                    article = article + "<td style='padding: 5px 0; width: 16.66%;'>Kém</td>";
                    article = article + "</tr>";
                    article = article + "</table>";
                    article = article + "</td>";
                    article = article + "</tr>";

                    for (int i = 0; i <= totalRow; ++i)
                    {
                        article = article + "<tr class='t-nd'>";
                        article = article + "<td style='border-right: solid 1px black; border-bottom: solid 1px black; padding: 0; width: 5%;'>" + "&nbsp;" + "</td>";
                        article = article + "<td style='border-right: solid 1px black; border-bottom: solid 1px black; padding: 0; width: 30%;'>" + "&nbsp;" + "</td>";
                        article = article + "<td style='border-right: solid 1px black; border-bottom: solid 1px black; padding: 0; width: 15%;'>";
                        article = article + "<table class='table-mini'>";
                        article = article + "<tr>";
                        article = article + "<td style='border-right: solid 1px black; padding: 5px 0; width: 33.33%;'>" + "&nbsp;" + "</td>";
                        article = article + "<td style='border-right: solid 1px black; padding: 5px 0; width: 33.33%;'>" + "&nbsp;" + "</td>";
                        article = article + "<td style='padding: 5px 0; width: 33.33%;'>" + "&nbsp;" + "</td>";
                        article = article + "</tr>";
                        article = article + "</table>";
                        article = article + "</td>";
                        article = article + "<td style='border-right: solid 1px black; border-bottom: solid 1px black; padding: 0; width: 15%;'>";
                        article = article + "<table class='table-mini'>";
                        article = article + "<tr>";
                        article = article + "<td style='border-right: solid 1px black; padding: 5px 0; width: 33.33%;'>" + "&nbsp;" + "</td>";
                        article = article + "<td style='border-right: solid 1px black; padding: 5px 0; width: 33.33%;'>" + "&nbsp;" + "</td>";
                        article = article + "<td style='padding: 5px 0; width: 33.33%;'>" + "&nbsp;" + "</td>";
                        article = article + "</tr>";
                        article = article + "</table>";
                        article = article + "</td>";
                        article = article + "<td style='border-bottom: solid 1px black; padding: 0; width: 30%;'>";
                        article = article + "<table class='table-mini'>";
                        article = article + "<tr>";
                        article = article + "<td style='border-right: solid 1px black; padding: 5px 0; width: 16.66%;'>" + "&nbsp;" + "</td>";
                        article = article + "<td style='border-right: solid 1px black; padding: 5px 0; width: 16.66%;'>" + "&nbsp;" + "</td>";
                        article = article + "<td style='border-right: solid 1px black; padding: 5px 0; width: 16.66%;'>" + "&nbsp;" + "</td>";
                        article = article + "<td style='border-right: solid 1px black; padding: 5px 0; width: 16.66%;'>" + "&nbsp;" + "</td>";
                        article = article + "<td style='border-right: solid 1px black; padding: 5px 0; width: 16.66%;'>" + "&nbsp;" + "</td>";
                        article = article + "<td style='padding: 5px 0; width: 16.66%;'>" + "&nbsp;" + "</td>";
                        article = article + "</tr>";
                        article = article + "</table>";
                        article = article + "</td>";
                        article = article + "</tr>";
                    }

                    article = article + "</table>";
                }

                using (StreamReader sr = new StreamReader(path))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.Replace("$pagecontent", article);
                        line = result = result + line;
                    }
                    string fileName = Constants.FileName.DaoTao.BangTongHopKetQuaHoanThanhChiTieuThucHanh + ".html";
                    tempPath = Path.Combine(Path.GetTempPath(), fileName);
                    StreamWriter oWriter = new StreamWriter(tempPath);
                    oWriter.Write(result);
                    oWriter.Close();
                    Process.Start(tempPath);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region Hien Trang Su Dung Thiet Bi Tien Lam Sang

        public void ExportHienTrangSuDungThietBiTienLamSang(HienTrangSuDungThietBiTienLamSang data, int totalRow)
        {
            try
            {
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.BangTheoDoiChiTieuThucHanh);

                String result = String.Empty;
                string tempPath = string.Empty;
                String article = String.Empty;

                foreach (var item in data.LoaiMoHinhSuDung)
                {
                    article = article + "<li>" + item.LoaiMoHinhSuDung + "</li>";
                }

                using (StreamReader sr = new StreamReader(path))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.Replace("$ngaybatdau", data.ThoiGianBatDau);
                        line = line.Replace("$ngayketthuc", data.ThoiGianKetThuc);
                        line = line.Replace("$tenkhoahoc", data.TenKhoaHocDaoTao);
                        line = line.Replace("$soluonghocvien", data.SoLuongHocVien);
                        line = line.Replace("$danhsachhocvien", data.DanhSachHocVien);
                        line = line.Replace("$ngaythang", string.Format("Ngày {0} tháng {1} năm {2}", data.NgayThang.Day.ToString(), data.NgayThang.Month.ToString(), data.NgayThang.Year.ToString()));
                        line = line.Replace("$loaimohinh", article);
                        line = result = result + line;
                    }
                    string fileName = Constants.FileName.DaoTao.BangTheoDoiChiTieuThucHanh + ".html";
                    tempPath = Path.Combine(Path.GetTempPath(), fileName);
                    StreamWriter oWriter = new StreamWriter(tempPath);
                    oWriter.Write(result);
                    oWriter.Close();
                    Process.Start(tempPath);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region Chung nhan, Chung chi
        //public void ExportGiayChungNhanDA(DT_GiayChungChi data)
        //{
        //    ExprotChungChiChungNhan(data, 3);
        //}

        public void ExportGiayChungNhan(DT_GiayChungChi data)
        {
            ExprotChungChiChungNhan(data, 2);
        }

        public void ExportGiayChungChi(DT_GiayChungChi data)
        {
            ExprotChungChiChungNhan(data, 1);         
        }

        private void ExprotChungChiChungNhan(DT_GiayChungChi data,int type)
        {
            try
            {

                string contentPath = string.Empty;
                string path = string.Empty;
                //if (type == 3 || type == 2)
                //{
                //    contentPath = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.GiayChungChi03Content);
                //    path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.GiayChungChi01);
                //}
                //else
                //{
                    contentPath = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.GiayChungChi01Content);
                    path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.GiayChungChi01);
                //}
                //}
                //else
                //{
                //    contentPath = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.GiayChungChi02Content);
                //    path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.GiayChungChi02);
                //}
                string content = string.Empty;
                string result = string.Empty;
                /// Load Content
                using (StreamReader sr = new StreamReader(contentPath))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        content += line;
                    }
                }
                foreach (var item in data.ListChungChi)
                {
                    string temp = content;
                    temp = temp.Replace("$Name", item.HocVien);
                    temp = temp.Replace("$DateOfBirth",item.NgaySinh);
                    //temp = temp.Replace("$Qualification",item.TrinhDo);
                    temp = temp.Replace("$Organization",item.DonViCongTac);
                    temp = temp.Replace("$Content",item.KhoaHocHoanThanh);
                    temp = temp.Replace("$Duration",item.SoTietHoc);
                    temp = temp.Replace("$Start",item.NgayBatDau);
                    temp = temp.Replace("$End",item.NgayKetThuc);
                    temp = temp.Replace("$Date",item.ThongTin);
                    temp = temp.Replace("$Code",string.Format("{0}",item.MaHocVien));
                    temp = temp.Replace("$XepLoaiTitle", item.XepLoaiTitle);
                    temp = temp.Replace("$xeploai",item.XepLoai);
                    temp = temp.Replace("$covantruongduan", item.CoVan.ToUpper());
                    //temp = temp.Replace("$bannganh", item.bannganh);
                    temp = temp.Replace("$DuAn", item.DuAn);
                    result += temp;
                }
                content = result;
                result = string.Empty;
                string tempPath = string.Empty;
                using (StreamReader sr = new StreamReader(path))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.Replace("$datachungchi", content);
                        result += line;
                    }
                    string fileName = Constants.FileName.DaoTao.GiayChungChi + ".html";
                    tempPath = Path.Combine(Path.GetTempPath(), fileName);
                    StreamWriter oWriter = new StreamWriter(tempPath);
                    oWriter.Write(result);
                    oWriter.Close();
                }
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DT_GiayChungNhan GetDT_GiayChungNhan()
        {
            DT_GiayChungNhan data = new DT_GiayChungNhan();
            List<ChungNhan> list = new List<ChungNhan>();
            ChungNhan cn = new ChungNhan();
            cn.HocVien = "Nguyễn Văn A";
            cn.NgaySinh = "7/25/1981";
            cn.TrinhDo = "Bác sĩ";
            cn.DonViCongTac = "Bệnh viện y học cổ truyền";
            cn.KhoaHocHoanThanh = "lớp bác sĩ chuyên khoa i";
            cn.SoTietHoc = "150 tiết";
            cn.NgayBatDau = "12/09/2013";
            cn.NgayKetThuc = "12/10/2015";
            cn.ThongTin = "Hà Nội, Ngày 12 tháng 10 năm 2015";
            list.Add(cn);
            data.ListChungNhan = list;
            return data;
        }

        private ChungNhan GetChungNhan()
        {
            return new ChungNhan
            {
                HocVien = "Nguyễn Văn A",
                NgaySinh = "7/25/1981",
                TrinhDo = "Bác sĩ",
                DonViCongTac = "Bệnh viện y học cổ truyền",
                KhoaHocHoanThanh = "lớp bác sĩ chuyên khoa i",
                SoTietHoc = "150 tiết",
                NgayBatDau = "12/09/2013",
                NgayKetThuc = "12/10/2015",
                ThongTin = "Hà Nội, Ngày 12 tháng 10 năm 2015"
            };
        }

        private DT_GiayChungChi GetDT_GiayChungChi()
        {
            DT_GiayChungChi data = new DT_GiayChungChi();
            List<ChungChi> list = new List<ChungChi>();
            ChungChi cn = new ChungChi();
            cn.HocVien = "Nguyễn Văn A";
            cn.NgaySinh = "7/25/1981";
            cn.TrinhDo = "Bác sĩ";
            cn.DonViCongTac = "Bệnh viện y học cổ truyền";
            cn.KhoaHocHoanThanh = "lớp bác sĩ chuyên khoa i";
            cn.SoTietHoc = "150 tiết";
            cn.NgayBatDau = "12/09/2013";
            cn.NgayKetThuc = "12/10/2015";
            cn.ThongTin = "Hà Nội, Ngày 12 tháng 10 năm 2015";
            list.Add(cn);
            data.ListChungChi = list;
            return data;
        }

        private ChungChi GetChungChi()
        {
            return new ChungChi
            {
                HocVien = "Nguyễn Văn A",
                NgaySinh = "7/25/1981",
                TrinhDo = "Bác sĩ",
                DonViCongTac = "Bệnh viện y học cổ truyền",
                KhoaHocHoanThanh = "lớp bác sĩ chuyên khoa i",
                SoTietHoc = "150 tiết",
                NgayBatDau = "12/09/2013",
                NgayKetThuc = "12/10/2015",
                ThongTin = "Hà Nội, Ngày 12 tháng 10 năm 2015"
            };
        }

        #endregion

        #region G001_GiayHenTraChungChiHocVien

        public ReportDocument G001_GiayHenTraChungChiHocVien(List<G001_GiayHenTraChungChiHocVien> data)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.G001_GiayHenTraChungChiHocVien);
                rpt.Load(path);
                G001_BindingData(data, rpt);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void G001_GiayHenTraChungChiHocVien(List<G001_GiayHenTraChungChiHocVien> data, Constants.ExportType type)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.G001_GiayHenTraChungChiHocVien);
                rpt.Load(path);
                G001_BindingData(data, rpt);
                string tempPath = Path.Combine(Path.GetTempPath(), Constants.FileName.DaoTao.G001_GiayHenTraChungChiHocVien);
                tempPath = Export(rpt, tempPath, type);
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void G001_BindingData(List<G001_GiayHenTraChungChiHocVien> data, ReportDocument rpt)
        {
            if (data.Count > 0)
            {
                DataTable dt = ConvertToDataTable(data);
                rpt.SetDataSource(dt);
            }
        }

        #endregion

        #region G002_GiayHenTraTheHocVien

        public ReportDocument G002_GiayHenTraTheHocVien(List<G002_GiayHenTraTheHocVien> data)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.G002_GiayHenTraTheHocVien);
                rpt.Load(path);
                G002_BindingData(data, rpt);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void G002_GiayHenTraTheHocVien(List<G002_GiayHenTraTheHocVien> data, Constants.ExportType type)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.G002_GiayHenTraTheHocVien);
                rpt.Load(path);
                G002_BindingData(data, rpt);
                string tempPath = Path.Combine(Path.GetTempPath(), Constants.FileName.DaoTao.G002_GiayHenTraTheHocVien);
                tempPath = Export(rpt, tempPath, type);
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void G002_BindingData(List<G002_GiayHenTraTheHocVien> data, ReportDocument rpt)
        {
            if (data.Count > 0)
            {
                DataTable dt = ConvertToDataTable(data);
                rpt.SetDataSource(dt);
            }
        }

        #endregion

        #region G003_GiayDeNghiThuTienHocPhi

        public ReportDocument G003_GiayDeNghiThuTienHocPhi(List<G003_GiayDeNghiThuTienHocPhi> data)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.G003_GiayDeNghiThuTienHocPhi);
                rpt.Load(path);
                G003_BindingData(data, rpt);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void G003_GiayDeNghiThuTienHocPhi(List<G003_GiayDeNghiThuTienHocPhi> data, Constants.ExportType type)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.G003_GiayDeNghiThuTienHocPhi);
                rpt.Load(path);
                G003_BindingData(data, rpt);
                string tempPath = Path.Combine(Path.GetTempPath(), Constants.FileName.DaoTao.G003_GiayDeNghiThuTienHocPhi);
                tempPath = Export(rpt, tempPath, type);
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void G003_BindingData(List<G003_GiayDeNghiThuTienHocPhi> data, ReportDocument rpt)
        {
            if (data.Count > 0)
            {
                DataTable dt = ConvertToDataTable(data);
                rpt.SetDataSource(dt);
            }
        }

        #endregion

        #region G004_GiayDeNghiTiepNhanHocVien

        public ReportDocument G004_GiayDeNghiTiepNhanHocVien(List<G004_GiayDeNghiTiepNhanHocVien> data)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.G004_GiayDeNghiTiepNhanHocVien);
                rpt.Load(path);
                G004_BindingData(data, rpt);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void G004_GiayDeNghiTiepNhanHocVien(List<G004_GiayDeNghiTiepNhanHocVien> data, Constants.ExportType type)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.G004_GiayDeNghiTiepNhanHocVien);
                rpt.Load(path);
                G004_BindingData(data, rpt);
                string tempPath = Path.Combine(Path.GetTempPath(), Constants.FileName.DaoTao.G004_GiayDeNghiTiepNhanHocVien);
                tempPath = Export(rpt, tempPath, type);
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void G004_BindingData(List<G004_GiayDeNghiTiepNhanHocVien> data, ReportDocument rpt)
        {
            if (data.Count > 0)
            {
                DataTable dt = ConvertToDataTable(data);
                rpt.SetDataSource(dt);
            }
        }

        #endregion

        #region P_PhieuThuLT

        public ReportDocument P003_PhieuThuLTNhieuHocVien(List<P_PhieuThuLT> data)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.P003_PhieuThuLT);
                rpt.Load(path);
                P003_BindingData(data, rpt);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void P003_PhieuThuLTNhieuHocVien(List<P_PhieuThuLT> data, Constants.ExportType type)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.P003_PhieuThuLT);
                rpt.Load(path);
                P003_BindingData(data, rpt);
                string tempPath = Path.Combine(Path.GetTempPath(), Constants.FileName.DaoTao.P003_PhieuThuLTNhieuHocVien);
                tempPath = Export(rpt, tempPath, type);
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void P003_BindingData(List<P_PhieuThuLT> data, ReportDocument rpt)
        {
            if (data.Count > 0)
            {
                DataTable dt = ConvertToDataTable(data);
                rpt.SetDataSource(dt);
            }
        }

        /// <summary>
        /// Export P004_PhieuThuLT
        /// </summary>
        /// <param name="data">P004_PhieuThuLT object</param>
        protected void P_PhieuThuLT(P_PhieuThuLT data, string fileName)
        {
            if (data == null)
                return;

            string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.P_PhieuThuLT);
            string tempPath = string.Empty;
            String result = Constants.Html.Header;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = ReplaceDataP(data, line);
                        line = result = result + line;
                    }

                    result = result + Constants.Html.Footer;
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

        protected static string ReplaceDataP(P_PhieuThuLT data, String line)
        {
            line = line.Replace("$TenNguoiNop", string.IsNullOrEmpty(data.TenNguoiNop) ? string.Empty : data.TenNguoiNop);
            line = line.Replace("$ThoiGianNhap", string.IsNullOrEmpty(data.ThoiGianNhap) ? string.Empty : data.ThoiGianNhap);
            line = line.Replace("$NoiCongTac", string.IsNullOrEmpty(data.NoiCongTac) ? string.Empty : data.NoiCongTac);
            line = line.Replace("$LyDoNop", string.IsNullOrEmpty(data.LyDoNop) ? string.Empty : data.LyDoNop);
            line = line.Replace("$SoTien", string.IsNullOrEmpty(data.SoTien) ? string.Empty : data.SoTien);
            line = line.Replace("$VietBangChu", string.IsNullOrEmpty(data.SoTienVietBangChu) ? string.Empty : data.SoTienVietBangChu);
            line = line.Replace("$TenThuQuy", string.IsNullOrEmpty(data.TenThuQuy) ? string.Empty : data.TenThuQuy);
            line = line.Replace("$LanhDaoTrungTam", string.IsNullOrEmpty(data.LanhDaoTrungTam) ? string.Empty : data.LanhDaoTrungTam);
            return line;
        }

        /// <summary>
        /// Export G003 Giay hen tra chung chi hoc vien
        /// </summary>
        /// <param name="data">List G001_GiayHenTraChungChiHocVien</param>
        protected void P_PhieuThuLT(List<P_PhieuThuLT> listData, string fileName)
        {
            if (listData.Count == 0)
                return;

            string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.P_PhieuThuLT);
            string tempPath = string.Empty;
            String result = Constants.Html.Header;
            try
            {
                foreach (P_PhieuThuLT data in listData)
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        String line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            line = ReplaceDataP(data, line);
                            line = result = result + line;
                        }
                    }
                }

                result = result + Constants.Html.Footer;
                tempPath = Path.Combine(Path.GetTempPath(), fileName);
                StreamWriter oWriter = new StreamWriter(tempPath);
                oWriter.Write(result);
                oWriter.Close();
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

        public void P001_PhieuThuLTKemCap(P_PhieuThuLT data)
        {
            P_PhieuThuLT(data, Constants.FileName.DaoTao.P001_PhieuThuLTKemCap + ".html");
        }

        public void P001_PhieuThuLTKemCap(List<P_PhieuThuLT> data)
        {
            P_PhieuThuLT(data, Constants.FileName.DaoTao.P001_PhieuThuLTKemCap + ".html");
        }

        public void P002_PhieuThuLTTheoLop(P_PhieuThuLT data)
        {
            P_PhieuThuLT(data, Constants.FileName.DaoTao.P002_PhieuThuLTTheoLop + ".html");
        }

        public void P002_PhieuThuLTTheoLop(List<P_PhieuThuLT> data)
        {
            P_PhieuThuLT(data, Constants.FileName.DaoTao.P002_PhieuThuLTTheoLop + ".html");
        }

        #endregion

        #region B001_BangDiemDanhTheoLop

        public ReportDocument B001_BangDiemDanhTheoLopCRVBinding(B001_BangDiemDanhTheoLop data)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B001_BangDiemDanhTheoLopRpt);
                rpt.Load(path);
                B001_BindingData(data, rpt);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void B001_BangDiemDanhTheoLop(B001_BangDiemDanhTheoLop data, Constants.ExportType type)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B001_BangDiemDanhTheoLopRpt);
                rpt.Load(path);
                B001_BindingData(data, rpt);
                string tempPath = Path.Combine(Path.GetTempPath(), Constants.FileName.DaoTao.B001_BangDiemDanhTheoLop);
                tempPath = Export(rpt, tempPath, type);
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void B001_BindingData(B001_BangDiemDanhTheoLop data, ReportDocument rpt)
        {
            if (data.ListHocVien != null)
            {
                DataTable dt = ConvertToDataTable(data.ListHocVien);
                rpt.SetDataSource(dt);
            }

            ReplaceData(rpt, "KhoaDaoTao", string.IsNullOrEmpty(data.KhoaDaoTao) ? string.Empty : data.KhoaDaoTao);
            ReplaceData(rpt, "NgayBatDau", string.IsNullOrEmpty(data.NgayBatDau) ? string.Empty : data.NgayBatDau);
            ReplaceData(rpt, "NgayKetThuc", string.IsNullOrEmpty(data.NgayKetThuc) ? string.Empty : data.NgayKetThuc);
            ReplaceData(rpt, "TuanBatDau", string.IsNullOrEmpty(data.TuanBatDau) ? string.Empty : data.TuanBatDau);
            ReplaceData(rpt, "TuanKetThuc", string.IsNullOrEmpty(data.TuanKetThuc) ? string.Empty : data.TuanKetThuc);
            ReplaceData(rpt, "ThoiGianNhap", string.IsNullOrEmpty(data.ThoiGianNhap) ? Constants.EmptyData.NgayViet : data.ThoiGianNhap);
            ReplaceData(rpt, "CanBoPhuTrachLop", string.IsNullOrEmpty(data.CanBoPhuTrachLop) ? string.Empty : data.CanBoPhuTrachLop);
            ReplaceData(rpt, "NhomTruong", string.IsNullOrEmpty(data.NhomTruong) ? string.Empty : data.NhomTruong);
        }

        public void B001_BangDiemDanhTheoLop(B001_BangDiemDanhTheoLop data)
        {
            if (data == null)
                return;

            string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B001_BangDiemDanhTheoLop);
            string tempPath = string.Empty;
            String result = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = ReplaceDataB001(data, line);
                        line = result = result + line;
                    }

                    string fileName = Constants.FileName.DaoTao.B001_BangDiemDanhTheoLop + ".html";
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

        private static string ReplaceDataB001(B001_BangDiemDanhTheoLop data, String line)
        {
            line = line.Replace("$KhoaDaoTao", string.IsNullOrEmpty(data.KhoaDaoTao) ? string.Empty : data.KhoaDaoTao);
            line = line.Replace("$TenLop", string.IsNullOrEmpty(data.TenLop) ? string.Empty : data.TenLop);
            line = line.Replace("$TuNgay", string.IsNullOrEmpty(data.NgayBatDau) ? string.Empty : data.NgayBatDau);
            line = line.Replace("$DenNgay", string.IsNullOrEmpty(data.NgayKetThuc) ? string.Empty : data.NgayKetThuc);
            line = line.Replace("$TuanTu", string.IsNullOrEmpty(data.TuanBatDau) ? Constants.EmptyData.LongEmpty : data.TuanBatDau);
            line = line.Replace("$DenTuan", string.IsNullOrEmpty(data.TuanKetThuc) ? string.Empty : data.TuanKetThuc);
            line = line.Replace("$ThoiGianNhap", string.IsNullOrEmpty(data.ThoiGianNhap) ? Constants.EmptyData.NgayViet : data.ThoiGianNhap);
            string dataTable = GetDanhSachHocVien(data.ListHocVien);
            line = line.Replace("$DataTable", string.IsNullOrEmpty(dataTable) ? string.Empty : dataTable);
            return line;
        }

        private static string GetDanhSachHocVien(List<DanhSachLop> list)
        {
            if (list.Count == 0)
                return string.Empty;

            string dataTable = string.Empty;
            int stt = 0;
            foreach (DanhSachLop item in list)
            {
                stt++;
                dataTable = dataTable + "<tr>";
                dataTable = dataTable + "<td class='tr3 td13'><p class='p0 ft3'>" + stt + "</p></td>";
                dataTable = dataTable + "<td class='tr3 td14'><p class='p12 ft3'>" + item.TenHocVien + "</p></td>";
                dataTable = dataTable + "<td class='tr3 td15'><p class='p13 ft3'>&nbsp;</p></td>";
                dataTable = dataTable + "<td class='tr3 td16'><p class='p0 ft4'>&nbsp;</p></td>";
                dataTable = dataTable + "<td class='tr3 td17'><p class='p0 ft3'>&nbsp;</p></td>";
                dataTable = dataTable + "<td class='tr3 td18'><p class='p14 ft3'>&nbsp;</p></td>";
                dataTable = dataTable + "<td class='tr3 td19'><p class='p0 ft4'>&nbsp;</p></td>";
                dataTable = dataTable + "<td class='tr3 td20'><p class='p15 ft3'>&nbsp;</p></td>";
                dataTable = dataTable + "<td class='tr3 td21'><p class='p13 ft3'>&nbsp;</p></td>";
                dataTable = dataTable + "<td class='tr3 td22'><p class='p0 ft4'>&nbsp;</p></td>";
                dataTable = dataTable + "<td class='tr3 td23'><p class='p16 ft3'>&nbsp;</p></td>";
                dataTable = dataTable + "<td class='tr3 td24'><p class='p13 ft3'>&nbsp;</p></td>";
                dataTable = dataTable + "<td class='tr3 td25'><p class='p0 ft4'>&nbsp;</p></td>";
                dataTable = dataTable + "<td class='tr3 td17'><p class='p0 ft3'>&nbsp;</p></td>";
                dataTable = dataTable + "<td class='tr3 td26'><p class='p17 ft3'>&nbsp;</p></td>";
                dataTable = dataTable + "<td class='tr3 td25'><p class='p0 ft4'>&nbsp;</p></td>";
                dataTable = dataTable + "<td class='tr3 td27'><p class='p0 ft3'>&nbsp;</p></td>";
                dataTable = dataTable + "<td class='tr3 td28'><p class='p0 ft4'>&nbsp;</p></td>";
                dataTable = dataTable + "</tr>";
            }

            return dataTable;
        }

        #endregion

        #region B011_BaoCaoSoLuongHocVienTheoTrinhDo

        public ReportDocument B011_BaoCaoSoLuongHocVienTheoTrinhDoCRVBinding(B011_BaoCaoSoLuongHocVienTheoTrinhDo data)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B011_BaoCaoSoLuongHocVienTheoTrinhDo);
                rpt.Load(path);
                B011_BindingData(data, rpt);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void B011_BaoCaoSoLuongHocVienTheoTrinhDo(B011_BaoCaoSoLuongHocVienTheoTrinhDo data, Constants.ExportType type)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B011_BaoCaoSoLuongHocVienTheoTrinhDo);
                rpt.Load(path);
                B011_BindingData(data, rpt);
                string tempPath = Path.Combine(Path.GetTempPath(), Constants.FileName.DaoTao.B011_BaoCaoSoLuongHocVienTheoTrinhDo);
                tempPath = Export(rpt, tempPath, type);
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void B011_BindingData(B011_BaoCaoSoLuongHocVienTheoTrinhDo data, ReportDocument rpt)
        {
            if (data.ListSoLuongHocVienTheoTrinhDo != null)
            {
                DataTable dt = ConvertToDataTable(data.ListSoLuongHocVienTheoTrinhDo);
                rpt.SetDataSource(dt);
            }

            ReplaceData(rpt, "NgayBatDau", string.IsNullOrEmpty(data.NgayBatDau) ? string.Empty : data.NgayBatDau);
            ReplaceData(rpt, "NgayKetThuc", string.IsNullOrEmpty(data.NgayKetThuc) ? string.Empty : data.NgayKetThuc);
        }

        #endregion

        #region B012_BaoCaoThuTienHocVienKemCap

        public ReportDocument B012_BaoCaoThuTienHocVienKemCapCRVBinding(B012_BaoCaoThuTienHocVienKemCap data)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B012_BaoCaoThuTienHocVienKemCap);
                rpt.Load(path);
                B012_BindingData(data, rpt);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void B012_BaoCaoThuTienHocVienKemCap(B012_BaoCaoThuTienHocVienKemCap data, Constants.ExportType type)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B012_BaoCaoThuTienHocVienKemCap);
                rpt.Load(path);
                B012_BindingData(data, rpt);
                string tempPath = Path.Combine(Path.GetTempPath(), Constants.FileName.DaoTao.B012_BaoCaoThuTienHocVienKemCap);
                tempPath = Export(rpt, tempPath, type);
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void B012_BindingData(B012_BaoCaoThuTienHocVienKemCap data, ReportDocument rpt)
        {
            if (data.ListClassDanhSachHocVien != null)
            {
                DataTable dt = ConvertToDataTable(data.ListClassDanhSachHocVien);
                rpt.SetDataSource(dt);
            }

            ReplaceData(rpt, "KhoaDaoTao", string.IsNullOrEmpty(data.KhoaDaoTao) ? string.Empty : data.KhoaDaoTao);
            ReplaceData(rpt, "TongSoTien", string.IsNullOrEmpty(data.TongSoTien) ? string.Empty : data.TongSoTien);
            ReplaceData(rpt, "SoTienBangChu", string.IsNullOrEmpty(data.SoTienBangChu) ? string.Empty : data.SoTienBangChu);
            ReplaceData(rpt, "ThoiGianNhap", string.IsNullOrEmpty(data.ThoiGianNhap) ? Constants.EmptyData.NgayViet : data.ThoiGianNhap);
            ReplaceData(rpt, "NguoiLapBaoCao", string.IsNullOrEmpty(data.NguoiLapBaoCao) ? string.Empty : data.NguoiLapBaoCao);
        }

        #endregion

        #region B014_BaoCaoTongKetKhoaDaoTao

        public ReportDocument B014_BaoCaoTongKetKhoaDaoTao(List<B014_BaoCaoTongKetKhoaDaoTao> data)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B014_BaoCaoTongKetKhoaDaoTao);
                rpt.Load(path);
                B014_BindingData(data, rpt);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void B014_BaoCaoTongKetKhoaDaoTao(List<B014_BaoCaoTongKetKhoaDaoTao> data, Constants.ExportType type)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B014_BaoCaoTongKetKhoaDaoTao);
                rpt.Load(path);
                B014_BindingData(data, rpt);
                string tempPath = Path.Combine(Path.GetTempPath(), Constants.FileName.DaoTao.B014_BaoCaoTongKetKhoaDaoTao);
                tempPath = Export(rpt, tempPath, type);
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void B014_BindingData(List<B014_BaoCaoTongKetKhoaDaoTao> data, ReportDocument rpt)
        {
            if (data.Count > 0)
            {
                DataTable dt = ConvertToDataTable(data);
                rpt.SetDataSource(dt);
            }
        }

        #endregion

        #region B015_BaoCaoThongKeHocVienTheoLop

        public ReportDocument B015_BaoCaoThongKeHocVienTheoLop(List<B015_BaoCaoThongKeHocVienTheoLop> data)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B015_BaoCaoThongKeHocVienTheoLop);
                rpt.Load(path);
                B015_BindingData(data, rpt);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void B015_BaoCaoThongKeHocVienTheoLop(List<B015_BaoCaoThongKeHocVienTheoLop> data, Constants.ExportType type)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.B015_BaoCaoThongKeHocVienTheoLop);
                rpt.Load(path);
                B015_BindingData(data, rpt);
                string tempPath = Path.Combine(Path.GetTempPath(), Constants.FileName.DaoTao.B015_BaoCaoThongKeHocVienTheoLop);
                tempPath = Export(rpt, tempPath, type);
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void B015_BindingData(List<B015_BaoCaoThongKeHocVienTheoLop> data, ReportDocument rpt)
        {
            if (data.Count > 0)
            {
                DataTable dt = ConvertToDataTable(data);
                rpt.SetDataSource(dt);
            }
        }

        #endregion

        #region D001_DanhSachKhoaHoc

        public ReportDocument D001_DanhSachKhoaHocCRVBinding(D001_DanhSachKhoaHoc data)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.D001_DanhSachKhoaHocRpt);
                rpt.Load(path);
                D001_BindingData(data, rpt);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void D001_DanhSachKhoaHoc(D001_DanhSachKhoaHoc data, Constants.ExportType type)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.D001_DanhSachKhoaHocRpt);
                rpt.Load(path);
                D001_BindingData(data, rpt);
                string tempPath = Path.Combine(Path.GetTempPath(), Constants.FileName.DaoTao.D001_DanhSachKhoaHoc);
                tempPath = Export(rpt, tempPath, type);
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void D001_BindingData(D001_DanhSachKhoaHoc data, ReportDocument rpt)
        {
            if (data.ListKhoaHoc != null)
            {
                DataTable dt = ConvertToDataTable(data.ListKhoaHoc);
                rpt.SetDataSource(dt);
            }

            ReplaceData(rpt, "NgayBatDau", string.IsNullOrEmpty(data.NgayBatDau) ? string.Empty : data.NgayBatDau);
            ReplaceData(rpt, "NgayKetThuc", string.IsNullOrEmpty(data.NgayKetThuc) ? string.Empty : data.NgayKetThuc);
            ReplaceData(rpt, "NgayLapBaoCao", string.IsNullOrEmpty(data.NgayLapBaoCao) ? Constants.EmptyData.NgayViet : data.NgayLapBaoCao);
            ReplaceData(rpt, "NguoiLapBaoCao", string.IsNullOrEmpty(data.NguoiLapBaoCao) ? string.Empty : data.NguoiLapBaoCao);
        }

        public void D001_DanhSachKhoaHoc(D001_DanhSachKhoaHoc data)
        {
            if (data == null)
                return;

            string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.D001_DanhSachKhoaHoc);
            string tempPath = string.Empty;
            String result = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = ReplaceDataD001(data, line);
                        line = result = result + line;
                    }

                    string fileName = Constants.FileName.DaoTao.D001_DanhSachKhoaHoc + ".html";
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

        private static string ReplaceDataD001(D001_DanhSachKhoaHoc data, String line)
        {
            line = line.Replace("$TuNgay", string.IsNullOrEmpty(data.NgayBatDau) ? string.Empty : data.NgayBatDau);
            line = line.Replace("$DenNgay", string.IsNullOrEmpty(data.NgayKetThuc) ? string.Empty : data.NgayKetThuc);
            string dataTable = GetDanhSachKhoaHoc(data.ListKhoaHoc);
            line = line.Replace("$DataTable", string.IsNullOrEmpty(dataTable) ? string.Empty : dataTable);
            return line;
        }

        private static string GetDanhSachKhoaHoc(List<KhoaDaoTao> list)
        {
            if (list.Count == 0)
                return string.Empty;

            string dataTable = string.Empty;
            int stt = 0;
            foreach (KhoaDaoTao item in list)
            {
                stt++;
                dataTable = dataTable + "<TR>";
                dataTable = dataTable + "<TD class='tr7 td17' style='border-bottom: #000000 1px solid;'><P class='p15 ft6'>" + stt + "</P></TD>";
                dataTable = dataTable + "<TD class='tr7 td18' style='border-bottom: #000000 1px solid;'><P class='p16 ft6'>" + item.TenKhoaHoc + "</P></TD>";
                dataTable = dataTable + "<TD class='tr7 td19' style='border-bottom: #000000 1px solid;'><P class='p2 ft2'>&nbsp;</P></TD>";
                dataTable = dataTable + "<TD class='tr7 td20' style='border-bottom: #000000 1px solid;'><P class='p17 ft6'><NOBR>" + item.ThoiGian + "</NOBR></P></TD>";
                dataTable = dataTable + "<TD class='tr7 td21' style='border-bottom: #000000 1px solid;'><P class='p11 ft6'>" + item.NguonKP + "</P></TD>";
                dataTable = dataTable + "<TD class='tr7 td22' style='border-bottom: #000000 1px solid;'><P class='p16 ft6'>" + item.CBPhuTrach + "</P></TD>";
                dataTable = dataTable + "<TD class='tr7 td23' style='border-bottom: #000000 1px solid;'><P class='p18 ft6'>" + item.SoHV + "</P></TD>";
                dataTable = dataTable + "<TD class='tr7 td24' style='border-bottom: #000000 1px solid;'><P class='p19 ft6'>" + item.TrangThai + "</P></TD>";
                dataTable = dataTable + "</TR>";
            }

            return dataTable;
        }

        #endregion

        #region D002_DanhSachHocVienNhanGiayChungNhan

        public ReportDocument D002_DanhSachHocVienNhanGiayChungNhan(D002_DanhSachHocVienNhanGiayChungNhan data)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.D002_DanhSachHocVienNhanGiayChungNhan);
                rpt.Load(path);
                D002_BindingData(data, rpt);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void D002_DanhSachHocVienNhanGiayChungNhan(D002_DanhSachHocVienNhanGiayChungNhan data, Constants.ExportType type)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.D002_DanhSachHocVienNhanGiayChungNhan);
                rpt.Load(path);
                D002_BindingData(data, rpt);
                string tempPath = Path.Combine(Path.GetTempPath(), Constants.FileName.DaoTao.D002_DanhSachHocVienNhanGiayChungNhan);
                tempPath = Export(rpt, tempPath, type);
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void D002_BindingData(D002_DanhSachHocVienNhanGiayChungNhan data, ReportDocument rpt)
        {
            if (data.ListHocVien != null)
            {
                DataTable dt = ConvertToDataTable(data.ListHocVien);
                rpt.SetDataSource(dt);
            }

            ReplaceData(rpt, "KhoaDaoTao", string.IsNullOrEmpty(data.KhoaDaoTao) ? string.Empty : data.KhoaDaoTao);
            ReplaceData(rpt, "ThoiGianTu", string.IsNullOrEmpty(data.ThoiGianTu) ? string.Empty : data.ThoiGianTu);
            ReplaceData(rpt, "ThoiGianDen", string.IsNullOrEmpty(data.ThoiGianDen) ? string.Empty : data.ThoiGianDen);
            ReplaceData(rpt, "NgayLap", string.IsNullOrEmpty(data.NgayLap) ? Constants.EmptyData.NgayViet : data.NgayLap);
            ReplaceData(rpt, "GiamDocTrungTam", string.IsNullOrEmpty(data.GiamDocTrungTam) ? string.Empty : data.GiamDocTrungTam);
        }

        #endregion

        #region D003_DanhSachLopHoc2

        public ReportDocument D003_DanhSachLopHoc2(D003_DanhSachLopHoc2 data)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.D003_DanhSachLopHoc2);
                rpt.Load(path);
                D003_BindingData(data, rpt);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void D003_DanhSachLopHoc2(D003_DanhSachLopHoc2 data, Constants.ExportType type)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.D003_DanhSachLopHoc2);
                rpt.Load(path);
                D003_BindingData(data, rpt);
                string tempPath = Path.Combine(Path.GetTempPath(), Constants.FileName.DaoTao.D003_DanhSachLopHoc2);
                tempPath = Export(rpt, tempPath, type);
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void D003_BindingData(D003_DanhSachLopHoc2 data, ReportDocument rpt)
        {
            if (data.ListHocVien != null)
            {
                DataTable dt = ConvertToDataTable(data.ListHocVien);
                rpt.SetDataSource(dt);
            }

            ReplaceData(rpt, "KhoaDaoTao", string.IsNullOrEmpty(data.KhoaDaoTao) ? string.Empty : data.KhoaDaoTao);
            ReplaceData(rpt, "ThoiGianTu", string.IsNullOrEmpty(data.ThoiGianTu) ? string.Empty : data.ThoiGianTu);
            ReplaceData(rpt, "ThoiGianDen", string.IsNullOrEmpty(data.ThoiGianDen) ? string.Empty : data.ThoiGianDen);
            ReplaceData(rpt, "NgayLap", string.IsNullOrEmpty(data.NgayLap) ? Constants.EmptyData.NgayViet : data.NgayLap);
            ReplaceData(rpt, "GiamDocTrungTam", string.IsNullOrEmpty(data.GiamDocTrungTam) ? string.Empty : data.GiamDocTrungTam);
        }

        #endregion

        #region D004_DanhSachThuTienTaiTDC

        public ReportDocument D004_DanhSachThuTienTaiTDC(D004_DanhSachThuTienTaiTDC data)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.D004_DanhSachThuTienTaiTDC);
                rpt.Load(path);
                D004_BindingData(data, rpt);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void D004_DanhSachThuTienTaiTDC(D004_DanhSachThuTienTaiTDC data, Constants.ExportType type)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.D004_DanhSachThuTienTaiTDC);
                rpt.Load(path);
                D004_BindingData(data, rpt);
                string tempPath = Path.Combine(Path.GetTempPath(), Constants.FileName.DaoTao.D004_DanhSachThuTienTaiTDC);
                tempPath = Export(rpt, tempPath, type);
                Process.Start(tempPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void D004_BindingData(D004_DanhSachThuTienTaiTDC data, ReportDocument rpt)
        {
            if (data.ListDanhSachHocVien != null)
            {
                DataTable dt = ConvertToDataTable(data.ListDanhSachHocVien);
                rpt.SetDataSource(dt);
            }

            ReplaceData(rpt, "TenLop", string.IsNullOrEmpty(data.TenLop) ? string.Empty : data.TenLop);
            ReplaceData(rpt, "ThoiGianTu", string.IsNullOrEmpty(data.ThoiGianTu) ? string.Empty : data.ThoiGianTu);
            ReplaceData(rpt, "ThoiGianDen", string.IsNullOrEmpty(data.ThoiGianDen) ? string.Empty : data.ThoiGianDen);
            ReplaceData(rpt, "TongSoTien", string.IsNullOrEmpty(data.TongSoTien) ? string.Empty : data.TongSoTien);
            ReplaceData(rpt, "TongSoTienBangChu", string.IsNullOrEmpty(data.TongSoTienBangChu) ? string.Empty : data.TongSoTienBangChu);
            ReplaceData(rpt, "NgayLap", string.IsNullOrEmpty(data.NgayLap) ? Constants.EmptyData.NgayViet : data.NgayLap);
            ReplaceData(rpt, "NguoiLapBaoCao", string.IsNullOrEmpty(data.NguoiLapBaoCao) ? string.Empty : data.NguoiLapBaoCao);
        }

        #endregion

        #region L001_LichLopHocLichGiangLyThuyet

        public void L001_LichLopHocLichGiangLyThuyet(L001_LichLopHocLichGiang data)
        {
            L001_LichLopHocLichGiang(data, Constants.Common.Title_LichGiangLyThuyet);
        }

        public void L001_LichLopHocLichGiangThucHanh(L001_LichLopHocLichGiang data)
        {
            L001_LichLopHocLichGiang(data, Constants.Common.Title_LichGiangThucHanh);
        }

        protected void L001_LichLopHocLichGiang(L001_LichLopHocLichGiang data, string title)
        {
            if (data == null)
                return;

            string path = Path.Combine(Environment.CurrentDirectory, Constants.TemplatePath.L001_LichLopHocLichGiang);
            string tempPath = string.Empty;
            String result = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = ReplaceDataL001(data, title, line);
                        line = result = result + line;
                    }

                    string fileName = string.Empty;
                    if (title == Constants.Common.Title_LichGiangLyThuyet)
                    {
                        fileName = Constants.FileName.DaoTao.L001_LichLopHocLichGiangLyThuyet + ".html";
                    }
                    else
                    {
                        fileName = Constants.FileName.DaoTao.L002_LichLopHocLichGiangThucHanh + ".html";
                    }

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

        private static string ReplaceDataL001(L001_LichLopHocLichGiang data, string title, String line)
        {
            line = line.Replace("$Title", string.IsNullOrEmpty(title) ? string.Empty : title);
            line = line.Replace("$KhoaDaoTao", string.IsNullOrEmpty(data.KhoaDaoTao) ? string.Empty : data.KhoaDaoTao);
            line = line.Replace("$TuNgay", string.IsNullOrEmpty(data.NgayBatDau) ? string.Empty : data.NgayBatDau);
            line = line.Replace("$DenNgay", string.IsNullOrEmpty(data.NgayKetThuc) ? string.Empty : data.NgayKetThuc);
            string dataTable = GetDanhSachLichGiang(data.ListLichGiang);
            line = line.Replace("$DataTable", string.IsNullOrEmpty(dataTable) ? string.Empty : dataTable);
            return line;
        }

        private static string GetDanhSachLichGiang(List<LichGiang> list)
        {
            if (list.Count == 0)
                return string.Empty;

            string dataTable = string.Empty;
            int stt = 0;
            foreach (LichGiang item in list)
            {
                stt++;
                dataTable = dataTable + "<TR>";
                dataTable = dataTable + "<TD class='tr5 td15'><P class='p4 ft2'>" + item.Thoigian + "</P></TD>";
                dataTable = dataTable + "<TD colspan='2' class='tr5 td16'><P class='p4 ft2'>" + item.NoiDungGiang + "</P></TD>";
                dataTable = dataTable + "<TD class='tr5 td17'><P class='p4 ft2'>" + item.SoTiet + "</P></TD>";
                dataTable = dataTable + "<TD class='tr5 td18'><P class='p4 ft2'>&nbsp;</P></TD>";
                dataTable = dataTable + "</TR>";
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
