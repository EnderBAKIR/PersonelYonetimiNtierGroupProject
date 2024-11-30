using NtierArchitecture.DataAccess.Context;
using NtierArchitecture.Entities.Models;

namespace NtierArchitecture.DataAccess.Repositories
{
    public class DiscontinuityRepository : GenericRepository<Discontinuity>
    {
        public DiscontinuityRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
