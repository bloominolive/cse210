public class BeginnerExercise: Exercise {     
   public BeginnerExercise():base()
   {
        _lines = new List<string> 
        {
            "ask had lad sag gas",
            "dad sad ash has dash",
            "lad had flag shag lags",
            "dash flask flask flask flask",
            "ask fads jag jag jags",
            "gash has lag hags slag",
            "shad fads lads jags",
            "sad gas hags flak slag",
            "lash has lad had ash",
            "shags flask had gas ash",
            "jag dash flak slag ask",
            "hags fads sag lags sad",
            "has had lash flag jags",
            "flask lad gas shad ash",
            "sag sad jag ash dash",
            "lags flag gash hags ask",
            "dash jag sad ash flag",
            "shad hags lag gas lads",
            "flak ask has lash sad",
            "jags flag flask lad sag",
            "ash gas had sag lash",
            "hags jags sad lag flag",
            "lad ash flask gas shad",
            "sag flag jag had dash"
        };
        _numberOfLines = 5;
   }
    public override int GetAndDisplayScore(double wpm, decimal accuracy)
    {
        var score = 0;
        if(wpm > 20)
        {
            score = 10;
        }
        if(accuracy > 70 && accuracy <= 89)
        {
            score += 10;
        }
        else if(accuracy > 90 && accuracy <= 99)
        {
            score += 20;
        }
        else if(accuracy == 100)
        {
            score += 30;
        }
        DisplayScore(score);
        return score;
    }
}