using System;

class Journal
{
    List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void WriteJournalEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }
    }
    
    public void DisplayJournalEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToCSV()
    {
        List<string> records = new List<string>();
        foreach (Entry entry in entries)
        {
            records.Add(entry.GetEntryAsCSV());   
        }
        Console.WriteLine("Name of file to save?");
        string _fileName = Console.ReadLine();

        File.WriteAllLines(_fileName, records);
    }

    public void LoadFromCSV()
    {
        Console.WriteLine("Name of file to load?");
        string _fileName = Console.ReadLine();

        List<string> records = System.IO.File.ReadAllLines(_fileName).ToList();
        foreach (string record in records)
        {
            string[] splitString = record.Split('|');
            Entry entry = new Entry(splitString[0], splitString[1], splitString[3]);
            entries.Add(entry);
        }
    }

}