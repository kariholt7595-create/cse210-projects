using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        Console.WriteLine(magicNumber);

        int number;

        do
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            number = int.Parse(guess);
        

                if (number > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                else if (number < magicNumber)
                {
                    Console.WriteLine("Higher"); 
                }

                else
                {
                    Console.WriteLine("You guessed it!");
                }
        } while (number != magicNumber);
        
    }
}