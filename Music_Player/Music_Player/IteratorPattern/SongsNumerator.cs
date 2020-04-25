using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    class SongsNumerator : IEnumerator
    {
        SongsCollection Collection;
        int index = 0;

        public SongsNumerator(SongsCollection collection)
        {
            Collection = collection;

        }
        public object Current()
        {
           return Collection[index];
        }

        public bool HasNext()
        {
           return index <= Collection.Count;
        }

        public object Next()
        {
            return Collection[index++];
        }

        public void Reset()
        {
            index = 0;
        }
        }
    }
