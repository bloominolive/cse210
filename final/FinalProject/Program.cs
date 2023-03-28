using System;
class Program{
    static void Main(string[] args)
    {
        var user = new User();
        var highScores = new HighScores();
        var game = new Game();
        var quit = false;
        Console.WriteLine("Welcome to the typing game!");
        user = user.CreateOrLoadUser();
        while (!quit)
        {
            var input = Menu.GetInput();
            switch (input)
            {
                case "1":
                    Console.Clear();
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
                    var lines = exercise.GetNumberOfLines();
                    game.StartGame(lines);
                    while (lines > 0)
                    {
                        var randomLine = exercise.DisplayLine();
                        var userLine = Console.ReadLine();
                        game.SetLine(randomLine,userLine);
                        lines--;
                    }
                    game.CalculateAndDisplayScore();
                    var wpm = game.GetWordsPerMin();
                    var accuracy = game.GetAccuracy();
                    var score = exercise.GetAndDisplayScore(wpm, accuracy);
                    user.SetUserStats(score, accuracy, wpm);
                    highScores.VerifyAndSetHighScore(user.GetUserName(), score);
                    break;
                case "2":
                    Console.Clear();
                    HighScoreMenu.DisplayHighScores(highScores);
                    break;
                case "3":
                    Console.Clear();
                    user.DisplayUserInfo();
                    break;
                case "4":
                    highScores.SaveHighScores();
                    user.SaveUser();
                    quit = true;
                    break;
            }
        }
    }
}