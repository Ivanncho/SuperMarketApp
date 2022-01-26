using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class SellProductUseCase : ISellProductUseCase
    {
        private readonly IProductRepository productRepository;
        private readonly IRecordTransactionUseCase recordTransaction;

        public SellProductUseCase(IProductRepository productRepository,
            IRecordTransactionUseCase recordTransaction)
        {
            this.productRepository = productRepository;
            this.recordTransaction = recordTransaction;
        }
        public void Execute(string cashierName,int productId, int qtyToSell)
        {
            var product = productRepository.GetProductById(productId);
            if (product == null)
            {
                return;
            }
            product.Quantity -= qtyToSell;
            productRepository.UpdateProduct(product);
            recordTransaction.Execute(cashierName, productId, qtyToSell);
        }
    }
}
