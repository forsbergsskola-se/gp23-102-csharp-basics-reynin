int compNumber = Random.Shared.Next(1,101);

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
    if (compNumber < inputNumber)
    {
        Console.WriteLine("Nope! My number is Smaller!");
        goto Guess;
    }
    Console.WriteLine("That's the number! Well played!");
}
else
{
    Console.WriteLine("You Lose!");
}