using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CShapT3H
{
    public class Helper
    {
        public static bool checkIsNumber(string s)
        {
            try
            {
                var valueChek = Int32.Parse(s);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        public static bool checkNumberCharacter(string chuoiKiemTra, int soLuongKyTuCanKiemTra, ref char[] charArr)
        {
            try
            {
                charArr = chuoiKiemTra.ToCharArray();
                if (charArr.Count() != soLuongKyTuCanKiemTra) return false;
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public static bool checkIsDateTimeFormat(string s)
        {
            DateTime d;
            bool chValidity = DateTime.TryParseExact(
                s,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out d);
            return chValidity;

        }
    }
}
