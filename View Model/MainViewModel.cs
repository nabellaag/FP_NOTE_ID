using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NOTE_ID.View_Model
{
    internal class MainViewModel : BaseViewModel
    {
        private ICommand homeViewCommand;
        private ICommand fAQViewCommand;
        private ICommand aboutViewCommand;
        private ICommand loginViewCommand;
        private object currentView;
        private AboutPageViewModel aboutPage;
        private FAQPageViewModel fAQPage;
        private HomePageViewModel homePage;
        private LoginPageViewModel loginPage;

        public ICommand HomeViewCommand
        {
            get => homeViewCommand;
            set => homeViewCommand = value;
        }
        public ICommand FAQViewCommand
        {
            get => fAQViewCommand;
            set => fAQViewCommand = value;
        }
        public ICommand AboutViewCommand
        {
            get => aboutViewCommand;
            set => aboutViewCommand = value;
        }
        public ICommand LoginViewCommand
        {
            get => loginViewCommand; set => loginViewCommand = value;
        }
        public object CurrentView
        {
            get => currentView;
            set
            {
                currentView = value;
                OnPropertyChanged();
            }
        }
        public HomePageViewModel HomePage
        {
            get => homePage;
            set
            {
                homePage = value;
                OnPropertyChanged();
            }
        }
        public AboutPageViewModel AboutPage
        {
            get => aboutPage;
            set
            {
                aboutPage = value;
                OnPropertyChanged();
            }
        }
        public FAQPageViewModel FAQPage
        {
            get => fAQPage;
            set
            {
                fAQPage = value;
                OnPropertyChanged();
            }
        }
        public LoginPageViewModel LoginPage
        {
            get => loginPage;
            set
            {
                loginPage = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            homePage = new HomePageViewModel();
            aboutPage = new AboutPageViewModel();
            fAQPage = new FAQPageViewModel();
            loginPage = new LoginPageViewModel();

            currentView = homePage;

            homeViewCommand = new CommandViewModel(x => CurrentView = homePage);
            aboutViewCommand = new CommandViewModel(x => CurrentView = aboutPage);
            fAQViewCommand = new CommandViewModel(x => CurrentView = fAQPage);
            loginViewCommand = new CommandViewModel(x => CurrentView = loginPage);
        }

    }
}
