using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoliDate.Domain
{
    public class PdfToTextConverter
    {
        public string Convert(string fileName)
        {
            using (var stream = File.OpenRead(fileName))
            using (UglyToad.PdfPig.PdfDocument document = UglyToad.PdfPig.PdfDocument.Open(stream))
            {
                var page = document.GetPage(2);
                return page.Text;
            }
        }
    }
}
 