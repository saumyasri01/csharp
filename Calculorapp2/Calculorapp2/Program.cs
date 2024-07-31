using System;

class Program
{
    static void Main(string[] args)
    {
        string name = "Zachary";
        DateTime bday = new DateTime(1990, 5, 20);
        decimal pay = 69759.25m;

        // Basic formatting
        Console.WriteLine("V1- {0} was born on {1:dd-MM-yyyy} and earns {2:C}", name, bday, pay);
        Console.WriteLine($"V2- {name} was born on {bday:dd-MM-yyyy} and earns {pay:C}");

        // Additional formatting examples
        Console.WriteLine("\nAdditional Formatting Examples:");

        // Date formatting
        Console.WriteLine($"Long date: {bday:D}");
        Console.WriteLine($"Short date: {bday:d}");
        Console.WriteLine($"Custom date: {bday:MMM dd, yyyy}");

        // Number formatting
        Console.WriteLine($"Currency (invariant culture): {pay.ToString("C", System.Globalization.CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Number with 2 decimal places: {pay:N2}");
        Console.WriteLine($"Percentage: {(pay / 100000):P2}");

        // Padding and alignment
        Console.WriteLine($"{"Left",-10}|{" Center ",10}|{"Right",10}");

        // Custom numeric format
        Console.WriteLine($"Phone number: {8005551234:###-###-####}");

        // Enum formatting
        Console.WriteLine($"Day of week: {bday.DayOfWeek:G}");

        // TimeSpan formatting
        TimeSpan timeWorked = new TimeSpan(8, 30, 0);
        Console.WriteLine($"Time worked: {timeWorked:hh\\:mm}");
    }
}