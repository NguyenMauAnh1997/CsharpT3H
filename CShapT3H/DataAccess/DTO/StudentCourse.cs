using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    class StudentCourse:Student
    {
        public DateTime RegisterDate { set; get; }
        public Double CourseCost { set; get; }
        public string CourseCode { set; get; }
        public Double CourseCostAfterCacul { set; get; }
    }
}
