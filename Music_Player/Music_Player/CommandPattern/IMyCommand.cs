using Musical_Player.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musical_Player.CommandPattern
{
    interface IMyCommand
    {
        bool Execute(string login, string password);
    }
}
