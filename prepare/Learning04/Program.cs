using System;

class Program
{
    static void Main(string[] args)
    {

        var assignment = new Assignment("Hyrum Whittier", "Creative Writing");

        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();



        var math = new MathAssignment("Kari Whittier", "Algebra", "5.2", "1-15, 18-20");

        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine();



        var writing = new WritingAssignment("Danny Star", "Modern Literature", "The Evolution of Storytelling");

        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
        Console.WriteLine();



        var randomMath = new MathAssignment("Hyrum Whittier", "Geometry", "9.4", "3-12");

        Console.WriteLine(randomMath.GetSummary());
        Console.WriteLine(randomMath.GetHomeworkList());
        Console.WriteLine();
    }
}