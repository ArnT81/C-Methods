//using Methods;
var methods = new Methods.Methods();


Console.WriteLine($"You have entered the name {methods.GetUserName()}"); // 1
Console.WriteLine(methods.GetUserWord()); // 2
Console.WriteLine($"You have entered {methods.GetUserNumberAsString("Please enter a number")}"); // 3
Console.WriteLine($"You have entered {methods.GetUserWordWithArgument("number")}"); // 4
Console.WriteLine(methods.GetUserFullName("Anders", "Söderberg")); //5