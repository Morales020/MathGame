namespace MathGame
{
    // Interface for defining problem-related functionalities
    public interface IProblems 
    {
        // Method to execute operations and generate problems
        void Excute(IOperations operations);

        // Method to print a problem statement
        void Printing(int i);

        // Method to get a problem statement
        string GetProblems(int i);

        // Method to get a solution
        long GetSolutions(int i);

        // Method to get the number of problems
        int GetProblemsNumber();
    }
}
