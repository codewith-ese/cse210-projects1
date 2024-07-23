public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;
    
    public string CompleteAddress()
    {
        return $" \n Street:  {_street} \n City: {_city} \n State Province: {_stateProvince}\n Country: {_country}  ";
    }

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
        
    }

    // public void SetStreet(string street)
    // {
    //     Address address = new Address(_street, _city, _stateProvince, _country);
        
    // }

}