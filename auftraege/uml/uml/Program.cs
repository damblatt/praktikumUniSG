namespace uml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Abteilung abteilung1 = new Abteilung();
            Angestellter angestellter1 = abteilung1.NeuerAngestellter("Damian", 7999);
            Angestellter angestellter2 = abteilung1.NeuerAngestellter("Manuel", 8000);
            Manager manager1 = abteilung1.NeuerManager("Damian", 1234, 66);
            Manager manager2 = abteilung1.NeuerManager("Zweiter Manager", 9999, 999);

            Console.WriteLine();
            Console.WriteLine($"Der Monatslohn von {angestellter1.Name} betraegt {angestellter1.GetMonatslohn()}.");
            Console.WriteLine();
            Console.WriteLine($"Der Monatslohn von {angestellter2.Name} betraegt {angestellter2.GetMonatslohn()}.");
            Console.WriteLine();
            Console.WriteLine($"Das Gehalt von {manager1.Name} setzt sich aus einem Monatslohn von {manager1.GetMonatslohn()} CHF und einem Bonus von {manager1.GetBonus()} CHF zusammen. Insgesamt also {manager1.GetGehalt()} CHF.");
            Console.WriteLine();
            Console.WriteLine($"Das Gehalt von {manager2?.Name} setzt sich aus einem Monatslohn von {manager2?.GetMonatslohn()} CHF und einem Bonus von {manager2?.GetBonus()} CHF zusammen. Insgesamt also {manager2?.GetGehalt()} CHF.");
            Console.WriteLine();

            Console.WriteLine(abteilung1.GetMitarbeiter());
        }
    }
}