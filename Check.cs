using System.Text;

namespace MathGame
{
    public class Check 
    {
        private readonly List<long> _records;
        private readonly List<string> _history;
        private readonly IList<IProblems> _problems;
        private int _score = 0;
        private int _totalScore = 0;

        public Check()
        {
            _problems = new List<IProblems>();
            _records = new List<long>();
            _history = new List<string>();
        }

        // Method to record user input
        public void Recording(int input) 
        {
            _records.Add(input);
        }

        // Method to check the recorded inputs against the solutions
        public void Checking() 
        {
            _totalScore = _problems.Count * 50;
            foreach (var problem in _problems)
            {
                for (int i = 0; i < _records.Count; i++)
                {
                    if (i < problem.GetProblemsNumber())
                    {
                        if (_records[i] == problem.GetSolutions(i))
                        {
                            // Correct answer
                            _history.Add($"{problem.GetProblems(i)} {_records[i]}  True +10");
                            _score += 10;
                        }
                        else
                        {
                            // Incorrect answer
                            _history.Add($"{problem.GetProblems(i)} {_records[i]}  You got it Wrong And The Right Answer Is {problem.GetSolutions(i)}");
                        }
                    }
                }
            }
        }

        // Method to print the history and score
        public void Printing() 
        {
            var sb = new StringBuilder();
            sb.Append('-', 70).AppendLine();
            sb.Append("@Your Work History").AppendLine();
            sb.Append('-', 70).AppendLine();

            foreach (var item in _history)
            {
                sb.Append(item).AppendLine();
            }

            sb.Append('-', 70).AppendLine();
            sb.Append($"You Got {_score} of {_totalScore}");
            Console.WriteLine(sb);
        }

        // Method to register a problem
        public void Register(IProblems problem) 
        {
            _problems.Add(problem);
        }
    }
}
