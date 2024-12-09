using FluentValidation.Results;
using NtierArchitecture.Business.IServices;
using NtierArchitecture.Business.Validators;
using NtierArchitecture.DataAccess.Repositories;
using NtierArchitecture.Entities.Models;
using System.Linq.Expressions;
using System.Text;

namespace NtierArchitecture.Business.Services
{
    public class SalaryTrackingService : IService<SalaryTracking>
    {
        private readonly SalaryTrackingRepository _repository;
        public SalaryTrackingService(SalaryTrackingRepository catRepo)
        {
            _repository = catRepo;
        }
        public void Create(SalaryTracking entity)
        {


            //Install-Package FluentValidation
            SalaryTrackingValidator cval = new();
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

        public IEnumerable<SalaryTracking> GetAll()
        {
            return _repository.GetAll();
        }

        public SalaryTracking GetByID(Guid Id)
        {
            return _repository.GetByID(Id);
        }

        public bool IfEntityExists(Expression<Func<SalaryTracking, bool>> filter)
        {
            return _repository.IfEntityExists(filter);
        }

        public void Update(SalaryTracking entity)
        {
            if (entity != null)
            {
                _repository.Update(entity);
            }

        }

        public bool IsSalaryPaid(Guid employeeId, int month, int year)
        {
            
            var salaryTracking = _repository.GetAll()
                .FirstOrDefault(st => st.EmployeeId == employeeId && st.PaymentMonth == month && st.PaymentYear == year);

            
            if (salaryTracking == null)
            {
                return false;
            }

            
            return salaryTracking.IsPayed;
        }

        public void MarkSalaryAsPaid(Guid employeeId)
        {
            _repository.MarkSalaryAsPaid(employeeId);
        }
    }
}
