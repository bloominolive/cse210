public class Exercise {

    protected List<string> _lines;
    
    protected int _numberOfLines;

    public Exercise(){
        _lines = new List<string> {
            "cat act tac coat oat",
            "ship his sip hip ship",
            "mount count tout sound round",
            "truck track ruck stuck luck",
            "bird rid rib bid brim",
            "bake bake take snake make",
            "snore sore nor more score",
            "jog jog dog fog log",
            "water waiter rate tear tare",
            "light night fight might right",
            "brush rush hush lush mush",
            "bread beard read bead bred",
            "swim slim dim trim prim",
            "town gown down frown crown",
            "fry try dry sky by",
            "hike like bike mike pike",
            "chair hair pair fair stair",
            "sun fun run bun stun",
            "drum rum gum hum sum",
            "shirt skirt dirt hurt flirt",
            "queen seen keen teen mean",
            "bend send lend end trend",
            "chalk talk walk stalk balk"
        };
        _numberOfLines = 8;
   }

    public string DisplayLine(){
        var line = GetRandomLine();
        Console.WriteLine(line);
        return line;
    }

    public string GetRandomLine(){
        Random rnd = new Random();
        int randomIndex = rnd.Next(_lines.Count);
        return _lines[randomIndex];
    }

    public virtual int CalculateScore(double wpm, int accuracy){
        var score = 0;
        if(wpm > 40 && wpm <= 54){
            score = 20;
        }
        else if(wpm > 55){
            score = 30;
        }

        if(accuracy > 70 && accuracy <= 89){
            score += 20;
        }
        else if(accuracy > 90 && accuracy <= 99){
            score += 30;
        }
        else if(accuracy == 100){
            score += 40;
        }

        return score;
    }


}