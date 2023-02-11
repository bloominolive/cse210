public class Reference{

    public Reference(string book, int chapter, int startVerse){
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse){
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    
    private string _book {get; set;}

    private int _chapter {get; set;}

    private int _startVerse {get; set;}

    private int _endVerse {get; set;}

    public string GetRenderedText(){
        if(_endVerse != 0){
            return $"{_book} {_chapter} {_startVerse} - {_endVerse}";
        }
            return $"{_book} {_chapter} {_startVerse}";
        
    }
}