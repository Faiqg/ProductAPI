using Refactored.This.Model.Entities;
using Refactored.This.Data.Contracts;

namespace Refactored.This.Data.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(RefactorContext context)
            : base(context)
        { }
    }
}
