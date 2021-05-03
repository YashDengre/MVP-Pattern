namespace DomainLayer.Models.Department
{
    public interface IDepartmentModel
    {
        string CityLocation { get; set; }
        int DepartmentId { get; set; }
        string DepartmentName { get; set; }
        string DepartmentUrl { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        string StateLocation { get; set; }
    }
}