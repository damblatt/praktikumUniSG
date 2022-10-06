using System.Security.Cryptography.X509Certificates;

namespace datumsformatierung
{
    public class Program
    {
        static void Main(string[] args)
        {
            Date firstDate = new Date(01, 02, 2003);

            FormattedDate firstFormattedDate = new FormattedDate(firstDate, "CH");
            firstFormattedDate.FormatDate();
            Console.WriteLine(GetMessage(firstFormattedDate));
        }

        public static string GetMessage(FormattedDate formattedDate)
        {
            if (formattedDate.IsValid)
            {
                return formattedDate.Message;
            }
            else if (!formattedDate.DateIsValid && formattedDate.FormatIsValid)
            {
                return "invalid date";
            }
            else if (formattedDate.DateIsValid && !formattedDate.FormatIsValid)
            {
                return "invalid format";
            }
            else
            {
                return "invalid date and format";
            }
        }
    }
}