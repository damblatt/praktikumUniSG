using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace datumsformatierung.test
{
    [TestClass]
    public class DateFormatterTest
    {
        [TestMethod]
        public void FormattedDate_SetMessage_CH_correct()
        {
            // Arrange
            var date = new Date(01, 02, 2003);
            var formattedDate = new FormattedDate(date, "CH"); ;

            // Act
            formattedDate.FormatDate();
            var message = Program.GetMessage(formattedDate);
            Console.WriteLine(message);

            // Assert
            Assert.AreEqual("CH: 1.2.2003", message);
        }

        [TestMethod]
        public void FormattedDate_SetMessage_CH_incorrectDate()
        {
            // Arrange
            var date = new Date(100, 02, 2003);
            var formattedDate = new FormattedDate(date, "CH"); ;

            // Act
            formattedDate.FormatDate();
            var message = Program.GetMessage(formattedDate);
            Console.WriteLine(message);

            // Assert
            Assert.AreEqual("invalid date", message);
        }

        [TestMethod]
        public void FormattedDate_SetMessage_CH_incorrectFormat()
        {
            // Arrange
            var date = new Date(01, 02, 2003);
            var formattedDate = new FormattedDate(date, "CHb"); ;

            // Act
            formattedDate.FormatDate();
            var message = Program.GetMessage(formattedDate);
            Console.WriteLine(message);

            // Assert
            Assert.AreEqual("invalid format", message);
        }

        [TestMethod]
        public void FormattedDate_SetMessage_US_correct()
        {
            // Arrange
            var date = new Date(01, 02, 2003);
            var formattedDate = new FormattedDate(date, "US"); ;

            // Act
            formattedDate.FormatDate();
            var message = Program.GetMessage(formattedDate);
            Console.WriteLine(message);

            // Assert
            Assert.AreEqual("US: 2/1/2003", message);
        }

        [TestMethod]
        public void FormattedDate_SetMessage_US_incorrectDate()
        {
            // Arrange
            var date = new Date(100, 02, 2003);
            var formattedDate = new FormattedDate(date, "US"); ;

            // Act
            formattedDate.FormatDate();
            var message = Program.GetMessage(formattedDate);
            Console.WriteLine(message);

            // Assert
            Assert.AreEqual("invalid date", message);
        }

        [TestMethod]
        public void FormattedDate_SetMessage_US_incorrectFormat()
        {
            // Arrange
            var date = new Date(01, 02, 2003);
            var formattedDate = new FormattedDate(date, "USA"); ;

            // Act
            formattedDate.FormatDate();
            var message = Program.GetMessage(formattedDate);
            Console.WriteLine(message);

            // Assert
            Assert.AreEqual("invalid format", message);
        }

        [TestMethod]
        public void FormattedDate_SetMessage_ISO_correct()
        {
            // Arrange
            var date = new Date(01, 02, 2003);
            var formattedDate = new FormattedDate(date, "ISO"); ;

            // Act
            formattedDate.FormatDate();
            var message = Program.GetMessage(formattedDate);
            Console.WriteLine(message);

            // Assert
            Assert.AreEqual("ISO: 2003-2-1", message);
        }

        [TestMethod]
        public void FormattedDate_SetMessage_ISO_incorrectDate()
        {
            // Arrange
            var date = new Date(100, 02, 2003);
            var formattedDate = new FormattedDate(date, "ISO"); ;

            // Act
            formattedDate.FormatDate();
            var message = Program.GetMessage(formattedDate);
            Console.WriteLine(message);

            // Assert
            Assert.AreEqual("invalid date", message);
        }

        [TestMethod]
        public void FormattedDate_SetMessage_ISO_incorrectFormat()
        {
            // Arrange
            var date = new Date(01, 02, 2003);
            var formattedDate = new FormattedDate(date, "IS"); ;

            // Act
            formattedDate.FormatDate();
            var message = Program.GetMessage(formattedDate);
            Console.WriteLine(message);

            // Assert
            Assert.AreEqual("invalid format", message);
        }
    }
}