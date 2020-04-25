using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musical_Player
{
    public interface IEnumerator
    {
        void Reset();
        object Current();
        bool HasNext();
        object Next();
    }
}
