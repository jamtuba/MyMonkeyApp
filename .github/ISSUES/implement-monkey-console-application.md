---
name: "Implement Monkey Console Application"
about: "Create a small C# console app to manage and display monkey data"
title: "Implement Monkey Console Application"
labels: ["enhancement", "good first issue"]
assignees: []
---

# Implement Monkey Console Application

Create a C# console application (inside the existing MyMonkeyApp project) that can:

- List all available monkeys
- Get details for a specific monkey by name
- Pick a random monkey

The app should use a `Monkey` model class and include simple ASCII art for visual appeal when displaying a monkey.

Why this is useful
- Provides an interactive demo of the project's domain model
- Good starter task for contributors to get familiar with the repo structure and C# console coding standards

Requirements / Acceptance criteria
- Add a `Monkey` model with at least the following properties: `Name` (string), `Location` (string), `Population` (int)
- Add a static helper class (e.g. `MonkeyHelper`) that exposes at minimum:
  - `GetMonkeys()` -> IEnumerable<Monkey>
  - `GetMonkeyByName(string name)` -> Monkey? (case-insensitive search)
  - `GetRandomMonkey()` -> Monkey
- Update `Program.cs` to provide a simple interactive menu (text-based) offering these commands:
  - `list` — prints the list of monkey names
  - `show <name>` — prints the monkey details with ASCII art
  - `random` — shows a randomly selected monkey with ASCII art
  - `exit` — quits the app
- Include XML documentation on public classes/methods and follow the C# coding standards in the repository (PascalCase, file-scoped namespaces, use `var` when obvious, etc.)
- Add simple error handling for unknown names and empty lists

Suggested file structure (inside the `MyMonkeyApp` project)
- `Models/Monkey.cs` — model class
- `Helpers/MonkeyHelper.cs` — static helper to return seeded data and helper methods
- `Program.cs` — menu UI wired to helper methods (small and focused)

Design notes and small contract
- Inputs: user text commands from console
- Outputs: console text, formatted monkey data, ASCII art
- Error modes: unknown command, monkey not found — show friendly messages and help text

Edge cases to consider
- Searching for a name that does not exist
- Empty monkey collection (seed at least 5 to avoid this in normal runs)
- Name collisions or partial matching (require exact name match but case-insensitive)

Implementation checklist
- [ ] Create `Models/Monkey.cs` model class
- [ ] Create `Helpers/MonkeyHelper.cs` with seeded data and the three methods (`GetMonkeys`, `GetMonkeyByName`, `GetRandomMonkey`)
- [ ] Update `Program.cs` to add interactive menu and wire commands
- [ ] Add ASCII art templates and include them when printing monkey details
- [ ] Add XML docs and make sure coding standards are followed
- [ ] Run and verify console app works locally

Minimal example of Monkey ASCII art (use when printing details):

    (\_/)
    (O.o)
    /|_|\  Monkey: {Name}
           Location: {Location}
           Population: {Population}

Implementation steps (detailed)
1. Add `Models/Monkey.cs`:
   - Simple POCO with Name, Location, Population and XML docs.
2. Add `Helpers/MonkeyHelper.cs`:
   - Seed a small in-memory list of 5-8 monkeys.
   - Implement `GetMonkeys()`, `GetMonkeyByName(string)`, `GetRandomMonkey()`.
3. Update `Program.cs`:
   - Add a loop-based menu parsing user input and calling helper methods.
   - Use `Console.WriteLine` to render ASCII art and data.
4. Validate:
   - Build the project and run locally to verify commands — `list`, `show`, `random`, `exit`.

Notes for contributors
- Keep changes small and focused. This is an ideal first PR.
- Follow repository conventions in `.github/copilot-instructions.md` for C# style.

If you'd like, I can implement the model, helper, and Program.cs changes in a follow-up PR or patch.

---

If you want me to create a live GitHub Issue (instead of a local markdown file), reply and I'll open it on GitHub using your repo permissions.
