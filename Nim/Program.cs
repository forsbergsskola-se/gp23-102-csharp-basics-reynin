void basicNim()
{
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

    int drawAI = Random.Shared.Next(1, 4); //Ai's turn
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
}

//With smarter ai
//If total matches is odd, ai picks even, and vice versa
void smartAiNim()
{
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
    
    int drawAI = playerDraw == 1 ? 3 : playerDraw == 2 ? 2 : 1; //SmartAI turn

    if (matches == 11 || matches == 10 || matches == 10)
    {
        drawAI = 1;
    }
    else if (matches <= 8)
    {
        if (playerDraw == 1)
        {
            drawAI = 2;
        } 
        else if(playerDraw == 2)
        {
            drawAI = 1;
        }
    }
    // 1 2 3 4 5 6 7 8 9 10 11 12
    
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
}
smartAiNim();