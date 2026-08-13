public abstract class Activity
{
    private DateTime _date;
    private int _length;

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public abstract string GetActivityType();

    public string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} {GetActivityType()} ({_length} min) - Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }

    public int GetLength()
    {
        return _length;
    }

    public DateTime GetDate()
    {
        return _date;
    }
}