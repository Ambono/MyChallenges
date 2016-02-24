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
      int Sumup = 0;
      int Sumdown = 0;

      for(int up = 0; up<A.Length; ++up)
      {
        for(int down = A.Length -1; down >=0 ;--down)
        {
          Sumup +=A[up];
          Sumdown += A[down];
          if((down - up == 2) && Sumup == Sumdown)
          {
            return up + 1;
          }
        }
      }

      return -1;
    }
  }
}
