using System.Linq.Expressions;

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public string CompleteAddress()
    {
        return $"{_street} {_city} {_stateProvince} {_country}";
    }

    public bool Usa()
    {
        //  this code will convert the country address string 
        // and return a USA in respective of the latter case 
        return _country.ToLower() == "USA";

    }
}



