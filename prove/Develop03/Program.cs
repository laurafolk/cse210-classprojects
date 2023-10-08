using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Philippians", "4", "13");
        Scripture scripture = new Scripture(reference, "I can do all things through Christ who strengtheneth me.");
        
        string userInput = "";

        while (userInput != "quit" && scripture.HasWordLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or 'quit' to end:");
            userInput = Console.ReadLine();
        }
    }
}