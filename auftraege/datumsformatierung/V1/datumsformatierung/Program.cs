using System.Security.Cryptography.X509Certificates;

namespace datumsformatierung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateFormatter dateForm = new DateFormatter();

            Date date = new Date(01, 02, 2003);

            Console.WriteLine(dateForm.GetFormattedDate(date, "CH"));
            Console.WriteLine(dateForm.GetFormattedDate(date, "US"));
            Console.WriteLine(dateForm.GetFormattedDate(date, "ISO"));
        }
    }
}