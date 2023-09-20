string? GetUserName()
{
    Console.WriteLine("Please enter your name");
    return Console.ReadLine();
}

string GetUserWord()
{
    Console.WriteLine("Please enter a word");
    return $"#{Console.ReadLine()}";
}

string? GetUserNumberAsString(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}

string? GetUserWordWithArgument(string word)
{
    Console.WriteLine($"Please enter a {word}");
    return Console.ReadLine();
}

string GetUserFullName(string firstName, string lastName)
{
    return $"{lastName}, {firstName}";
}


Console.WriteLine($"You have entered the name {GetUserName()}"); // 1
Console.WriteLine(GetUserWord()); // 2
Console.WriteLine($"You have entered {GetUserNumberAsString("Please enter a number")}"); // 3
Console.WriteLine($"You have entered {GetUserWordWithArgument("number")}"); // 4
Console.WriteLine(GetUserFullName("Anders", "Söderberg")); //5