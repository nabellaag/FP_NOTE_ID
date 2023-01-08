using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NOTE_ID.View_Model
{
    public class AfterLoginViewModel : BaseViewModel
    {
        public AfterLoginViewModel()
        {
            gettingStartedPage = new GettingStartedPageViewModel();
            currentView = gettingStartedPage;
            gettingStartedCommand = new CommandViewModel(x => CurrentView = gettingStartedPage);
        }
        private object currentView;
        private GettingStartedPageViewModel gettingStartedPage;
        private ICommand gettingStartedCommand;

        public ICommand GettingStartedCommand { get => gettingStartedCommand; set => gettingStartedCommand = value; }
        public ICommand QuickNoteCommand { get; set; }
        public ICommand BookRecommendationCommand { get; set; }
        public ICommand ToDoListCommand { get; set; }
        public ICommand ReadingListCommand { get; set; }
        public object CurrentView
        {
            get => currentView;
            set
            {
                currentView = value;
                OnPropertyChanged();
            }
        }
    }
}
