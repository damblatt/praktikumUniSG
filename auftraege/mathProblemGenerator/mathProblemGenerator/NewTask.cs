using System;
using System.Security.AccessControl;

namespace mathProblemGenerator
{
    internal class NewTask
    {
        // properties
        private int Difficulty { get; set; }
        private string OperatorString { get; set; }
        private int FirstNumber { get; set; }
        private int SecondNumber { get; set; }
        public int Result { get; set; }

        // constructor
        public NewTask(int difficulty)
        {
            this.Difficulty = difficulty;
            this.OperatorString = SetOperator();
            this.FirstNumber = SetFirstNumber();
            this.SecondNumber = SetSecondNumber();
            this.Result = SetResult();
        }

        public string GetTask()
        {
            return $"{FirstNumber} {OperatorString} {SecondNumber}";
        }

        public bool CheckResult(int result)
        {
            return (result == Result);
        }
            
        // methods
        private string SetOperator()
        {
            Random random = new Random();
            int randomOperatorValue = random.Next(1, 5);

            switch (randomOperatorValue)
            {
                case 1:
                    return "+";

                case 2:
                    return "-";

                case 3:
                    return "*";

                case 4:
                    return "/";

                default:
                    return "";
            }
        }

        private int SetFirstNumber()
        {
            Random random = new Random();
            switch (Difficulty)
            {
                case 1:
                    return random.Next(1, 12);
                case 2:
                    return random.Next(1, 100);
                case 3:
                    return random.Next(1, 600);
                case 4:
                    return random.Next(1, 1000000);
                default: return 0;
            }
        }
        private int SetSecondNumber()
        {
            Random random = new Random();
            if (OperatorString == "/")
            {
                return SetSecondNumberDivision();
            } else if (OperatorString == "-")
            {
                return random.Next(1, FirstNumber + 1);
            }
            switch (Difficulty)
            {
                case 1:
                    return random.Next(1, 12);
                case 2:
                    return random.Next(1, 100); // max value for subtraction is the value of the first number
                case 3:
                    return random.Next(1, 600);
                case 4:
                    return random.Next(1, 1000000);
                default: return 0;
            }
        }

        private int SetResult()
        {
            switch (OperatorString)
            {
                case "+":
                    return FirstNumber + SecondNumber;
                case "-":
                    return FirstNumber - SecondNumber;
                case "*":
                    return FirstNumber * SecondNumber;
                case "/":
                    return FirstNumber / SecondNumber;
            }
            return 0;
        }

        private int SetSecondNumberDivision()
        {
            int randomAsNumber;
            do
            {
                var random = new Random();
                randomAsNumber = random.Next(1, FirstNumber + 1);
            } while (FirstNumber % randomAsNumber != 0);
            return randomAsNumber;
        }
    }
}