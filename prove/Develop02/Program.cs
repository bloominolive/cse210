using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string file;
        bool quit = false;
        while (!quit){
            var chosenOption = Menu.GetOption();
            switch(chosenOption) 
            {
            case 1:
                string prompt = PromptGenerator.GetPrompt();
                Console.WriteLine($"{prompt}");
                Console.Write("> ");
                Entry entry = new Entry{
                    _prompt = prompt,
                    _date = DateTime.Now.ToShortDateString(),
                    _response = Console.ReadLine()
                };
                journal._entries.Add(entry);
                break;
            case 2:
                journal.Display();
                break;
            case 3:
                Console.Write($"Enter the name of the file to load: ");
                file = Console.ReadLine();
                var loadedJournal = journal.Load(file);
                journal._entries = loadedJournal._entries;
                break;
            case 4:
                Console.Write($"Enter the name of the file to load: ");
                file = Console.ReadLine();
                journal.Save(file);
                break;
            case 5:
                quit = true;
                break;
            default:
                break;
            }
    }
        
        Console.WriteLine($"");
    }
}