using System.Diagnostics;
using MyMonkeyApp.Models;

namespace MyMonkeyApp.Helpers;

/// <summary>
/// Provides in-memory monkey data and helper methods to query it.
/// </summary>
public static class MonkeyHelper
{
    private static readonly List<Monkey> _monkeys;
    private static readonly Random _rng = new();

    static MonkeyHelper()
    {
        _monkeys = new List<Monkey>
        {
            new Monkey { Name = "Baboon", Location = "Africa & Asia", Details = "Baboons are African and Arabian Old World monkeys.", Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/baboon.jpg", Population = 10000, Latitude = -8.783195, Longitude = 34.508523 },
            new Monkey { Name = "Capuchin Monkey", Location = "Central & South America", Details = "The capuchin monkeys are New World monkeys of the subfamily Cebinae.", Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/capuchin.jpg", Population = 23000, Latitude = 12.769013, Longitude = -85.602364 },
            new Monkey { Name = "Blue Monkey", Location = "Central and East Africa", Details = "The blue monkey or diademed monkey is a species of Old World monkey.", Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/bluemonkey.jpg", Population = 12000, Latitude = 1.957709, Longitude = 37.297204 },
            new Monkey { Name = "Squirrel Monkey", Location = "Central & South America", Details = "The squirrel monkeys are the New World monkeys of the genus Saimiri.", Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/saimiri.jpg", Population = 11000, Latitude = -8.783195, Longitude = -55.491477 },
            new Monkey { Name = "Golden Lion Tamarin", Location = "Brazil", Details = "The golden lion tamarin also known as the golden marmoset.", Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/tamarin.jpg", Population = 19000, Latitude = -14.235004, Longitude = -51.92528 },
            new Monkey { Name = "Howler Monkey", Location = "South America", Details = "Howler monkeys are among the largest of the New World monkeys.", Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/alouatta.jpg", Population = 8000, Latitude = -8.783195, Longitude = -55.491477 },
            new Monkey { Name = "Japanese Macaque", Location = "Japan", Details = "The Japanese macaque is a terrestrial Old World monkey species native to Japan.", Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/macasa.jpg", Population = 1000, Latitude = 36.204824, Longitude = 138.252924 },
            new Monkey { Name = "Mandrill", Location = "Southern Cameroon, Gabon, and Congo", Details = "The mandrill is a primate of the Old World monkey family.", Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/mandrill.jpg", Population = 17000, Latitude = 7.369722, Longitude = 12.354722 },
            new Monkey { Name = "Proboscis Monkey", Location = "Borneo", Details = "The proboscis monkey or long-nosed monkey is endemic to Borneo.", Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/borneo.jpg", Population = 15000, Latitude = 0.961883, Longitude = 114.55485 },
            new Monkey { Name = "Sebastian", Location = "Seattle", Details = "This little trouble maker lives in Seattle with James.", Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/sebastian.jpg", Population = 1, Latitude = 47.606209, Longitude = -122.332071 },
            new Monkey { Name = "Henry", Location = "Phoenix", Details = "An adorable Monkey who is traveling the world with Heather.", Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/henry.jpg", Population = 1, Latitude = 33.448377, Longitude = -112.074037 },
            new Monkey { Name = "Red-shanked douc", Location = "Vietnam", Details = "The red-shanked douc is a species of Old World monkey.", Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/douc.jpg", Population = 1300, Latitude = 16.111648, Longitude = 108.262122 },
            new Monkey { Name = "Mooch", Location = "Seattle", Details = "An adorable Monkey who is traveling the world with Heather.", Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/Mooch.PNG", Population = 1, Latitude = 47.608013, Longitude = -122.335167 }
        };
    }

    /// <summary>
    /// Returns all seeded monkeys.
    /// </summary>
    /// <returns>IEnumerable of <see cref="Monkey"/>.</returns>
    public static IEnumerable<Monkey> GetMonkeys() => _monkeys;

    /// <summary>
    /// Finds a monkey by case-insensitive exact name match.
    /// </summary>
    /// <param name="name">Name to search for.</param>
    /// <returns>The matching monkey or null.</returns>
    public static Monkey? GetMonkeyByName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            return null;

        return _monkeys.FirstOrDefault(m => string.Equals(m.Name, name.Trim(), StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Returns a random monkey from the collection. Throws InvalidOperationException if none are available.
    /// </summary>
    /// <returns>A random <see cref="Monkey"/>.</returns>
    public static Monkey GetRandomMonkey()
    {
        if (_monkeys.Count == 0)
            throw new InvalidOperationException("No monkeys are available.");

        var index = _rng.Next(0, _monkeys.Count);
        return _monkeys[index];
    }
}
