using System;

class Program
{
    static void Main(string[] args)
    {
        // Get test scores
        int[] scores = GetTestScores();

        // Calculate and display results
        int highest = GetHighestScore(scores);
        double average = GetAverageScore(scores);
        int lowest = GetLowestScore(scores);

        // Display results
        Console.WriteLine($"Highest score: {highest}");
        Console.WriteLine($"Average score: {average:F2}");
        Console.WriteLine($"Lowest score: {lowest}");
    }

    static int[] GetTestScores()
    {
        int[] scores = new int[6];
        for (int i = 0; i < 6; i++)
        {
            while (true)
            {
                Console.Write($"Enter test score {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int score) && score >= 0 && score <= 100)
                {
                    scores[i] = score;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a score between 0 and 100.");
                }
            }
        }
        return scores;
    }

    static int GetHighestScore(int[] scores)
    {
        int highest = scores[0];
        for (int i = 1; i < scores.Length; i++)
        {
            if (scores[i] > highest)
            {
                highest = scores[i];
            }
        }
        return highest;
    }

    static double GetAverageScore(int[] scores)
    {
        int sum = 0;
        foreach (int score in scores)
        {
            sum += score;
        }
        return (double)sum / scores.Length;
    }

    static int GetLowestScore(int[] scores)
    {
        int lowest = scores[0];
        for (int i = 1; i < scores.Length; i++)
        {
            if (scores[i] < lowest)
            {
                lowest = scores[i];
            }
        }
        return lowest;
    }
}