namespace MyMonkeyApp.Models;

/// <summary>
/// Represents a monkey with basic information returned by MonkeyMCP.
/// </summary>
public sealed class Monkey
{
    /// <summary>
    /// Gets or sets the monkey's common name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the location or range where the monkey is found.
    /// </summary>
    public string Location { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets a short details or description about the monkey.
    /// </summary>
    public string? Details { get; set; }

    /// <summary>
    /// Gets or sets an optional image URL for the monkey.
    /// </summary>
    public string? Image { get; set; }

    /// <summary>
    /// Gets or sets the estimated population for this monkey type.
    /// </summary>
    public int Population { get; set; }

    /// <summary>
    /// Gets or sets the latitude (if available) associated with the monkey.
    /// </summary>
    public double? Latitude { get; set; }

    /// <summary>
    /// Gets or sets the longitude (if available) associated with the monkey.
    /// </summary>
    public double? Longitude { get; set; }
}
