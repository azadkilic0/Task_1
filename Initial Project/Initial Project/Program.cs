using System;




class Program
{
    static void Main(string[] args)
    
    {
        Console.WriteLine("Modification 1");
        Console.WriteLine("Modification 2");
        Console.WriteLine("Modification 3");
        int[] numbers = { 1, 2, 3, 4, 5 };
        double average = CalculateAverage(numbers);
        Console.WriteLine($"The average is: {average}");
    }

    static double CalculateAverage(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty", nameof(nums));
        }

        long sum = 0;
        foreach (int element in nums)
        {
            sum += element;
        }
        return (double)sum / nums.Length;
    }
}