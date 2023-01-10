using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTE_ID.Model
{
    public class ToDoList
    {
        public string Judul { get; set; }
        public ToDoListStatus Status { get; set; }
    }
    public enum ToDoListStatus
    {
        ToDo,
        Doing,
        Done
    }
}
