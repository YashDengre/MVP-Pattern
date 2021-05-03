using DomainLayer.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.EmployeeServices
{
    public interface IEmployeeServices
    {
        List<EmployeeSelectDto> GetEmployeeSelectList();
    }
}
