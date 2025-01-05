namespace MathGame
{
    // Interface for defining operations
    public interface IOperations
    {
        // Method to get the operation sign as a string
        string Sign(List<long> operands);

        // Method to execute the operation and return the result
        long Excute(List<long> operands);

        // Method to get the number of operands required for the operation
        int OperandsNumber();
    }
}
