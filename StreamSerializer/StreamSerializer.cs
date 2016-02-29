using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace StreamSerializer
{
  class StreamSerializer
  {
    static void Main(string[] args)
    {
      SerializeObjects();
    }
   
    static void SerializeObjects()
    {
      MyObject obj = new MyObject();
      obj.n1 = 1;
      obj.n2 = 24;
      obj.str = "Some String";
      IFormatter formatter = new BinaryFormatter();
      Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
      formatter.Serialize(stream, obj);
      stream.Close();
    }

    static void DeSerializze()
    {
      IFormatter formatter = new BinaryFormatter();
      Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
      MyObject obj = (MyObject)formatter.Deserialize(stream);
      stream.Close();

      // Here's the proof.
      Console.WriteLine("n1: {0}", obj.n1);
      Console.WriteLine("n2: {0}", obj.n2);
      Console.WriteLine("str: {0}", obj.str);
    }
  }

  [Serializable]
  public class MyObject
  {
    public int n1 = 0;
    public int n2 = 0;
    public String str = null;
  }
}
