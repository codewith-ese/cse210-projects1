using System.Collections.Specialized;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

public class Lecture: EventC
{
    private string _speakerName;
    private int _capacity;
    

    public  Lecture(string title, string description, String date, string time, Address address, string speakerName, int capacity):
     base(title, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;

    }

    //public string FullDetails(string speakerName, int capacity)

    // this code will only display the name of the speaker 
    // and the capacity 
    public string DisplaySpeakerDetails()
    {
        Console.WriteLine($" Event Speakers Name: == {_speakerName}");
        Console.WriteLine($" Event Capacity: == {_capacity}");
        return " ";
    }




}