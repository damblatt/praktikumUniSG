namespace uml.Test
{
    [TestClass]
    public class UML
    {
        [TestMethod]
        public void Angestellter_GetMonatslohn()
        {
            //
            var abteilung = new Abteilung();
            Angestellter angestellter = abteilung.NeuerAngestellter("angestellter1", 350);

            //
            int lohn = angestellter.GetMonatslohn();

            //
            Assert.AreEqual(350, lohn);
        }

        [TestMethod]
        public void Manager_GetBonus()
        {
            var abteilung = new Abteilung();
            Manager manager = abteilung.NeuerManager("manager1", 350, 10);

            int bonus = manager.GetBonus();

            Assert.AreEqual(10, bonus);
        }

        [TestMethod]
        public void Manager_GetGehalt()
        {
            var abteilung = new Abteilung();
            Manager manager = abteilung.NeuerManager("manager1", 350, 10);

            int? gehalt = manager.GetGehalt();

            Assert.AreEqual(360, gehalt);
        }

        [TestMethod]
        public void Manager_GetMonatslohn()
        {
            var abteilung = new Abteilung();
            Manager manager = abteilung.NeuerManager("manager1", 350, 10);

            int monatslohn = manager.GetMonatslohn();

            Assert.AreEqual(350, monatslohn);
        }

        [TestMethod]
        public void Abteilung_Lohnkosten()
        {
            var abteilung = new Abteilung();
            Manager manager = abteilung.NeuerManager("manager1", 500, 100);
            Angestellter angestellter1 = abteilung.NeuerAngestellter("angestellter1", 150);
            Angestellter angestellter2 = abteilung.NeuerAngestellter("angestellter2", 250);

            int? lohn = abteilung.GetLohnkosten();

            Assert.AreEqual(1000, lohn);
        }
    }
}