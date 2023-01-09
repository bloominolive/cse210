using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int input = 1;
        do 
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            numbers.Add(input);
        } while (input != 0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is : {sum}");

        float listAverage = ((float)sum)/ numbers.Count;
        Console.WriteLine($"The average is: {listAverage}");

        int largestNum = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largestNum)
            {
                largestNum = number;
            }
        }

        Console.WriteLine($"The largest number is: {largestNum}");
    }   
}