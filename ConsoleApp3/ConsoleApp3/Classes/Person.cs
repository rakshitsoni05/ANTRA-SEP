using ConsoleApp3.Interfaces;

namespace ConsoleApp3.Classes;

public abstract class Person : IPersonService
{
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    
    public List<string> Addresses  = new List<string>();
    public decimal Salary { get;  set; }

    public Person(string name, DateTime dateOfBirth, decimal salary)
    {
        Name = name;
        DateOfBirth = dateOfBirth;
        Salary = salary >= 0 ? salary : throw new ArgumentOutOfRangeException("Salary cannot be negative");
    }

    public int CalculateAge()
    {
        var today = DateTime.Today;
        var age = today.Year - DateOfBirth.Year;
        if (DateOfBirth.Date > today.AddYears(-age)) age--;
        return age;
    }

    public virtual decimal CalculateSalary()
    {
        return Salary;
    }

    public List<string> GetAddresses()
    {
        return Addresses;
    }

    public void AddAddress(string address)
    {
        Addresses.Add(address);
    }
}
