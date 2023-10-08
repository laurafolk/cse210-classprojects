using System;
using System.Collections.Generic;

class Scripture
{
    private List<Word> words;
    private Reference scriptureReference;

    public Scripture (Reference _scriptureReference, string _scriptureText)
    {
        scriptureReference = _scriptureReference;
        words = CreateWords(_scriptureText);
    }

    private List<Word> CreateWords(string _scriptureText)
    {
        List<Word> words = new List<Word>();
        string[] wordArray = _scriptureText.Split(' ');

        foreach (string word in wordArray)
        {
            words.Add(new Word(word));
        }

        return words;
    }

    public string GetScripture()
    {
        string scripture = scriptureReference.GetReference() + " ";

        foreach (Word word in words)
        {
            if (word.GetIsHidden())
            {
                scripture += new string('_', word.GetWord().Length) + " ";
            }
            else
            {
                scripture += word.GetWord() + " ";
            }
        }

        return scripture;
    }

    public bool HasWordLeft()
    {
        foreach (Word word in words)
        {
            if (!word.GetIsHidden())
            {
                return true;
            }
        }

        return false;
    }

    public void RemoveWords()
    {
        int numWordsToRemove = new Random().Next(2, 4);
        int wordsRemoved = 0;

        do
        {
            int rndIndex = new Random().Next(0, words.Count());
            if (!words[rndIndex].GetIsHidden())
            {
                words[rndIndex].SetIsHidden(true);
                wordsRemoved++;
            }
        } while (wordsRemoved != numWordsToRemove && this.HasWordLeft());
    }    
}