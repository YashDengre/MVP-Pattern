namespace DomainLayer.Models.Employees
{
    public interface IEmployeeModel
    {
        int EmployeeId { get; set; }
        string Name { get; set; }
        string Location { get; set; }
        int DepartmentId { get; set; }
        string JobLocation { get; set; }
        string Designation { get; set; }
        string PhoneNumber { get; set; }
    }
}