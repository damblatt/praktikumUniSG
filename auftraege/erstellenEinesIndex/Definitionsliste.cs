using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erstellenEinesIndex
{
    internal class Definitionsliste
    {
        public static string[,] tabelle = new string[13, 20];
        //public static List<string[,]> tabelle1 = new List<string[,]> [1, 20];

        //public List<string> ganzerDatensatz = new List<string>();
        public List<string> index = new List<string>(); // beinhaltet index
        //public List<string> inhalt = new List<string>(); // beinhaltet nur den inhalt, nicht den index

        //public static List<string> jederGanzeDatensatz = new List<string>();
        public static List<string> jederIndex = new List<string>(); // beinhaltet index
        public static List<string> jederInhalt = new List<string>(); // beinhaltet nur den inhalt, nicht den index

        public static string indexMessage;
        public static int publicZaehler = 0;

        public Definitionsliste(string[,] defliste)
        {
            int i = 0;
            foreach (var item in defliste)
            {
                tabelle[publicZaehler, i] = item;
                i++;
            }
            jederIndex.Add(defliste[0, 0]);
            PrintNormalVersion(defliste);

            foreach (string content in defliste)
            {
                jederInhalt.Add(content);
            }
            //inhalt.Remove(definitionsliste[0]);
            jederInhalt.Remove(defliste[0, 0]);
            jederInhalt = jederInhalt.Distinct().ToList();

            //PrintDefinition(definitionsliste);
            //Test(definitionsliste);

            publicZaehler++;
        }

        public void PrintNormalVersion(string[,] defliste)
        {
            Console.Write($"{defliste[0, 0]}: ");
            for (int i = 1; i < defliste.GetLength(1); i++)
            {
                var nachricht = $"{defliste[0, i]}, ";
                if (i == defliste.GetLength(1) -1)
                {
                    nachricht = $"{defliste[0, i]}";
                }
                Console.Write(nachricht);
            }
            Console.WriteLine("\n");
        }

        public static void Test()
        {
            foreach (var inhalt in jederInhalt)
            {
                Console.Write($"{inhalt}: ");
                int i = 0;
                foreach (var index in jederIndex)
                {
                    for (int zaehler = 1; zaehler < tabelle.GetLength(1); zaehler++)
                    {
                        if (tabelle[i, zaehler] != null && tabelle[i, zaehler].Contains(inhalt))
                        {
                            var nachricht = $"{index} ";
                            Console.Write(nachricht);
                        }
                    }
                    i++;
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
            Console.Clear();
            publicZaehler = 0;
            jederIndex.Clear();
            jederInhalt.Clear();
        }
    }
}
