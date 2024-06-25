using System.Globalization;
using System.IO;
using System.Collections.Generic;

public class Journal
{

   // public List<Entry> _entries;

    // public void AddEntry(Entry newEnty)
    // {
    //     Console.WriteLine();
    //     Console.WriteLine("what do you think? ");
    //     string _entryText = Console.ReadLine();
    // }

//  //   public void DisplayAall()
//     {
//         foreach (Entry words1 in _entries)
//         {
//             // This code will call the Display method on each words
//             words1.Display();

//         }

//     }

    public static void SaveToFile(List<Entry> entries)
    {
        Console.WriteLine(" What is the file name? ");
        string fileNameByUser = Console.ReadLine();

        string filename = fileNameByUser;
      //  filename = fileNameByUser;

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry word in entries)
            {

                Console.WriteLine(" Writing to File........");
                Console.WriteLine("===================");
              //  outputFile.WriteLine("\n");
                outputFile.WriteLine("= Journal Entry =");
                outputFile.WriteLine($" Prompt : {word._promptText}");
                outputFile.WriteLine($" Date: {word._date}");
                outputFile.WriteLine($" Journal: {word._entryText} ");
                Console.WriteLine("===================");
            }

        }
    }

    public static List<Entry> LoadFromFile()
    {
        Console.WriteLine(" What is the file name? ");
        string fileNameByUser = Console.ReadLine();

        Console.WriteLine(" ================================== ");
        Console.WriteLine(" Reading from file.............. ");

        List<Entry> journalRead = new List<Entry>();
        string filename = fileNameByUser;

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
        Console.WriteLine(" ================================== ");

        return journalRead;
    }


    public static List<Entry> LoadFromTempral()
    {
        Console.WriteLine(" ================================== ");
        Console.WriteLine(" Reading from file Temprally file .............. ");

        List<Entry> journalRead = new List<Entry>();
        string filename = "journalTempralFile.txt";

        string[] linesNew = System.IO.File.ReadAllLines(filename);

        foreach (string line in linesNew)
        {
            Console.WriteLine(line);    
        }
        Console.WriteLine(" ================================== ");
        return journalRead;
    }


    public static void SaveDailyTemprallyFile(List<Entry> entries)
    {
        // Console.WriteLine(" What is the file name? ");
        // string fileNameByUser = Console.ReadLine();

        string filename = "journalTempralFile.txt";


        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry word in entries)
            {

                Console.WriteLine(" Writing to Temprally File ........");
                outputFile.WriteLine("= Journal Entry =");
                outputFile.WriteLine($" Prompt : {word._promptText}");
                outputFile.WriteLine($" Date: {word._date}");
                outputFile.WriteLine($" Journal: {word._entryText} ");
            }


        }
    }

}