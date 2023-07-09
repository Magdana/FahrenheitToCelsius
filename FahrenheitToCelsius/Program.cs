using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a temperature in Fahrenheit ");
        string input = Console.ReadLine();
        double fahr;

        if (double.TryParse(input, out fahr))
            {
            double cels = 5.0 / 9.0 * (fahr - 32.0);
            Console.WriteLine("Equivalent temperature in Celsius is " + cels);
        }
        else
        {
            Console.WriteLine("Conversion failed. Invalid input, enter correct value.");
        }

        
    }
}