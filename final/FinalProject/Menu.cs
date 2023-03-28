public static class Menu {
    private static string _header="Let's begin! What would you like to do?";
    private static string _footer="Please select an option to continue:";
    private static readonly Dictionary<int, string> _options = new Dictionary<int, string>()
    {
        {1, "New Game" },
        {2, "View High Scores"}, 
        {3, "View User Stats"},
        {4, "Quit"}
    };
    public static string GetInput()
    {
        Console.WriteLine($"{_header}");
        for (int i = 1; i <= _options.Count(); i++)
        {
            Console.WriteLine($"{i}. {_options[i]}");
        }
        Console.WriteLine($"{_footer}");
        return Console.ReadLine();
    }
}