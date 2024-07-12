
// a parent class called Books
public class Books
{
    private string _name;

    public Books(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }
}

// a child class called NoteBook
public class NoteBook : Books
{
    private string _number;

    // calling the parent constructor using "base"!
    public NoteBook(string name, string number) : base(name)
    {
      _number = number;
    }

    public string GetNumber()
    {
        return _number;
    }
}