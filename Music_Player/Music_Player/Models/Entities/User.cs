using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    class User
    {
        private int id;
        private string login;
        private string password;

        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }
    }
}
