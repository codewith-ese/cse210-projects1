using System.Security.Cryptography.X509Certificates;

public class Swimming : Activity
{
    private float _laps;

    public Swimming(DateTime date, float activityLenght, float laps)
    : base(date, activityLenght)
    {
        _laps = laps;


    }
    public override float Distance()
    {
        var distance = _laps * 50 / 1000;
        return distance;
        
    }

    public override float Speed()
    {
        return Distance() / DisplayLenght() * 60;

    }

    public override float Pace()
    {
        return 60 / Speed();

    }

    public override string GetSummary()
    {
        
        return $"{DisplayDate()}  ({DisplayLenght()}min)- Distanes {Distance()} miles, Speed: {Speed()}Kph, Pace: {Pace()}  ";

    }


}