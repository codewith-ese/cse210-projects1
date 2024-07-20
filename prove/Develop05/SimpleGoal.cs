using System.Drawing;

public class SimpleGoal : Goal
{
    // Atribute
    protected bool _isComplete;

    // Constructor (name, description, and points )
    // SimpleGoal(-----) base(.....)


    public SimpleGoal(string name, string description, int points): base(name, description, points)
    {
    //    _shortName = name;
    //    _discription = description;
    //    _points = points;
        _points = points ++;
    }

    public override int RecordEvent()
    {
       
        
        // If we previously were not complete
        //  mark complete and return points

        // what if we priviously were complete
       Console.WriteLine(_isComplete);

       Console.WriteLine(_points);

        // Implement the logic for recording events specific to SimpleGoal
        return _points;
    }

    public override bool IsComplete()
    {
    
        Console.WriteLine(_points);
        // Return back whether the goal is complete
        return false;
    }

    public override string GetStringRepressentation()
    {
      //  GetDetailString();

        return $" {_shortName} {_discription} {_points} ";
    }
}