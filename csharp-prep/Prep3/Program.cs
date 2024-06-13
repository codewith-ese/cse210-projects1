using System;

class Program
{
    static void Main(string[] args)
    {
       // This code will generate random numbers 
       Random randomGenerator = new Random();
       int magicNumber = randomGenerator.Next(1, 40);

       //int magicNumber = 12;

        int guess = -1;

        while (guess != magicNumber)
        {

            //  Ask for user guess number
            Console.Write(" What is the magic number? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine(" Lower ");
            }

            else if (guess < magicNumber)
            {
                Console.WriteLine(" Higher ");
            }

            else
            {
                Console.WriteLine(" You guess it! ");
            }

        }
    }
}