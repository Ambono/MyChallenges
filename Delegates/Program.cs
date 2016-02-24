using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
  class Program
  {
    delegate void GreetingDelegate(string s);

    static void Main(string[] args)
    {
      GreetingDelegate firstDel, secondDel;
      firstDel = new GreetingDelegate(Hello);
      secondDel = new GreetingDelegate(Goodbye);
      firstDel += secondDel;
      GreetMethod(firstDel, "Cathy");
      GreetMethod(secondDel, "Bob");
    }
     static void Hello(string s)
    {
      Console.WriteLine("Hello, {0}!", s);
    }
    static void Goodbye(string s)
     {
       Console.WriteLine("Goodbye, {0}!", s);
     }
    static void GreetMethod(GreetingDelegate gd, string name)
    {
      Console.WriteLine("The greeting is: ");
      gd(name);
    }
  }
}
