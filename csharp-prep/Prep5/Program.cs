using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string username = PromptUserName();
        int usernumber = PromptUserNumber();
        int squarednumber = SquareNumber(usernumber);

        DisplayResult(username, squarednumber);        
    }

    static void DisplayMessage()
        {
        Console.WriteLine("Welcome to the Program!");
        }

    static string PromptUserName() 
    {
        Console.Write("Please enter your name: ");
        string inputname = Console.ReadLine();
        return inputname;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favnumber = int.Parse(Console.ReadLine());
        return favnumber;
    }

    static int SquareNumber(int favnumber)
    {
        int sqaure = favnumber * favnumber;
        return sqaure;

    }

    static void DisplayResult(string name, int square)
    {
    Console.WriteLine($"{name}, the sqaure of your number is {square}");
    }
}