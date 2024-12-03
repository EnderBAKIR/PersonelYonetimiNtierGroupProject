using FluentValidation;
using NtierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierArchitecture.Business.Validators
{
    public class LeaveValidator : AbstractValidator<Leave>
    {
        public LeaveValidator()
        {
            RuleFor(leave => leave.Day)
            .GreaterThan(0).WithMessage("İzin günü sayısı 0'dan büyük olmalıdır.");


            RuleFor(leave => leave.Description)
                .NotEmpty().WithMessage("İzin açıklaması boş olamaz.")
                .Length(5, 250).WithMessage("İzin açıklaması en az 5, en fazla 250 karakter olmalıdır.");


            RuleFor(leave => leave.StartDate)
        .GreaterThanOrEqualTo(DateTime.Today).WithMessage("Başlangıç tarihi bugünden önce olamaz.")
        .LessThanOrEqualTo(leave => leave.EndDate).WithMessage("Başlangıç tarihi, bitiş tarihinden önce veya aynı olmalıdır.");

            RuleFor(leave => leave.EndDate)
           .GreaterThanOrEqualTo(leave => leave.StartDate).WithMessage("Bitiş tarihi, başlangıç tarihinden önce olamaz.");


            RuleFor(leave => leave.EmployeeId)
                .NotEmpty().WithMessage("Çalışan ID'si boş olamaz.");

            RuleFor(leave => leave.Day)
        .LessThanOrEqualTo(leave => (leave.EndDate - leave.StartDate).Days + 1)
        .WithMessage("İzin günü sayısı, başlangıç ve bitiş tarihleri arasındaki gün sayısını aşamaz.");

            RuleFor(leave => leave.Day)
        .GreaterThanOrEqualTo(leave => (leave.EndDate - leave.StartDate).Days + 1)
        .WithMessage("İzin günü sayısı, başlangıç ve bitiş tarihleri arasındaki gün sayısından az olamaz.");
        }
    }
}
