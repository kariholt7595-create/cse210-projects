using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running(new DateTime(2026, 8, 12), 30, 3.0);
        activities.Add(running);

        Bicycle bicycle = new Bicycle(new DateTime(2026, 8, 12), 30, 12.0);
        activities.Add(bicycle);

        Swimming swimming = new Swimming(new DateTime(2026, 8, 12), 30, 20);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}