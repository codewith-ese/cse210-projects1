public class Comment
{
    public string _name;
    public string _commentText;

    public Comment(string name, string commentText)
    {
        _name = name;
        _commentText = commentText;
    }

    public string GetNameAndComments()
    {
        return $" {_name} {_commentText}";
    }

    public void DisplayComment()
    {
        Console.WriteLine();
        Console.WriteLine($"Commenter: {_name}");
        Console.WriteLine($"Comment: {_commentText}");
        Console.WriteLine();
      //  Console.WriteLine("---------------------------------------------");
    }
}

