namespace mathProblemGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper consoleHelper = new ConsoleHelper();
            int amountOfTasks;
            int difficulty;
            List<NewTask> wrongSolvedTasks = new List<NewTask>();

            // intro and setup
            Console.WriteLine("Hey user. Since you're so bad at math, this app will help you getting better at it.");
            (amountOfTasks, difficulty) = consoleHelper.SetupGame();

            // main loop
            for (int i = 0; i < amountOfTasks; i++)
            {
                NewTask task = new NewTask(difficulty);
                Console.Clear();
                Console.WriteLine($"{task.GetTask()} = ");
                Console.Write("x = ");
                int userGuess = 0;
                while (!Int32.TryParse(Console.ReadLine(), out userGuess) || userGuess < 0)
                {
                    Console.Clear();
                    Console.WriteLine($"{task.GetTask()} = ");
                    Console.Write("x = ");
                }
                if (task.CheckResult(userGuess))
                {
                    consoleHelper.CorrectTasks++;
                } else { wrongSolvedTasks.Add(task); }
            }

            // evaluation and final output
            Console.WriteLine($"Out of {amountOfTasks} math problems you solved {consoleHelper.CorrectTasks} of them correctly.");
            Console.WriteLine($"Here are the tasks you couldn't solve:\n");
            foreach (NewTask task in wrongSolvedTasks)
            {
                Console.WriteLine($"{task.GetTask()} = {task.Result}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}