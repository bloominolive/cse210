using System.Text;

public class HighScores {

    public HighScores(){
        this._scores = LoadHighScores();
    }
    private List<KeyValuePair<int,string>> _scores;
    public void VerifyAndSetHighScore(string user, int score)
    {
        if (_scores.Count() <= 10)
        {
            _scores.Add(new KeyValuePair<int,string>(score, user));
            return;
        }
        var lowHighScore = _scores.OrderBy(i => i.Key).FirstOrDefault();
        if(lowHighScore.Key < score)
        {
            _scores.Remove(lowHighScore);
            _scores.Add(new KeyValuePair<int,string>(score, user));
        }
    }
    public List<KeyValuePair<int,string>> LoadHighScores()
    {
        List<KeyValuePair<int,string>> scores = new List<KeyValuePair<int,string>>();
        try
        {
            using(var reader = new StreamReader(@$"highscores.csv"))
            {   
                while ((!reader.EndOfStream)) 
                {
                    var values = reader.ReadLine().Split('|');
                    scores.Add(new KeyValuePair<int,string>(int.Parse(values[0]),values[1]));             
                }
            }            
            return scores;
        }
        catch
        {
            Console.WriteLine("Data could not be loaded from the file.");
        }
        return new List<KeyValuePair<int,string>>();
    }
    public void SaveHighScores()
    {
        string file = "highscores.csv";
        StringBuilder scores = new StringBuilder();
        scores.Clear();
        foreach(KeyValuePair<int,string> pair in _scores)
        {
            scores.AppendLine($"{pair.Key}|{pair.Value}");
        }
        
        try
        {
            File.WriteAllText(@$"{file}", scores.ToString());
            Console.WriteLine($"Scores saved to {file}");
        }
        catch (Exception)
        {
            Console.WriteLine("Data could not be written to the file.");
            return;
        }
    }
    public List<string> GetOrderedHighScores()
    {
        var list = new List<string>();
        var scoreNumber = 1;
        if(_scores != null)
        {
            foreach (var score in _scores.OrderByDescending(i => i.Key))
            {
            list.Add($"{scoreNumber}. Score: {score.Key}  User: {score.Value}");
            scoreNumber++;
            }
        }        
        return list;
    }
}