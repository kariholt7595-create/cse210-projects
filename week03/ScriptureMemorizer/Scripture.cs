using System.Collections.Generic;
using System.ComponentModel;

public class Scripture
{
    private Reference _reference;

    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    // Made some changes to this block of code to adjust for it only choosing words that aren't hidden already.
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            if (IsCompletelyHidden())
            {
                return;
            }

            int index = random.Next(_words.Count);

            while (_words[index].IsHidden())
            {
                index = random.Next(_words.Count);
            }
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        return scriptureText;
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