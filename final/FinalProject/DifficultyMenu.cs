public static class DifficultyMenu {

    private static readonly Dictionary<int, string> _options = new Dictionary<int, string>(){
        {1, "Beginner"},
        {2, "Intermediate"},
        {3, "Expert"}
    };
    private static string _header="Difficulty options: ";
    private static string _footer="Please select your difficulty: ";

    public static string GetInput(){
        Console.WriteLine($"{_header}");
        for (int i = 1; i <= _options.Count(); i++){
            Console.WriteLine($"{i}. {_options[i]}");
        }
        Console.WriteLine($"{_footer}");
        return Console.ReadLine();
    }
}