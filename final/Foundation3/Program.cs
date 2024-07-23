using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("  ");
        Console.WriteLine(" ****************************** ");
        Console.WriteLine("  Envent Planning App 2024 ");
        Console.WriteLine(" ******************************");


        Console.WriteLine("=== Event (001) === ");
        Address address1 = new Address("Ademola Crecent", " Lagos", " Lagos state ", "Nigeria ");

        Lecture events = new Lecture("THE INPORTANCE A PROGRAMMING",
         " How to sulve a real word problem with programming language ",
          "23-7-2024", "2: 44 PM", address1, " Monday E. Eseinone ", 500);

        Console.WriteLine("");
        Console.WriteLine($"   {events.StandardDetails()}"); 
        Console.WriteLine(" ");
        Console.WriteLine("        FULL DETAILS          ");
      //  Console.WriteLine($"       {events.DisplayEventType("Lecture")}          ");
        Console.WriteLine($" Event Type is:   {events}          ");
        Console.WriteLine($"=========================== ");
        Console.WriteLine($" {events.FullDetails()} ");
        Console.WriteLine($" {events.DisplaySpeakerDetails()}");
   
        Console.WriteLine("==============================");
        Console.WriteLine($"|   Short Description  |");
        Console.WriteLine("==============================");
        Console.WriteLine(" ");

        Console.WriteLine($" Event Type is:  {events} ");
        Console.WriteLine($" {events.ShortDescription()}");
        Console.WriteLine($" ");


        Console.WriteLine("=== Event (002) === ");
        Address address2 = new Address(" G397  Bilian Avenue ", " Lagos", " Lagos state ", "Nigeria ");

        Reception event2 = new Reception(" The Benefit of Inheritance in C# ",
         " How to master the use of  inheritance in solving coding challage   ",
          "23-7-2024", "10: 13 PM", address2, "mondayese@gmail.com");

        Console.WriteLine("");
        Console.WriteLine($"   {event2.StandardDetails()}"); 
        Console.WriteLine(" ");
        Console.WriteLine("        FULL DETAILS          ");
      //  Console.WriteLine($"       {events.DisplayEventType("Lecture")}          ");
        Console.WriteLine($" Event Type is:   {event2}          ");
        Console.WriteLine($"=========================== ");
        Console.WriteLine($" {event2.FullDetails()} ");
        Console.WriteLine($" {event2.DisplayEmail()}");
   
        Console.WriteLine("==============================");
        Console.WriteLine($"|   Short Description  |");
        Console.WriteLine("==============================");
        Console.WriteLine(" ");

        Console.WriteLine($" Event Type is:  {event2} ");
        Console.WriteLine($" {event2.ShortDescription()}");
        Console.WriteLine($" ");



        Console.WriteLine("=== Event (003) === ");
        Address address3 = new Address(" A 21   Cuser Avenue ", " Lagos", " Lagos state ", "Nigeria ");

        OutdoorGadering event3 = new OutdoorGadering(" Five Step To a Business Success ",
         " How to grow a business with five simple modern  woftware in 2024   ",
          "23-7-2024", "10: 40 PM", address3, " 60 digree ");

        Console.WriteLine("");
        Console.WriteLine($"   {event3.StandardDetails()}"); 
        Console.WriteLine(" ");
        Console.WriteLine("        FULL DETAILS          ");
      //  Console.WriteLine($"       {events.DisplayEventType("Lecture")}          ");
        Console.WriteLine($" Event Type is:   {event3}          ");
        Console.WriteLine($"=========================== ");
        Console.WriteLine($" {event3.FullDetails()} ");
        Console.WriteLine($" {event3.DisplayWeather()}");
   
        Console.WriteLine("==============================");
        Console.WriteLine($"|   Short Description  |");
        Console.WriteLine("==============================");
        Console.WriteLine(" ");

        Console.WriteLine($" Event Type is:  {event3} ");
        Console.WriteLine($" {event3.ShortDescription()}");
        Console.WriteLine($" ");
    }
}