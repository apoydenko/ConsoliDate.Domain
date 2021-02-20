using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoliDate.Domain
{
    public class Driver
    {
        public void Run(string fileName)
        {
            var pp = new PdfToTextConverter();

            var text = pp.Convert(fileName);

            Debug.WriteLine(text);

            var cp = new CourseParser();
            var cr = cp.Parse(text);

            Console.WriteLine(cr.ToString());

        }
    }
}
