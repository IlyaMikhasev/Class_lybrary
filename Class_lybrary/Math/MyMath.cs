using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_lybrary
{
    public class MyMath
    {
        public static bool LeapYear(int year) {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
        public static bool LeapYear(DateTime year)
        {
            return DateTime.IsLeapYear(year.Year);
        }
        public static bool LeapYear(string year)
        {
            if (year.Contains(":") || year.Contains("."))
                return LeapYear(Convert.ToDateTime(year));
            else
                return LeapYear(Convert.ToInt32(year));
        }
        public static int MinValue(string numbers) {

            Regex reg = new Regex("[0-9]+");
            MatchCollection match = reg.Matches(numbers);
            int min = Convert.ToInt32(match[0].ToString());
            foreach (var num in match)
            {
                int tmp = Convert.ToInt32(num.ToString());
                if (tmp < min)
                    min= tmp;
            }
            return min;
        }
        public static int MaxValue(string numbers)
        {

            Regex reg = new Regex("[0-9]+");
            MatchCollection match = reg.Matches(numbers);
            int max = Convert.ToInt32(match[0].ToString());
            foreach (var num in match)
            {
                int tmp = Convert.ToInt32(num.ToString());
                if (tmp > max)
                    max = tmp;
            }
            return max;
        }
        public static int SumValue(string numbers)
        {
            Regex reg = new Regex("[0-9]+");
            MatchCollection match = reg.Matches(numbers);
            int sum = 0;
            foreach (var num in match)
            {
                sum += Convert.ToInt32(num.ToString());
            }
            return sum;
        }
    }
}
