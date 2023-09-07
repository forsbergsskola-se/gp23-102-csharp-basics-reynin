Console.WriteLine("Give me a number of seconds");
string? input = Console.ReadLine();

float seconds = float.Parse(input);
float days = seconds / 60 / 60 / 24;

int iHour = (int)days * 24;
int iMinutes = iHour * 60;
int iSecond = iMinutes * 60;

Console.WriteLine($" Seconds: {seconds}\n Minutes: {iMinutes}\n Hour: {iHour}\n Days: {days}");


Console.WriteLine($"{days}.{iHour}:{iMinutes}:{iSecond}");
Console.WriteLine($"In total, that's {days} Days.");x