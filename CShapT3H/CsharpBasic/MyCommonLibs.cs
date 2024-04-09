using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic
{
    class MyCommonLibs
    {
        /// <summary>
        /// This is a fuction check only one character is Number
        /// 0<= Number is <= 9
        /// </summary>
        /// <param name="s">char type</param>
        /// <returns></returns>
        public static bool checkIsNumberWithOneChar(char s)
        {
            bool checkValue = false;
            try
            {
                var intNo = Int16.Parse(s.ToString());
                if(0 <= intNo && intNo <= 9) checkValue = true;

            }
            catch (Exception)
            {
                checkValue = false;
            }
            return checkValue;
        }
        /// <summary>
        /// Check string have enought character 
        /// </summary>
        /// <param name="s">string need check</param>
        /// <param name="checkNoChar">Number character need check</param>
        /// <returns></returns>
        public static bool checkNumberCharacterInString(string s, int checkNoChar)
        {
            var charString = s.ToCharArray();
            if (charString.Count() == checkNoChar) return true;
            return false;
        }
    }
}
