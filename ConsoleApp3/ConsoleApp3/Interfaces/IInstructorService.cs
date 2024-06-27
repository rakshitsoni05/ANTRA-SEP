using ConsoleApp3.Classes;

namespace ConsoleApp3.Interfaces;

public interface IInstructorService : IPersonService
{
    void AssignDepartment(Department department);
    decimal CalculateBonus();
}