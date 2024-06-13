using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine(" Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();

        int enterNumber = -1;

        while  (enterNumber != 0)
        {

            Console.Write(" Enter number: ");
            enterNumber = int.Parse(Console.ReadLine());

            numbers.Add(enterNumber);

          //  foreach (int number in numbers)
           // {
           //     Console.WriteLine(number);
          //  }

            if (enterNumber == 0)
            {   
                    // Calculate the sum total in the list 
                int sum = numbers.Sum();
                Console.WriteLine("==================");
                Console.WriteLine($" The sum is: {sum} ");
                Console.WriteLine("===================");

                    // Calculate the average 
                double average = numbers.Average();
                Console.WriteLine("==================");
                Console.WriteLine($" The Average is: {average} ");
                Console.WriteLine("===================");
        

                    // Calculating the gratest value
                numbers.Sort();
                int greatestValue = numbers[numbers.Count-1];
                Console.WriteLine("==================");
                Console.WriteLine($" The largest number is: {greatestValue} ");
                Console.WriteLine("===================");
                Console.WriteLine();


            }

        }

    }
}