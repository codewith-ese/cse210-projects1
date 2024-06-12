using System;

class Program
{
    static void Main(string[] args)
    {
        // This program will ask users for numbers 
        Console.Write(" What  is your grade percentage?");
        string valueFromUser = Console.ReadLine();

        int userGrade = int.Parse(valueFromUser);

        if (userGrade >=90)
        {
            Console.WriteLine();
            Console.WriteLine("Wow!,  Execcellent! ");
            Console.WriteLine("Congratulations you have got an 'A' ");
            Console.WriteLine($" your total score is {userGrade}%");
            Console.WriteLine();
        }
        else if (userGrade >= 80)
        {
            Console.WriteLine();
            Console.WriteLine("Congratulations you have got a 'B'  ");
            Console.WriteLine($" your total score is {userGrade}%");
            Console.WriteLine();
        }
        else if (userGrade >= 70)
        {
            Console.WriteLine();
            Console.WriteLine(" Congratulations you have got a 'C' ");
            Console.WriteLine($" your total score is {userGrade}%");
            Console.WriteLine();
        }

        else if (userGrade >= 60)
        {
            Console.WriteLine();
            Console.WriteLine(" Congratulations you have got a 'D' ");
            Console.WriteLine($" your total score is {userGrade}%");
            Console.WriteLine();
        }
        else if (userGrade < 60)
        {
            Console.WriteLine();
            Console.WriteLine(" sory you have got an F which means you failed the course");
            Console.WriteLine($" your total score is {userGrade}% ");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine(" Invalid Entry ");
            Console.WriteLine();
        }


    }
}