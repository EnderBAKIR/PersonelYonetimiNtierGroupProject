using FluentValidation;
using NtierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierArchitecture.Business.Validators
{
    public class DepartmentValidator : AbstractValidator<Department>
    {
        public DepartmentValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Departman alanı boş geçilemez.")
                .MinimumLength(5).WithMessage("Departman adı minimum 2 karakter olmadılıdır.")
                .MaximumLength(25).WithMessage("Departman adı maximum 50 karakter olmadılıdır.")
                .Matches("^[a-zA-ZğüşıöçĞÜŞİÖÇ\\s]+$").WithMessage("Lütfen sadece harf girişi yapınız.");

            
        }
    }
}
