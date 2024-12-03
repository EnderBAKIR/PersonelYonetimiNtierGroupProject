using Microsoft.EntityFrameworkCore;
using NtierArchitecture.DataAccess.Context;
using NtierArchitecture.Entities.Models;

namespace NtierArchitecture.DataAccess.Repositories
{
    public class LeaveRepository : GenericRepository<Leave>
    {
        public LeaveRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<Leave> GetLeavesWithEmployee()
        {
            var leaves = _dbContext.Leaves.Include(x=>x.Employee).ToList();
            return leaves;
        }
    }
}
