using System;

// Exceeded requirements by asking the user for their mood
// and storing, displaying, saving, and loading it with each entry.

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                Console.Write("How would you describe your mood today? ");
                string mood = Console.ReadLine();

                DateTime currentDate = DateTime.Now;
                string dateText = currentDate.ToShortDateString();

                Entry newEntry = new Entry();

                newEntry._date = dateText;
                newEntry._promptText = prompt;
                newEntry._entryText = response;
                newEntry._mood = mood;

                journal.AddEntry(newEntry);
            }

            else if (choice == 2)
            {
                journal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.Write("What is the filename? ");
                string file = Console.ReadLine();

                journal.LoadFromFile(file);
            }

            else if (choice == 4)
            {
                Console.Write("What is the filename? ");
                string file = Console.ReadLine();

                journal.SaveToFile(file);
            }
        }
    }
}