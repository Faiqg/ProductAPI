using Refactored.This.Model.Entities;
using Refactored.This.Data.Contracts;

namespace Refactored.This.Data.Repositories
{
    public class LocationRepository : BaseRepository<Location>, ILocationRepository
    {
        public LocationRepository(RefactorContext context) : base(context)
        {
        }
    }
}
