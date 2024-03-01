internal class Program
{

    private static void Main(string[] args)
    {
        Random guess = new Random(); //Calls Random() function

        int guessNumber = guess.Next(1, 100); //Specifies range for Random() function

        bool win = false; //Intializes win to false to mark beginning of game 

        do 
        {
            Console.Write("Enter a number:"); // Collects output from user

            string userInput = Console.ReadLine(); //Reads input 

            int numberEntered;

            if (!int.TryParse(userInput, out numberEntered)) //validates user input must be integer
            {
                Console.WriteLine($"{userInput} is not an integer.");
            }
            else
            {
                if (numberEntered - guessNumber == 1 || numberEntered - guessNumber == 2) //Added a little bit of suspense to the game
                {
                    Console.WriteLine("You are so close!..Enter a slightly lower number.");
                }
                else if (guessNumber - numberEntered == 1 || guessNumber - numberEntered == 2) //Added a little bit of suspense to the game
                {
                    Console.WriteLine("That was so close!.. Enter a slightly higher number.");
                }
                else if (numberEntered > guessNumber)
                {
                    Console.WriteLine("Too High...Guess Lower!");   //Directs user to enter lower number
                }
                else if (numberEntered < guessNumber)           //Directs user to enter higher number
                {
                    Console.WriteLine("Too Low...Guess Higher");
                }
                else if (numberEntered == guessNumber) //If the user input is equal to the guess number, user wins.
                {
                    Console.WriteLine("YOU WIN!");
                    win = true;
                }
            }
        } while (win == false);
        Console.WriteLine("Thank you for playing this game");
        Console.Write("Press any key to exit the game.");
        Console.ReadKey();  //Reads any keystrokes to exit the game

    }
}