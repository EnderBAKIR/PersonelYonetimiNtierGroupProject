using NtierArchitecture.DataAccess.Context;
using NtierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierArchitecture.DataAccess.Repositories
{
    public class SalaryTrackingRepository : GenericRepository<SalaryTracking>
    {
        public SalaryTrackingRepository(ApplicationDbContext context) : base(context)
        {
        }

        public void MarkSalaryAsPaid(Guid employeeId)
        {
            _dbContext.Add(new SalaryTracking
            {
                EmployeeId = employeeId,
                IsPayed = true,
                CreateDate = DateTime.Now
            });
            _dbContext.SaveChanges();
        }
    }
}
