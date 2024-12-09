using FluentValidation;
using FluentValidation.Results;
using NtierArchitecture.Business.IServices;
using NtierArchitecture.Business.Validators;
using NtierArchitecture.DataAccess.Repositories;
using NtierArchitecture.Entities.Models;
using System.Linq.Expressions;
using System.Text;


namespace NtierArchitecture.Business.Services
{
    public class DepartmentService : IService<Department>
    {
        private readonly DepartmentRepository _repository;
        public DepartmentService(DepartmentRepository catRepo)
        {
            _repository = catRepo;
        }
        public void Create(Department entity)
        {
            if (IfEntityExists(c => c.Name == entity.Name))
            {
                throw new Exception("Bu departman daha önce kayıt edilmiştir.");
            }

            //Install-Package FluentValidation
            DepartmentValidator cval = new();
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
                throw new Exception("Aktif olan bir departman silinemez.");
            }

            _repository.Delete(Id);
        }

        public IEnumerable<Department> GetAll()
        {
            return _repository.GetAll();
        }

        public Department GetByID(Guid Id)
        {
            return _repository.GetByID(Id);
        }

        public bool IfEntityExists(Expression<Func<Department, bool>> filter)
        {
            return _repository.IfEntityExists(filter);
        }

        public void Update(Department entity)
        {
            DepartmentValidator cval = new();
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
            }

        }
    }
}
