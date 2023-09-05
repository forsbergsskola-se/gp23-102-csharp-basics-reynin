Console.WriteLine("Give me a number.");
string? input = Console.ReadLine();
double i = double.Parse(input);
Console.WriteLine(i);
int i2 = (int)i;
Console.WriteLine(i2);
int i3 = Convert.ToInt32(input);
Console.WriteLine(i3);