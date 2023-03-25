using System;

class Program
{
    static void Main(string[] args)
    {
        var user = new User();
        var highScores = new HighScores();
        var game = new Game();
        //try load highscores

        var quit = false;
        while (!quit){
            var input = Menu.GetInput();
            switch (input){
                case "1":
                    Console.Clear();
                    if (!user.IsUserLoaded()){
                        input = UserMenu.GetInput();
                        switch(input)
                        {
                            case "1":
                                user.CreateUser();
                            break;
                            case "2":
                                user.LoadUser();
                            break;
                        }
                    }
                    input = DifficultyMenu.GetInput();
                    Exercise exercise;
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
                        default:
                            exercise = new Exercise();
                        break;
                    }
                    game.StartGame();
                    var randomLine = exercise.DisplayLine();
                    var userLine = Console.ReadLine();
                    game.SetLine(randomLine,userLine);
                    game.CalculateAndDisplayScore();
                    break;
                case "2":
                    Console.Clear();
                    HighScoreMenu.DisplayHighScores(highScores);
                    break;
                case "3":
                    //save highscores
                    //save user
                    quit = true;
                    break;

            }
        }
    }
}