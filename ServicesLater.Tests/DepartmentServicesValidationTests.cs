using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace ServicesLayer.Tests
{
    [Trait("Category","Model Validation")]
    public class DepartmentServicesValidationTests: IClassFixture<DepartmentServicesFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private DepartmentServicesFixture _departmentServicesFixture;
        public DepartmentServicesValidationTests(DepartmentServicesFixture departmentServicesFixture, ITestOutputHelper testOutputHelper)
        {
            _departmentServicesFixture = departmentServicesFixture;
            _testOutputHelper = testOutputHelper;
            SetValidSampleValues();
        }

        private void SetValidSampleValues()
        {
            _departmentServicesFixture.DepartmentModel.DepartmentId = 1;
            _departmentServicesFixture.DepartmentModel.CityLocation = "Cochin";
            _departmentServicesFixture.DepartmentModel.DepartmentName = "Accounting";
            _departmentServicesFixture.DepartmentModel.Email = "accounting01@company.com";
            _departmentServicesFixture.DepartmentModel.PhoneNumber = "11122235";
            _departmentServicesFixture.DepartmentModel.StateLocation = "Kerala";
            _departmentServicesFixture.DepartmentModel.DepartmentUrl = "www.Accounting.co.in";

        }

        [Fact]
        public void ShouldNotThrowExceptionForDefaultTestValuesOnAnnotations()
        {
            var exception = Record.Exception(()=> _departmentServicesFixture.DepartmentServices.ValidateModelDataAnnotaions
            (_departmentServicesFixture.DepartmentModel));
            Assert.Null(exception);
            WriteExceptionTestResult(exception);
        }

        private void WriteExceptionTestResult(Exception exception)
        {
            if (exception !=null)
            {
                _testOutputHelper.WriteLine(exception.Message);
            }
            else
            {
                StringBuilder stringBuilder = new StringBuilder();
                JObject json = JObject.FromObject(_departmentServicesFixture.DepartmentModel);
                stringBuilder.Append("****** No Exception Was Thrown ******").AppendLine();
                foreach(JProperty jProperty in json.Properties())
                {
                    stringBuilder.Append(jProperty.Name).Append("-->").Append(jProperty.Value).AppendLine();
                }
                _testOutputHelper.WriteLine(stringBuilder.ToString());
            }
        }
    }
}
