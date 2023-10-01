using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _20._101_02_BeautySalon.classes
{
    public static class Validacia
    {
        public static bool ValidEmailAddress(this string s)
        {
            Regex regex = new Regex(@"^[\w\.-]+@[a-zA-Z\d\.-]+\.[a-zA-Z]{2,}$");
            return !regex.IsMatch(s);
        }

        public static bool ValidPhone(this string s)
        {
            Regex regex = new Regex("[^0-9+() -]+");
            return !regex.IsMatch(s);
        }
        public static bool ValidColor(this string s)
        {
            Regex regex = new Regex("[^0-9A-Z]+");
            return !regex.IsMatch(s);
        }

        public static bool ValidFIO(this string s)
        {
            Regex regex = new Regex("[^a-zа-яА-ЯA-Z -]+");
            return !regex.IsMatch(s);
        }

    
    }
}

