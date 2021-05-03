using DomainLayer.Models.Department;
using ServiceLayer.CommonServices;
using ServiceLayer.Services.DepartmentServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.Tests
{
    public class DepartmentServicesFixture
    {
        private  IDepartmentService _departmentServices;
        private  IDepartmentModel _departmentModel;
        public DepartmentServicesFixture()
        {
            _departmentServices = new DepartmentServices(null, new ModelDataAnnotationCheck());
            _departmentModel = new DepartmentModel();

        }

        public DepartmentModel DepartmentModel
        {
            get { return (DepartmentModel)_departmentModel; }
            set { _departmentModel = value; }
        }
        public DepartmentServices DepartmentServices
        {
            get { return (DepartmentServices)_departmentServices; }
            set { _departmentServices = value; }
        }


    }
}
