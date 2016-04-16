using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTutorialsPlatform
{
    class PerformanceTutorialsFile
    {
        static void Main(string[] args)
        {
            int [] feezbuzz= {1, 3, 7,5,15, 4, 21, 25, 13, 5, 20, 15};
            displayfeezbuzz(feezbuzz);
        }

        static void displayfeezbuzz(int [] feezBuzz)
        {
            for (int index = 0; index < feezBuzz.Length; ++index)
            {
                if(feezBuzz[index]%3!=0&&feezBuzz[index]%5!=0)
                {
                    Console.WriteLine(feezBuzz[index] + " ");
                }
                if (feezBuzz[index] % 3 == 0)
                {
                    Console.WriteLine("feez ");
                }
                if (feezBuzz[index] % 5 == 0)
                {
                    Console.WriteLine("buzz ");
                }

            }

        }
    }
}
