internal class Program
{

    private static void Main(string[] args)
    {
        Random guess = new Random(); //Calls Random() function

        int guessNumber = guess.Next(1, 100); //Specifies range for Random() function

        bool win = false; //Intializes win to false to mark beginning of game

        do 
        {
            Console.Write("Enter a number:"); // Collects output from

            string userInput = Console.ReadLine();

            int numberEntered = int.Parse(userInput);

            if (numberEntered > guessNumber)
            {
                Console.WriteLine("Too High...Guess Lower!");
            }
            else if (numberEntered < guessNumber)
            {
                Console.WriteLine("Too Low...Guess Higher");
            }
            else if (numberEntered == guessNumber)
            { 
                Console.WriteLine("YOU WIN!");
                win = true;
            }

        } while (win == false);
        Console.WriteLine("Thank you for playing this game");
        Console.Write("Press any key to exit the game.");
        Console.ReadKey();

    }
}