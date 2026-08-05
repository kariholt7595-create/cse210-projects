public class EternalGoal : Goal
{
    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }
}