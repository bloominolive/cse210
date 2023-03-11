using System;

class Program
{
    //EXCEEDS REQUIREMENTS: 
    //1. I have added a leveling system that will display a users level starting at 1 and increasing 1 level for every 250 points.
    //2. I have added functionality to check if goals have been altered since last save. If they have and are trying to quit it prompts them to save before quitting.
    //3. If a user has already loaded a file this session it prevents them from loading a file with the same name so that they don't compound their goals.
    //4. If the user has loaded a file and chooses to save a file on quit it will use the previously loaded file name. 

    static void Main(string[] args)
    {
        var isGoalMenu = true;
        var quit = false;
        string file;
        var progress = new Progress();
        while (!quit) 
        {
            var input = Menu.GetInput();
            switch (input){
                case "1":
                    Console.Clear();
                    input = Menu.GetInput(isGoalMenu);
                    switch(input){
                        case "1":
                            progress.AddGoal(GoalTypes.SimpleGoal);
                        break;
                        case "2":
                            progress.AddGoal(GoalTypes.EternalGoal);
                        break;
                        case "3":
                            progress.AddGoal(GoalTypes.ChecklistGoal);
                        break;
                    }
                    break;
                case "2":
                    Console.Clear();
                    progress.DisplayGoalList();
                    break;
                case "3":
                    Console.Clear();
                    Console.Write($"Enter the name of the file to save to: ");
                    file = Console.ReadLine();
                    progress.Save(file);
                    Console.Write($"File Saved! ");
                    break;
                case "4":
                    Console.Clear();
                    Console.Write($"Enter the name of the file to load: ");
                    file = Console.ReadLine();
                    progress.Load(file);
                    break;
                case "5":
                    Console.Clear();
                    if(progress.GetGoalListIncrementNumber() > 1)
                    {
                        progress.GetAndRecordEvent();
                    }
                    else{
                        Console.WriteLine("Please Create New a New Goal First.");
                    }
                    break;
                case "6":
                    if(!progress.IsSaved())
                    {
                        var isConfirmed = Menu.PromptSaveOnQuit();
                        if(isConfirmed)
                        {
                            Console.Clear();
                            file = progress.GetLoadedFileName();
                            if(file == null)
                            {
                                Console.Write($"Enter the name of the file to save to: ");
                                file = Console.ReadLine();
                            }
                            progress.Save(file);
                            Console.Write($"File Saved as {file}!");
                        }
                    }
                    quit = true;
                    break;
                default:
                    break;
            }
        }
    }
}