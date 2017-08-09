using System;
using System.Collections.Generic;



namespace FindAndReplace.Models
{
  public class FindAndReplaceClass
  {
    private string _word;
    private string _replacement;
    private string _sentence;

    public FindAndReplaceClass(string word, string replacement, string sentence)
    {
      _word = word;
      _replacement = replacement;
      _sentence = sentence;
    }
    public void SetWord(string word)
    {
      _word = word;
    }
    public string GetWord()
    {
      return _word;
    }
    public void SetRepalcement(string replacement)
    {
      _replacement = replacement;
    }
    public string SetRepalcement()
    {
      return _replacement;
    }
    public void SetSentence(string sentence)
    {
      _sentence = sentence;
    }
    public string GetSentence()
    {
      return _sentence;
    }
    public bool Find()
    {
      bool isFind = false;
      string[] sentenceArray = _sentence.Split(' ');
      for(int i=0 ; i<sentenceArray.Length; i++)
      {
        string temp = sentenceArray[i];
        string findWord = "";
        for(int j = 0, k=0; j < _word.Length && k < temp.Length ; )
        {
          if(_word[j] == temp[k])
          {
            k++;
            j++;
            findWord = findWord + _word[j];
          }
          else
          {
            k++;
          }
        }
        if(findWord == _word)
        {
          isFind = true;
        }
      }
      return isFind;
    }
    public string FindingAndReplacing()
    {
      string result="";
      if(Find() == true)
      {
        result = _sentence.Replace("_word", "_replacement");
      }
      else
      {
        result = "No match found";
      }
      return result;
    }
  }
}
