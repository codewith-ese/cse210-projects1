public class Running: Activity
{
    private float _distance;

    
    public Running(DateTime date, float activityLenght, float distance)
    : base(date, activityLenght)
    {
        _distance = distance; 

    }

    public override float Distance()
    {
        return _distance;
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
        // Console.WriteLine($"{DisplayDate()}  ({DisplayLenght()}min)- Distanes {Distance()} miles, Speed: {Speed()}Kph, Pace: {Pace()}  ");
        // return "";

        return $"{DisplayDate()}  ({DisplayLenght()}min)- Distanes {Distance()} miles, Speed: {Speed()}Kph, Pace: {Pace()}";
        
    }
    
    
}