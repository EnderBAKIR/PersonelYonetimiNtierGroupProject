using NtierArchitecture.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierArchitecture.Entities.Models
{
    public class Leave : BaseEntity
    {
        public int Day { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public LeaveStatus Status { get; set; }
    }

    public enum LeaveStatus
    {
        Pending = 0,       // Bekleniyor
        Approved = 1,      // Onaylandı
        Rejected = 2,      // Onaylanmadı
        Expired = 3        // Süresi Geçti
    }
}
