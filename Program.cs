using System.Reflection;

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables to track the start and end time of the game
            DateTime startingTimer;
            DateTime endingTimer;
            TimeSpan period;

            // Variable to store user input
            int input;

            // Variable to store the selected operation
            IOperations start = null!;

            // Create a new instance of the MathGame class
            MathGame game = new MathGame();

            // Welcome message
            Console.WriteLine("Welcome To Math Game");
            Console.WriteLine();
            Console.WriteLine("Press Enter If You Are Ready");

            // Wait for the user to press a key
            var position = Console.ReadKey();

            // Main game loop
            while (true)
            {
                var index = 0;

                // Check if the Enter key was pressed
                if (position.Key == ConsoleKey.Enter) {
                    // Display the main menu
                    Console.WriteLine("\nMain Menu");
                    Console.WriteLine();
                    Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Modules\n6. Square\n7. Random\n ");

                    // Wait for the user to select an option
                    var kind = Console.ReadKey();

                    // Determine which operation to perform based on user input
                    switch (kind.Key)
                    {
                        case ConsoleKey.NumPad1:
                        case ConsoleKey.D1:
                            start = new Add();
                            break;
                        case ConsoleKey.NumPad2:
                        case ConsoleKey.D2:
                            start = new Subtract();
                            break;
                        case ConsoleKey.NumPad3:
                        case ConsoleKey.D3:
                            start = new Multiply();
                            break;
                        case ConsoleKey.NumPad4:
                        case ConsoleKey.D4:
                            start = new Division();
                            break;
                        case ConsoleKey.NumPad5:
                        case ConsoleKey.D5:
                            start = new Modules();
                            break;
                        case ConsoleKey.NumPad6:
                        case ConsoleKey.D6:
                            start = new Square();
                            break;
                        case ConsoleKey.NumPad7:
                        case ConsoleKey.D7:
                            start = new RandomOperation();
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            continue;
                    }

                    // Prompt the user to choose the difficulty level
                    Console.WriteLine("\nChoose The Difficulty Level : \n\n1-Easy\n2-Medium\n3-Hard\n4-Super Hard\n");

                    // Wait for the user to select a difficulty level
                    var state = Console.ReadKey();
                    Console.WriteLine();
                    Console.WriteLine();

                    // Determine the difficulty level based on user input
                    switch (state.Key)
                    {
                        case ConsoleKey.NumPad1:
                        case ConsoleKey.D1:
                            {
                                // Easy difficulty selected
                                var type = new Easy();
                                Start(type, index);
                                break;
                            }

                        case ConsoleKey.NumPad2:
                        case ConsoleKey.D2:
                            {
                                // Medium difficulty selected
                                var type = new Medium();
                                Start(type, index);
                                break;
                            }

                        case ConsoleKey.NumPad3:
                        case ConsoleKey.D3:
                            {
                                // Hard difficulty selected
                                var type = new Hard();
                                Start(type, index);
                                break;
                            }

                        case ConsoleKey.NumPad4:
                        case ConsoleKey.D4:
                            {
                                // Super Hard difficulty selected
                                var type = new SuperHard();
                                Start(type, index);
                                break;
                            }

                        default:
                            // Handle invalid choice for difficulty level
                            Console.WriteLine("\nInvalid Choice");
                            continue;
                    }

                }
                else if (position.Key == ConsoleKey.Enter) continue;

                else if (position.Key == ConsoleKey.Escape) break;
                }

            // Display the game history
            game.History();

            // Method to start the game with the selected difficulty level
            void Start(IProblems type, int index) 
            {
                // Record the start time
                startingTimer = DateTime.Now;
                game.Start(start!, type, index);
                while (true)
                {
                    if (index < Base.problemsNumbers - 1)
                    {
                        index++;

                        try
                        {
                            // Read user input
                            input = int.Parse(Console.ReadLine()!);
                        }
                        catch (FormatException)
                        {
                            // Handle invalid input
                            Console.WriteLine("Invalid input! Please enter a valid integer.");
                            return; 
                        }

                        // Print the next problem and record the solution
                        game.PrintingProblems(type, index);
                        game.RecordingSolutions(input);
                    }
                    else
                    {
                        // Read the final input and record the solution
                        input = int.Parse(Console.ReadLine()!);
                        game.RecordingSolutions(input);
                        // Record the end time
                        endingTimer = DateTime.Now;
                        period = endingTimer - startingTimer;
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
