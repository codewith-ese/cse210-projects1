using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Net.NetworkInformation;
using System.Threading.Tasks.Dataflow;
public class GoalManager 
{
    // Attribut (private)
    protected List<Goal> _goals;
    protected int _scores;

    // Constuctor - initializing the attribute
    public GoalManager()
    {
        // _goals = "";
       // _scores = 0;
    }

    public void Start() 
    {
       
        Console.WriteLine("");
        Console.WriteLine($" You have {_scores} points. ");
        // Display the main menu and display the player info       
  
       var choice = "";
        do
        {
            DisplayPlayerInfo();

            Console.WriteLine("");
            Console.WriteLine(" Menu Options: ");
            Console.WriteLine(" 1. Create New Goal ");
            Console.WriteLine(" 2. List Goals ");
            Console.WriteLine(" 3. Save Goals ");
            Console.WriteLine(" 4. Load Goals ");
            Console.WriteLine(" 5. Record Event ");
            Console.WriteLine(" 6. Quit ");

            Console.Write("Select a choice from the menu: ");
            
            choice = Console.ReadLine();
            if (choice =="1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
                   
            }
            else if (choice == "3")
            {
                Console.WriteLine();
                SaveGoals();
                Console.WriteLine(" You have save to file successfuly ");
            }
            else if (choice == "4")
            {
                
                LoadGoals();
              //  RecordEvent();
                Console.WriteLine();
                
            }
            else if (choice == "5")
            {
                
                RecordEvent();
            }
            else if (choice == "6")
            {
                Console.WriteLine(" Goodbye");
            }
            else
            {
                Console.Write("Invalid Choice. Try Again ");
            }
    
        }
        while (choice !=  "6");

        
        // Call:
        // CreateGoal, ListGoalDetails, SaveGoals, and LoadGoals
        // RecordEvent

    }
    public void DisplayPlayerInfo() 
    {
        // Display the points
        Console.WriteLine(_scores);

    }

    public void ListGoalNames()
    {

        // Loop through the list of goals
        // and display the names (YOU MAY NEED
        // ANOTHER FUNCTION IN THE GOAL CLASS)
        // 1. Go to bed on time
        // 2. Do my homework



        // List<Goal> goals = new List<Goal>();
        // SimpleGoal sg = new SimpleGoal(); 
        // goals.Add(sg);

        // Goal g = goals[0]

        // foreach (Goal goal in _goals)
        // Console.WriteLine(goal.GetDetailString());
    

    }


    public void ListGoalDetails()
    {
      
        string filename = "temporaryFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
            
        }

        string efilename = "eternalTemporay.txt";
        string[] elines = System.IO.File.ReadAllLines(efilename);

        //Console.WriteLine(lines);
        // Console.WriteLine(elines);
        foreach (string eline in elines)
        {

            Console.WriteLine(eline);
        }

        string checkfilename = "checklistTemporay.txt";
        string[] chlines = System.IO.File.ReadAllLines(checkfilename);

        //Console.WriteLine(lines);
        // Console.WriteLine(elines);
        foreach (string cline in chlines)
        {

            Console.WriteLine(cline);
        }


                 // Loop through the list of goals and 
        // display the full details

        // foreach (Goal goal in _goals)
        // {
        //     Console.WriteLine(goal.GetDetailString());
        //     // Add any additional details you want to display here
        //     Console.Write($" llllllllllllllllllll{goal.GetStringRepressentation()}");
        // }

    }


    public void CreateGoal()
    {
        // Display a sub-menu to select a goal type
        var createGoal = "";
        do
        {
           // Console.Clear();
            Console.WriteLine(" The types of goals are :");
            Console.WriteLine("     1. Simple Goal ");
            Console.WriteLine("     2. Eternal Goal ");
            Console.WriteLine("     3. Checklist Goal");
            Console.Write(" Which type of goals will you like to create? ");
            
            createGoal = Console.ReadLine();

            if (createGoal == "1")
            {
                
                // Ask for the name, description and points
                Console.Write(" What is the name of the goal? ");
                string goalName = Console.ReadLine();

                Console.Write(" What is the short discription of it ");
                string shortDiscription = Console.ReadLine();

                Console.Write(" What is the amount of point associated with this goal? ");
                string pointAssigned = Console.ReadLine();

                int poinConvert = int.Parse(pointAssigned);

                SimpleGoal goal = new SimpleGoal(goalName, shortDiscription, poinConvert);
                Console.WriteLine();
                Console.WriteLine($" You created a {goal} ");
                Console.WriteLine($" You created a {goal.GetDetailString()} ");

              //  goal.GetDetailString();

              //  _goals.Add(goal);
                _goals = new List<Goal>();

                List<string> goalList = new List<string>();
                goalList.Add(goalName);
                goalList.Add(shortDiscription );
                goalList.Add(pointAssigned);  

                _scores = poinConvert;

                // writing to a temprary file 
                using (StreamWriter outputFile = new StreamWriter("temporaryFile.txt"))
                {
                    
                    outputFile.WriteLine($"[ ]---{goal}:  {goalName} | {shortDiscription} | {pointAssigned} ");
                    
                }

        
            }
            else if (createGoal == "2")
            {
                              
                // Ask for the name, description and points
                Console.Write(" What is the name of the goal? ");
                string goalName = Console.ReadLine();

                Console.Write(" What is the short discription of it ");
                string shortDiscription = Console.ReadLine();

                Console.Write(" What is the amount of point associated with this goal? ");
                string pointAssigned = Console.ReadLine();

                int poinConvert = int.Parse(pointAssigned);

                List<Goal> goals = new List<Goal>();
                EternalGoal egoal = new EternalGoal(goalName, shortDiscription, poinConvert);
                Console.WriteLine();

                goals.Add(egoal);

               // goal.GetDetailString();
                Console.WriteLine("============== ");
                Console.WriteLine(" You created a: ");
                Console.WriteLine("============== ");
                Console.WriteLine($" {egoal} ");
                Console.WriteLine("============== ");
                Console.WriteLine($" {egoal.GetDetailString()}");
                Console.WriteLine("============== ");
                Console.WriteLine("============== ");

                _scores = poinConvert;

                // writing to a temprary file 
                using (StreamWriter outputFile = new StreamWriter("eternalTemporay.txt"))
                {
                    outputFile.WriteLine($"[ ]---{egoal}:  {goalName} | {shortDiscription} | {pointAssigned} ");
                    
                }

            //    Console.WriteLine($" You created a {goal} ");
             //   Console.WriteLine($" You created a {goal.GetDetailString()} ");

            }
            else if (createGoal == "3")
            {               
                // Ask for the name, description and points
                Console.Write(" What is the name of the goal? ");
                string goalName = Console.ReadLine();

                Console.Write(" What is the short discription of it ");
                string shortDiscription = Console.ReadLine();

                Console.Write(" What is the amount of point associated with this goal? ");
                string pointAssigned = Console.ReadLine();

                Console.Write(" How namy time does this goal need to be accomplished for a bonus? ");
                string more = Console.ReadLine();

                int poinConvert = int.Parse(pointAssigned);

                List<Goal> goals = new List<Goal>();
                ChecklistGoal checkLgoal = new ChecklistGoal(goalName, shortDiscription, poinConvert);
                Console.WriteLine();

                goals.Add(checkLgoal);

               // goal.GetDetailString();
                Console.WriteLine("============== ");
                Console.WriteLine(" You created a: ");
                Console.WriteLine("============== ");
                Console.WriteLine($" {checkLgoal} ");
                Console.WriteLine("============== ");
                Console.WriteLine($" {checkLgoal.GetDetailString()}");
                Console.WriteLine("============== ");
                Console.WriteLine("============== ");
                

                _scores = poinConvert;

                // writing to a temprary file 
                using (StreamWriter outputFile = new StreamWriter("checklistTemporay.txt"))
                {
                    outputFile.WriteLine($"[ ]---{checkLgoal}:  {goalName} | {shortDiscription} | {pointAssigned} ");
                    
                }

            }
            else if (createGoal == "4")
            {
                Console.WriteLine(" Are you sure you want to Quit the Game without creating more goals? ");
                Console.WriteLine(" If yes, Click the Enter key to Exit the Game ");
            }
            else
            {
                Console.WriteLine(" Invalid Choice of Goal, Try Again ");
            }

        }while (createGoal =="");

        // Ask for the name, description and points
        // Ask for more if they pick checklist goal
        // Create the object and add to the goal list    

    }
    public void RecordEvent()
    {
        
        // Display a list of all of the goal names
        // Ask user to select a goal
        // Call RecordEvent on the correct one 
        // update the score based on the points
        // Display current points

    
        // Display a sub-menu to select a goal type
        var recordEvents = "";
        do
        {
            // Console.Clear();
            Console.WriteLine(" ====================== ");

            ListGoalNames();
            Console.WriteLine(" Here are the goals :");
            Console.WriteLine($"     1. Simple Goal");
            Console.WriteLine($"     2. Eternal Goal ");
            Console.WriteLine($"     3. Checklist Goal ");
            Console.WriteLine("  ========================  ");
        
            Console.Write(" Which goal did you accomplish? ");
            recordEvents = Console.ReadLine();

            if (recordEvents == "1")
            {

              //  SimpleGoal goal = new (_scores);
                
                Console.Write(" Congratulations ");
                Console.WriteLine(_scores);
            }
            else if (recordEvents == "2")
            {
                                
            
                  Console.Write(" Congratulations ");
                  Console.WriteLine(_scores);

         

            }
            else if (recordEvents == "3")
            {               
                
                Console.Write(" Congratulations ");
                Console.WriteLine(_scores);



            }
            else if (recordEvents == "4")
            {
                Console.WriteLine(" Are you sure you want to Quit the Game without creating more goals? ");
                Console.WriteLine(" If yes, Click the Enter key to Exit the Game ");
            }
            else
            {
                Console.WriteLine(" Invalid Choice of Goal, Try Again ");
            }

        }while (recordEvents =="");

    }
    public void SaveGoals()
    {

        Console.Write(" What is the name of the file? ");
        string saveGoals = Console.ReadLine();
    
        // writing to a temprary file 
        using (StreamWriter outputFile = new StreamWriter($"{saveGoals}"))
        {
            string filename = "temporaryFile.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                outputFile.WriteLine(line);
                
            }

            string efilename = "eternalTemporay.txt";
            string[] elines = System.IO.File.ReadAllLines(efilename);

            //outputFile.WriteLine(lines);
           // outputFile.WriteLine(elines);
            foreach (string eline in elines)
            {

                outputFile.WriteLine(eline);
            }

            string checkfilename = "checklistTemporay.txt";
            string[] chlines = System.IO.File.ReadAllLines(checkfilename);

            //outputFile.WriteLine(lines);
           // outputFile.WriteLine(elines);
            foreach (string cline in chlines)
            {

                outputFile.WriteLine(cline);
            }
                       
        }
        // Ask user for a file name
        // Loop through the goals and convert each
        // goal to a string and then save the string

    }
    public void LoadGoals()
    {
        Console.Write(" What is the file name you want to Open? ");
        string openGoals = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine(" ====================== ");
        Console.WriteLine(" The goals are : ");
        Console.WriteLine(" ====================== ");
        Console.WriteLine(); 

        string filename = $"{openGoals}";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);    
        }
        Console.WriteLine(" ====================== ");



        // Ask user for a file name
        // Read each line of the file and splite it up
        // Use the parts to re-create the Goal object

    }

}



