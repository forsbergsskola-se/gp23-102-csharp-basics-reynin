//Console asks for name
Console.WriteLine("What's your name?");

//A string type is created
//Console awaits user to write a name
//The input is now returned as a declared value for the string type
string? name = Console.ReadLine();

//Console prints out "Hello " and the users input
Console.WriteLine($"Hello, {name}!");