using System;

namespace WebAPI.DTO
{
    public class EmployeeResult
    {
        public int Id { get; set; }

        public string Department { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public DateTime DateOfEmployment { get; set; }

        public double Salary { get; set; }
    }
}
