using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musical_Player
{
    class SongsCollection : IEnumerable
    {
        public List<Song> songs = new List<Song>();

        public Song this[int index]
        {
            get { return songs[index]; }
        }

        public int Count
        {
            get { return songs.Count; }
        }

        public IEnumerator CreateNumerator()
        {
            return new SongsNumerator(this);
        }
        public List<Song> GetSongs()
        {
            return songs;
        }
    }
}
