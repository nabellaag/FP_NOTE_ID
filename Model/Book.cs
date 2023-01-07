using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTE_ID.Model
{
    public class Book
    {
        public string nama { get; set; }
        public string deskripsi { get; set; }
        public string judul { get; set; }
        public string cover { get; set; }
        public int rating { get; set; }
        public int jmlhal { get; set; }
        public DateTime tgl { get; set; }
        public string isbn { get; set; }
        public string penerbit { get; set; }
        public string bahasa { get; set; }
        public string link { get; set; }
    }
}
