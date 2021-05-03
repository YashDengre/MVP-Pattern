using DomainLayer.Models.Department;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Services.DepartmentServices
{
    public interface IDepartmentService
    {
        void ValidateModel(IDepartmentModel departmentModel);
        List<DepartmentSelectDto> GetDepartmentSelectList();
    }
}
