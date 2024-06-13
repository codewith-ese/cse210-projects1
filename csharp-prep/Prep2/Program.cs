using System;

class Program
{
    static void Main(string[] args)
    {
        // This program will ask users for numbers 
        Console.Write(" What  is your grade percentage? ");
        string valueFromUser = Console.ReadLine();

        int userGrade = int.Parse(valueFromUser);

        string letterGrade = "";

        if (userGrade >=90)
        {
            Console.WriteLine($" {letterGrade}  A ");
        }
        else if (userGrade >= 80)
        {
            Console.WriteLine($" {letterGrade}  B ");
        }
        else if (userGrade >= 70)
        {
            Console.WriteLine($" {letterGrade}  C ");

        }

        else if (userGrade >= 60)
        {
            Console.WriteLine($" {letterGrade}  C ");
        }

        else
        {
           letterGrade = "F";
        }

        Console.WriteLine("===============================");
        Console.WriteLine($" Your grade is {userGrade}% ");

        if (userGrade >=70)
        {
            Console.WriteLine(" You Passed! ");
            Console.WriteLine("============================");

        }

        else
        {
            Console.WriteLine(" Better luck next time ");
            Console.WriteLine("===============================");
        }

    }
}