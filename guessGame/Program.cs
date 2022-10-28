class Program
{
    static void Main(string[]args)
    {
        string secretWord = "Hello", guess = "";
        int gueesCount = 0;

        while (guess != secretWord)
        {
            Console.Write("Enter guess: ");
            guess = Console.ReadLine();
        }
        Console.WriteLine("You win!");
    }
}