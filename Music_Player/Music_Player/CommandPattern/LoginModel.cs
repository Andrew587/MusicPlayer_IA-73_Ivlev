using Music_Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musical_Player.Models
{
    class LoginModel
    {
        public bool Author(string login, string password)
        {
            if(Holder.Users.FirstOrDefault(u => u.Login == login && u.Password == password) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
