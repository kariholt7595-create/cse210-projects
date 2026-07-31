public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0)
    {

    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();

        int timeRemaining = GetDuration();

        while (timeRemaining > 0)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();

            Console.Write("Now breathe out...");
            ShowCountDown(4);
            Console.WriteLine();

            Console.WriteLine();

            timeRemaining -= 8;
        }

        DisplayEndingMessage();

    }

}