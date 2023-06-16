using FL.Model;
using FL.Point.Data.Data;
using FL.Point.Data.Inferfaces;
using FL.Point.Data.Repositories.Base;
using FL.Point.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL.Point.Data.Repositories
{
    public class EletronicPointRepository : BaseRepository<EletronicPoint>, IEletronicPointRepository
    {
        private readonly DataBaseContext _dataBaseContext ;

        public EletronicPointRepository(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public async Task Add(EletronicPoint eletronicPoint)
        {
            await _dataBaseContext.EletronicPoints.Add(eletronicPoint);
            await Save();
        }

        private async Task Save()
        {
            await _dataBaseContext.SaveChangesAsync();
        }
    }
}
