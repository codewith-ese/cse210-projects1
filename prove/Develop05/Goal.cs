public abstract class Goal{
    // Attribute (private or protected )
    protected string _shortName;
    protected string _discription;
    protected int _points;

    // constructor (name, discription, and point )
    public Goal(string name, string discription, int points)
    {
        _shortName = name;
        _discription = discription;
        _points = points;
    }
    public abstract int RecordEvent();


    public abstract bool IsComplete();

    public string GetDetailString()
    {
       // return "Details ";
            return $" {_shortName} {_discription} {_points}";
    }

    public abstract string GetStringRepressentation();

}