using FL.Data.Inferfaces;
using FL.Data.Repositories.Base;
using FL.Model;

namespace FL.Data.Repositories
{
    public class FinancialTransactionRepository : BaseRepository<FinancialTransaction>, IFinancialTransactionRepository
    {
        public Task<FinancialTransaction> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
