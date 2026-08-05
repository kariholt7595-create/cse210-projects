public class SimpleGoal : Goal
{
    private bool _isComplete;

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }
}