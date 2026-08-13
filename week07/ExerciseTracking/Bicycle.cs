public class Bicycle : Activity
{
    private double _speed;

    public Bicycle(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetLength()) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return (60 / _speed);
    }

    public override string GetActivityType()
    {
        return "Bicycle";
    }
}