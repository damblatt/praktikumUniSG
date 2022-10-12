using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml
{
    public class Angestellter : IMitarbeiter
    {
        // Properties
        public string Name{ get; set; }
        public int Monatslohn { get; set; }

        // Constructor
        public Angestellter(string name, int monatslohn)
        {
            Name = name;
            Monatslohn = monatslohn;
        }

        // Methods
        string IMitarbeiter.PrintMitarbeiterListe()
        {
            string ausgabe = $"-  Name: {Name}, Monatslohn: {Monatslohn}";
            return $"{ausgabe}";
        }
        
        public virtual int GetMonatslohn()
        {
            return Monatslohn;
        }
    }
}
