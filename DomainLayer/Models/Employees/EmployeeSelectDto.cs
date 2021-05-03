
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.Employees
{
    public class EmployeeSelectDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Designation { get; set; }
        public int DepartmentId { get; set; }
    }
}
