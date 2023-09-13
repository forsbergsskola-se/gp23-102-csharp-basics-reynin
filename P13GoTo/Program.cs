Random random = new Random();

int compNumber = random.Next(1,101);

Console.WriteLine("I have picked a number (1-100). It's your turn to guess it!");

Guess:

int inputNumber = int.Parse(Console.ReadLine());

if (compNumber > inputNumber)
{
    Console.WriteLine("Nope! My number is Greater!");
    goto Guess;
}
else if(compNumber < inputNumber)
{
    Console.WriteLine("Nope! My number is Smaller!");
    goto Guess;
}
else
{
    Console.WriteLine("Output: That's the number! Well played!");
}