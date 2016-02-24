using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeezBuzz
{
  class Feezbuzz
  {
    static void Main(string[] args)
    {
      int[] feebuzzArr = { 1, 2, 3, 4, 7, 10, 15, 13, 20 };
      DisplayFeezBuzz(feebuzzArr);      
    }
    static void DisplayFeezBuzz(int [] feebuzzArr) 
    {
    
      for(int feezBuzzIndex = 0; feezBuzzIndex < feebuzzArr.Length; ++feezBuzzIndex)
      {
        if (feebuzzArr[feezBuzzIndex] % 3 !=0 && feebuzzArr[feezBuzzIndex]%5 !=0)
        {
          Console.Write(feebuzzArr[feezBuzzIndex]+ " ");
        }
       if(feebuzzArr[feezBuzzIndex]%3 ==0)
       {
         Console.Write("Feez ");
       }
       if(feebuzzArr[feezBuzzIndex]%5 ==0)
       {
         Console.Write("Buzz ");
       }
      }
      Console.WriteLine();
    }
  }
}
