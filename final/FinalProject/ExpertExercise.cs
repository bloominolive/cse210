public class ExpertExercise : Exercise
{    
   public ExpertExercise(){
        _lines = new List<string> {
            "salad ask sad all lad",
            "trend end lend send bend",    
            "humor rumor tumor tumor hum",    
            "omen oven even venom move",    
            "cower power shower tower lower",    
            "grove glove love drove prove",    
            "joust just shout stout south",    
            "tryst try dry dusty study",    
            "siren risen resin grin sin",    
            "prawn pawn fawn dawn lawn",    
            "phone hone bone lone zone",    
            "scowl howl owl bowel towel",    
            "clank flank bank plank rank",    
            "light night might sight tight",    
            "surge urge merge purge dirge",    
            "swine twine pine dine vine",    
            "slack jack pack knack lack",    
            "flint glint tint mint hint",    
            "furry hurry curry jury bury",    
            "fluff bluff cuff rough tough",    
            "spade shade spate stade made",    
            "pilot plot lot lit tilt",    
            "bleat beat meat seat heat",    
            "wince mince since prince rinse",    
            "halve have rave wave pave",    
            "flute lute mute cute chute"
        };
        _numberOfLines = 10;
   }
  
    public override int CalculateScore(double wpm, int accuracy){
        var score = 0;
        if(wpm > 50 && wpm <= 59){
            score = 30;
        }
        else if(wpm > 60 && wpm <= 69){
            score = 40;
        }
        else if(wpm > 70 && wpm <= 79){
            score = 60;
        }
        else if(wpm > 80 && wpm <= 100){
            score = 90;
        }
        else if(wpm > 100){
            score = 500;
        }

        if(accuracy > 70 && accuracy <= 89){
            score += 30;
        }
        else if(accuracy > 90 && accuracy <= 99){
            score += 40;
        }
        else if(accuracy == 100){
            score += 50;
        }

        return score;
    }
}