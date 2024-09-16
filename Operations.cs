namespace MathGame
{
    public class RandomOperation :IOperations
    {
        public static readonly Random instance = new Random();
        private readonly IList<IOperations> _operations;
        private int _random;
        public RandomOperation()
        {
            _operations = [new Add(),new Subtract(),new Multiply(),new Division(),new Modules(), new Square()];
        }
        public long Excute(List<long>operands)
        {
            _random = instance.Next(0, 3);
           return _operations[_random].Excute(operands);
        }


        public string Sign(List<long> operands)
        {
            return _operations[_random].Sign( operands);
        }
        public int OperandsNumber()
        {
            return _operations[_random].OperandsNumber();
        }
    }
    /// <summary>
    /// //////////////////////////////////////////////////////////
    /// </summary>
    public class Add : IOperations 
    {
        public long Excute(List<long> operands) 
        {
            return operands[0] + operands[1];
        }
        public string Sign(List<long> operands)
        {
            return $"{operands[0]} + {operands[1]} = ";
        }

        public int OperandsNumber()
        {
            return 2;
        }
    }
    /// <summary>
    /// /////////////////////////////////////////////////////////
    /// </summary>
    public class Subtract : IOperations
    {
        public long Excute(List<long>operands)
        {
            return operands[0] - operands[1];
        }

        public string Sign(List<long> operands)
        {
            return $"{operands[0]} - {operands[1]} = ";
        }
        public int OperandsNumber()
        {
            return 2;
        }
    }
    /// <summary>
    /// /////////////////////////////////////////////////////////
    /// </summary>
    public class Multiply : IOperations
    {
        public long Excute(List<long>operands)
        {
            return operands[0] * operands[1];
        }

        public string Sign(List<long> operands)
        {
            return $"{operands[0]} * {operands[1]} = ";
        }
        public int OperandsNumber()
        {
            return 2;
        }
    }
    /// <summary>
    /// /////////////////////////////////////////////////////////
    /// </summary>
    public class Division : IOperations
    {
        public long Excute(List<long>operands)
        {
            if(operands[0] % operands[1] == 0)
            return operands[0] / operands[1];
            return -1000;
        }

        public string Sign(List<long> operands)
        {
            return $"{operands[0]} / {operands[1]} = ";
        }
        public int OperandsNumber()
        {
            return 2;
        }
    }
    public class Modules : IOperations
    {
        public long Excute(List<long>operands)
        {
            return operands[0] % operands[1];
        }

        public string Sign(List<long> operands)
        {
            return $"{operands[0]} % {operands[1]} = ";
        }
        public int OperandsNumber()
        {
            return 2;
        }
    }
    public class Square : IOperations
    {
        public long Excute(List<long> operands)
        {
                return operands[0] * operands[0];
        }

        public string Sign(List<long> operands)
        {
            return $"{operands[0]}² = ";
        }
        public int OperandsNumber()
        {
            return 1;
        }
    }
}
