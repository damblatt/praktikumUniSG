using indexV2;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;

namespace erstellenEinesIndex
{
    public class DefinitionList
    {
        public List<string> allValues = new List<string>();
        public Dictionary<string, List<string>> DefList { get; set; }
        public bool IsValid { get; set; }

        public DefinitionList(Dictionary<string, List<string>> definitionList)
        {
            DefList = definitionList;
            IsValid = false;
        }

        public Dictionary<string, List<string>> FormatDefList()
        {
            var allKeys = new List<string>();
            var newDeflist = new Dictionary<string, List<string>>();
            StringBuilder indexString = new StringBuilder();
            IsValid = false;

            FillAllValuesList();

            foreach (var value in allValues)
            {
                var contentList = new List<string>();
                foreach (KeyValuePair<string, List<string>> kvp in DefList)
                {
                    if (kvp.Value.Contains(value))
                    {
                        contentList.Add(kvp.Key);
                        contentList = contentList.Distinct().ToList();
                    }
                }
                newDeflist.Add(value, contentList);
            }
            return newDeflist;
        }

        private void FillAllValuesList()
        {
            foreach (KeyValuePair<string, List<string>> kvp in DefList)
            {
                foreach (var value in kvp.Value)
                {
                    allValues.Add(value.ToString());
                    allValues = allValues.Distinct().ToList();
                }
            }
        }


        public string GetValuesContainingIndex(string index)
        {
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

        public string GetIndexesContainingValue(string value)
        {
            StringBuilder indexString = new StringBuilder();
            IsValid = false;

            // build indexString
            foreach (KeyValuePair<string, List<string>> kvp in DefList)
            {
                IsValid = true;
                indexString.Append(kvp.Value.Contains(value) ? $"{kvp.Key}, " : "");
            }

            // invalid, error message
            if (IsValid)
            {
                indexString.Remove(indexString.Length - 2, 2);
                return $"{value}: {indexString.ToString()}";
            }
            else
            {
                return $"{value} is not a valid value.";
            }
        }
    }
}
