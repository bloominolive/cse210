public class HighScores {
    private Dictionary<int, string> _scores;

    public void SetHighScore(string name){}
    public void CheckForHighScore(int score){}
    public void LoadHighScores(){}
    public void SaveHighScores(){}

    public List<string> GetOrderedHighScores(){
        var list = new List<string>();
        var scoreNumber = 1;
        if(_scores != null){
            foreach (var score in _scores.OrderBy(i => i.Key))
            {
            list.Add($"{scoreNumber}. Score: {score.Key}  User: {score.Value}");
            scoreNumber++;
            }
        }
        
        return list;
    }

}