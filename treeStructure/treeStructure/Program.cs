using System.Text;

namespace treeStructure
{
    internal class Program
    {
        public static int CurrentLine { get; set; } = 0;
        public static int CurrentColumn { get; set; } = 0;
        private static string fileContent = File.ReadAllText("Resources/structure.txt");
        public static string[] ArrayWithContent { get; set; } = fileContent.Split(Environment.NewLine);
        public static string[,] Table { get; set; } = new string[ArrayWithContent.Length, ArrayWithContent.Length];

        static void Main(string[] args)
        {
            var fileContent = File.ReadAllText("Resources/structure.txt");
            FillArray();
        }

        private static void FillArray()
        {
            var manager = new Manager();
            int currentRow = 0;
            foreach (string line in ArrayWithContent)
            {
                Table[CurrentLine, 0] = line;
                RemoveTabsForChildElements();
            }
        }

        private static void RemoveTabsForChildElements()
        {
            var manager = new Manager();
            while (manager.GetNumberOfTabs(ArrayWithContent[CurrentLine+1]) != 0)
            {
                ArrayWithContent[CurrentLine + 1].Remove(0, 2);
                if (!(manager.GetNumberOfTabs(ArrayWithContent[CurrentLine+1]) >= 1))
                {
                    Table[CurrentLine, CurrentColumn] = ArrayWithContent[CurrentLine + 1];
                }
                CurrentLine++;
                CurrentColumn++;
            }
        }
    }
}