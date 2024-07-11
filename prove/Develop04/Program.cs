using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime aDate = DateTime.Now;
        Console.WriteLine("========================      ========================================");
        Console.WriteLine("|| Mindfulness Program " + "        || " + aDate.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’"));
        Console.WriteLine("========================      ========================================");
      //  Console.WriteLine("");

        var choice = "";
        do
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Start breathing  activity ");
            Console.WriteLine(" 2. Start reflecting activity ");
            Console.WriteLine(" 3. Start listing activity ");
            Console.WriteLine(" 4. Quit ");
            Console.Write("Select a choice from the menu: ");
            
            choice = Console.ReadLine();
            if (choice =="1")
            {

                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                
                // breathingActivity.DisplayStartingMessage();
                // breathingActivity.ShowSinner(5);
                // breathingActivity.DisplayEndingMessage();



            }
            else if (choice == "2")
            {
                ReflectiinActivity reflectingActivity = new ReflectiinActivity();
                reflectingActivity.Run();

            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
               // List<string> a = new List<string>;
               

            }
            else if (choice == "4")
            {
                Console.WriteLine(" Goodbye");

            }
            else
            {
                Console.Write("Invalid Choice. Try Again ");
            }
    
        }
        while (choice !=  "4");

    }
}