using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugin.DataStore.SQL
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly MarketContext context;

        public TransactionRepository(MarketContext context)
        {
            this.context = context;
        }
        public IEnumerable<Transaction> Get(string cashierName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transaction> GetByDateRange(string cashierName, DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transaction> GetByDay(string cashierName, DateTime date)
        {
            throw new NotImplementedException();
        }

        public void Save(string cashierName, int productId, string productName, double price, int beforeQty, int soldQty)
        {
            throw new NotImplementedException();
        }
    }
}
