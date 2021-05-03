using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DomainLayer.Models.Employees
{
    public class EmployeeModel : IEmployeeModel
    {
        public int DepartmentId { get; set; }
        public string PhoneNumber { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string JobLocation { get; set; }
        public string Designation { get; set; }
    }
}
