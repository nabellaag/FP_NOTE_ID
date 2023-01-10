using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using NOTE_ID.View;
using System.Windows.Input;

namespace NOTE_ID.View_Model
{
    public class LoginViewModel : BaseViewModel
    {
        public LoginViewModel()
        {
            loginCommand = new CommandViewModel(ExecuteLoginCommand, CanExecuteLoginCommand);
        }
        private string emailOrPhoneField = String.Empty;
        private string passwordField = String.Empty;
        public ICommand LoginCommand { get => loginCommand; set => loginCommand = value; }
        private string errorMessage;
        private ICommand loginCommand;

        public string EmailOrPhoneField
        {
            get => emailOrPhoneField;
            set
            {
                emailOrPhoneField = value;
                OnPropertyChanged();
            }
        }
        public string PasswordField
        {
            get => passwordField;
            set
            {
                passwordField = value;
                OnPropertyChanged();
            }
        }
        public string ErrorMessage
        {
            get => errorMessage;
            set
            {
                errorMessage = value;
            }
        }
        public Action CloseWindow { get; set; }

        private bool CanExecuteLoginCommand(object obj)
        {
            if (PasswordField.Length < 4) return false;
            return true;
        }
        private void ExecuteLoginCommand(object obj)
        {
            AfterLoginWindow afterLoginWindow = new AfterLoginWindow();
            afterLoginWindow.Show();
            PasswordField = String.Empty;
            EmailOrPhoneField = String.Empty;
        }
    }
}
