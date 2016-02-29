using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLWriter
{
  class Program
  {
    static void Main(string[] args)
    {
      Employee[] employees = new Employee[4];
      employees[0] = new Employee(1, "David", "Smith", 10000);
      employees[1] = new Employee(3, "Mark", "Drinkwater", 30000);
      employees[2] = new Employee(4, "Norah", "Miller", 20000);
      employees[3] = new Employee(12, "Cecil", "Walker", 120000);

      using (XmlWriter writer = XmlWriter.Create("employees.xml"))
      {
        writer.WriteStartDocument();
        writer.WriteStartElement("Employees");

        foreach (Employee employee in employees)
        {
          writer.WriteStartElement("Employee");

          writer.WriteElementString("ID", employee.Id.ToString());
          writer.WriteElementString("FirstName", employee.FirstName);
          writer.WriteElementString("LastName", employee.LastName);
          writer.WriteElementString("Salary", employee.Salary.ToString());

          writer.WriteEndElement();
        }

        writer.WriteEndElement();
        writer.WriteEndDocument();
      }
    }
  }
}
