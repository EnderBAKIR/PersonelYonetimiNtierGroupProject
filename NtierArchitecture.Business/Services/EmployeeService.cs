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

            //Install-Package FluentValidation
            EmployeeValidator cval = new();
            ValidationResult result = cval.Validate(entity);
            StringBuilder sb = new();
            result.Errors.ForEach(x => sb.AppendLine(x.ToString()));

            if (!result.IsValid)
            {
                //throw new Exception(string.Join(",", result.Errors));
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
            if (entity != null)
            {
                _repository.Update(entity);
            }

        }
    }
}
