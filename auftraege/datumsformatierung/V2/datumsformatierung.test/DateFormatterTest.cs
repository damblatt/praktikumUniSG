namespace datumsformatierung.test
{
    [TestClass]
    public class DateFormatterTest
    {
        [TestMethod]
        public void dateFormatter_GetFormattedDate_CH_correct()
        {
            // Arrange
            var dateFormatter = new DateFormatter();
            var date = new Date(01, 02, 2003);

            // Act
            var output = dateFormatter.GetFormattedDate(date, "ch");
            Console.WriteLine(output);

            // Assert
            Assert.AreEqual("CH: 1.2.2003", output);
        }

        [TestMethod]
        public void dateFormatter_GetFormattedDate_US_correct()
        {
            // Arrange
            var dateFormatter = new DateFormatter();
            var date = new Date(01, 02, 2003);

            // Act
            var output = dateFormatter.GetFormattedDate(date, "US");
            Console.WriteLine(output);

            // Assert
            Assert.AreEqual("US: 2/1/2003", output);
        }

        [TestMethod]
        public void dateFormatter_GetFormattedDate_ISO_correct()
        {
            // Arrange
            var dateFormatter = new DateFormatter();
            var date = new Date(01, 02, 2003);

            // Act
            var output = dateFormatter.GetFormattedDate(date, "ISO");
            Console.WriteLine(output);

            // Assert
            Assert.AreEqual("ISO: 2003-2-1", output);
        }
    }
}