using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

class Program
{
  
    public static string Text { get; private set; }

    static void Main(string[] args)
    {
        while (true)
        {

            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine("Welcome to the Journal Program ");
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine(" 1. Write ");
            Console.WriteLine(" 2. Display ");
            Console.WriteLine(" 3. Load ");
            Console.WriteLine(" 4. Save ");
            Console.WriteLine(" 5. Quit ");
            Console.WriteLine("================================");

            

            Console.Write(" What would you like to do? ");
            string UserAnwser = Console.ReadLine();

            int anwser = int.Parse(UserAnwser);

            if (anwser == 1)
            {

                PromptGenerator prompt = new PromptGenerator();
                prompt._words1 = "Who was the most interesting person I interacted with today? ";
                prompt._words2 = "What was the best part of my day? ";
                prompt._words3 = "How did I see the hand of the Lord in my life today? ";
                prompt._words4 = "What was the strongest emotion I felt today? ";
                prompt._words5 = "If I had one thing I could do over today, what would it be?";

                // printing out prompt generated
                Console.WriteLine();
                Console.WriteLine(prompt.GetRandomPrompt());
                string Text = Console.ReadLine();

                // date fucntion 
                DateTime theCurrentTime = DateTime.Now;
                string _date = theCurrentTime.ToShortDateString();

                Entry entry1 = new Entry();
                entry1._date = _date;
                entry1._promptText = prompt.GetRandomPrompt();
                entry1._entryText = Text;


                List<Entry> entries = new List<Entry>();
                entries.Add(entry1);

                foreach (Entry words in entries)
                {
                    Console.WriteLine();
                    Console.WriteLine($" {words._date} ");
                    Console.WriteLine($" {words._promptText}");
                    Console.WriteLine($" {words._entryText}");
                    Console.WriteLine();

                }
                
                Journal.SaveDailyTemprallyFile(entries);

                Journal.SaveToFile(entries);

                

            }

            else if (anwser == 2)
            {


                Journal.LoadFromTempral();

                // calling loading from files 
                List<Entry> readingFromTextFile = new List<Entry>();
                foreach (Entry contenText in readingFromTextFile)
                {
                    Console.WriteLine($"{contenText._entryText}");
                    Console.WriteLine(" you have choose to Display Number 2. Option ");
                }


                
            }

            else if (anwser == 3)
            {
                Journal.LoadFromFile();

                // calling loading from files 
                List<Entry> readingFromTextFile = new List<Entry>();
                foreach (Entry textFileConten in readingFromTextFile)
                {
                    Console.WriteLine(textFileConten._entryText);
                }

            }

            else if (anwser == 4)
            {
               // PromptGenerator prompt = new PromptGenerator();

             //   date fucntion 
                DateTime theCurrentTime = DateTime.Now;
                string _date = theCurrentTime.ToShortDateString();

                Entry entry1 = new Entry();
                entry1._date = _date;
              //  entry1._promptText = _promptText;
                entry1._entryText = Text;


                List<Entry> entries = new List<Entry>();
                entries.Add(entry1);

                foreach (Entry words in entries)
                {
                    Console.WriteLine();
                    Console.WriteLine($" {words._date} ");
                    Console.WriteLine($" {words._promptText}");
                    Console.WriteLine($" {words._entryText}");
                    Console.WriteLine();

                }

                Journal.SaveToFile(entries);

            }
            else if (anwser == 5)
            {
                Console.WriteLine(" You Exited the program");
                break;

            }

        }
    }


}
