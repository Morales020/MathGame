using System.Text;

namespace MathGame
{
    public class Check 
    {
       private readonly List<int>_records;
        private readonly List<string> _history;
        private readonly IList<IProblems>_problem;
        private int _score = 0;
        private int _totalScore = 0;

        public Check()
        {
            _problem = new List<IProblems>();
            _records = new List<int>();
            _history = new List<string>();
        }
        public void Recording(int input) 
        {
            _records.Add(input);
        }
        public void Checking() 
        {
            _totalScore = _problem.Count*50;
            foreach (var problem in _problem)
            {
                int v = 0;
                for (int i = 0; i < _records.Count; i++)
                {
                    if (v < problem.GetProblemsNumber())
                    {
                        if (_records[i] == problem.GetSolutions(v))
                        {
                            _history.Add($"{problem.GetProblems(v)} {_records[i]}  True +10");
                            _score += 10;
                        }
                        else
                        {
                            _history.Add($"{problem.GetProblems(v)} {_records[i]}  You got it Wrong And The Right Answer Is {problem.GetSolutions(v)}");
                        }
                        _records.Remove(_records[i]);
                        i--;
                        v++;
                    }
                }
            }
        }
        public void Printing() 
        {
            var sb = new StringBuilder();
            sb.Append('-',70);
            sb.AppendLine();
            sb.Append("@Your Work History");
            sb.AppendLine();
            sb.Append('-', 70);
            sb.AppendLine();

            foreach (var item in _history)
            {
               sb.Append(item);
                sb.AppendLine();
            }
            sb.Append('-', 70);
            sb.AppendLine();
            sb.Append($"You Got {_score} of {_totalScore}");
            Console.WriteLine(sb);
        }
        public void Register(IProblems problem) 
        {
            _problem.Add(problem);
        }
        
    }
}
