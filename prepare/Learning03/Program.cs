using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fractionOne = new Fraction();
        Console.WriteLine(fractionOne.GetFractionString());
        Console.WriteLine(fractionOne.GetDecimalValue());

        Fraction fractionTwo = new Fraction(5);
        Console.WriteLine(fractionTwo.GetFractionString());
        Console.WriteLine(fractionTwo.GetDecimalValue());

        Fraction fractionThree = new Fraction(3, 4);
        Console.WriteLine(fractionThree.GetFractionString());
        Console.WriteLine(fractionThree.GetDecimalValue());

        Fraction fractionFour = new Fraction(1, 3);
        Console.WriteLine(fractionFour.GetFractionString());
        Console.WriteLine(fractionFour.GetDecimalValue());
    }
}

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Learning03 World!");

//         Person p = new Person();
//         p.SetFirstName(" Monday ");

//         Console.WriteLine(p.GetFirstName());  
//     }



//     public class Person
//     {
//         private string _title;
//         private string _firstName;
//         private string _lastName;

//         public string GetFirstName()
//         {
//             return _firstName;
//         }

//         public void SetFirstName(string firstName)
//         {
//             _firstName = firstName;
//         }

//     }

    

// }