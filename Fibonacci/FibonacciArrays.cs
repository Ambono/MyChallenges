using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class FibonacciArrays
    {
        public static void CalculateFibonacciUsingArray()
        {

            //number of elements to generate in a series
            int limit = 20;

            long[] series = new long[limit];

            //create first 2 series elements
            series[0] = 0;
            series[1] = 1;

            //create the Fibonacci series and store it in an array
            for (int i = 2; i < limit; i++)
            {
                series[i] = series[i - 1] + series[i - 2];
            }

            //print the Fibonacci series numbers

            Console.WriteLine("Fibonacci Series up to " + limit);
            for (int i = 0; i < limit; i++)
            {
                Console.Write(series[i] + " ");
            }
        }
    }
}
