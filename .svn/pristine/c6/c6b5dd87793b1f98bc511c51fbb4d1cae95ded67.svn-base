using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OfficeReporting.LIB;

namespace OfficeReporting.Report
{
    public class ReportCanBoChuyenGiaoKyThuat
    {
        private WordTemplates wordTemplates;
        public ReportCanBoChuyenGiaoKyThuat()
        {
            wordTemplates = new WordTemplates();
        }

        public string IFileName
        {
            get;
            set;
        }

        public string GenarateReport()
        {
            try
            {
                object missing = System.Reflection.Missing.Value;

                wordTemplates.CreateNewDocument();
                // xoay ngang page
                wordTemplates.WordDoc.Content.PageSetup.TogglePortrait();
                wordTemplates.WordDoc.Content.PageSetup.TopMargin = 40F;
                wordTemplates.WordDoc.Content.PageSetup.BottomMargin = 40F;
                wordTemplates.WordDoc.Content.PageSetup.LeftMargin = 20F;
                wordTemplates.WordDoc.Content.PageSetup.RightMargin = 20F;

                //Add paragraph - Bo y te
                wordTemplates.InsertParagraph("Bộ y tế", "Normal", "Times New Roman", 12, "left", true, 0);

                // Add paragraph - Benh vien bach mai
                wordTemplates.InsertParagraph("bệnh viện bạch mai", "Bold", "Times New Roman", 13, "LEFT", true, 0);

                //Add paragraph - DANH SÁCH CÁN BỘ NHẬN CHUYỂN GIAO CÔNG NGHỆ KỸ THUẬT
                wordTemplates.InsertParagraph("danh sách cán bộ nhận chuyển giao công nghệ kỹ thuật", "Bold", "Times New Roman", 14, "center", true, 0);

                // Add paragraph - Theo hop dong so
                wordTemplates.InsertParagraph("Theo hợp đồng số: ........................", "Bold", "Times New Roman", 13, "center", false, 0);

                // Add paragraph - Tai benh vien
                wordTemplates.InsertParagraph("Tại bệnh viện: ............................................................................................................................................................................", "Bold", "Times New Roman", 14, "left", false, 0);

                // tạo bảng dữ liệu
                wordTemplates.InsertTable(5);

                wordTemplates.InsertParagraph(" ", "normal", "Times New Roman", 11, "left", false, 0);
                // tạo chữ ký
                wordTemplates.InsertSignatureForm(@"Nguyễn Hữu Hào", @"Bệnh viện Bạch Mai");

                //Save the document
                //filename = @"E:\baocaocanbokt.docx";
                wordTemplates.SaveAs(IFileName);

                return @"Tạo báo cáo thành công tại :" + IFileName.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
                //return "Thao tác lỗi tại: " + e.ToString();
            }
        }
    }
}
