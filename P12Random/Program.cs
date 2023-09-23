Console.WriteLine("Please pass me a seed (integer)");

Random random = new Random(int.Parse(Console.ReadLine()));

Console.WriteLine("Three integers between 0 and 5:");
Console.WriteLine(random.Next(5));
Console.WriteLine(random.Next(5));
Console.WriteLine(random.Next(5));

Console.WriteLine("Three numbers between 0.0 and 0.5:");
Console.WriteLine(random.NextDouble()); // or Console.WriteLine(random.NextDouble()*0.5
Console.WriteLine(random.NextDouble());
Console.WriteLine(random.NextDouble());

Console.WriteLine("Three numbers between 0.2 and 0.7:");
Console.WriteLine(random.NextDouble()*(0.5)+0.2);
Console.WriteLine(random.NextDouble()*(0.5)+0.2);
Console.WriteLine(random.NextDouble()*(0.5)+0.2);

Console.WriteLine("Give me a crit chance between 0,0 (0%) and 1,0 (100%)");
double chance = double.Parse(Console.ReadLine());

Console.WriteLine(random.NextDouble() < chance ? "Crit": "No crit"); //This is using with the same seed
Console.WriteLine(random.NextDouble() < chance ? "Crit": "No crit"); //If wish to use other random integers: Random.Shared.
Console.WriteLine(random.NextDouble() < chance ? "Crit": "No crit");
Console.WriteLine(random.NextDouble() < chance ? "Crit": "No crit");
Console.WriteLine(random.NextDouble() < chance ? "Crit": "No crit");