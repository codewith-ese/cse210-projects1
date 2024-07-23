using System;
using System.Net.Sockets;

public class EventC
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    // public Event()
    // {

    // }

    public EventC(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;

        
    }

    public string StandardDetails()
    {

        Console.WriteLine($" STANDARD DETAILS  ");
        Console.WriteLine($" Event Title: == {_title} \n Description: == {_description} ");
        Console.WriteLine($" Event Date: == {_date} \n Time: == {_time}\n ");
        Console.WriteLine($" Event Adress/Venue: == {_address.CompleteAddress()}");
        return " ";

    }

   // public abstract string FullDetails();
    public string FullDetails()
    {
        // Console.WriteLine(_title);
        // Console.WriteLine(_description);
        // Console.WriteLine(_date);
        // Console.WriteLine(_time);
        // Console.WriteLine(_address);
        
        Console.WriteLine($" Event Title: == {_title} \n Description: == {_description} ");
        Console.WriteLine($" Event Date: == {_date} \n Time: == {_time}\n ");
        Console.WriteLine($" Event Adress/Venue: == {_address.CompleteAddress()}");
     


        return "";
       
    }
  
    public string ShortDescription()
    {
        Console.WriteLine($" Event Title: == {_title} ");
        Console.WriteLine($" Event Date: == {_date} \n");
        return "";  
    }

    // the code will store and display the name of each Event 
    public string DisplayEventType(string eventType)
    {
        var eventName = eventType;

        Console.WriteLine(" ====================================== ");
        Console.WriteLine($" Event Type is :|  '{eventName}' | Event. ");
        Console.WriteLine(" ====================================== ");

        return "";
    }


}