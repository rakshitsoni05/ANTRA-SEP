using EntityFramework.Core.Entities;
using EntityFramework.Core.Models.RequestModel;
using EntityFramework.Core.Models.ResponseModel;
using EntityFramework.Infrastructure.Repository;
using EntityFramework.Infrastructure.Services;

namespace EntityFramework.Presentation.UI;

public class ManageDepartment
{
    private DepartmentService _departmentService = new DepartmentService();
    
    
    private void AddDepartment()
    {
        DepartmentRequestModel departmentRequestModel = new DepartmentRequestModel();
        Console.WriteLine("Enter Department Name =>");
        departmentRequestModel.DepartmentName = Console.ReadLine();
        Console.WriteLine("Enter Location =>");
        departmentRequestModel.Location = Console.ReadLine();
        Console.WriteLine(_departmentService.AddDepartment(departmentRequestModel));
        

    }

    public void DeleteDepartment()
    {
        Console.WriteLine("Enter Department Id =>");
        int Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(_departmentService.DeleteDepartmentById(Id));
    }


    private void UpdateDepartment()
    {
        DepartmentRequestModel departmentRequestModel = new DepartmentRequestModel();
        Console.WriteLine("Enter Id =>");
        int Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Department Name =>");
        departmentRequestModel.DepartmentName = Console.ReadLine();
        Console.WriteLine("Enter Location =>");
        departmentRequestModel.Location = Console.ReadLine();
        Console.WriteLine(_departmentService.UpdateDepartmentById(Id, departmentRequestModel));
    }


    private void PrintAllDepartment()
    {
        var departments = _departmentService.GetAllDepartments();
        foreach (var dep in departments)
        {
            Console.WriteLine(dep.DepartmentName + "\t" + dep.Location);
        }
    }

    private void GetDepartmentById()
    {
        Console.WriteLine("Enter Department Id =>");
        int Id = Convert.ToInt32(Console.ReadLine());
        var department = _departmentService.GetById(Id);
        Console.WriteLine(department.DepartmentName+"\t"+department.Location);
    }


    public void Run()
    {
        // AddDepartment();
        // DeleteDepartment();
        UpdateDepartment();
        // PrintAllDepartment();
        // GetDepartmentById();
    }
}