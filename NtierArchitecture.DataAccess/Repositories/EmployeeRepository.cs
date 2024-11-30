using NtierArchitecture.DataAccess.Context;
using NtierArchitecture.Entities.Models;

namespace NtierArchitecture.DataAccess.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
