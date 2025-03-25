using System;

class Program
{
    static void Main()
    {
        // Read input and split into X, Y, N
        string[] input = Console.ReadLine().Split();
        int X = int.Parse(input[0]);
        int Y = int.Parse(input[1]);
        int N = int.Parse(input[2]);

        // Loop from 1 to N
        for (int i = 1; i <= N; i++)
        {
            if (i % X == 0 && i % Y == 0) // Divisible by both X and Y?
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % X == 0) // Divisible by X?
            {
                Console.WriteLine("Fizz");
            }
            else if (i % Y == 0) // Divisible by Y?
            {
                Console.WriteLine("Buzz");
            }
            else // Otherwise, print the number
            {
                Console.WriteLine(i);
            }
        }
    }
}