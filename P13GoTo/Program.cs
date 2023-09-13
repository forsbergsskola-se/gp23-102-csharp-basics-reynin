Random random = new Random();

int compNumber = random.Next(1,101);

Console.WriteLine("I have picked a number (1-100). It's your turn to guess it!");
Console.WriteLine("You don't need more than 7 guesses.");
Console.WriteLine("You lose after 10 guesses.");

int tryCounter = 0;
Guess:
tryCounter++;

int inputNumber = int.Parse(Console.ReadLine());

if (tryCounter < 10)
{

    if (compNumber > inputNumber)
    {
        Console.WriteLine("Nope! My number is Greater!");
        goto Guess;
    }
    else if (compNumber < inputNumber)
    {
        Console.WriteLine("Nope! My number is Smaller!");
        goto Guess;
    }
    else
    {
        Console.WriteLine("Output: That's the number! Well played!");
    }
}
else
{
    Console.WriteLine("You Lose!");
}