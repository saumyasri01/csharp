using System;

class Program
{
    static void Main(string[] args)
    {
        string encodedAddress = "Betty Smallwood|3329 Duchess|Erath, Texas";

        // Split the encoded address into its components
        string[] parts = encodedAddress.Split('|');

        // Extract name and address
        string name = parts[0];
        string address = parts[1];

        // Split the city and state
        string[] cityState = parts[2].Split(", ");
        string city = cityState[0];
        string state = cityState[1];

        // Display the extracted information
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Address: {address}");
        Console.WriteLine($"City: {city}");
        Console.WriteLine($"State: {state}");
    }
}