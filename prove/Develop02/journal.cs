using System.Collections.Generic;
using System.IO;




class Journal
{
    private List<Entry> _entries = new List<Entry>();
    private const string Separator = "~|~";

    private string GetProjectDirectory()
    {
        return Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {

            entry.Display();
        }
    }


    public void SaveToFile(string filename)
    {
        string fullPath = Path.Combine(GetProjectDirectory(), filename);

        using (StreamWriter writer = new StreamWriter(fullPath))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToFileString(Separator));
            }
        }
    }

    public void LoadFromFile(string filename)
    {

        string fullPath = Path.Combine(GetProjectDirectory(), filename);

        List<Entry> loadedEntries = new List<Entry>();

        foreach (string line in File.ReadAllLines(fullPath))
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                
                continue;
            }

            loadedEntries.Add(Entry.FromFileString(line, Separator));
        }

        _entries = loadedEntries;
    }
}
