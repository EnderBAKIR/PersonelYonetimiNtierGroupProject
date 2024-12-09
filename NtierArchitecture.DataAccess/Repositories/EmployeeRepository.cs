using Microsoft.EntityFrameworkCore;
using NtierArchitecture.DataAccess.Context;
using NtierArchitecture.Entities.Models;

namespace NtierArchitecture.DataAccess.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>
    {
		private readonly ApplicationDbContext _context;
		public EmployeeRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}
		public IQueryable<Employee> GetAll()
		{
			return _context.Employees.Include(e => e.Department);
		}

		public void Update(Employee employee)
		{
			_context.Employees.Update(employee);
		}
		public void SaveChanges()
		{
			_context.SaveChanges(); //Veritabanına değişiklikleri kaydeder
		}

        public List<Employee> GetAllEmployeesWithDepartment()
        {
            return _context.Employees.Include(e => e.Department).ToList();
        }
    }
}

