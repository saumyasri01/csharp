using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> movies = new List<string>();

        // Input movies
        while (true)
        {
            Console.Write("Enter a movie title (or press Enter to finish): ");
            string? movie = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(movie))
                break;
            movies.Add(movie);
        }

        // Sort the list
        movies.Sort(StringComparer.OrdinalIgnoreCase);

        Console.WriteLine("\nYour sorted movie list:");
        foreach (var movie in movies)
        {
            Console.WriteLine(movie);
        }

        // Search functionality
        while (true)
        {
            Console.Write("\nDo you want to search for a movie? (yes/no): ");
            if (Console.ReadLine()?.ToLower() != "yes")
                break;

            Console.Write("Enter 'P' for Partial Search or 'E' for Exact Search: ");
            string? searchType = Console.ReadLine()?.ToUpper();

            Console.Write("Enter your search term: ");
            string? searchTerm = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                Console.WriteLine("Search term cannot be empty.");
                continue;
            }

            if (searchType == "P")
            {
                var results = movies.Where(m => m.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                if (results.Count > 0)
                {
                    Console.WriteLine("Matching movies:");
                    foreach (var result in results)
                    {
                        Console.WriteLine(result);
                    }
                }
                else
                {
                    Console.WriteLine("No matches found.");
                }
            }
            else if (searchType == "E")
            {
                bool found = movies.Any(m => m.Equals(searchTerm, StringComparison.OrdinalIgnoreCase));
                Console.WriteLine(found ? "Movie found!" : "Movie not found.");
            }
            else
            {
                Console.WriteLine("Invalid search type.");
            }
        }

        Console.WriteLine("Thank you for using FavoriteMovies!");
    }
}