using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTE_ID.Model
{
    public class ReadingList
    {
        public string TitleBook { get; set; }
        public DateTime Tanggal { get; set; }
        public string Type { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public Status Status { get; set; }
    }
    public enum Status
    {
        Finished = 0,
        NotYet = 1
    }
}
