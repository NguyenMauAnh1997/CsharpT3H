using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic
{
    class MyGeneric<T>
    {
        public static void addNew(List<T> obj)
        {
            bool checkInputData = true;
            int intNumObj = 0;
            Console.WriteLine("This is a Program input new Object");
            do
            {
                Console.Write("Please input Number of object input: ");
                var strNumObj = Console.ReadLine();
                try
                {
                    intNumObj = Int32.Parse(strNumObj);
                    if(intNumObj > 0 && intNumObj < 2147483647)
                    {
                        checkInputData = false;
                    }
                    else
                    {
                        Console.Write("Please input NUMBER Object is more than 0 and less than 2147483647");
                    }
                }
                catch (Exception)
                {

                    Console.Write("Input is not correct....");
                }

            } while (checkInputData);

            if (intNumObj > 0)
            {
                for (int i = 1; i <= intNumObj ; i++)
                {
                    bool checkInputObjNo = true;
                    do
                    {
                        Console.WriteLine("Please Input Infomation Object Number " + i);
                        Console.Write("Object No : ");
                        var strObjectNo = Console.ReadLine();
                        //check ObjectNo have 9 character 
                        if (MyCommonLibs.checkNumberCharacterInString(strObjectNo, 9))
                        {
                            var charArrObjectNo = strObjectNo.ToCharArray();
                            int coutIsCorrect = 0;
                            for (int j = 0; j < charArrObjectNo.Length; j++)
                            {
                                if (MyCommonLibs.checkIsNumberWithOneChar(charArrObjectNo[j])) coutIsCorrect++;
                            }
                            if (coutIsCorrect == charArrObjectNo.Length) 
                            {
                                checkInputObjNo = false;
                            }
                            else
                            {
                                Console.WriteLine("Have character in string Input is not number from 0 ~ 9 ");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Input Object Number not enought 9 character ");
                        }

                    } while (checkInputObjNo);


                    Console.Write("Object Name : ");
                    var strObjectName = Console.ReadLine();

                    Console.Write("Object BirthDay : ");
                    var strObjectBirhDay = Console.ReadLine();


                }
                
            }

        }
    }
}
