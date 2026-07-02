using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int gradePercent = int.Parse(answer);

        string letter = "";

        if (gradePercent >= 90)
        {
            letter = "A";
        }

        else if (gradePercent >= 80)
        {
            letter = "B";
        }

        else if (gradePercent >= 70)
        {
            letter = "C";
        }

        else if (gradePercent >= 60)
        {
            letter = "D";  
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations, you passed! ");
        }
        else
        {
            Console.WriteLine("This isn't passing, try harder next time. ");
        }
    }
}