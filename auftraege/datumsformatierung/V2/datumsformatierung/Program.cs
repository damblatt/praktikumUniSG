using System.Security.Cryptography.X509Certificates;

namespace datumsformatierung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date firstDate = new Date(01, 02, 2003);

            FormattedDate firstFormattedDate = new FormattedDate(firstDate, "CH");
            firstFormattedDate.SetMessage();
            Console.WriteLine(firstFormattedDate.Message);
        }
    }
}