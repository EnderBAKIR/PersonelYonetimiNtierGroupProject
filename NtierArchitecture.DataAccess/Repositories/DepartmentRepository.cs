using Microsoft.EntityFrameworkCore;
using NtierArchitecture.DataAccess.Context;
using NtierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierArchitecture.DataAccess.Repositories
{
    public class DepartmentRepository : GenericRepository<Department>
    {
        public DepartmentRepository(ApplicationDbContext context) : base(context)
        {  
        }
    }
}
