using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.Interfaces
{
    public interface IRepository<Tkey, TEntity>
    {
        void Insert(TEntity e);
        void Update(Tkey k, TEntity e);
        void Delete(Tkey k);
        TEntity GetById(Tkey k);
        IEnumerable<TEntity> GetAll();
    }
}
