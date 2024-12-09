using FluentValidation;
using NtierArchitecture.Entities.Models;


namespace NtierArchitecture.Business.Validators
{
    public class SalaryTrackingValidator : AbstractValidator<SalaryTracking>
    {
        public SalaryTrackingValidator()
        {
            
            RuleFor(x => x.IsPayed)
                .NotNull().WithMessage("Ödeme durumu belirtilmeli.");

            
            RuleFor(x => x.PaymentMonth)
                .NotNull().WithMessage("Ödeme ayı belirtilmeli.")
                .InclusiveBetween(1, 12).WithMessage("Geçerli bir ay seçilmeli (1-12).");

            
            RuleFor(x => x.PaymentYear)
                .NotNull().WithMessage("Ödeme yılı belirtilmeli.")
                .GreaterThan(1900).WithMessage("Geçerli bir yıl girilmeli.")
                .LessThanOrEqualTo(DateTime.Now.Year).WithMessage("Gelecek yıl için ödeme yapılmaz.");

           
            RuleFor(x => x.EmployeeId)
                .NotNull().WithMessage("Çalışan seçilmeli.");

            
            RuleFor(x => new { x.PaymentMonth, x.PaymentYear })
                .Must(x => IsValidPaymentDate(x.PaymentMonth, x.PaymentYear))
                .WithMessage("Ödeme tarihi geçersiz.");
        }

        
        private bool IsValidPaymentDate(int? month, int? year)
        {
            if (month.HasValue && year.HasValue)
            {
                DateTime paymentDate = new DateTime(year.Value, month.Value, 1);
                return paymentDate <= DateTime.Now;
            }
            return false;
        }
    }
}
