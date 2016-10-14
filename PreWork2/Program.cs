using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreWork2
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Please enter start date in format DD/MM/YYYY: ");
                string DateInput1 = Console.ReadLine();
            /* get first date input as string */
            DateTime StringConvert1 = DateTime.ParseExact(DateInput1, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            /* convert string to date */
            Console.WriteLine("You entered start date: " + DateInput1);
            Console.WriteLine();
            /* confirm to the user the date they entered, insert blank line for prettiness) */

            Console.Write("Please enter end date in format DD/MM/YYYY: ");
            string DateInput2 = Console.ReadLine();
            /* get second date input as string */
            DateTime StringConvert2 = DateTime.ParseExact(DateInput2, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            /* convert string to date */
            Console.WriteLine("You entered end date: " + DateInput2);
            Console.WriteLine("");
            /* confirm to the user the date they entered, insert blank line for prettiness) */

            TimeSpan ts = StringConvert2 - StringConvert1;
            /* use method to calculate the timespan between dates */
            int differenceInDays = ts.Days;
            int differenceInYears = differenceInDays / 365;
            int differenceInMonths = differenceInDays / 52;
            /* calculate for days, months, and years */
            Console.WriteLine("The number of years between dates is: {0} ", differenceInYears);
            Console.WriteLine("The number of months between dates is: {0} ", differenceInMonths);
            Console.WriteLine("The number of days between dates is: {0} ", differenceInDays);
            /* output the calculated results */
            Console.ReadLine();
            /* so the console doesn't close automatically */
        }
    }
        }
    

