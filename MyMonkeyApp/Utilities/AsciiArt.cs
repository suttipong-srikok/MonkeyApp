namespace MyMonkeyApp.Utilities;

/// <summary>
/// Provides ASCII art and visual elements for the monkey application.
/// </summary>
public static class AsciiArt
{
    /// <summary>
    /// Gets a random monkey ASCII art.
    /// </summary>
    /// <returns>A string containing ASCII art of a monkey.</returns>
    public static string GetRandomMonkeyArt()
    {
        var arts = new[]
        {
            GetHappyMonkey(),
            GetCuriousMonkey(),
            GetPlayfulMonkey(),
            GetWisdomMonkey()
        };

        var random = new Random();
        return arts[random.Next(arts.Length)];
    }

    /// <summary>
    /// Gets the application banner with monkey ASCII art.
    /// </summary>
    /// <returns>A string containing the application banner.</returns>
    public static string GetBanner()
    {
        return @"
╔══════════════════════════════════════════════════════════════╗
║                    🐒 MONKEY CONSOLE APP 🐒                   ║
║              Welcome to the Wild World of Monkeys!          ║
╚══════════════════════════════════════════════════════════════╝
" + GetHappyMonkey();
    }

    /// <summary>
    /// Gets a happy monkey ASCII art.
    /// </summary>
    /// <returns>ASCII art of a happy monkey.</returns>
    public static string GetHappyMonkey()
    {
        return @"
        .-""-.
       /     \
      | () () |
       \  ^  /
        |||||
        |||||
     Ooh ooh aah aah!
";
    }

    /// <summary>
    /// Gets a curious monkey ASCII art.
    /// </summary>
    /// <returns>ASCII art of a curious monkey.</returns>
    public static string GetCuriousMonkey()
    {
        return @"
       .-.-.
      (  o  )
       > ^ <
      /|||||\ 
      ||||||
      ||||||
    What's that?
";
    }

    /// <summary>
    /// Gets a playful monkey ASCII art.
    /// </summary>
    /// <returns>ASCII art of a playful monkey.</returns>
    public static string GetPlayfulMonkey()
    {
        return @"
      \    o  /
       \  |  /
        \\_|_//
         (^_^)
         /|||||\
        ||||||
      Let's play!
";
    }

    /// <summary>
    /// Gets a wise monkey ASCII art.
    /// </summary>
    /// <returns>ASCII art of a wise monkey.</returns>
    public static string GetWisdomMonkey()
    {
        return @"
        .---.
       /     \
      | -   - |
       \  _  /
        |||||
        |||||
     Monkey wisdom!
";
    }

    /// <summary>
    /// Gets separator line with monkey emojis.
    /// </summary>
    /// <returns>A decorative separator line.</returns>
    public static string GetSeparator()
    {
        return "🐒═══════════════════════════════════════════════════════════════🐒";
    }

    /// <summary>
    /// Gets monkey sound effects.
    /// </summary>
    /// <returns>Random monkey sound effect.</returns>
    public static string GetMonkeySound()
    {
        var sounds = new[]
        {
            "Ooh ooh aah aah!",
            "Eek eek eek!",
            "Hoo hoo haa haa!",
            "Ook ook!",
            "Chattering sounds... 🐒",
            "Monkey business! 🍌"
        };

        var random = new Random();
        return sounds[random.Next(sounds.Length)];
    }
}