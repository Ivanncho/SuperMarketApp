using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class RecordTransactionUseCase : IRecordTransactionUseCase
    {
        private readonly ITransactionRepository transactionRepository;
        private readonly IGetProductByIdUseCase getProductById;

        public RecordTransactionUseCase(ITransactionRepository transactionRepository,
                                        IGetProductByIdUseCase getProductById)
        {
            this.transactionRepository = transactionRepository;
            this.getProductById = getProductById;
        }
        public void Execute(string cashierName, int productId, int qty)
        {
            var product = getProductById.Execute(productId);
            transactionRepository.Save(cashierName, productId, product.Price.Value,product.Quantity.Value,qty);
        }
    }
}
