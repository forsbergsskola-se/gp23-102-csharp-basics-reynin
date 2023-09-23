Console.WriteLine("What's your age?");
int age = int.Parse(Console.ReadLine());

string result = age > 0 && age <= 12 ? "You are a child." : age <= 19 ? "You are a teenager." : "You are a grown-up.";

Console.WriteLine(result);

Console.WriteLine("Give me another integer.");
int inputNumber = int.Parse(Console.ReadLine());

int bigNumber = inputNumber > age ? inputNumber : age;
Console.WriteLine($"Your maximum number is: {bigNumber}");

string bigNumberR = bigNumber % 2 != 0 ? "Your number is an odd number" : "Your number is an even number";
Console.WriteLine(bigNumberR);