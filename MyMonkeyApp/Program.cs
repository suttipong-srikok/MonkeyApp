
using MyMonkeyApp;

namespace MyMonkeyApp;

internal class Program
{
    private static readonly string[] asciiArt = new[]
    {
        @"  (o o)\n (  V  )\n/--m-m-",
        @"   w  c( .. )o   ( - )\n    (  -  )     (  - )\n     (  - )     (  - )",
        @"   (o o)\n  (  V  )\n /--m-m-",
        @"   (o.o)\n  (   )\n  ("")_("")"
    };

    private static void Main()
    {
        var random = new Random();
        while (true)
        {
            // Display random ASCII art sometimes
            if (random.Next(0, 3) == 0)
            {
                Console.WriteLine();
                Console.WriteLine(asciiArt[random.Next(asciiArt.Length)]);
                Console.WriteLine();
            }

            Console.WriteLine("MonkeyApp Menu:");
            Console.WriteLine("1. List all monkeys");
            Console.WriteLine("2. Get details for a specific monkey by name");
            Console.WriteLine("3. Get a random monkey");
            Console.WriteLine("4. Exit app");
            Console.Write("Select an option (1-4): ");

            var userInput = Console.ReadLine();
            Console.WriteLine();

            switch (userInput)
            {
                case "1":
                    DisplayAllMonkeys();
                    break;
                case "2":
                    GetMonkeyByName();
                    break;
                case "3":
                    GetRandomMonkey();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.\n");
                    break;
            }
        }
    }

    private static void DisplayAllMonkeys()
    {
        var monkeys = MonkeyHelper.GetMonkeys();
        Console.WriteLine("| Name                 | Location                        | Population | Latitude, Longitude        |");
        Console.WriteLine("|----------------------|---------------------------------|------------|----------------------------|");
        foreach (var monkey in monkeys)
        {
            Console.WriteLine($"| {monkey.Name,-20} | {monkey.Location,-31} | {monkey.Population,10} | {monkey.Latitude,8:F6}, {monkey.Longitude,-10:F6} |");
        }
        Console.WriteLine();
    }

    private static void GetMonkeyByName()
    {
        Console.Write("Enter monkey name: ");
        var name = Console.ReadLine();
        var monkey = MonkeyHelper.GetMonkeyByName(name ?? string.Empty);
        if (monkey is not null)
        {
            Console.WriteLine($"Name: {monkey.Name}");
            Console.WriteLine($"Location: {monkey.Location}");
            Console.WriteLine($"Details: {monkey.Details}");
            Console.WriteLine($"Population: {monkey.Population}");
            Console.WriteLine($"Latitude, Longitude: {monkey.Latitude}, {monkey.Longitude}");
        }
        else
        {
            Console.WriteLine("Monkey not found.");
        }
        Console.WriteLine();
    }

    private static void GetRandomMonkey()
    {
        var monkey = MonkeyHelper.GetRandomMonkey();
        var accessCount = MonkeyHelper.GetRandomMonkeyAccessCount();
        Console.WriteLine($"Random monkey (accessed {accessCount} times):");
        Console.WriteLine($"Name: {monkey.Name}");
        Console.WriteLine($"Location: {monkey.Location}");
        Console.WriteLine($"Details: {monkey.Details}");
        Console.WriteLine($"Population: {monkey.Population}");
        Console.WriteLine($"Latitude, Longitude: {monkey.Latitude}, {monkey.Longitude}");
        Console.WriteLine();
    }
}
