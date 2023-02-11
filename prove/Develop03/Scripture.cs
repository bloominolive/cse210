public class Scripture{

    public Scripture(Reference reference, string scripture){
        _reference = reference;
        _words = CreateWordList(scripture);
    }

    private Reference _reference {get; set;}

    private List<Word> _words {get; set;}

    private int _difficulty {get; set;}

    private List<Word> CreateWordList(string scripture){
        var wordList = new List<Word>();

        foreach(var word in scripture.Split(" ")){
            var insert = new Word(word);
            wordList.Add(insert);
        }

        return wordList;
    }

    public void HideWords(){
        foreach (var word in _words){
            if(!word.IsHidden()){
                var random = new Random();
                if(random.Next(_difficulty) == 0){
                    word.Hide();
                }
            }
            
        }
    }

    public void SetDifficulty(){
        Console.WriteLine("To Set Difficulty enter a number from 1-4. (1 = Hardest - 4 = Easiest)");
        var input = Console.ReadLine();
        try{
            var difficulty = Int32.Parse(input);
            if(difficulty > 4)
            {
                _difficulty = 4;
            }
            else if(difficulty < 1)
            {
                _difficulty = 1;
            }
            else
            {
                _difficulty = difficulty;
            }
        }
        catch(Exception ){
            _difficulty = 2;
        }
    }

    public string GetRenderedText(){
        var scripture = "";
        scripture+= _reference.GetRenderedText();
        foreach(var word in _words){
            scripture+= $" {word.GetRenderedText()}";
        }
        return scripture;
    }

    public bool IsCompletelyHidden(){
        foreach(var word in _words){
            if(!word.IsHidden()){
                return false;
            }
        }
        return true;
    }
}