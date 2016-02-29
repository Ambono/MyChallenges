using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace XMLSerializer
{
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
