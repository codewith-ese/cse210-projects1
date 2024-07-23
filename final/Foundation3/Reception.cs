public class Reception: EventC
{
    private string _email;

    // public override string FullDetails()
    // {
    //     return "";
    // }

    public Reception(string title, string description, string date, string time, Address address, string email):
    base(title, description, date, time, address)
    {
        _email = email;

    }

    public string DisplayEmail()
    {
        Console.WriteLine($" Booking Email: == {_email}");

        return "";
    }
}