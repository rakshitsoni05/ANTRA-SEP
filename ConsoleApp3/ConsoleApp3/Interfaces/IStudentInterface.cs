using ConsoleApp3.Classes;

namespace ConsoleApp3.Interfaces;

public interface IStudentService : IPersonService
{
    void EnrollInCourse(Course course);
    double CalculateGPA();
}