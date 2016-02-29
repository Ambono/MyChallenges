using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingLinq
{
  class Linq
  {
    static void Main(string[] args)
    {
    }

    /// <summary>
    /// Duplicate word removal.
    /// </summary>
    /// <param name="sentence"></param>
    static void DuplicateWordRemoval(string sentence)
    {

      /// *************** remove word duplicate
      //string sentencetest = "Hello word of today Hello word of tomorrow";
      //DuplicateWordRemoval(sentencetest);

      string[] duplicatedword = sentence.Split();

      var wordString = from word in duplicatedword
                       let uppercaseString = word.ToLower()
                       orderby uppercaseString
                       select uppercaseString;

      foreach (var item in wordString)
      {
        Console.WriteLine("{0}", item);
      }

      Console.WriteLine("//////////////////");

      foreach (var item in wordString.Distinct())
      {
        Console.WriteLine("{0}", item);
      }

    }

    /// <summary>
    /// Duplicate characters removal.
    /// </summary>
    /// <param name="duplicatedCharacters"></param>
    public static void removeDuplicateCharacters(List<char> duplicatedCharacters)
    {
      //**************remove character duplicate
      //string test = "anticonstitutionellementtodays";
      //List<char> listchar = new List<char>() { };
      //for (int index = 0; index < test.Length; ++index)
      //{
      //  listchar.Add(test[index]);
      //}
      var dupcharasc = from singlechar in duplicatedCharacters
                       orderby singlechar
                       select singlechar;

      var dupchardesc = from singlechardesc in duplicatedCharacters
                        orderby singlechardesc descending
                        select singlechardesc;

      Console.WriteLine("//////////////////ASCENDING");
      foreach (var item in dupcharasc)
      {
        Console.WriteLine("{0}", item);
      }

      Console.WriteLine("///////////////////////////DESCENDING");

      foreach (var item in dupchardesc)
      {
        Console.WriteLine("{0}", item);
      }


      Console.WriteLine("///////////////////////////DISTINCT");

      foreach (var item in dupcharasc.Distinct())
      {
        Console.WriteLine("{0}", item);
      }
    } //end method

    /// <summary>
    /// first element in array.
    /// </summary>
    /// <param name="firstELement"></param>
    static void selectFirstElement(int[] firstELement)
    {

      var result = from item in firstELement
                   orderby item
                   select item;
      if (result.Any())
      {
        Console.WriteLine(result.First());
      }
      else
      {
        Console.WriteLine("Not found");
      }
    }

  }
}
