namespace treeStructureV2
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
            string[] arrayWithContent = fileContent.Split(Environment.NewLine);

            var masterNode = new Node(null, Node.RemoveTabsForChildElements());

        }

        private static List<string> FillFirstChildrenList()
        {
            List<string> ChildrenStringList = new List<string>();
            var manager = new Manager();
            int numberOfCurrentTabs = manager.GetNumberOfTabs(ArrayWithContent[CurrentLine]);
            while (manager.GetNumberOfTabs(ArrayWithContent[CurrentLine + 1]) == numberOfCurrentTabs + 1)
            {
                ChildrenStringList.Add(ArrayWithContent[CurrentLine + 1]);
                CurrentLine++;
                CurrentColumn++;
            }
            return ChildrenStringList;
        }
    }
}