using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panagram
{
 static class Program
  {
    static void Main(string[] args)
    {
      string test = "The quick brown fox jumps over the lazy dog";
      //Console.WriteLine(arguments.Any() && arguments.First().IsPangram());
      Console.WriteLine(IsPangram(test));
    }
    
    private static bool IsPangram(this string text)
    {
      string alphabet = "abcdefghijklmnopqrstuvwxyz";
      return alphabet.All(text.ToLower().Contains);
    }

  }
}
