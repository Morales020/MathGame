namespace MathGame
{
    public interface IOperations
    {
        string Sign(List<long> operands);
        long Excute(List<long> operands);

        int OperandsNumber();
    }
}
