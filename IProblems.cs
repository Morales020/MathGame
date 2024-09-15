namespace MathGame
{
    public interface IProblems 
    {
        public void Excute(IOperations operations);
        public void Printing(int i);
        public string GetProblems(int i);
        public int GetSolutions(int i);
        public int GetProblemsNumber();

    }
}
