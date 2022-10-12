using erstellenEinesIndex;
using System.Text;

namespace IndexV2.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetDefListSortedByIndex()
        {
            // Assign
            StringBuilder tempStringBuilder = new StringBuilder();
            StringBuilder finalStringBuilder = new StringBuilder();
            var defList = new Dictionary<string, List<string>>();

            var blumeInhalt = new List<string> { "Blatt", "Blüte" };
            defList.Add("Blume", blumeInhalt);

            var baumInhalt = new List<string> { "Blatt", "Stamm" };
            defList.Add("Baum", baumInhalt);

            var definitionListManager = new DefinitionList(defList);

            // Act
            foreach (KeyValuePair<string, List<string>> kvp in defList)
            {
                tempStringBuilder.Clear();
                tempStringBuilder.Append($"{kvp.Key}: ");
                tempStringBuilder.AppendJoin(", ", kvp.Value);
                finalStringBuilder.Append($"{tempStringBuilder}\n");
            }

            // Assert
            Assert.AreEqual("Blume: Blatt, Blüte\nBaum: Blatt, Stamm\n", finalStringBuilder.ToString());
        }

        [TestMethod]
        public void DefinitionList_GetDefListSortedByValue()
        {
            // Assign
            StringBuilder tempStringBuilder = new StringBuilder();
            StringBuilder finalStringBuilder = new StringBuilder();
            var defList = new Dictionary<string, List<string>>();

            var blumeInhalt = new List<string> { "Blatt", "Blüte" };
            defList.Add("Blume", blumeInhalt);

            var baumInhalt = new List<string> { "Blatt", "Stamm" };
            defList.Add("Baum", baumInhalt);

            var definitionListManager = new DefinitionList(defList);

            // Act
            var newDefList = definitionListManager.FormatDefList();
            foreach (KeyValuePair<string, List<string>> kvp in newDefList)
            {
                tempStringBuilder.Clear();
                tempStringBuilder.Append($"{kvp.Key}: ");
                tempStringBuilder.AppendJoin(", ", kvp.Value);
                finalStringBuilder.Append($"{tempStringBuilder}\n");
            }

            // Assert
            Assert.AreEqual("Blatt: Blume, Baum\nBlüte: Blume\nStamm: Baum\n", finalStringBuilder.ToString());
        }


        [TestMethod]
        public void DefinitionList_GetValuesContainingIndex()
        {
            // Assign
            StringBuilder tempStringBuilder = new StringBuilder();
            StringBuilder finalStringBuilder = new StringBuilder();
            var defList = new Dictionary<string, List<string>>();

            var blumeInhalt = new List<string> { "Blatt", "Blüte" };
            defList.Add("Blume", blumeInhalt);

            var baumInhalt = new List<string> { "Blatt", "Stamm" };
            defList.Add("Baum", baumInhalt);

            var definitionListManager = new DefinitionList(defList);

            // Act
            var newDefList = definitionListManager.FormatDefList();
            foreach (KeyValuePair<string, List<string>> kvp in newDefList)
            {
                tempStringBuilder.Clear();
                tempStringBuilder.Append($"{kvp.Key}: ");
                tempStringBuilder.AppendJoin(", ", kvp.Value);
                finalStringBuilder.Append($"{tempStringBuilder}\n");
            }

            // Assert
            Assert.AreEqual("Blatt: Blume, Baum\nBlüte: Blume\nStamm: Baum\n", finalStringBuilder.ToString());
        }

        [TestMethod]
        public void DefinitionList_GetIndexesContainingValue()
        {
            // Assign
            StringBuilder tempStringBuilder = new StringBuilder();
            StringBuilder finalStringBuilder = new StringBuilder();
            var defList = new Dictionary<string, List<string>>();

            var blumeInhalt = new List<string> { "Blatt", "Blüte" };
            defList.Add("Blume", blumeInhalt);

            var baumInhalt = new List<string> { "Blatt", "Stamm" };
            defList.Add("Baum", baumInhalt);

            var definitionListManager = new DefinitionList(defList);

            // Act
            var newDefList = definitionListManager.FormatDefList();
            foreach (KeyValuePair<string, List<string>> kvp in newDefList)
            {
                tempStringBuilder.Clear();
                tempStringBuilder.Append($"{kvp.Key}: ");
                tempStringBuilder.AppendJoin(", ", kvp.Value);
                finalStringBuilder.Append($"{tempStringBuilder}\n");
            }

            // Assert
            Assert.AreEqual("Blatt: Blume, Baum\nBlüte: Blume\nStamm: Baum\n", finalStringBuilder.ToString());
        }
    }
}