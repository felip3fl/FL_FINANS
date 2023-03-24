using FL.Data.Inferfaces.Base;
using FL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL.Data.Inferfaces
{
    public interface IFinancialTransaction : IBaseRepository<FinancialTransaction>
    {
        Task<FinancialTransaction> GetById(int id);
    }
}
