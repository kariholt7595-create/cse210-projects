using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

// ***Exceeding requirements*** The user can choose how many words are hidden during each round, allowing them to adjust the memorization difficulty.
// I also made it so the program can only hide words that aren't already hidden.

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding.");

        // I added this for exceeding requirements
        Console.Write("How many words would you like to hide each round? ");
        int wordsToHide = int.Parse(Console.ReadLine());

        string userInput = "";

        while (userInput != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");

            userInput = Console.ReadLine();

            if (userInput != "quit")
            {
                scripture.HideRandomWords(wordsToHide);
                // This line is changed for exceeding requirements 
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}