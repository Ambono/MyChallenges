using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equilibrium
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] A = { -1, 3, -4, 5, 1, -6, 2, 1 };
      Console.WriteLine(solution(A));
    }

    public static int solution(int[] A)
    {
      // write your code in C# 6.0 with .NET 4.5 (Mono)
      LinkedList<Object> L = new LinkedList<object>();
      int[] B = new int[] { };
      int val = L.Count;
      int up = 0;
      int down = 0;
     
      for (int i = 0; i < A.Length; ++i)
      {

        for (int x = A.Length - 1; x >= 0; --x)
        {
          up += A[i];
          down += A[x];

          if ((up == down))
          {

            return i + 1;
          }

        }

      }

      return -1;
    }
  }
}
