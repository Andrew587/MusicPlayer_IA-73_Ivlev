using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.Models.Entities
{
    class UsersPlaylist
    {
        private int id;
        private User user;
        private Playlist playlist;

        public int Id { get => id; set => id = value; }
        internal User User { get => user; set => user = value; }
        internal Playlist Playlist { get => playlist; set => playlist = value; }
    }
}
