using System;

class Program2
{
    static void Main(string[] args)
    {
        // Example usage
        int[] numbers = { 10, 32, 45, 90, 8 };
        int max = FindMaximum(numbers);
        Console.WriteLine($"The maximum value is: {max}");
    }

    static int FindMaximum(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty", nameof(nums));
        }

        int max = nums[0];
        foreach (int num in nums)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
    }
}