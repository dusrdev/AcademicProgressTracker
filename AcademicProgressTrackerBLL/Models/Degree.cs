using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicProgressTrackerBLL.Models
{
    public class Degree
    {
        public string Title { get; set; }
        public double Grade { get; set; }
        public int RequiredPoints { get; set; }
        public List<Course> PassedCourses { get; set; }
        public List<Course> FutureCourses { get; set; }
    }
}
