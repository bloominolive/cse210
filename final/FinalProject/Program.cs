using System;

class Program
{
    static void Main(string[] args)
    {
        var user = new User();
        var quit = false;
        while (!quit){
            var input = Menu.GetInput();
            switch (input){
                case "1":
                    Console.Clear();
                    if (user.IsUserLoaded()){
                        input = DifficultyMenu.GetInput();
                        object exercise;
                        switch(input)
                        {
                            case "1":
                                exercise = new BeginnerExercise();
                            break;
                            case "2":
                                exercise = new Exercise();
                            break;
                            case "3":
                                exercise = new ExpertExercise();
                            break;
                        }
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

            }
        }
    }
}