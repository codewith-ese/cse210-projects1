public class BreathingActivity: Activity
{
    public BreathingActivity()
    {
        _name = "Breathin Activity ";
        _discription = " This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing. ";
      //  _duration = 0;

    }
    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
        
        do
        { 
            // Have the user breath in for 5 seconds
            Console.WriteLine("");
            Console.WriteLine(" Breathe In ......");
            ShowSpinner(5);
            
            // Have the user breath out for 5 seconds 
            Console.WriteLine(" Now breathe Out........ ");
            ShowSpinner(5); 
        
        }
        while (DateTime.Now < stopTime);

    
        // repeat this for duration of (Loop)

        Console.WriteLine("");
        DisplayEndingMessage();

    }
}