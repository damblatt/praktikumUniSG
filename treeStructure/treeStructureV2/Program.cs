namespace treeStructureV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileContent = File.ReadAllText("Resources/structure.txt");
            string[] arrayWithContent = fileContent.Split(Environment.NewLine);

            LinkedList linkedList = new LinkedList();

            foreach(string str in arrayWithContent)
            {
                linkedList.AddNode(str);
            }
        }

        private static void RemoveTabsForChildElements()
        {
            var manager = new Manager();
            while (manager.GetNumberOfTabs(ArrayWithContent[CurrentLine + 1]) != 0)
            {
                ArrayWithContent[CurrentLine + 1].Remove(0, 2);
                if (!(manager.GetNumberOfTabs(ArrayWithContent[CurrentLine + 1]) >= 1))
                {
                    Table[CurrentLine, CurrentColumn] = ArrayWithContent[CurrentLine + 1];
                }
                CurrentLine++;
                CurrentColumn++;
            }
        }
    }
}