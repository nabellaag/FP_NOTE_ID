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
            LoginCommand = new CommandViewModel(ExecuteLoginCommand, CanExecuteLoginCommand);
        }
        private string emailOrPhoneField = String.Empty;
        private string passwordField = String.Empty;
        private ICommand LoginCommand { get;set; }
        private string errorMessage;

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
            string emailPattern = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";
            if (Regex.IsMatch(EmailOrPhoneField, emailPattern)) return false;
            if (PasswordField.Length < 4) return false;
            return true;
        }
        private void ExecuteLoginCommand(object obj)
        {
            Model.SignUp signUp;
            if (App.signUp.Any(x=> x.Email.ToLower() == EmailOrPhoneField.ToLower()))
            {
                signUp = App.signUp.Where(x=> x.Email.ToLower() == EmailOrPhoneField.ToLower()).FirstOrDefault();
                if (signUp.Password == PasswordField)
                {
                    AfterLoginWindow afterLoginWindow = new AfterLoginWindow();
                    CloseWindow();
                    afterLoginWindow.Show();
                }
            }
        }
    }
}
