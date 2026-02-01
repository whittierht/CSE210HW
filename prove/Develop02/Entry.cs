using System;

class Entry
{
    private string _date;
    private string _prompt;
    private string _response;

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_response);
        Console.WriteLine();
    }

    public string ToFileString(string separator)
    {
        return $"{_date}{separator}{_prompt}{separator}{_response}";
    }

    public static Entry FromFileString(string line, string separator)
    {
        string[] parts = line.Split(separator);
        return new Entry(parts[0], parts[1], parts[2]);
    }
}
