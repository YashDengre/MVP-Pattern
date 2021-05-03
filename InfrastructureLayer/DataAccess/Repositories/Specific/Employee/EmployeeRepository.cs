using CommonComponents;
using DomainLayer.Models.Employees;
using ServiceLayer.Services.EmployeeServices;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.DataAccess.Repositories.Specific.Employee
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private string _connectionString;
        public EmployeeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(IEmployeeModel departmentModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEmployeeModel departmentModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEmployeeModel> GetAll()
        {
            List<EmployeeModel> employeeModelList = new List<EmployeeModel>();
            DataAccessStatus dataAccessStatus = new DataAccessStatus();

            using (SQLiteConnection sqlLiteConnection = new SQLiteConnection(_connectionString))
            {
                try
                {
                    string sql = "SELECT * FROM EMPLOYEES";

                    sqlLiteConnection.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, sqlLiteConnection))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EmployeeModel employeeModel = new EmployeeModel();
                                employeeModel.EmployeeId = Int32.Parse(reader["Id"].ToString());
                                employeeModel.Name = reader["Name"].ToString();
                                employeeModel.Location = reader["Location"].ToString();
                                employeeModel.PhoneNumber = reader["Mobile"].ToString();
                                employeeModel.Designation = reader["Designation"].ToString();
                                employeeModel.DepartmentId = Int32.Parse(reader["DepartmentId"].ToString());
                                employeeModel.JobLocation = reader["JobLocation"].ToString();
                                employeeModelList.Add(employeeModel);
                            }
                        }
                        sqlLiteConnection.Close();
                    }
                }
                catch (SQLiteException e)
                {
                    dataAccessStatus.setValues(status: "Error", operationSucceeded: false, exceptionMessage: e.Message, customMessage: "Unable to get Department Model list from database", helpLink: e.HelpLink, errorCode: e.ErrorCode, stackTrace: e.StackTrace);
                    throw new DataAccessException(e.Message, e.InnerException, dataAccessStatus);
                }
                return employeeModelList;
            }
        }

        public IEmployeeModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(IEmployeeModel departmentModel)
        {
            throw new NotImplementedException();
        }
    }
}
