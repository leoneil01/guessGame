class Program
{
    static void Main(string[]args)
    {
        string secretWord = "Hello", guess = "";
        int guessCount = 0;

        while (guess != secretWord)
        {
            Console.Write("Enter guess: ");
            guess = Console.ReadLine();
            guessCount++;
        }
        Console.WriteLine("You win!");
    }
}