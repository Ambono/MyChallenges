using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;


namespace XMLSerializer
{
  class XMLSerializer
  {
    static void Main(string[] args)
    {
     
    }
    static void Serialize()
    {
      User p = new User();
      p.IsMember = true;
      p.Name = "A User";
      p.Age = 24;
      System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(p.GetType());
      x.Serialize(Console.Out, p);
      Console.WriteLine();
      Console.ReadLine();
    }

    static void Deserialize()
    {
      string path = @"XMLFile.xml";
      StreamReader responseStream = new StreamReader(path);
      XmlSerializer serializer = new XmlSerializer(typeof(User));
      User user = (User)serializer.Deserialize(responseStream);

      bool isMember = user.IsMember;
      string name = user.Name;
      int age = user.Age;
    }
  }

  class User
  {
    [XmlAttribute]
    public bool IsMember { get; set; }

    [XmlElement]
    public string Name { get; set; }

    [XmlElement]
    public int Age { get; set; }
  }
}
