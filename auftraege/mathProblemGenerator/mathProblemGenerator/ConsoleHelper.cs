using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathProblemGenerator
{
    internal class ConsoleHelper
    {
        public int CorrectTasks { get; set; }

        public (int, int) SetupGame()
        {
            CorrectTasks = 0;
            int number = SetAmountOfTasks();
            int difficulty = SetDifficulty();
            return (number, difficulty);
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
            List<int> difficultiesList = new List<int>() { 1, 2, 3, 4 };
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
    }
}
