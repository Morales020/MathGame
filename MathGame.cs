namespace MathGame
{
    public class MathGame 
    {
     public Check check = new Check();

        public void Start(IOperations operation, IProblems problems,int i) 
        {
        problems.Excute(operation);
        problems.Printing(i);
        check.Register(problems);
        }
        public void PrintingProblems(IProblems problems, int i) 
        {
            problems.Printing(i);
        }
        public void RecordingSolutions(int input) 
        {
            check.Recording(input);
        }
        public void History() 
        {
            check.Checking();
            check.Printing();
        }
    }
}
