public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    
    public Scripture(Reference reference, string text)
    {
        // Spliting up the words in text and storing each as a word object in the list _words
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
       
        // Creating word object and puting it into _words 

        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        var wordsToHide = visibleWords.OrderBy(x => Guid.NewGuid()).Take(numberToHide).ToList();

         // looping through each word
        foreach (var word in wordsToHide)
        {
            // using the Hide function 
            word.Hide();
        }
    }

    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()} ";
        foreach (var word in _words)
        {
            displayText += word.IsHidden() ? "___ " : word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}





