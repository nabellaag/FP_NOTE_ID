using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTE_ID.View_Model
{
    internal class MainViewModel : BaseViewModel
    {
        public CommandViewModel HomeViewCommand { get; set; }
        public CommandViewModel ReservationViewCommand { get; set; }
        public CommandViewModel HistoryViewCommand { get; set; }
    }
}
