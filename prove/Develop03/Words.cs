public class HideRandomWords
{
    private string _text;
    private bool _inHidden;

    public void Word(string text)
    {
       _text  = text;
    }

    public void Hide()
    {
        _text = "";
    }
}
