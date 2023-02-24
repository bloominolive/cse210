public class Activity {

    private const int _defaultSpinTime = 2;

    private string _spinner {get; set;}

    public string _name {get; set;}

    public string _description {get; set;}

    public int _timeDuration {get; set;}

    private void DisplayIntroduction(){
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine($"This activity will help you {_description}");
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session?");
    }

    private void DisplayConclusion(){
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Spin();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_timeDuration} seconds of the {_name}");
        Spin();
        Console.Clear();
    }

    private void SetDurationFromUserInput()
    {
        try{
            _timeDuration = Int32.Parse(Console.ReadLine());
        }
        catch{
            _timeDuration = 30;
        }
    }

    private void DisplayGetReady(){
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Spin();
        Console.WriteLine();
    }

    public void Spin(int timeInSeconds = _defaultSpinTime){
        while(timeInSeconds > 0){
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            timeInSeconds--;
        }          
    }

    public void DisplayCountDown(int timeInSeconds){
        while (timeInSeconds > 0){
            Console.Write($"{timeInSeconds}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            timeInSeconds--;
        }
    }

    public void BeginActivity(Action activity){
        DisplayIntroduction();
        SetDurationFromUserInput();
        DisplayGetReady();
        activity();
        DisplayConclusion();
    }
}