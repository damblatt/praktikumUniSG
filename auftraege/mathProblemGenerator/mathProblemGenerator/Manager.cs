using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathProblemGenerator
{
    public class Manager
    {
        private int AmountOfTasks { get; set; }
        private int Difficulty { get; set; }
        private int AmountOfCorrectTasks { get; set; }
        private List<Task> WrongSolvedTasks = new List<Task>();

        public void SetupGame()
        {
            Console.WriteLine("Hey user. Since you're so bad at math, this app will help you getting better at it.");
            
            AmountOfCorrectTasks = 0;
            AmountOfTasks = SetAmountOfTasks();
            Difficulty = SetDifficulty();
        }

        public void MainLoop()
        {
            for (int i = 0; i < AmountOfTasks; i++)
            {
                Task task = new Task(Difficulty);
                Console.Clear();
                Console.WriteLine($"{task.GetTask()} = ");
                Console.Write("x = ");
                int usersGuess = GetUsersGuess(task);
                if (CheckResult(usersGuess, task.Result))
                {
                    AmountOfCorrectTasks++;
                }
                else { WrongSolvedTasks.Add(task); }
            }
        }

        public string EvaluationAndFinalOutput()
        {
            StringBuilder stringBuilder = new StringBuilder($"Out of {AmountOfTasks} math problems you solved {AmountOfCorrectTasks} of them correctly.");

            if (!(AmountOfCorrectTasks == AmountOfTasks))
            {
                stringBuilder.Append("\nHere are the tasks you couldn't solve:\n");
                foreach (Task task in WrongSolvedTasks)
                {
                    stringBuilder.Append($"{task.GetTask()} = {task.Result}\n");
                }
            } else { stringBuilder.Append(" CONGRATULATIONS!"); }

            return stringBuilder.ToString();
        }

        private int SetAmountOfTasks()
        {
            int number = 0;
            Console.Write("How many tasks would you like to be given? Enter a positive number: ");
            while (!Int32.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.WriteLine("Enter a valid number.");
                Console.Write("How many tasks would you like to be given? ");
            }
            return number;
        }

        private int SetDifficulty()
        {
            int difficulty = 0;
            bool isDecidedAndValid = false;
            while (!isDecidedAndValid)
            {
                Console.Clear();
                Console.WriteLine("How difficult would you like the tasks to be? Enter the corresponding number or keyword.");
                Console.WriteLine("[1] EASY");
                Console.WriteLine("[2] MEDIUM");
                Console.WriteLine("[3] HARD");
                Console.WriteLine("[4] IMPOSSIBLE");

                difficulty = ConvertDifficultyStringToDifficultyInt(Console.ReadLine().ToLower());

                switch (difficulty)
                {
                    case 0:
                        isDecidedAndValid = false;
                        break;
                    case 4:
                        Console.Write("Impossible is literally impossible. Do you really want to play at this difficulty? [y/n] ");
                        string yesOrNo = Console.ReadLine().ToLower();
                        if (yesOrNo == "y")
                        {
                            isDecidedAndValid = true;
                        }
                        if (yesOrNo == "n")
                        {
                            isDecidedAndValid = false;
                        }
                        break;
                    default:
                        isDecidedAndValid = true;
                        break;
                }
            }
            return difficulty;
        }

        private int ConvertDifficultyStringToDifficultyInt(string difficulty)
        {
            switch (difficulty)
            {
                case "1":
                    return 1;
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "easy":
                    return 1;
                case "medium":
                    return 2;
                case "hard":
                    return 3;
                case "impossible":
                    return 4;
                default: return 0;
            }
        }

        private int GetUsersGuess(Task task)
        {
            int userGuess = 0;
            while (!Int32.TryParse(Console.ReadLine(), out userGuess) || userGuess < 0)
            {
                Console.Clear();
                Console.WriteLine($"{task.GetTask()} = ");
                Console.Write("x = ");
            }
            return userGuess;
        }

        private bool CheckResult(int usersGuess, int result)
        {
            return (usersGuess == result);
        }
    }
}
