public static class Menu{

    private const string _heading = "Please select one of the following choices:";

    private static List<string> _options = new List<string>(new []
    {
        "1. Write",
        "2. Display",
        "3. Load",
        "4. Save",
        "5. Quit"
    });

    private const string _footer = "What would you like to do?";

    public static int GetOption(){
        
        Console.WriteLine($"{_heading}");

        foreach (var option in _options){
            Console.WriteLine($"{option}");
        }
        Console.Write($"{_footer} ");

        return int.Parse(Console.ReadLine());
    }
}