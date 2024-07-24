public abstract class Activity
{
    private DateTime _date;
    private float _activityLenght;

    public Activity(DateTime date, float activityLenght)
    {
        _date = date;
        _activityLenght = activityLenght;
        

    }

    public string DisplayDate()
    {
        // date fucntion 
        DateTime theCurrentTime = DateTime.Now;
        return theCurrentTime.ToString("dd MMMM yyyy");
    }

    public float DisplayLenght()
    {
        return _activityLenght;
    }

    public virtual float Speed()
    {
        
        return -1;
    }

    public abstract float Distance();
 
    public virtual float Pace()
    {
        return -1;
    }

    public abstract string GetSummary();
 
}