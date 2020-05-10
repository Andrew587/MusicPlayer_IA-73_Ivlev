using Music_Player.MementoPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.MementoPattern
{
    class SongsHistory
    {
        public Stack<SongMemento> History { get; private set; }
        public SongsHistory()
        {
            History = new Stack<SongMemento>();
        }
    }
}
