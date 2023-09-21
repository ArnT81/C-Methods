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

        string OnlyFirstLetterCapitalized(string str)
        {
            return $"{str[0].ToString().ToUpper() + str.Substring(1).ToLower()}";
        }

        string CapitalizeFirstThreeLetters(string str)
        {
            return str.Substring(0, 3).ToUpper();
        }

        public string OptionalAssignmentFormatter(string firstName, string lastName)
        {
            string fnFormatted = OnlyFirstLetterCapitalized(firstName);
            string lnFormatted = OnlyFirstLetterCapitalized(lastName);
            string lnShort = CapitalizeFirstThreeLetters(lastName);
            string fnShort = CapitalizeFirstThreeLetters(firstName);

            return $"#_{lnFormatted}, " + $"{fnFormatted} ({lnShort + fnShort})";
        }
    }
}
