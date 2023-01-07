using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NOTE_ID.Model;

namespace NOTE_ID.Data_Acces_Layer
{
    public class BookManager
    {
        public void SaveBook(List<Book> list)
        {
            using (StreamWriter file = File.CreateText("Books.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, list);
            }
        }
        public List<Book> LoadBook(string filePath)
        {
            return JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(filePath));
        }
    }
}
