using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoliDate.Domain.Models
{
    public class CourseEvent
    {
        public DateTime Date { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Date} {Description}";
        }

    }
}
