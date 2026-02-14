using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Verse> verses = new List<Verse>
        {
            new Verse(
                new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
            ),
            new Verse(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
            ),
            new Verse(
                new Reference("Mosiah", 2, 17),
                "When ye are in the service of your fellow beings ye are only in the service of your God."
            ),
            new Verse(
                new Reference("2 Nephi", 2, 25),
                "Adam fell that men might be; and men are, that they might have joy."
            )
        };



        Random random = new Random();
        int startIndex = random.Next(verses.Count);
        int currentIndex = startIndex;
        int completedCount = 0;
        string input = "";
//This is cool cause it filters through all of the verse randomly
        while (input != "quit" && completedCount < verses.Count)
        {
            Verse verse = verses[currentIndex];
            if (verse.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine("Good Job!!");
                Console.WriteLine("Press Enter to continue to the next verse: ");
                Console.ReadLine();

                completedCount++;
                currentIndex = (currentIndex + 1) % verses.Count;
                continue;
            }




            Console.Clear();
            Console.WriteLine(verse.GetText());
            Console.WriteLine();
            Console.Write("Press Enter to continue or type quit: ");

            input = Console.ReadLine();

            if (input != "quit")
            {
                verse.HideRandomWords(1);
            }
        }
    }
}
