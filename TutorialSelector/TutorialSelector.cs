using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
namespace TutorialSelector
{
  enum Tutorials
  {
    ANGULARJS,
    BINARYSEARCH,
    BUILDINGTRIANGLES,
    CHECKNUMBERISINRANGE,
    DELEGATES,
    EQUILIBRIUM,
    FACTORIALRECURSIVE,
    FACTORIALWHILELOOP,
    FEEZBUZ,
    FIBONACCI,
    GENERICS,
    JSON,
    LARGESTTRIANGLEPERIMETER,
    LISTOFSQUARE,
    MAXBINARYGAP,
    MAXANDMINNUMBERINRANGE,
    NUMBEROFIDENTICALSTRINGS,
    NUMBEROFUPPERANDLOWERCASES,
    PALINDROME,
    PANGRAM,
    PASCALTRIANGLES,
    PERFECTNUMBERS,
    PRIMENUMBERSINARANGE,
    SQLSERVERQUERIES,
    STREAMREADERWRITER,
    STREAMSERIALIZER,
    STRINGCOMPRESSIONDECOMPRESSION,
    THREADS,
    USINGLINQ,
    XMLREADER,
    XMLSERIALIZER,
    XMLWRITER
  }
  class TutorialSelector
  {
    static void Main(string[] args)
    {
      SelectTutorial();
    }
    static void SelectTutorial()
    {
      Random number = new Random();
      string tutorial = "";
      string path = @"C:\OutputFiles\TutorialFile.txt";
      var fs = File.Open(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);

      using (StreamReader reader = new StreamReader(fs))
      {
        using (StreamWriter writer = new StreamWriter(fs))
        {
          string line;
          string newLine = "";
          int limit = 2;
          List<string> contentToRead = new List<string>();
          List<string> contentToOutput = new List<string>();


          if ((line = reader.ReadLine()) == null)
          {
            for (int sentinelle = 0; sentinelle < limit; ++sentinelle)
            {
              tutorial = Enum.GetName(typeof(Tutorials), number.Next(31));
              Console.WriteLine(tutorial);
              writer.WriteLine(tutorial);
            }
          }
          else
          {
            while ((line = reader.ReadLine()) != null)
            {
              contentToRead.Add(line);
            }

            Console.WriteLine("number of tutorial already listed: {0}:32", contentToRead.Count() + 1);
            int count = 0;
            for (int sentinelle = 0; sentinelle < limit; ++sentinelle)
            {

              tutorial = Enum.GetName(typeof(Tutorials), number.Next(31));

              for (int index = 0; index < contentToRead.Count; ++index)
              {
                if (tutorial.Equals(contentToRead[index]))
                {
                  tutorial = Enum.GetName(typeof(Tutorials), number.Next(31));
                  ++count;
                }

              }
              if (count == 0)
              {
                contentToOutput.Add(tutorial);

              }
            }

            foreach (var item in contentToOutput.Distinct())
            {
              Console.WriteLine(item);
              writer.WriteLine(item);
            }
          }
        }
      }

    }
  }
}
