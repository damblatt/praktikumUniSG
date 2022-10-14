using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treeStructureV2
{
    public class Node
    {
        // content list
        /* */ private static string fileContent = File.ReadAllText("Resources/structure.txt");
        /* */ private static string[] nodesContent { get; set; } = fileContent.Split(Environment.NewLine);
        /* */ private static string[] firstNodesContent = new string[1] { "" };
        /* */ public static string[] allNodesContent = firstNodesContent.Concat(nodesContent).ToArray();
        // content list

        public static int CurrentLine { get; set; } = Program.CurrentLine;

        public List<string> Children { get; set; }
        public string Content { get; set; }

        // constructor
        public Node(List<string> children, string content)
        {
            Children = children;
            Content = content;
        }

        public void lol(List<string> children)
        {
            foreach (var child in children)
            {
                Node node = new Node(GetChildrenList(child), child);
                lol(node.Children);
            }
        }

        public static List<string> GetFirstChildrenList()
        {
            List<string> firstChildrenList = new List<string>();
            var manager = new Manager();
            for(int i = 0; i < (allNodesContent.Length -1); i++)
            {
                CurrentLine++;
                if (manager.GetNumberOfTabs(allNodesContent[CurrentLine]) == 0)
                {
                    firstChildrenList.Add(allNodesContent[CurrentLine]);
                }
            }
            return firstChildrenList;
        }

        public static List<string> GetChildrenList(string content)
        {
            CurrentLine = Array.IndexOf(allNodesContent, content);
            List<string> children = new List<string>();
            var manager = new Manager();
            int numberOfCurrentTabs = manager.GetNumberOfTabs(allNodesContent[CurrentLine]);
            while (manager.GetNumberOfTabs(allNodesContent[CurrentLine + 1]) == numberOfCurrentTabs + 1)
            {
                children.Add(allNodesContent[CurrentLine + 1]);
                CurrentLine++;
            }
            return children;
        }

        //public void AddChild()
        //{
        //    Node node = new Node();
        //    Children.Add(node);
        //}
    }
}
