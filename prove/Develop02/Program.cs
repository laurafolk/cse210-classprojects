using System;

class Program //A class is just a template and becomes useful when an instance is created and assigned to
              //a variable in the program.
{
    static void Main(string[] args)  // This is the beginning of the program.
    {
        Journal journal = new Journal(); // The instance of Journal is created and assigned the variable of
        int menuUserinput = 0;
        //Menu and user input variables
        List<string> menu = new List<string>
            {
                "Please select a number from the list below: ",
                "1. Write",
                "2. Display",
                "3. Save",
                "4. Load",
                "5. Quit",
                "What would you like to do?"
            };

        while (menuUserinput != 5) //Program continues to run until the user selects 5.
        {
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            menuUserinput = int.Parse(Console.ReadLine());

            if (menuUserinput == 1)
            {
                journal.WriteJournalEntries();
            }
            else if (menuUserinput == 2)
            {
                journal.DisplayJournalEntries();
            }
            else if (menuUserinput == 3)
            {
                Console.WriteLine("Enter the filename to save the journal to:");
                string fileName = Console.ReadLine();
                journal.SaveToCSV(fileName);
                Console.WriteLine($"Journal saved to {fileName}.");
            }
            else if (menuUserinput == 4)
            {
                Console.WriteLine("Enter the filename to load the journal from:");
                string fileName = Console.ReadLine();
                journal.LoadFromCSV(fileName);
                Console.WriteLine($"Journal loaded from {fileName}.");
            }
        }
        if (menuUserinput == 5)
        {
            Console.WriteLine("Goodbye, Until the next Journal Entry.");
        } 
    }
}