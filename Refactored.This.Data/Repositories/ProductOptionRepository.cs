using Refactored.This.Model.Entities;
using Refactored.This.Data.Contracts;

namespace Refactored.This.Data.Repositories
{
    public class ProductOptionRepository : BaseRepository<ProductOption>, IProductOptionRepository
    {
        public ProductOptionRepository(RefactorContext context)
            : base(context)
        { }
    }
}
