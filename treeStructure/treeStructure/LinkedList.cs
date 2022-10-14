//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace treeStructure
//{
//    public class LinkedList
//    {
//        private Node head;

//        public void AddNode(Object data)
//        {
//            Node newNode = new Node();
//            newNode.Next = head;
//            newNode.Data = data;
//            head = newNode;
//        }

//        public void PrintAllNodes()
//        {
//            Node current = head;
//            while (current != null)
//            {
//                Console.WriteLine(current.Data.ToString());
//                current = current.Next;
//            }
//        }
//    }
//}
