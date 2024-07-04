using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Program Title 
        Console.WriteLine(" Scripture Memorizer");
        Console.WriteLine("============================");

        Reference reference = new Reference("1 Nephi", 3, 7);
        Scripture scripture = new Scripture(reference, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

        // using the while loop and the if statemt to display,
        // to hide and check if we need to quit

        while (true)
        {
            Console.WriteLine(" ");
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine(" ");
            Console.WriteLine("============================");
            Console.Write("Press Enter to continue or type 'quit' to finish: ");

            string userAnswer = Console.ReadLine();

            if (userAnswer == "")
            {
                // This function will hide one word from the scripture 
                Console.Clear();
                scripture.HideRandomWords(1);
            }
            else if (userAnswer == "quit")
            {
                // This code will alert the user that he has quit the program 
                // if the user type in quit 
                Console.WriteLine(" ");
                Console.WriteLine("You Quit the program!");
                Console.WriteLine("============================");
                Console.WriteLine(" ");
                break;
            }

            if (scripture.IsCompletelyHidden())
            {
                // this code will display if all the word has been hidden
                // and the program will end 
                Console.WriteLine(" ");
                Console.WriteLine("All words have been hidden!");
                Console.WriteLine("============================");
                Console.WriteLine(" ");
                break;
            }
        }
    }
}



