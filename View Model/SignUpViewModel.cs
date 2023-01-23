using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace NOTE_ID.View_Model
{
    internal class SignUpViewModel : BaseViewModel
    {
        public SignUpViewModel()
        {
            signUpCommand = new CommandViewModel(ExecuteSignUpCommand, CanExecuteSignUpCommand);
            haveAccountCommand = new CommandViewModel(ExecuteHaveAccountCommand);
        }
        private string userName = String.Empty;
        private string password = String.Empty;
        private string email = String.Empty;
        private string confirmPassword = String.Empty;
        private string errorMessage = String.Empty;
        private static Brush defaultBrush = (Brush)(new BrushConverter()).ConvertFromString("#FFE3AE49");
        private Brush userNameBrush = defaultBrush;
        private Brush passwordBrush = defaultBrush;
        private Brush emailBrush = defaultBrush;
        private Brush confirmPasswordBrush = defaultBrush;
        private ICommand signUpCommand;
        private ICommand haveAccountCommand;

        public string UserName
        {
            get => userName;
            set
            {
                userName = value;
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged();
            }
        }
        public string Email
        {
            get => email;
            set
            {
                email = value;
                OnPropertyChanged();
            }
        }
        public string ConfirmPassword
        {
            get => confirmPassword;
            set
            {
                confirmPassword = value;
                OnPropertyChanged();
            }
        }
        public ICommand SignUpCommand 
        { 
            get => signUpCommand; 
            set => signUpCommand = value; 
        }
        public string ErrorMessage
        {
            get => errorMessage;
            set
            {
                errorMessage = value;
                OnPropertyChanged();
            }
        }

        public Brush UserNameBrush
        {
            get => userNameBrush;
            set
            {
                userNameBrush = value;
                OnPropertyChanged();
            }
        }
        public Brush PasswordBrush
        {
            get => passwordBrush;
            set
            {
                passwordBrush = value;
                OnPropertyChanged();
            }
        }
        public Brush EmailBrush
        {
            get => emailBrush;
            set
            {
                emailBrush = value;
                OnPropertyChanged();
            }
        }
        public Brush ConfirmPasswordBrush
        {
            get => confirmPasswordBrush;
            set
            {
                confirmPasswordBrush = value;
                OnPropertyChanged();
            }
        }

        public ICommand HaveAccountCommand
        {
            get => haveAccountCommand;
            set => haveAccountCommand = value;
        }

        private void ExecuteHaveAccountCommand(object obj)
        {
            var mainViewModel =
                (MainViewModel)System.Windows.Application.Current.MainWindow.DataContext;
            mainViewModel.CurrentView = mainViewModel.LoginPage;
        }
        private bool CanExecuteSignUpCommand(object obj)
        {
            string emailPattern = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";
            if (!Regex.IsMatch(Email, emailPattern))
            {
                EmailBrush = Brushes.Red;
                return false;
            }
            EmailBrush = defaultBrush;
            if (UserName.Length < 4)
            {
                UserNameBrush = Brushes.Red;
                return false;
            }
            UserNameBrush = defaultBrush;
            if (Password.Length < 4)
            {
                PasswordBrush = Brushes.Red;
                return false;
            }
            PasswordBrush = defaultBrush;
            if (ConfirmPassword != Password)
            {
                ConfirmPasswordBrush = Brushes.Red;
                return false;
            }
            ConfirmPasswordBrush = defaultBrush;
            return true;
        }
        private void ExecuteSignUpCommand(object obj)
        {
            Model.SignUp signUp = new()
            {
                Email = Email,
                Password = Password,
                Username = UserName,
            };
            App.signUp.Add(signUp);
            Email = string.Empty;
            UserName = String.Empty;
            Password = string.Empty;
            ConfirmPassword = String.Empty;
        }
    }
}
