using System;

class Entry
{
    string date, prompt, response;

    public Entry(string _date, string _prompt, string _response)
    {
        date = _date;
        prompt = _prompt;
        response = _response;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"{date}: {prompt} - {response}");
    }

    public string GetEntryAsCSV()
    {
        return string.Format("{0} | {1} | {2}", date, prompt, response);
        //return $"{date} | {prompt} | {response}";
    }

}