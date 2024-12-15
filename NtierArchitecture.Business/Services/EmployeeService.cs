using FluentValidation.Results;
using NtierArchitecture.Business.IServices;
using NtierArchitecture.Business.Validators;
using NtierArchitecture.DataAccess.Repositories;
using NtierArchitecture.Entities.Models;
using System.Linq.Expressions;
using System.Text;

namespace NtierArchitecture.Business.Services
{
    public class EmployeeService : IService<Employee>
    {
        private readonly EmployeeRepository _repository;
        public EmployeeService(EmployeeRepository catRepo)
        {
            _repository = catRepo;
        }
        public void Create(Employee entity)
        {
            if (IfEntityExists(c => c.TcNo == entity.TcNo))
            {
                throw new Exception("Bu Çalışan daha önce kayıt edilmiştir.");
            }
            EmployeeValidator cval = new();
            ValidationResult result = cval.Validate(entity);
            StringBuilder sb = new();
            result.Errors.ForEach(x => sb.AppendLine(x.ToString()));

            if (!result.IsValid)
            {
                throw new Exception(sb.ToString());
            }

            _repository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            var cat = _repository.GetByID(Id);

            if (cat.IsActive)
            {
                throw new Exception("Aktif olan bir Çalışan silinemez.");
            }

            _repository.Delete(Id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _repository.GetAll();
        }

        public Employee GetByID(Guid Id)
        {
            return _repository.GetByID(Id);
        }

        public bool IfEntityExists(Expression<Func<Employee, bool>> filter)
        {
            return _repository.IfEntityExists(filter);
        }

        public void Update(Employee entity)
        {
            EmployeeValidator cval = new();
            ValidationResult result = cval.Validate(entity);
            StringBuilder sb = new();
            result.Errors.ForEach(x => sb.AppendLine(x.ToString()));
            if (!result.IsValid)
            {
                throw new Exception(sb.ToString());
            }
            if (entity != null)
            {
                _repository.Update(entity);
                _repository.SaveChanges();
            }

        }
        public Employee GetEmployeeByTcAndPassword(string tcNo, string password)
        {
            return _repository
                .Find(e => e.TcNo == tcNo && e.Password == password)
                .FirstOrDefault();
        }
		public List<Employee> GetEmployeesByDepartment(string departmentName)
		{
			return _repository.GetAll().Where(e => e.Department != null && e.Department.Name == departmentName).ToList();
		}
		public void UpdateEmployee(Employee employee)
		{
			_repository.Update(employee);
			_repository.SaveChanges();
		}
		public Employee GetEmployeeByTcNo(string tcNo)
		{
			return _repository.GetAll().FirstOrDefault(e => e.TcNo == tcNo);
		}

        public List<Employee> GetAllEmployeesWithDepartment()
        {
            return _repository.GetAllEmployeesWithDepartment();
        }

        public List<Employee> GetEmployeesByDepartmentId(Guid departmanId)
        {
            return _repository.GetAll().Where(e => e.Department != null && e.Department.Id == departmanId).ToList();
        }


        public List<Employee> GetEmployeesByDepartmentName(string departmentName)
        {
            return _repository.GetAll() // Tüm çalışanları al
                .Where(e => e.Department.Name == departmentName) // Departmana göre filtrele
                .ToList();
        }
    }
}
