namespace MathGame
{
    public class RandomOperation :IOperations
    {
        public static readonly Random instance = new Random();
        private readonly IList<IOperations> _operations;
        private int _random;
        public RandomOperation()
        {
            _operations = [new Add(),new Subtract(),new Multiply(),new Division(),new Modules()];
        }
        public int Excute(int firstNum, int secondNum)
        {
            _random = instance.Next(0, 3);
           return _operations[_random].Excute(firstNum,secondNum);
        }

        public char Sign()
        {
            return _operations[_random].Sign();
        }
    }
    /// <summary>
    /// //////////////////////////////////////////////////////////
    /// </summary>
    public class Add : IOperations 
    {
        public char Sign()
        {
            return '+';
        }
        public int Excute(int firstNum,int secondNum) 
        {
            return firstNum + secondNum;
        }
    }
    /// <summary>
    /// /////////////////////////////////////////////////////////
    /// </summary>
    public class Subtract : IOperations
    {
        public int Excute(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }

        public char Sign()
        {
             return '-';
        }
    }
    /// <summary>
    /// /////////////////////////////////////////////////////////
    /// </summary>
    public class Multiply : IOperations
    {
        public int Excute(int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }

        public char Sign()
        {
            return '*';
        }
    }
    /// <summary>
    /// /////////////////////////////////////////////////////////
    /// </summary>
    public class Division : IOperations
    {
        public int Excute(int firstNum, int secondNum)
        {
            if(firstNum % secondNum == 0)
            return firstNum / secondNum;
            return -1000;
        }

        public char Sign()
        {
            return '/';
        }
    }
    public class Modules : IOperations
    {
        public int Excute(int firstnum, int secondnum)
        {
            return firstnum % secondnum;
        }

        public char Sign()
        {
            return '%';
        }
    }
}
