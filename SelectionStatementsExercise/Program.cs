// See https://aka.ms/new-console-template for more information


internal class Program
{
    private static void Main(string[] args)
    {
        int favoriteNumber = 537;

        Console.WriteLine("Try to guess my favorite number");
        var userInput = int.Parse(Console.ReadLine());

        if (userInput < favoriteNumber)
        {
            Console.WriteLine("too low");
        }
        else 
        if (userInput > favoriteNumber)
        {
            Console.WriteLine("too high");
        }
        else
        {
            Console.WriteLine("Nevermind");
        }

        Console.WriteLine("What is your favorite school subject?");
        string subjectInput = Console.ReadLine();

        switch (subjectInput)
        {
            case "Math":
                Console.WriteLine("Oh, Math! I like numbers too");
                break;

            case "Science":
                Console.WriteLine("Oh, Science! I like research too");
                break;

            case "English":
                Console.WriteLine("Oh, English! I like words too");
                break;

            case "History":
                Console.WriteLine("Oh, History! I like the past too");
                break;

            case "Choir":
                Console.WriteLine("Oh, Choir! I like singing too");
                break;

                default: 
                Console.WriteLine($"Oh, {subjectInput}! I like that one, I guess");
                break;
        }
    }
}