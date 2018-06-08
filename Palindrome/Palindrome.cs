using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
  class Program
  {
    static void Main(string[] args)
    {
     Console.WriteLine (isPalindrome("today"));
    }

    private static bool isPalindrome(String palindrome)
    {
      String newWord = string.Empty;
      for (int i = palindrome.Length - 1; i >= 0; --i)
      {
        newWord += palindrome[i];
      }

      return palindrome == newWord;
    }
  }
}
<!--
  
  in javascript
  function palindrome(str) {
    var len = str.length;
    for ( var i = 0; i < Math.floor(len/2); i++ ) {
        if (str[i] !== str[len - 1 - i]) {
            return false;
        }
    }
    return true;
}
  
  -->
