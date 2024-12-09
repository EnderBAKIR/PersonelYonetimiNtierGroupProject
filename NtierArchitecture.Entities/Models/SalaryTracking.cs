using NtierArchitecture.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierArchitecture.Entities.Models
{
    public class SalaryTracking : BaseEntity
    {
        public bool IsPayed { get; set; }

        public int? PaymentMonth { get; set; }
        public int? PaymentYear { get; set; }

        public Guid? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
