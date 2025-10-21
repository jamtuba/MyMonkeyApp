using MyMonkeyApp.Helpers;
using System.Globalization;

static void ShowMonkeyDetails(MyMonkeyApp.Models.Monkey monkey)
{
	// Simple ASCII art header
	Console.WriteLine();
	Console.WriteLine("  (\\_/)   \u001b[1;33mMonkey Details\u001b[0m");
	Console.WriteLine("  (O.O)   ---------------------------");
	Console.WriteLine("  /|_|\\");
	Console.WriteLine();

	Console.WriteLine($"Name      : {monkey.Name}");
	Console.WriteLine($"Location  : {monkey.Location}");
	Console.WriteLine($"Details   : {monkey.Details}");
	Console.WriteLine($"Image URL : {monkey.Image}");
	Console.WriteLine($"Population: {monkey.Population:N0}");

	if (monkey.Latitude.HasValue && monkey.Longitude.HasValue)
	{
		Console.WriteLine($"Latitude  : {monkey.Latitude.Value.ToString(CultureInfo.InvariantCulture)}");
		Console.WriteLine($"Longitude : {monkey.Longitude.Value.ToString(CultureInfo.InvariantCulture)}");
	}

	Console.WriteLine();
}

Console.WriteLine("Random Monkey Explorer\n");

while (true)
{
	var monkey = MonkeyHelper.GetRandomMonkey();
	ShowMonkeyDetails(monkey);

	Console.WriteLine("Options: [n]ext random, [q]uit");
	Console.Write("Choose an option: ");
	var input = Console.ReadLine()?.Trim().ToLowerInvariant();

	if (string.IsNullOrEmpty(input))
		continue;

	if (input == "q" || input == "quit" || input == "exit")
	{
		Console.WriteLine("Goodbye!");
		break;
	}

	// any other input (including 'n' or Enter) will pick another monkey
	Console.Clear();
}

