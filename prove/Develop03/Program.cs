using System;

class Program
{
    static void Main(string[] args)
    {
        var reference = new Reference("John", 3, 15, 16);
        var scriptureText = "That whosoever believeth in him should not perish, but have eternal life. For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        var scripture = new Scripture(reference, scriptureText);
        
        scripture.SetDifficulty();
        var input = "";        
        while (true) 
        {
            Console.WriteLine(scripture.GetRenderedText());
            input = Menu.GetInput();
            if(input == "Q" || input == "q"){
                break;
            }
            if(scripture.IsCompletelyHidden()){
                break;
            }
            scripture.HideWords();
        }
    }
}