using DomainLayer.Models.Department;
using ServiceLayer.CommonServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ServiceLayer.Services.DepartmentServices
{
    public class DepartmentServices : IDepartmentService, IDepartmentRepository
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IModelDataAnnotationCheck _modelDataAnnotationCheck;

        public DepartmentServices(IDepartmentRepository departmentRepository, IModelDataAnnotationCheck modelDataAnnotationCheck)
        {
            _departmentRepository = departmentRepository;
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
        }

        public void Add(IDepartmentModel departmentModel)
        {
            ValidateModel(departmentModel);
            _departmentRepository.Add(departmentModel);
        }

        public void Delete(IDepartmentModel departmentModel)
        {
            _departmentRepository.Delete(departmentModel);
        }

        public IEnumerable<IDepartmentModel> GetAll()
        {
            return _departmentRepository.GetAll();
        }

        public DepartmentModel GetById(int id)
        {
            return _departmentRepository.GetById(id);
        }

        public void Update(IDepartmentModel departmentModel)
        {

            ValidateModel(departmentModel);
            _departmentRepository.Update(departmentModel);
        }

        public void ValidateModel(IDepartmentModel departmentModel)
        {
            _modelDataAnnotationCheck.ValidateModelDataAnnotaions(departmentModel);
            ValidateDepartmentUrl(departmentModel);
        }
        public void ValidateModelDataAnnotaions(IDepartmentModel departmentModel)
        {
            _modelDataAnnotationCheck.ValidateModelDataAnnotaions(departmentModel);
        }


        public void ValidateDepartmentUrl(IDepartmentModel departmentModel)
        {
            StringBuilder errorStringBuilder = new StringBuilder();
            Uri uriAddress = new Uri(departmentModel.DepartmentUrl);
            string domainExtension = (Path.GetExtension(uriAddress.Host.ToString())).Trim().ToLower();
            if (!".com .net".Contains(domainExtension))
            {
                errorStringBuilder.Append("URl domain extension can only be .com or .net").AppendLine();
            }
            if (departmentModel.DepartmentUrl.Length < 7 || departmentModel.DepartmentUrl.Length > 30)
            {
                errorStringBuilder.Append("Department URL must be form 7 to 30 characters").AppendLine();
            }
            if (uriAddress.GetLeftPart(UriPartial.Scheme) != "http://")
            {
                errorStringBuilder.Append($"Department URL must start with http://").AppendLine();
            }
            if (errorStringBuilder.Length > 0)
            {
                throw new ArgumentException($"{errorStringBuilder.ToString()}");
            }
        }

        public List<DepartmentSelectDto> GetDepartmentSelectList()
        {
            List<DepartmentModel> AllDepartments = (List<DepartmentModel>)GetAll();
            List<DepartmentSelectDto> departmentMinimumDetailDtoList = new List<DepartmentSelectDto>();

            foreach (DepartmentModel departmentModel in AllDepartments)
            {
                DepartmentSelectDto departmentMinimumDetailDto = new DepartmentSelectDto();
                departmentMinimumDetailDto.DepartmentId = departmentModel.DepartmentId;
                departmentMinimumDetailDto.DepartmentName = departmentModel.DepartmentName;
                departmentMinimumDetailDto.CityLocation = departmentModel.CityLocation;
                departmentMinimumDetailDto.StateLocation = departmentModel.StateLocation;
                departmentMinimumDetailDtoList.Add(departmentMinimumDetailDto);
            }
            return departmentMinimumDetailDtoList;
        }
    }
}
