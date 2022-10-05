using System.Security.Cryptography.X509Certificates;

namespace datumsformatierung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date(01, 02, 2003);
            
            DateFormatter formattedDate = new DateFormatter();

            CheckFormattedDate(formattedDate.GetFormattedDate(date, "CH"));
            CheckFormattedDate(formattedDate.GetFormattedDate(date, "US"));
            CheckFormattedDate(formattedDate.GetFormattedDate(date, "ISO"));
        }

        public static void CheckFormattedDate(string outputFormattedDate)
        {
            if (outputFormattedDate != "")
            {
                Console.WriteLine(outputFormattedDate);
            }
        }
    }
}