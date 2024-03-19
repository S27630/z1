using System;

class Program
{
    static double GetAvg(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        return (double)sum / arr.Length;
    }

    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        double average = GetAvg(numbers);
        Console.WriteLine("Average: " + average);
    }
}
