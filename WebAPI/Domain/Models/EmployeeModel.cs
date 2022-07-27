using System;

namespace WebAPI.Domain.Models
{
    public class EmployeeModel
    {
        public string Department { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public DateTime DateOfEmployment { get; set; }

        public double Salary { get; set; }
    }
}
