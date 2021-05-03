using DomainLayer.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.EmployeeServices
{
    public interface IEmployeeRepository
    {
        void Add(IEmployeeModel departmentModel);
        void Update(IEmployeeModel departmentModel);
        void Delete(IEmployeeModel departmentModel);

        IEnumerable<IEmployeeModel> GetAll();

        IEmployeeModel GetById(int id);
    }
}
