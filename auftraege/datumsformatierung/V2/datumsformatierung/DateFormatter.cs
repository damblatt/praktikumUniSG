using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace datumsformatierung
{
    public class DateFormatter
    {
        public string GetFormattedDate(Date date, string format)
        {
            bool isValidDate = DateIsValid(date);
            if (isValidDate)
            {
                format = format.ToLower();
                if (format == "ch")
                {
                    return $"CH: {date.Day}.{date.Month}.{date.Year}";
                }
                else if (format == "us")
                {
                    return $"US: {date.Month}/{date.Day}/{date.Year}";
                }
                else if (format == "iso")
                {
                    return $"ISO: {date.Year}-{date.Month}-{date.Day}";
                }
                else { PrintInvalidFormat(); return ""; }
            }
            else { PrintInvalidDate(); return ""; }
        }

        public bool DateIsValid(Date date)
        {
            if (date.Day > 31 || date.Day < 1)
            {
                return false;
            }
            else if (date.Month > 12 || date.Month < 1)
            {
                return false;
            }
            else if (date.Year < 0)
            {
                return false;
            }
            return true;
        }

        public void PrintInvalidFormat()
        {
            Console.WriteLine("invalid format");
        }
        public void PrintInvalidDate()
        {
            Console.WriteLine("invalid date");
        }
    }
}
