using Music_Player.Models.Entities;
using Music_Player.MementoPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.MementoPattern
{
    class PlayerModel
    {
        private Playlist playlist;
        private SongsHistory history;
        internal Playlist Playlist { get => playlist; set => playlist = value; }

        public PlayerModel()
        {
            history = new SongsHistory();
        }
        public void NextSong(Song currSong)
        {
            history.History.Push(playlist.SaveState());
            playlist.CurrentSong = playlist.NextSong;
        }
        public void PrevSong()
        {
            playlist.RestoreState(history.History.Pop());
        }
    }
}
