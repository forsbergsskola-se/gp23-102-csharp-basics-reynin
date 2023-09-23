Console.WriteLine("What's your age?");
int age = int.Parse(Console.ReadLine());

bool isChild = age < 12;
bool isTeenager = 13 < age && age < 19;
bool isAdult = age > 19;

Console.WriteLine("You are a child: "+ isChild);
Console.WriteLine("You are a child: "+ isTeenager);
Console.WriteLine("You are a child: "+ isAdult);