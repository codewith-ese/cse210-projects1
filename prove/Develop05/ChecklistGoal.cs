using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

public class ChecklistGoal : Goal
{
    protected int _amountCompleted;
    protected int _target;
    protected int _bonus;

    public ChecklistGoal(string name, string description, int points) : base(name, description, points)

    {
        
    }
 
    public override int RecordEvent()
    {
        _target = _points ++;
        // If we previously were not complete
        //  mark complete and return points

        // what if we priviously were complete
       // Console.WriteLine(_isComplete);
        // Implement the logic for recording events specific to SimpleGoal
        return 0;
    }

    public override bool IsComplete()
    {
        _target = _points ++;
        // Return back whether the goal is complete

        return false;
    }

    public override string GetStringRepressentation()
    {
      //  GetDetailString();

       return $" {_shortName} {_discription} {_points} ";
    }
}