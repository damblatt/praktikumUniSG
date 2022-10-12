using indexV2;
using System.Collections;
using System.Runtime.ExceptionServices;
using System.Text;

namespace erstellenEinesIndex
{
    public class Program
    {
        static void Main(string[] args)
        {
            var defList = new Dictionary<string, List<string>>();

            var blumeInhalt = new List<string> { "Blatt", "Blüte" };
            defList.Add("Blume", blumeInhalt);

            var baumInhalt = new List<string> { "Blatt", "Stamm" };
            defList.Add("Baum", baumInhalt);

            var definitionListManager = new DefinitionList(defList);

            // Print definition list
            PrintDefList(defList);

            // Print modified definition list
            var newDefList = definitionListManager.FormatDefList();
            PrintDefList(newDefList);

            // Search for values containing a specific index
            string inhalt = definitionListManager.GetValuesContainingIndex("Pilz");
            Console.WriteLine(inhalt);

            // Search for indexes containing a specific value
            string index = definitionListManager.GetIndexesContainingValue("Gruen");
            Console.WriteLine(index);
        }

        private static void PrintDefList(Dictionary<string, List<string>> defList)
        {
            StringBuilder tempStringBuilder = new StringBuilder();
            StringBuilder finalStringBuilder = new StringBuilder();
            foreach (KeyValuePair<string, List<string>> kvp in defList)
            {
                tempStringBuilder.Clear();
                tempStringBuilder.Append($"{kvp.Key}: ");
                tempStringBuilder.AppendJoin(", ", kvp.Value);
                finalStringBuilder.Append($"{tempStringBuilder}\n");
            }
            Console.WriteLine(finalStringBuilder.ToString());
            Console.ReadKey();
            Console.Clear();
        }
    }
}