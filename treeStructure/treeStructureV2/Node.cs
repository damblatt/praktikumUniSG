using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treeStructureV2
{
    public class Node
    {
        public List<Node> children;
        public Object Data { get; set; }

        public void AddChild(string data)
        {
            Node node = new Node();
            children.Add(node);
        }
    }
}
