using System.Reflection;

namespace IBANNUmmer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var iban = new IBAN(70090100, 1234567890, "DE");
            //Console.WriteLine(iban.IBANNumber);
            Console.Write("Enter IBAN: ");
            Console.WriteLine(IBAN.IsIBANValid(Console.ReadLine()));
        }
    }
}