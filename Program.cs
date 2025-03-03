namespace Number_guessing_game;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int genNumber = random.Next(1,11);
        Console.WriteLine("Welcome to the number guessing game!");
        Console.ReadKey();
        Console.WriteLine("A number between 1 and 10 will be generated.");
        Console.ReadKey();
        Console.WriteLine("If you guess the correct number, you win!");

        bool gameWon = false;
        while (!gameWon)
        {
            Console.WriteLine("Please enter your guess.");
            int input = Convert.ToInt32(Console.ReadLine());

                if (input < genNumber) {
                    Console.WriteLine("Your guess is too low!");
                }
                else if (input > genNumber) {
                    Console.WriteLine("Your guess is too high!");
                }
                else {
                    Console.WriteLine("Correct");
                    gameWon = true;
                }
            }
            
            Console.WriteLine("Congratulations, you have won the game!");

        
    }
    }
