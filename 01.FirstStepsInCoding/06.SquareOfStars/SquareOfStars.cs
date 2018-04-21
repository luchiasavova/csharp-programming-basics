using System;

public class SquareOfStars
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        PrintUpperAndBottomLine(n);
        PrintMiddlePart(n);
        PrintUpperAndBottomLine(n);
    }

    private static void PrintMiddlePart(int n)
    {
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("*{0}*", new string(' ', n - 2));
        }

    }

    public static void PrintUpperAndBottomLine(int n)
    {
        Console.WriteLine(new string('*', n));
    }
}
