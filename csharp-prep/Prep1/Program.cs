using System;

class Program
{
    static void Main(string[] args)
    {
        // This will ask the user for first and last name. 
        Console.Write("what is your first name? ");
        string first_name = Console.ReadLine();
        Console.Write("What is your last name ? ");
        string last_name = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}. ");
        Console.WriteLine();
        
    }
}



