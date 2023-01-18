using System;

class Program
{
    static void Main(string[] args)
    {
        var job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Software Pros";
        job1._startYear = 1999;
        job1._endYear = 2020;
        
        var job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Circuit City";
        job2._startYear = 2020;
        job2._endYear = 2021;

        var myResume = new Resume();
        myResume._name = "Bob Ross";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

        
    }

}

   