using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Word = Microsoft.Office.Interop.Word;
using Reporting.LIB;

namespace Reporting.Business
{
    public class WordTemplates
    {
        private Word.Application wordApp;
        private Word.Document wordDoc;

        public WordTemplates()
        {
            wordApp = new Word.Application();
        }

        /// <summary>
        /// Tạo mới tệp tài liệu
        /// </summary>
        private void CreateNewDocument()
        {
            object missing = System.Reflection.Missing.Value;
            //wordApp.ShowAnimation = false;
            wordApp.Visible = true;
            wordDoc = wordApp.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            wordDoc.Activate();
        }

        /// <summary>
        /// Mở tệp tài lệu (tệp đã đã tồn tại)
        /// </summary>
        /// <param name="fileName">Đường dẫn đầy đủ, tên tệp tài liệu</param>
        private void OpenDocument(object fileName)
        {
            object readOnly = false;
            object isVisible = true;
            object missing = System.Reflection.Missing.Value;
            wordDoc = wordApp.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing, ref missing,
                                            ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                                            ref isVisible, ref missing, ref missing, ref missing, ref missing);
            wordDoc.Activate();
        }

        /// <summary>
        /// Sao lưu tệp tài liệu
        /// </summary>
        /// <param name="fileName"></param>
        private void SaveAs(object fileName)
        {
            object missing = System.Reflection.Missing.Value;
            wordDoc.SaveAs(ref fileName, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
            wordDoc.Close(ref missing, ref missing, ref missing);
            wordDoc = null;
            wordApp.Quit(ref missing, ref missing, ref missing);
            wordApp = null;
        }

        /// <summary>
        /// Tạo đoạn văn bản
        /// </summary>
        /// <param name="paraText">nội dung văn bản</param>
        /// <param name="fontStyle">Bold: chữ in đậm. Italic: chữ in nghiêng. Underline: ngạch chân chữ</param>
        /// <param name="fontName">font chữ</param>
        /// <param name="fontSize">kích thước font chữ</param>
        /// <param name="alignment">Căn dòng. Nếu L/l/Left/left/LEFT: căn dòng trái. Nếu R/r/Right/right/RIGHT: căn dòng phải. Nếu C/c/Center/center/CENTER: căn giưa. Mắc định căn đều</param>
        private void InsertParagraph(string paraText, string fontType, string fontName, int fontSize, string alignment, bool isUpper, float paraSpacing)
        {
            object missing = System.Reflection.Missing.Value;
            Word.Paragraph para = wordDoc.Content.Paragraphs.Add(ref missing);
            if (isUpper == true)
                paraText = paraText.ToUpper();
            para.Range.Text = paraText;
            switch (fontType)
            {
                case "Bold":
                    para.Range.Bold = 1;
                    break;
                case "Italic":
                    para.Range.Italic = 1;
                    break;
                case "Underlined":
                    para.Range.Font.Subscript = 0;
                    break;
                default:
                    para.Range.Bold = 0;
                    break;
            }
            para.Range.Font.Name = fontName;
            para.Range.Font.Size = fontSize; ;
            para.Range.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceSingle;
            para.Range.ParagraphFormat.SpaceAfter = paraSpacing;
            if (alignment == "L" || alignment == "l" || alignment == "Left" || alignment == "left" || alignment == "LEFT")
            {
                para.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            }
            else if (alignment == "R" || alignment == "r" || alignment == "Right" || alignment == "right" || alignment == "RIGHT")
            {
                para.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            }
            else if (alignment == "C" || alignment == "c" || alignment == "Center" || alignment == "center" || alignment == "CENTER")
            {
                para.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            }
            else
            {
                para.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            }
            para.Range.InsertParagraphAfter();
        }



        private void CreateParagraphWithMultiFontStyle(string mainText, string contentText, string fontName, int fontSize, string alignment, float paraSpacing)
        {
            object missing = System.Reflection.Missing.Value;
            Word.Paragraph paragraph = wordDoc.Content.Paragraphs.Add(ref missing);
            string text = mainText + contentText;
            paragraph.Range.Text = text;
            paragraph.Range.Font.Name = fontName;
            paragraph.Range.Font.Size = fontSize;
            paragraph.Range.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceSingle;
            paragraph.Range.ParagraphFormat.SpaceAfter = paraSpacing;
            if (alignment == "L" || alignment == "l" || alignment == "Left" || alignment == "left" || alignment == "LEFT")
            {
                paragraph.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            }
            else if (alignment == "R" || alignment == "r" || alignment == "Right" || alignment == "right" || alignment == "RIGHT")
            {
                paragraph.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            }
            else if (alignment == "C" || alignment == "c" || alignment == "Center" || alignment == "center" || alignment == "CENTER")
            {
                paragraph.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            }
            else
            {
                paragraph.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            }
            int i = 0;
            int index = text.IndexOf(mainText, i);
            while (index > 0)
            {
                object oStart = paragraph.Range.Start + index;
                object oEnd = paragraph.Range.Start + index + 12;

                Word.Range subRange = wordDoc.Range(oStart, oEnd);
                subRange.Bold = 1;

                i = index + 12;
                index = text.IndexOf(mainText, i);
            }
            paragraph.Range.InsertParagraphAfter();
        }


        /// <summary>
        /// tạo header cho văn bản
        /// </summary>
        /// <param name="headerText">nội dung header</param>
        /// <param name="isBold">Giá trị trả về true: kiểu chữ đậm</param>
        /// <param name="isUpperCase">Giá trị trả về true: kiểu chữ in hoa</param>
        /// <param name="alignment">Căn lề. Nếu L/l/Left/left/LEFT: căn lề trái. Nếu R/r/Right/right/RIGHT: căn lề phải. Mặc định căn lề giữa</param>
        /// <param name="fontSize">size of font</param>
        private void InsertHeader(string headerText, bool isBold, bool isUpperCase, string alignment, int fontSize)
        {
            //Add header into the document
            foreach (Microsoft.Office.Interop.Word.Section section in wordDoc.Sections)
            {
                Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                if (alignment == "L" || alignment == "l" || alignment == "Left" || alignment == "left" || alignment == "LEFT")
                {
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                }
                else if (alignment == "R" || alignment == "r" || alignment == "Right" || alignment == "right" || alignment == "RIGHT")
                {
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight;
                }
                else
                {
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }
                //headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlue; // color for header
                if (isBold == true)
                {
                    headerRange.Font.Bold = 1;
                }
                else
                {
                    headerRange.Font.Bold = 0;
                }
                if (isUpperCase == true)
                {
                    headerText = headerText.ToUpper();
                }

                headerRange.Font.Size = fontSize;
                headerRange.Text = headerText;

            }
        }


        /// <summary>
        /// Tạo nội dung cho header với chèn hình ảnh vào văn bản
        /// </summary>
        /// <param name="imageUrl">Đường dẫn ảnh</param>
        /// <param name="alignment">Căn lề. Nếu L/l/Left/left/LEFT: căn lề trái. Nếu R/r/Right/right/RIGHT: căn lề phải. Mặc định căn lề giữa</param>
        private void InsertHeaderWithInsertImage(string imageUrl, string alignment)
        {
            object missing = System.Reflection.Missing.Value;
            Image headerImage = Image.FromFile(imageUrl.ToString());
            //Add header into the document
            foreach (Microsoft.Office.Interop.Word.Section section in wordDoc.Sections)
            {
                Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                if (alignment == "L" || alignment == "l" || alignment == "Left" || alignment == "left" || alignment == "LEFT")
                {
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                }
                else if (alignment == "R" || alignment == "r" || alignment == "Right" || alignment == "right" || alignment == "RIGHT")
                {
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight;
                }
                else
                {
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                headerRange.InlineShapes.AddPicture(imageUrl, ref missing, ref missing, ref missing);
            }


        }

        /// <summary>
        /// Tạo nội dung footer văn bản
        /// </summary>
        /// <param name="footerText">nội dung footer</param>
        /// <param name="alignment">Căn lề. Nếu L/l/Left/left/LEFT: căn lề trái. Nếu R/r/Right/right/RIGHT: căn lề phải. Mặc định căn lề giữa</param>
        /// <param name="fontSize">size of font</param>
        /// <param name="isUpper">Giá trị trả về true: chữ in hoa</param>
        /// <param name="isBold">Giá trị trả về true: chữ đậm</param>
        private void InsertFooter(string footerText, string alignment, int fontSize, bool isUpper, bool isBold)
        {
            //Add the footers into the document
            foreach (Word.Section wordSection in wordDoc.Sections)
            {
                Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                //footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdDarkRed;
                footerRange.Font.Size = fontSize;
                if (alignment == "L" || alignment == "l" || alignment == "Left" || alignment == "left" || alignment == "LEFT")
                {
                    footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                }
                else if (alignment == "R" || alignment == "r" || alignment == "Right" || alignment == "right" || alignment == "RIGHT")
                {
                    footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight;
                }
                else
                {
                    footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }
                if (isBold == true)
                    footerRange.Font.Bold = 1;
                else
                    footerRange.Font.Bold = 0;
                if (isUpper == true)
                    footerText = footerText.ToUpper();
                footerRange.Text = footerText;
            }
        }

        private void FillData(Word.Table table, List<CanBo_NhanCGKT> item)
        {
            foreach (Word.Row row in table.Rows)
            {
                foreach (Word.Cell cell in row.Cells)
                {
                    //Data row
                    if (cell.RowIndex > 1 && cell.RowIndex != 2)
                    {
                        table.Cell(cell.RowIndex, 1).Range.Text = item[cell.RowIndex].TT.ToString();
                        table.Cell(cell.RowIndex, 2).Range.Text = item[cell.RowIndex].HoTenCanBo.ToString();
                        if (item[cell.RowIndex].TrinhDo == "Bác sĩ")
                        {
                            table.Cell(cell.RowIndex, 3).Range.Text = "x";
                            table.Cell(cell.RowIndex, 4).Range.Text = string.Empty;
                            table.Cell(cell.RowIndex, 5).Range.Text = string.Empty;
                        }
                        else if (item[cell.RowIndex].TrinhDo == "Điều dưỡng/KTV")
                        {
                            table.Cell(cell.RowIndex, 3).Range.Text = string.Empty;
                            table.Cell(cell.RowIndex, 4).Range.Text = "x";
                            table.Cell(cell.RowIndex, 5).Range.Text = string.Empty;
                        }
                        else
                        {
                            table.Cell(cell.RowIndex, 3).Range.Text = string.Empty;
                            table.Cell(cell.RowIndex, 4).Range.Text = string.Empty;
                            table.Cell(cell.RowIndex, 5).Range.Text = "x";
                        }
                        table.Cell(cell.RowIndex, 6).Range.Text = item[cell.RowIndex].TenKyThuatChuyenGiao.ToString();
                        table.Cell(cell.RowIndex, 7).Range.Text = item[cell.RowIndex].DiemDanhGiaTruocCG.ToString();
                        table.Cell(cell.RowIndex, 8).Range.Text = item[cell.RowIndex].SoLanThucHanh.ToString();
                        table.Cell(cell.RowIndex, 9).Range.Text = item[cell.RowIndex].DiemDanhGiaSauCG.ToString();
                        table.Cell(cell.RowIndex, 10).Range.Text = item[cell.RowIndex].KetLuan_Dat.ToString();
                        table.Cell(cell.RowIndex, 11).Range.Text = item[cell.RowIndex].KetLuan_ChuaDat.ToString();
                        table.Cell(cell.RowIndex, 12).Range.Text = item[cell.RowIndex].Lydo.ToString();

                        cell.Range.Font.Bold = 0;
                        cell.Range.Font.Size = 12;
                        cell.Range.Font.Name = "Times New Roman";
                    }

                }
            }
        }

        private void InsertTable(List<CanBo_NhanCGKT> item)
        {
            object missing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";

            // create table which contains data from database
            //Create a 5X8 table and insert some dummy record
            Word.Range paraTable = wordDoc.Bookmarks.get_Item(oEndOfDoc).Range;
            Word.Table dataTable = wordDoc.Tables.Add(paraTable, item.Count, 12, ref missing, ref missing);
            Word.Cell cell;

            dataTable.Range.Font.Name = "Times New Roman";
            dataTable.Cell(1, 1).Range.Text = "TT";
            dataTable.Cell(1, 1).Range.Font.Size = 12;
            dataTable.Cell(1, 1).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            dataTable.Cell(1, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            dataTable.Cell(1, 2).Range.Text = "Họ và tên CB nhận chuyển giao kỹ thuật";
            dataTable.Cell(1, 2).Range.Font.Size = 12;
            dataTable.Cell(1, 2).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            dataTable.Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            dataTable.Cell(1, 3).Range.Text = "Trình độ";
            dataTable.Cell(1, 3).Range.Font.Size = 12;
            dataTable.Cell(1, 3).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            dataTable.Cell(1, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            dataTable.Cell(1, 6).Range.Text = "Tên kỹ thuật được chuyển giao";
            dataTable.Cell(1, 6).Range.Font.Size = 12;
            dataTable.Cell(1, 6).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            dataTable.Cell(1, 6).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            dataTable.Cell(1, 7).Range.Text = "Điểm đánh giá trước chuyển giao";
            dataTable.Cell(1, 7).Range.Font.Size = 12;
            dataTable.Cell(1, 7).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            dataTable.Cell(1, 7).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            dataTable.Cell(1, 8).Range.Text = "Số lần thực hành KT";
            dataTable.Cell(1, 8).Range.Font.Size = 12;
            dataTable.Cell(1, 8).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            dataTable.Cell(1, 8).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            dataTable.Cell(1, 9).Range.Text = "Điểm đánh giá sau chuyển giao";
            dataTable.Cell(1, 9).Range.Font.Size = 12;
            dataTable.Cell(1, 9).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            dataTable.Cell(1, 9).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            dataTable.Cell(1, 10).Range.Text = "Kết luận";
            dataTable.Cell(1, 10).Range.Font.Size = 12;
            dataTable.Cell(1, 10).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            dataTable.Cell(1, 10).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            // SET WIDTH FOR COLUMN
            dataTable.Columns[1].SetWidth(30, Word.WdRulerStyle.wdAdjustNone);
            dataTable.Columns[2].SetWidth(120, Word.WdRulerStyle.wdAdjustNone);
            dataTable.Columns[3].SetWidth(30, Word.WdRulerStyle.wdAdjustNone);
            dataTable.Columns[4].SetWidth(45, Word.WdRulerStyle.wdAdjustNone);
            dataTable.Columns[5].SetWidth(40, Word.WdRulerStyle.wdAdjustNone);
            dataTable.Columns[6].SetWidth(150, Word.WdRulerStyle.wdAdjustNone);
            dataTable.Columns[7].SetWidth(80, Word.WdRulerStyle.wdAdjustNone);
            dataTable.Columns[8].SetWidth(50, Word.WdRulerStyle.wdAdjustNone);
            dataTable.Columns[9].SetWidth(80, Word.WdRulerStyle.wdAdjustNone);
            dataTable.Columns[10].SetWidth(30, Word.WdRulerStyle.wdAdjustNone);
            dataTable.Columns[11].SetWidth(40, Word.WdRulerStyle.wdAdjustNone);
            dataTable.Columns[12].SetWidth(50, Word.WdRulerStyle.wdAdjustNone);

            FillData(dataTable, item);


            cell = dataTable.Cell(1, 1);
            cell.Merge(dataTable.Cell(2, 1));

            cell = dataTable.Cell(1, 2);
            cell.Merge(dataTable.Cell(2, 2));

            cell = dataTable.Cell(1, 3);
            cell.Merge(dataTable.Cell(1, 4));

            cell = dataTable.Cell(1, 3);
            cell.Merge(dataTable.Cell(1, 4));

            cell = dataTable.Cell(1, 4);
            cell.Merge(dataTable.Cell(2, 6));

            cell = dataTable.Cell(1, 5);
            cell.Merge(dataTable.Cell(2, 7));

            cell = dataTable.Cell(1, 6);
            cell.Merge(dataTable.Cell(2, 8));

            cell = dataTable.Cell(1, 7);
            cell.Merge(dataTable.Cell(2, 9));

            cell = dataTable.Cell(1, 8);
            cell.Merge(dataTable.Cell(1, 9));

            cell = dataTable.Cell(1, 8);
            cell.Merge(dataTable.Cell(1, 9));

            dataTable.Cell(2, 3).Range.Text = "BS";
            dataTable.Cell(2, 3).Range.Font.Size = 12;
            dataTable.Cell(2, 3).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            dataTable.Cell(2, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            dataTable.Cell(2, 4).Range.Text = "ĐD/KTV";
            dataTable.Cell(2, 4).Range.Font.Size = 12;
            dataTable.Cell(2, 4).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            dataTable.Cell(2, 4).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            dataTable.Cell(2, 5).Range.Text = "Khác";
            dataTable.Cell(2, 5).Range.Font.Size = 12;
            dataTable.Cell(2, 5).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            dataTable.Cell(2, 5).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            dataTable.Cell(2, 10).Range.Text = "Đạt";
            dataTable.Cell(2, 10).Range.Font.Size = 12;
            dataTable.Cell(2, 10).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            dataTable.Cell(2, 10).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            dataTable.Cell(2, 11).Range.Text = "Chưa đạt";
            dataTable.Cell(2, 11).Range.Font.Size = 12;
            dataTable.Cell(2, 11).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            dataTable.Cell(2, 11).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            dataTable.Cell(2, 12).Range.Text = "Lý do";
            dataTable.Cell(2, 12).Range.Font.Size = 12;
            dataTable.Cell(2, 12).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            dataTable.Cell(2, 12).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            try
            {
                dataTable.Borders.Shadow = true;
            }
            catch
            {
            }
        }

        /// <summary>
        /// Tạo form chữ ký báo cáo
        /// </summary>
        /// <param name="textLeft">Nội dung bên trái</param>
        /// <param name="textRight">Nội dung bên phải</param>
        private void InsertSignatureForm(string textLeft, string textRight)
        {
            object missing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";
            Microsoft.Office.Interop.Word.Table objTable;
            Microsoft.Office.Interop.Word.Range wrdRng = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

            objTable = wordDoc.Tables.Add(wrdRng, 2, 2, ref missing, ref missing);
            objTable.Range.ParagraphFormat.SpaceAfter = 7;

            objTable.Rows[1].Range.Font.Bold = 1;
            objTable.Rows[1].Range.Font.Size = 11;
            objTable.Cell(1, 1).Range.Text = "NGƯỜI LẬP BIỂU";
            objTable.Cell(1, 2).Range.Text = "XÁC NHẬN CỦA ĐƠN VỊ CHUYỂN GIAO";
            objTable.Cell(1, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Rows[2].Range.Font.Bold = 1;
            objTable.Rows[2].Range.Font.Italic = 1;
            objTable.Rows[2].Range.Font.Size = 11;
            objTable.Cell(2, 1).Range.Text = textLeft;
            objTable.Cell(2, 2).Range.Text = textRight;
            objTable.Cell(2, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(2, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            try
            {
                objTable.Borders.Shadow = false;
            }
            catch
            {
            }
        }

        private void InsertSignatureForm_HanhChinh(string CanBoBenGiao, string CanBoBenNhan)
        {
            object missing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";
            Microsoft.Office.Interop.Word.Table objTable;
            Microsoft.Office.Interop.Word.Range wrdRng = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

            objTable = wordDoc.Tables.Add(wrdRng, 2, 2, ref missing, ref missing);
            objTable.Range.ParagraphFormat.SpaceAfter = 7;

            objTable.Rows[1].Range.Font.Bold = 1;
            objTable.Rows[1].Range.Font.Size = 11;
            objTable.Cell(1, 1).Range.Text = "ĐẠI DIỆN BÊN GIAO";
            objTable.Cell(1, 2).Range.Text = "ĐẠI DIỆN BÊN NHẬN";
            objTable.Cell(1, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Rows[2].Range.Font.Bold = 1;
            objTable.Rows[2].Range.Font.Italic = 1;
            objTable.Rows[2].Range.Font.Size = 11;
            objTable.Cell(2, 1).Range.Text = "(Ký, ghi rõ họ tên)";
            objTable.Cell(2, 2).Range.Text = "(Ký, ghi rõ họ tên)";
            objTable.Cell(2, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(2, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(3, 1).Range.Text = CanBoBenGiao;
            objTable.Cell(3, 1).Range.Font.Bold = 1;
            objTable.Cell(3, 1).Range.Paragraphs.SpaceAfter = 20;
            objTable.Cell(3, 2).Range.Text = CanBoBenNhan;
            objTable.Cell(3, 2).Range.Font.Bold = 1;
            objTable.Cell(3, 2).Range.Paragraphs.SpaceAfter = 20;
            objTable.Cell(3, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(3, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            try
            {
                objTable.Borders.Shadow = false;
            }
            catch
            {
            }
        }

        private void InsertSignatureForm_CongVanDen(string TongSoCongVan, string location)
        {
            object missing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";
            Microsoft.Office.Interop.Word.Table objTable;
            Microsoft.Office.Interop.Word.Range wrdRng = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

            objTable = wordDoc.Tables.Add(wrdRng, 2, 2, ref missing, ref missing);
            objTable.Range.ParagraphFormat.SpaceAfter = 7;

            objTable.Rows[1].Range.Font.Bold = 1;
            objTable.Rows[1].Range.Font.Size = 11;
            objTable.Cell(1, 1).Range.Text = TongSoCongVan;
            objTable.Cell(1, 2).Range.Text = "";
            objTable.Cell(1, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Rows[2].Range.Font.Bold = 1;
            objTable.Rows[2].Range.Font.Italic = 1;
            objTable.Rows[2].Range.Font.Size = 11;
            objTable.Cell(2, 1).Range.Text = location;
            objTable.Cell(2, 2).Range.Text = "Người lập báo cáo";
            objTable.Cell(2, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(2, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            try
            {
                objTable.Borders.Shadow = false;
            }
            catch
            {
            }
        }

        private void InsertSignatureForm_DKGDPH(string location)
        {
            object missing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";
            Microsoft.Office.Interop.Word.Table objTable;
            Microsoft.Office.Interop.Word.Range wrdRng = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

            objTable = wordDoc.Tables.Add(wrdRng, 2, 2, ref missing, ref missing);
            objTable.Range.ParagraphFormat.SpaceAfter = 7;

            objTable.Rows[1].Range.Font.Bold = 1;
            objTable.Rows[1].Range.Font.Size = 11;
            objTable.Cell(1, 1).Range.Text = string.Empty;
            objTable.Cell(1, 2).Range.Text = location;
            objTable.Cell(1, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Rows[2].Range.Font.Bold = 1;
            objTable.Rows[2].Range.Font.Italic = 1;
            objTable.Rows[2].Range.Font.Size = 11;
            objTable.Cell(2, 1).Range.Text = string.Empty;
            objTable.Cell(2, 2).Range.Text = "Người báo cáo";
            objTable.Cell(2, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(2, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            try
            {
                objTable.Borders.Shadow = false;
            }
            catch
            {
            }
        }

        private void InsertSignatureForm_VanPhongPham_TheoTo(string LanhDao, string NhomTruong, string NguoiNhan, string NguoiDuTru)
        {
            object missing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";
            Microsoft.Office.Interop.Word.Table objTable;
            Microsoft.Office.Interop.Word.Range wrdRng = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

            objTable = wordDoc.Tables.Add(wrdRng, 2, 2, ref missing, ref missing);
            objTable.Range.ParagraphFormat.SpaceAfter = 7;

            objTable.Rows[1].Range.Font.Bold = 1;
            objTable.Rows[1].Range.Font.Size = 11;
            objTable.Cell(1, 1).Range.Text = "LÃNH ĐẠO TT ĐT & CDT";
            objTable.Cell(1, 2).Range.Text = "NHÓM TRƯỞNG";
            objTable.Cell(1, 3).Range.Text = "NGƯỜI NHẬN";
            objTable.Cell(1, 4).Range.Text = "NGƯỜI DỰ TRÙ";
            objTable.Cell(1, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(1, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(1, 4).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Rows[2].Range.Font.Bold = 1;
            objTable.Rows[2].Range.Font.Italic = 1;
            objTable.Rows[2].Range.Font.Size = 11;
            objTable.Cell(2, 1).Range.Text = LanhDao;
            objTable.Cell(2, 2).Range.Text = NhomTruong;
            objTable.Cell(2, 3).Range.Text = NguoiNhan;
            objTable.Cell(2, 4).Range.Text = NguoiDuTru;
            objTable.Cell(2, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(2, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(2, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(2, 4).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(2, 1).Range.ParagraphFormat.SpaceAfter = 20;
            objTable.Cell(2, 2).Range.ParagraphFormat.SpaceAfter = 20;
            objTable.Cell(2, 3).Range.ParagraphFormat.SpaceAfter = 20;
            objTable.Cell(2, 4).Range.ParagraphFormat.SpaceAfter = 20;
            objTable.Rows[2].Range.Font.Bold = 1;
            objTable.Rows[2].Range.Font.Italic = 1;


            try
            {
                objTable.Borders.Shadow = false;
            }
            catch
            {
            }
        }


        private void InsertSignatureForm_VanPhongPham(string LanhDao, string TruongPhong, string NguoiLapPhieu)
        {
            object missing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";
            Microsoft.Office.Interop.Word.Table objTable;
            Microsoft.Office.Interop.Word.Range wrdRng = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

            objTable = wordDoc.Tables.Add(wrdRng, 2, 2, ref missing, ref missing);
            objTable.Range.ParagraphFormat.SpaceAfter = 7;

            objTable.Rows[1].Range.Font.Bold = 1;
            objTable.Rows[1].Range.Font.Size = 11;
            objTable.Cell(1, 1).Range.Text = "NGƯỜI LẬP PHIẾU";
            objTable.Cell(1, 2).Range.Text = "LÃNH ĐẠO TT ĐT & CDT";
            objTable.Cell(1, 3).Range.Text = "TRƯỞNG PHÒNG HCQT";
            objTable.Cell(1, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(1, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Rows[2].Range.Font.Bold = 1;
            objTable.Rows[2].Range.Font.Italic = 1;
            objTable.Rows[2].Range.Font.Size = 11;
            objTable.Cell(2, 1).Range.Text = NguoiLapPhieu;
            objTable.Cell(2, 2).Range.Text = LanhDao;
            objTable.Cell(2, 3).Range.Text = TruongPhong;
            objTable.Cell(2, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(2, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(2, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(2, 1).Range.ParagraphFormat.SpaceAfter = 20;
            objTable.Cell(2, 2).Range.ParagraphFormat.SpaceAfter = 20;
            objTable.Cell(2, 3).Range.ParagraphFormat.SpaceAfter = 20;
            objTable.Rows[2].Range.Font.Bold = 1;
            objTable.Rows[2].Range.Font.Italic = 1;


            try
            {
                objTable.Borders.Shadow = false;
            }
            catch
            {
            }
        }
        /// <summary>
        /// Tạo mẫu chữ kỹ với thời gian, địa điểm
        /// </summary>
        /// <param name="textLeft">Nội dung cột trái</param>
        /// <param name="textRight">Nội dung cột phải</param>
        private void InsertSignatureFormAndLocation(string textLeft, string textRight, string location)
        {
            object missing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";
            Microsoft.Office.Interop.Word.Table objTable;
            Microsoft.Office.Interop.Word.Range wrdRng = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

            objTable = wordDoc.Tables.Add(wrdRng, 2, 2, ref missing, ref missing);
            objTable.Range.ParagraphFormat.SpaceAfter = 7;


            objTable.Rows[1].Range.Font.Bold = 0;
            objTable.Rows[1].Range.Font.Italic = 1;
            objTable.Rows[1].Range.Font.Size = 11;
            objTable.Cell(1, 2).Range.Text = location + ", ngày " + DateTime.Now.Day.ToString() + ", tháng " + DateTime.Now.Month + ", năm " + DateTime.Now.Year;
            objTable.Cell(1, 2).Range.Paragraphs.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            objTable.Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            objTable.Cell(1, 1).Merge(objTable.Cell(1, 2));
            objTable.Rows[2].Range.Font.Bold = 1;
            objTable.Rows[2].Range.Font.Size = 11;
            objTable.Cell(2, 1).Range.Text = textLeft;
            objTable.Cell(2, 2).Range.Text = textRight;
            objTable.Cell(2, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(2, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Columns[1].SetWidth(200, Word.WdRulerStyle.wdAdjustNone);
            objTable.Columns[1].SetWidth(350, Word.WdRulerStyle.wdAdjustNone);

            try
            {
                objTable.Borders.Shadow = false;
            }
            catch
            {
            }
        }

        private void InsertHeaderForm(string timeInfo)
        {
            object missing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";
            Microsoft.Office.Interop.Word.Table objTable;
            Microsoft.Office.Interop.Word.Range wrdRng = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

            objTable = wordDoc.Tables.Add(wrdRng, 2, 2, ref missing, ref missing);
            objTable.Range.ParagraphFormat.SpaceAfter = 7;

            objTable.Rows[1].Range.Font.Bold = 1;
            objTable.Rows[1].Range.Font.Size = 11;
            objTable.Cell(1, 1).Range.Text = "BỆNH VIỆN BẠCH MAI";
            objTable.Cell(1, 2).Range.Text = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM";
            objTable.Cell(1, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(2, 1).Range.Text = "VĂN PHÒNG TRUNG TÂM";
            objTable.Cell(2, 2).Range.Text = "Độc lập - Tự do - Hạnh phúc";
            objTable.Cell(2, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(2, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Rows[2].Range.Font.Bold = 1;
            objTable.Cell(3, 2).Range.Text = timeInfo;
            objTable.Cell(3, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            objTable.Rows[2].Range.Font.Italic = 1;
            objTable.Rows[2].Range.Font.Size = 11;

            try
            {
                objTable.Borders.Shadow = false;
            }
            catch
            {
            }
        }

        /// <summary>
        /// Tạo form mẫu cộng hòa, trung tâm cho báo cáo Công văn - hành chính
        /// </summary>
        private void InsertHeaderForm_CongVan()
        {
            object missing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";
            Microsoft.Office.Interop.Word.Table objTable;
            Microsoft.Office.Interop.Word.Range wrdRng = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

            objTable = wordDoc.Tables.Add(wrdRng, 2, 2, ref missing, ref missing);
            objTable.Range.ParagraphFormat.SpaceAfter = 7;

            objTable.Rows[1].Range.Font.Bold = 1;
            objTable.Rows[1].Range.Font.Size = 11;
            objTable.Cell(1, 1).Range.Text = "BỆNH VIỆN BẠCH MAI";
            objTable.Cell(1, 2).Range.Text = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM";
            objTable.Cell(1, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(2, 1).Range.Text = "VĂN PHÒNG TRUNG TÂM";
            objTable.Cell(2, 2).Range.Text = "Độc lập - Tự do - Hạnh phúc";
            objTable.Cell(2, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(2, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Rows[2].Range.Font.Bold = 1;
            objTable.Rows[2].Range.Font.Italic = 1;
            objTable.Rows[2].Range.Font.Size = 11;
            objTable.Columns[1].SetWidth(250, Word.WdRulerStyle.wdAdjustNone);
            objTable.Columns[1].SetWidth(450, Word.WdRulerStyle.wdAdjustNone);

            try
            {
                objTable.Borders.Shadow = false;
            }
            catch
            {
            }
        }

        private void InsertHeaderForm_VanPhongPhamTheoTo(string TenNhom, string thang)
        {
            object missing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";
            Microsoft.Office.Interop.Word.Table objTable;
            Microsoft.Office.Interop.Word.Range wrdRng = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

            objTable = wordDoc.Tables.Add(wrdRng, 3, 2, ref missing, ref missing);
            objTable.Range.ParagraphFormat.SpaceAfter = 7;

            objTable.Cell(1, 1).Range.Text = "TRUNG TÂM ĐÀO TẠO & CHỈ ĐẠO TUYẾN";
            objTable.Cell(1, 1).Range.Font.Bold = 0;
            objTable.Cell(1, 1).Range.Font.Size = 12;
            objTable.Cell(1, 2).Range.Text = "PHIẾU DỰ TRÙ VĂN PHÒNG PHẨM";
            objTable.Cell(1, 2).Range.Font.Size = 18;
            objTable.Cell(1, 2).Range.Font.Bold = 1;
            objTable.Cell(1, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(2, 1).Range.Text = string.Format("NHÓM: {0}", TenNhom);
            objTable.Cell(2, 1).Range.Font.Bold = 0;
            objTable.Cell(2, 1).Range.Font.Size = 12;
            objTable.Cell(2, 2).Range.Text = thang;
            objTable.Cell(2, 2).Range.Font.Size = 18;
            objTable.Cell(2, 2).Range.Font.Bold = 1;
            objTable.Cell(2, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(2, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(3, 1).Range.Text = "---------***---------";
            objTable.Cell(3, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Columns[1].SetWidth(250, Word.WdRulerStyle.wdAdjustNone);
            objTable.Columns[1].SetWidth(450, Word.WdRulerStyle.wdAdjustNone);

            try
            {
                objTable.Borders.Shadow = false;
            }
            catch
            {
            }
        }

        private void InsertHeaderForm_VanPhongPham(string thang)
        {
            object missing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";
            Microsoft.Office.Interop.Word.Table objTable;
            Microsoft.Office.Interop.Word.Range wrdRng = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

            objTable = wordDoc.Tables.Add(wrdRng, 3, 2, ref missing, ref missing);
            objTable.Range.ParagraphFormat.SpaceAfter = 7;

            objTable.Cell(1, 1).Range.Text = "BỆNH VIỆN BẠCH MAI";
            objTable.Cell(1, 1).Range.Font.Bold = 0;
            objTable.Cell(1, 1).Range.Font.Size = 12;
            objTable.Cell(1, 2).Range.Text = "PHIẾU DỰ TRÙ VĂN PHÒNG PHẨM";
            objTable.Cell(1, 2).Range.Font.Size = 18;
            objTable.Cell(1, 2).Range.Font.Bold = 1;
            objTable.Cell(1, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(2, 1).Range.Text = "TRUNG TÂM ĐÀO TẠO & CHỈ ĐẠO TUYẾN";
            objTable.Cell(2, 1).Range.Font.Bold = 0;
            objTable.Cell(2, 1).Range.Font.Size = 11;
            objTable.Cell(2, 2).Range.Text = thang;
            objTable.Cell(2, 2).Range.Font.Size = 18;
            objTable.Cell(2, 2).Range.Font.Bold = 1;
            objTable.Cell(2, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(2, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(3, 1).Range.Text = "---------***---------";
            objTable.Cell(3, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Columns[1].SetWidth(250, Word.WdRulerStyle.wdAdjustNone);
            objTable.Columns[1].SetWidth(450, Word.WdRulerStyle.wdAdjustNone);

            try
            {
                objTable.Borders.Shadow = false;
            }
            catch
            {
            }
        }

        private void InsertHeaderForm_ThietBiLamSang(string tieude, string thongtin)
        {
            object missing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";
            Microsoft.Office.Interop.Word.Table objTable;
            Microsoft.Office.Interop.Word.Range wrdRng = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

            objTable = wordDoc.Tables.Add(wrdRng, 3, 2, ref missing, ref missing);
            objTable.Range.ParagraphFormat.SpaceAfter = 7;

            objTable.Cell(1, 1).Range.Text = "TRUNG TÂM ĐÀO TẠO & CHỈ ĐẠO TUYẾN";
            objTable.Cell(1, 1).Range.Font.Bold = 0;
            objTable.Cell(1, 1).Range.Font.Size = 12;
            objTable.Cell(1, 2).Range.Text = tieude;
            objTable.Cell(1, 2).Range.Font.Size = 18;
            objTable.Cell(1, 2).Range.Font.Bold = 1;
            objTable.Cell(1, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(2, 1).Range.Text = "BỆNH VIỆN BẠCH MAI";
            objTable.Cell(2, 1).Range.Font.Bold = 0;
            objTable.Cell(2, 1).Range.Font.Size = 11;
            objTable.Cell(2, 2).Range.Text = thongtin;
            objTable.Cell(2, 2).Range.Font.Size = 14;
            objTable.Cell(2, 2).Range.Font.Bold = 1;
            objTable.Cell(2, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Cell(2, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objTable.Columns[1].SetWidth(250, Word.WdRulerStyle.wdAdjustNone);
            objTable.Columns[1].SetWidth(450, Word.WdRulerStyle.wdAdjustNone);

            try
            {
                objTable.Borders.Shadow = false;
            }
            catch
            {
            }
        }
        /// <summary>
        /// Tạo danh sách dữ liệu với các kiểu numberic và bullet
        /// </summary>
        /// <param name="list">danh sách dữ liệu</param>
        /// <param name="appliedListFormat">true: numeric, false: bullet</param>
        private void InsertNumbericList(string title, string[] list, bool appliedListFormat)
        {
            object missing = System.Reflection.Missing.Value;
            Word.Paragraph para = wordDoc.Content.Paragraphs.Add(ref missing);
            para.Range.Text = title;
            para.Range.Font.Bold = 1;
            para.Range.Font.Name = "Times New Roman";
            para.Range.Font.Size = 13;
            para.Range.ParagraphFormat.SpaceAfter = 5;
            para.Range.InsertParagraphAfter();

            Word.Paragraph paragraph = wordDoc.Content.Paragraphs.Add();
            Word.Range rng = paragraph.Range;
            rng.InsertAfter("\n");
            object start = rng.End;
            object end = rng.End;
            rng = wordDoc.Range(ref start, ref end);

            paragraph.Range.Font.Name = "Times New Roman";
            paragraph.Range.Font.Bold = 0;
            paragraph.Range.Font.Size = 12;


            if (!appliedListFormat)
            {
                paragraph.Range.ListFormat.ApplyBulletDefault(Word.WdDefaultListBehavior.wdWord10ListBehavior);
                appliedListFormat = true;
            }
            else
            {
                paragraph.Range.ListFormat.ApplyNumberDefault(Word.WdDefaultListBehavior.wdWord10ListBehavior);
                appliedListFormat = false;
            }

            for (int i = 0; i < list.Length; i++)
            {
                string bulletItem = list[i];
                if (i < list.Length - 1)
                    bulletItem = bulletItem + "\n";
                paragraph.Range.InsertBefore(bulletItem);
            }
        }

        private void InsertNumbericListWithOutTitle(string[] list, bool appliedListFormat)
        {
            object missing = System.Reflection.Missing.Value;
            Word.Paragraph paragraph = wordDoc.Content.Paragraphs.Add(missing);
            Word.Range rng = paragraph.Range;
            rng.InsertAfter("\n");
            object start = rng.End;
            object end = rng.End;
            rng = wordDoc.Range(ref start, ref end);

            paragraph.Range.Font.Name = "Times New Roman";
            paragraph.Range.Font.Bold = 0;
            paragraph.Range.Font.Size = 12;


            if (!appliedListFormat)
            {
                paragraph.Range.ListFormat.ApplyBulletDefault(Word.WdDefaultListBehavior.wdWord10ListBehavior);
                appliedListFormat = true;
            }
            else
            {
                paragraph.Range.ListFormat.ApplyNumberDefault(Word.WdDefaultListBehavior.wdWord10ListBehavior);
                appliedListFormat = false;
            }

            for (int i = 0; i < list.Length; i++)
            {
                string bulletItem = list[i];
                if (i < list.Length - 1)
                    bulletItem = bulletItem + "\n";
                paragraph.Range.InsertBefore(bulletItem);
            }
        }

        private void InsertMultiNumericList(string title, string[] rootList, string[] subList, bool appliedListFormat)
        {
            object missing = System.Reflection.Missing.Value;
            bool indented = false;
            Word.Paragraph para = wordDoc.Content.Paragraphs.Add(ref missing);
            para.Range.Text = title;
            para.Range.Font.Bold = 1;
            para.Range.Font.Name = "Times New Roman";
            para.Range.Font.Size = 13;
            para.Range.ParagraphFormat.SpaceAfter = 5;
            para.Range.InsertParagraphAfter();

            Word.Paragraph paragraph = wordDoc.Content.Paragraphs.Add();
            Word.Range rng = paragraph.Range;
            rng.InsertAfter("\n");
            object start = rng.End;
            object end = rng.End;
            rng = wordDoc.Range(ref start, ref end);

            paragraph.Range.Font.Name = "Times New Roman";
            paragraph.Range.Font.Bold = 0;
            paragraph.Range.Font.Size = 12;


            /*if (!appliedListFormat)
            {
                paragraph.Range.ListFormat.ApplyBulletDefault(Word.WdDefaultListBehavior.wdWord10ListBehavior);
                appliedListFormat = true;
            }
            else
            {
                paragraph.Range.ListFormat.ApplyNumberDefault(Word.WdDefaultListBehavior.wdWord10ListBehavior);
                appliedListFormat = false;
            }*/

            for (int i = 0; i < rootList.Length; i++)
            {
                paragraph.Range.ListFormat.ApplyNumberDefault(Word.WdDefaultListBehavior.wdWord10ListBehavior);
                string bulletItem = rootList[i];
                if (i < rootList.Length - 1)
                    bulletItem = bulletItem + "\n";

                paragraph.Outdent();
                //paragraph.Range.InsertParagraphAfter();
                paragraph.Range.InsertBefore(bulletItem);

                for (int j = 0; j < subList.Length; j++)
                {
                    paragraph.Range.ListFormat.ApplyBulletDefault(Word.WdDefaultListBehavior.wdWord10ListBehavior);
                    string subItem = subList[j];
                    if (j < subList.Length - 1)
                        subItem = subItem + "\n";

                    if (!indented)
                    {
                        paragraph.Indent();
                        indented = true;
                    }
                    paragraph.Indent();
                    paragraph.Range.InsertBefore(subItem);
                }
                indented = false;
            }
        }


        /// <summary>
        /// Phụ lục 1 - Danh sách Cán bộ nhận chuyển giao kỹ thuật - 1816
        /// </summary>
        /// <param name="filename">Đường dẫn đầy đủ tệp tài liệu</param>
        /// <returns></returns>
        public string BaoCaoCanBoChuyenGiaoKyThuat(object filename, BC_CanBo_NhanCGKT item)
        {
            try
            {
                object missing = System.Reflection.Missing.Value;

                CreateNewDocument();
                // xoay ngang page
                wordDoc.Content.PageSetup.TogglePortrait();
                wordDoc.Content.PageSetup.TopMargin = 40F;
                wordDoc.Content.PageSetup.BottomMargin = 40F;
                wordDoc.Content.PageSetup.LeftMargin = 20F;
                wordDoc.Content.PageSetup.RightMargin = 20F;

                //Add paragraph - Bo y te
                InsertParagraph("Bộ y tế", "Normal", "Times New Roman", 12, "left", true, 0);

                // Add paragraph - Benh vien bach mai
                InsertParagraph("bệnh viện bạch mai", "Bold", "Times New Roman", 13, "LEFT", true, 0);

                //Add paragraph - DANH SÁCH CÁN BỘ NHẬN CHUYỂN GIAO CÔNG NGHỆ KỸ THUẬT
                InsertParagraph("danh sách cán bộ nhận chuyển giao công nghệ kỹ thuật", "Bold", "Times New Roman", 14, "center", true, 0);

                // Add paragraph - Theo hop dong so
                InsertParagraph("Theo hợp đồng số: " + item.SoHopDong, "Bold", "Times New Roman", 13, "center", false, 0);

                // Add paragraph - Tai benh vien
                InsertParagraph("Tại bệnh viện: " + item.BenhVien, "Bold", "Times New Roman", 14, "left", false, 0);

                // tạo bảng dữ liệu
                InsertTable(item.DanhSachCanBoCGKT);

                InsertParagraph(" ", "normal", "Times New Roman", 11, "left", false, 0);
                // tạo chữ ký
                InsertSignatureForm(item.ChuKy_CanBo, item.ChyKy_BenhVien);

                //Save the document
                SaveAs(filename);

                return "Tạo báo cáo thành công";
            }
            catch (Exception e)
            {
                return "Thao tác lỗi tại: " + e.ToString();
            }
        }

        /// <summary>
        /// Báo cáo kết quả đào tạo - hội chuẩn trực tuyến
        /// </summary>
        /// <param name="filename">tệp tài liệu</param>
        /// <param name="ngayTienHanh">Ngày tiến hành</param>
        /// <param name="chuTri">Người chủ trì</param>
        /// <param name="thuKy">Thư ký</param>
        /// <param name="congtacChuanbi"></param>
        /// <param name="daotao"></param>
        /// <returns></returns>
        public string BaoCaoKetQuaDaoTao_HoiChuanTrucTuyen(object filename, BC_KQDT_HoiChuanTrucTuyen item)
        {
            try
            {
                object missing = System.Reflection.Missing.Value;
                object oEndOfDoc = "\\endofdoc";
                // tạo tệp tài liệu mới
                CreateNewDocument();
                // tạo header
                InsertHeader("trung tâm đào tạo và chỉ đạo tuyến bạch mai", false, false, "LEFT", 12);

                // Tiêu đề
                InsertParagraph("báo cáo kết quả đào tạo - hội chuẩn trực tuyến", "Bold", "Times New Roman", 14, "center", true, 10);

                // Tạo bảng chứa các nội dung
                // 1: Ngày tiến hành
                // 2: Chủ trì
                // 3: Thư ký
                Word.Table infoTable;
                Word.Range wrdRng = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

                infoTable = wordDoc.Tables.Add(wrdRng, 3, 2, ref missing, ref missing);
                infoTable.Range.ParagraphFormat.SpaceAfter = 4;
                infoTable.Range.Font.Name = "Times New Roman";
                infoTable.Range.Font.Size = 12;

                infoTable.Cell(1, 1).Range.Text = "Ngày tiến hành: ";
                infoTable.Cell(1, 1).Range.Font.Bold = 1;
                infoTable.Cell(1, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                infoTable.Cell(1, 2).Range.Text = item.NgayTienHanh.ToString("dd/MM/yyyy");
                infoTable.Cell(1, 2).Range.Font.Bold = 0;
                infoTable.Cell(1, 2).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

                infoTable.Cell(2, 1).Range.Text = "Chủ trì: ";
                infoTable.Cell(2, 1).Range.Font.Bold = 1;
                infoTable.Cell(2, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                infoTable.Cell(2, 2).Range.Text = item.NguoiChuTri;
                infoTable.Cell(2, 2).Range.Font.Bold = 0;
                infoTable.Cell(2, 2).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

                infoTable.Cell(3, 1).Range.Text = "Thư ký: ";
                infoTable.Cell(3, 1).Range.Font.Bold = 1;
                infoTable.Cell(3, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                infoTable.Cell(3, 2).Range.Text = item.ThuKy;
                infoTable.Cell(3, 2).Range.Font.Bold = 0;
                infoTable.Cell(3, 2).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

                infoTable.Columns[1].SetWidth(110, Word.WdRulerStyle.wdAdjustNone);
                infoTable.Columns[2].SetWidth(400, Word.WdRulerStyle.wdAdjustSameWidth);

                InsertParagraph("Số liệu thống kê", "Bold", "Times New Roman", 12, "left", false, 0);

                Word.Table dataTable;
                Word.Range wrdRng1 = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                dataTable = wordDoc.Tables.Add(wrdRng1, item.SoLieuThongKe.Count, 4, ref missing, ref missing);
                dataTable.Range.ParagraphFormat.SpaceAfter = 4;
                dataTable.Range.Font.Name = "Times New Roman";
                dataTable.Range.Font.Size = 12;

                dataTable.Cell(1, 1).Range.Text = "TT";
                dataTable.Cell(1, 1).Range.Font.Bold = 1;
                dataTable.Cell(1, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                dataTable.Cell(1, 2).Range.Text = "BV Tham gia";
                dataTable.Cell(1, 2).Range.Font.Bold = 1;
                dataTable.Cell(1, 2).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                dataTable.Cell(1, 3).Range.Text = "Báo cáo BA";
                dataTable.Cell(1, 3).Range.Font.Bold = 1;
                dataTable.Cell(1, 3).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                dataTable.Cell(1, 4).Range.Text = "Số người tham dự";
                dataTable.Cell(1, 4).Range.Font.Bold = 1;
                dataTable.Cell(1, 4).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                dataTable.Columns[1].SetWidth(30, Word.WdRulerStyle.wdAdjustNone);
                dataTable.Columns[2].SetWidth(220, Word.WdRulerStyle.wdAdjustNone);
                dataTable.Columns[3].SetWidth(180, Word.WdRulerStyle.wdAdjustNone);
                dataTable.Columns[4].SetWidth(70, Word.WdRulerStyle.wdAdjustNone);

                foreach (Word.Row row in dataTable.Rows)
                {
                    foreach (Word.Cell cell in row.Cells)
                    {
                        //Data row
                        if (cell.RowIndex > 1)
                        {
                            dataTable.Cell(cell.RowIndex, 1).Range.Text = item.SoLieuThongKe[cell.RowIndex].TT.ToString();
                            dataTable.Cell(cell.RowIndex, 2).Range.Text = item.SoLieuThongKe[cell.RowIndex].BenhVienThamGia;
                            dataTable.Cell(cell.RowIndex, 3).Range.Text = item.SoLieuThongKe[cell.RowIndex].BaoCaoBA;
                            dataTable.Cell(cell.RowIndex, 4).Range.Text = item.SoLieuThongKe[cell.RowIndex].SoNguoiThamDu.ToString();

                            cell.Range.Font.Bold = 0;
                            cell.Range.Font.Size = 12;
                            cell.Range.Font.Name = "Times New Roman";
                        }

                    }
                }

                // paragraph - I. Công tác chuẩn bị
                InsertNumbericList("I. Công tác chuẩn bị: ", item.CongTacChuanBi, true);

                // paragraph - II. Qúa trình đào tạo - Hội chuẩn trực tuyến
                InsertNumbericList("II. Quá trình đào tạo - Hội chuẩn trực tuyến: ", item.QuaTrinhDaoTao, true);

                // paragraph - III. Nhận xét và đề xuất
                InsertParagraph("III. Nhận xét và đề xuất", "Bold", "Times New Roman", 13, "left", false, 5);
                InsertParagraph(item.NhanXetVaDeXuat, "normal", "Times New Roman", 13, "left", false, 5);
                InsertParagraph(item.ThoiGianKetThuc, "normal", "Times New Roman", 12, "left", false, 5);

                InsertSignatureFormAndLocation("PHÒNG CHỈ ĐẠO TUYẾN", "NGƯỜI LÀM BÁO CÁO", item.DiaDiem);
                try
                {
                    infoTable.Borders.Shadow = false;
                    dataTable.Borders.Shadow = true;
                }
                catch
                {
                }
                //Save the document
                SaveAs(filename);

                return "Tạo báo cáo thành công";
            }
            catch (Exception e)
            {
                return "Error:" + e.Message.ToString();
            }
        }

        public string BaoCaoKetQua_HoatDongChuyenGiaoKyThuat(object filename, BC_KQ_HoatDongChuyenGiaoKyThuat item)
        {
            try
            {
                object missing = System.Reflection.Missing.Value;
                object oEndOfDoc = "\\endofdoc";

                // tạo tệp tài liệu mới
                CreateNewDocument();

                // tiêu đề
                InsertParagraph("báo cáo kết quả", "bold", "Times New Roman", 14, "center", true, 5);
                InsertParagraph("hoạt động chuyển giao kỹ thuật", "bold", "Times New Roman", 14, "center", true, 0);

                // tên kỹ thuật chuyển giao
                InsertParagraph("Tên kỹ thuật chuyển: .....................................................................", "bold", "Times New Roman", 12, "left", false, 10);

                // địa điểm tổ chức
                InsertParagraph("1. Địa điểm tổ chức: .....................................................................", "bold", "Times New Roman", 12, "left", false, 0);

                // thời gian
                CreateParagraphWithMultiFontStyle("2. Thời gian:", " Từ ngày: 5/6/2014 đến ngày: 6/6/2014", "Times New Roman", 12, "left", 0);
                //Save the document
                filename = @"D:\bckq_hoatdongchuyengiaokythuat.docx";
                SaveAs(filename);

                return "Tạo báo cáo thành công";
            }
            catch (Exception e)
            {
                return "Error: " + e.ToString();
            }
        }

        /// <summary>
        /// Hành chính - Báo Cáo: Phiếu mượn thiết bị
        /// </summary>
        /// <param name="filename">tên tệp tài liệu</param>
        /// <param name="item">Đối tượng báo cáo</param>
        /// <returns></returns>
        public string HanhChinh_BaoCao_PhieuMuonThietBi(object filename, HC_BaoCao_PhieuMuonThietBi item)
        {
            try
            {
                object missing = System.Reflection.Missing.Value;
                object oEndOfDoc = "\\endofdoc";

                // tạo tệp tài liệu mới
                CreateNewDocument();

                // khung mẫu header
                InsertHeaderForm(item.ThongTinThoiGian);
                // phiếu mượn thiết bị
                InsertParagraph("phiếu mượn thiết bị", "Bold", "Times New Roman", 16, "center", true, 0);
                //Đại diện bên giao: TDC
                InsertParagraph("I. đại diện bên giao: tdc", "Bold", "Times New Roman", 13, "left", true, 5);
                // tạo bảng formatting danh sách đại diện bên giao
                Word.Table tableGiao;
                Word.Range wrdRng = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

                tableGiao = wordDoc.Tables.Add(wrdRng, item.DaiDienBenGiao.Count, 2, ref missing, ref missing);
                tableGiao.Range.ParagraphFormat.SpaceAfter = 4;
                tableGiao.Range.Font.Name = "Times New Roman";
                tableGiao.Range.Font.Size = 12;
                tableGiao.Columns[1].SetWidth(225, Word.WdRulerStyle.wdAdjustNone);
                tableGiao.Columns[2].SetWidth(225, Word.WdRulerStyle.wdAdjustNone);

                foreach (Word.Row row in tableGiao.Rows)
                {
                    foreach (Word.Cell cell in row.Cells)
                    {
                        //Data row
                        tableGiao.Cell(cell.RowIndex, 1).Range.Text = string.Format("{0}. Ông (Bà): {1}", item.DaiDienBenGiao[cell.RowIndex].STT, item.DaiDienBenGiao[cell.RowIndex].TenCanBo);
                        tableGiao.Cell(cell.RowIndex, 2).Range.Text = string.Format("Chức vụ: {0}", item.DaiDienBenGiao[cell.RowIndex].ChucVu);
                        cell.Range.Font.Bold = 0;
                        cell.Range.Font.Size = 12;
                        cell.Range.Font.Name = "Times New Roman";

                    }
                }

                // Đại diện bên mượn
                InsertParagraph(string.Format("II. đại diện bên mượn: {0}", item.BenMuon), "Bold", "Times New Roman", 13, "left", true, 5);
                // tạo bảng formating bên nhận
                Word.Table tableNhan;
                Word.Range wrdRngNhan = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

                tableNhan = wordDoc.Tables.Add(wrdRngNhan, item.DaiDienBenNhan.Count, 2, ref missing, ref missing);
                tableNhan.Range.ParagraphFormat.SpaceAfter = 4;
                tableNhan.Range.Font.Name = "Times New Roman";
                tableNhan.Range.Font.Size = 12;
                tableNhan.Columns[1].SetWidth(225, Word.WdRulerStyle.wdAdjustNone);
                tableNhan.Columns[2].SetWidth(225, Word.WdRulerStyle.wdAdjustNone);

                foreach (Word.Row row in tableNhan.Rows)
                {
                    foreach (Word.Cell cell in row.Cells)
                    {
                        //Data row
                        tableNhan.Cell(cell.RowIndex, 1).Range.Text = string.Format("{0}. Ông (Bà): {1}", item.DaiDienBenNhan[cell.RowIndex].STT, item.DaiDienBenNhan[cell.RowIndex].TenCanBo);
                        tableNhan.Cell(cell.RowIndex, 2).Range.Text = string.Format("Chức vụ: {0}", item.DaiDienBenNhan[cell.RowIndex].ChucVu);
                        cell.Range.Font.Bold = 0;
                        cell.Range.Font.Size = 12;
                        cell.Range.Font.Name = "Times New Roman";

                    }
                }

                // dia diem muon
                InsertParagraph(string.Format("Địa điểm mượn: {0}", item.DiaDiemMuon), "Normal", "Times New Roman", 12, "left", false, 5);
                // thoi gian muon
                InsertParagraph(string.Format("Thời gian mượn: {0}", item.ThoiGianMuon), "Normal", "Times New Roman", 12, "left", false, 5);
                // iii. noi dung
                InsertParagraph("III. nội dung:", "Bold", "Times New Roman", 13, "left", true, 5);
                // bảng mượn thiết bị
                Word.Table tableThietBi;
                Word.Range wrdRngTB = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

                tableThietBi = wordDoc.Tables.Add(wrdRngTB, item.DanhSachThietBiMuon.Count, 7, ref missing, ref missing);
                tableThietBi.Range.ParagraphFormat.SpaceAfter = 4;
                tableThietBi.Range.Font.Name = "Times New Roman";
                tableThietBi.Range.Font.Size = 12;

                tableThietBi.Cell(1, 1).Range.Text = "STT";
                tableThietBi.Cell(1, 2).Range.Text = "Tên Thiết bị";
                tableThietBi.Cell(1, 3).Range.Text = "Serial";
                tableThietBi.Cell(1, 4).Range.Text = "Xuất xứ";
                tableThietBi.Cell(1, 5).Range.Text = "Đơn vị";
                tableThietBi.Cell(1, 6).Range.Text = "Số lượng";
                tableThietBi.Cell(1, 7).Range.Text = "Ghi chú";
                tableThietBi.Rows[1].Range.Font.Bold = 1;
                tableThietBi.Rows[1].Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                tableThietBi.Columns[1].SetWidth(45, Word.WdRulerStyle.wdAdjustNone);
                tableThietBi.Columns[2].SetWidth(125, Word.WdRulerStyle.wdAdjustNone);
                tableThietBi.Columns[3].SetWidth(80, Word.WdRulerStyle.wdAdjustNone);
                tableThietBi.Columns[4].SetWidth(80, Word.WdRulerStyle.wdAdjustNone);
                tableThietBi.Columns[5].SetWidth(60, Word.WdRulerStyle.wdAdjustNone);
                tableThietBi.Columns[6].SetWidth(60, Word.WdRulerStyle.wdAdjustNone);
                tableThietBi.Columns[7].SetWidth(100, Word.WdRulerStyle.wdAdjustNone);

                foreach (Word.Row row in tableGiao.Rows)
                {
                    foreach (Word.Cell cell in row.Cells)
                    {
                        //Data row
                        if (cell.RowIndex > 1)
                        {
                            tableThietBi.Cell(cell.RowIndex, 1).Range.Text = item.DanhSachThietBiMuon[cell.RowIndex].STT.ToString();
                            tableThietBi.Cell(cell.RowIndex, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                            tableThietBi.Cell(cell.RowIndex, 2).Range.Text = item.DanhSachThietBiMuon[cell.RowIndex].TenThietBi;
                            tableThietBi.Cell(cell.RowIndex, 2).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableThietBi.Cell(cell.RowIndex, 3).Range.Text = item.DanhSachThietBiMuon[cell.RowIndex].Serial;
                            tableThietBi.Cell(cell.RowIndex, 3).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableThietBi.Cell(cell.RowIndex, 4).Range.Text = item.DanhSachThietBiMuon[cell.RowIndex].XuatXu;
                            tableThietBi.Cell(cell.RowIndex, 4).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableThietBi.Cell(cell.RowIndex, 5).Range.Text = item.DanhSachThietBiMuon[cell.RowIndex].DonVi;
                            tableThietBi.Cell(cell.RowIndex, 5).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableThietBi.Cell(cell.RowIndex, 6).Range.Text = item.DanhSachThietBiMuon[cell.RowIndex].SoLuong.ToString();
                            tableThietBi.Cell(cell.RowIndex, 6).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                            tableThietBi.Cell(cell.RowIndex, 7).Range.Text = item.DanhSachThietBiMuon[cell.RowIndex].GhiChu;
                            tableThietBi.Cell(cell.RowIndex, 7).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                            cell.Range.Font.Bold = 0;
                            cell.Range.Font.Size = 12;
                            cell.Range.Font.Name = "Times New Roman";
                        }
                    }
                    InsertParagraph("Kể từ khi mượn, bên nhận thiết bị có trách nhiệm giữ gìn, bảo quản thiết bị theo quy định. Có trách nhiệm bồi thường khi xảy ra mất mát hay hư hỏng. Hoàn trả thiết bị đúng thời gian.", "normal", "Times New Roman", 12, "left", false, 4);
                    InsertParagraph("Biên bản được lập thành 02 bản. Mỗi bên giữ 01 bản và có giá trị như nhau.", "normal", "Times New Roman", 12, "left", false, 4);
                    InsertSignatureForm_HanhChinh(item.CanBoBenGiao, item.CanBoBenNhan);

                    //Save the document
                    filename = @"D:\hanhchinh_bc_phieumuonthietbi.docx";
                    SaveAs(filename);
                }
                return "Tạo báo cáo thành công";
            }
            catch (Exception e) { return "Error: " + e.ToString(); }
        }

        /// <summary>
        /// Hành chính - Báo cáo: Công Văn Đến
        /// </summary>
        /// <param name="filename">tên tệp tài liệu</param>
        /// <param name="item">đối tượng báo cáo</param>
        /// <returns></returns>
        public string HanhChinh_BaoCao_CongVanDen(object filename, HC_BaoCao_CongVanDen item)
        {
            try
            {
                object missing = System.Reflection.Missing.Value;
                object oEndOfDoc = "\\endofdoc";
                //tạo tệp tài liệu mới
                CreateNewDocument();
                // xoay ngang page
                wordDoc.Content.PageSetup.TogglePortrait();
                wordDoc.Content.PageSetup.TopMargin = 40F;
                wordDoc.Content.PageSetup.BottomMargin = 40F;
                wordDoc.Content.PageSetup.LeftMargin = 20F;
                wordDoc.Content.PageSetup.RightMargin = 20F;
                InsertHeaderForm_CongVan();
                // tiêu đề - công văn đến
                InsertParagraph("báo cáo công văn đến tdc", "Bold", "Times New Roman", 18, "center", true, 10);
                InsertParagraph(item.ThoiGianNhanCongVan, "Italic", "Times New Roman", 12, "center", false, 0);
                Word.Table tableCongVanDen;
                Word.Range wrdRng = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

                tableCongVanDen = wordDoc.Tables.Add(wrdRng, item.DanhSachCongVanDen.Count, 7, ref missing, ref missing);
                tableCongVanDen.Range.ParagraphFormat.SpaceAfter = 4;
                tableCongVanDen.Range.Font.Name = "Times New Roman";
                tableCongVanDen.Range.Font.Size = 12;

                tableCongVanDen.Cell(1, 1).Range.Text = "STT";
                tableCongVanDen.Cell(1, 2).Range.Text = "Số công văn";
                tableCongVanDen.Cell(1, 3).Range.Text = "Ngày nhận";
                tableCongVanDen.Cell(1, 4).Range.Text = "Về việc";
                tableCongVanDen.Cell(1, 5).Range.Text = "Nơi gửi";
                tableCongVanDen.Cell(1, 6).Range.Text = "Vị trí lưu";
                tableCongVanDen.Rows[1].Range.Font.Bold = 1;
                tableCongVanDen.Rows[1].Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                tableCongVanDen.Columns[1].SetWidth(50, Word.WdRulerStyle.wdAdjustNone);
                tableCongVanDen.Columns[2].SetWidth(90, Word.WdRulerStyle.wdAdjustNone);
                tableCongVanDen.Columns[3].SetWidth(90, Word.WdRulerStyle.wdAdjustNone);
                tableCongVanDen.Columns[4].SetWidth(200, Word.WdRulerStyle.wdAdjustNone);
                tableCongVanDen.Columns[5].SetWidth(100, Word.WdRulerStyle.wdAdjustNone);
                tableCongVanDen.Columns[6].SetWidth(80, Word.WdRulerStyle.wdAdjustNone);

                foreach (Word.Row row in tableCongVanDen.Rows)
                {
                    foreach (Word.Cell cell in row.Cells)
                    {
                        //Data row
                        if (cell.RowIndex > 1)
                        {
                            tableCongVanDen.Cell(cell.RowIndex, 1).Range.Text = item.DanhSachCongVanDen[cell.RowIndex].STT.ToString();
                            tableCongVanDen.Cell(cell.RowIndex, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                            tableCongVanDen.Cell(cell.RowIndex, 2).Range.Text = item.DanhSachCongVanDen[cell.RowIndex].SoCongVan;
                            tableCongVanDen.Cell(cell.RowIndex, 2).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableCongVanDen.Cell(cell.RowIndex, 3).Range.Text = item.DanhSachCongVanDen[cell.RowIndex].NgayNhan.ToString("dd/MM/yyyy");
                            tableCongVanDen.Cell(cell.RowIndex, 3).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableCongVanDen.Cell(cell.RowIndex, 4).Range.Text = item.DanhSachCongVanDen[cell.RowIndex].VeViec;
                            tableCongVanDen.Cell(cell.RowIndex, 4).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableCongVanDen.Cell(cell.RowIndex, 5).Range.Text = item.DanhSachCongVanDen[cell.RowIndex].NoiGui;
                            tableCongVanDen.Cell(cell.RowIndex, 5).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableCongVanDen.Cell(cell.RowIndex, 6).Range.Text = item.DanhSachCongVanDen[cell.RowIndex].ViTriLuu;
                            tableCongVanDen.Cell(cell.RowIndex, 6).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                            cell.Range.Font.Bold = 0;
                            cell.Range.Font.Size = 12;
                            cell.Range.Font.Name = "Times New Roman";
                        }
                    }
                }
                InsertParagraph("", "", "Times New Roman", 12, "l", false, 0);
                InsertSignatureForm_CongVanDen(string.Format("Tổng số công văn đến là: {0}", item.DanhSachCongVanDen.Count), item.ThoiGianCongVanDen);
                filename = @"D:\hanhchinh_bc_congvanden.docx";
                SaveAs(filename);

                return "Tạo báo cáo thành công";
            }
            catch (Exception e)
            {
                return "Error: " + e.ToString();
            }
        }

        /// <summary>
        /// Hành chính - Báo cáo: Công Văn đi
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public string HanhChinh_BaoCao_CongVanDi(object filename, HC_BaoCao_CongVanDi item)
        {
            try
            {
                object missing = System.Reflection.Missing.Value;
                object oEndOfDoc = "\\endofdoc";
                //tạo tệp tài liệu mới
                CreateNewDocument();
                // xoay ngang page
                wordDoc.Content.PageSetup.TogglePortrait();
                wordDoc.Content.PageSetup.TopMargin = 40F;
                wordDoc.Content.PageSetup.BottomMargin = 40F;
                wordDoc.Content.PageSetup.LeftMargin = 20F;
                wordDoc.Content.PageSetup.RightMargin = 20F;
                InsertHeaderForm_CongVan();
                // tiêu đề - công văn đến
                InsertParagraph("báo cáo công văn đến tdc", "Bold", "Times New Roman", 18, "center", true, 10);
                InsertParagraph(item.ThoiGianNhanCongVan, "Italic", "Times New Roman", 12, "center", false, 0);
                Word.Table tableCongVanDi;
                Word.Range wrdRng = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

                tableCongVanDi = wordDoc.Tables.Add(wrdRng, item.DanhSachCongVanDi.Count, 7, ref missing, ref missing);
                tableCongVanDi.Range.ParagraphFormat.SpaceAfter = 4;
                tableCongVanDi.Range.Font.Name = "Times New Roman";
                tableCongVanDi.Range.Font.Size = 12;

                tableCongVanDi.Cell(1, 1).Range.Text = "STT";
                tableCongVanDi.Cell(1, 2).Range.Text = "Số công văn";
                tableCongVanDi.Cell(1, 3).Range.Text = "Ngày nhận";
                tableCongVanDi.Cell(1, 4).Range.Text = "Về việc";
                tableCongVanDi.Cell(1, 5).Range.Text = "Nơi gửi";
                tableCongVanDi.Cell(1, 6).Range.Text = "Vị trí lưu";
                tableCongVanDi.Rows[1].Range.Font.Bold = 1;
                tableCongVanDi.Rows[1].Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                tableCongVanDi.Columns[1].SetWidth(50, Word.WdRulerStyle.wdAdjustNone);
                tableCongVanDi.Columns[2].SetWidth(90, Word.WdRulerStyle.wdAdjustNone);
                tableCongVanDi.Columns[3].SetWidth(90, Word.WdRulerStyle.wdAdjustNone);
                tableCongVanDi.Columns[4].SetWidth(200, Word.WdRulerStyle.wdAdjustNone);
                tableCongVanDi.Columns[5].SetWidth(100, Word.WdRulerStyle.wdAdjustNone);
                tableCongVanDi.Columns[6].SetWidth(80, Word.WdRulerStyle.wdAdjustNone);

                foreach (Word.Row row in tableCongVanDi.Rows)
                {
                    foreach (Word.Cell cell in row.Cells)
                    {
                        //Data row
                        if (cell.RowIndex > 1)
                        {
                            tableCongVanDi.Cell(cell.RowIndex, 1).Range.Text = item.DanhSachCongVanDi[cell.RowIndex].STT.ToString();
                            tableCongVanDi.Cell(cell.RowIndex, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                            tableCongVanDi.Cell(cell.RowIndex, 2).Range.Text = item.DanhSachCongVanDi[cell.RowIndex].SoCongVan;
                            tableCongVanDi.Cell(cell.RowIndex, 2).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableCongVanDi.Cell(cell.RowIndex, 3).Range.Text = item.DanhSachCongVanDi[cell.RowIndex].NgayNhan.ToString("dd/MM/yyyy");
                            tableCongVanDi.Cell(cell.RowIndex, 3).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableCongVanDi.Cell(cell.RowIndex, 4).Range.Text = item.DanhSachCongVanDi[cell.RowIndex].VeViec;
                            tableCongVanDi.Cell(cell.RowIndex, 4).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableCongVanDi.Cell(cell.RowIndex, 5).Range.Text = item.DanhSachCongVanDi[cell.RowIndex].NoiGui;
                            tableCongVanDi.Cell(cell.RowIndex, 5).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableCongVanDi.Cell(cell.RowIndex, 6).Range.Text = item.DanhSachCongVanDi[cell.RowIndex].ViTriLuu;
                            tableCongVanDi.Cell(cell.RowIndex, 6).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                            cell.Range.Font.Bold = 0;
                            cell.Range.Font.Size = 12;
                            cell.Range.Font.Name = "Times New Roman";
                        }
                    }
                }
                InsertParagraph("", "", "Times New Roman", 12, "l", false, 0);
                InsertSignatureForm_CongVanDen(string.Format("Tổng số công văn đến là: {0}", item.DanhSachCongVanDi.Count), item.ThoiGianCongVanDi);
                filename = @"D:\hanhchinh_bc_congvandi.docx";
                SaveAs(filename);

                return "Tạo báo cáo thành công";
            }
            catch (Exception e)
            {
                return "Error: " + e.ToString();
            }
        }

        /// <summary>
        /// Hành chính - Báo cáo: Đăng ký Giảng Đường Phòng Học
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public string HanhChinh_BaoCao_DangKyGiangDuong_PhongHoc(object filename, HC_BaoCao_DKGiangDuongPhongHoc item)
        {
            try
            {
                object missing = System.Reflection.Missing.Value;
                object oEndOfDoc = "\\endofdoc";
                //tạo tệp tài liệu mới
                CreateNewDocument();
                // xoay ngang page
                wordDoc.Content.PageSetup.TogglePortrait();
                wordDoc.Content.PageSetup.TopMargin = 40F;
                wordDoc.Content.PageSetup.BottomMargin = 40F;
                wordDoc.Content.PageSetup.LeftMargin = 20F;
                wordDoc.Content.PageSetup.RightMargin = 20F;
                InsertHeaderForm_CongVan();
                // tiêu đề - công văn đến
                InsertParagraph("báo cáo", "Bold", "Times New Roman", 18, "center", true, 1);
                InsertParagraph("đăng ký giảng đường phòng học tại tdc", "Bold", "Times New Roman", 18, "center", true, 1);
                InsertParagraph(item.ThoiGianDangKy, "Italic", "Times New Roman", 12, "center", false, 0);
                Word.Table tableDangKy;
                Word.Range wrdRng = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

                tableDangKy = wordDoc.Tables.Add(wrdRng, item.DanhSachGDPH.Count, 7, ref missing, ref missing);
                tableDangKy.Range.ParagraphFormat.SpaceAfter = 4;
                tableDangKy.Range.Font.Name = "Times New Roman";
                tableDangKy.Range.Font.Size = 12;

                tableDangKy.Cell(1, 1).Range.Text = "STT";
                tableDangKy.Cell(1, 2).Range.Text = "Ngày đăng ký";
                tableDangKy.Cell(1, 3).Range.Text = "Nội dung";
                tableDangKy.Cell(1, 4).Range.Text = "GĐ/ PH";
                tableDangKy.Cell(1, 5).Range.Text = "Cán bộ đăng ký";
                tableDangKy.Cell(1, 6).Range.Text = "Chất lượng";
                tableDangKy.Cell(1, 7).Range.Text = "Ý kiến khác";
                tableDangKy.Rows[1].Range.Font.Bold = 1;
                tableDangKy.Rows[1].Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                tableDangKy.Columns[1].SetWidth(50, Word.WdRulerStyle.wdAdjustNone);
                tableDangKy.Columns[2].SetWidth(90, Word.WdRulerStyle.wdAdjustNone);
                tableDangKy.Columns[3].SetWidth(160, Word.WdRulerStyle.wdAdjustNone);
                tableDangKy.Columns[4].SetWidth(80, Word.WdRulerStyle.wdAdjustNone);
                tableDangKy.Columns[5].SetWidth(110, Word.WdRulerStyle.wdAdjustNone);
                tableDangKy.Columns[6].SetWidth(80, Word.WdRulerStyle.wdAdjustNone);
                tableDangKy.Columns[7].SetWidth(80, Word.WdRulerStyle.wdAdjustNone);

                foreach (Word.Row row in tableDangKy.Rows)
                {
                    foreach (Word.Cell cell in row.Cells)
                    {
                        //Data row
                        if (cell.RowIndex > 1)
                        {
                            tableDangKy.Cell(cell.RowIndex, 1).Range.Text = item.DanhSachGDPH[cell.RowIndex].STT.ToString();
                            tableDangKy.Cell(cell.RowIndex, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                            tableDangKy.Cell(cell.RowIndex, 2).Range.Text = item.DanhSachGDPH[cell.RowIndex].NgayDangKy.ToString("dd/MM/yyyy");
                            tableDangKy.Cell(cell.RowIndex, 2).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableDangKy.Cell(cell.RowIndex, 3).Range.Text = item.DanhSachGDPH[cell.RowIndex].NoiDung;
                            tableDangKy.Cell(cell.RowIndex, 3).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableDangKy.Cell(cell.RowIndex, 4).Range.Text = item.DanhSachGDPH[cell.RowIndex].GDPH;
                            tableDangKy.Cell(cell.RowIndex, 4).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableDangKy.Cell(cell.RowIndex, 5).Range.Text = item.DanhSachGDPH[cell.RowIndex].CanBoDangKy;
                            tableDangKy.Cell(cell.RowIndex, 5).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableDangKy.Cell(cell.RowIndex, 6).Range.Text = item.DanhSachGDPH[cell.RowIndex].ChatLuong;
                            tableDangKy.Cell(cell.RowIndex, 6).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                            tableDangKy.Cell(cell.RowIndex, 7).Range.Text = item.DanhSachGDPH[cell.RowIndex].YKienKhac;
                            tableDangKy.Cell(cell.RowIndex, 7).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                            cell.Range.Font.Bold = 0;
                            cell.Range.Font.Size = 12;
                            cell.Range.Font.Name = "Times New Roman";
                        }
                    }
                }
                InsertParagraph("", "", "Times New Roman", 12, "l", false, 0);
                InsertSignatureForm_DKGDPH(item.ThoiGianTaoBaoCao);
                //Save the document
                filename = @"D:\hanhchinh_bc_dkgiangduong_phonghoc.docx";
                SaveAs(filename);

                return "Tạo báo cáo thành công";
            }
            catch (Exception e) { return "Error: " + e.ToString(); }
        }

        public string HanhChinh_BaoCao_PhieuDuTruVanPhongPham_TheoTo(object filename, HC_BaoCao_DuTruVanPhongPham_TheoTo item)
        {
            try
            {
                object missing = System.Reflection.Missing.Value;
                object oEndOfDoc = "\\endofdoc";
                //tạo tệp tài liệu mới
                CreateNewDocument();
                // xoay ngang page
                wordDoc.Content.PageSetup.TogglePortrait();
                wordDoc.Content.PageSetup.TopMargin = 40F;
                wordDoc.Content.PageSetup.BottomMargin = 40F;
                wordDoc.Content.PageSetup.LeftMargin = 20F;
                wordDoc.Content.PageSetup.RightMargin = 20F;

                // thông tin header
                InsertHeaderForm_VanPhongPhamTheoTo(item.NhomPhong, item.ThangBaoCao);
                InsertParagraph("", "", "Times New Roman", 11, "l", false, 0);
                Word.Table tableVPP;
                Word.Range wrdRng = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

                tableVPP = wordDoc.Tables.Add(wrdRng, item.DanhSachVanPhongPham.Count, 5, ref missing, ref missing);
                tableVPP.Range.ParagraphFormat.SpaceAfter = 4;
                tableVPP.Range.Font.Name = "Times New Roman";
                tableVPP.Range.Font.Size = 12;

                tableVPP.Cell(1, 1).Range.Text = "STT";
                tableVPP.Cell(1, 2).Range.Text = "Vật tư sản phẩm";
                tableVPP.Cell(1, 3).Range.Text = "Đơn vị";
                tableVPP.Cell(1, 4).Range.Text = "Số lượng dự trù";
                tableVPP.Cell(1, 5).Range.Text = "Ghi chú";

                tableVPP.Rows[1].Range.Font.Bold = 1;
                tableVPP.Rows[1].Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                tableVPP.Columns[1].SetWidth(50, Word.WdRulerStyle.wdAdjustNone);
                tableVPP.Columns[2].SetWidth(200, Word.WdRulerStyle.wdAdjustNone);
                tableVPP.Columns[3].SetWidth(60, Word.WdRulerStyle.wdAdjustNone);
                tableVPP.Columns[4].SetWidth(80, Word.WdRulerStyle.wdAdjustNone);
                tableVPP.Columns[5].SetWidth(110, Word.WdRulerStyle.wdAdjustNone);

                foreach (Word.Row row in tableVPP.Rows)
                {
                    foreach (Word.Cell cell in row.Cells)
                    {
                        //Data row
                        if (cell.RowIndex > 1)
                        {
                            tableVPP.Cell(cell.RowIndex, 1).Range.Text = item.DanhSachVanPhongPham[cell.RowIndex].STT.ToString();
                            tableVPP.Cell(cell.RowIndex, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                            tableVPP.Cell(cell.RowIndex, 2).Range.Text = item.DanhSachVanPhongPham[cell.RowIndex].VatTuSanPham;
                            tableVPP.Cell(cell.RowIndex, 2).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableVPP.Cell(cell.RowIndex, 3).Range.Text = item.DanhSachVanPhongPham[cell.RowIndex].DonVi;
                            tableVPP.Cell(cell.RowIndex, 3).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableVPP.Cell(cell.RowIndex, 4).Range.Text = item.DanhSachVanPhongPham[cell.RowIndex].SoLuongDuTru.ToString();
                            tableVPP.Cell(cell.RowIndex, 4).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableVPP.Cell(cell.RowIndex, 5).Range.Text = item.DanhSachVanPhongPham[cell.RowIndex].GhiChu;
                            tableVPP.Cell(cell.RowIndex, 5).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            cell.Range.Font.Bold = 0;
                            cell.Range.Font.Size = 12;
                            cell.Range.Font.Name = "Times New Roman";
                        }
                    }
                }
                InsertParagraph(item.ThoiGianTaoBaoCao, "Italic", "Times New Roman", 12, "right", false, 5);
                InsertSignatureForm_VanPhongPham_TheoTo(item.ChuKy_LanhDao, item.Chuky_NhomTruong, item.Chuky_NguoiNhan, item.Chuky_nguoiDuTru);
                //Save the document
                filename = @"D:\hanhchinh_bc_phieudutruvanphongpham_theoto.docx";
                SaveAs(filename);
                return "Tạo báo cáo thành công";
            }
            catch (Exception e) { return "Error: " + e.ToString(); }
        }
        /*
        public string HanhChinh_BaoCao_PhieuDuTruVanPhongPham(object filename, HC_BaoCao_DuTruVanPhongPham item)
        {
            try
            {
                object missing = System.Reflection.Missing.Value;
                object oEndOfDoc = "\\endofdoc";
                //tạo tệp tài liệu mới
                CreateNewDocument();
                // xoay ngang page
                wordDoc.Content.PageSetup.TogglePortrait();
                wordDoc.Content.PageSetup.TopMargin = 40F;
                wordDoc.Content.PageSetup.BottomMargin = 40F;
                wordDoc.Content.PageSetup.LeftMargin = 20F;
                wordDoc.Content.PageSetup.RightMargin = 20F;

                // thông tin header
                InsertHeaderForm_VanPhongPham(item.ThangBaoCao);
                InsertParagraph("", "", "Times New Roman", 11, "l", false, 0);
                Word.Table tableVPP;
                Word.Range wrdRng = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

                tableVPP = wordDoc.Tables.Add(wrdRng, item.DanhSachVanPhongPham.Count, 5, ref missing, ref missing);
                tableVPP.Range.ParagraphFormat.SpaceAfter = 4;
                tableVPP.Range.Font.Name = "Times New Roman";
                tableVPP.Range.Font.Size = 12;

                tableVPP.Cell(1, 1).Range.Text = "STT";
                tableVPP.Cell(1, 2).Range.Text = "Danh mục hàng hóa";
                tableVPP.Cell(1, 3).Range.Text = "Đơn vị";
                tableVPP.Cell(1, 4).Range.Text = "Số lượng";
                tableVPP.Cell(1, 5).Range.Text = "Ghi chú";

                tableVPP.Rows[1].Range.Font.Bold = 1;
                tableVPP.Rows[1].Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                tableVPP.Columns[1].SetWidth(50, Word.WdRulerStyle.wdAdjustNone);
                tableVPP.Columns[2].SetWidth(200, Word.WdRulerStyle.wdAdjustNone);
                tableVPP.Columns[3].SetWidth(60, Word.WdRulerStyle.wdAdjustNone);
                tableVPP.Columns[4].SetWidth(80, Word.WdRulerStyle.wdAdjustNone);
                tableVPP.Columns[5].SetWidth(110, Word.WdRulerStyle.wdAdjustNone);

                foreach (Word.Row row in tableVPP.Rows)
                {
                    foreach (Word.Cell cell in row.Cells)
                    {
                        //Data row
                        if (cell.RowIndex > 1)
                        {
                            tableVPP.Cell(cell.RowIndex, 1).Range.Text = item.DanhSachVanPhongPham[cell.RowIndex].STT.ToString();
                            tableVPP.Cell(cell.RowIndex, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                            tableVPP.Cell(cell.RowIndex, 2).Range.Text = item.DanhSachVanPhongPham[cell.RowIndex].VatTuSanPham;
                            tableVPP.Cell(cell.RowIndex, 2).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableVPP.Cell(cell.RowIndex, 3).Range.Text = item.DanhSachVanPhongPham[cell.RowIndex].DonVi;
                            tableVPP.Cell(cell.RowIndex, 3).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableVPP.Cell(cell.RowIndex, 4).Range.Text = item.DanhSachVanPhongPham[cell.RowIndex].SoLuongDuTru.ToString();
                            tableVPP.Cell(cell.RowIndex, 4).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableVPP.Cell(cell.RowIndex, 5).Range.Text = item.DanhSachVanPhongPham[cell.RowIndex].GhiChu;
                            tableVPP.Cell(cell.RowIndex, 5).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            cell.Range.Font.Bold = 0;
                            cell.Range.Font.Size = 12;
                            cell.Range.Font.Name = "Times New Roman";
                        }
                    }
                }
                InsertParagraph(item.ThoiGianTaoBaoCao, "Italic", "Times New Roman", 12, "right", false, 5);
                InsertSignatureForm_VanPhongPham(item.ChuKy_LanhDao, item.Chuky_TruongPhong, item.Chuky_NguoiLapPhieu);
                //Save the document
                filename = @"D:\hanhchinh_bc_phieudutruvanphongpham.docx";
                SaveAs(filename);
                return "Tạo báo cáo thành công";
            }
            catch (Exception e) { return "Error: " + e.ToString(); }
        }
       
        public string HanhChinh_BaoCao_TonKhoThietBiLamSang(object filename, HC_BaoCao_TonKhoThietBiLamSang item)
        {
            try
            {
                object missing = System.Reflection.Missing.Value;
                object oEndOfDoc = "\\endofdoc";
                //tạo tệp tài liệu mới
                CreateNewDocument();
                // xoay ngang page
                wordDoc.Content.PageSetup.TogglePortrait();
                wordDoc.Content.PageSetup.TopMargin = 40F;
                wordDoc.Content.PageSetup.BottomMargin = 40F;
                wordDoc.Content.PageSetup.LeftMargin = 20F;
                wordDoc.Content.PageSetup.RightMargin = 20F;

                // thông tin header
                InsertHeaderForm_ThietBiLamSang(item.TieuDeBaoCao, item.ThongTinBaoCao);
                InsertParagraph("", "", "Times New Roman", 11, "l", false, 0);
                Word.Table tableTBLS;
                Word.Range wrdRng = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

                tableTBLS = wordDoc.Tables.Add(wrdRng, item.DanhSachTonKhoThietBiLamSang.Count, 7, ref missing, ref missing);
                tableTBLS.Range.ParagraphFormat.SpaceAfter = 4;
                tableTBLS.Range.Font.Name = "Times New Roman";
                tableTBLS.Range.Font.Size = 12;

                tableTBLS.Cell(1, 1).Range.Text = "STT";
                tableTBLS.Cell(1, 2).Range.Text = "Ngày";
                tableTBLS.Cell(1, 3).Range.Text = "Nội dung";
                tableTBLS.Cell(1, 4).Range.Text = "Tình trạng";
                tableTBLS.Cell(1, 5).Range.Text = "Nhập";
                tableTBLS.Cell(1, 6).Range.Text = "Xuất";
                tableTBLS.Cell(1, 7).Range.Text = "Tồn";

                tableTBLS.Rows[1].Range.Font.Bold = 1;
                tableTBLS.Rows[1].Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                tableTBLS.Columns[1].SetWidth(50, Word.WdRulerStyle.wdAdjustNone);
                tableTBLS.Columns[2].SetWidth(90, Word.WdRulerStyle.wdAdjustNone);
                tableTBLS.Columns[3].SetWidth(180, Word.WdRulerStyle.wdAdjustNone);
                tableTBLS.Columns[4].SetWidth(100, Word.WdRulerStyle.wdAdjustNone);
                tableTBLS.Columns[5].SetWidth(60, Word.WdRulerStyle.wdAdjustNone);
                tableTBLS.Columns[6].SetWidth(60, Word.WdRulerStyle.wdAdjustNone);
                tableTBLS.Columns[7].SetWidth(60, Word.WdRulerStyle.wdAdjustNone);

                foreach (Word.Row row in tableTBLS.Rows)
                {
                    foreach (Word.Cell cell in row.Cells)
                    {
                        //Data row
                        if (cell.RowIndex > 1)
                        {
                            tableTBLS.Cell(cell.RowIndex, 1).Range.Text = item.DanhSachTonKhoThietBiLamSang[cell.RowIndex].STT.ToString();
                            tableTBLS.Cell(cell.RowIndex, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                            tableTBLS.Cell(cell.RowIndex, 2).Range.Text = item.DanhSachTonKhoThietBiLamSang[cell.RowIndex].Ngay.ToString("dd/MM/yyyy");
                            tableTBLS.Cell(cell.RowIndex, 2).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableTBLS.Cell(cell.RowIndex, 3).Range.Text = item.DanhSachTonKhoThietBiLamSang[cell.RowIndex].NoiDung;
                            tableTBLS.Cell(cell.RowIndex, 3).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableTBLS.Cell(cell.RowIndex, 4).Range.Text = item.DanhSachTonKhoThietBiLamSang[cell.RowIndex].TinhTrang;
                            tableTBLS.Cell(cell.RowIndex, 4).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableTBLS.Cell(cell.RowIndex, 5).Range.Text = item.DanhSachTonKhoThietBiLamSang[cell.RowIndex].Nhap.ToString();
                            tableTBLS.Cell(cell.RowIndex, 5).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableTBLS.Cell(cell.RowIndex, 6).Range.Text = item.DanhSachTonKhoThietBiLamSang[cell.RowIndex].Xuat.ToString();
                            tableTBLS.Cell(cell.RowIndex, 6).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            tableTBLS.Cell(cell.RowIndex, 7).Range.Text = item.DanhSachTonKhoThietBiLamSang[cell.RowIndex].Ton.ToString();
                            tableTBLS.Cell(cell.RowIndex, 7).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            cell.Range.Font.Bold = 0;
                            cell.Range.Font.Size = 12;
                            cell.Range.Font.Name = "Times New Roman";
                        }
                    }
                }
                //Save the document
                filename = @"D:\hanhchinh_bc_tonkhothietbilamsang.docx";
                SaveAs(filename);
                return "Tạo báo cáo thành công";
            }
            catch (Exception e) { return "Error: " + e.ToString(); }
        }*/
    }
}
