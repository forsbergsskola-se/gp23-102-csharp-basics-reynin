Console.WriteLine("Welcome to Nim");
Console.WriteLine("Rules are: You may only draw up to 3 matches.");

int matches = 24; //Starting matches

Console.WriteLine("|||||||||||||||||||||||| (24)"); //Presenting total matches
Console.WriteLine("Player 1: How many matches do you want to draw?");

round:
tryAgain:

int playerDraw = int.Parse(Console.ReadLine());

if (playerDraw > matches)
{
    Console.WriteLine("You can't draw more than there is matches, try again!");
    goto tryAgain;
}

if (matches == playerDraw) //Game Over if player loses
{
    Console.WriteLine("\nYou drew the last match. You lose!");
    goto theEnd;
}

matches -= playerDraw; //Total matches left after players turn

int matchCount = 0; //The printout
displayMatches:
matchCount++;
if (matchCount <= matches)
{
    Console.Write("|");
    goto displayMatches;
}

Console.Write($" ({matches})\n");

//Ai's turn
    
int drawAI = matches % 4 == 0 ? 3 : matches % 2 != 0 ? 2 : 1; //With smarter AI; if ai is in certain position, it will try to put player in losing position (5, 9, 13, 17, 21)
                                                              //Basic way: int drawAI = Random.Shared.Next(1, 4);
    
Console.WriteLine($"Ai draws {drawAI} matches.");

matches -= drawAI;

matchCount = 0; //The printout
displayMatchesAi:
matchCount++;
if (matchCount <= matches)
{
    Console.Write("|");
    goto displayMatchesAi;
}

if (matches > 0) //Round starts anew
{
    Console.Write($" ({matches})\n"); //Total matches left after AI's turn
    goto round;
}

Console.WriteLine("\nAi drew the last match. Ai lose!"); //Game Over when ai loses
theEnd: ;