using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public void Start()
    {
        string choice = "";

        while (choice != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }

            else if (choice == "2")
            {
                ListGoalDetails();
            }

            else if (choice == "3")
            {
                SaveGoals();
            }

            else if (choice == "4")
            {
                LoadGoals();
            }

            else if (choice == "5")
            {
                RecordEvent();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        DisplayLevel();
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }

    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            string status = "[ ]";

            if (_goals[i].IsComplete())
            {
                status = "[X]";
            }

            Console.WriteLine($"{i + 1}. {status} {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.WriteLine("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        if (choice == 1)
        {
            newGoal = new SimpleGoal(name, description, points, false);
        }
        else if (choice == 2)
        {
            newGoal = new EternalGoal(name, description, points);
        }
        else if (choice == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            newGoal = new ChecklistGoal(name, description, points, target, bonus);
        }
        _goals.Add(newGoal);
    }

    public void RecordEvent()
    {
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        choice = choice - 1;

        if (choice < 0 || choice >= _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        if (_goals[choice].IsComplete())
        {
            Console.WriteLine("That goal has already been completed.");
            return;
        }

        _goals[choice].RecordEvent();
        _score += _goals[choice].GetPoints();

        if (_goals[choice] is ChecklistGoal)
        {
            ChecklistGoal checklist = (ChecklistGoal)_goals[choice];
            if (checklist.IsComplete())
            {
                _score += checklist.GetBonus();
            }
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("WHat is the filename? ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(':');

            string goalType = parts[0];
            string[] goalData = parts[1].Split(',');

            if (goalType == "SimpleGoal")
            {
                string name = goalData[0];
                string description = goalData[1];
                int points = int.Parse(goalData[2]);
                bool isComplete = bool.Parse(goalData[3]);

                SimpleGoal goal = new SimpleGoal(name, description, points, isComplete);
                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                string name = goalData[0];
                string description = goalData[1];
                int points = int.Parse(goalData[2]);

                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                string name = goalData[0];
                string description = goalData[1];
                int points = int.Parse(goalData[2]);
                int target = int.Parse(goalData[3]);
                int bonus = int.Parse(goalData[4]);
                int amountCompleted = int.Parse(goalData[5]);

                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
                _goals.Add(goal);
            }
        }
    }

    public void DisplayLevel()
    {
        Console.Write("Current Level: ");

        if (_score >= 1000)
        {
            Console.WriteLine("Expert");
        }
        else if (_score >= 500)
        {
            Console.WriteLine("Intermediate");
        }
        else
        {
            Console.WriteLine("Beginner");
        }
    }

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
}