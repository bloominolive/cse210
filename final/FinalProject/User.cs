public class User {
    public User(string name){
        this._name = name;
    }
    public User(){

    }

    private string _name;
    private int _highScore;
    private int _highAccuracy;
    private int _highWordsPerMin;

    public SetHighScore(int score){}

    public SetHighAccuracy(int accuracy){}
    public SetHighWordsPerMin(int wpm){}
    public bool IsUserLoaded(){}
    public void CreateUser(){}
    public void LoadUser(){}
    public void SaveUser(){}
    public void DisplayUserInfo(){}


}