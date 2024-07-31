using System;

class Program
{
    static void Main(string[] args)
    {
        // Create three instances of SportsPlayer
        SportsPlayer player1 = new SportsPlayer("LeBron James", "Basketball", 20, 203, 113);
        SportsPlayer player2 = new SportsPlayer("Lionel Messi", "Soccer", 17, 170, 72);
        SportsPlayer player3 = new SportsPlayer("Serena Williams", "Tennis", 25, 175, 72);

        // Call methods on each player
        player1.PrintInfo();
        player1.Train(5);

        player2.PrintInfo();
        player2.Train(3);

        player3.PrintInfo();
        player3.Train(7);
    }
}

class SportsPlayer
{
    // Properties
    public string Name { get; set; }
    public string Sport { get; set; }
    public int YearsExperience { get; set; }
    public int Height { get; set; } // in cm
    public int Weight { get; set; } // in kg

    // Constructor
    public SportsPlayer(string name, string sport, int yearsExperience, int height, int weight)
    {
        Name = name;
        Sport = sport;
        YearsExperience = yearsExperience;
        Height = height;
        Weight = weight;
    }

    // Method to print player information
    public void PrintInfo()
    {
        Console.WriteLine($"Player: {Name}");
        Console.WriteLine($"Sport: {Sport}");
        Console.WriteLine($"Years of Experience: {YearsExperience}");
        Console.WriteLine($"Height: {Height} cm");
        Console.WriteLine($"Weight: {Weight} kg");
        Console.WriteLine();
    }

    // Method to simulate training
    public void Train(int hours)
    {
        Console.WriteLine($"{Name} trained for {hours} hours.");
        YearsExperience += hours / 1000; // Assume 1000 hours of training equals 1 year of experience
        Console.WriteLine($"New years of experience: {YearsExperience}");
        Console.WriteLine();
    }
}
