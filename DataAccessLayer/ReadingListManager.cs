using Newtonsoft.Json;
using NOTE_ID.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTE_ID.DataAccessLayer
{
    public class ReadingListManager
    {
        public void SaveReadingList(List<ReadingList> list)
        {
            using (StreamWriter file = File.CreateText("ReadingList.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, list);
            }
        }
        public List<ReadingList> LoadQuickNote(string filePath)
    {
            return JsonConvert.DeserializeObject<List<ReadingList>>(File.ReadAllText(filePath));
        }
    }
}
