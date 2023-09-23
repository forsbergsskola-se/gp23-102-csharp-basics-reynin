Console.WriteLine("Give me a number.");
string? input = Console.ReadLine();
double i = double.Parse(input);
Console.WriteLine(i);
int i2 = (int)i;
Console.WriteLine(i2);
int i3 = Convert.ToInt32(input);
Console.WriteLine(i3);

//First: Try assigning it. Error?
//Second: Try casting it. Error?
//Third: Try parsing it. Eroor?
//Last Resort: Try converting it.

/* Another  way:
 
Console.WriteLine("Give me a number.");

string number = Console.ReadLine();

double dbl = double.Parse(number);
Console.WriteLine(dbl);

int sgl = (int)dbl;
Console.WriteLine(sgl);

int og = int.Parse(number);
Console.WriteLine(og)

*/