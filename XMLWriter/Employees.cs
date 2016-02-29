using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLWriter
{
  class Employee
  {
    int _id;
    string _firstName;
    string _lastName;
    int _salary;

    public Employee(int id, string firstName, string lastName, int salary)
    {
      this._id = id;
      this._firstName = firstName;
      this._lastName = lastName;
      this._salary = salary;
    }

    public int Id { get { return _id; } }
    public string FirstName { get { return _firstName; } }
    public string LastName { get { return _lastName; } }
    public int Salary { get { return _salary; } }
  }
}