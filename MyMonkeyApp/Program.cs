using MyMonkeyApp.Helpers;
using MyMonkeyApp.Models;
using MyMonkeyApp.Utilities;

namespace MyMonkeyApp;

/// <summary>
/// Main program class for the Monkey Console Application.
/// </summary>
public class Program
{
    /// <summary>
    /// Entry point for the application.
    /// </summary>
    public static async Task Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine(AsciiArt.GetBanner());
        
        // Show monkey of the day
        ShowMonkeyOfTheDay();
        
        // Main menu loop
        bool running = true;
        while (running)
        {
            DisplayMenu();
            
            var choice = Console.ReadLine()?.Trim();
            Console.WriteLine();
            
            switch (choice?.ToLower())
            {
                case "1":
                case "list":
                    await ListAllMonkeysAsync();
                    break;
                case "2":
                case "details":
                    ShowMonkeyDetails();
                    break;
                case "3":
                case "random":
                    await ShowRandomMonkeyAsync();
                    break;
                case "4":
                case "art":
                    ShowRandomArt();
                    break;
                case "5":
                case "count":
                    ShowMonkeyCount();
                    break;
                case "6":
                case "sounds":
                    PlayMonkeySounds();
                    break;
                case "0":
                case "exit":
                case "quit":
                    running = false;
                    ShowGoodbye();
                    break;
                default:
                    Console.WriteLine("🙈 Oops! That's not a valid choice. Try again!");
                    Console.WriteLine(AsciiArt.GetMonkeySound());
                    break;
            }
            
            if (running)
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    /// <summary>
    /// Displays the main menu options.
    /// </summary>
    private static void DisplayMenu()
    {
        Console.WriteLine(AsciiArt.GetSeparator());
        Console.WriteLine("🐒 MONKEY MENU - Choose your monkey adventure! 🐒");
        Console.WriteLine(AsciiArt.GetSeparator());
        Console.WriteLine();
        Console.WriteLine("1. 📋 List All Monkeys");
        Console.WriteLine("2. 🔍 View Monkey Details");
        Console.WriteLine("3. 🎲 Random Monkey Surprise");
        Console.WriteLine("4. 🎨 Random Monkey Art");
        Console.WriteLine("5. 📊 Monkey Count");
        Console.WriteLine("6. 🔊 Monkey Sounds");
        Console.WriteLine("0. 🚪 Exit");
        Console.WriteLine();
        Console.Write("Enter your choice (0-6): ");
    }

    /// <summary>
    /// Shows the monkey of the day with ASCII art.
    /// </summary>
    private static void ShowMonkeyOfTheDay()
    {
        var monkey = MonkeyHelper.GetRandomMonkey();
        if (monkey != null)
        {
            Console.WriteLine("🌟 MONKEY OF THE DAY 🌟");
            Console.WriteLine($"Today's featured monkey: {monkey.Name}");
            Console.WriteLine($"Fun Fact: {monkey.FunFact}");
            Console.WriteLine(AsciiArt.GetRandomMonkeyArt());
            Console.WriteLine(AsciiArt.GetMonkeySound());
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Lists all monkeys in a formatted display.
    /// </summary>
    private static async Task ListAllMonkeysAsync()
    {
        Console.WriteLine("🐒 ALL MONKEYS IN OUR COLLECTION 🐒");
        Console.WriteLine(AsciiArt.GetSeparator());
        Console.WriteLine();

        var monkeys = MonkeyHelper.GetAllMonkeys();
        
        for (int i = 0; i < monkeys.Count; i++)
        {
            var monkey = monkeys[i];
            Console.WriteLine($"{i + 1:D2}. {monkey}");
            
            // Add a small delay for dramatic effect
            await Task.Delay(100);
        }
        
        Console.WriteLine();
        Console.WriteLine($"Total monkeys: {monkeys.Count} 🐒");
        Console.WriteLine(AsciiArt.GetMonkeySound());
    }

    /// <summary>
    /// Shows detailed information for a specific monkey.
    /// </summary>
    private static void ShowMonkeyDetails()
    {
        Console.WriteLine("🔍 MONKEY DETAILS 🔍");
        Console.WriteLine("Choose a monkey to learn more about:");
        Console.WriteLine();

        var monkeys = MonkeyHelper.GetAllMonkeys();
        
        // Display numbered list
        for (int i = 0; i < monkeys.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {monkeys[i].Name}");
        }
        
        Console.WriteLine();
        Console.Write("Enter monkey number (1-" + monkeys.Count + "): ");
        
        if (int.TryParse(Console.ReadLine(), out int choice) && 
            choice >= 1 && choice <= monkeys.Count)
        {
            var monkey = monkeys[choice - 1];
            Console.WriteLine();
            Console.WriteLine(AsciiArt.GetSeparator());
            Console.WriteLine($"🐒 {monkey.Name.ToUpper()} 🐒");
            Console.WriteLine(AsciiArt.GetSeparator());
            Console.WriteLine();
            Console.WriteLine($"📍 Location: {monkey.Location}");
            Console.WriteLine($"👥 Population: {monkey.Population:N0}");
            Console.WriteLine($"💡 Fun Fact: {monkey.FunFact}");
            Console.WriteLine();
            Console.WriteLine(AsciiArt.GetRandomMonkeyArt());
            Console.WriteLine(AsciiArt.GetMonkeySound());
        }
        else
        {
            Console.WriteLine("🙈 Invalid choice! Please try again.");
        }
    }

    /// <summary>
    /// Shows a random monkey with ASCII art.
    /// </summary>
    private static async Task ShowRandomMonkeyAsync()
    {
        Console.WriteLine("🎲 RANDOM MONKEY SURPRISE! 🎲");
        Console.WriteLine("Picking a random monkey for you...");
        Console.WriteLine();
        
        // Add suspense with loading animation
        var loadingChars = new[] { "🐒", "🙈", "🙉", "🙊" };
        for (int i = 0; i < 8; i++)
        {
            Console.Write($"\rLoading {loadingChars[i % loadingChars.Length]}");
            await Task.Delay(200);
        }
        
        Console.WriteLine("\n");
        
        var monkey = MonkeyHelper.GetRandomMonkey();
        if (monkey != null)
        {
            Console.WriteLine(AsciiArt.GetSeparator());
            Console.WriteLine($"🎉 YOUR RANDOM MONKEY: {monkey.Name.ToUpper()} 🎉");
            Console.WriteLine(AsciiArt.GetSeparator());
            Console.WriteLine();
            Console.WriteLine($"📍 Location: {monkey.Location}");
            Console.WriteLine($"👥 Population: {monkey.Population:N0}");
            Console.WriteLine($"💡 Fun Fact: {monkey.FunFact}");
            Console.WriteLine();
            Console.WriteLine(AsciiArt.GetRandomMonkeyArt());
            Console.WriteLine(AsciiArt.GetMonkeySound());
        }
        else
        {
            Console.WriteLine("🙈 No monkeys found! This shouldn't happen!");
        }
    }

    /// <summary>
    /// Shows random monkey ASCII art.
    /// </summary>
    private static void ShowRandomArt()
    {
        Console.WriteLine("🎨 RANDOM MONKEY ART 🎨");
        Console.WriteLine();
        Console.WriteLine(AsciiArt.GetRandomMonkeyArt());
        Console.WriteLine(AsciiArt.GetMonkeySound());
    }

    /// <summary>
    /// Shows the total count of monkeys.
    /// </summary>
    private static void ShowMonkeyCount()
    {
        Console.WriteLine("📊 MONKEY STATISTICS 📊");
        Console.WriteLine();
        Console.WriteLine($"Total monkey species in our collection: {MonkeyHelper.GetMonkeyCount()} 🐒");
        
        var monkeys = MonkeyHelper.GetAllMonkeys();
        var totalPopulation = monkeys.Sum(m => m.Population);
        Console.WriteLine($"Combined population: {totalPopulation:N0} monkeys worldwide! 🌍");
        Console.WriteLine();
        Console.WriteLine(AsciiArt.GetRandomMonkeyArt());
    }

    /// <summary>
    /// Plays various monkey sound effects.
    /// </summary>
    private static void PlayMonkeySounds()
    {
        Console.WriteLine("🔊 MONKEY SOUNDS CONCERT 🔊");
        Console.WriteLine("Listen to our monkey choir!");
        Console.WriteLine();
        
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"🐒 {AsciiArt.GetMonkeySound()}");
            Thread.Sleep(500);
        }
        
        Console.WriteLine();
        Console.WriteLine("🎵 That's the end of our monkey concert! 🎵");
    }

    /// <summary>
    /// Shows goodbye message with ASCII art.
    /// </summary>
    private static void ShowGoodbye()
    {
        Console.WriteLine();
        Console.WriteLine("👋 Thanks for visiting the Monkey Console App! 👋");
        Console.WriteLine("Hope you had a wild time learning about monkeys! 🐒");
        Console.WriteLine();
        Console.WriteLine(AsciiArt.GetRandomMonkeyArt());
        Console.WriteLine("🍌 Come back soon for more monkey business! 🍌");
    }
}
