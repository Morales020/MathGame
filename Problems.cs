namespace MathGame
{
    public class Base 
    {
        public readonly List<string> problems;
        public readonly List<long> solutions;
        public readonly List<long> randomOperands;
        private Random _randomNum =new Random();
        static public readonly int problemsNumbers = 5;
        public Base()
        {
            problems = new List<string>();
            solutions = new List<long>();
            randomOperands = [1,2];
        }
        public void Excution(IOperations operations,int min, int max) 
        {
                for (int i = 0; i < problemsNumbers; i++)
                {
                    for(int v = 0; v < operations.OperandsNumber(); v++) 
                    {
                    randomOperands[v] = _randomNum.NextInt64(min, max);
                    }
                    var result = operations.Excute(randomOperands);
                    if (result == -1000)
                    {
                        i--;
                        continue;
                    }
                problems.Add(operations.Sign(randomOperands));
                    solutions.Add(result);
                }
        }
    }   
    
    public class Easy: Base ,IProblems 
    {
        public Easy():base()
        {
        }
        public void Excute(IOperations operations)
        {
            Excution(operations,1,10);
        }

        public void Printing(int i)
        {
            Console.Write(problems[i]);
        }
        public string GetProblems(int i)
        {
            return problems[i];
        }

        public long GetSolutions(int i)
        {
            return solutions[i];
        }

        public int GetProblemsNumber()
        {
            return problemsNumbers;
        }
    }
    /// <summary>
    /// //////////////////////////////////////////////////////////
    /// </summary>
    public class Medium : Base ,IProblems
    {
        public Medium():base()
        {
        }
        public void Excute(IOperations operations)
        {
            Excution(operations,10,50);
        }
        public void Printing(int i)
        {
            Console.Write(problems[i]);
        }
        public string GetProblems(int i)
        {
            return problems[i];
        }

        public long GetSolutions(int i)
        {
            return solutions[i];
        }
        public int GetProblemsNumber()
        {
            return problemsNumbers;
        }
    }
    /// <summary>
    /// ///////////////////////////////////////////////////////////////////
    /// </summary>
    public class Hard : Base, IProblems
    {
        public Hard():base()
        {
        }
        public void Excute(IOperations operations)
        {
            Excution(operations, 50, 100);
        }
        public void Printing(int i)
        {
            Console.Write(problems[i]);
        }
        public string GetProblems(int i)
        {
            return problems[i];
        }

        public long GetSolutions(int i)
        {
            return solutions[i];
        }
        public int GetProblemsNumber()
        {
            return problemsNumbers;
        }
    }
    public class SuperHard : Base, IProblems
    {
        public SuperHard() : base()
        {
        }
        public void Excute(IOperations operations)
        {
            Excution(operations, 100, 1000);
        }
        public void Printing(int i)
        {
            Console.Write(problems[i]);
        }
        public string GetProblems(int i)
        {
            return problems[i];
        }

        public long GetSolutions(int i)
        {
            return solutions[i];
        }
        public int GetProblemsNumber()
        {
            return problemsNumbers;
        }
    }

}
