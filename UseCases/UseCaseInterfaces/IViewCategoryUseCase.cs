using CoreBusiness;
using System.Collections.Generic;

namespace UseCases
{
    public interface IViewCategoryUseCase
    {
        IEnumerable<Category> Execute();
    }
}