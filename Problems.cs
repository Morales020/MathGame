namespace MathGame
{
    public class Base 
    {
        public readonly List<string> problems;
        public readonly List<int> solutions;
        static public readonly Random firstNumR = new Random();
        static public readonly Random secondNumR = new Random();
        private  int _firstnum;
        private  int _secondnum;
        static public readonly int problemsNumbers = 5;
        public Base()
        {
            problems = new List<string>();
            solutions = new List<int>();
        }
        public void Excution(IOperations operations,int min, int max) 
        {
            for (int i = 0; i < problemsNumbers; i++)
            {
                _firstnum = firstNumR.Next(min,max);
                _secondnum = secondNumR.Next(min,max);
                var result = operations.Excute(_firstnum, _secondnum);
                if (result == -1000)
                {
                    i--;
                    continue;
                }
                problems.Add($"{_firstnum} {operations.Sign()} {_secondnum} = ");
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

        public int GetSolutions(int i)
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

        public int GetSolutions(int i)
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

        public int GetSolutions(int i)
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

        public int GetSolutions(int i)
        {
            return solutions[i];
        }
        public int GetProblemsNumber()
        {
            return problemsNumbers;
        }
    }

}
