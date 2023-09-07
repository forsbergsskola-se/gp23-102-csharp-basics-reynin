Console.WriteLine("What's your age?");
int age = int.Parse(Console.ReadLine());

if (age > 0 && age <= 12)
{
    Console.WriteLine("You are a child.");
}
else if (age <= 19)
{
    Console.WriteLine("You are a teenager.");
}
else
{    
    Console.WriteLine("You are a grown-up.");
}

Console.WriteLine("Give me another integer.");
int inputNumber = int.Parse(Console.ReadLine());

int bigNumber = inputNumber > age ? inputNumber : age;
Console.WriteLine($"Your maximum number is: {bigNumber}");

string bigNumberR = bigNumber % 2 != 0 ? "Your number is an odd number" : "Your number is an even number";
Console.WriteLine(bigNumberR);