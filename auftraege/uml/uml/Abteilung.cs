using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace uml
{

    public class Abteilung
    {
        // Properties
        public List<IMitarbeiter> MitarbeiterListe { get; private set; } = null;

        public bool HatManager { get; private set; } = false;
        public int Lohnkosten { get; private set; } = 0;

        public Abteilung()
        {
            MitarbeiterListe = new List<IMitarbeiter>();
        }

        // Methods
        public Angestellter NeuerAngestellter(string name, int monatslohn)
        {
            Angestellter angestellter = new Angestellter(name, monatslohn);
            Console.WriteLine($"{name} erfolgreich als Angestellter hinzugefügt.");
            MitarbeiterListe.Add(angestellter);
            Lohnkosten += angestellter.GetMonatslohn();
            return angestellter;
        }

        public Manager NeuerManager(string name, int monatslohn, int bonus)
        {
            if (!HatManager)
            {
                Manager manager = new Manager(name, monatslohn, bonus);
                Console.WriteLine($"{name} erfolgreich als Manager hinzugefügt.");
                MitarbeiterListe.Add(manager);
                HatManager = true;
                Lohnkosten += manager.GetGehalt();
                return manager;
            }
            else { Console.WriteLine($"Deine Abteilung enthält bereits einen Manager!"); return null; }
        }

        public int GetLohnkosten()
        {
            return Lohnkosten;
        }

        public string GetMitarbeiter()
        {
            var stringBuilder = new StringBuilder();
            var managerStringBuilder = new StringBuilder("Manager:\n");
            var angestellterStringBuilder = new StringBuilder("Angestellte:\n");

            foreach (var mitarbeiter in MitarbeiterListe)
            {
                if (mitarbeiter.GetType() == typeof(Manager))
                {
                    managerStringBuilder.Append($"\t{mitarbeiter.PrintMitarbeiterListe()}");
                }
                else if (mitarbeiter.GetType() == typeof(Angestellter))
                {
                    angestellterStringBuilder.Append($"\t{mitarbeiter.PrintMitarbeiterListe()}\n");
                }
            }
            stringBuilder.Append($"{managerStringBuilder}\n\n{angestellterStringBuilder}");
            return stringBuilder.ToString();
        }
    }
}
