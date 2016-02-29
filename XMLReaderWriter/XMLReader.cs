using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace XMLReaderWriter
{
  class XMLReader
  {
    static void Main(string[] args)
    {
      readXML();
    }

    static void ReadSimpleXML()
    {
      string responseStream = @"XMLFile\XMLFile.xml";

      XmlReader responseReader = XmlReader.Create(responseStream);

      responseReader.Read();
      bool isMember = Boolean.Parse(responseReader.GetAttribute("IsMember"));
      responseReader.Read();

      responseReader.ReadStartElement("Name");
      string name = responseReader.ReadContentAsString();
      responseReader.ReadEndElement();

      responseReader.ReadStartElement("Age");
      int age = responseReader.ReadContentAsInt();
      responseReader.ReadEndElement();

      responseReader.ReadEndElement();
    }

    static void readXML()
    {
      // Create an XML reader for this file.
      using (XmlReader reader = XmlReader.Create(@"XMLFile\perls.xml"))
      {
        while (reader.Read())
        {
          // Only detect start elements.
          if (reader.IsStartElement())
          {
            // Get element name and switch on it.
            switch (reader.Name)
            {
              case "perls":
                // Detect this element.
                Console.WriteLine("Start <perls> element.");
                break;
              case "article":
                // Detect this article element.
                Console.WriteLine("Start <article> element.");
                // Search for the attribute name on this current node.
                string attribute = reader["name"];
                if (attribute != null)
                {
                  Console.WriteLine("  Has attribute name: " + attribute);
                }
                // Next read will contain text.
                if (reader.Read())
                {
                  Console.WriteLine("  Text node: " + reader.Value.Trim());
                }
                break;
            }
          }
        }
      }

    }
  }
}
