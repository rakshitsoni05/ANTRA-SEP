using EntityFramework.Core.Entities;
using EntityFramework.Core.Interfaces.Services;
using EntityFramework.Core.Models.RequestModel;
using EntityFramework.Core.Models.ResponseModel;
using EntityFramework.Infrastructure.Repository;

namespace EntityFramework.Infrastructure.Services;

public class EmployeeService: IEmployeeService
{
    private EmployeeRepository _employeeRepository = new EmployeeRepository();
    
    public List<EmployeeResponseModel> GetAllEmployees()
    {
        var employees = _employeeRepository.GetAll();
        var employeeResponseModels = new List<EmployeeResponseModel>();
        foreach (var employee in employees)
        {
            employeeResponseModels.Add(new EmployeeResponseModel()
            {
                EmployeeName = employee.EmployeeName,
                Age = employee.Age
            });
        }

        return employeeResponseModels;
    }

    public EmployeeResponseModel GetById(int id)
    {
        var employees = _employeeRepository.GetById(id);
        if (employees != null)
        {
            var employeeResponseModels = new EmployeeResponseModel()
            {
                EmployeeName = employees.EmployeeName,
                Age = employees.Age
            };
            return employeeResponseModels;
        }

        return null;

    }

    public int AddEmployee(EmployeeRequestModel model)
    {
        var employeeEntity = new Employee
        {
            EmployeeName = model.EmployeeName,
            Age = model.Age,
            DepartmentID = 1
        };
        return _employeeRepository.Insert(employeeEntity);
    }
    
    
    public int DeleteEmployeeById(int id)
    {
        return _employeeRepository.DeleteById(id);
    }
    
    public int UpdateEmployeeById(int id, EmployeeRequestModel model)
    {
        var employeeEntity = new Employee()
        {
            Id = id,
            EmployeeName = model.EmployeeName,
            Age = model.Age,
            DepartmentID = 1
        };
        return _employeeRepository.Update(employeeEntity);
    }
}