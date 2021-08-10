using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBook_.Helpers
{
    class FileHelper
    {
        public void JsonSerialization()
        {
            DataBase db = new DataBase();
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter("Students.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, db);
                }
            }
        }


        //public void JsonDeserialize(DataBase dataBase)
        //{
        //    List<User> users = null;
        //    var serializer = new JsonSerializer();

        //    using (StreamReader sr = new StreamReader("Students.json"))
        //    {
        //        using (var jr = new JsonTextReader(sr))
        //        {
        //            users = serializer.Deserialize<List<User>>(jr);
        //        }
        //        dataBase.AddUser();
        //    }

        //}


    }
}
