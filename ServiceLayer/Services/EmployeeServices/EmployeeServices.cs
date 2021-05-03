using DomainLayer.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.EmployeeServices
{
    public class EmployeeServices: IEmployeeServices, IEmployeeRepository
    {

        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeServices(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public void Add(IEmployeeModel departmentModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEmployeeModel departmentModel)
        {
            throw new NotImplementedException();
        }

        public IEmployeeModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(IEmployeeModel departmentModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEmployeeModel> GetAll()
        {
            return _employeeRepository.GetAll();
        }
        List<EmployeeSelectDto> IEmployeeServices.GetEmployeeSelectList()
        {
            List<EmployeeModel> AllEmployees = (List<EmployeeModel>)GetAll();
            List<EmployeeSelectDto> employeeMinimumDetailDtoList = new List<EmployeeSelectDto>();

            foreach (EmployeeModel employeeModel in AllEmployees)
            {
                EmployeeSelectDto employeeMinimumDetailDto = new EmployeeSelectDto();
                employeeMinimumDetailDto.Id = employeeModel.EmployeeId;
                employeeMinimumDetailDto.Name = employeeModel.Name;
                employeeMinimumDetailDto.Country = employeeModel.Location;
                employeeMinimumDetailDto.Designation = employeeModel.Designation!=""?employeeModel.Designation:"N/A";
                employeeMinimumDetailDto.DepartmentId = employeeModel.DepartmentId;
                employeeMinimumDetailDtoList.Add(employeeMinimumDetailDto);
            }
            return employeeMinimumDetailDtoList;
        }
    }
}
