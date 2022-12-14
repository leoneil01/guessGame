class Program
{
    static void Main(string[]args)
    {
        string secretWord = "Hello", guess = "";
        int guessCount = 0;
        int guessLimit = 3;
        bool noMoreGuesses = false;

        while (guess != secretWord && !noMoreGuesses)
        {
            if (guessCount < guessLimit)
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
                guessCount++;
            }
            else
            {
                noMoreGuesses = true;
            }
        }
        if (noMoreGuesses)
        {
            Console.WriteLine("Try again. You lose");
        }
        else
        {
            Console.WriteLine("You win!");
        }
    }
}