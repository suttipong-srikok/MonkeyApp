# MyMonkeyApp

MyMonkeyApp is a .NET 9 console application written in C# 13 for managing monkey species data and integrating with GitHub via MCP servers.

## Features
- Interactive console menu for managing monkey data
- Static helper class for monkey data operations
- Model classes for monkey species representation
- Separation of concerns between UI and business logic
- Repository pattern for data access
- GitHub integration via MCP servers

## Project Structure
```
MonkeyApp.sln
MyMonkeyApp/
  Monkey.cs
  MonkeyHelper.cs
  MyMonkeyApp.csproj
  Program.cs
```

## Coding Standards
- PascalCase for classes, methods, and properties
- camelCase for local variables and parameters
- Descriptive naming for clarity
- XML documentation for public methods and classes
- Use `var` for obvious local types, explicit types for readability
- Async/await for asynchronous operations
- Proper exception handling with try-catch
- Implement IDisposable for resource management
- Nullable reference types enabled
- File-scoped namespaces

## Naming Conventions
- Classes: `MonkeyHelper`, `Monkey`, `Program`
- Methods: `GetMonkeys()`, `GetRandomMonkey()`, `GetMonkeyByName()`
- Properties: `Name`, `Location`, `Population`
- Variables: `selectedMonkey`, `monkeyCount`, `userInput`
- Constants: `MAX_MONKEYS`, `DEFAULT_POPULATION`

## Getting Started
1. **Prerequisites:**
   - .NET 9 SDK
2. **Build and Run:**
   - Open a terminal in the project root
   - Run: `dotnet run --project MyMonkeyApp`

## GitHub Integration
This project is hosted at [MonkeyApp on GitHub](https://github.com/suttipong-srikok/MonkeyApp).

## License
MIT License
