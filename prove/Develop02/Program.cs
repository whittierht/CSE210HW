using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";

          while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                
            }
            else if (choice == "2")
            {
                
            }
            else if (choice == "3")
            {

            }
            else if (choice == "4")
            {
                
            }
            else if (choice == "5")
            {

            }
            else
            {
                Console.WriteLine("enter a number that is 1–5.\n");
            }
        }
    }
}
