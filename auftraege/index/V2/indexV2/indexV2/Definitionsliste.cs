namespace erstellenEinesIndex
{
    internal class Definitionsliste
    {
        public static string[,] jederDatensatz = new string[4, 6];
        // first int: anzahl datensätze, resp. objekte, die aufgerufen werden
        // second int:  anzahl inhalte, die übergeben werden (+ 1 index)

        public static List<string> jederIndex = new List<string>(); // beinhaltet jeden Index
        public static List<string> jederInhalt = new List<string>(); // beinhaltet jeden Inhalt, ohne Index

        public static int publicZaehler = 0;

        public Definitionsliste(string[,] datensatz)
        {
            int i = 0;
            foreach (var item in datensatz)
            {
                jederDatensatz[publicZaehler, i] = item;
                i++;
            }
            jederIndex.Add(datensatz[0, 0]);
            PrintNormalVersion(datensatz);

            foreach (string content in datensatz)
            {
                jederInhalt.Add(content);
            }
            jederInhalt.Remove(datensatz[0, 0]);
            jederInhalt = jederInhalt.Distinct().ToList();

            publicZaehler++;
        }

        public void PrintNormalVersion(string[,] defliste)
        {
            Console.Write($"{defliste[0, 0]}: ");
            for (int i = 1; i < defliste.GetLength(1); i++)
            {
                var nachricht = $"{defliste[0, i]}, ";
                if (i == defliste.GetLength(1) - 1)
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
                    for (int zaehler = 1; zaehler < jederDatensatz.GetLength(1); zaehler++)
                    {
                        if (jederDatensatz[i, zaehler] != null && jederDatensatz[i, zaehler].Contains(inhalt))
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
