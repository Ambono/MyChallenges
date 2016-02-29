using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCompressionDecompression
{
  class StringCompression
  {
    static void Main(string[] args)
    {
      CompressString("arronSpelling");
    }
    static void CompressString(string str)
    {
      int count = 1;
      string newStr = string.Empty;
      string strlc = str.ToLower();
      for (int strcharcount = 0; strcharcount < str.Length -1; ++strcharcount)
      {
        if (str[strcharcount] == str[strcharcount + 1])
        {
          ++count;
        }
        else
        {
          newStr += str[strcharcount] +""+ count;
          count = 1;
        } 
      }
      if (newStr.Length <= str.Length)
      {
        Console.WriteLine(newStr);
      }
      else
      {
        Console.WriteLine(str);
      }

    }
  }
}
