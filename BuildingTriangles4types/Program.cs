using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingTriangles4types
{

  class Program
  {
    enum Triangles
    {
      ISOCELE,
      EQUILATERAL,
      SCALENE,
      NOTFOUND
    }

    static void Main(string[] args)
    {

      Console.WriteLine(BuildTriangles(5, 1, 2));
    }


    static string BuildTriangles1(int sideA, int sideB, int sideC)
    {


        if (sideA == 0 || sideB == 0 || sideC == 0)
        {
            return Enum.GetName(typeof(Triangles), Triangles.NOTFOUND);
        }

        if ((sideA + sideB > sideC) || (sideA + sideC > sideB) || (sideC + sideB > sideA))
        {

            if (sideA == sideB && sideA == sideC)
            {
                return Enum.GetName(typeof(Triangles), Triangles.EQUILATERAL);
            }

            if ((sideA == sideB && sideA != sideC) || (sideA == sideC && sideA != sideB))
            {
                return Enum.GetName(typeof(Triangles), 0);
            }

            if (sideA != sideB && sideA != sideC)
            {
                return Enum.GetName(typeof(Triangles), Triangles.SCALENE);
            }
        }

        return Enum.GetName(typeof(Triangles), Triangles.NOTFOUND);
    }



    static string BuildTriangles(int sideA, int sideB, int sideC)
    {


      if (sideA == 0 || sideB == 0 || sideC == 0)
      {
        return Enum.GetName(typeof(Triangles), 3);
      }

      if ((sideA + sideB > sideC) || (sideA + sideC > sideB) || (sideC + sideB > sideA))
      {

        if (sideA == sideB && sideA == sideC)
        {
          return Enum.GetName(typeof(Triangles), 1);
        }

        if ((sideA == sideB && sideA != sideC) || (sideA == sideC && sideA != sideB))
        {
          return Enum.GetName(typeof(Triangles), 0);
        }

        if (sideA != sideB && sideA != sideC)
        {
          return Enum.GetName(typeof(Triangles), 2);
        }
      }

      return Enum.GetName(typeof(Triangles), 3);
    }


    static Enum BuildTriangles2(int sideA, int sideB, int sideC)
    {
      if (sideA == 0 || sideB == 0 || sideC == 0)
      {
        return Triangles.NOTFOUND;
 
      }

      if ((sideA + sideB > sideC) || (sideA + sideC > sideB) || (sideC + sideB > sideA))
      {

        if (sideA == sideB && sideA == sideC)
        {
          return Triangles.EQUILATERAL;
 
        }

        if ((sideA == sideB && sideA != sideC) || (sideA == sideC && sideA != sideB))
        {
          return Triangles.ISOCELE;

        }

        if (sideA != sideB && sideA != sideC)
        {
          return Triangles.SCALENE;

        }
      }

      return Triangles.NOTFOUND;
 
    }
  }
}
