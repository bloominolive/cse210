public static class UserMenu {
    private static readonly Dictionary<int, string> _options = new Dictionary<int, string>()
    {
        {1, "Create User"},
        {2, "Load User"}
    };
    private static string _header="User options: ";
    private static string _footer="Please select your option: ";
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