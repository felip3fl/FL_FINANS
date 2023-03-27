using FL.Data.Inferfaces;
using FL.Data.Repositories.Base;
using FL.Model;

namespace FL.Data.Repositories
{
    public class FinancialTransactionRepository : BaseRepository<FinancialTransaction>, IFinancialTransactionRepository
    {
        public async Task<FinancialTransaction> GetById(int id)
        {
            var teste = new FinancialTransaction();
            teste.Description = "TESTE TESTE";
            return teste;

        }
    }
}
