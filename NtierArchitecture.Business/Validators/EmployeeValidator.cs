using FluentValidation;
using NtierArchitecture.Entities.Models;

namespace NtierArchitecture.Business.Validators
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
           // RuleFor(e => e.Name)
           //.NotEmpty().WithMessage("Ad alanı boş bırakılamaz.")
           //.Length(2, 30).WithMessage("Ad en az 2, en fazla 30 karakter olmalıdır.");

           // RuleFor(e => e.Surname)
           //.NotEmpty().WithMessage("Soyad alanı boş bırakılamaz.");

           // RuleFor(e => e.TcNo)
           //.NotEmpty().WithMessage("TC Kimlik No boş bırakılamaz.")
           //.Length(11).WithMessage("TC Kimlik No 11 haneli olmalıdır.");

           // RuleFor(e => e.BirthDate)
           //.NotEmpty().WithMessage("Doğum tarihi boş bırakılamaz.")
           //.LessThan(DateTime.Now).WithMessage("Doğum tarihi bugünden küçük olmalıdır.");

           // RuleFor(e => e.Adress).NotEmpty().WithMessage("Adresinizi giriniz");
           // RuleFor(e => e.Tel).NotEmpty().WithMessage("Telefon numaranızı giriniz").Custom((tel, context) =>
           // {
           //     if (tel.StartsWith("0"))
           //     {
           //         context.AddFailure("Telefon numarasını başında '0' olmadan giriniz.");
           //     }
           // });
        }
    }
}
