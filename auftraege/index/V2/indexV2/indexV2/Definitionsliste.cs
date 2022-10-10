using indexV2;
using System;
using System.Net.Http.Headers;
using System.Text;

namespace erstellenEinesIndex
{
    internal class DefinitionList
    {
        public Dictionary<string, List<string>> DefList { get; set; }
        public bool IsValid { get; set; }

        public DefinitionList(Dictionary<string, List<string>> definitionList)
        {
            DefList = definitionList;
            IsValid = false;
        }

        public string GetValuesByIndex(string index)
        {
            Dictionary<string, List<string>>.KeyCollection keys = DefList.Keys;
            Dictionary<string, List<string>>.ValueCollection values = DefList.Values;
            StringBuilder valuesString = new StringBuilder();

            // build valuesString
            foreach (KeyValuePair<string, List<string>> kvp in DefList)
            {
                if (kvp.Key == index)
                {
                    IsValid = true;
                    valuesString.Clear();
                    valuesString.AppendJoin(", ", kvp.Value);
                }
            }

            // invalid, error message
            if (IsValid)
            {
                return $"{index}: {valuesString}";
            }
            else
            {
                return $"{index} is not a valid index/key.";
            }
        }

        public string GetIndexByValues(string value)
        {
            Dictionary<string, List<string>>.KeyCollection keys = DefList.Keys;
            Dictionary<string, List<string>>.ValueCollection values = DefList.Values;
            StringBuilder indexString = new StringBuilder();
            IsValid = false;

            // build indexString
            foreach (KeyValuePair<string, List<string>> kvp in DefList)
            {
                IsValid = true;
                indexString.Append(kvp.Value.Contains(value) ? $"{kvp.Key}, ": "");
            }

            // invalid, error message
            if (IsValid)
            {
                indexString.Remove(indexString.Length - 2, 2);
                return $"{value}: {indexString}";
            }
            else
            {
                return $"{value} is not a valid value.";
            }
        }

        //public static void Test()
        //{
        //    foreach (var inhalt in jederInhalt)
        //    {
        //        Console.Write($"{inhalt}: ");
        //        int i = 0;
        //        foreach (var index in jederIndex)
        //        {
        //            for (int zaehler = 1; zaehler < jederDatensatz.GetLength(1); zaehler++)
        //            {
        //                if (jederDatensatz[i, zaehler] != null && jederDatensatz[i, zaehler].Contains(inhalt))
        //                {
        //                    var nachricht = $"{index} ";
        //                    Console.Write(nachricht);
        //                }
        //            }
        //            i++;
        //        }
        //        Console.WriteLine("\n");
        //    }
        //    Console.ReadKey();
        //    Console.Clear();
        //    publicZaehler = 0;
        //    jederIndex.Clear();
        //    jederInhalt.Clear();
        //}
    }
}
