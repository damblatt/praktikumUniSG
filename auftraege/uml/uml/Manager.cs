using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace uml
{
    public class Manager : Angestellter, IMitarbeiter
    {
        // Properties
        public int Bonus { get; private set; }
        public int Gehalt { get; private set; }

        // Constructor
        public Manager(string name, int monatslohn, int bonus) : base(name, monatslohn)
        {
            Name = name;
            Monatslohn = monatslohn;
            Bonus = bonus;
            Gehalt = monatslohn + bonus;
        }

        // Methods
        string IMitarbeiter.PrintMitarbeiterListe()
        {
            string ausgabe = $"-  Name: {Name}, Monatslohn: {Monatslohn}, Bonus: {Bonus}, Gehalt: {Gehalt}";
            return ausgabe;
        }
        
        public override int GetMonatslohn()
        {
            return base.GetMonatslohn();
        }

        public int GetBonus()
        {
            return Bonus;
        }

        public int GetGehalt()
        {
            return Gehalt;
        }
    }
}
