using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class DateTimeClass
    {
        public void DateTimeMethod() {
            DateTime d;
            d = DateTime.Now;

            Console.WriteLine(d);

            Console.WriteLine($"Day = {d.Day}");

            Console.WriteLine($"Month = {d.Month}");

            Console.WriteLine($"Year = {d.Year}");

            Console.WriteLine($"Hour = {d.Hour}");

            Console.WriteLine($"Minute = {d.Minute}");

            Console.WriteLine($"Second = {d.Second}");

            Console.WriteLine($"Millisecond = {d.Millisecond}");

            Console.WriteLine($"Long Date = {d.ToLongDateString()}");

            Console.WriteLine($"Short Date = {d.ToShortDateString()}");

            Console.WriteLine($"Long Time = {d.ToLongTimeString()}");

            Console.WriteLine($"Short Time = {d.ToShortTimeString()}");

            Console.WriteLine($"Day of the Week = {d.DayOfWeek.ToString()}");

            Console.WriteLine($"Day of the Year = {d.DayOfYear.ToString()}");

            string d1 = d.ToString("MMMM dd, yyyy");

            Console.WriteLine($"New Date Format = {d1}");

            string d2 = d.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture);

            Console.WriteLine($"New Date Format = {d2}");
        }
    }
}
