using Musical_Player.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    class Holder
    {
        private static List<Song> songs;
        private static List<User> users;
        private static List<Player> players;
        private static List<UsersPlayer> usersPlayers;

        static Holder()
        {
            songs = new List<Song>();
            users = new List<User>();
            players = new List<Player>();
            usersPlayers = new List<UsersPlayer>();
        }

        internal static List<Song> Songs { get => songs; set => songs = value; }
        internal static List<User> Users { get => users; set => users = value; }
        internal static List<Player> Players { get => players; set => players = value; }
        internal static List<UsersPlayer> UsersPlayers { get => usersPlayers; set => usersPlayers = value; }

        private static void InitUsers()
        {
            User user = new User { Id = 0, Login = "1", Password = "1" };
            User user2 = new User { Id = 1, Login = "2", Password = "2" };
            Users.Add(user);
            Users.Add(user2);
        }

    }
}
