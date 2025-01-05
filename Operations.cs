namespace MathGame
{
    // Class for performing a random operation
    public class RandomOperation : IOperations
    {
        private static readonly Random instance = new Random();
        private readonly IList<IOperations> _operations;
        private int _random;

        public RandomOperation()
        {
            _operations = new List<IOperations> { new Add(), new Subtract(), new Multiply(), new Division(), new Modules(), new Square() };
        }

        // Execute a random operation
        public long Excute(List<long> operands)
        {
            _random = instance.Next(0, _operations.Count);
            return _operations[_random].Excute(operands);
        }

        // Get the sign of the random operation
        public string Sign(List<long> operands)
        {
            return _operations[_random].Sign(operands);
        }

        // Get the number of operands for the random operation
        public int OperandsNumber()
        {
            return _operations[_random].OperandsNumber();
        }
    }

    // Class for addition operation
    public class Add : IOperations 
    {
        // Execute addition
        public long Excute(List<long> operands) 
        {
            return operands[0] + operands[1];
        }

        // Get the sign of the addition operation
        public string Sign(List<long> operands)
        {
            return $"{operands[0]} + {operands[1]} = ";
        }

        // Get the number of operands for addition
        public int OperandsNumber()
        {
            return 2;
        }
    }

    // Class for subtraction operation
    public class Subtract : IOperations
    {
        // Execute subtraction
        public long Excute(List<long> operands)
        {
            return operands[0] - operands[1];
        }

        // Get the sign of the subtraction operation
        public string Sign(List<long> operands)
        {
            return $"{operands[0]} - {operands[1]} = ";
        }

        // Get the number of operands for subtraction
        public int OperandsNumber()
        {
            return 2;
        }
    }

    // Class for multiplication operation
    public class Multiply : IOperations
    {
        // Execute multiplication
        public long Excute(List<long> operands)
        {
            return operands[0] * operands[1];
        }

        // Get the sign of the multiplication operation
        public string Sign(List<long> operands)
        {
            return $"{operands[0]} * {operands[1]} = ";
        }

        // Get the number of operands for multiplication
        public int OperandsNumber()
        {
            return 2;
        }
    }

    // Class for division operation
    public class Division : IOperations
    {
        // Execute division
        public long Excute(List<long> operands)
        {
            if (operands[1] == 0 || operands[0] % operands[1] != 0)
                return -1000; // Return error code for invalid division
            return operands[0] / operands[1];
        }

        // Get the sign of the division operation
        public string Sign(List<long> operands)
        {
            return $"{operands[0]} / {operands[1]} = ";
        }

        // Get the number of operands for division
        public int OperandsNumber()
        {
            return 2;
        }
    }

    // Class for modulus operation
    public class Modules : IOperations
    {
        // Execute modulus
        public long Excute(List<long> operands)
        {
            return operands[0] % operands[1];
        }

        // Get the sign of the modulus operation
        public string Sign(List<long> operands)
        {
            return $"{operands[0]} % {operands[1]} = ";
        }

        // Get the number of operands for modulus
        public int OperandsNumber()
        {
            return 2;
        }
    }

    // Class for square operation
    public class Square : IOperations
    {
        // Execute square
        public long Excute(List<long> operands)
        {
            return operands[0] * operands[0];
        }

        // Get the sign of the square operation
        public string Sign(List<long> operands)
        {
            return $"{operands[0]}² = ";
        }

        // Get the number of operands for square
        public int OperandsNumber()
        {
            return 1;
        }
    }
}
