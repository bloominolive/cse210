using System;

class Program
{
    static void Main(string[] args)
    {   // for first requirement from user input
       /*  Console.Write("What is the magic number? ");
        string inputMagicNumber = Console.ReadLine();
        int magicNumber = int.Parse(inputMagicNumber); */

        // for second requirement with random number generator

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.WriteLine("Guess the magic number from 1-100!");

        int numGuess = -1;

        while (numGuess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string inputNumGuess = Console.ReadLine();
            numGuess = int.Parse(inputNumGuess);

            if (numGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (numGuess > magicNumber) 
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                break;
            }
        }
    }
}