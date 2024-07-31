using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter your name: ");
                string? name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Name cannot be empty. Please try again.");
                    i--; // Decrement i to retry this iteration
                    continue;
                }

                Console.Write("How old will you be on 31-December this year? ");
                if (!int.TryParse(Console.ReadLine(), out int age))
                {
                    Console.WriteLine("Invalid age input. Please enter a number.");
                    i--; // Decrement i to retry this iteration
                    continue;
                }

                int birthYear = GetBirthYear(age);

                Console.WriteLine($"{name} was born in {birthYear}");

                if (i < 2)
                {
                    Console.Write("Do you want to enter another (yes/no)? ");
                    string? response = Console.ReadLine()?.ToLower();
                    if (response != "yes")
                    {
                        return;
                    }
                }
            }

            Console.Write("Do you want to enter another (yes/no)? ");
            string? finalResponse = Console.ReadLine()?.ToLower();
            if (finalResponse != "yes")
            {
                break;
            }
        }
    }

    static int GetBirthYear(int ageOnDecember31)
    {
        int currentYear = DateTime.Now.Year;
        return currentYear - ageOnDecember31;
    }
}