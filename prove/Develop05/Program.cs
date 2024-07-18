using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        // Create a GoalManger object
        // call the Start function on the object
        GoalManager goalManager = new GoalManager();
        goalManager.Start();

       // goalManager.SaveGoals();

        

    }
} 
       
        // List<Goal> goals = new List<Goal>();
        // SimpleGoal sg = new SimpleGoal(); 
        // goals.Add(sg);

        // Goal g = goals[0]