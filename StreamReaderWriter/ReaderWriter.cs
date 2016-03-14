using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamReaderWriter
{
    class ReaderWriter
    {
        static void Main(string[] args)
        {
            ReadStream();

        }
        static void WriteStream()
        {
            using (StreamWriter sw = new StreamWriter(@"C:\OutputFiles\important.txt"))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("World");
            }
        }

        static void ReadStream()
        {
            using (StreamReader sr = new StreamReader(@"C:\OutputFiles\important.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

    }
}
