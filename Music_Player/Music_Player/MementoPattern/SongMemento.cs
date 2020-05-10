using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.MementoPattern
{
    class SongMemento
    {
        public Song CurrentSong { get; private set; }
        public Song NextSong { get; private set; }

        public SongMemento(Song s1, Song s2)
        {
            CurrentSong = s1;
            NextSong = s2;
        }
    }
}
