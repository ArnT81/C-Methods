string GetUserName()
{
    Console.WriteLine("Please enter your name");
    return Console.ReadLine();
}

string GetUserWord()
{
    Console.WriteLine("Please enter a word");
    return $"#{Console.ReadLine()}";
}

string getUserNumberAsString(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}

string getUserWordWithArgument(string word)
{
    Console.WriteLine($"Please enter a {word}");
    return Console.ReadLine();
}

string getUserFullName(string firstName, string lastName)
{
    return $"{lastName}, {firstName}";
}


Console.WriteLine($"You have entered the name {GetUserName()}"); // 1
Console.WriteLine(GetUserWord()); // 2
Console.WriteLine($"You have entered {getUserNumberAsString("Please enter a number")}"); // 3
Console.WriteLine($"You have entered {getUserWordWithArgument("number")}"); // 4
Console.WriteLine(getUserFullName("Anders", "Söderberg")); //5