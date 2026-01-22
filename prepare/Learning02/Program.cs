using System;

class Program
{
    static void Main(string[] args)
    {

  
        Job job1 = new Job();
        job1._jobTitle = "SEO Lead";
        job1._company = "Hangar Marketing";
        job1._startYear = 2025;
        job1._endYear = 2026;


        Job job2 = new Job();
        job2._jobTitle = "Customer Support Representative";
        job2._company = "Squeeze Media";
        job2._startYear = 2024;
        job2._endYear = 2025;

        job1.Display();
        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Hyrum Whittier";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}