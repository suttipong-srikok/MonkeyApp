using MyMonkeyApp.Models;

namespace MyMonkeyApp.Helpers;

/// <summary>
/// Static helper class for managing monkey data and operations.
/// </summary>
public static class MonkeyHelper
{
    private static readonly List<Monkey> _monkeys = new();
    private static readonly Random _random = new();

    /// <summary>
    /// Initializes the MonkeyHelper with sample monkey data.
    /// </summary>
    static MonkeyHelper()
    {
        InitializeSampleData();
    }

    /// <summary>
    /// Gets all monkeys in the collection.
    /// </summary>
    /// <returns>A read-only list of all monkeys.</returns>
    public static IReadOnlyList<Monkey> GetAllMonkeys()
    {
        return _monkeys.AsReadOnly();
    }

    /// <summary>
    /// Gets a monkey by its name.
    /// </summary>
    /// <param name="name">The name of the monkey to find.</param>
    /// <returns>The monkey if found, otherwise null.</returns>
    public static Monkey? GetMonkeyByName(string name)
    {
        return _monkeys.FirstOrDefault(m => 
            string.Equals(m.Name, name, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Gets a random monkey from the collection.
    /// </summary>
    /// <returns>A randomly selected monkey, or null if no monkeys exist.</returns>
    public static Monkey? GetRandomMonkey()
    {
        if (_monkeys.Count == 0) return null;
        
        int index = _random.Next(_monkeys.Count);
        return _monkeys[index];
    }

    /// <summary>
    /// Adds a new monkey to the collection.
    /// </summary>
    /// <param name="monkey">The monkey to add.</param>
    public static void AddMonkey(Monkey monkey)
    {
        if (monkey != null && !string.IsNullOrWhiteSpace(monkey.Name))
        {
            _monkeys.Add(monkey);
        }
    }

    /// <summary>
    /// Gets the total number of monkeys in the collection.
    /// </summary>
    /// <returns>The count of monkeys.</returns>
    public static int GetMonkeyCount()
    {
        return _monkeys.Count;
    }

    /// <summary>
    /// Gets a monkey by its index in the collection.
    /// </summary>
    /// <param name="index">The zero-based index of the monkey.</param>
    /// <returns>The monkey at the specified index, or null if index is out of range.</returns>
    public static Monkey? GetMonkeyByIndex(int index)
    {
        if (index >= 0 && index < _monkeys.Count)
        {
            return _monkeys[index];
        }
        return null;
    }

    /// <summary>
    /// Initializes the collection with sample monkey data.
    /// </summary>
    private static void InitializeSampleData()
    {
        _monkeys.AddRange(new[]
        {
            new Monkey
            {
                Name = "Chimpanzee",
                Location = "Central & West Africa",
                Population = 300000,
                FunFact = "Can learn sign language and use tools!"
            },
            new Monkey
            {
                Name = "Orangutan",
                Location = "Borneo & Sumatra",
                Population = 104000,
                FunFact = "They're the largest tree-dwelling mammals on Earth!"
            },
            new Monkey
            {
                Name = "Gorilla",
                Location = "Central Africa",
                Population = 100000,
                FunFact = "Despite their size, they're gentle giants who eat mostly plants!"
            },
            new Monkey
            {
                Name = "Baboon",
                Location = "Africa & Arabia",
                Population = 500000,
                FunFact = "They have colorful rumps that signal their social status!"
            },
            new Monkey
            {
                Name = "Macaque",
                Location = "Asia & North Africa",
                Population = 2500000,
                FunFact = "Some species enjoy hot springs to stay warm in winter!"
            },
            new Monkey
            {
                Name = "Capuchin",
                Location = "Central & South America",
                Population = 100000,
                FunFact = "They're so smart, they can be trained to help disabled people!"
            },
            new Monkey
            {
                Name = "Spider Monkey",
                Location = "Central & South America",
                Population = 250000,
                FunFact = "Their arms are longer than their bodies - perfect for swinging!"
            },
            new Monkey
            {
                Name = "Howler Monkey",
                Location = "Central & South America",
                Population = 200000,
                FunFact = "Their calls can be heard up to 3 miles away!"
            },
            new Monkey
            {
                Name = "Lemur",
                Location = "Madagascar",
                Population = 100000,
                FunFact = "They have a special tooth comb for grooming!"
            },
            new Monkey
            {
                Name = "Proboscis Monkey",
                Location = "Borneo",
                Population = 7000,
                FunFact = "Their big noses help amplify their calls and attract mates!"
            }
        });
    }
}