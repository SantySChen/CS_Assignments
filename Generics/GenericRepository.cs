using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class GenericRepository : IRepository<Entity>
    {
        void IRepository<Entity>.Add(Entity item)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Entity> IRepository<Entity>.GetAll()
        {
            throw new NotImplementedException();
        }

        Entity IRepository<Entity>.GetByld(int id)
        {
            throw new NotImplementedException();
        }

        void IRepository<Entity>.Remove(Entity item)
        {
            throw new NotImplementedException();
        }

        void IRepository<Entity>.Save()
        {
            throw new NotImplementedException();
        }
    }
}
