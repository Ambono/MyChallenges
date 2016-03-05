using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Jason
{
  //[DefaultMemberAttribute("Item")]
  //public class JsonArray : JsonValue, IList<JsonValue>,
  //  ICollection<JsonValue>, IEnumerable<JsonValue>, IEnumerable
  //{
  //}
  class Program
  {
    static void Main(string[] args)
    {
     
    }


    //  static void createJason()
    //  {
    //    string path = @"JsonFile.jason";
    //    StreamReader responseStream = new StreamReader(path);
    //    JsonArray users = (JsonArray)JsonArray.Load(responseStream);

    //    var members = from member in users
    //                  where member["IsMember"]
    //                  select member;

    //    foreach (JsonObject member in members)
    //    {
    //      string name = member["Name"];
    //      int age = member["Age"];

    //      // Do something...

    //    }

    //  }
    //  static void serializeJson()
    //  {
    //    string path = @"JsonFile.jason";
    //    StreamReader responseStream = new StreamReader(path);
    //    DataContractJsonSerializer serializer =
    //      new DataContractJsonSerializer(typeof(User));
    //    User user = (User)serializer.ReadObject(responseStream);

    //    bool isMember = user.IsMember;
    //    string name = user.Name;
    //    int age = user.Age;

    //  }

    //}


    //public class User
    //{
    //  public bool IsMember { get; set; }
    //  public string Name { get; set; }
    //  public int Age { get; set; }
    //}

  }
}
