using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfIdenticalStringsInExpression
{
  class NumberOfIdenticalStrings
  {
    static void Main(string[] args)
    {
      string myString = "The blue bird is flying over the blue ocean as a plane is flying blue";
      FindNumberOfIdenticalStrings(myString);
    }

static void FindNumberOfIdenticalStrings(string theString)
    {
      string[] newString = theString.ToLower().Split();
      Array.Sort(newString);
      int count = 1;
  for(int index = 0; index<newString.Length-1; ++index)
  {
    if(newString[index]==newString[index +1])
    {
      ++count;
    }
    else
    {
      Console.WriteLine("The count is {0}: {1} ", newString[index], count);
      count = 1;
    }
  }
    }
  }
}
