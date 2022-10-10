using indexV2;
using System.Collections;
using System.Runtime.ExceptionServices;

namespace erstellenEinesIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();

            var blumeInhalt = new List<string> { "Blatt", "Stiel", "Bluete", "Gruen" };
            dict.Add("Blume", blumeInhalt);

            var baumInhalt = new List<string> { "Stamm", "Ast", "Bluete", "Gruen", "Blatt" };
            dict.Add("Baum", baumInhalt);

            var pilzInhalt = new List<string> { "Hut", "Farbe", "Stiel" };
            dict.Add("Pilz", pilzInhalt);


            var defListe = new DefinitionList(dict);
            string inhalt = defListe.GetValuesByIndex("Pilz");
            string index = defListe.GetIndexByValues("Gruen");
            Console.WriteLine(inhalt);
            Console.WriteLine(index);
        }
    }
}