using System.Security.Cryptography;

public class PromptGenerator
{
    public List<string> _prompts;

    public string _words1;
    public string _words2;
    public string _words3;
    public string _words4;
    public string _words5; 



    public string GetRandomPrompt()
    {
        // I got the idea from this website 
        //  https://www.tutorialspoint.com/compile_csharp_online.php
        var random = new Random();
            
        var list = new List<string>{_words1, _words2, _words3, _words4, _words5};
        
        int index = random.Next(list.Count);
            
        // Console.Write(list[index]);
         
        // Random randomGenerator = new Random();
        // int magicNumber = randomGenerator.Next(1, 40);

        return list[index];
    }
}