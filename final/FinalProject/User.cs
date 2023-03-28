using System.Text;
public class User {
    public User(string name, int highScore, decimal highAccuracy, double highWordsPerMin)
    {
        this._name = name;
        this._highAccuracy = highAccuracy;
        this._highScore = highScore;
        this._highWordsPerMin = highWordsPerMin;
    }
    public User(){}
    private string _name;
    private int _highScore;
    private decimal _highAccuracy;
    private double _highWordsPerMin;
    private void SetHighScore(int score)
    {
        if (score > _highScore)
        {
            _highScore = score;
        }
    }
    private void SetHighAccuracy(decimal accuracy)
    {
        if (accuracy > _highAccuracy)
        {
            _highAccuracy = accuracy;
        }
    }
    private void SetHighWordsPerMin(double wpm)
    {
        if (wpm > _highWordsPerMin)
        {
            _highWordsPerMin = wpm;
        }
    }
    public string GetUserName()
    {
        return _name;
    }
    public void SetUserStats(int score, decimal accuracy, double wpm)
    {
        SetHighScore(score);
        SetHighAccuracy(accuracy);
        SetHighWordsPerMin(wpm);
    }
    public User CreateOrLoadUser()
    {
        User user = new User();
        Console.WriteLine("Please enter a username: ");        
        var name  = Console.ReadLine();        
        try
        {
            using(var reader = new StreamReader(@$"users\{name}.csv"))
            {   
                while ((!reader.EndOfStream)) 
                {
                    var values = reader.ReadLine().Split('|');
                    user = new User(values[0], int.Parse(values[1]), decimal.Parse(values[2]), double.Parse(values[3]));             
                }
            }
        }
        catch
        {
            user._name = name;
        }
        return user;        
    }
    public void SaveUser()
    {
        string file = $"{_name}.csv";
        StringBuilder user = new StringBuilder();
        user.Clear();
        user.AppendLine($"{_name}|{_highScore}|{_highAccuracy}|{_highWordsPerMin}");
        try
        {
            File.WriteAllText(@$"users\{file}", user.ToString());
            Console.WriteLine($"User saved to {file}");
        }
        catch (Exception)
        {
            Console.WriteLine("Data could not be written to the file.");
            return;
        }
    }
    public void DisplayUserInfo()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Highest Words Per Minute {_highWordsPerMin}");
        Console.WriteLine($"Highest Accuracy: {_highAccuracy}");
        Console.WriteLine($"High Score: {_highScore}");
    }
}