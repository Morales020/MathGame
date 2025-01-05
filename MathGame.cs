namespace MathGame
{
    public class MathGame 
    {
        // Instance of the Check class to handle recording and checking solutions
        public Check check = new Check();

        // Method to start the game with the selected operation and problems
        public void Start(IOperations operation, IProblems problems, int i) 
        {
            // Execute the operation to generate problems
            problems.Excute(operation);
            // Print the first problem
            problems.Printing(i);
            // Register the problems with the Check instance
            check.Register(problems);
        }

        // Method to print the next problem
        public void PrintingProblems(IProblems problems, int i) 
        {
            problems.Printing(i);
        }

        // Method to record the user's solution
        public void RecordingSolutions(int input) 
        {
            check.Recording(input);
        }

        // Method to display the game history and score
        public void History() 
        {
            check.Checking();
            check.Printing();
        }
    }
}
