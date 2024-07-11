public class ReflectiinActivity: Activity
{
    protected List<string> _prompts;
    protected List<string> _questions;
    

    public ReflectiinActivity()
    {
        _name = "Reflecting Activity";
        _discription = " This activity will help you reflet in time in your life when you have shown strenght and resiliance. This will help you recongnize the power that you have and how you can use it in other aspect of your life. ";
         //  _duration = 0;

    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);

        // display random questions 
        Console.WriteLine("");
        Console.WriteLine(" Consider the following prompt: ");
        Console.WriteLine("");

        // geting random prompt 
        DisplayPrompt();

        
        do
        {
            // This code will display the random question and hold for 10 seconds 
            //  for the user to reflect on the question 
            DisplayQuestion();
            ShowCountDown(10);

        }
        while (DateTime.Now < stopTime);

        // This code will display the end message to the screen
        Console.WriteLine("");
        DisplayEndingMessage();
    
    }

    public string GetRandomPrompt()
    {
        _prompts = ["Think of a time when you stood up for someone else .", " Think of a time when you did something really difficult.",  " Think of a time when you helped someone in need. ", "Think of a time when you did something truly selfless."];

        List<string> promptReflecting = new List<string>();
        promptReflecting.Add(_prompts[0]);
        promptReflecting.Add(_prompts[1]);
        promptReflecting.Add(_prompts[2]);
        promptReflecting.Add(_prompts[3]);
      //  promptReflecting.Add(_prompts[4]);

        var random = new Random();

        int index = random.Next(promptReflecting.Count);

        Console.WriteLine("============================== ");
        Console.WriteLine($"----  {promptReflecting[index]} ----");
        Console.WriteLine("============================== ");
         
        return $"----  {promptReflecting[index]} ----";

    }

    public string GetRandomQuestion()
    {
        _questions = [" Why was this experience meaningful to you?", " Have you ever done anything like this before?", " How did you get started?", " How did you feel when it was complete?"
        , " What made this time different than other times when you were not as successful? ", " What is your favorite thing about this experience?"
        , " What could you learn from this experience that applies to other situations? ", " What did you learn about yourself through this experience? ", " How can you keep this experience in mind in the future?"];

        List<string> randomQuestion = new List<string>();
        randomQuestion.Add(_questions[0]);
        randomQuestion.Add(_questions[1]);
        randomQuestion.Add(_questions[2]);
        randomQuestion.Add(_questions[3]);
        randomQuestion.Add(_questions[4]);
        randomQuestion.Add(_questions[5]);
        randomQuestion.Add(_questions[6]);
        randomQuestion.Add(_questions[7]);
        randomQuestion.Add(_questions[8]);

        var randomQuest = new Random();

        int index = randomQuest.Next(randomQuestion.Count);

        Console.WriteLine($"----  {randomQuestion[index]} ----");

        return "";
    }

    public void DisplayPrompt()
    {
        GetRandomPrompt();

        // geting random prompt 
        Console.WriteLine("");
        Console.Write(" When you have something in mind, press enter to continue : ");
        string enterPress = Console.ReadLine();
        ShowSpinner(5);
        Console.Clear();

       // Console.WriteLine(" you pass ");
        
    }

    public void DisplayQuestion()
    {
        GetRandomQuestion();
        
    }
}