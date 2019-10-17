using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;


namespace LINQtoXMLAndJSON
{
     public static class JSONData
    {
        public static List<Book> GetBooksFromFile(string fileName)
        {
             var dataFromJSON = File.ReadAllText("JSONFile.json");
             return JsonConvert.DeserializeObject<List<Book>>(dataFromJSON);

        }
    }
}
