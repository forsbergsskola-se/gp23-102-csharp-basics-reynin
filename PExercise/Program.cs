//Exercise 1
void convertHourToSec()
{
    Console.WriteLine("Give me a number in km/h");
    string userInput = Console.ReadLine();
    float kmh = float.Parse(userInput);

    float ms = kmh / 60 / 60 * 1000;
    
    Console.WriteLine($"That is {ms} m/s!");
}

//Exercise 1
void convertMinToSec()
{
    Console.WriteLine("Give me a number as minutes");
    string inputNumber = Console.ReadLine();
    float conNumber = float.Parse(inputNumber);
    float y = conNumber * 60;
    
    Console.WriteLine($"That is {conNumber} seconds!");
}

//Exercise 2
void division()
{
    Console.WriteLine("Give me a number");
    string x = Console.ReadLine();
    int x1 = int.Parse(x);

    Console.WriteLine("Give me an another number");
    
    string y = Console.ReadLine();
    int y1 = int.Parse(y);

    float z = x1 / y1;

    Console.WriteLine($"The accurate result will be {z}");
}

//Exercise 3
void remainder()
{
    Console.WriteLine("Give me a number");
    string x = Console.ReadLine();
    int x1 = int.Parse(x);

    Console.WriteLine("Now give me an another number");

    string y = Console.ReadLine();
    int y1 = int.Parse(y);

    int z = x1 % y1;
    Console.WriteLine($"The remainder will be {z}");
}

//Exercise 4
void areaCircle()
{
    Console.WriteLine("Give me a number for a circles radius");
    
    string inputRadius = Console.ReadLine();
    float Radius = float.Parse((inputRadius));
    float area = Radius*Radius * Single.Pi;
    Console.WriteLine(area);
    
    Console.WriteLine($"The area of the circle is {area}!");
}

//Exercise 5
void negativ()
{
    Console.WriteLine("Give me a number");
    string input = Console.ReadLine();
    int x = int.Parse(input);
    int y = -x;
    
    Console.WriteLine($"The opposite number is {y}");
}

//Exercise 6
void multi()
{
    Console.WriteLine("Give me a number");
    
    string input = Console.ReadLine();
    int x = int.Parse(input);
    
    Console.WriteLine("Give me an another number to multiply with");

    string input1 = Console.ReadLine();
    int y = int.Parse(input);

    int z = x * y;
    
    Console.WriteLine($"The result is {z}!");
}

//Exercise 7
void bmi()
{   
    Console.WriteLine("What is your weight (kg)");

    string inputW = Console.ReadLine();
    int weight = int.Parse(inputW);
    
    Console.WriteLine("And how tall(m) are you?");
    
    string inputH = Console.ReadLine();
    int height = int.Parse(inputH);

    int bodyMass = weight / (height * height);
    
    Console.WriteLine($"Your BMI is: {bodyMass}");
}

//Exercise 8
void hypotenuse()
{
    Console.WriteLine("Give me a length (cm) of the vertical side of a right triangle");

    string input = Console.ReadLine();
    float wall = float.Parse(input);
    
    Console.WriteLine("Give me a width (cm) of the horizontal side of a right triangle");
    
    string input1 = Console.ReadLine();
    float floor = float.Parse(input1);

    float hypo = (wall * wall) + (floor + floor);
    
    Console.WriteLine($"The hypotenuse of the triangle is: {hypo}");
}

//Exercise 9
void secToMin()
{
    Console.WriteLine("Give me number as seconds");
    
    string input = Console.ReadLine();
    int seconds = int.Parse(input);

    float minutes = (float)seconds / 60;
    Console.WriteLine($"That is {minutes} minutes!");
}
void exer()
{

//Exercise
//Ask the user for an input in km/h
//Print the result of converting the value to m/s
    Console.WriteLine("Welcome to km/h to m/s converter.");
    Console.WriteLine("Please enter a value in km/h:");
    string userInput = Console.ReadLine();
    float userNumber = float.Parse(userInput);
    float x = userNumber / 60 / 60 * 1000; //If using int type, prioritise multiplication before division.
    Console.WriteLine($"That would be {x} m/s.");
}

//Bonus Exercise
void exer1()
{
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(--x*-1);
}
exer1();