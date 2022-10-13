namespace mathProblemGenerator
{
    internal class Program
    {
        private static Manager _consoleHelper = new Manager();

        static void Main(string[] args)
        {
            _consoleHelper.SetupGame();

            _consoleHelper.Mainloop();

            Console.WriteLine(_consoleHelper.EvaluationAndFinalOutput());

            Console.ReadKey();
        }
    }
}