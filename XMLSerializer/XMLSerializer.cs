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
      string path = @"XMLFile.xml";
      StreamReader responseStream = new StreamReader(path);
      XmlSerializer serializer = new XmlSerializer(typeof(User));
      User user = (User)serializer.Deserialize(responseStream);

      bool isMember = user.IsMember;
      string name = user.Name;
      int age = user.Age;
    }
  }
}
