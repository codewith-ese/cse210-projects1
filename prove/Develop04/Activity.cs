using System.Formats.Asn1;
using System.Runtime.InteropServices;

public class Activity
{
    protected string _name;
    protected string _discription;
    protected int _duration;

    public Activity()
    {
        // initializing _name, _discription and _duration 
        _name = "";
        _discription = "";
        _duration = 0;

    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine(" ");
        Console.WriteLine(" ==================================== ");
        Console.WriteLine($" Welcome to {_name} ");
        Console.WriteLine("");
        Console.WriteLine(_discription); 
        Console.Write("");

       // Console.Clear();

        // Pronpt for duration 
        Console.WriteLine("");
        Console.Write(" how long, in seconds, would you like in your session? ");
        string userSeconds = Console.ReadLine();
        int anwser = int.Parse(userSeconds);

        _duration = anwser;  

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);

        Console.Clear();
        Console.WriteLine("Get Ready........");
       // ShowSpinner(5);
        ShowCountDown(5);
        

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine(" Well Done ");
        Console.WriteLine($" your have completed another {_duration} seconds of {_name} ");
        Console.WriteLine("");
        ShowCountDown(10);
        ShowSpinner(5);

        Console.Clear();

    }
    public void ShowSpinner(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
      //  Console.WriteLine(" Spinner ");

    }
    public void ShowCountDown(int seconds)
    {
        List<string> animationCountdown = new List<string>();
        animationCountdown.Add("|");
        animationCountdown.Add("/");
        animationCountdown.Add("-");
        animationCountdown.Add("\\");
        animationCountdown.Add("|");
        animationCountdown.Add("/");
        animationCountdown.Add("-");
        animationCountdown.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < stopTime)
        {
            string c = animationCountdown[i];

            Console.Write(c);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;
            if (i >= animationCountdown.Count)
            {
              i = 0;
            }
    
        }

    
      //  Console.WriteLine($" Count Down...... {_duration}");
      //  Console.WriteLine(_duration);
    }

}