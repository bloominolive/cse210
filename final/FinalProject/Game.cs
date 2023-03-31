public class Game{
    private List<KeyValuePair<string,string>> _lines = new List<KeyValuePair<string, string>>();
    private decimal _accuracy;
    private double _wordsPerMin;
    private DateTime _startTime;
    private DateTime _endTime;

    public void StartGame(int numberOfLines){
        Console.Clear();
        Console.WriteLine($"In this exercise you will be given {numberOfLines} lines to copy. Try to type the line exactly as shown.");
        Console.WriteLine("Press enter at the end of each line to see the next line. You will be scored for accuracy, WMP and be given an overall score.");
        Console.WriteLine("Press Enter to start!");
        Console.ReadLine();
        Console.Clear();
        SetStartTime();
    }
    public void CalculateAccuracy(){
        decimal matchCount = 0;
        decimal totalCount = 0;
        foreach(KeyValuePair<string, string> pair in _lines)
        {
            totalCount += pair.Key.Length;
            for (int i = 0; i < pair.Key.Length && i < pair.Value.Length; i++)
            {
                if (pair.Key[i] == pair.Value[i])
                {
                    matchCount++;
                }
            }
        }
        _accuracy = (matchCount / totalCount) * 100;
    }
    public void CalculateWordsPerMin(){
        var words = 0;
        foreach(var value in _lines.Select(i => i.Value) )
        {
            words += value.Split(' ').Length;
        }
        _wordsPerMin = words / (_endTime - _startTime).TotalMinutes;
    }
    public void SetLine(string randomLine, string userLine)
    {
        _lines.Add(new KeyValuePair<string,string>(randomLine, userLine));
    }
    public void SetStartTime()
    {
        _startTime = DateTime.UtcNow;
    }
    public void SetEndTime()
    {
        _endTime = DateTime.UtcNow;
    }
    public void CalculateAndDisplayStats()
    {
        SetEndTime();
        CalculateWordsPerMin();
        CalculateAccuracy();
        Console.WriteLine($"Your accuracy is: " + _accuracy.ToString("F2"));
        Console.WriteLine($"Your words per minute is: " + _wordsPerMin.ToString("F2"));
    }
    public double GetWordsPerMin()
    {
        return _wordsPerMin;
    }
    public decimal GetAccuracy()
    {
        return _accuracy;
    }
}