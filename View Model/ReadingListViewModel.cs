using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NOTE_ID.View_Model
{
    public class ReadingListViewModel : BaseViewModel
    {
        public ReadingListViewModel()
        {
            newReadingListCommand = new CommandViewModel(ExecuteNewReadingListCommand);
        }
        private bool _showReadingListPopup = false;
        private ICommand newReadingListCommand;

        public ICommand NewReadingListCommand 
        { 
            get => newReadingListCommand; 
            set => newReadingListCommand = value; 
        }
        public bool ShowReadingListPopup
        {
            get => _showReadingListPopup;
            set
            {
                _showReadingListPopup = value;
                OnPropertyChanged();
            }
        }
        private void ExecuteNewReadingListCommand(object obj)
        {
            ShowReadingListPopup = !_showReadingListPopup;
        }

    }
}
