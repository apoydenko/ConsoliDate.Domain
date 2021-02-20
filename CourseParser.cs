using ConsoliDate.Domain.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoliDate.Domain
{
    public class CourseParser
    {
        public Course Parse(string text)
        {
            var course = new Course();

            course.CourseEvents = new List<CourseEvent>();

            var regex = @"Assignment \b\d due:";
            var rg = new Regex(regex);

            var m1 = rg.Match(text);

            if (m1.Success)
            {
                var courseEvent = new CourseEvent();
                 
                var evtDateStr = text.Substring(m1.Index + m1.Length, 20);
                var t = "";
                var i = m1.Index + m1.Length;
                var dtFound = false;
                var monthNameEnd = text.IndexOf(" ", m1.Index + m1.Length + 1);
                var monthName = text.Substring(m1.Index + m1.Length, monthNameEnd - m1.Index - m1.Length);
                var day = text.Substring(monthNameEnd + 1, 2);
                if (!Char.IsDigit(day[1]))
                {
                    day = text.Substring(monthNameEnd, 1);
                }

                 courseEvent.Description = text.Substring(m1.Index, m1.Length);
                var monthInd = DateTime.ParseExact(monthName.Trim(), "MMMM", CultureInfo.CurrentCulture).Month;
                courseEvent.Date = new DateTime(2020, monthInd, int.Parse(day));

                course.CourseEvents.Add(courseEvent);
            }

            return course;
        }
    }
}
