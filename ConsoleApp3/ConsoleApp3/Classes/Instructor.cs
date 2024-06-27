using ConsoleApp3.Interfaces;

namespace ConsoleApp3.Classes;

public class Instructor : Person, IInstructorService
{
    public Department Department { get;  set; }
    public DateTime JoinDate { get; private set; }

    public Instructor(string name, DateTime dateOfBirth, decimal salary, DateTime joinDate)
        : base(name, dateOfBirth, salary)
    {
        JoinDate = joinDate;
    }

    public void AssignDepartment(Department department)
    {
        Department = department;
        if (department.Head == null)
        {
            department.SetHead(this);
        }
    }

    public decimal CalculateBonus()
    {
        int experienceYears = DateTime.Now.Year - JoinDate.Year;
        return experienceYears * 1000;
    }

    public override decimal CalculateSalary()
    {
        return base.CalculateSalary() + CalculateBonus(); 
    }
}