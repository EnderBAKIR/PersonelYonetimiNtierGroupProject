using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierArchitecture.Entities.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Salary { get; set; }
        public string TcNo { get; set; }
        public DateTime BirthDate { get; set; }
        public string Adress { get; set; }

    }
}
