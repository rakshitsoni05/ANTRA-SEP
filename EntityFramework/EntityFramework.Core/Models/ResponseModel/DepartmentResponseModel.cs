using EntityFramework.Core.Entities;

namespace EntityFramework.Core.Models.ResponseModel;

public class DepartmentResponseModel
{
    public string? DepartmentName { get; set; }
    public string? Location { get; set; }
    public List<Employee> Employees { get; set; }
}