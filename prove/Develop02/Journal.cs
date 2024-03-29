using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    List<Entry> entries;
    PromptGenerator promptGenerator;
    public Journal()
    {
        entries = new List<Entry>();
        promptGenerator = new PromptGenerator();
    }

    public void WriteJournalEntries()
{
    Console.WriteLine("Enter the date (e.g. May 7, 2023):");
    string date = Console.ReadLine();

    Console.WriteLine("Choose a prompt:");
    PromptGenerator promptGenerator = new PromptGenerator();
    string prompt = promptGenerator.GetRandomPrompt();
    Console.WriteLine(prompt);

    Console.WriteLine("Enter your response:");
    string response = Console.ReadLine();

    Entry entry = new Entry(date, prompt, response);
    entries.Add(entry);

    Console.WriteLine("Entry added successfully.");
}
  
    public void DisplayJournalEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToCSV(string fileName)
    {
        List<string> records = new List<string>();
        foreach (Entry entry in entries)
        {
            records.Add(entry.GetEntryAsCSV());   
        }
        File.WriteAllLines(fileName, records);
        Console.WriteLine("Name of file to save?");
        string _fileName = Console.ReadLine();

        File.WriteAllLines(fileName, records);
    }

    public void LoadFromCSV(string fileName)
    {
        Console.WriteLine("Name of file to load?");
        string _fileName = Console.ReadLine();
        entries.Clear(); // Add this line to clear existing entries before loading from the file

        List<string> records = File.ReadAllLines(fileName).ToList();
        foreach (string record in records)
        {
            string[] splitString = record.Split('|');
            Entry entry = new Entry(splitString[0], splitString[1], splitString[2]);
            entries.Add(entry);
        }
    }
}