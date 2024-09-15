using System.Reflection;

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime startingTimer;
            DateTime endingTimer;
            TimeSpan period;
            int input;
            IOperations start =null!;
            MathGame game = new MathGame();
            Console.WriteLine("Welcome To Math Game");
            Console.WriteLine();
            Console.WriteLine("Press Enter If You Are Ready");
            var position = Console.ReadKey();
                while (true)
                {
                var index = 0;
                if (position.Key == ConsoleKey.Enter) {
                    Console.WriteLine("\nMain Menu");
                    Console.WriteLine();
                    Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Modules\n6. Random\n ");
                    var kind = Console.ReadKey();
                    if (kind.Key == ConsoleKey.NumPad1)
                    {
                        start = new Add();
                    }
                    else if (kind.Key == ConsoleKey.NumPad2)
                    {
                        start = new Subtract();
                    }
                    else if (kind.Key == ConsoleKey.NumPad3)
                    {
                        start = new Multiply();
                    }
                    else if (kind.Key == ConsoleKey.NumPad4)
                    {
                        start = new Division();
                    }
                    else if (kind.Key == ConsoleKey.NumPad5) 
                    {
                        start = new Modules();
                    }
                    else if (kind.Key == ConsoleKey.NumPad6)
                    {
                        start = new RandomOperation();
                    }

                    Console.WriteLine("\nChoose The Difficulitly Level : \n\n1-Easy\n2-Medium\n3-Hard\n4-Super Hard\n");

                    var state = Console.ReadKey();
                    Console.WriteLine();
                    Console.WriteLine();

                    if (state.Key == ConsoleKey.NumPad1)
                    {
                        var type = new Easy();
                        Start(type, index);
                    }

                    else if (state.Key == ConsoleKey.NumPad2)
                    {
                        var type = new Medium();
                        Start(type, index);
                    }
                    else if (state.Key == ConsoleKey.NumPad3)
                    {
                        var type = new Hard();
                        Start(type, index);
                    }
                    else if (state.Key == ConsoleKey.NumPad4)
                    {
                        var type = new SuperHard();
                        Start(type, index);
                    }

                }
                else if (position.Key == ConsoleKey.Enter) continue;

                else if (position.Key == ConsoleKey.Escape) break;
                }

            game.History();

            void Start(IProblems type ,int index) 
            {
                startingTimer = DateTime.Now;
                game.Start(start!, type, index);
                while (true)
                {
                    if (index < Base.problemsNumbers - 1)
                    {
                        index++;
                        input = int.Parse(Console.ReadLine()!);
                        if (input == null) throw new NullReferenceException();
                        game.PrintingProblems(type, index);
                        game.RecordingSolutions(input);
                    }
                    else
                    {
                        input = int.Parse(Console.ReadLine()!);
                        game.RecordingSolutions(input);
                        endingTimer = DateTime.Now;
                        period =endingTimer - startingTimer;
                        break;
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"You Took {period} To Finish These Problems");
                Console.WriteLine();
                Console.WriteLine("Wanna do more?");
                Console.WriteLine("Press Enter if you want to play again or Escape to close");
                position = Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
