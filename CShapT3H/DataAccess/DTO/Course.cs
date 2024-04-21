using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class Course
    {
        public string CourseName { set; get; }
        public string CourseDes { set; get; }
        public int CourseCost { set; get; }
        public DateTime CourseStartTime { set; get; }
    }
}
