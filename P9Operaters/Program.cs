Console.WriteLine("Give me a number of seconds");
string? input = Console.ReadLine();
float seconds = float.Parse(input);

int iSeconds = (int)seconds % 60; //For print-out in seconds, without counting above
float minutes = seconds / 60;

int iMinutes = (int)minutes % 60; //For print-out in minutes, without counting above
float hour = minutes / 60;

int iHour = (int)hour % 24; //For print-out in hours, without counting above
float days = hour / 24;

int iDays = (int)days;

Console.WriteLine($" Seconds: {iSeconds}\n Minutes: {iMinutes}\n Hour: {iHour}\n Days: {iDays}");
Console.WriteLine($"{iDays}.{iHour}:{iMinutes}:{iSeconds}");
Console.WriteLine($"In total, that's {days} Days.");