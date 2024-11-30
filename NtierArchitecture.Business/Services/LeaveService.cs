using FluentValidation.Results;
using NtierArchitecture.Business.IServices;
using NtierArchitecture.Business.Validators;
using NtierArchitecture.DataAccess.Repositories;
using NtierArchitecture.Entities.Models;
using System.Linq.Expressions;
using System.Text;

namespace NtierArchitecture.Business.Services
{
    public class LeaveService : IService<Leave>
    {
        private readonly LeaveRepository _repository;
        public LeaveService(LeaveRepository catRepo)
        {
            _repository = catRepo;
        }
        public void Create(Leave entity)
        {
            if (IfEntityExists(c => c.Id == entity.Id))
            {
                throw new Exception("Bu İzin daha önce kayıt edilmiştir.");
            }

            //Install-Package FluentValidation
            LeaveValidator cval = new();
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
                throw new Exception("Aktif olan bir İzin silinemez.");
            }

            _repository.Delete(Id);
        }

        public IEnumerable<Leave> GetAll()
        {
            return _repository.GetAll();
        }

        public Leave GetByID(Guid Id)
        {
            return _repository.GetByID(Id);
        }

        public bool IfEntityExists(Expression<Func<Leave, bool>> filter)
        {
            return _repository.IfEntityExists(filter);
        }

        public void Update(Leave entity)
        {
            if (entity != null)
            {
                _repository.Update(entity);
            }

        }
    }
}
