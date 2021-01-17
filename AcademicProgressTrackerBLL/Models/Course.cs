using System.Collections.Generic;

namespace AcademicProgressTrackerBLL.Models
{
    public class Course
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public int Value { get; set; }
        public double Grade { get; set; }
        public List<Course> Requirements { get; set; } 
    }
}
