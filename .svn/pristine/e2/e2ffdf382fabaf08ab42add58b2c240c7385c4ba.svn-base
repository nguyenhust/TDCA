using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using System.IO;

namespace Export.Helpers
{
    public class ExportPdf
    {
        public static void ExportHtmlToPdf(string html, string filePath, string fileName)
        {
            StringReader reader = new StringReader(html);
            string outputFile = Path.Combine(filePath, fileName);
            using (FileStream fs = new FileStream(outputFile, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                //Create a new PDF document setting the size to A4 with float 10 10 10 10
                using (Document doc = new Document(PageSize.A4, 10f, 10f, 10f, 10f))
                {
                    HTMLWorker htmlParse = new HTMLWorker(doc);
                    //Bind the PDF document to the FileStream using an iTextSharp PdfWriter
                    using (PdfWriter pdfWriter = PdfWriter.GetInstance(doc, fs))
                    {
                        //Open the document for writing
                        doc.Open();
                        htmlParse.Parse(reader);
                        //Close our document
                        doc.Close();
                    }
                }
            }
        }
    }
}
