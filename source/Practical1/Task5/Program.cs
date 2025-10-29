using System;
using System.Text;

namespace Task5;


public class Program
{
    public static double GetAverage(int[] marks)
    {
        if (marks.Length == 0) return 0;
        double sum = 0;
        foreach (int mark in marks)
            sum += mark;
        return sum / marks.Length;
    }

    public static int GetMin(int[] marks)
    {
        int min = marks[0];
        foreach (int mark in marks)
            if (mark < min) min = mark;
        return min;
    }

    public static int GetMax(int[] marks)
    {
        int max = marks[0];
        foreach (int mark in marks)
            if (mark > max) max = mark;
        return max;
    }

    public static void PrintGroupStatistics(int[][] groups)
    {
        for (int i = 0; i < groups.Length; i++)
        {
            double avg = GetAverage(groups[i]);
            int min = GetMin(groups[i]);
            int max = GetMax(groups[i]);
            Console.WriteLine($"Група {i + 1}: Середній = {avg:F0}, Мінімальний = {min}, Максимальний = {max}");
        }
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int[][] groups = new int[][]
        {
            new int[] { 100, 90, 80, 70, 60, 85, 95, 75, 88, 92 },
            new int[] { 50, 60, 70, 80, 90, 95, 65, 75, 85, 55 },
            new int[] { 100, 100, 95, 90, 92, 96, 98, 94, 97, 99 }
        };

        PrintGroupStatistics(groups);
    }
}