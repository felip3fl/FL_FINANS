using FL.Point.Data.Inferfaces.Base;
using FL.Point.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL.Point.Data.Repositories.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public Task Add(T entity)
        {

            return default;
        }

        public Task Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAll()
        {
            var listEletronicPoint = new List<T>() ;
            var result = Task.FromResult(listEletronicPoint);

            return result;
        }
    }
}
