namespace Methods
{
    public class Methods
    {
        public string? GetUserName()
        {
            Console.WriteLine("Please enter your name");
            return Console.ReadLine();
        }

        public string GetUserWord()
        {
            Console.WriteLine("Please enter a word");
            return $"#{Console.ReadLine()}";
        }

        public string? GetUserNumberAsString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public string? GetUserWordWithArgument(string word)
        {
            Console.WriteLine($"Please enter a {word}");
            return Console.ReadLine();
        }

        public string GetUserFullName(string firstName, string lastName)
        {
            return $"{lastName}, {firstName}";
        }
        
        public string GetUserFullNameForTesting(string firstName, string lastName)
        {
            return $"{lastName.ToUpper()}, {firstName[0].ToString().ToUpper() + firstName.Substring(1).ToLower()}";
        }
    }
}
