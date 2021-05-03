
using CommonComponents;
using DomainLayer.Models.Department;
using InfrastructureLayer.DataAccess.Repositories.Specific;
using InfrastructureLayer.DataAccess.Repositories.Specific.Department;
using Newtonsoft.Json.Linq;
using ServiceLayer.CommonServices;
using ServiceLayer.Services.DepartmentServices;
using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace ServicesLayer.Tests
{
    [Trait("Category", "Data Access Validations")]
    public class DepartmentServicesDataAccessTests
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private DepartmentServices _departmentServices;
        private string _connectionString;
        public DepartmentServicesDataAccessTests(ITestOutputHelper testOutputHelper)
        {
            _connectionString = "Data Source=" +
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\MVPAppiDemo-UnitTest\MVPDemo.sqlite;Version = 3;";
            _testOutputHelper = testOutputHelper;
            _departmentServices = new DepartmentServices(new DepartmentRepository(_connectionString), new ModelDataAnnotationCheck());
        }

        [Fact]
        public void ShouldReturnListOfDepartments()
        {
            List<DepartmentModel> departmentModelList = (List<DepartmentModel>)_departmentServices.GetAll();

            Assert.NotEmpty(departmentModelList);

            foreach (DepartmentModel dm in departmentModelList)
            {
                _testOutputHelper.WriteLine($"Name: {dm.DepartmentName}\nCity: {dm.CityLocation}\nState: {dm.StateLocation}\nPhone: {dm.PhoneNumber}\n");
            }
        }

        [Fact]
        public void ShouldReturnDepartmentModelMatchingId()
        {
            DepartmentModel departmentModel = null;
            int idToGet = 2;
            try
            {
                departmentModel = _departmentServices.GetById(idToGet);
            }
            catch (DataAccessException dae)
            {
                _testOutputHelper.WriteLine(dae.DataAccessStatusInfo.getFormattedValues());
            }

            Assert.True(departmentModel != null);
            Assert.True(idToGet == departmentModel.DepartmentId);

            if (departmentModel != null)
            {
                string departmentModelJsonStr = Newtonsoft.Json.JsonConvert.SerializeObject(departmentModel);
                string formattedJsonStr = JToken.Parse(departmentModelJsonStr).ToString();
                _testOutputHelper.WriteLine(formattedJsonStr);
            }


        }

        #region TC 
        //[Fact]
        //public void ShouldReturnSuccessForAdd()
        //{
        //    DepartmentModel dm = new DepartmentModel() { DepartmentName = "Graphics(Unit Test)", CityLocation = "Denver", DepartmentUrl = "http://sofware.com/graphics", Email = "graphics@software.com", PhoneNumber = "2134448888", StateLocation = "MH" };

        //    bool operationSucceeded = false;
        //    string dataAccessStatusJsonStr = string.Empty;
        //    string formattedJsonStr = string.Empty;

        //    try
        //    {
        //        _departmentServices.Add(dm);
        //        operationSucceeded = true;
        //    }
        //    catch (DataAccessException dataAccessException)
        //    {
        //        operationSucceeded = dataAccessException.DataAccessStatusInfo.OperationSucceeded;
        //        dataAccessStatusJsonStr = Newtonsoft.Json.JsonConvert.SerializeObject(dataAccessException.DataAccessStatusInfo);
        //        formattedJsonStr = JToken.Parse(dataAccessStatusJsonStr).ToString();
        //    }

        //    try
        //    {
        //        Assert.True(operationSucceeded);
        //        _testOutputHelper.WriteLine("The record was successfully added");

        //    }
        //    finally
        //    {
        //        _testOutputHelper.WriteLine(formattedJsonStr);
        //    }
        //}

        //[Fact]
        //public void ShouldReturnSuccessForUpdate()
        //{
        //    DepartmentModel dm = new DepartmentModel() { DepartmentId = 0, DepartmentName = "Graphics(Unit Test)", CityLocation = "Denver", DepartmentUrl = "http://sofware.com/graphics", Email = "art@software.com", PhoneNumber = "114448888", StateLocation = "Kerala" };

        //    bool operationSucceeded = false;
        //    string dataAccessStatusJsonStr = string.Empty;
        //    string formattedJsonStr = string.Empty;

        //    try
        //    {
        //        _departmentServices.Update(dm);
        //        operationSucceeded = true;
        //    }
        //    catch (DataAccessException dataAccessException)
        //    {
        //        operationSucceeded = dataAccessException.DataAccessStatusInfo.OperationSucceeded;
        //        dataAccessStatusJsonStr = Newtonsoft.Json.JsonConvert.SerializeObject(dataAccessException.DataAccessStatusInfo);
        //        formattedJsonStr = JToken.Parse(dataAccessStatusJsonStr).ToString();
        //    }

        //    try
        //    {
        //        Assert.True(operationSucceeded);
        //        _testOutputHelper.WriteLine("The record was successfully updated");

        //    }
        //    finally
        //    {
        //        _testOutputHelper.WriteLine(formattedJsonStr);
        //    }
        //}
        //[Fact]
        //public void ShouldReturnSuccessForDelete()
        //{
        //    DepartmentModel dm = new DepartmentModel() { DepartmentId = 47, DepartmentName = "Graphics(Unit Test)", CityLocation = "Denver", DepartmentUrl = "http://sofware.com/graphics", Email = "graphics@software.com", PhoneNumber = "213-444-8888", StateLocation = "Utah" };

        //    bool operationSucceeded = false;
        //    string dataAccessStatusJsonStr = string.Empty;
        //    string formattedJsonStr = string.Empty;

        //    try
        //    {
        //        _departmentServices.Delete(dm);
        //        operationSucceeded = true;
        //    }
        //    catch (DataAccessException dataAccessException)
        //    {
        //        operationSucceeded = dataAccessException.DataAccessStatusInfo.OperationSucceeded;
        //        dataAccessStatusJsonStr = Newtonsoft.Json.JsonConvert.SerializeObject(dataAccessException.DataAccessStatusInfo);
        //        formattedJsonStr = JToken.Parse(dataAccessStatusJsonStr).ToString();
        //    }

        //    try
        //    {
        //        Assert.True(operationSucceeded);
        //        _testOutputHelper.WriteLine("The record was successfully deleted");

        //    }
        //    finally
        //    {
        //        _testOutputHelper.WriteLine(formattedJsonStr);
        //    }
        //}
        #endregion




    }
}
