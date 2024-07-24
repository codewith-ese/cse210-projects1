using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" =============================");
        Console.WriteLine("  Exercise Tracking  Activity 2024");
        Console.WriteLine(" ============================== ");

        // Console.WriteLine($" {swimming1.DisplayDate()}");
        // Console.WriteLine($" {swimming1.Distance()}");
        // Console.WriteLine($" {swimming1.DisplayLenght()}");
        // Console.WriteLine($" {swimming1.Pace()}");

        Swimming swimming = new Swimming(DateTime.Now, 40, 905);
        Console.WriteLine($"  {swimming} {swimming.GetSummary()} ");

        
        Cycling cycling = new Cycling(DateTime.Now, 40, 805);
        Console.WriteLine($"  {cycling} {cycling.GetSummary()} ");

        Running running = new Running(DateTime.Now, 60, 987);
        Console.WriteLine($"  {running} | {running.GetSummary()} ");
        Console.WriteLine("");


        List<Activity> activities = new List<Activity>();
        activities.Add(swimming);
        activities.Add(cycling);
        activities.Add(running);

        foreach (Activity a in activities)
        {
            Console.WriteLine($" Activity Type is: | {a} | {a.GetSummary()} ");

        }

        Console.WriteLine(" ");
        Console.WriteLine("  ===================   ");
        Console.WriteLine(" ");




        

    }
}