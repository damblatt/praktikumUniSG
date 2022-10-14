namespace treeStructureV2
{
    internal class Program
    {
        public static int CurrentLine { get; set; } = 0;

        static void Main(string[] args)
        {
            var fileContent = File.ReadAllText("Resources/structure.txt");
            var masterNode = new Node(Node.GetFirstChildrenList(), "");
            masterNode.lol(masterNode.Children);
        }

        //private static List<string> FillFirstChildrenList()
        //{
        //    List<string> ChildrenStringList = new List<string>();
        //    var manager = new Manager();
        //    int numberOfCurrentTabs = manager.GetNumberOfTabs(nodesContent[CurrentLine]);
        //    while (manager.GetNumberOfTabs(nodesContent[CurrentLine + 1]) == numberOfCurrentTabs + 1)
        //    {
        //        ChildrenStringList.Add(nodesContent[CurrentLine + 1]);
        //        CurrentLine++;
        //        CurrentColumn++;
        //    }
        //    return ChildrenStringList;
        //}
    }
}