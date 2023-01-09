using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTE_ID.View_Model
{
    public class LoginViewModel : BaseViewModel
    {
        private string emailOrPhoneField;
        private string passwordField;
        private string errorMessage;
        private void CanExecuteLoginCommand(object obj)
        {
            string emailPattern = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";

        }
    }
}
