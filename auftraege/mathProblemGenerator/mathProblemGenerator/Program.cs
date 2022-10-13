namespace mathProblemGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();

            manager.SetupGame();

            manager.MainLoop();

            Console.WriteLine(manager.EvaluationAndFinalOutput());

            Console.ReadKey();
        }
    }
}