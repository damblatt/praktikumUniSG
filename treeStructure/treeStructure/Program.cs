using System.Text;

namespace treeStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileContent = File.ReadAllText("Resources/structure.txt");

            List<string> lol = fileContent.Split(Environment.NewLine).ToList(); // removes all newlines

            string[,] bruh = new string[lol.Count, lol.Count];
            int count = 0;
            foreach (string line in lol)
            {
                bruh[count, 0] = line;
                count++;
                //Console.WriteLine(line);
            }
        }

        //private string[,] FillArray()
        //{

        //}
    }
}