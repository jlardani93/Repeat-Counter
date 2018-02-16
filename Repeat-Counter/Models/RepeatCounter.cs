using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace RepeatCounterProject.Models
{
  public class RepeatCounter
  {
    private static string _userSentence;
    private static string _userWord;

    public static void SetUserSentence(string userSentence)
    {
      _userSentence = userSentence;
    }

    public static void SetUserWord(string userWord)
    {
      _userWord = userWord;
    }

    public static string GetUserSentence()
    {
      return _userSentence;
    }

    public static string GetUserWord()
    {
      return _userWord;
    }

    public static int FindFirstIndex()
    {
      for (int i = 0; i < _userSentence.Length; i++)
      {
        if (_userSentence[i] == _userWord[0])
        {
          return i;
        }
      }
      return -1;
    }

    public static List<int> GetIndexes()
    {
      List<int> indexes = new List<int>();

      for (int i = 0; i < _userSentence.Length; i++)
      {
        if (_userSentence[i] == _userWord[0])
        {
          indexes.Add(i);
        }
      }
      return indexes;
    }

    public static bool SubstringIsEqual(int index)
    {
      string substring = _userSentence.Substring(index, _userWord.Length);
      return (_userWord.Equals(substring));
    }

    public static bool SubstringIsWord(string sentence, int startIndex, int endIndex)
    {
      if (endIndex > sentence.Length && startIndex == 0)
      {
        Console.WriteLine("True in case 1");
        return true;
      }

      if (endIndex > sentence.Length && sentence[startIndex-1] == ' ')
      {
        Console.WriteLine("True in case 2");
        return true;
      }

      if (startIndex == 0 && sentence[endIndex+1] == ' ')
      {
        Console.WriteLine("True in case 3");
        return true;
      }
      else if (startIndex == 0 && sentence[endIndex+1] != ' ')
      {
        return false;
      }

      if (sentence[startIndex-1] == ' ' && sentence[endIndex+1] == ' ')
      {
        Console.WriteLine("True in case 4");
        return true;
      }
      return false;
    }

    public static int GetRepeatCount()
    {
      List<int> indexes = GetIndexes();
      int repeatCount = 0;

      if (_userWord.Length > _userSentence.Length)
      {
        return 0;
      }

      foreach (int i in indexes)
      {
        if (SubstringIsEqual(i) && SubstringIsWord(_userSentence, i, i+(_userWord.Length-1)))
        {
          repeatCount ++;
        }
      }
      return repeatCount;
    }
  }
}
