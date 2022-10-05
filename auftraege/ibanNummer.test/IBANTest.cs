using IBANNUmmer;

namespace ibanNummer.test
{
    [TestClass]
    public class IBANTest
    {
        [TestMethod]
        public void iban()
        {
            // Arrange
            var iban = new IBAN(70090100, 1234567890, "DE");

            // Act
            var ibannumber = iban.IBANNumber;
            Console.WriteLine(ibannumber);

            // Assert
            Assert.AreEqual("DE08700901001234567890", ibannumber);
        }

        [TestMethod]
        public void iban_isIBANValid_DE_correct()
        {
            // Act
            string message = IBAN.IsIBANValid("DE36500105177645384541");

            // Assert
            Assert.AreEqual("This IBAN is valid.", message);
        }

        [TestMethod]
        public void iban_isIBANValid_DE_correct2()
        {
            // Act
            string message = IBAN.IsIBANValid("DE13500105175924666744");

            // Assert
            Assert.AreEqual("This IBAN is valid.", message);
        }

        [TestMethod]
        public void iban_isIBANValid_CH_correct()
        {
            // Act
            string message = IBAN.IsIBANValid("CH0589144431964268868");

            // Assert
            Assert.AreEqual("This IBAN is valid.", message);
        }

        [TestMethod]
        public void iban_isIBANValid_CH_incorrect()
        {
            // Act
            string message = IBAN.IsIBANValid("CHH0589144431964268868");

            // Assert
            Assert.AreEqual("This IBAN is not valid.", message);
        }

        [TestMethod]
        public void iban_isIBANValid_CH_withSpace_correct()
        {
            // Act
            string message = IBAN.IsIBANValid("CEHH  058 9 144   4319  64268   868");

            // Assert
            Assert.AreEqual("This IBAN is not valid.", message);
        }
    }
}