using System.Collections;

namespace erstellenEinesIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Beispiel 1
            //-----------------------------------------------------------------------------------------
            var inhaltBlume = new string[1, 5] { { "Blume", "Blatt", "Stiel", "Bluete", "Gruen" } };
            var inhaltBaum = new string[1, 6] { { "Baum", "Stamm", "Ast", "Bluete", "Gruen", "Blatt" } };
            var inhaltPilz = new string[1, 4] { { "Pilz", "Hut", "Farbe", "Stiel" } };

            var defBlume = new Definitionsliste(inhaltBlume);
            var defBaum = new Definitionsliste(inhaltBaum);
            var defPilz = new Definitionsliste(inhaltPilz);
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Definitionsliste.Test();

            // Beispiel 2
            //-----------------------------------------------------------------------------------------
            var inhaltTisch = new string[1, 3] { { "Tisch", "Holz", "Beine" } };
            var inhaltSchrank = new string[1, 3] { { "Schrank", "Holz", "Tuer" } };
            var inhaltStuhl = new string[1, 4] { { "Stuhl", "Lehne", "Beine", "Sitzflaeche" } };
            var inhaltBett = new string[1, 4] { { "Bett", "Holz", "Beine", "Laken" } };

            var defTisch = new Definitionsliste(inhaltTisch);
            var defSchrank = new Definitionsliste(inhaltSchrank);
            var defStuhl = new Definitionsliste(inhaltStuhl);
            var defBett = new Definitionsliste(inhaltBett);
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Definitionsliste.Test();
        }
    }
}