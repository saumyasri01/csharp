using System;

class Program
{
    static void Main(string[] args)
    {
        // Integer calculations
        Console.WriteLine("Integer Calculations:");
        Console.Write("Enter the first integer: ");
        int int1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int int2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Sum: {int1 + int2}");
        Console.WriteLine($"Difference: {int1 - int2}");
        Console.WriteLine($"Product: {int1 * int2}");
        Console.WriteLine($"Quotient: {(double)int1 / int2}");

        Console.WriteLine();

        // Double calculations
        Console.WriteLine("Double Calculations:");
        Console.Write("Enter the first double: ");
        double double1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second double: ");
        double double2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Sum: {double1 + double2}");
        Console.WriteLine($"Difference: {double1 - double2}");
        Console.WriteLine($"Product: {double1 * double2}");
        Console.WriteLine($"Quotient: {double1 / double2}");
    }
}