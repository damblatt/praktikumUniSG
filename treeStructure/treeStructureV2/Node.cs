using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treeStructureV2
{
    public class Node
    {
        public static int CurrentLine { get; set; } = Program.CurrentLine;
        public static int CurrentColumn { get; set; } = Program.CurrentColumn;
        private static string fileContent = File.ReadAllText("Resources/structure.txt");
        public static string[] ArrayWithContent { get; set; } = fileContent.Split(Environment.NewLine);
        public static string[,] Table { get; set; } = Program.Table;

        public string Content { get; set; }
        public Node Parent { get; set; }
        public List<string> Children;

        public Node(Node parent, List<string> children, string content = "")
        {
            Parent = parent;
            Children = children;
            Content = content;
        }

        public void CreateChildrensNode()
        {
            foreach (var child in Children)
            {
                RemoveTabsForChildElements();
            }
        }

        public static void RemoveTabsForChildElements()
        {
            List<string> children = new List<string>();
            var manager = new Manager();
            int numberOfCurrentTabs = manager.GetNumberOfTabs(ArrayWithContent[CurrentLine]);
            while (manager.GetNumberOfTabs(ArrayWithContent[CurrentLine + 1]) == numberOfCurrentTabs + 1)
            {
                children.Add(ArrayWithContent[CurrentLine + 1]);
                CurrentLine++;
                CurrentColumn++;
            }
        }

        //public void AddChild()
        //{
        //    Node node = new Node();
        //    Children.Add(node);
        //}
    }
}
