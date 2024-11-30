using NtierArchitecture.DataAccess.Context;
using NtierArchitecture.Entities.Models;

namespace NtierArchitecture.DataAccess.Repositories
{
    public class LeaveRepository : GenericRepository<Leave>
    {
        public LeaveRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
