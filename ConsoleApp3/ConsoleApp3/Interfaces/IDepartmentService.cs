using ConsoleApp3.Classes;

namespace ConsoleApp3.Interfaces;

public interface IDepartmentService
{
    void SetHead(Instructor head);
    void AddCourse(Course course);

    List<Course> GetAllCourses();
}