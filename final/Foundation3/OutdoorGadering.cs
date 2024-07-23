using System;
using System.Globalization;

public class OutdoorGadering: EventC
{
    private string _weatherStatement;

    // public override string FullDetails()
    // {
    //     return "";
    // }

    public OutdoorGadering(string title, string description, string date, string time, Address address, string weatherStatement):
    base(title, description, date, time, address)
    {
        _weatherStatement = weatherStatement;
        
    }

    public string DisplayWeather()
{
    Console.WriteLine($" Weather Statement: == {_weatherStatement}");

    return "";
    }
}