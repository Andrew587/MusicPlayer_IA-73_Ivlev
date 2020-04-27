using Musical_Player.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Musical_Player.CommandPattern
{
    class LoginCommand : IMyCommand
    {
        private LoginModel login;
        private Action<object> execute;

        public LoginCommand(Action<object> action)
        {
            execute = action;
            login = new LoginModel();
        }

        public bool Execute(string log, string password)
        {
            return login.Author(log, password);
        }
    }
}
