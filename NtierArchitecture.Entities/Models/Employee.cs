using NtierArchitecture.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierArchitecture.Entities.Models
{
    public class Employee: BaseEntity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Password { get; set; }
        public double? Salary { get; set; }
        public string? TcNo { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Adress { get; set; }
        public string? Tel { get; set; }
        public Department? Department { get; set; }
        public Guid? DepartmentId { get; set; }
        public Discontinuity? Discontinuity { get; set; }
        public Guid? DiscontinuityId { get; set; }
        public ICollection<Leave>? Leaves { get; set; }

        public ICollection<SalaryTracking>? SalaryTrackings { get; set; }
        public string FullNameWithTc => $"{Name} {Surname} - {TcNo}";

    }
}
