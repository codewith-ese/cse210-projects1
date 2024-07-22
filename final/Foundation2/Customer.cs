public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetCustomerInfo()
    {
        return _name;
    }

    public string GetCustomerAddress()
    {
        return _address.CompleteAddress();
    }

    public bool Usa()
    {
        return _address.Usa();
    }
}

