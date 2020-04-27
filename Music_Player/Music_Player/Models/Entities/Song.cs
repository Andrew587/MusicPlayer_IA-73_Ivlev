using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    class Song
    {
        private string singer;
        private string name;

        public string Name { get => name; set => name = value; }
        public string Singer { get => singer; set => singer = value; }
    }
}
