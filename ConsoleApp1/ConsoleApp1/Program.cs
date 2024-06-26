// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

using ConsoleApp1;


Console.WriteLine("Please enter your favorite color:");
string favoriteColor = Console.ReadLine();


Console.WriteLine("Please enter your astrology sign:");
string astrologySign = Console.ReadLine();


Console.WriteLine("Please enter your street address number:");
string streetAddressNumber = Console.ReadLine();


string hackerName = favoriteColor + astrologySign + streetAddressNumber;
Console.WriteLine($"Your hacker name is {hackerName}.");

UnderstandingTypes ut = new UnderstandingTypes();
ut.TypeInfo();
Console.WriteLine("------------------------------------------------------------------------------");
ut.ConvertCenturies(1);
ut.ConvertCenturies(5);
double a = 0;
Console.WriteLine(a/0);
Console.WriteLine("------------------------------------------------------------------------------");

Exercise03 fb = new Exercise03();
fb.FizzBuzz();
Console.WriteLine("------------------------------------------------------------------------------");
fb.Check();
Console.WriteLine("------------------------------------------------------------------------------");

RandomBetween1and3 random = new RandomBetween1and3();
random.RandomGenerator();

Console.WriteLine("------------------------------------------------------------------------------");

Pyramid p = new Pyramid();
p.PrintPyramid();

Console.WriteLine("------------------------------------------------------------------------------");

BirthDateCalculator bd = new BirthDateCalculator();
bd.BirthDate();
Console.WriteLine("------------------------------------------------------------------------------");

Greetings greetings = new Greetings();
greetings.Greet();
Console.WriteLine("------------------------------------------------------------------------------");

CountTwentyFour ctf = new CountTwentyFour(); 
ctf.Count();
    
