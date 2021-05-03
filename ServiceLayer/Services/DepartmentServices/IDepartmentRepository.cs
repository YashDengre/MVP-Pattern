using DomainLayer.Models.Department;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Services.DepartmentServices
{
    public interface IDepartmentRepository
    {
        void Add(IDepartmentModel departmentModel);
        void Update(IDepartmentModel departmentModel);
        void Delete(IDepartmentModel departmentModel);

        IEnumerable<IDepartmentModel> GetAll();

        DepartmentModel GetById(int id);


    }
}
