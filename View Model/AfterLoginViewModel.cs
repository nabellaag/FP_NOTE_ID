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
            quickNotePage = new QuickNotePageViewModel();
            bookRecommendationPage = new BookRecommendationPageViewModel();
            readingListPage = new ReadingListPageViewModel();
            currentView = gettingStartedPage;
            gettingStartedCommand = new CommandViewModel(x => CurrentView = gettingStartedPage);
            quickNoteCommand = new CommandViewModel(x => CurrentView = quickNotePage);
            bookRecommendationCommand = new CommandViewModel(x=> CurrentView = bookRecommendationPage);
            readingListCommand = new CommandViewModel(x=> CurrentView = readingListPage);
        }
        private object currentView;
        private GettingStartedPageViewModel gettingStartedPage;
        private QuickNotePageViewModel quickNotePage;
        private BookRecommendationPageViewModel bookRecommendationPage;
        private ReadingListPageViewModel readingListPage;
        private ICommand gettingStartedCommand;
        private ICommand quickNoteCommand;
        private ICommand bookRecommendationCommand;
        private ICommand toDoListCommand;
        private ICommand readingListCommand;

        public ICommand GettingStartedCommand { get => gettingStartedCommand; set => gettingStartedCommand = value; }
        public ICommand QuickNoteCommand { get => quickNoteCommand; set => quickNoteCommand = value; }
        public ICommand BookRecommendationCommand { get => bookRecommendationCommand; set => bookRecommendationCommand = value; }
        public ICommand ToDoListCommand { get => toDoListCommand; set => toDoListCommand = value; }
        public ICommand ReadingListCommand { get => readingListCommand; set => readingListCommand = value; }
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
