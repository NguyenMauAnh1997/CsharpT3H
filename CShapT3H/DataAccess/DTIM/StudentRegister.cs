using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTIM
{
    public class StudentRegister : DTI.IStudentRegister
    {
        List<Course> courses = new List<Course>();

        public void InputInfoCource()
        {
            bool checkNexInput = true;
            do
            {
                Console.WriteLine("NHAP THONG TIN KHOA HOC");

                bool checkCourseName = true;
                var courseName = "";
                do
                {
                    Console.Write("Ten Khoa Hoc: ");
                    courseName = Console.ReadLine();
                    if (CommonLibs.ValidationData.CheckIsNullOrWhiteSpace(courseName))
                    {
                        Console.WriteLine("Input Error !!! Please Retry Input ");
                        checkCourseName = true;
                    }
                    else
                    {
                        checkCourseName = false;
                    }

                } while (checkCourseName);

                bool checkCourseDes = true;
                var courseDes = "";
                do
                {
                    Console.WriteLine("Mo Ta Khoa Hoc: ");
                    courseDes = Console.ReadLine();
                    if (CommonLibs.ValidationData.CheckIsNullOrWhiteSpace(courseDes))
                    {
                        Console.WriteLine("Input Error !!! Please Retry Input ");
                        checkCourseDes = true;
                    }
                    else
                    {
                        checkCourseDes = false;
                    }

                } while (checkCourseDes);

                bool checkCourseCost = true;
                int courseCost = 0;
                do
                {
                    Console.Write("Hoc Phi: ");
                    var strCourseCost = Console.ReadLine();
                    if (CommonLibs.ValidationData.CheckIsNullOrWhiteSpace(strCourseCost) || !CommonLibs.ValidationData.CheckIsNumberAndLessThanZero(strCourseCost))
                    {
                        Console.WriteLine("Input Error !!! Please Retry Input ");
                        checkCourseCost = true;
                    }
                    else
                    {
                        checkCourseCost = false;
                        courseCost = Int32.Parse(strCourseCost);
                    }

                } while (checkCourseCost);



                bool checkCourseStartTime = true;
                DateTime courseStartTime = new DateTime();
                do
                {
                    Console.Write("Ngay Khai Giang (dd/MM/yyy): ");
                    var strCourseStartTime = Console.ReadLine();

                    if (CommonLibs.ValidationData.CheckIsNullOrWhiteSpace(strCourseStartTime) 
                        || !CommonLibs.ValidationData.CheckDateTimeFormat(strCourseStartTime, "dd/MM/yyyy"))
                    {
                        Console.WriteLine("Input Error !!! Please Retry Input ");
                        checkCourseStartTime = true;
                    }
                    else
                    {
                        checkCourseStartTime = false;
                        courseStartTime = DateTime.ParseExact(strCourseStartTime, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    }

                } while (checkCourseStartTime);

                Course course = new Course();
                course.CourseName = courseName;
                course.CourseDes = courseDes;
                course.CourseCost = courseCost;
                course.CourseStartTime = courseStartTime;

                bool inputIsCorrect = true;
                do
                {
                    Console.Write("Tiep Tuc Nhap Khoa Hoc:  1.Yes   0.No:    ");
                    var nextInput = Console.ReadLine();
                    if (nextInput == "1")
                    {
                        inputIsCorrect = false;
                        checkNexInput = true;
                    }
                    else if (nextInput == "0")
                    {
                        inputIsCorrect = false;
                        checkNexInput = false;
                    }
                    else
                    {
                        Console.WriteLine("Input Error ! Please Retry  ");
                        inputIsCorrect = true;
                    }

                } while (inputIsCorrect);

            } while (checkNexInput);
        }

        public ReturnData RegisterCource(Course course, Student student)
        {
            throw new NotImplementedException();
        }
    }
}
