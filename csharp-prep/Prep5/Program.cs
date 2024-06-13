using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine();
        DisplayWelcomeMessage();
        Console.WriteLine("     ********************************* ");

        string username = PrompUserName();
        int userNumber = PromptUserNumber();

        int squarNumber = SquareNumber(userNumber);

        DisplayResult(username, squarNumber);
    }


    static void DisplayWelcomeMessage()
    {
        Console.WriteLine(" Welcome to the program! ");
    }
    
         // This function will display the user name 
    static string PrompUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name; 
    }

    static int PromptUserNumber()
    {
        Console.Write(" Please enter your favorite number: ");
        int userFavorit = int.Parse(Console.ReadLine());

        return userFavorit; 
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine("================================================= ");
        Console.WriteLine($"{name}, the square of your number is {square}");
        Console.WriteLine("================================================= ");
    }

}