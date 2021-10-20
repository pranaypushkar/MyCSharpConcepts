namespace Isomorphic
{ 
  using System;
  using System.Linq;
  using System.Collections.Generic;

  public class IsomorphicValidator
  {
    public void Validate()
    {
     string first = "ACAB";
     string second = "XCXY";
     
     // case if length of strings are not equal return false
     if(first.Length != second.Length)
     {
      Console.WriteLine("false");
     }

     // if count of unique characters are not equal return false
    // .Distinct() from Linq returns IEnumerable<char>
     if(first.Distinct().Count() != second.Distinct().Count())
     {
       Console.WriteLine("false");
     }

     // if frequency of unique characters are not equal  return false
     //int count = source.Count(f => f == '/'); // using Linq
     //int count = source.Split('/').Length - 1;
     // also the order in which they apprae in sequence shoudl be same
      IDictionary<char, char> map = new Dictionary<char,char>();
      for(int i = 0; i < first.Length; i++)
      {
        char mapValue = 'a';  

        if(!map.ContainsKey(first[i]))
        {
          map.Add(first[i], second[i]);
        }
        else if(map.TryGetValue(first[i], out mapValue))
        {
          if(mapValue != second[i])
          {
             Console.WriteLine("false");
          }
        }
      }

      Console.WriteLine("true");

    }
  }
}