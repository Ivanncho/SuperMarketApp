using CoreBusiness;
using Microsoft.EntityFrameworkCore;
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
            return context.Transactions.ToList();
        }

        public IEnumerable<Transaction> GetByDateRange(string cashierName, DateTime startDate, DateTime endDate)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
            {
                return context.Transactions.Where(t => 
                    t.TimeStamp >= startDate.Date &&
                    t.TimeStamp <= endDate.Date.AddDays(1).Date);
            }
            else
            {
                return context.Transactions.Where(t => 
                    EF.Functions.Like(t.CashierName, $"%{cashierName}%") &&
                    t.TimeStamp >= startDate.Date && t.TimeStamp <= endDate.Date.AddDays(1).Date);
            }
        }

        public IEnumerable<Transaction> GetByDay(string cashierName, DateTime date)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
            {
                return context.Transactions.Where(t => t.TimeStamp.Date == date.Date);
            }
            else
            {
                return context.Transactions.Where(t =>
                    EF.Functions.Like(t.CashierName, $"%{cashierName}%") &&
                    t.TimeStamp.Date == date.Date);
            }
        }

        public void Save(string cashierName, int productId, string productName, double price, int beforeQty, int soldQty)
        {
            var transaction = new Transaction()
            {
                ProductId = productId,
                ProductName = productName,
                TimeStamp = DateTime.Now,
                Price = price,
                BeforeQuantity = beforeQty,
                SoldQuantity = soldQty,
                CashierName = cashierName
            };
            context.Transactions.Add(transaction);
            context.SaveChanges();
        }
    }
}
