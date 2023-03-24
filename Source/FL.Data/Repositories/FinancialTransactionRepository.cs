using FL.Data.Inferfaces;
using FL.Data.Repositories.Base;
using FL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL.Data.Repositories
{
    public class FinancialTransactionRepository : BaseRepository<FinancialTransaction>, IFinancialTransaction
    {
        public Task<FinancialTransaction> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
