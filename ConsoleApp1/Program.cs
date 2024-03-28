// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.IO;


//1. Write a C# program that reads a file path from the user and tries to open the file.
//Handle exceptions if the file does not exist.
Console.WriteLine("Item 1");
string line;
try
{
    StreamReader sr = new StreamReader("C:\\Sample.txt");
    line = sr.ReadLine();
    while (line != null)
    {
        Console.WriteLine(line);
        line = sr.ReadLine();
    }
    //close the file
    sr.Close();
    Console.ReadLine();
}
catch (Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}
finally
{
    Console.WriteLine("Executing finally block.");
}

//2. Write a C# program that prompts the user to input a numeric integer and throws an
//exception if the number is less than 0 or greater than 1000.
Console.WriteLine("Item 2");
Console.WriteLine("Enter a number between 0 and 1000");
string num = Console.ReadLine();
int number = int.Parse(num);
if (number > 1000 || number < 0)
    throw new Exception("Number is out of range");


//3. Write a C# program that implements a method that takes an array of integers as input
//and calculates the average value. Handle the exception if the array is empty.
Console.WriteLine("Item 3");
int ave(int[] arr)
{
    if (!arr.Any())
    {
        throw new Exception("Array is empty");
    }

    return (int)arr.Average();
}

// 4.
Console.WriteLine("Item 4");
Console.WriteLine("Enter a number");
string num1 = Console.ReadLine();
if (int.TryParse(num1, out int res))
{
    Console.WriteLine($"Your number is: {res}");
}

// 5.
Console.WriteLine("Item 5");
string input = string.Empty;
while (true)
{
    Console.WriteLine("Enter a number or q to quit");
    input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        Int32.Parse(input);
    }
    catch (OverflowException e)
    {
        Console.WriteLine("Input is too large: " + e.Message);
    }
}

// 6.
Console.WriteLine("Item 6");
int Divide(int a, int b)
{
    if (b == 0)
    {
        throw new DivideByZeroException();
    }

    return a / b;
}

// 7.
Console.WriteLine("Item 7");
Console.WriteLine("Enter a date(dd/mm/yyyy)");
GetDate();

void GetDate()
{
    string date = Console.ReadLine();
    try
    {
        DateTime.ParseExact(date, "dd/mm/yyyy", null);
    }
    catch (Exception e)
    {
        Console.WriteLine("Invalid date format: " + e.Message);
    }
}

// 8.
Console.WriteLine("Item 8");
Console.WriteLine("Enter a number: ");
string num2 = Console.ReadLine();
int number2 = int.Parse(num2);
Console.WriteLine($"the sqrt is: {MathF.Sqrt(number2)}");

// 9.
Console.WriteLine("Item 9");
ToUpper("dsdcsd");

string ToUpper(string? str)
{
    if (str is null)
    {
        throw new NullReferenceException("The string provided is empty");
    }

    return str.ToUpper();
}

// 10.
Console.WriteLine("Item 10");
Console.WriteLine($"{GetFactorial(123456790)}");

Int32 GetFactorial(int n)
{
    Int32 result = 1;
    try
    {
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        return result;

    }
    catch (OverflowException e)
    {
        Console.WriteLine("The given number exceeds the max allowable number for Int32. " + e.Message);
        return 0;
    }
}