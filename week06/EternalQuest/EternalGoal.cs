public class EternalGoal : Goal
{
    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetShortName()},{GetDescription()},{GetPoints()}";
    }

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }
}