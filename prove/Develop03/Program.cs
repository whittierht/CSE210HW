class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Verse verse = new Verse(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        string input = "";

        while (input != "quit" && !verse.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(verse.GetText());
            Console.WriteLine();
            Console.Write("Press Enter to continue or type quit: ");

            input = Console.ReadLine();

            if (input != "quit")
            {
                verse.HideRandomWords(3);
            }
        }
    }
}
