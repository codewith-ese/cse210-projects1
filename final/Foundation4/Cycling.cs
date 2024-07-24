using System.Diagnostics.Contracts;

public class Cycling : Activity
{
    private float _speed;

    public Cycling(DateTime date, float activityLenght, float speed)
    : base(date, activityLenght)
    {
        _speed = speed;

    }

    public override float Distance()
    { 
    
        return _speed; 
    }


    public override float Speed()
    {
        return Distance() / DisplayLenght() * 60;
    }

    public override float Pace()
    {
        return _speed / 60;
    }


    public override string GetSummary()
    {
        return $"{DisplayDate()}  ({DisplayLenght()}min)- Distanes {Distance()} miles, Speed: {Speed()}Kph, Pace: {Pace()}";

    }

}