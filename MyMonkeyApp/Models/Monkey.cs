namespace MyMonkeyApp.Models;

/// <summary>
/// Represents a monkey with its basic information including name, location, and population.
/// </summary>
public class Monkey
{
    /// <summary>
    /// Gets or sets the name of the monkey species.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the primary location where this monkey species is found.
    /// </summary>
    public string Location { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the estimated population of this monkey species.
    /// </summary>
    public int Population { get; set; }

    /// <summary>
    /// Gets or sets a fun fact about this monkey species.
    /// </summary>
    public string FunFact { get; set; } = string.Empty;

    /// <summary>
    /// Returns a string representation of the monkey.
    /// </summary>
    /// <returns>A formatted string with monkey information.</returns>
    public override string ToString()
    {
        return $"{Name} - {Location} (Population: {Population:N0})";
    }
}