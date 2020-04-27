using Musical_Player.CommandPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Music_Player.ViewModels
{
    class MainWindowVM : ViewModel
    {
        private string login;
        private string password;
        private LoginCommand loginCommand;

        public event EventHandler ClosingRequest;

        public LoginCommand LoginCommand
        {
            get
            {
                return loginCommand ?? (loginCommand = new LoginCommand(obj =>
                {
                    if(loginCommand.Execute(login, password))
                    {
                        MessageBox.Show("Вы успешно авторизировались!");                    
                    }
                    else
                    {
                        MessageBox.Show("Такого пользователя не существует...");
                    }
                }));
            }
        }
        public string Login
        {
            get { return login; }
            set
            {
                login = value;
                OnPropertyChanged(nameof(Login));
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
    }
}
