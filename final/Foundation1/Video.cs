public class Video
{
    public string _title;
    public string Author;
    public int _lenght;
    public List<Comment> _comments;

    public Video()
    {
        _comments = new List<Comment>();
    }

    public int NumberOfComments()
    {
        return _comments.Count;
    }

    public void AddComment(string commenterName, string commentText)
    {
        Comment comment = new Comment(commenterName, commentText);
        _comments.Add(comment);

        // foreach (var commentNew in _comments)
        // {
        //    Console.WriteLine($" New comments {commentNew} ");
            
        // }
    }

    public string GetVideoAuthorAndTitle()
    {
        return $" {_title} {Author}";
    }

    public int GetVidoeLenght()
    {
        return _lenght;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine(" ");
        Console.WriteLine($"YouTube Video title: {_title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Number of Comments: {NumberOfComments()}");

        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"Commenter: {comment._name}");
            Console.WriteLine($"Comment: {comment._commentText}");
            Console.WriteLine("*******************************************");
        }
    }
}

