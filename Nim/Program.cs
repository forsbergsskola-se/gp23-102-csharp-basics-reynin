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
Random random = new Random();
impossible:
int drawAI = random.Next(1, 4);
    
if (drawAI > matches)
{
    goto impossible;
}
Console.WriteLine($"Ai draws {drawAI} matches.");
if (matches == drawAI) //Game Over when ai loses
{
    Console.WriteLine("\nAi lose!");
    goto theEnd;
}

matches -= drawAI;

matchCount = 0;
displayMatchesAi:
matchCount++;

if (matchCount <= matches) //The printout
{
    Console.Write("|");
    goto displayMatchesAi;
}

Console.Write($" ({matches})\n");
if (matches > 0)
{
    goto round;   
}
theEnd: ;
