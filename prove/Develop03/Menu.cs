public static class Menu{
    private const string _menu = "Please press Enter to continue. Type \"Q\" to quit.";

     public static string GetInput(){
        Console.WriteLine($"{_menu}");
        return Console.ReadLine();
    }
}