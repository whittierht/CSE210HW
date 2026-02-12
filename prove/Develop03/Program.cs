using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("");
        Verse verse = new Verse(reference, "");

        while (!verse.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(verse.GetText());
            Console.WriteLine("Press Enter to continue or type quit: ");

            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            verse.HideRandomWords(3);
        }
    }
}
