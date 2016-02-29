using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threads
{
  class ThreadExample
  { 

    public static void Main(String[] args)
    {
      Thread thread1 = new Thread(new ThreadStart(A));
      Thread thread2 = new Thread(new ThreadStart(B));

      try
      {
        thread1.Start();
        thread2.Start();
        thread1.Join();
        thread2.Join();

      }
      catch (ThreadStateException e)
      {
        Console.WriteLine(e);  // Display text of exception
                // Result says there was an error
      }
      catch (ThreadInterruptedException e)
      {
        Console.WriteLine(e);  // This exception means that the thread
        // was interrupted during a Wait
                  // Result says there was an error
      }
      // Even though Main returns void, this provides a return code to 
      // the parent process.
      
    }

    static void A()
    {
      Thread.Sleep(100);
      Console.WriteLine('A');
    }

    static void B()
    {
      Thread.Sleep(1000);
      Console.WriteLine('B');
    }

  }
}
