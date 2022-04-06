using System;

namespace Permutation_in_String
{
  class Program
  {
    static void Main(string[] args)
    {
      string s1 = "abcde";
      string s2 = "eidabooo";
      Program p = new Program();
      var result = p.CheckInclusion(s1, s2);
      Console.WriteLine(result);
    }

    public bool CheckInclusion(string s1, string s2)
    {
      int s1length = s1.Length;
      int s2length = s2.Length;
      bool containsInclusion = false;
      // if s1 length is bigger then we cant have a substring of length s1 in s2.
      if (s1length > s2length) return containsInclusion;
      var arr1 = s1.ToCharArray();
      Array.Sort(arr1);
      // sort and recreate the s1 string
      s1 = new string(arr1);
      int i = 0;
      // at any given position there should be at least s1 length eq or greater chars must be present to create a substring
      while(i < s2length && s2length - i >= s1length)
      {
        // create substring from current position in  s2 of length s1.
        string subStr = s2.Substring(i, s1length);
        var arr2 = subStr.ToCharArray();
        Array.Sort(arr2);
        // sort the substring
        subStr = new string(arr2);
        // s1 permutation string is said to be a substring of s2 only when
        // sorted s1 and substr of s2 are same.
        containsInclusion =  subStr == s1;
        if (containsInclusion) break;
        i++;
      }

      return containsInclusion;
    }
  }
}
