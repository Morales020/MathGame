namespace MathGame
{
    // Base class for handling common problem functionalities
    public class Base 
    {
        // List to store problem statements
        public readonly List<string> problems;
        // List to store solutions to the problems
        public readonly List<long> solutions;
        // List to store random operands for the problems
        public readonly List<long> randomOperands;
        // Random number generator
        private Random _randomNum = new Random();
        // Number of problems to generate
        static public readonly int problemsNumbers = 5;

        // Constructor to initialize lists
        public Base()
        {
            problems = new List<string>();
            solutions = new List<long>();
            randomOperands = new List<long> { 1, 2 };
        }

        // Method to execute operations and generate problems
        public void Excution(IOperations operations, int min, int max) 
        {
            for (int i = 0; i < problemsNumbers; i++)
            {
                // Generate random operands
                for (int v = 0; v < operations.OperandsNumber(); v++) 
                {
                    randomOperands[v] = _randomNum.NextInt64(min, max);
                }
                // Execute the operation
                var result = operations.Excute(randomOperands);
                if (result == -1000)
                {
                    // Skip invalid results
                    i--;
                    continue;
                }
                // Add problem statement and solution to lists
                problems.Add(operations.Sign(randomOperands));
                solutions.Add(result);
            }
        }

        // Method to print a problem statement
        public void Printing(int i)
        {
            Console.Write(problems[i]);
        }

        // Method to get a problem statement
        public string GetProblems(int i)
        {
            return problems[i];
        }

        // Method to get a solution
        public long GetSolutions(int i)
        {
            return solutions[i];
        }

        // Method to get the number of problems
        public int GetProblemsNumber()
        {
            return problemsNumbers;
        }
    }   
    
    // Easy difficulty class
    public class Easy : Base, IProblems 
    {
        public Easy() : base() { }

        // Execute operations with easy difficulty range
        public void Excute(IOperations operations)
        {
            Excution(operations, 1, 10);
        }
    }

    // Medium difficulty class
    public class Medium : Base, IProblems
    {
        public Medium() : base() { }

        // Execute operations with medium difficulty range
        public void Excute(IOperations operations)
        {
            Excution(operations, 10, 50);
        }
    }

    // Hard difficulty class
    public class Hard : Base, IProblems
    {
        public Hard() : base() { }

        // Execute operations with hard difficulty range
        public void Excute(IOperations operations)
        {
            Excution(operations, 50, 100);
        }
    }

    // Super Hard difficulty class
    public class SuperHard : Base, IProblems
    {
        public SuperHard() : base() { }

        // Execute operations with super hard difficulty range
        public void Excute(IOperations operations)
        {
            Excution(operations, 100, 1000);
        }
    }
}
