using EntityFramework.Core.Models.RequestModel;
using EntityFramework.Infrastructure.Services;

namespace EntityFramework.Presentation.UI;

public class ManageEmployee
{
    private EmployeeService _employeeService = new EmployeeService();

    private void AddEmployee()
    {
        EmployeeRequestModel employeeRequestModel = new EmployeeRequestModel();
        Console.WriteLine("Please enter employee name: ");
        employeeRequestModel.EmployeeName = Console.ReadLine();
        Console.WriteLine("Please enter employee age: ");
        employeeRequestModel.Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(_employeeService.AddEmployee(employeeRequestModel));

    }
    
    public void DeleteEmployee()
    {
        Console.WriteLine("Enter Employee Id =>");
        int Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(_employeeService.DeleteEmployeeById(Id));
    }
    
    
    private void UpdateEmployee()
    {
        EmployeeRequestModel employeeRequestModel = new EmployeeRequestModel();
        Console.WriteLine("Enter Id =>");
        int Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Name =>");
        employeeRequestModel.EmployeeName = Console.ReadLine();
        Console.WriteLine("Enter Age =>");
        employeeRequestModel.Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(_employeeService.UpdateEmployeeById(Id, employeeRequestModel));
    }

    private void PrintAllEmployee()
    {
        var employees = _employeeService.GetAllEmployees();
        foreach (var employee in employees)
        {
            Console.WriteLine(employee.EmployeeName+"\t"+employee.Age);
        }

    }

    private void GetEmployeeById()
    {
        Console.WriteLine("Please enter employee id: ");
        int id = Convert.ToInt32(Console.ReadLine());
        var employee = _employeeService.GetById(id);
        Console.WriteLine(employee.EmployeeName+"\t"+employee.Age);

    }

    public void Run()
    {
        // AddEmployee();
        // PrintAllEmployee();
        // GetEmployeeById();
        // DeleteEmployee();
        UpdateEmployee();


    }
}