using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoliDate.Domain.Models
{
    public class Course
    {
        /// <summary>
        /// CP132 for example
        /// </summary>
        public string Code { get; set; }

        public string Description { get; set; }

        public List<CourseEvent> CourseEvents { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{Code}-{Description}");
            foreach(var ce in CourseEvents)
            {
                sb.AppendLine(ce.ToString());
            }
            return sb.ToString();
        }

    }
}
