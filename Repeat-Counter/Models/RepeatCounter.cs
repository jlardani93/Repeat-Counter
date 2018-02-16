using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace RepeatCounterProject.Models
{
  public class RepeatCounter
  {
    public static int FindFirstIndex(string userWord, string userSentence)
    {
      for (int i = 0; i < userSentence.Length; i++)
      {
        if (userSentence[i] == userWord[0])
        {
          return i;
        }
      }
      return -1;
    }

    public static List<int> GetIndexes(string userWord, string userSentence)
    {
      List<int> indexes = new List<int>();

      for (int i = 0; i < userSentence.Length; i++)
      {
        if (userSentence[i] == userWord[0])
        {
          indexes.Add(i);
        }
      }
      return indexes;
    }

    public static bool SubstringIsEqual(string userWord, string userSentence, int index)
    {
      string substring = userSentence.Substring(index, userWord.Length);
      return (userWord.Equals(substring));
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

    public static int GetRepeatCount(string userWord, string userSentence)
    {
      List<int> indexes = GetIndexes(userWord, userSentence);
      int repeatCount = 0;

      if (userWord.Length > userSentence.Length)
      {
        return 0;
      }

      foreach (int i in indexes)
      {
        if (SubstringIsEqual(userWord, userSentence, i) && SubstringIsWord(userSentence, i, i+(userWord.Length-1)))
        {
          repeatCount ++;
        }
      }
      return repeatCount;
    }
  }
}
