using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int percentageInt = int.Parse(percentage);
        string letter;
        string sign = "";

        if (percentageInt >= 90)
        {
            letter = "A";
        }
        else if (percentageInt >= 80)
        {
            letter = "B";
        }
        else if (percentageInt >= 70)
        {
            letter = "C";
        }
        else if (percentageInt >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int number = percentageInt/10;
        int remainder = percentageInt%10;


        if (remainder >= 7 && number < 9 && number > 5)
        {
            sign = "+";
        }
        else if (remainder <= 3 && number > 5 && number < 10)
        {
            sign = "-";
        }

        Console.Write($"Your letter grade is {letter}{sign}. ");

        if (percentageInt >= 70)
        {
            Console.Write("You Passed!");
        }
        else
        {
            Console.Write("You shall not pass.");
        }
    }
}