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
        List<StudentCourse> lstStudentCourse = new List<StudentCourse>();

        public void InputInfoCource()
        {
            bool checkNexInput = true;
            do
            {
                Console.WriteLine("NHAP THONG TIN KHOA HOC");

                bool checkCourseCode = true;
                var courseCode = "";
                do
                {
                    Console.Write("Ma Khoa Hoc: ");
                    courseCode = Console.ReadLine();
                    if (CommonLibs.ValidationData.CheckIsNullOrWhiteSpace(courseCode))
                    {
                        Console.WriteLine("Input Error !!! Please Retry Input ");
                        checkCourseCode = true;
                    }
                    else
                    {
                        checkCourseCode = false;
                    }

                } while (checkCourseCode);


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
                course.CourseCode = courseCode;
                course.CourseName = courseName;
                course.CourseDes = courseDes;
                course.CourseCost = courseCost;
                course.CourseStartTime = courseStartTime;

                courses.Add(course);
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

        public ReturnData RegisterCource()
        {
            ReturnData returnData = new ReturnData();
            try
            {
                Console.WriteLine("-----------DANG KY KHOA HOC-----------");
                bool checkNexInput = true;
                do
                {
                    bool checkStudentName = true;
                    var studentName = "";
                    do
                    {
                        Console.Write("Ten Sinh Vien: ");
                        studentName = Console.ReadLine();
                        if (CommonLibs.ValidationData.CheckIsNullOrWhiteSpace(studentName) || CommonLibs.ValidationData.CheckContainSpecialChar(studentName))
                        {
                            Console.WriteLine("Input Error !!! Please Retry Input ");
                            checkStudentName = true;
                        }
                        else
                        {
                            checkStudentName = false;
                        }

                    } while (checkStudentName);


                    bool checkStudentBirthday = true;
                    DateTime studentBirthday = new DateTime();
                    do
                    {
                        Console.Write("Ngay Sinh Sinh Vien (dd/MM/yyy): ");
                        var strStudentBirthday = Console.ReadLine();

                        if (CommonLibs.ValidationData.CheckIsNullOrWhiteSpace(strStudentBirthday)
                            || !CommonLibs.ValidationData.CheckDateTimeFormat(strStudentBirthday, "dd/MM/yyyy"))
                        {
                            Console.WriteLine("Input Error !!! Please Retry Input ");
                            checkStudentBirthday = true;
                        }
                        else
                        {
                            checkStudentBirthday = false;
                            studentBirthday = DateTime.ParseExact(strStudentBirthday, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        }

                    } while (checkStudentBirthday);


                    bool checkRegisterDate = true;
                    DateTime registerDate = new DateTime();
                    do
                    {
                        Console.Write("Ngay Dang Ky (dd/MM/yyy): ");
                        var strRegisterDate = Console.ReadLine();

                        if (CommonLibs.ValidationData.CheckIsNullOrWhiteSpace(strRegisterDate)
                            || !CommonLibs.ValidationData.CheckDateTimeFormat(strRegisterDate, "dd/MM/yyyy"))
                        {
                            Console.WriteLine("Input Error !!! Please Retry Input ");
                            checkRegisterDate = true;
                        }
                        else
                        {
                            checkRegisterDate = false;
                            registerDate = DateTime.ParseExact(strRegisterDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        }

                    } while (checkRegisterDate);


                    bool checkCourseCode = true;
                    var courseCode = "";
                    do
                    {
                        Console.Write("Ma Khoa Hoc: ");
                        courseCode = Console.ReadLine();
                        var searchCourseCode = courses.Where(s => s.CourseCode == courseCode)
                                                .Select(r => r.CourseCode).FirstOrDefault();
                        if (CommonLibs.ValidationData.CheckIsNullOrWhiteSpace(courseCode) || searchCourseCode == null)
                        {
                            Console.WriteLine("Input Error !!! Please Retry Input ");
                            checkCourseCode = true;
                        }
                        else
                        {
                            checkCourseCode = false;
                        }

                    } while (checkCourseCode);


                    StudentCourse studentCourse = new StudentCourse();
                    studentCourse.StudentName = studentName;
                    studentCourse.StudentBirthDay = studentBirthday;
                    studentCourse.CourseCode = courseCode;
                    studentCourse.RegisterDate = registerDate;
                    studentCourse.CourseCost = courses.Where(r => r.CourseCode == courseCode).Select(r => r.CourseCost).FirstOrDefault();

                    var courseStartTime = courses.Where(r => r.CourseCode == courseCode).Select(r => r.CourseStartTime).FirstOrDefault();
                    // Kiem tra som 30 ngay hay khong giam 30%
                    if (DateTime.Compare(registerDate, courseStartTime.AddDays(-30)) < 0)
                    {
                        studentCourse.DiscountLevel = 30;
                        var x = (double)(100 - studentCourse.DiscountLevel) / 100;
                        studentCourse.CourseCostAfterCacul = studentCourse.CourseCost * (double)(100 - studentCourse.DiscountLevel) / 100;
                    }// Kiem tra som 10 ngay hay khong giam 10%
                    else if (DateTime.Compare(registerDate, courseStartTime.AddDays(-10)) < 0)
                    {
                        studentCourse.DiscountLevel = 10;
                        studentCourse.CourseCostAfterCacul = studentCourse.CourseCost * (double)(100 - studentCourse.DiscountLevel) / 100;
                    }
                    else
                    {
                        studentCourse.CourseCostAfterCacul = studentCourse.CourseCost;
                    }

                    lstStudentCourse.Add(studentCourse);


                    bool inputIsCorrect = true;
                    {
                        Console.Write("Tiep Tuc Dang Ky Khoa Hoc:  1.Yes   0.No:    ");
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

                    } while (inputIsCorrect) ;

                    returnData.ReturnCode = 1;
                returnData.ReturnMsg = "SUCCESS ! ";
                return returnData;
            }
            catch (Exception)
            {
                returnData.ReturnCode = 0;
                returnData.ReturnMsg = "SYSTEM ERROR ! ";
                return returnData;
            }


        }

        public ReturnData ShowListRegisterCource()
        {
            ReturnData returnData = new ReturnData();
            try
            {
                Console.WriteLine(" ----------HIEN THI DANH SACH DANG KY KHOA HOC ----------");
                var sortList = lstStudentCourse.OrderByDescending(o => o.DiscountLevel).ToList();
                foreach (var item in sortList)
                {
                    Console.WriteLine("Ho va ten Sinh Vien: " + item.StudentName);
                    Console.WriteLine("Ngay sinh: " + item.StudentBirthDay);
                    Console.WriteLine("Ngay dang ky: " + item.RegisterDate.ToString("dd/MM/yyyy"));
                    Console.WriteLine("Hoc phi: " + item.CourseCost);
                    Console.WriteLine("Ty le triet khau: " + item.CourseCost.ToString());
                    Console.WriteLine("Hoc phi sau chiet khau: " + item.StudentName);
                }

                returnData.ReturnCode = 1;
                returnData.ReturnMsg = "SUCCESS ! ";
                return returnData;
            }
            catch (Exception)
            {
                returnData.ReturnCode = 0;
                returnData.ReturnMsg = "SYSTEM ERROR ! ";
                return returnData;
            }
        }
    }
}
