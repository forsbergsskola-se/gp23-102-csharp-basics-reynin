//Exercise 1
void convertHourToSec()
{   
    Console.WriteLine("Welcome to speed-converter!");
    Console.WriteLine("Please enter a number in km/h");
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

    float z = (float)x1 / y1;

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
    float area = Radius*Radius * Single.Pi; //Math.PI works as well
    
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
    float weight = float.Parse(inputW);
    
    Console.WriteLine("And how tall (m) are you?");
    
    string inputH = Console.ReadLine();
    float height = float.Parse(inputH);

    float bodyMass = weight / (height * height);
    
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

    float x = (wall * wall) + (floor + floor);
    float hypo = MathF.Sqrt(x);
    
    Console.WriteLine($"The hypotenuse of the triangle is: {hypo}");
}

//Exercise 9
void secToMin()
{
    Console.WriteLine("Give me number as seconds");

    int totalSeconds = int.Parse((Console.ReadLine()));

    float minutes = (float)totalSeconds / 60;
    float seconds = (float)totalSeconds % 60;
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

//Exercise P11_1
void alphabet ()
{
    Console.WriteLine("Give me a number");
    int input = int.Parse((Console.ReadLine()));

    string result = input < 60 ? "F" : input < 69 ? "D" : input < 79 ? "C" : input < 89 ? "B" : "A";
    
    Console.WriteLine($"That number represent {result}!");
}

//Exercise P11_2
void minMax()
{
    Console.WriteLine("Please input a number");
    int firstInput = int.Parse(Console.ReadLine());
    Console.WriteLine("Please input a second number");
    int secondInput = int.Parse(Console.ReadLine());
    Console.WriteLine("Please input a third number");
    int thirdInput = int.Parse(Console.ReadLine());

    int smallest = firstInput < secondInput && firstInput < thirdInput ? firstInput :
        secondInput < firstInput && secondInput < thirdInput ? secondInput : thirdInput;
    
    int biggest = firstInput > secondInput && firstInput > thirdInput ? firstInput :
        secondInput > firstInput && secondInput > thirdInput ? secondInput : thirdInput;
    
    Console.WriteLine($"{smallest}, {biggest}");
}

//Exercise P11_3
void characters()
{
    Console.WriteLine("Please input a single character");
    var inputCharacter = Console.ReadLine();
   
}

//Exercise P11_4
void Calculater()
{
    Console.WriteLine("Please enter your first number");
    int firstInput = int.Parse(Console.ReadLine());

    Console.WriteLine("What do you wish to do? Addition?\nSubtraction?\nMultiplication?\nDivision?");
    string opp = Console.ReadLine();
    
    Console.WriteLine("And with what second number?");
    int secondInput = int.Parse(Console.ReadLine());

    int result = opp == "Addition" ? firstInput + secondInput :
        opp == "Subtraction" ? firstInput - secondInput :
        opp == "Multiplication" ? firstInput * secondInput : 
        firstInput / secondInput;
    
    Console.WriteLine(result);
}

//Exercise P11_5

void evenOrOdd()
{

}

//Exercise

void simplification()
{
    // printing output
    Console.WriteLine("What's your age?");
    // console input && variable && type
    string ageInput = Console.ReadLine();
    // conversion && variable && type
    int age = int.Parse(ageInput);
    // conditional branching && boolean expressions && comparison operator
    if (age < 13)
    {
        Console.WriteLine("You are a child.");
    }
    else if (age <= 19)
    {
        Console.WriteLine("You are a teen.");
    }
    else
    {
        Console.WriteLine("You are an adult.");
    }

    Console.WriteLine("Give me another integer.");
    string numberInput = Console.ReadLine();
    int number = int.Parse(numberInput);

    // if.. else to assign higher number to max
    int maxNumber = age > number ? age : number;
    // have this code block only once, not twice,
    // without condition, using max variable
    Console.WriteLine($"The maximum is {maxNumber}.");

    if (number % 2 == 0)
    {
        Console.WriteLine("It's an even number.");
    }
    else
    {
        Console.WriteLine("It's an odd number.");
    }
}

//Exercise P12_1
void coordinates()
{
    Random random = new Random();
    
    int coordinateX = random.Next(0, 101);
    int coordinateY = random.Next(0, 101);
    
    Console.WriteLine($"The coordinates are {coordinateX}, {coordinateY}");
}


//Exercise P13_1
void Dollars()
{
    int userInput = int.Parse((Console.ReadLine()));
    int printCount = 0;
    repeat:
    printCount++;
    if (printCount <= userInput)
    {
        Console.Write("$");
        goto repeat;
    }
}


//Exercise P13_2
void triangleQuick() //Quick-Way,thanks Hugo!
{
    int userInput = int.Parse(Console.ReadLine());
    repeat:
    if (userInput > 0)
    {
        Console.WriteLine($"{new string('#', userInput)}");
        userInput--;
        goto repeat;
    }
}

void Triangle()
{
    int userInput = int.Parse(Console.ReadLine());
    int counter = userInput;
    newLine:
    repeat:
    if (counter > 0)
    {
        Console.Write("#");
        counter--;
        goto repeat;
    }
    if (counter == 0)
    {
        Console.Write("\n");
        userInput--;
        counter = userInput;
        goto newLine;
    }
}


//Exercise P13_3
void Pattern()
{
    int userInput = int.Parse(Console.ReadLine());
    int counter = userInput;
    repeat:
    if (userInput !=0)
    {
        repeat2: //Print-out line
        if (counter > 0)
        {
            Console.Write("#-");
            counter--;
            goto repeat2;
        }

        counter = userInput;
        userInput--;
        Console.Write("\n");
        goto repeat;
    }


}
Pattern();
