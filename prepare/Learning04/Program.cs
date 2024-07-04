using System;

class Program
{
    static void Main(string[] args)
    {
        // Base "Assignment" object
        Assignment a1 = new Assignment("Monday Eseinone", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        // Now create the derived class assignments
        MathAssignment a2 = new MathAssignment("Ben Maroland", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Jerimah Orland", "Intro To Tech ", "The basic of Technology ");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}