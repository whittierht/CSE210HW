using System;
using System.Collections.Generic;

public class Verse
{
    private Reference _reference;

    private List<Word> _words;
    private static Random _random = new Random();

    public Verse(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        foreach (string part in parts)
        {
            
            _words.Add(new Word(part));
        }
    }





public void HideRandomWords(int count)
{
    List<Word> visibleWords = new List<Word>();

    foreach (Word word in _words)
    {
        if (!word.IsHidden())
        {
            visibleWords.Add(word);
        }
    }

    for (int i = 0; i < count && visibleWords.Count > 0; i++)
    {
        int index = _random.Next(visibleWords.Count);
        visibleWords[index].Hide();
        visibleWords.RemoveAt(index);
    }
}


    public string GetText()
    {
        List<string> rendered = new List<string>();

        foreach (Word word in _words)
        {
            rendered.Add(word.GetText());
        }

        return $"{_reference.GetText()}\n{string.Join(" ", rendered)}";
    }




    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}
