Console.WriteLine("Welcome to Nim");
Console.WriteLine("Rules are: You may only draw up to 3 matches.");

int matches = 24; //Starting matches

Console.WriteLine("|||||||||||||||||||||||| (24)"); //Presenting total matches
Console.WriteLine("Player 1: How many matches do you want to draw?");

int playerDraw;

round:
playerDraw = int.Parse(Console.ReadLine());

if (matches == playerDraw) //Game Over if player loses
{
    Console.WriteLine("\nYou lose!");
    goto theEnd;
}
    
matches -= playerDraw;

int matchCount = 0;
displayMatches:
matchCount++;
if (matchCount <= matches) //The printout
{
    Console.Write("|");
    goto displayMatches;
}

Console.Write($" ({matches})\n");

int drawAI = Random.Shared.Next(1, 4);

Console.WriteLine($"Ai draws {drawAI} matches.");

matches -= drawAI;

matchCount = 0;
displayMatchesAi:
matchCount++;
if (matchCount <= matches) //The printout
{
    Console.Write("|");
    goto displayMatchesAi;
}

if (matches > 0)
{
    Console.Write($" ({matches})\n");
    goto round;
}

Console.WriteLine("\nAi lose!");//Game Over when ai loses
theEnd: ;
