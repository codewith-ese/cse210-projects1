public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points) : base(name, description, points)

    {


    }
 
    public override int RecordEvent()
    {
        // If we previously were not complete
        //  mark complete and return points

        // what if we priviously were complete
       // Console.WriteLine(_isComplete);
        // Implement the logic for recording events specific to SimpleGoal
        return 0;
    }

    public override bool IsComplete()
    {
        // Return back whether the goal is complete
        return false;
    }

    public override string GetStringRepressentation()
    {
      //  GetDetailString();

       return $" {_shortName} {_discription} {_points} ";
    }
}