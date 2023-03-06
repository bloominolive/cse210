using System;

class Program
{
    static void Main(string[] args)
    {   
        //EXCEED EXPECTATIONS COMMENT:
        //To exceed expectations I have added an unused question and unused prompt property to certain classes in order to avoid repeating questions and prompts during a single session.

        var breathingActivity = new BreathingActivity();
        var reflectingActivity = new ReflectingActivity();  
        var listingActivity = new ListingActivity();
        var quit = false;
        while (!quit) 
        {
            var input = Menu.GetInput();
            switch (input){
                case "1":
                    breathingActivity.RunActivity();
                    break;
                case "2":
                    reflectingActivity.RunActivity();
                    break;
                case "3":
                    listingActivity.RunActivity();
                    break;
                case "4":
                    quit = true;
                    break;
                default:
                    break;
            }
        }
    }
}