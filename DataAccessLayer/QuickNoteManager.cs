using NOTE_ID.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace NOTE_ID.Data_Acces_Layer
{
    public class QuickNoteManager
    {
        public void Save(List<QuickNote> list)
        {
            using (StreamWriter file = File.CreateText("QuickNotes.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, list);
            }
        }
        public List<QuickNote> LoadQuickNote(string filePath)
        {
            return JsonConvert.DeserializeObject<List<QuickNote>>(File.ReadAllText(filePath));
        }
    }
}
