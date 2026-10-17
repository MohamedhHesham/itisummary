using System;
using System.Collections.Generic;
using System.Text;

namespace Gem.Helpers
{
    public static class ExtendMethodDef
    {
        public static void WriteToConsoleInParentheses(this string str)
        {
            Console.WriteLine($"((({str})))");
        }
        public static string FormatAsEgyptianCurrency(this decimal amount)
        {
            return amount.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("ar-EG"));
        }
        public static string FormatAsBritishCurrency(this decimal amount)
        {
            return amount.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("en-GB"));
        }
        public static bool IsAllowedHiringBirthDate(this DateTime birthdate)
        {
           return birthdate.AddYears(18) <= DateTime.Now;
        }
    }
}
