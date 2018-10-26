using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2inclass.Helpers
{
    public static class Extensions
    {
        public static int ToAge(this DateTime age, DateTime birthday)
        {
            int difference = birthday.Month - age.Month;
            if (difference < 0)
            {
                difference = difference / 365;
            }
            return difference;
        }

        public static string ToDigitsOnly(this string Digit)
        {
            var Number = "";
            foreach (var n in Digit)
            {
                if (char.IsDigit(n))
                {
                    Number += n;
                }
            }
            return Number;
        }
    }
}