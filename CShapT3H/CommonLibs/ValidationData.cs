using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommonLibs
{
    public class ValidationData
    {
        public static bool CheckContainSpecialChar(string input)
        {
            Regex specialCharRegex = new Regex(@"[~`!@#$%^&*()+=|\\{}':;,.<>?/""-]");
            if (specialCharRegex.IsMatch(input))
            {
                return true;
            }
            else
                return false;
        }

        public static bool CheckIsNullOrWhiteSpace(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return true;
            }
            else
                return false;
        }

        public static bool CheckIsNumberAndLessThanZero(string input)
        {
            try
            {
                int number = Int32.Parse(input);
                if(number <= 0)
                {
                    return false;
                }else
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool CheckDateTimeFormat(string input, string dateFormat)
        {
            try
            {
                var dt = DateTime.ParseExact(input, dateFormat, CultureInfo.InvariantCulture);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
