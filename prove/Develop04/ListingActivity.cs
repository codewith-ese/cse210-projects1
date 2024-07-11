using System;
public class ListingActivity: Activity
{
    protected int _count;
   // List<string> _prompt = new List<string>();
    protected List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing Activity ";
        _discription = " This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
       // _count = 0;
        
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);

        // display random questions 
        Console.WriteLine("");
        Console.WriteLine(" List as many as you can to the following prompt: ");

        // geting random prompt 
        GetRandomPrompt();
        ShowSpinner(5);
        Console.WriteLine(" You may begin in: ");
        
        do
        {
            GetListFromUser();

        }
        while (DateTime.Now < stopTime);


        Console.WriteLine("");
        Console.WriteLine($" You listed {_count} items ");
        Console.WriteLine("");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        _prompts = [" When have you felt the Holy Ghost this month? ",
         " Who are people that you appreciate? ", 
         " Who are some of your personal heroes? ",
          " What are personal strengths of yours? ",
           " Who are people that you have helped this week? ",
            " When have you felt the Holy Ghost this month?"];

        List<string> promptList = new List<string>();
        promptList.Add(_prompts[0]);
        promptList.Add(_prompts[1]);
        promptList.Add(_prompts[2]);
        promptList.Add(_prompts[3]);
        promptList.Add(_prompts[4]);

        var random = new Random();

        int index = random.Next(promptList.Count);

        Console.WriteLine("============================== ");
        Console.WriteLine($"----  {promptList[index]} ----");
        Console.WriteLine("============================== ");

    }
    public void GetListFromUser()
    { 
        List<string> userList = new List<string>();

        Console.Write("<_>  ");
        string aaa = Console.ReadLine();

        if (aaa != "")
        {
            userList.Add(aaa);

            foreach (string i in userList)
            {
                // This will count the number of entries in the list
               // Console.WriteLine(i);
                _count = i.Count();

            }

        }


       // Console.WriteLine(userList);

    }
}