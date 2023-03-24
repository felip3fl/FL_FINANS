using FL.Data.Inferfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL.Data.Repositories.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public Task Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
