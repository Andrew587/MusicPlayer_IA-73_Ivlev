using Music_Player.MementoPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.Models.Entities
{
    class Playlist
    {
        private Song currentSong;
        private Song nextSong;

        internal Song CurrentSong { get => currentSong; set => currentSong = value; }
        internal Song NextSong { get => nextSong; set => nextSong = value; }

        public SongMemento SaveState()
        {
            return new SongMemento(currentSong, NextSong);
        }
        public void RestoreState(SongMemento memento)
        {
            this.currentSong = memento.CurrentSong;
            this.nextSong = memento.NextSong;
        }
    }
}
