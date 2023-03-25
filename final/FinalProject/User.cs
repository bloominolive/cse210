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

    public void SetHighScore(int score){}

    public void SetHighAccuracy(int accuracy){}
    public void SetHighWordsPerMin(int wpm){}
    public bool IsUserLoaded(){
        return true;
    }
    public void CreateUser(){}
    public void LoadUser(){}
    public void SaveUser(){}
    public void DisplayUserInfo(){}


}